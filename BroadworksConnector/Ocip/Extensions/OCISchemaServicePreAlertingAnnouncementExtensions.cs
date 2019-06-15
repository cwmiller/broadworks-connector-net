using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServicePreAlertingAnnouncementExtensions
{

    /// <summary>
    /// Get the Enterprise pre-alerting service settings.
    /// The response is either a EnterprisePreAlertingAnnouncementGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<EnterprisePreAlertingAnnouncementGetResponse> EnterprisePreAlertingAnnouncementGetRequest(this OcipClient client, EnterprisePreAlertingAnnouncementGetRequest request) {
        return await client.Call(request) as EnterprisePreAlertingAnnouncementGetResponse;
    }

    /// <summary>
    /// Modify the enterprise level pre-alerting service settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> EnterprisePreAlertingAnnouncementModifyRequest(this OcipClient client, EnterprisePreAlertingAnnouncementModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get the group’s PreAlertingservice settings.
    /// The response is either a GroupPreAlertingAnnouncementGetResponse20 or an ErrorResponse.
    /// </summary>
    public static async Task<GroupPreAlertingAnnouncementGetResponse20> GroupPreAlertingAnnouncementGetRequest20(this OcipClient client, GroupPreAlertingAnnouncementGetRequest20 request) {
        return await client.Call(request) as GroupPreAlertingAnnouncementGetResponse20;
    }

    /// <summary>
    /// Modify the group level pre-alerting service settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupPreAlertingAnnouncementModifyRequest20(this OcipClient client, GroupPreAlertingAnnouncementModifyRequest20 request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Add a criteria to the user's pre-alerting service.
    /// The following elements are only used in AS data mode:
    /// callToNumber
    /// 
    /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserPreAlertingAnnouncementAddCriteriaRequest(this OcipClient client, UserPreAlertingAnnouncementAddCriteriaRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Delete a criteria from the user's pre-alerting service.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserPreAlertingAnnouncementDeleteCriteriaRequest(this OcipClient client, UserPreAlertingAnnouncementDeleteCriteriaRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get a criteria for the user's pre-alerting service.
    /// The response is either a UserPreAlertingAnnouncementGetCriteriaResponse21 or an ErrorResponse.
    /// </summary>
    public static async Task<UserPreAlertingAnnouncementGetCriteriaResponse21> UserPreAlertingAnnouncementGetCriteriaRequest21(this OcipClient client, UserPreAlertingAnnouncementGetCriteriaRequest21 request) {
        return await client.Call(request) as UserPreAlertingAnnouncementGetCriteriaResponse21;
    }

    /// <summary>
    /// Get the user's pre-alerting service setting.
    /// The response is either a UserPreAlertingAnnouncementGetResponse20 or an ErrorResponse.
    /// </summary>
    public static async Task<UserPreAlertingAnnouncementGetResponse20> UserPreAlertingAnnouncementGetRequest20(this OcipClient client, UserPreAlertingAnnouncementGetRequest20 request) {
        return await client.Call(request) as UserPreAlertingAnnouncementGetResponse20;
    }

    /// <summary>
    /// Modify a criteria for the user's pre-alerting service.
    /// The following elements are only used in AS data mode:
    /// callToNumber
    /// 
    /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserPreAlertingAnnouncementModifyCriteriaRequest(this OcipClient client, UserPreAlertingAnnouncementModifyCriteriaRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Modify the user's pre-alerting service setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserPreAlertingAnnouncementModifyRequest20(this OcipClient client, UserPreAlertingAnnouncementModifyRequest20 request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
