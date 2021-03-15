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

        private OcipClientOptions _options;

        private TcpClient _tcpClient;

        private Stream _stream;

        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="host"></param>
        /// <param name="port"></param>
        /// <param name="useSsl"></param>
        /// <param name="options"></param>
        public TcpTransport(string host, int port, bool useSsl, OcipClientOptions options)
        {
            _host = host;
            _port = port;
            _useSsl = useSsl;
            _options = options;
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
            // Use a semaphore to prevent concurrency issues since this transport only maintains a single TCP connection.
            await _semaphore.WaitAsync();

            var response = "";

            try
            {
                // Connect to host
                if (_tcpClient == null)
                {

                    _tcpClient = new TcpClient(_host, _port);
                    _tcpClient.SendTimeout = _options.TcpSendTimeout;
                    _tcpClient.ReceiveTimeout = _options.TcpReceiveTimeout;

                    if (_useSsl)
                    {
                        _stream = new SslStream(_tcpClient.GetStream());
                        await (_stream as SslStream).AuthenticateAsClientAsync(_host).ConfigureAwait(false);
                    }
                    else
                    {
                        _stream = _tcpClient.GetStream();
                    }
                }
                
                var requestData = _options.TcpRequestEncoding.GetBytes(request);

                var responseData = new List<byte>();
                var responseBuffer = new byte[1024];

                await _stream.WriteAsync(requestData, 0, requestData.Length, cancellationToken).ConfigureAwait(false);

                try
                {
                    int bytesRead = -1;

                    do
                    {
                        // Clear out response buffer for each read so there's no hanging data from the previous read
                        bytesRead = await _stream.ReadAsync(responseBuffer, 0, responseBuffer.Length, cancellationToken).ConfigureAwait(false);

                        // Append buffer contents to full response
                        responseData.AddRange(responseBuffer.Take(bytesRead));

                        // Read the full response as a string using the encoding provided in the client options

                        response = _options.TcpResponseEncoding.GetString(responseData.ToArray());

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
            } 
            finally
            {
                _semaphore.Release();
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
