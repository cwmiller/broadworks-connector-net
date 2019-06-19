using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceExternalCallingLineIDDeliveryExtensions
    {

        /// <summary>
        /// Request the user level data associated with External Calling Line ID Delivery.
        /// The response is either a UserExternalCallingLineIDDeliveryGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserExternalCallingLineIDDeliveryGetResponse> UserExternalCallingLineIDDeliveryGetRequest(this OcipClient client, UserExternalCallingLineIDDeliveryGetRequest request)
        {
            return await client.Call(request) as UserExternalCallingLineIDDeliveryGetResponse;
        }

        /// <summary>
        /// Modify the user level data associated with External Calling Line ID Delivery.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserExternalCallingLineIDDeliveryModifyRequest(this OcipClient client, UserExternalCallingLineIDDeliveryModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
