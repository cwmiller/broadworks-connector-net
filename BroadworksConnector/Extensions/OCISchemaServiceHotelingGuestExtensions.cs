using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceHotelingGuestExtensions
    {

        /// <summary>
        /// Get a list of users that can be assigned as Hoteling Guests.
        /// The response is either UserHotelingGuestGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserHotelingGuestGetAvailableUserListResponse> UserHotelingGuestGetAvailableUserListRequest(this OcipClient client, UserHotelingGuestGetAvailableUserListRequest request)
        {
            return await client.Call(request) as UserHotelingGuestGetAvailableUserListResponse;
        }

        /// <summary>
        /// Request the user level data associated with Hoteling Guest.
        /// The response is either a UserHotelingGuestGetResponse14sp4 or an ErrorResponse.
        /// </summary>
        public static async Task<UserHotelingGuestGetResponse14sp4> UserHotelingGuestGetRequest14sp4(this OcipClient client, UserHotelingGuestGetRequest14sp4 request)
        {
            return await client.Call(request) as UserHotelingGuestGetResponse14sp4;
        }

        /// <summary>
        /// Modify the user level data associated with Hoteling Guest.
        /// Provisioning error will be given when setting hostUserId to not nil value while Hoteling Guest feature is not active.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserHotelingGuestModifyRequest21(this OcipClient client, UserHotelingGuestModifyRequest21 request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
