using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceExecutiveExtensions
{

    /// <summary>
    /// Request to get the Executive system parameters.
    /// The response is either SystemExecutiveGetResponse or ErrorResponse.
    /// </summary>
    public static async Task<SystemExecutiveGetResponse> SystemExecutiveGetRequest(this OcipClient client, SystemExecutiveGetRequest request) {
        return await client.Call(request) as SystemExecutiveGetResponse;
    }

    /// <summary>
    /// Request to modify the Executive system parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> SystemExecutiveModifyRequest(this OcipClient client, SystemExecutiveModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Add a filtering criteria to an executive user.
    /// Both executive and the executive assistant can run this command.
    /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserExecutiveAddFilteringSelectiveCriteriaRequest(this OcipClient client, UserExecutiveAddFilteringSelectiveCriteriaRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Delete a filtering criteria from an executive user.
    /// Both executive and the executive assistant can run this command.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserExecutiveDeleteFilteringSelectiveCriteriaRequest(this OcipClient client, UserExecutiveDeleteFilteringSelectiveCriteriaRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get the assistant setting and the list of assistants assigned to an executive.
    /// The response is either UserExecutiveGetAssistantResponse or ErrorResponse.
    /// </summary>
    public static async Task<UserExecutiveGetAssistantResponse> UserExecutiveGetAssistantRequest(this OcipClient client, UserExecutiveGetAssistantRequest request) {
        return await client.Call(request) as UserExecutiveGetAssistantResponse;
    }

    /// <summary>
    /// Get a list of users that can be assigned to an executive.
    /// Searching for users by group only makes sense when the executive user is part of an Enterprise.
    /// The response is either UserExecutiveGetAvailableAssistantListResponse or ErrorResponse.
    /// </summary>
    public static async Task<UserExecutiveGetAvailableAssistantListResponse> UserExecutiveGetAvailableAssistantListRequest(this OcipClient client, UserExecutiveGetAvailableAssistantListRequest request) {
        return await client.Call(request) as UserExecutiveGetAvailableAssistantListResponse;
    }

    /// <summary>
    /// Get the filtering setting and the list of filtering criteria defined for an executive user.
    /// Both executive and the executive assistant can run this command.
    /// The response is either UserExecutiveGetFilteringResponse or ErrorResponse.
    /// </summary>
    public static async Task<UserExecutiveGetFilteringResponse> UserExecutiveGetFilteringRequest(this OcipClient client, UserExecutiveGetFilteringRequest request) {
        return await client.Call(request) as UserExecutiveGetFilteringResponse;
    }

    /// <summary>
    /// Get a filtering criteria for an executive user.
    /// Both executive and the executive assistant can run this command.
    /// The response is either UserExecutiveGetFilteringSelectiveCriteriaResponse21 or ErrorResponse.
    /// </summary>
    public static async Task<UserExecutiveGetFilteringSelectiveCriteriaResponse21> UserExecutiveGetFilteringSelectiveCriteriaRequest21(this OcipClient client, UserExecutiveGetFilteringSelectiveCriteriaRequest21 request) {
        return await client.Call(request) as UserExecutiveGetFilteringSelectiveCriteriaResponse21;
    }

    /// <summary>
    /// Get the screening and alerting setting of an executive. Both executive and the executive assistant can run this command.
    /// The response is either UserExecutiveGetScreeningAlertingResponse or ErrorResponse.
    /// </summary>
    public static async Task<UserExecutiveGetScreeningAlertingResponse> UserExecutiveGetScreeningAlertingRequest(this OcipClient client, UserExecutiveGetScreeningAlertingRequest request) {
        return await client.Call(request) as UserExecutiveGetScreeningAlertingResponse;
    }

    /// <summary>
    /// Request to modify the assistant setting and the list of assistants assigned to an executive user.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserExecutiveModifyAssistantRequest(this OcipClient client, UserExecutiveModifyAssistantRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Modify the filtering setting for an executive user.
    /// Both executive and the executive assistant can run this command.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserExecutiveModifyFilteringRequest(this OcipClient client, UserExecutiveModifyFilteringRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Modify a filtering selective criteria for an executive.
    /// Both executive and the executive assistant can run this command.
    /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserExecutiveModifyFilteringSelectiveCriteriaRequest(this OcipClient client, UserExecutiveModifyFilteringSelectiveCriteriaRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Modify the screening and alerting setting of an executive.
    /// Both executive and the executive assistant can run this command.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserExecutiveModifyScreeningAlertingRequest(this OcipClient client, UserExecutiveModifyScreeningAlertingRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
