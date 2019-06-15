using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceInternalCallingLineIDDeliveryExtensions
{

    /// <summary>
    /// Request the user level data associated with Internal Calling Line ID Delivery.
    /// The response is either a UserInternalCallingLineIDDeliveryGetResponse or an
    /// ErrorResponse.
    /// </summary>
    public static async Task<UserInternalCallingLineIDDeliveryGetResponse> UserInternalCallingLineIDDeliveryGetRequest(this OcipClient client, UserInternalCallingLineIDDeliveryGetRequest request) {
        return await client.Call(request) as UserInternalCallingLineIDDeliveryGetResponse;
    }

    /// <summary>
    /// Modify the user level data associated with Internal Calling Line ID Delivery.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserInternalCallingLineIDDeliveryModifyRequest(this OcipClient client, UserInternalCallingLineIDDeliveryModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
