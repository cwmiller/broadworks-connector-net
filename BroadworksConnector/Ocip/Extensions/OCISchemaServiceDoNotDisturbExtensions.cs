using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceDoNotDisturbExtensions
    {

        /// <summary>
        /// Request the user level data associated with Do Not Disturb.
        /// The response is either a UserDoNotDisturbGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserDoNotDisturbGetResponse> UserDoNotDisturbGetRequest(this OcipClient client, UserDoNotDisturbGetRequest request)
        {
            return await client.Call(request) as UserDoNotDisturbGetResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Do Not Disturb.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        public static async Task<SuccessResponse> UserDoNotDisturbModifyRequest(this OcipClient client, UserDoNotDisturbModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
