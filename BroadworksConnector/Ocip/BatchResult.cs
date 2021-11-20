using BroadWorksConnector.Ocip.Models.C;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BroadWorksConnector.Ocip
{
    /// <summary>
    /// Wraps the results of a batch request, allowing for iterating over the results or retrieving the result for a specific request
    /// </summary>
    public class BatchResult : IEnumerable<OCIResponse>
    {
        private readonly IDictionary<Guid, OCIResponse> _dict = new Dictionary<Guid, OCIResponse>();

        internal BatchResult(IEnumerable<OCIRequest> requests, IEnumerable<OCIResponse> responses)
        {
            _dict = requests.Zip(responses, (q, s) => new { q, s }).ToDictionary(x => x.q.RequestGuid, x => x.s);
        }

        /// <summary>
        /// Get the response for the given request
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="request">The instance of a request object originally passed to CallAllAsync</param>
        /// <returns></returns>
        public TResponse Get<TResponse>(OCIRequest<TResponse> request) where TResponse : OCICommand
        {
            if (!_dict.ContainsKey(request.RequestGuid))
            {
                throw new ArgumentException("Object was not part of request", nameof(request));
            }

            return _dict[request.RequestGuid] as TResponse;
        }

        public IEnumerator<OCIResponse> GetEnumerator() => _dict.Values.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _dict.Values.GetEnumerator();
    }
}
