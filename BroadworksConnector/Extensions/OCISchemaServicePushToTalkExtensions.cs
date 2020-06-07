using System;
using System.Threading;
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
        [Obsolete("This method is deprecated. Use UserPushToTalkGetAvailableUserListRequestAsync instead.")]
        public static async Task<UserPushToTalkGetAvailableUserListResponse> UserPushToTalkGetAvailableUserListRequest(this OcipClient client, UserPushToTalkGetAvailableUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPushToTalkGetAvailableUserListResponse;
        }

        /// <summary>
        /// Get a list of available users for the push to talk service.
        /// The response is either UserPushToTalkGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserPushToTalkGetAvailableUserListResponse> UserPushToTalkGetAvailableUserListRequestAsync(this OcipClient client, UserPushToTalkGetAvailableUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPushToTalkGetAvailableUserListResponse;
        }
        /// <summary>
        /// Request the push to talk service setting.
        /// The response is either a UserPushToTalkGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPushToTalkGetRequestAsync instead.")]
        public static async Task<UserPushToTalkGetResponse> UserPushToTalkGetRequest(this OcipClient client, UserPushToTalkGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPushToTalkGetResponse;
        }

        /// <summary>
        /// Request the push to talk service setting.
        /// The response is either a UserPushToTalkGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserPushToTalkGetResponse> UserPushToTalkGetRequestAsync(this OcipClient client, UserPushToTalkGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPushToTalkGetResponse;
        }
        /// <summary>
        /// Change the push to talk service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPushToTalkModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPushToTalkModifyRequest(this OcipClient client, UserPushToTalkModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Change the push to talk service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPushToTalkModifyRequestAsync(this OcipClient client, UserPushToTalkModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
