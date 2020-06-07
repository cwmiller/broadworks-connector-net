using System;
using System.Threading;
using System.Threading.Tasks;

namespace BroadWorksConnector.Ocip
{
    public interface ITransport : IDisposable
    {
        [Obsolete("This method is deprecated. Use SendAsync instead.")]
        Task<string> Send(string request);

        Task<string> SendAsync(string request, CancellationToken cancellationToken = default);
    }
}
