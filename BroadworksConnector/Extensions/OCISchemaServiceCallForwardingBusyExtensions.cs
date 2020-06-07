using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallForwardingBusyExtensions
    {

        /// <summary>
        /// Request the user level data associated with Call Forwarding Busy.
        /// The response is either a UserCallForwardingBusyGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallForwardingBusyGetRequestAsync instead.")]
        public static async Task<UserCallForwardingBusyGetResponse> UserCallForwardingBusyGetRequest(this OcipClient client, UserCallForwardingBusyGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallForwardingBusyGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Call Forwarding Busy.
        /// The response is either a UserCallForwardingBusyGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallForwardingBusyGetResponse> UserCallForwardingBusyGetRequestAsync(this OcipClient client, UserCallForwardingBusyGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallForwardingBusyGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Call Forwarding Busy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallForwardingBusyModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallForwardingBusyModifyRequest(this OcipClient client, UserCallForwardingBusyModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Call Forwarding Busy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        public static async Task<SuccessResponse> UserCallForwardingBusyModifyRequestAsync(this OcipClient client, UserCallForwardingBusyModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
