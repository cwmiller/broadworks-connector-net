using BroadWorksConnector.Ocip;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;
using BroadWorksConnector.Ocip.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

[assembly: InternalsVisibleToAttribute("BroadWorksConnector.Tests")]

namespace BroadWorksConnector
{
    /// <summary>
    /// Client for communicating with BroadWorks OCI-P
    /// </summary>
    public class OcipClient : IOcipClient, IDisposable
    {
        private readonly string _username;

        private readonly string _password;

        private readonly string _sessionId;

        internal ITransport Transport { get; private set; }

        private readonly Serializer _serializer;

        public OcipClientOptions Options { get; private set; }

        public UserDetails UserDetails { get; private set; }

        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="url"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public OcipClient(string url, string username, string password) : this(url, username, password, new OcipClientOptions()) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="url"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="options"></param>
        public OcipClient(string url, string username, string password, OcipClientOptions options)
        {
            _username = username;
            _password = password;
            _sessionId = GenerateSessionId();
            _serializer = new Serializer(typeof(AccessDevice).Namespace);
            Options = options;

            var uri = new Uri(url);

            switch (uri.Scheme)
            {
                case "http":
                case "https":
                    Transport = new SoapTransport(uri, options);
                    break;
                case "tcp":
                    Transport = new TcpTransport(uri.Host, uri.Port > -1 ? uri.Port : 2208, false, options);
                    break;
                case "ssl":
                case "sslv2":
                case "sslv3":
                case "tls":
                    Transport = new TcpTransport(uri.Host, uri.Port > -1 ? uri.Port : 2209, true, options);
                    break;
                default:
                    throw new ArgumentException("Unsupported protocol", nameof(url));
            }
        }

        /// <summary>
        /// Execute a single command and receive the response
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="command"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<TResponse> CallAsync<TResponse>(OCIRequest<TResponse> command, CancellationToken cancellationToken = default) where TResponse : OCICommand
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command), "Command cannot be NULL");
            }

            if (UserDetails == null)
            {
                await LoginAsync(cancellationToken).ConfigureAwait(false);
            }

            var responses = await ExecuteCommandsAsync(new List<OCIRequest<TResponse>> { command }, cancellationToken).ConfigureAwait(false);

            return responses.First() as TResponse;
        }

        /// <summary>
        /// Execute multiple commands in a single request
        /// </summary>
        /// <param name="commands"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="LoginException">Thrown when the login to the server fails.</exception>
        /// <exception cref="ValidationException">Thrown when the given request fails local validation.</exception>
        public async Task<BatchResult> CallAllAsync(IEnumerable<OCIRequest> commands, CancellationToken cancellationToken = default)
        {
            if (commands == null)
            {
                throw new ArgumentNullException(nameof(commands), "Command list cannot be NULL");
            }

            if (commands.Count() == 0)
            {
                throw new ArgumentException("Commands list cannot be empty.", nameof(commands));
            }

            // Do not allow duplicates
            if (commands.Distinct().Count() != commands.Count())
            {
                throw new ArgumentException("Commands list cannot have any duplicate entries.", nameof(commands));
            }

            if (UserDetails == null)
            {
                await LoginAsync(cancellationToken).ConfigureAwait(false);
            }

            var responses = await ExecuteCommandsAsync(commands, cancellationToken).ConfigureAwait(false);

            return new BatchResult(commands, responses);
        }

        /// <summary>
        /// All sessions require a session ID to be generated. This is created once and used for all requests.
        /// </summary>
        /// <returns></returns>
        private string GenerateSessionId()
        {
            // Session ID will be a SHA2 hash using a GUID and the hashcode for this instance
            var sha256 = new SHA256Managed();
            var guid = Guid.NewGuid().ToString();
            var hashCode = GetHashCode();

            var input = $"{guid}:{hashCode}";
            var inputBytes = Encoding.ASCII.GetBytes(input);

            var computedHash = sha256.ComputeHash(inputBytes);

            return string.Concat(computedHash.Select(b => b.ToString("x2")));
        }

        /// <summary>
        /// Authenticate against OCI-P using the provided username and password
        /// </summary>
        /// <returns></returns>
        /// <exception cref="LoginException">Thrown when the login to the server fails.</exception>
        public async Task<UserDetails> LoginAsync(CancellationToken cancellationToken = default)
        {
            await _semaphore.WaitAsync();

            if (UserDetails == null)
            {
                try
                {
                    if (Options.MinServerVersion == ServerVersion.R22)
                    {
                        UserDetails = await Login22Async(cancellationToken);
                    }
                    else
                    {
                        UserDetails = await Login14Async(cancellationToken);
                    }
                }
                catch (ErrorResponseException e)
                {
                    throw new LoginException(e.Message, e);
                }
                finally
                {
                    _semaphore.Release();
                }
            }

            return UserDetails;
        }

        /// <summary>
        /// Perform login via V22 method
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        private async Task<UserDetails> Login22Async(CancellationToken cancellationToken = default)
        {
            // Release 22 login will return reseller information if logging in as a reseller
            var loginRequest = new LoginRequest22V2
            {
                UserId = _username,
                Password = _password
            };

            var loginResponse = (await ExecuteCommandsAsync(new LoginRequest22V2[] { loginRequest }, cancellationToken).ConfigureAwait(false)).First() as LoginResponse22V2;

            return new UserDetails
            {
                LoginType = loginResponse.LoginType.ToString(),
                Locale = loginResponse.Locale,
                Encoding = loginResponse.Encoding,
                GroupId = loginResponse.GroupId,
                ServiceProviderId = loginResponse.ServiceProviderId,
                IsEnterprise = loginResponse.IsEnterprise,
                PasswordExpiresDays = loginResponse.PasswordExpiresDays,
                UserDomain = loginResponse.UserDomain,
                ResellerId = loginResponse.ResellerId
            };
        }

        /// <summary>
        /// Perform login via V14 method
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        private async Task<UserDetails> Login14Async(CancellationToken cancellationToken = default)
        {
            var authRequest = new AuthenticationRequest
            {
                UserId = _username
            };

            var authResponse = (await ExecuteCommandsAsync(new AuthenticationRequest[] { authRequest }, cancellationToken).ConfigureAwait(false)).First() as AuthenticationResponse;

            string signedPassword = null;

            if (authResponse.PasswordAlgorithm == DigitalSignatureAlgorithm.MD5)
            {
                signedPassword = Md5($"{authResponse.Nonce}:{Sha1(_password)}");
            }
            else
            {
                throw new LoginException("Only MD5 supported for signing");
            }

            var loginRequest = new LoginRequest14sp4
            {
                UserId = _username,
                SignedPassword = signedPassword
            };

            var loginResponse = (await ExecuteCommandsAsync(new LoginRequest14sp4[] { loginRequest }, cancellationToken).ConfigureAwait(false)).First() as LoginResponse14sp4;

            return new UserDetails
            {
                LoginType = loginResponse.LoginType.ToString(),
                Locale = loginResponse.Locale,
                Encoding = loginResponse.Encoding,
                GroupId = loginResponse.GroupId,
                ServiceProviderId = loginResponse.ServiceProviderId,
                IsEnterprise = loginResponse.IsEnterprise,
                PasswordExpiresDays = loginResponse.PasswordExpiresDays,
                UserDomain = loginResponse.UserDomain
            };
        }

        /// <summary>
        /// Serializes the given list of commands to XML
        /// </summary>
        /// <param name="commands"></param>
        /// <returns></returns>
        public string SerializeCommands<T>(IEnumerable<T> commands) where T : OCICommand
        {

            var broadsoftDocument = new BroadsoftDocument<T>
            {
                SessionId = _sessionId,
                Protocol = "OCI",
                Command = commands.ToList()
            };

            return _serializer.Serialize(broadsoftDocument);
        }

        /// <summary>
        /// Executes multiple commands
        /// </summary>
        /// <param name="commands"></param>
        /// <exception cref="BadResponseException">Thrown when server returns something that isn't expected.</exception>
        /// <exception cref="ErrorResponseException">Thrown when server returns an ErrorResponse object.</exception>
        /// <returns></returns>
        private async Task<IEnumerable<OCIResponse>> ExecuteCommandsAsync(IEnumerable<OCIRequest> commands, CancellationToken cancellationToken = default) 
        {
            ValidateCommands(commands);

            var xml = SerializeCommands(commands);
            BroadsoftDocument<OCIResponse> response = null;

            var responseXml = await Transport.SendAsync(xml, cancellationToken).ConfigureAwait(false);

            if (responseXml.Length == 0)
            {
                throw new BadResponseException("Response is empty.");
            }

            try
            {
                response = _serializer.Deserialize<OCIResponse>(responseXml);
            }
            catch (Exception e)
            {
                throw new BadResponseException("Unable to deserialize response.", e);
            }

            if (!(response is BroadsoftDocument<OCIResponse>))
            {
                throw new BadResponseException("Response did not include a BroadsoftDocument element.");
            }

            if (response.Command.Count == 0)
            {
                throw new BadResponseException("Response does not include any commands.");
            }

            foreach (var command in response.Command)
            {
                if (command is ErrorResponse)
                {
                    throw new ErrorResponseException(command as ErrorResponse);
                }
            }

            return response.Command;
        }

        /// <summary>
        /// Validates a list of commands
        /// </summary>
        /// <param name="commands"></param>
        private void ValidateCommands(IEnumerable<OCICommand> commands)
        {
            foreach (var command in commands)
            {
                var validationResult = Validator.Validate(command);

                if (!validationResult.Success)
                {
                    var message = validationResult.Errors.Count() == 1
                        ? validationResult.Errors.Single().Message
                        : "Multiple validation errors found";

                    throw new ValidationException(message, validationResult.Errors);
                }
            }
        }


        /// <summary>
        /// Calculates the MD5 hash of a string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string Md5(string input)
        {
            MD5 md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return string.Concat(hash.Select(b => b.ToString("x2")));
        }

        /// <summary>
        /// Calculates the SHA1 hash of a string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string Sha1(string input)
        {
            SHA1Managed sha1 = new SHA1Managed();
            var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));

            return string.Concat(hash.Select(b => b.ToString("x2")));
        }

        public void Dispose()
        {
            if (Transport != null)
            {
                Transport.Dispose();
            }
        }
    }
}
