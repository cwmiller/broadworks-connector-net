using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceAuthenticationExtensions
    {

        /// <summary>
        /// Get the user's authentication service information.
        /// The response is either a UserAuthenticationGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserAuthenticationGetResponse> UserAuthenticationGetRequest(this OcipClient client, UserAuthenticationGetRequest request)
        {
            return await client.Call(request) as UserAuthenticationGetResponse;
        }

        /// <summary>
        /// Modify the user's authentication service information.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserAuthenticationModifyRequest(this OcipClient client, UserAuthenticationModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
