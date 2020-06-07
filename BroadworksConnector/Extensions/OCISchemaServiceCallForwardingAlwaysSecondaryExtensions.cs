using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallForwardingAlwaysSecondaryExtensions
    {

        /// <summary>
        /// Request the user level data associated with Call Forwarding Always Secondary service.
        /// The response is either a UserCallForwardingAlwaysSecondaryGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallForwardingAlwaysSecondaryGetRequestAsync instead.")]
        public static async Task<UserCallForwardingAlwaysSecondaryGetResponse> UserCallForwardingAlwaysSecondaryGetRequest(this OcipClient client, UserCallForwardingAlwaysSecondaryGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallForwardingAlwaysSecondaryGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Call Forwarding Always Secondary service.
        /// The response is either a UserCallForwardingAlwaysSecondaryGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallForwardingAlwaysSecondaryGetResponse> UserCallForwardingAlwaysSecondaryGetRequestAsync(this OcipClient client, UserCallForwardingAlwaysSecondaryGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallForwardingAlwaysSecondaryGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Call Forwarding Always Secondary service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallForwardingAlwaysSecondaryModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallForwardingAlwaysSecondaryModifyRequest(this OcipClient client, UserCallForwardingAlwaysSecondaryModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Call Forwarding Always Secondary service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallForwardingAlwaysSecondaryModifyRequestAsync(this OcipClient client, UserCallForwardingAlwaysSecondaryModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
