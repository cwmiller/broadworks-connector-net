using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace BroadworksConnector.Ocip
{
    public class TcpTransport : ITransport
    {
        private readonly string _host;

        private readonly int _port;

        private readonly TcpClient _tcpClient;

        public TcpTransport(string host, int port)
        {
            _host = host;
            _port = port;
            _tcpClient = new TcpClient(host, port);
        }

        public async Task<string> Send(string request)
        {
            Debug.WriteLine(request);

            var response = "";
            var responseData = new char[1024];

            var stream = _tcpClient.GetStream();

            var writer = new StreamWriter(stream, Encoding.UTF8);
            writer.AutoFlush = true;

            var reader = new StreamReader(stream, Encoding.UTF8);

            await writer.WriteAsync(request);

            try
            {
                while (true)
                {
                    await reader.ReadAsync(responseData, 0, responseData.Length);

                    response += new string(responseData);

                    if (response.Contains("</BroadsoftDocument>\n"))
                    {
                        break;
                    }
                }
            } catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return response;
        }
    }
}
