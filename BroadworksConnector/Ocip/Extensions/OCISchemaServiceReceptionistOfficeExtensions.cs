using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceReceptionistOfficeExtensions
    {

        /// <summary>
        /// Get the Receptionist Office available user list.
        /// The response is either UserBroadWorksReceptionistOfficeGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserBroadWorksReceptionistOfficeGetAvailableUserListResponse> UserBroadWorksReceptionistOfficeGetAvailableUserListRequest(this OcipClient client, UserBroadWorksReceptionistOfficeGetAvailableUserListRequest request)
        {
            return await client.Call(request) as UserBroadWorksReceptionistOfficeGetAvailableUserListResponse;
        }

        /// <summary>
        /// Request the Receptionist Office parameters.
        /// The response is either a UserBroadWorksReceptionistOfficeGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserBroadWorksReceptionistOfficeGetResponse> UserBroadWorksReceptionistOfficeGetRequest(this OcipClient client, UserBroadWorksReceptionistOfficeGetRequest request)
        {
            return await client.Call(request) as UserBroadWorksReceptionistOfficeGetResponse;
        }

        /// <summary>
        /// Replace the Receptionist Office monitored user list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksReceptionistOfficeModifyRequest(this OcipClient client, UserBroadWorksReceptionistOfficeModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
