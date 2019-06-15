using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceCallNotifyExtensions
{

    /// <summary>
    /// Request the reseller level data associated with Call Notify.
    /// The response is either a ResellerCallNotifyGetResponse or an
    /// ErrorResponse.
    /// </summary>
    public static async Task<ResellerCallNotifyGetResponse> ResellerCallNotifyGetRequest(this OcipClient client, ResellerCallNotifyGetRequest request) {
        return await client.Call(request) as ResellerCallNotifyGetResponse;
    }

    /// <summary>
    /// Modify the reseller level data associated with Call Notify.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> ResellerCallNotifyModifyRequest(this OcipClient client, ResellerCallNotifyModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the system level data associated with Call Notify.
    /// The response is either a SystemCallNotifyGetResponse or an
    /// ErrorResponse.
    /// </summary>
    public static async Task<SystemCallNotifyGetResponse> SystemCallNotifyGetRequest(this OcipClient client, SystemCallNotifyGetRequest request) {
        return await client.Call(request) as SystemCallNotifyGetResponse;
    }

    /// <summary>
    /// Modify the system level data associated with Call Notify.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> SystemCallNotifyModifyRequest(this OcipClient client, SystemCallNotifyModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Add a criteria to the user's call notify service.
    /// The following elements are only used in AS data mode:
    /// callToNumber
    /// 
    /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCallNotifyAddCriteriaRequest16(this OcipClient client, UserCallNotifyAddCriteriaRequest16 request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Delete a criteria from the user's call notify service.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCallNotifyDeleteCriteriaRequest(this OcipClient client, UserCallNotifyDeleteCriteriaRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get a criteria for the user's call notify service.
    /// The response is either a UserCallNotifyGetCriteriaResponse21 or an ErrorResponse.
    /// </summary>
    public static async Task<UserCallNotifyGetCriteriaResponse21> UserCallNotifyGetCriteriaRequest21(this OcipClient client, UserCallNotifyGetCriteriaRequest21 request) {
        return await client.Call(request) as UserCallNotifyGetCriteriaResponse21;
    }

    /// <summary>
    /// Get the user's call notify service setting.
    /// The response is either a UserCallNotifyGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserCallNotifyGetResponse> UserCallNotifyGetRequest(this OcipClient client, UserCallNotifyGetRequest request) {
        return await client.Call(request) as UserCallNotifyGetResponse;
    }

    /// <summary>
    /// Modify a criteria for the user's call notify service.
    /// The following elements are only used in AS data mode:
    /// callToNumber
    /// 
    /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCallNotifyModifyCriteriaRequest(this OcipClient client, UserCallNotifyModifyCriteriaRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Modify the user's call notify service setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCallNotifyModifyRequest(this OcipClient client, UserCallNotifyModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
