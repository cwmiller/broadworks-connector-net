using BroadWorksConnector.Ocip;
using BroadWorksConnector.Ocip.Models.C;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BroadWorksConnector
{
    /// <summary>
    /// Client for communicating with BroadWorks OCI-P
    /// </summary>
    public interface IOcipClient
    {
        /// <summary>
        /// Execute a single command and receive the response
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="command"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="LoginException">Thrown when the login to the server fails.</exception>
        /// <exception cref="ValidationException">Thrown when the given request fails local validation.</exception>
        Task<TResponse> CallAsync<TResponse>(OCIRequest<TResponse> command, CancellationToken cancellationToken = default) where TResponse : OCICommand;

        /// <summary>
        /// Execute multiple commands in a single request
        /// </summary>
        /// <param name="commands"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="LoginException">Thrown when the login to the server fails.</exception>
        /// <exception cref="ValidationException">Thrown when the given request fails local validation.</exception>
        Task<BatchResult> CallAllAsync(IEnumerable<OCIRequest> commands, CancellationToken cancellationToken = default);

        /// <summary>
        /// Authenticate against OCI-P using the provided username and password
        /// </summary>
        /// <returns></returns>
        /// <exception cref="LoginException">Thrown when the login to the server fails.</exception>
        Task<UserDetails> LoginAsync(CancellationToken cancellationToken = default);
    }
}
