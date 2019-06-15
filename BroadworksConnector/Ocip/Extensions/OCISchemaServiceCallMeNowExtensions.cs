using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceCallMeNowExtensions
{

    /// <summary>
    /// Request the system level data associated with Call Me Now service.
    /// The response is either a SystemCallMeNowGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SystemCallMeNowGetResponse> SystemCallMeNowGetRequest(this OcipClient client, SystemCallMeNowGetRequest request) {
        return await client.Call(request) as SystemCallMeNowGetResponse;
    }

    /// <summary>
    /// Modify the system level data associated with Call me now service.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> SystemCallMeNowModifyRequest(this OcipClient client, SystemCallMeNowModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Add a criterion to the user's call me now service.  The criterion added is automatically active.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCallMeNowAddCriteriaRequest(this OcipClient client, UserCallMeNowAddCriteriaRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Delete a criteria from the user's call me now service.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCallMeNowDeleteCriteriaRequest(this OcipClient client, UserCallMeNowDeleteCriteriaRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get a criteria for the user's call me now service.
    /// The response is either a UserCallMeNowGetCriteriaResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserCallMeNowGetCriteriaResponse> UserCallMeNowGetCriteriaRequest(this OcipClient client, UserCallMeNowGetCriteriaRequest request) {
        return await client.Call(request) as UserCallMeNowGetCriteriaResponse;
    }

    /// <summary>
    /// Get the user's call me now service setting.
    /// The response is either a UserCallMeNowGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserCallMeNowGetResponse> UserCallMeNowGetRequest(this OcipClient client, UserCallMeNowGetRequest request) {
        return await client.Call(request) as UserCallMeNowGetResponse;
    }

    /// <summary>
    /// Modify a criteria for the user's call me now service.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCallMeNowModifyCriteriaRequest(this OcipClient client, UserCallMeNowModifyCriteriaRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Modify the user's call me now service setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCallMeNowModifyRequest(this OcipClient client, UserCallMeNowModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
