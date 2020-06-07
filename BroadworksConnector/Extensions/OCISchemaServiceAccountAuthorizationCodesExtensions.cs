using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceAccountAuthorizationCodesExtensions
    {

        /// <summary>
        /// Add a list of account/authorization codes to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccountAuthorizationCodesAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAccountAuthorizationCodesAddListRequest(this OcipClient client, GroupAccountAuthorizationCodesAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of account/authorization codes to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAccountAuthorizationCodesAddListRequestAsync(this OcipClient client, GroupAccountAuthorizationCodesAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of account/authorization codes from a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccountAuthorizationCodesDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAccountAuthorizationCodesDeleteListRequest(this OcipClient client, GroupAccountAuthorizationCodesDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of account/authorization codes from a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAccountAuthorizationCodesDeleteListRequestAsync(this OcipClient client, GroupAccountAuthorizationCodesDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of non restricted users for the account/authorization codes service.
        /// The response is either GroupAccountAuthorizationCodesGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccountAuthorizationCodesGetAvailableUserListRequestAsync instead.")]
        public static async Task<GroupAccountAuthorizationCodesGetAvailableUserListResponse> GroupAccountAuthorizationCodesGetAvailableUserListRequest(this OcipClient client, GroupAccountAuthorizationCodesGetAvailableUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAccountAuthorizationCodesGetAvailableUserListResponse;
        }

        /// <summary>
        /// Get a list of non restricted users for the account/authorization codes service.
        /// The response is either GroupAccountAuthorizationCodesGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupAccountAuthorizationCodesGetAvailableUserListResponse> GroupAccountAuthorizationCodesGetAvailableUserListRequestAsync(this OcipClient client, GroupAccountAuthorizationCodesGetAvailableUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAccountAuthorizationCodesGetAvailableUserListResponse;
        }
        /// <summary>
        /// Request the list of account/authorization codes for a group.
        /// The response is either a GroupAccountAuthorizationCodesGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccountAuthorizationCodesGetListRequestAsync instead.")]
        public static async Task<GroupAccountAuthorizationCodesGetListResponse> GroupAccountAuthorizationCodesGetListRequest(this OcipClient client, GroupAccountAuthorizationCodesGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAccountAuthorizationCodesGetListResponse;
        }

        /// <summary>
        /// Request the list of account/authorization codes for a group.
        /// The response is either a GroupAccountAuthorizationCodesGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupAccountAuthorizationCodesGetListResponse> GroupAccountAuthorizationCodesGetListRequestAsync(this OcipClient client, GroupAccountAuthorizationCodesGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAccountAuthorizationCodesGetListResponse;
        }
        /// <summary>
        /// Request the group's account/authorization codes setting.
        /// The response is either a GroupAccountAuthorizationCodesGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccountAuthorizationCodesGetRequestAsync instead.")]
        public static async Task<GroupAccountAuthorizationCodesGetResponse> GroupAccountAuthorizationCodesGetRequest(this OcipClient client, GroupAccountAuthorizationCodesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAccountAuthorizationCodesGetResponse;
        }

        /// <summary>
        /// Request the group's account/authorization codes setting.
        /// The response is either a GroupAccountAuthorizationCodesGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupAccountAuthorizationCodesGetResponse> GroupAccountAuthorizationCodesGetRequestAsync(this OcipClient client, GroupAccountAuthorizationCodesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAccountAuthorizationCodesGetResponse;
        }
        /// <summary>
        /// Change the group's account/authorization codes setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccountAuthorizationCodesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAccountAuthorizationCodesModifyRequest(this OcipClient client, GroupAccountAuthorizationCodesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Change the group's account/authorization codes setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAccountAuthorizationCodesModifyRequestAsync(this OcipClient client, GroupAccountAuthorizationCodesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
