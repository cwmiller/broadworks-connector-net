using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceCustomRingbackExtensions
{

    /// <summary>
    /// Get the group's custom ring back service settings.
    /// The response is either a GroupCustomRingbackGroupGetResponse20 or an ErrorResponse.
    /// </summary>
    public static async Task<GroupCustomRingbackGroupGetResponse20> GroupCustomRingbackGroupGetRequest20(this OcipClient client, GroupCustomRingbackGroupGetRequest20 request) {
        return await client.Call(request) as GroupCustomRingbackGroupGetResponse20;
    }

    /// <summary>
    /// Modify the group's custom ring back service settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupCustomRingbackGroupModifyRequest20(this OcipClient client, GroupCustomRingbackGroupModifyRequest20 request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Add a criteria to the user's custom ringback service.
    /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCustomRingbackUserAddCriteriaRequest20(this OcipClient client, UserCustomRingbackUserAddCriteriaRequest20 request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Delete a criteria from the user's custom ringback service.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCustomRingbackUserDeleteCriteriaRequest(this OcipClient client, UserCustomRingbackUserDeleteCriteriaRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get the user's custom ringback service criteria listing.
    /// The response is either a UserCustomRingbackUserGetCriteriaListResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserCustomRingbackUserGetCriteriaListResponse> UserCustomRingbackUserGetCriteriaListRequest(this OcipClient client, UserCustomRingbackUserGetCriteriaListRequest request) {
        return await client.Call(request) as UserCustomRingbackUserGetCriteriaListResponse;
    }

    /// <summary>
    /// Get a criteria for the user's custom ringback service.
    /// The response is either a UserCustomRingbackUserGetCriteriaResponse21 or an ErrorResponse.
    /// </summary>
    public static async Task<UserCustomRingbackUserGetCriteriaResponse21> UserCustomRingbackUserGetCriteriaRequest21(this OcipClient client, UserCustomRingbackUserGetCriteriaRequest21 request) {
        return await client.Call(request) as UserCustomRingbackUserGetCriteriaResponse21;
    }

    /// <summary>
    /// Modify the user's custom ringback service criteria's active setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCustomRingbackUserModifyActiveCriteriaListRequest(this OcipClient client, UserCustomRingbackUserModifyActiveCriteriaListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Modify a criteria for the user's custom ringback service.
    /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCustomRingbackUserModifyCriteriaRequest20(this OcipClient client, UserCustomRingbackUserModifyCriteriaRequest20 request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
