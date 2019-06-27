using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceReceptionistSmallBusinessExtensions
    {

        /// <summary>
        /// Get a list of available users for the Receptionist Small Business service.
        /// The response is either UserBroadWorksReceptionistSmallBusinessGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserBroadWorksReceptionistSmallBusinessGetAvailableUserListResponse> UserBroadWorksReceptionistSmallBusinessGetAvailableUserListRequest(this OcipClient client, UserBroadWorksReceptionistSmallBusinessGetAvailableUserListRequest request)
        {
            return await client.Call(request) as UserBroadWorksReceptionistSmallBusinessGetAvailableUserListResponse;
        }

        /// <summary>
        /// Request the Receptionist Small Business parameters.
        /// The response is either a UserBroadWorksReceptionistSmallBusinessGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserBroadWorksReceptionistSmallBusinessGetResponse> UserBroadWorksReceptionistSmallBusinessGetRequest(this OcipClient client, UserBroadWorksReceptionistSmallBusinessGetRequest request)
        {
            return await client.Call(request) as UserBroadWorksReceptionistSmallBusinessGetResponse;
        }

        /// <summary>
        /// Replace the Receptionist Small Business monitored user list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksReceptionistSmallBusinessModifyRequest(this OcipClient client, UserBroadWorksReceptionistSmallBusinessModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
