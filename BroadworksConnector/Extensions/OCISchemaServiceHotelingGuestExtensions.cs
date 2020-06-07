using System;
using System.Threading;
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
        [Obsolete("This method is deprecated. Use UserHotelingGuestGetAvailableUserListRequestAsync instead.")]
        public static async Task<UserHotelingGuestGetAvailableUserListResponse> UserHotelingGuestGetAvailableUserListRequest(this OcipClient client, UserHotelingGuestGetAvailableUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserHotelingGuestGetAvailableUserListResponse;
        }

        /// <summary>
        /// Get a list of users that can be assigned as Hoteling Guests.
        /// The response is either UserHotelingGuestGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserHotelingGuestGetAvailableUserListResponse> UserHotelingGuestGetAvailableUserListRequestAsync(this OcipClient client, UserHotelingGuestGetAvailableUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserHotelingGuestGetAvailableUserListResponse;
        }
        /// <summary>
        /// Request the user level data associated with Hoteling Guest.
        /// The response is either a UserHotelingGuestGetResponse14sp4 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserHotelingGuestGetRequest14sp4Async instead.")]
        public static async Task<UserHotelingGuestGetResponse14sp4> UserHotelingGuestGetRequest14sp4(this OcipClient client, UserHotelingGuestGetRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserHotelingGuestGetResponse14sp4;
        }

        /// <summary>
        /// Request the user level data associated with Hoteling Guest.
        /// The response is either a UserHotelingGuestGetResponse14sp4 or an ErrorResponse.
        /// </summary>
        public static async Task<UserHotelingGuestGetResponse14sp4> UserHotelingGuestGetRequest14sp4Async(this OcipClient client, UserHotelingGuestGetRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserHotelingGuestGetResponse14sp4;
        }
        /// <summary>
        /// Modify the user level data associated with Hoteling Guest.
        /// Provisioning error will be given when setting hostUserId to not nil value while Hoteling Guest feature is not active.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserHotelingGuestModifyRequest21Async instead.")]
        public static async Task<SuccessResponse> UserHotelingGuestModifyRequest21(this OcipClient client, UserHotelingGuestModifyRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Hoteling Guest.
        /// Provisioning error will be given when setting hostUserId to not nil value while Hoteling Guest feature is not active.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserHotelingGuestModifyRequest21Async(this OcipClient client, UserHotelingGuestModifyRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
