using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceSeriesCompletionExtensions
    {

        /// <summary>
        /// Adds a Series Completion group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupSeriesCompletionAddInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupSeriesCompletionAddInstanceRequest(this OcipClient client, GroupSeriesCompletionAddInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Adds a Series Completion group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupSeriesCompletionAddInstanceRequestAsync(this OcipClient client, GroupSeriesCompletionAddInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Deletes a Series Completion group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupSeriesCompletionDeleteInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupSeriesCompletionDeleteInstanceRequest(this OcipClient client, GroupSeriesCompletionDeleteInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Deletes a Series Completion group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupSeriesCompletionDeleteInstanceRequestAsync(this OcipClient client, GroupSeriesCompletionDeleteInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of users that can be assigned to a Series Completion group.
        /// The available user list for a new Series Completion group can be obtained
        /// by not setting the name.
        /// The response is either GroupSeriesCompletionGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupSeriesCompletionGetAvailableUserListRequestAsync instead.")]
        public static async Task<GroupSeriesCompletionGetAvailableUserListResponse> GroupSeriesCompletionGetAvailableUserListRequest(this OcipClient client, GroupSeriesCompletionGetAvailableUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupSeriesCompletionGetAvailableUserListResponse;
        }

        /// <summary>
        /// Get a list of users that can be assigned to a Series Completion group.
        /// The available user list for a new Series Completion group can be obtained
        /// by not setting the name.
        /// The response is either GroupSeriesCompletionGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupSeriesCompletionGetAvailableUserListResponse> GroupSeriesCompletionGetAvailableUserListRequestAsync(this OcipClient client, GroupSeriesCompletionGetAvailableUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupSeriesCompletionGetAvailableUserListResponse;
        }
        /// <summary>
        /// Request to get a list of Series Completion instances within a group.
        /// The response is either GroupSeriesCompletionGetInstanceListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupSeriesCompletionGetInstanceListRequestAsync instead.")]
        public static async Task<GroupSeriesCompletionGetInstanceListResponse> GroupSeriesCompletionGetInstanceListRequest(this OcipClient client, GroupSeriesCompletionGetInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupSeriesCompletionGetInstanceListResponse;
        }

        /// <summary>
        /// Request to get a list of Series Completion instances within a group.
        /// The response is either GroupSeriesCompletionGetInstanceListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupSeriesCompletionGetInstanceListResponse> GroupSeriesCompletionGetInstanceListRequestAsync(this OcipClient client, GroupSeriesCompletionGetInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupSeriesCompletionGetInstanceListResponse;
        }
        /// <summary>
        /// Gets a Series Completion group.
        /// The response is either GroupSeriesCompletionGetInstanceResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupSeriesCompletionGetInstanceRequestAsync instead.")]
        public static async Task<GroupSeriesCompletionGetInstanceResponse> GroupSeriesCompletionGetInstanceRequest(this OcipClient client, GroupSeriesCompletionGetInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupSeriesCompletionGetInstanceResponse;
        }

        /// <summary>
        /// Gets a Series Completion group.
        /// The response is either GroupSeriesCompletionGetInstanceResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupSeriesCompletionGetInstanceResponse> GroupSeriesCompletionGetInstanceRequestAsync(this OcipClient client, GroupSeriesCompletionGetInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupSeriesCompletionGetInstanceResponse;
        }
        /// <summary>
        /// Modifies a Series Completion group. Replaces the entire list of users in the group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupSeriesCompletionModifyInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupSeriesCompletionModifyInstanceRequest(this OcipClient client, GroupSeriesCompletionModifyInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies a Series Completion group. Replaces the entire list of users in the group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupSeriesCompletionModifyInstanceRequestAsync(this OcipClient client, GroupSeriesCompletionModifyInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Gets the details of the Series Completion group that a user belongs to (if any).
        /// Any user can only belong to one Series Completion group.
        /// The response is either UserSeriesCompletionGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSeriesCompletionGetRequestAsync instead.")]
        public static async Task<UserSeriesCompletionGetResponse> UserSeriesCompletionGetRequest(this OcipClient client, UserSeriesCompletionGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserSeriesCompletionGetResponse;
        }

        /// <summary>
        /// Gets the details of the Series Completion group that a user belongs to (if any).
        /// Any user can only belong to one Series Completion group.
        /// The response is either UserSeriesCompletionGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserSeriesCompletionGetResponse> UserSeriesCompletionGetRequestAsync(this OcipClient client, UserSeriesCompletionGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserSeriesCompletionGetResponse;
        }

    }
}
