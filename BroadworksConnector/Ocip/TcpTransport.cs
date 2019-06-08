using System;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BroadWorksConnector.Ocip
{
    /// <summary>
    /// TCP transport
    /// </summary>
    public class TcpTransport : ITransport
    {
        private string _host;

        private int _port;

        private bool _useSsl;

        private TcpClient _tcpClient;

        private Stream _stream;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="host"></param>
        /// <param name="port"></param>
        /// <param name="useSsl"></param>
        public TcpTransport(string host, int port, bool useSsl = false)
        {
            _host = host;
            _port = port;
            _useSsl = useSsl;
        }

        /// <summary>
        /// Send request to host and return results
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<string> Send(string request)
        {
            // Connect to host
            if (_tcpClient == null)
            {
                _tcpClient = new TcpClient(_host, _port);

                if (_useSsl)
                {
                    _stream = new SslStream(_tcpClient.GetStream());
                    await (_stream as SslStream).AuthenticateAsClientAsync(_host);
                }
                else
                {
                    _stream = _tcpClient.GetStream();
                }
            }

            var response = "";
            var requestData = Encoding.UTF8.GetBytes(request);
            var responseData = new byte[1024];

            await _stream.WriteAsync(requestData, 0, requestData.Length);

            try
            {
                int bytesRead = -1;

                do
                {
                    // Clear out response buffer for each read so there's no hanging data from the previous read
                    Array.Clear(responseData, 0, responseData.Length);
                    bytesRead = await _stream.ReadAsync(responseData, 0, responseData.Length);

                    response += Encoding.UTF8.GetString(responseData);

                    // Reading stops once we receive a closing BroadsoftDocument tag
                    if (response.Contains("</BroadsoftDocument>\n"))
                    {
                        break;
                    }
                } while (bytesRead != 0);
            } catch(Exception e)
            {
                throw new BadResponseException("Unable to parse response", e);
            }

            // Remove any NULL characters that might have slipped in.
            return response.Replace("\0", "");
        }

        public void Dispose()
        {
            if (_stream != null)
            {
                _stream.Dispose();
            }

            if (_tcpClient != null)
            {
                _tcpClient.Dispose();
            }
        }
    }
}
