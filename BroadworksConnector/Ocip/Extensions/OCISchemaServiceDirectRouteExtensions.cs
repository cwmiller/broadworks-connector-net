using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceDirectRouteExtensions
{

    /// <summary>
    /// Get the direct route setting and the list of DTGs/Trunk Identities assigned to a user.
    /// The response is either UserDirectRouteGetResponse or ErrorResponse.
    /// </summary>
    public static async Task<UserDirectRouteGetResponse> UserDirectRouteGetRequest(this OcipClient client, UserDirectRouteGetRequest request) {
        return await client.Call(request) as UserDirectRouteGetResponse;
    }

    /// <summary>
    /// Modify the direct route setting and the list of DTGs/Trunk Identities assigned to a user.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserDirectRouteModifyRequest(this OcipClient client, UserDirectRouteModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
