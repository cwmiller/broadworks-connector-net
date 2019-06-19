using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceVideoAddOnExtensions
    {

        /// <summary>
        /// Get the user's Video Add-On service setting.
        /// The response is either a UserVideoAddOnGetResponse19 or an ErrorResponse.
        /// </summary>
        public static async Task<UserVideoAddOnGetResponse19> UserVideoAddOnGetRequest19(this OcipClient client, UserVideoAddOnGetRequest19 request)
        {
            return await client.Call(request) as UserVideoAddOnGetResponse19;
        }

        /// <summary>
        /// Get the user's Video Add-On service setting.
        /// The response is either a UserVideoAddOnGetResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<UserVideoAddOnGetResponse22> UserVideoAddOnGetRequest22(this OcipClient client, UserVideoAddOnGetRequest22 request)
        {
            return await client.Call(request) as UserVideoAddOnGetResponse22;
        }

        /// <summary>
        /// Modify the user's Video Add-On service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserVideoAddOnModifyRequest14(this OcipClient client, UserVideoAddOnModifyRequest14 request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
