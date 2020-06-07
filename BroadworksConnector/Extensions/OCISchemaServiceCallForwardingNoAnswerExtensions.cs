using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallForwardingNoAnswerExtensions
    {

        /// <summary>
        /// Request the user level data associated with Call Forwarding No Answer.
        /// The response is either a UserCallForwardingNoAnswerGetResponse13mp16 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallForwardingNoAnswerGetRequest13mp16Async instead.")]
        public static async Task<UserCallForwardingNoAnswerGetResponse13mp16> UserCallForwardingNoAnswerGetRequest13mp16(this OcipClient client, UserCallForwardingNoAnswerGetRequest13mp16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallForwardingNoAnswerGetResponse13mp16;
        }

        /// <summary>
        /// Request the user level data associated with Call Forwarding No Answer.
        /// The response is either a UserCallForwardingNoAnswerGetResponse13mp16 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallForwardingNoAnswerGetResponse13mp16> UserCallForwardingNoAnswerGetRequest13mp16Async(this OcipClient client, UserCallForwardingNoAnswerGetRequest13mp16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallForwardingNoAnswerGetResponse13mp16;
        }
        /// <summary>
        /// Modify the user level data associated with Call Forwarding No Answer.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallForwardingNoAnswerModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallForwardingNoAnswerModifyRequest(this OcipClient client, UserCallForwardingNoAnswerModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Call Forwarding No Answer.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        public static async Task<SuccessResponse> UserCallForwardingNoAnswerModifyRequestAsync(this OcipClient client, UserCallForwardingNoAnswerModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
