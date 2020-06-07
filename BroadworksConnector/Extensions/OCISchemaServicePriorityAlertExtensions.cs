using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServicePriorityAlertExtensions
    {

        /// <summary>
        /// Add a criteria to the user's priority alert service.
        /// The following elements are only used in AS data mode:
        /// callToNumber
        /// 
        /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPriorityAlertAddCriteriaRequest16Async instead.")]
        public static async Task<SuccessResponse> UserPriorityAlertAddCriteriaRequest16(this OcipClient client, UserPriorityAlertAddCriteriaRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a criteria to the user's priority alert service.
        /// The following elements are only used in AS data mode:
        /// callToNumber
        /// 
        /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPriorityAlertAddCriteriaRequest16Async(this OcipClient client, UserPriorityAlertAddCriteriaRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a criteria from the user's priority alert service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPriorityAlertDeleteCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPriorityAlertDeleteCriteriaRequest(this OcipClient client, UserPriorityAlertDeleteCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a criteria from the user's priority alert service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPriorityAlertDeleteCriteriaRequestAsync(this OcipClient client, UserPriorityAlertDeleteCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the user's priority alert criteria listing.
        /// The response is either a UserPriorityAlertGetCriteriaListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPriorityAlertGetCriteriaListRequestAsync instead.")]
        public static async Task<UserPriorityAlertGetCriteriaListResponse> UserPriorityAlertGetCriteriaListRequest(this OcipClient client, UserPriorityAlertGetCriteriaListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPriorityAlertGetCriteriaListResponse;
        }

        /// <summary>
        /// Get the user's priority alert criteria listing.
        /// The response is either a UserPriorityAlertGetCriteriaListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserPriorityAlertGetCriteriaListResponse> UserPriorityAlertGetCriteriaListRequestAsync(this OcipClient client, UserPriorityAlertGetCriteriaListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPriorityAlertGetCriteriaListResponse;
        }
        /// <summary>
        /// Get a criteria for the user's priority alert service.
        /// The response is either a UserPriorityAlertGetCriteriaResponse21 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPriorityAlertGetCriteriaRequest21Async instead.")]
        public static async Task<UserPriorityAlertGetCriteriaResponse21> UserPriorityAlertGetCriteriaRequest21(this OcipClient client, UserPriorityAlertGetCriteriaRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPriorityAlertGetCriteriaResponse21;
        }

        /// <summary>
        /// Get a criteria for the user's priority alert service.
        /// The response is either a UserPriorityAlertGetCriteriaResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<UserPriorityAlertGetCriteriaResponse21> UserPriorityAlertGetCriteriaRequest21Async(this OcipClient client, UserPriorityAlertGetCriteriaRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPriorityAlertGetCriteriaResponse21;
        }
        /// <summary>
        /// Activate the user's priority alert criteria list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPriorityAlertModifyActiveCriteriaListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPriorityAlertModifyActiveCriteriaListRequest(this OcipClient client, UserPriorityAlertModifyActiveCriteriaListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Activate the user's priority alert criteria list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPriorityAlertModifyActiveCriteriaListRequestAsync(this OcipClient client, UserPriorityAlertModifyActiveCriteriaListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify a criteria for the user's priority alert service.
        /// The following elements are only used in AS data mode:
        /// callToNumberList
        /// 
        /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPriorityAlertModifyCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPriorityAlertModifyCriteriaRequest(this OcipClient client, UserPriorityAlertModifyCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a criteria for the user's priority alert service.
        /// The following elements are only used in AS data mode:
        /// callToNumberList
        /// 
        /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPriorityAlertModifyCriteriaRequestAsync(this OcipClient client, UserPriorityAlertModifyCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
