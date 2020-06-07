using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallForwardingSelectiveExtensions
    {

        /// <summary>
        /// Add a criteria to the user's call forwarding selective service.
        /// The following elements are only used in AS data mode:
        /// callToNumber
        /// 
        /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallForwardingSelectiveAddCriteriaRequest16Async instead.")]
        public static async Task<SuccessResponse> UserCallForwardingSelectiveAddCriteriaRequest16(this OcipClient client, UserCallForwardingSelectiveAddCriteriaRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a criteria to the user's call forwarding selective service.
        /// The following elements are only used in AS data mode:
        /// callToNumber
        /// 
        /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallForwardingSelectiveAddCriteriaRequest16Async(this OcipClient client, UserCallForwardingSelectiveAddCriteriaRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a criteria from the user's call forwarding selective service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallForwardingSelectiveDeleteCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallForwardingSelectiveDeleteCriteriaRequest(this OcipClient client, UserCallForwardingSelectiveDeleteCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a criteria from the user's call forwarding selective service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallForwardingSelectiveDeleteCriteriaRequestAsync(this OcipClient client, UserCallForwardingSelectiveDeleteCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a criteria for the user's call forwarding selective service.
        /// The response is either a UserCallForwardingSelectiveGetCriteriaResponse21 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallForwardingSelectiveGetCriteriaRequest21Async instead.")]
        public static async Task<UserCallForwardingSelectiveGetCriteriaResponse21> UserCallForwardingSelectiveGetCriteriaRequest21(this OcipClient client, UserCallForwardingSelectiveGetCriteriaRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallForwardingSelectiveGetCriteriaResponse21;
        }

        /// <summary>
        /// Get a criteria for the user's call forwarding selective service.
        /// The response is either a UserCallForwardingSelectiveGetCriteriaResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallForwardingSelectiveGetCriteriaResponse21> UserCallForwardingSelectiveGetCriteriaRequest21Async(this OcipClient client, UserCallForwardingSelectiveGetCriteriaRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallForwardingSelectiveGetCriteriaResponse21;
        }
        /// <summary>
        /// Get the user's call forwarding selective service setting.
        /// The response is either a UserCallForwardingSelectiveGetResponse16 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallForwardingSelectiveGetRequest16Async instead.")]
        public static async Task<UserCallForwardingSelectiveGetResponse16> UserCallForwardingSelectiveGetRequest16(this OcipClient client, UserCallForwardingSelectiveGetRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallForwardingSelectiveGetResponse16;
        }

        /// <summary>
        /// Get the user's call forwarding selective service setting.
        /// The response is either a UserCallForwardingSelectiveGetResponse16 or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallForwardingSelectiveGetResponse16> UserCallForwardingSelectiveGetRequest16Async(this OcipClient client, UserCallForwardingSelectiveGetRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallForwardingSelectiveGetResponse16;
        }
        /// <summary>
        /// Modify a criteria for the user's call forwarding selective service.
        /// The following elements are only used in AS data mode:
        /// callToNumber
        /// 
        /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallForwardingSelectiveModifyCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallForwardingSelectiveModifyCriteriaRequest(this OcipClient client, UserCallForwardingSelectiveModifyCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a criteria for the user's call forwarding selective service.
        /// The following elements are only used in AS data mode:
        /// callToNumber
        /// 
        /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallForwardingSelectiveModifyCriteriaRequestAsync(this OcipClient client, UserCallForwardingSelectiveModifyCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the user's call forwarding selective service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallForwardingSelectiveModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallForwardingSelectiveModifyRequest(this OcipClient client, UserCallForwardingSelectiveModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's call forwarding selective service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallForwardingSelectiveModifyRequestAsync(this OcipClient client, UserCallForwardingSelectiveModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
