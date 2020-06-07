using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceReceptionistOfficeExtensions
    {

        /// <summary>
        /// Get the Receptionist Office available user list.
        /// The response is either UserBroadWorksReceptionistOfficeGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksReceptionistOfficeGetAvailableUserListRequestAsync instead.")]
        public static async Task<UserBroadWorksReceptionistOfficeGetAvailableUserListResponse> UserBroadWorksReceptionistOfficeGetAvailableUserListRequest(this OcipClient client, UserBroadWorksReceptionistOfficeGetAvailableUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserBroadWorksReceptionistOfficeGetAvailableUserListResponse;
        }

        /// <summary>
        /// Get the Receptionist Office available user list.
        /// The response is either UserBroadWorksReceptionistOfficeGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserBroadWorksReceptionistOfficeGetAvailableUserListResponse> UserBroadWorksReceptionistOfficeGetAvailableUserListRequestAsync(this OcipClient client, UserBroadWorksReceptionistOfficeGetAvailableUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserBroadWorksReceptionistOfficeGetAvailableUserListResponse;
        }
        /// <summary>
        /// Request the Receptionist Office parameters.
        /// The response is either a UserBroadWorksReceptionistOfficeGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksReceptionistOfficeGetRequestAsync instead.")]
        public static async Task<UserBroadWorksReceptionistOfficeGetResponse> UserBroadWorksReceptionistOfficeGetRequest(this OcipClient client, UserBroadWorksReceptionistOfficeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserBroadWorksReceptionistOfficeGetResponse;
        }

        /// <summary>
        /// Request the Receptionist Office parameters.
        /// The response is either a UserBroadWorksReceptionistOfficeGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserBroadWorksReceptionistOfficeGetResponse> UserBroadWorksReceptionistOfficeGetRequestAsync(this OcipClient client, UserBroadWorksReceptionistOfficeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserBroadWorksReceptionistOfficeGetResponse;
        }
        /// <summary>
        /// Replace the Receptionist Office monitored user list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksReceptionistOfficeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserBroadWorksReceptionistOfficeModifyRequest(this OcipClient client, UserBroadWorksReceptionistOfficeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Replace the Receptionist Office monitored user list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksReceptionistOfficeModifyRequestAsync(this OcipClient client, UserBroadWorksReceptionistOfficeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
