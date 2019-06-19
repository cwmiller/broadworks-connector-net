using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceCallingNumberDeliveryExtensions
    {

        /// <summary>
        /// Request the user level data associated with Calling
        /// Name Delivery. The response is either a UserCallingNumberDeliveryGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallingNumberDeliveryGetResponse> UserCallingNumberDeliveryGetRequest(this OcipClient client, UserCallingNumberDeliveryGetRequest request)
        {
            return await client.Call(request) as UserCallingNumberDeliveryGetResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Calling Number Delivery.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallingNumberDeliveryModifyRequest(this OcipClient client, UserCallingNumberDeliveryModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
