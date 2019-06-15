using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceAutomaticCallbackExtensions
{

    /// <summary>
    /// Adds automatic callback release cause to the releaseCause attribute.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> SystemAutomaticCallbackAddReleaseCauseListRequest(this OcipClient client, SystemAutomaticCallbackAddReleaseCauseListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Deletes automatic callback release causes from the release cause attribute.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> SystemAutomaticCallbackDeleteReleaseCauseListRequest(this OcipClient client, SystemAutomaticCallbackDeleteReleaseCauseListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the system's automatic callback attributes.
    /// The response is either a SystemAutomaticCallbackGetReleaseCauseListResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SystemAutomaticCallbackGetReleaseCauseListResponse> SystemAutomaticCallbackGetReleaseCauseListRequest(this OcipClient client, SystemAutomaticCallbackGetReleaseCauseListRequest request) {
        return await client.Call(request) as SystemAutomaticCallbackGetReleaseCauseListResponse;
    }

    /// <summary>
    /// Request the system's automatic callback attributes.
    /// The response is either a SystemAutomaticCallbackGetResponse17 or an ErrorResponse.
    /// </summary>
    public static async Task<SystemAutomaticCallbackGetResponse17> SystemAutomaticCallbackGetRequest17(this OcipClient client, SystemAutomaticCallbackGetRequest17 request) {
        return await client.Call(request) as SystemAutomaticCallbackGetResponse17;
    }

    /// <summary>
    /// Modifies the system's automatic callback attributes.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> SystemAutomaticCallbackModifyRequest15(this OcipClient client, SystemAutomaticCallbackModifyRequest15 request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the user level data associated with Automatic Callback.
    /// The response is either a UserAutomaticCallbackGetResponse or an
    /// ErrorResponse.
    /// </summary>
    public static async Task<UserAutomaticCallbackGetResponse> UserAutomaticCallbackGetRequest(this OcipClient client, UserAutomaticCallbackGetRequest request) {
        return await client.Call(request) as UserAutomaticCallbackGetResponse;
    }

    /// <summary>
    /// Modify the user level data associated with Automatic Callback.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserAutomaticCallbackModifyRequest(this OcipClient client, UserAutomaticCallbackModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
