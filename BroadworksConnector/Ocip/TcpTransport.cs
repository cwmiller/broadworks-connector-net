using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BroadWorksConnector.Ocip
{
    /// <summary>
    /// TCP transport
    /// </summary>
    internal class TcpTransport : ITransport
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
        [Obsolete("Method deprecated. Use SendAsync instead.")]
        public Task<string> Send(string request) => SendAsync(request);

        /// <summary>
        /// Send request to host and return results
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<string> SendAsync(string request, CancellationToken cancellationToken = default)
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

            var responseData = new List<byte>();
            var responseBuffer = new byte[1024];

            await _stream.WriteAsync(requestData, 0, requestData.Length, cancellationToken);

            try
            {
                int bytesRead = -1;

                do
                {
                    // Clear out response buffer for each read so there's no hanging data from the previous read
                    bytesRead = await _stream.ReadAsync(responseBuffer, 0, responseBuffer.Length, cancellationToken);

                    // Append buffer contents to full response
                    responseData.AddRange(responseBuffer.Take(bytesRead));

                    // Read the full response as a UTF8 string
                    
                    response = Encoding.UTF8.GetString(responseData.ToArray());

                    // Once the response contains the ending tag, return it
                    if (response.Contains("</BroadsoftDocument>\n"))
                    {
                        break;
                    }
                } while (bytesRead != 0);
            }
            catch (Exception e) when (!(e is OperationCanceledException))   // Allow exceptions caused by cancellationToken to fall through 
            {
                throw new BadResponseException("Unable to parse response", e);
            }

            return response;
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
