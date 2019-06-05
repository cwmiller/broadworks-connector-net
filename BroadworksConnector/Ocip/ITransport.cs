using System;
using System.Threading.Tasks;

namespace BroadworksConnector.Ocip
{
    public interface ITransport : IDisposable
    {
        Task<string> Send(string request);
    }
}
