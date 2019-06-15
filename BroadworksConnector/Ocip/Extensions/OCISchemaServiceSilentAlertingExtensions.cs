using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceSilentAlertingExtensions
{

    /// <summary>
    /// Request the user level data associated with Silent Alerting service.
    /// The response is either a UserSilentAlertingGetResponse or an
    /// ErrorResponse.
    /// </summary>
    public static async Task<UserSilentAlertingGetResponse> UserSilentAlertingGetRequest(this OcipClient client, UserSilentAlertingGetRequest request) {
        return await client.Call(request) as UserSilentAlertingGetResponse;
    }

    /// <summary>
    /// Modify the user level data associated with Silent Alerting service.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserSilentAlertingModifyRequest(this OcipClient client, UserSilentAlertingModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
