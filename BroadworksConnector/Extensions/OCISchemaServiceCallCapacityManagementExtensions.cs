using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallCapacityManagementExtensions
    {

        /// <summary>
        /// Adds a Call Capacity Management group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCapacityManagementAddInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCapacityManagementAddInstanceRequest(this OcipClient client, GroupCallCapacityManagementAddInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Adds a Call Capacity Management group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCapacityManagementAddInstanceRequestAsync(this OcipClient client, GroupCallCapacityManagementAddInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Adds one or more users to a Call Capacity Management group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCapacityManagementAddUserListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCapacityManagementAddUserListRequest(this OcipClient client, GroupCallCapacityManagementAddUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Adds one or more users to a Call Capacity Management group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCapacityManagementAddUserListRequestAsync(this OcipClient client, GroupCallCapacityManagementAddUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Deletes one or more Call Capacity Management groups.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCapacityManagementDeleteInstanceListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCapacityManagementDeleteInstanceListRequest(this OcipClient client, GroupCallCapacityManagementDeleteInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Deletes one or more Call Capacity Management groups.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCapacityManagementDeleteInstanceListRequestAsync(this OcipClient client, GroupCallCapacityManagementDeleteInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Deletes one or more users from a Call Capacity Management group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCapacityManagementDeleteUserListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCapacityManagementDeleteUserListRequest(this OcipClient client, GroupCallCapacityManagementDeleteUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Deletes one or more users from a Call Capacity Management group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCapacityManagementDeleteUserListRequestAsync(this OcipClient client, GroupCallCapacityManagementDeleteUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of users that can be assigned to a Call Capacity Management group.
        /// The available user list for a new Call Capacity Management group can be obtained
        /// by not setting the name.
        /// The response is either GroupCallCapacityManagementGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCapacityManagementGetAvailableUserListRequestAsync instead.")]
        public static async Task<GroupCallCapacityManagementGetAvailableUserListResponse> GroupCallCapacityManagementGetAvailableUserListRequest(this OcipClient client, GroupCallCapacityManagementGetAvailableUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCapacityManagementGetAvailableUserListResponse;
        }

        /// <summary>
        /// Get a list of users that can be assigned to a Call Capacity Management group.
        /// The available user list for a new Call Capacity Management group can be obtained
        /// by not setting the name.
        /// The response is either GroupCallCapacityManagementGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCapacityManagementGetAvailableUserListResponse> GroupCallCapacityManagementGetAvailableUserListRequestAsync(this OcipClient client, GroupCallCapacityManagementGetAvailableUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCapacityManagementGetAvailableUserListResponse;
        }
        /// <summary>
        /// Request to get a list of Call Capacity Management instances within a group.
        /// The response is either GroupCallCapacityManagementGetInstanceListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCapacityManagementGetInstanceListRequestAsync instead.")]
        public static async Task<GroupCallCapacityManagementGetInstanceListResponse> GroupCallCapacityManagementGetInstanceListRequest(this OcipClient client, GroupCallCapacityManagementGetInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCapacityManagementGetInstanceListResponse;
        }

        /// <summary>
        /// Request to get a list of Call Capacity Management instances within a group.
        /// The response is either GroupCallCapacityManagementGetInstanceListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCapacityManagementGetInstanceListResponse> GroupCallCapacityManagementGetInstanceListRequestAsync(this OcipClient client, GroupCallCapacityManagementGetInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCapacityManagementGetInstanceListResponse;
        }
        /// <summary>
        /// Gets a Call Capacity Management group.
        /// The response is either GroupCallCapacityManagementGetInstanceResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCapacityManagementGetInstanceRequestAsync instead.")]
        public static async Task<GroupCallCapacityManagementGetInstanceResponse> GroupCallCapacityManagementGetInstanceRequest(this OcipClient client, GroupCallCapacityManagementGetInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCapacityManagementGetInstanceResponse;
        }

        /// <summary>
        /// Gets a Call Capacity Management group.
        /// The response is either GroupCallCapacityManagementGetInstanceResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCapacityManagementGetInstanceResponse> GroupCallCapacityManagementGetInstanceRequestAsync(this OcipClient client, GroupCallCapacityManagementGetInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCapacityManagementGetInstanceResponse;
        }
        /// <summary>
        /// Modifies a Call Capacity Management group. Replaces the entire list of users in the group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCapacityManagementModifyInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCapacityManagementModifyInstanceRequest(this OcipClient client, GroupCallCapacityManagementModifyInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies a Call Capacity Management group. Replaces the entire list of users in the group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCapacityManagementModifyInstanceRequestAsync(this OcipClient client, GroupCallCapacityManagementModifyInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
