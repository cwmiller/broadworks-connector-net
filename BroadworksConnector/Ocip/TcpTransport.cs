using System;
using System.Diagnostics;
using System.IO;
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
        private readonly string _host;

        private readonly int _port;

        private readonly TcpClient _tcpClient;

        private readonly NetworkStream _stream;

        private readonly StreamWriter _writer;

        private readonly StreamReader _reader;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="host"></param>
        /// <param name="port"></param>
        public TcpTransport(string host, int port)
        {
            _host = host;
            _port = port;
            _tcpClient = new TcpClient(host, port);

            _stream = _tcpClient.GetStream();

            _writer = new StreamWriter(_stream, Encoding.UTF8);
            _writer.AutoFlush = true;

            _reader = new StreamReader(_stream, Encoding.UTF8);
        }

        public async Task<string> Send(string request)
        {
            var response = "";
            var responseData = new char[1024];

            await _writer.WriteAsync(request);

            try
            {
                while (true)
                {
                    Array.Clear(responseData, 0, responseData.Length);
                    await _reader.ReadAsync(responseData, 0, responseData.Length);

                    response += new string(responseData);

                    if (response.Contains("</BroadsoftDocument>\n"))
                    {
                        break;
                    }
                }
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
