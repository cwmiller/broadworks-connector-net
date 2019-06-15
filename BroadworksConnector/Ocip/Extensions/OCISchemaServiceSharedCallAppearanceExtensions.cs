using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceSharedCallAppearanceExtensions
{

    /// <summary>
    /// Associate an access device instance to the user's Shared Call Appearance.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserSharedCallAppearanceAddEndpointRequest14sp2(this OcipClient client, UserSharedCallAppearanceAddEndpointRequest14sp2 request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Disassociate one or more of a user's Shared Call Appearance endpoints.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserSharedCallAppearanceDeleteEndpointListRequest14(this OcipClient client, UserSharedCallAppearanceDeleteEndpointListRequest14 request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get the user's Shared Call Appearance endpoint setting.
    /// The response is either a UserSharedCallAppearanceGetEndpointResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserSharedCallAppearanceGetEndpointResponse> UserSharedCallAppearanceGetEndpointRequest(this OcipClient client, UserSharedCallAppearanceGetEndpointRequest request) {
        return await client.Call(request) as UserSharedCallAppearanceGetEndpointResponse;
    }

    /// <summary>
    /// Get the user's Shared Call Appearance service setting.
    /// The response is either a UserSharedCallAppearanceGetResponse21sp1 or an ErrorResponse.
    /// </summary>
    public static async Task<UserSharedCallAppearanceGetResponse21sp1> UserSharedCallAppearanceGetRequest21sp1(this OcipClient client, UserSharedCallAppearanceGetRequest21sp1 request) {
        return await client.Call(request) as UserSharedCallAppearanceGetResponse21sp1;
    }

    /// <summary>
    /// Associate/Disassociate an access device instance to the user's Shared Call Appearance.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserSharedCallAppearanceModifyEndpointRequest(this OcipClient client, UserSharedCallAppearanceModifyEndpointRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Modify the user's Shared Call Appearance service setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following elements are only used in XS data mode and ignored in AS data mode:
    /// useUserPrimaryWithAlternateCallsSetting
    /// allowSimultaneousPrimaryAndAlternate
    /// restrictCallRetrieveOfPrimary
    /// restrictCallBridgingOfPrimary
    /// </summary>
    public static async Task<SuccessResponse> UserSharedCallAppearanceModifyRequest(this OcipClient client, UserSharedCallAppearanceModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
