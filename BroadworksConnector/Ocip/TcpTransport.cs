using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
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

        private const string EndTag = "</BroadsoftDocument>\n";

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
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<string> SendAsync(string request, CancellationToken cancellationToken = default)
        {
            // Use a semaphore to prevent concurrency issues since this transport only maintains a single TCP connection.
            await _semaphore.WaitAsync();

            var response = "";

            try
            {
                // Connect to host if this is the first time called
                if (_tcpClient == null)
                {
                    _tcpClient = new TcpClient(_host, _port)
                    {
                        SendTimeout = _options.TcpSendTimeout,
                        ReceiveTimeout = _options.TcpReceiveTimeout
                    };

                    if (_useSsl)
                    {
                        if (_options.IgnoreSslCertificateErrors) {
                             _stream = new SslStream(_tcpClient.GetStream(), false, (message, cert, chain, errors) => true);
                        } else {
                            _stream = new SslStream(_tcpClient.GetStream());
                        }

                        await (_stream as SslStream).AuthenticateAsClientAsync(_host).ConfigureAwait(false);
                    }
                    else
                    {
                        _stream = _tcpClient.GetStream();
                    }
                }

                // Using the configured encoding, convert the XML request string into bytes
                var requestData = _options.TcpRequestEncoding.GetBytes(request);

                // Write all of the XML request to the socket
                await _stream.WriteAsync(requestData, 0, requestData.Length, cancellationToken).ConfigureAwait(false);

                var responseData = new List<byte>();
                var responseBuffer = new byte[1024];
                int bytesRead = -1;

                while (bytesRead != 0)
                {
                    // Read in some response bytes from the socket
                    bytesRead = await _stream.ReadAsync(responseBuffer, 0, responseBuffer.Length, cancellationToken).ConfigureAwait(false);

                    // Append received bytes to full buffer
                    responseData.AddRange(responseBuffer.Take(bytesRead));

                    // Read the full response as a string using the encoding provided in the client options
                    response = _options.TcpResponseEncoding.GetString(responseData.ToArray());

                    // Once the response contains the ending tag, return it
                    if (response.Contains(EndTag))
                    {
                        break;
                    }
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
