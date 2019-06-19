using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceAccountAuthorizationCodesExtensions
    {

        /// <summary>
        /// Add a list of account/authorization codes to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAccountAuthorizationCodesAddListRequest(this OcipClient client, GroupAccountAuthorizationCodesAddListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of account/authorization codes from a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAccountAuthorizationCodesDeleteListRequest(this OcipClient client, GroupAccountAuthorizationCodesDeleteListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a list of non restricted users for the account/authorization codes service.
        /// The response is either GroupAccountAuthorizationCodesGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupAccountAuthorizationCodesGetAvailableUserListResponse> GroupAccountAuthorizationCodesGetAvailableUserListRequest(this OcipClient client, GroupAccountAuthorizationCodesGetAvailableUserListRequest request)
        {
            return await client.Call(request) as GroupAccountAuthorizationCodesGetAvailableUserListResponse;
        }

        /// <summary>
        /// Request the list of account/authorization codes for a group.
        /// The response is either a GroupAccountAuthorizationCodesGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupAccountAuthorizationCodesGetListResponse> GroupAccountAuthorizationCodesGetListRequest(this OcipClient client, GroupAccountAuthorizationCodesGetListRequest request)
        {
            return await client.Call(request) as GroupAccountAuthorizationCodesGetListResponse;
        }

        /// <summary>
        /// Request the group's account/authorization codes setting.
        /// The response is either a GroupAccountAuthorizationCodesGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupAccountAuthorizationCodesGetResponse> GroupAccountAuthorizationCodesGetRequest(this OcipClient client, GroupAccountAuthorizationCodesGetRequest request)
        {
            return await client.Call(request) as GroupAccountAuthorizationCodesGetResponse;
        }

        /// <summary>
        /// Change the group's account/authorization codes setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAccountAuthorizationCodesModifyRequest(this OcipClient client, GroupAccountAuthorizationCodesModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
