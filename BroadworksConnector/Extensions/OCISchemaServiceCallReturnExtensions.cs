using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallReturnExtensions
    {

        /// <summary>
        /// Request the system level data associated with Call Return.
        /// The response is either a SystemCallReturnGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallReturnGetRequestAsync instead.")]
        public static async Task<SystemCallReturnGetResponse> SystemCallReturnGetRequest(this OcipClient client, SystemCallReturnGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallReturnGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Call Return.
        /// The response is either a SystemCallReturnGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallReturnGetResponse> SystemCallReturnGetRequestAsync(this OcipClient client, SystemCallReturnGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallReturnGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Call Return.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallReturnModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallReturnModifyRequest(this OcipClient client, SystemCallReturnModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Call Return.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallReturnModifyRequestAsync(this OcipClient client, SystemCallReturnModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
