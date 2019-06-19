using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceSelectiveCallRejectionExtensions
    {

        /// <summary>
        /// Add a criteria to the user's selective call rejection service.
        /// The following elements are only used in AS data mode:
        /// callToNumber
        /// 
        /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSelectiveCallRejectionAddCriteriaRequest16(this OcipClient client, UserSelectiveCallRejectionAddCriteriaRequest16 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a criteria from the user's selective call rejection service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSelectiveCallRejectionDeleteCriteriaRequest(this OcipClient client, UserSelectiveCallRejectionDeleteCriteriaRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the user's selective call rejection criteria listing.
        /// The response is either a UserSelectiveCallRejectionGetCriteriaListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserSelectiveCallRejectionGetCriteriaListResponse> UserSelectiveCallRejectionGetCriteriaListRequest(this OcipClient client, UserSelectiveCallRejectionGetCriteriaListRequest request)
        {
            return await client.Call(request) as UserSelectiveCallRejectionGetCriteriaListResponse;
        }

        /// <summary>
        /// Get a criteria for the user's selective call rejection service.
        /// The response is either a UserSelectiveCallRejectionGetCriteriaResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<UserSelectiveCallRejectionGetCriteriaResponse21> UserSelectiveCallRejectionGetCriteriaRequest21(this OcipClient client, UserSelectiveCallRejectionGetCriteriaRequest21 request)
        {
            return await client.Call(request) as UserSelectiveCallRejectionGetCriteriaResponse21;
        }

        /// <summary>
        /// Activate the user's selective call rejection criteria list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSelectiveCallRejectionModifyActiveCriteriaListRequest(this OcipClient client, UserSelectiveCallRejectionModifyActiveCriteriaListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify a criteria for the user's selective call rejection service.
        /// The following elements are only used in AS data mode:
        /// callToNumberList
        /// 
        /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSelectiveCallRejectionModifyCriteriaRequest16(this OcipClient client, UserSelectiveCallRejectionModifyCriteriaRequest16 request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
