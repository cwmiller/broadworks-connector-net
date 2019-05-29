using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BroadworksConnector.Ocip
{
    public interface ITransport
    {
        Task<string> Send(string request);
    }
}
