using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServicePushToTalkExtensions
    {

        /// <summary>
        /// Get a list of available users for the push to talk service.
        /// The response is either UserPushToTalkGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserPushToTalkGetAvailableUserListResponse> UserPushToTalkGetAvailableUserListRequest(this OcipClient client, UserPushToTalkGetAvailableUserListRequest request)
        {
            return await client.Call(request) as UserPushToTalkGetAvailableUserListResponse;
        }

        /// <summary>
        /// Request the push to talk service setting.
        /// The response is either a UserPushToTalkGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserPushToTalkGetResponse> UserPushToTalkGetRequest(this OcipClient client, UserPushToTalkGetRequest request)
        {
            return await client.Call(request) as UserPushToTalkGetResponse;
        }

        /// <summary>
        /// Change the push to talk service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPushToTalkModifyRequest(this OcipClient client, UserPushToTalkModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
