using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceInterceptExtensions
{

    /// <summary>
    /// Get the group's intercept group service settings.
    /// The response is either a GroupInterceptGroupGetResponse21sp1 or an ErrorResponse.
    /// </summary>
    public static async Task<GroupInterceptGroupGetResponse21sp1> GroupInterceptGroupGetRequest21sp1(this OcipClient client, GroupInterceptGroupGetRequest21sp1 request) {
        return await client.Call(request) as GroupInterceptGroupGetResponse21sp1;
    }

    /// <summary>
    /// Modify the group's intercept group service settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// exemptInboundMobilityCalls
    /// exemptOutboundMobilityCalls
    /// disableParallelRingingToNetworkLocations
    /// </summary>
    public static async Task<SuccessResponse> GroupInterceptGroupModifyRequest21sp1(this OcipClient client, GroupInterceptGroupModifyRequest21sp1 request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request to add an Intercept User number(s) to the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> SystemInterceptUserAddDnListRequest(this OcipClient client, SystemInterceptUserAddDnListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request to delete an Intercept User number(s) from the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> SystemInterceptUserDeleteDnListRequest(this OcipClient client, SystemInterceptUserDeleteDnListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request to get a list of Intercept User dns defined in the system.
    /// The response is either a SystemInterceptUserGetDnListResponse
    /// or an ErrorResponse.
    /// </summary>
    public static async Task<SystemInterceptUserGetDnListResponse> SystemInterceptUserGetDnListRequest(this OcipClient client, SystemInterceptUserGetDnListRequest request) {
        return await client.Call(request) as SystemInterceptUserGetDnListResponse;
    }

    /// <summary>
    /// Get the system-level intercept user service settings.
    /// The response is either a SystemInterceptUserGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SystemInterceptUserGetResponse> SystemInterceptUserGetRequest(this OcipClient client, SystemInterceptUserGetRequest request) {
        return await client.Call(request) as SystemInterceptUserGetResponse;
    }

    /// <summary>
    /// Request to modify a Intercept User number's description in the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> SystemInterceptUserModifyDnRequest(this OcipClient client, SystemInterceptUserModifyDnRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Modify the system-level intercept user service settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> SystemInterceptUserModifyRequest(this OcipClient client, SystemInterceptUserModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get the user's intercept user service settings.
    /// The response is either a UserInterceptUserGetResponse21sp1 or an ErrorResponse.
    /// </summary>
    public static async Task<UserInterceptUserGetResponse21sp1> UserInterceptUserGetRequest21sp1(this OcipClient client, UserInterceptUserGetRequest21sp1 request) {
        return await client.Call(request) as UserInterceptUserGetResponse21sp1;
    }

    /// <summary>
    /// Modify the user's intercept user service settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// exemptInboundMobilityCalls
    /// exemptOutboundMobilityCalls
    /// disableParallelRingingToNetworkLocations
    /// </summary>
    public static async Task<SuccessResponse> UserInterceptUserModifyRequest21sp1(this OcipClient client, UserInterceptUserModifyRequest21sp1 request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
