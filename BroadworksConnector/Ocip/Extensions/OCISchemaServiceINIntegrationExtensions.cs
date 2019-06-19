using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceINIntegrationExtensions
    {

        /// <summary>
        /// Request to get the user level IN Integration service attributes
        /// The response is either UserINIntegrationGetResponse or ErrorResponse
        /// </summary>
        public static async Task<UserINIntegrationGetResponse> UserINIntegrationGetRequest(this OcipClient client, UserINIntegrationGetRequest request)
        {
            return await client.Call(request) as UserINIntegrationGetResponse;
        }

        /// <summary>
        /// Request to modify the user level IN Integration service attributes
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> UserINIntegrationModifyRequest(this OcipClient client, UserINIntegrationModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
