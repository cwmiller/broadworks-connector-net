using System;
using System.Threading.Tasks;

namespace BroadWorksConnector.Ocip
{
    public interface ITransport : IDisposable
    {
        Task<string> Send(string request);
    }
}
