using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceChargeNumberExtensions
    {

        /// <summary>
        /// Request the user level data associated with Charge Number.
        /// The response is either a UserChargeNumberGetResponse14sp9 or an ErrorResponse.
        /// </summary>
        public static async Task<UserChargeNumberGetResponse14sp9> UserChargeNumberGetRequest14sp9(this OcipClient client, UserChargeNumberGetRequest14sp9 request)
        {
            return await client.Call(request) as UserChargeNumberGetResponse14sp9;
        }

        /// <summary>
        /// Modify the user level data associated with Charge Number.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserChargeNumberModifyRequest(this OcipClient client, UserChargeNumberModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
