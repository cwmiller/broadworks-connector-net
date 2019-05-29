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
    public class OcipClient
    {
        private readonly string _username;

        private readonly string _password;

        private readonly string _sessionId;

        public ITransport Transport { get; private set; }

        private readonly XmlSerializer _serializer;

        private bool _isLoggedIn;

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

        public async Task<OCIResponse> Call(OCICommand command)
        {
            if (!_isLoggedIn)
            {
                await Login();
            }

            var responses = await ExecuteCommands(new List<OCICommand> { command });

            return responses.First();
        }

        private string GenerateSessionId()
        {
            var sha256 = new SHA256Managed();
            var ticks = DateTime.Now.Ticks.ToString();
            var bytes = Encoding.ASCII.GetBytes(ticks);

            return ticks.ToString();
        }

        private async Task Login()
        {
            if (!_isLoggedIn)
            {
                var authRequest = new AuthenticationRequest
                {
                    UserId = _username
                };

                var authResponse = await ExecuteCommands(new List<OCICommand>() { authRequest });

                Debug.WriteLine(authResponse);
            }
        }

        private async Task<IEnumerable<OCIResponse>> ExecuteCommands(IEnumerable<OCICommand> commands)
        {
            // TODO: validate

            var xml = BuildCommandXml(commands);
            BroadsoftDocument response = null;

            var responseXml = (await Transport.Send(xml)).Trim('\0');

            Debug.WriteLine(responseXml);

            using (var reader = new StringReader(responseXml))
            {
                response = _serializer.Deserialize(reader) as BroadsoftDocument;
            }

            return response.Command as IEnumerable<OCIResponse>;
        }

        private string BuildCommandXml(IEnumerable<OCICommand> commands)
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
    }
}
