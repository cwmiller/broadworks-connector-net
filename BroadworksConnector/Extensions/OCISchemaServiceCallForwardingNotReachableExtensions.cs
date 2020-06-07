using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallForwardingNotReachableExtensions
    {

        /// <summary>
        /// Request the user level data associated with Call Forwarding Not Reachable.
        /// The response is either a UserCallForwardingNotReachableGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallForwardingNotReachableGetRequestAsync instead.")]
        public static async Task<UserCallForwardingNotReachableGetResponse> UserCallForwardingNotReachableGetRequest(this OcipClient client, UserCallForwardingNotReachableGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallForwardingNotReachableGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Call Forwarding Not Reachable.
        /// The response is either a UserCallForwardingNotReachableGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallForwardingNotReachableGetResponse> UserCallForwardingNotReachableGetRequestAsync(this OcipClient client, UserCallForwardingNotReachableGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallForwardingNotReachableGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Call Forwarding Not Reachable.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallForwardingNotReachableModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallForwardingNotReachableModifyRequest(this OcipClient client, UserCallForwardingNotReachableModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Call Forwarding Not Reachable.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        public static async Task<SuccessResponse> UserCallForwardingNotReachableModifyRequestAsync(this OcipClient client, UserCallForwardingNotReachableModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
