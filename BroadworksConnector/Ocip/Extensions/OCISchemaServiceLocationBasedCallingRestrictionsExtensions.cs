using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceLocationBasedCallingRestrictionsExtensions
{

    /// <summary>
    /// Gets system level the Location Based Calling Restrictions attributes.
    /// The response is either a SystemLocationBasedCallingRestrictionsGetResponse17sp3 or an ErrorResponse.
    /// </summary>
    public static async Task<SystemLocationBasedCallingRestrictionsGetResponse17sp3> SystemLocationBasedCallingRestrictionsGetRequest17sp3(this OcipClient client, SystemLocationBasedCallingRestrictionsGetRequest17sp3 request) {
        return await client.Call(request) as SystemLocationBasedCallingRestrictionsGetResponse17sp3;
    }

    /// <summary>
    /// Modifies the system level Location Based Calling Restriction attributes.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> SystemLocationBasedCallingRestrictionsModifyRequest(this OcipClient client, SystemLocationBasedCallingRestrictionsModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
