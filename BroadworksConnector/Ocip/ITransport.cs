using System;
using System.Threading;
using System.Threading.Tasks;

namespace BroadWorksConnector.Ocip
{
    public interface ITransport : IDisposable
    {
        Task<string> SendAsync(string request, CancellationToken cancellationToken = default);
    }
}
