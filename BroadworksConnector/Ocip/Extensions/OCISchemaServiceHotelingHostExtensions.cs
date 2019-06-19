using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceHotelingHostExtensions
    {

        /// <summary>
        /// Request the user level data associated with Hoteling Host.
        /// The response is either a UserHotelingHostGetResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<UserHotelingHostGetResponse17> UserHotelingHostGetRequest17(this OcipClient client, UserHotelingHostGetRequest17 request)
        {
            return await client.Call(request) as UserHotelingHostGetResponse17;
        }

        /// <summary>
        /// Modify the user level data associated with Hoteling Host.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserHotelingHostModifyRequest(this OcipClient client, UserHotelingHostModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
