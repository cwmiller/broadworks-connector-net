using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceRemoteOfficeExtensions
    {

        /// <summary>
        /// Request the user level data associated with Remote Office.
        /// The response is either a UserRemoteOfficeGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserRemoteOfficeGetResponse> UserRemoteOfficeGetRequest(this OcipClient client, UserRemoteOfficeGetRequest request)
        {
            return await client.Call(request) as UserRemoteOfficeGetResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Remote Office.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserRemoteOfficeModifyRequest(this OcipClient client, UserRemoteOfficeModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
