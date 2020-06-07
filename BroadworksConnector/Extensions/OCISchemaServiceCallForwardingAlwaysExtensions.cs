using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallForwardingAlwaysExtensions
    {

        /// <summary>
        /// Request the user level data associated with Call Forwarding Always.
        /// The response is either a UserCallForwardingAlwaysGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallForwardingAlwaysGetRequestAsync instead.")]
        public static async Task<UserCallForwardingAlwaysGetResponse> UserCallForwardingAlwaysGetRequest(this OcipClient client, UserCallForwardingAlwaysGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallForwardingAlwaysGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Call Forwarding Always.
        /// The response is either a UserCallForwardingAlwaysGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallForwardingAlwaysGetResponse> UserCallForwardingAlwaysGetRequestAsync(this OcipClient client, UserCallForwardingAlwaysGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallForwardingAlwaysGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Call Forwarding Always.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallForwardingAlwaysModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallForwardingAlwaysModifyRequest(this OcipClient client, UserCallForwardingAlwaysModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Call Forwarding Always.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        public static async Task<SuccessResponse> UserCallForwardingAlwaysModifyRequestAsync(this OcipClient client, UserCallForwardingAlwaysModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
