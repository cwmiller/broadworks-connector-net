using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallingNameDeliveryExtensions
    {

        /// <summary>
        /// Request the user level data associated with Calling
        /// Name Delivery. The response is either a UserCallingNameDeliveryGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallingNameDeliveryGetResponse> UserCallingNameDeliveryGetRequest(this OcipClient client, UserCallingNameDeliveryGetRequest request)
        {
            return await client.Call(request) as UserCallingNameDeliveryGetResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Calling Name Delivery.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallingNameDeliveryModifyRequest(this OcipClient client, UserCallingNameDeliveryModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
