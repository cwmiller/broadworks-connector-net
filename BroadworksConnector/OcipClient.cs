using BroadworksConnector.Ocip;
using BroadworksConnector.Ocip.Models;
using BroadworksConnector.Ocip.Models.C;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace BroadworksConnector
{
    /// <summary>
    /// Client for communicating with BroadWorks OCI-P
    /// </summary>
    public class OcipClient : IDisposable
    {
        private readonly string _username;

        private readonly string _password;

        private readonly string _sessionId;

        public ITransport Transport { get; private set; }

        private readonly XmlSerializer _serializer;

        public UserDetails UserDetails { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="url"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public OcipClient(string url, string username, string password)
        {
            _username = username;
            _password = password;
            _sessionId = GenerateSessionId();
            _serializer = new XmlSerializer(typeof(BroadsoftDocument), "C");

            var uri = new Uri(url);
            
            switch (uri.Scheme)
            {
                case "http":
                case "https":
                    Transport = new SoapTransport(uri);
                    break;
                case "tcp":
                    Transport = new TcpTransport(uri.Host, uri.Port);
                    break;
                default:
                    throw new ArgumentException("Unsupported protocol", nameof(url));
            }
        }

        /// <summary>
        /// Executes a single Request
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public async Task<OCIResponse> Call(OCICommand command)
        {
            if (UserDetails == null)
            {
                await Login();
            }

            var responses = await ExecuteCommands(new List<OCICommand> { command });

            return responses.First() as OCIResponse;
        }

        /// <summary>
        /// All sessions require a session ID to be generated. This is created once and used for all requests.
        /// </summary>
        /// <returns></returns>
        private string GenerateSessionId()
        {
            var sha256 = new SHA256Managed();
            var ticks = DateTime.Now.Ticks.ToString();
            var bytes = Encoding.ASCII.GetBytes(ticks);

            return ticks.ToString();
        }

        /// <summary>
        /// Authenticates against OCI-P using the provided username and password
        /// </summary>
        /// <returns></returns>
        public async Task<UserDetails> Login()
        {
            if (UserDetails == null)
            {
                var authRequest = new AuthenticationRequest
                {
                    UserId = _username
                };

                try
                {
                    var authResponse = (await ExecuteCommands(new List<OCICommand>() { authRequest })).First() as AuthenticationResponse;
                    string signedPassword = null;

                    if (authResponse.PasswordAlgorithm == DigitalSignatureAlgorithm.MD5)
                    {
                        signedPassword = Md5($"{authResponse.Nonce}:{Sha1(_password)}");
                    }
                    else
                    {
                        throw new LoginException("Only MD5 supported for signing");
                    }

                    // TODO: R22 support
                    var loginRequest = new LoginRequest14sp4
                    {
                        UserId = _username,
                        SignedPassword = signedPassword
                    };

                    var loginResponse = (await ExecuteCommands(new List<OCICommand>() { loginRequest })).First() as LoginResponse14sp4;

                    // TODO: set R22 properties
                    UserDetails = new UserDetails
                    {
                        LoginType = loginResponse.LoginType,
                        Locale = loginResponse.Locale,
                        Encoding = loginResponse.Encoding,
                        GroupId = loginResponse.GroupId,
                        ServiceProviderId = loginResponse.ServiceProviderId,
                        IsEnterprise = loginResponse.IsEnterprise,
                        PasswordExpiresDays = loginResponse.PasswordExpiresDays,
                        UserDomain = loginResponse.UserDomain
                    };
                }
                catch (ErrorResponseException e)
                {
                    throw new LoginException(e.Message, e);
                }
            }

            return UserDetails;
        }

        /// <summary>
        /// Executes multiple commands
        /// </summary>
        /// <param name="commands"></param>
        /// <exception cref="BadResponseException"></exception>
        /// <returns></returns>
        private async Task<IEnumerable<OCICommand>> ExecuteCommands(IEnumerable<OCICommand> commands)
        {
            // TODO: validate commands

            var xml = SerializeCommands(commands);
            BroadsoftDocument response = null;

            var responseXml = await Transport.Send(xml);

            Debug.WriteLine(responseXml);

            using (var reader = new StringReader(responseXml))
            {
                try
                {
                    response = _serializer.Deserialize(reader) as BroadsoftDocument;
                } catch(Exception e)
                {
                    throw new BadResponseException("Unable to deserialize response.", e);
                }
            }

            if (!(response is BroadsoftDocument))
            {
                throw new BadResponseException("Response did not include a BroadsoftDocument element.");
            }

            if (response.Command.Count == 0)
            {
                throw new BadResponseException("Response does not include any commands.");
            }

            return response.Command;
        }

        /// <summary>
        /// Serializes the given list of commands to XML
        /// </summary>
        /// <param name="commands"></param>
        /// <returns></returns>
        private string SerializeCommands(IEnumerable<OCICommand> commands)
        {
            string xml;
            
            var broadsoftDocument = new BroadsoftDocument
            {
                SessionId = _sessionId,
                Protocol = "OCI",
                Command = commands.ToList()
            };

            using (var requestStream = new MemoryStream())
            {
                using (var textWriter = new XmlTextWriter(requestStream, Encoding.UTF8))
                {
                    textWriter.Formatting = Formatting.None;
                    _serializer.Serialize(textWriter, broadsoftDocument);

                    xml = Encoding.UTF8.GetString(requestStream.ToArray());
                }
            }

            return xml;
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
