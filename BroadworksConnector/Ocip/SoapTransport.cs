using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BroadworksConnector.Ocip
{
    public class SoapTransport : ITransport
    {
        private Uri _uri;

        public SoapTransport(Uri uri)
        {
            _uri = uri;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<string> Send(string request)
        {
            throw new NotImplementedException();
        }
    }
}
