using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
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
        public static async Task<SuccessResponse> UserPriorityAlertAddCriteriaRequest16(this OcipClient client, UserPriorityAlertAddCriteriaRequest16 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a criteria from the user's priority alert service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPriorityAlertDeleteCriteriaRequest(this OcipClient client, UserPriorityAlertDeleteCriteriaRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the user's priority alert criteria listing.
        /// The response is either a UserPriorityAlertGetCriteriaListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserPriorityAlertGetCriteriaListResponse> UserPriorityAlertGetCriteriaListRequest(this OcipClient client, UserPriorityAlertGetCriteriaListRequest request)
        {
            return await client.Call(request) as UserPriorityAlertGetCriteriaListResponse;
        }

        /// <summary>
        /// Get a criteria for the user's priority alert service.
        /// The response is either a UserPriorityAlertGetCriteriaResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<UserPriorityAlertGetCriteriaResponse21> UserPriorityAlertGetCriteriaRequest21(this OcipClient client, UserPriorityAlertGetCriteriaRequest21 request)
        {
            return await client.Call(request) as UserPriorityAlertGetCriteriaResponse21;
        }

        /// <summary>
        /// Activate the user's priority alert criteria list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPriorityAlertModifyActiveCriteriaListRequest(this OcipClient client, UserPriorityAlertModifyActiveCriteriaListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify a criteria for the user's priority alert service.
        /// The following elements are only used in AS data mode:
        /// callToNumberList
        /// 
        /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPriorityAlertModifyCriteriaRequest(this OcipClient client, UserPriorityAlertModifyCriteriaRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
