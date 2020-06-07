using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallTransferExtensions
    {

        /// <summary>
        /// Request the user level data associated with Call Transfer.
        /// The response is either a UserCallTransferGetResponse14sp4 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallTransferGetRequest14sp4Async instead.")]
        public static async Task<UserCallTransferGetResponse14sp4> UserCallTransferGetRequest14sp4(this OcipClient client, UserCallTransferGetRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallTransferGetResponse14sp4;
        }

        /// <summary>
        /// Request the user level data associated with Call Transfer.
        /// The response is either a UserCallTransferGetResponse14sp4 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallTransferGetResponse14sp4> UserCallTransferGetRequest14sp4Async(this OcipClient client, UserCallTransferGetRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallTransferGetResponse14sp4;
        }
        /// <summary>
        /// Modify the user level data associated with Call Transfer.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallTransferModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallTransferModifyRequest(this OcipClient client, UserCallTransferModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Call Transfer.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallTransferModifyRequestAsync(this OcipClient client, UserCallTransferModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
