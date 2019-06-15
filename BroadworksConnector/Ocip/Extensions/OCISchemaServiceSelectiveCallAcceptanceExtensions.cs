using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceSelectiveCallAcceptanceExtensions
{

    /// <summary>
    /// Add a criteria to the user's selective call acceptance service.
    /// The following elements are only used in AS data mode:
    /// callToNumber
    /// 
    /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserSelectiveCallAcceptanceAddCriteriaRequest16(this OcipClient client, UserSelectiveCallAcceptanceAddCriteriaRequest16 request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Delete a criteria from the user's selective call acceptance service.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserSelectiveCallAcceptanceDeleteCriteriaRequest(this OcipClient client, UserSelectiveCallAcceptanceDeleteCriteriaRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get the user's selective call acceptance criteria listing.
    /// The response is either a UserSelectiveCallAcceptanceGetCriteriaListResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserSelectiveCallAcceptanceGetCriteriaListResponse> UserSelectiveCallAcceptanceGetCriteriaListRequest(this OcipClient client, UserSelectiveCallAcceptanceGetCriteriaListRequest request) {
        return await client.Call(request) as UserSelectiveCallAcceptanceGetCriteriaListResponse;
    }

    /// <summary>
    /// Get a criteria for the user's selective call acceptance service.
    /// The response is either a UserSelectiveCallAcceptanceGetCriteriaResponse21 or an ErrorResponse.
    /// </summary>
    public static async Task<UserSelectiveCallAcceptanceGetCriteriaResponse21> UserSelectiveCallAcceptanceGetCriteriaRequest21(this OcipClient client, UserSelectiveCallAcceptanceGetCriteriaRequest21 request) {
        return await client.Call(request) as UserSelectiveCallAcceptanceGetCriteriaResponse21;
    }

    /// <summary>
    /// Activate the user's selective call acceptance criteria list.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserSelectiveCallAcceptanceModifyActiveCriteriaListRequest(this OcipClient client, UserSelectiveCallAcceptanceModifyActiveCriteriaListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Modify a criteria for the user's selective call acceptance service.
    /// The following elements are only used in AS data mode:
    /// callToNumberList
    /// 
    /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserSelectiveCallAcceptanceModifyCriteriaRequest(this OcipClient client, UserSelectiveCallAcceptanceModifyCriteriaRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
