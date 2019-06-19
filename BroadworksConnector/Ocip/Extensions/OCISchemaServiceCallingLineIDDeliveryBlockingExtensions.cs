using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceCallingLineIDDeliveryBlockingExtensions
    {

        /// <summary>
        /// Request the user level data associated with Calling Line ID Delivery Blocking.
        /// The response is either a UserCallingLineIDDeliveryBlockingGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallingLineIDDeliveryBlockingGetResponse> UserCallingLineIDDeliveryBlockingGetRequest(this OcipClient client, UserCallingLineIDDeliveryBlockingGetRequest request)
        {
            return await client.Call(request) as UserCallingLineIDDeliveryBlockingGetResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Calling Line ID Delivery Blocking.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallingLineIDDeliveryBlockingModifyRequest(this OcipClient client, UserCallingLineIDDeliveryBlockingModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
