using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceDirectedCallPickupWithBargeInExtensions
    {

        /// <summary>
        /// Request the user level data associated with Directed Call Pickup With Barge In.
        /// The response is either a UserDirectedCallPickupWithBargeInGetResponse14sp7 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserDirectedCallPickupWithBargeInGetResponse14sp7> UserDirectedCallPickupWithBargeInGetRequest14sp7(this OcipClient client, UserDirectedCallPickupWithBargeInGetRequest14sp7 request)
        {
            return await client.Call(request) as UserDirectedCallPickupWithBargeInGetResponse14sp7;
        }

        /// <summary>
        /// Modify the user level data associated with Directed Call Pickup With Barge In.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserDirectedCallPickupWithBargeInModifyRequest(this OcipClient client, UserDirectedCallPickupWithBargeInModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
