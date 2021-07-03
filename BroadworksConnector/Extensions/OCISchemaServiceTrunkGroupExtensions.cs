using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceTrunkGroupExtensions
    {

        /// <summary>
        /// Request to add an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseEnterpriseTrunkAddRequest21Async instead.")]
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkAddRequest21(this OcipClient client, EnterpriseEnterpriseTrunkAddRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkAddRequest21Async(this OcipClient client, EnterpriseEnterpriseTrunkAddRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add users to an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseEnterpriseTrunkAddUserListRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkAddUserListRequest(this OcipClient client, EnterpriseEnterpriseTrunkAddUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add users to an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkAddUserListRequestAsync(this OcipClient client, EnterpriseEnterpriseTrunkAddUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseEnterpriseTrunkDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkDeleteRequest(this OcipClient client, EnterpriseEnterpriseTrunkDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkDeleteRequestAsync(this OcipClient client, EnterpriseEnterpriseTrunkDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete users from an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseEnterpriseTrunkDeleteUserListRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkDeleteUserListRequest(this OcipClient client, EnterpriseEnterpriseTrunkDeleteUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete users from an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkDeleteUserListRequestAsync(this OcipClient client, EnterpriseEnterpriseTrunkDeleteUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add users to an enterprise trunk in an enterprise. If the user is already assigned to another enterprise trunk,
        /// it will be unassigned from the old enterprise trunk and assigned to the new enterprise trunk specified in this request.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseEnterpriseTrunkForceAssignUserListRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkForceAssignUserListRequest(this OcipClient client, EnterpriseEnterpriseTrunkForceAssignUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add users to an enterprise trunk in an enterprise. If the user is already assigned to another enterprise trunk,
        /// it will be unassigned from the old enterprise trunk and assigned to the new enterprise trunk specified in this request.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkForceAssignUserListRequestAsync(this OcipClient client, EnterpriseEnterpriseTrunkForceAssignUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of all available trunk groups defined in an enterprise.  It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListRequestAsync instead.")]
        public static async Task<EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListResponse> EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListRequest(this OcipClient client, EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListResponse;
        }

        /// <summary>
        /// Request to get the list of all available trunk groups defined in an enterprise.  It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListResponse> EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListRequestAsync(this OcipClient client, EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListResponse;
        }
        /// <summary>
        /// Request the list of users that are available to be added to an enterprise trunk.  This list contains users in the enterprise that are trunk users and not already assigned to an enterprise trunk.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either an EnterpriseEnterpriseTrunkGetAvailableUserListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseEnterpriseTrunkGetAvailableUserListRequestAsync instead.")]
        public static async Task<EnterpriseEnterpriseTrunkGetAvailableUserListResponse> EnterpriseEnterpriseTrunkGetAvailableUserListRequest(this OcipClient client, EnterpriseEnterpriseTrunkGetAvailableUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseEnterpriseTrunkGetAvailableUserListResponse;
        }

        /// <summary>
        /// Request the list of users that are available to be added to an enterprise trunk.  This list contains users in the enterprise that are trunk users and not already assigned to an enterprise trunk.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either an EnterpriseEnterpriseTrunkGetAvailableUserListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseEnterpriseTrunkGetAvailableUserListResponse> EnterpriseEnterpriseTrunkGetAvailableUserListRequestAsync(this OcipClient client, EnterpriseEnterpriseTrunkGetAvailableUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseEnterpriseTrunkGetAvailableUserListResponse;
        }
        /// <summary>
        /// Request to get the list of all enterprise trunks defined in an enterprise.
        /// The response is either a EnterpriseEnterpriseTrunkGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseEnterpriseTrunkGetListRequestAsync instead.")]
        public static async Task<EnterpriseEnterpriseTrunkGetListResponse> EnterpriseEnterpriseTrunkGetListRequest(this OcipClient client, EnterpriseEnterpriseTrunkGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseEnterpriseTrunkGetListResponse;
        }

        /// <summary>
        /// Request to get the list of all enterprise trunks defined in an enterprise.
        /// The response is either a EnterpriseEnterpriseTrunkGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseEnterpriseTrunkGetListResponse> EnterpriseEnterpriseTrunkGetListRequestAsync(this OcipClient client, EnterpriseEnterpriseTrunkGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseEnterpriseTrunkGetListResponse;
        }
        /// <summary>
        /// Request to get an enterprise trunk
        /// The response is either an EnterpriseEnterpriseTrunkGetResponse21 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseEnterpriseTrunkGetRequest22Async instead.")]
        public static async Task<EnterpriseEnterpriseTrunkGetResponse21> EnterpriseEnterpriseTrunkGetRequest22(this OcipClient client, EnterpriseEnterpriseTrunkGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseEnterpriseTrunkGetResponse21;
        }

        /// <summary>
        /// Request to get an enterprise trunk
        /// The response is either an EnterpriseEnterpriseTrunkGetResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseEnterpriseTrunkGetResponse21> EnterpriseEnterpriseTrunkGetRequest22Async(this OcipClient client, EnterpriseEnterpriseTrunkGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseEnterpriseTrunkGetResponse21;
        }
        /// <summary>
        /// Request the list of users in an enterprise trunk.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a EnterpriseEnterpriseTrunkGetUserListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseEnterpriseTrunkGetUserListRequestAsync instead.")]
        public static async Task<EnterpriseEnterpriseTrunkGetUserListResponse> EnterpriseEnterpriseTrunkGetUserListRequest(this OcipClient client, EnterpriseEnterpriseTrunkGetUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseEnterpriseTrunkGetUserListResponse;
        }

        /// <summary>
        /// Request the list of users in an enterprise trunk.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a EnterpriseEnterpriseTrunkGetUserListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseEnterpriseTrunkGetUserListResponse> EnterpriseEnterpriseTrunkGetUserListRequestAsync(this OcipClient client, EnterpriseEnterpriseTrunkGetUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseEnterpriseTrunkGetUserListResponse;
        }
        /// <summary>
        /// Request to modify an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseEnterpriseTrunkModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkModifyRequest(this OcipClient client, EnterpriseEnterpriseTrunkModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkModifyRequestAsync(this OcipClient client, EnterpriseEnterpriseTrunkModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of local gateways defined within an enterprise. Only the local gateways having device associated are returned.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// If no sortOrder is included the response is sorted by Trunk group name  ascending by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// The response is either a EnterpriseLocalGatewayGetPagedSortedListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseLocalGatewayGetPagedSortedListRequestAsync instead.")]
        public static async Task<EnterpriseLocalGatewayGetPagedSortedListResponse> EnterpriseLocalGatewayGetPagedSortedListRequest(this OcipClient client, EnterpriseLocalGatewayGetPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseLocalGatewayGetPagedSortedListResponse;
        }

        /// <summary>
        /// Get a list of local gateways defined within an enterprise. Only the local gateways having device associated are returned.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// If no sortOrder is included the response is sorted by Trunk group name  ascending by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// The response is either a EnterpriseLocalGatewayGetPagedSortedListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseLocalGatewayGetPagedSortedListResponse> EnterpriseLocalGatewayGetPagedSortedListRequestAsync(this OcipClient client, EnterpriseLocalGatewayGetPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseLocalGatewayGetPagedSortedListResponse;
        }
        /// <summary>
        /// Get usage details of a local gateway under an enterprise.
        /// The response is either EnterpriseLocalGatewayGetUsageResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseLocalGatewayGetUsageRequestAsync instead.")]
        public static async Task<EnterpriseLocalGatewayGetUsageResponse> EnterpriseLocalGatewayGetUsageRequest(this OcipClient client, EnterpriseLocalGatewayGetUsageRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseLocalGatewayGetUsageResponse;
        }

        /// <summary>
        /// Get usage details of a local gateway under an enterprise.
        /// The response is either EnterpriseLocalGatewayGetUsageResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseLocalGatewayGetUsageResponse> EnterpriseLocalGatewayGetUsageRequestAsync(this OcipClient client, EnterpriseLocalGatewayGetUsageRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseLocalGatewayGetUsageResponse;
        }
        /// <summary>
        /// Request to add an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnterpriseTrunkAddRequest21Async instead.")]
        public static async Task<SuccessResponse> GroupEnterpriseTrunkAddRequest21(this OcipClient client, GroupEnterpriseTrunkAddRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEnterpriseTrunkAddRequest21Async(this OcipClient client, GroupEnterpriseTrunkAddRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add users to an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnterpriseTrunkAddUserListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupEnterpriseTrunkAddUserListRequest(this OcipClient client, GroupEnterpriseTrunkAddUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add users to an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEnterpriseTrunkAddUserListRequestAsync(this OcipClient client, GroupEnterpriseTrunkAddUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnterpriseTrunkDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupEnterpriseTrunkDeleteRequest(this OcipClient client, GroupEnterpriseTrunkDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEnterpriseTrunkDeleteRequestAsync(this OcipClient client, GroupEnterpriseTrunkDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete users from an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnterpriseTrunkDeleteUserListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupEnterpriseTrunkDeleteUserListRequest(this OcipClient client, GroupEnterpriseTrunkDeleteUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete users from an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEnterpriseTrunkDeleteUserListRequestAsync(this OcipClient client, GroupEnterpriseTrunkDeleteUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add users to an enterprise trunk in a group. If the user is already assigned to another enterprise trunk,
        /// it will be unassigned from the old enterprise trunk and assigned to the new enterprise trunk specified in this request.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnterpriseTrunkForceAssignUserListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupEnterpriseTrunkForceAssignUserListRequest(this OcipClient client, GroupEnterpriseTrunkForceAssignUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add users to an enterprise trunk in a group. If the user is already assigned to another enterprise trunk,
        /// it will be unassigned from the old enterprise trunk and assigned to the new enterprise trunk specified in this request.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEnterpriseTrunkForceAssignUserListRequestAsync(this OcipClient client, GroupEnterpriseTrunkForceAssignUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of all available trunk groups defined in a group.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a GroupEnterpriseTrunkGetAvailableTrunkGroupListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnterpriseTrunkGetAvailableTrunkGroupListRequestAsync instead.")]
        public static async Task<GroupEnterpriseTrunkGetAvailableTrunkGroupListResponse> GroupEnterpriseTrunkGetAvailableTrunkGroupListRequest(this OcipClient client, GroupEnterpriseTrunkGetAvailableTrunkGroupListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupEnterpriseTrunkGetAvailableTrunkGroupListResponse;
        }

        /// <summary>
        /// Request to get the list of all available trunk groups defined in a group.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a GroupEnterpriseTrunkGetAvailableTrunkGroupListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupEnterpriseTrunkGetAvailableTrunkGroupListResponse> GroupEnterpriseTrunkGetAvailableTrunkGroupListRequestAsync(this OcipClient client, GroupEnterpriseTrunkGetAvailableTrunkGroupListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupEnterpriseTrunkGetAvailableTrunkGroupListResponse;
        }
        /// <summary>
        /// Request the list of users that are available to be added to an enterprise trunk.  This list contains users in the group that are trunk users and not already assigned to an enterprise trunk.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a GroupEnterpriseTrunkGetAvailableUserListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnterpriseTrunkGetAvailableUserListRequestAsync instead.")]
        public static async Task<GroupEnterpriseTrunkGetAvailableUserListResponse> GroupEnterpriseTrunkGetAvailableUserListRequest(this OcipClient client, GroupEnterpriseTrunkGetAvailableUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupEnterpriseTrunkGetAvailableUserListResponse;
        }

        /// <summary>
        /// Request the list of users that are available to be added to an enterprise trunk.  This list contains users in the group that are trunk users and not already assigned to an enterprise trunk.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a GroupEnterpriseTrunkGetAvailableUserListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupEnterpriseTrunkGetAvailableUserListResponse> GroupEnterpriseTrunkGetAvailableUserListRequestAsync(this OcipClient client, GroupEnterpriseTrunkGetAvailableUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupEnterpriseTrunkGetAvailableUserListResponse;
        }
        /// <summary>
        /// Request to get the list of all enterprise trunks defined in a group.
        /// The response is either a GroupEnterpriseTrunkGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnterpriseTrunkGetListRequestAsync instead.")]
        public static async Task<GroupEnterpriseTrunkGetListResponse> GroupEnterpriseTrunkGetListRequest(this OcipClient client, GroupEnterpriseTrunkGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupEnterpriseTrunkGetListResponse;
        }

        /// <summary>
        /// Request to get the list of all enterprise trunks defined in a group.
        /// The response is either a GroupEnterpriseTrunkGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupEnterpriseTrunkGetListResponse> GroupEnterpriseTrunkGetListRequestAsync(this OcipClient client, GroupEnterpriseTrunkGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupEnterpriseTrunkGetListResponse;
        }
        /// <summary>
        /// Request to get an enterprise trunk
        /// The response is either an GroupEnterpriseTrunkGetResponse22 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnterpriseTrunkGetRequest22Async instead.")]
        public static async Task<GroupEnterpriseTrunkGetResponse22> GroupEnterpriseTrunkGetRequest22(this OcipClient client, GroupEnterpriseTrunkGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupEnterpriseTrunkGetResponse22;
        }

        /// <summary>
        /// Request to get an enterprise trunk
        /// The response is either an GroupEnterpriseTrunkGetResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupEnterpriseTrunkGetResponse22> GroupEnterpriseTrunkGetRequest22Async(this OcipClient client, GroupEnterpriseTrunkGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupEnterpriseTrunkGetResponse22;
        }
        /// <summary>
        /// Request the list of users in an enterprise trunk.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a GroupEnterpriseTrunkGetUserListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnterpriseTrunkGetUserListRequestAsync instead.")]
        public static async Task<GroupEnterpriseTrunkGetUserListResponse> GroupEnterpriseTrunkGetUserListRequest(this OcipClient client, GroupEnterpriseTrunkGetUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupEnterpriseTrunkGetUserListResponse;
        }

        /// <summary>
        /// Request the list of users in an enterprise trunk.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a GroupEnterpriseTrunkGetUserListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupEnterpriseTrunkGetUserListResponse> GroupEnterpriseTrunkGetUserListRequestAsync(this OcipClient client, GroupEnterpriseTrunkGetUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupEnterpriseTrunkGetUserListResponse;
        }
        /// <summary>
        /// Request to modify an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupEnterpriseTrunkModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupEnterpriseTrunkModifyRequest(this OcipClient client, GroupEnterpriseTrunkModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEnterpriseTrunkModifyRequestAsync(this OcipClient client, GroupEnterpriseTrunkModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Trunk Group instance to a group.
        /// The command will fail if enableNetworkAddressIdentity is set to
        /// true and administrator is not System/Provisioning level administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Following attributes are only used in IMS mode:
        /// implicitRegistrationSetSupportPolicy
        /// useSystemImplicitRegistrationSetSupportPolicy
        /// sipIdentityForPilotAndProxyTrunkModesPolicy
        /// useSystemSIPIdentityForPilotAndProxyTrunkModesPolicy
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupAddInstanceRequest22Async instead.")]
        public static async Task<SuccessResponse> GroupTrunkGroupAddInstanceRequest22(this OcipClient client, GroupTrunkGroupAddInstanceRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Trunk Group instance to a group.
        /// The command will fail if enableNetworkAddressIdentity is set to
        /// true and administrator is not System/Provisioning level administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Following attributes are only used in IMS mode:
        /// implicitRegistrationSetSupportPolicy
        /// useSystemImplicitRegistrationSetSupportPolicy
        /// sipIdentityForPilotAndProxyTrunkModesPolicy
        /// useSystemSIPIdentityForPilotAndProxyTrunkModesPolicy
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupAddInstanceRequest22Async(this OcipClient client, GroupTrunkGroupAddInstanceRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Trunk Group Instance from a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupDeleteInstanceRequest14sp4Async instead.")]
        public static async Task<SuccessResponse> GroupTrunkGroupDeleteInstanceRequest14sp4(this OcipClient client, GroupTrunkGroupDeleteInstanceRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Trunk Group Instance from a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupDeleteInstanceRequest14sp4Async(this OcipClient client, GroupTrunkGroupDeleteInstanceRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of hosted users that can be assigned to a Trunk Group.
        /// The response is either GroupTrunkGroupGetAvailableHostedUserListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupGetAvailableHostedUserListRequestAsync instead.")]
        public static async Task<GroupTrunkGroupGetAvailableHostedUserListResponse> GroupTrunkGroupGetAvailableHostedUserListRequest(this OcipClient client, GroupTrunkGroupGetAvailableHostedUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupTrunkGroupGetAvailableHostedUserListResponse;
        }

        /// <summary>
        /// Get a list of hosted users that can be assigned to a Trunk Group.
        /// The response is either GroupTrunkGroupGetAvailableHostedUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupGetAvailableHostedUserListResponse> GroupTrunkGroupGetAvailableHostedUserListRequestAsync(this OcipClient client, GroupTrunkGroupGetAvailableHostedUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupTrunkGroupGetAvailableHostedUserListResponse;
        }
        /// <summary>
        /// Get a list of Trunk Groups for the group or enterprise.
        /// It is possible to restrict the results to a particular department, or expand the list to the entire enterprise.
        /// The response is either a GroupTrunkGroupGetInstanceListResponse14sp4 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupGetInstanceListRequest14sp4Async instead.")]
        public static async Task<GroupTrunkGroupGetInstanceListResponse14sp4> GroupTrunkGroupGetInstanceListRequest14sp4(this OcipClient client, GroupTrunkGroupGetInstanceListRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupTrunkGroupGetInstanceListResponse14sp4;
        }

        /// <summary>
        /// Get a list of Trunk Groups for the group or enterprise.
        /// It is possible to restrict the results to a particular department, or expand the list to the entire enterprise.
        /// The response is either a GroupTrunkGroupGetInstanceListResponse14sp4 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceListResponse14sp4> GroupTrunkGroupGetInstanceListRequest14sp4Async(this OcipClient client, GroupTrunkGroupGetInstanceListRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupTrunkGroupGetInstanceListResponse14sp4;
        }
        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse23 or an ErrorResponse.
        /// The response contains a hosted user table with column headings: "User Id", "Last Name",
        /// "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number", "Extension",
        /// "Department", "Email Address".
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupGetInstanceRequest23Async instead.")]
        public static async Task<GroupTrunkGroupGetInstanceResponse23> GroupTrunkGroupGetInstanceRequest23(this OcipClient client, GroupTrunkGroupGetInstanceRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupTrunkGroupGetInstanceResponse23;
        }

        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse23 or an ErrorResponse.
        /// The response contains a hosted user table with column headings: "User Id", "Last Name",
        /// "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number", "Extension",
        /// "Department", "Email Address".
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceResponse23> GroupTrunkGroupGetInstanceRequest23Async(this OcipClient client, GroupTrunkGroupGetInstanceRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupTrunkGroupGetInstanceResponse23;
        }
        /// <summary>
        /// Get a list of user's on a Trunk Group Instance.
        /// The response is either a GroupTrunkGroupGetInstanceUserListResponse14sp4 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupGetInstanceUserListRequest14sp4Async instead.")]
        public static async Task<GroupTrunkGroupGetInstanceUserListResponse14sp4> GroupTrunkGroupGetInstanceUserListRequest14sp4(this OcipClient client, GroupTrunkGroupGetInstanceUserListRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupTrunkGroupGetInstanceUserListResponse14sp4;
        }

        /// <summary>
        /// Get a list of user's on a Trunk Group Instance.
        /// The response is either a GroupTrunkGroupGetInstanceUserListResponse14sp4 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceUserListResponse14sp4> GroupTrunkGroupGetInstanceUserListRequest14sp4Async(this OcipClient client, GroupTrunkGroupGetInstanceUserListRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupTrunkGroupGetInstanceUserListResponse14sp4;
        }
        /// <summary>
        /// Get the maximum and bursting maximum permissible active trunk group calls for the group.
        /// The response is either a GroupTrunkGroupGetResponse23 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupGetRequest23Async instead.")]
        public static async Task<GroupTrunkGroupGetResponse23> GroupTrunkGroupGetRequest23(this OcipClient client, GroupTrunkGroupGetRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupTrunkGroupGetResponse23;
        }

        /// <summary>
        /// Get the maximum and bursting maximum permissible active trunk group calls for the group.
        /// The response is either a GroupTrunkGroupGetResponse23 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupGetResponse23> GroupTrunkGroupGetRequest23Async(this OcipClient client, GroupTrunkGroupGetRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupTrunkGroupGetResponse23;
        }
        /// <summary>
        /// Modify a Trunk Group Instance in a group.
        /// The access device cannot be modified or cleared if there are any users assigned to the Trunk Group.
        /// The command will fail if enableNetworkAddressIdentity is set and
        /// administrator is not System/Provisioning level administrator.
        /// Following attributes are only used in IMS mode:
        /// implicitRegistrationSetSupportPolicy
        /// useSystemImplicitRegistrationSetSupportPolicy
        /// sipIdentityForPilotAndProxyTrunkModesPolicy
        /// useSystemSIPIdentityForPilotAndProxyTrunkModesPolicy
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupModifyInstanceRequest20sp1Async instead.")]
        public static async Task<SuccessResponse> GroupTrunkGroupModifyInstanceRequest20sp1(this OcipClient client, GroupTrunkGroupModifyInstanceRequest20sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Trunk Group Instance in a group.
        /// The access device cannot be modified or cleared if there are any users assigned to the Trunk Group.
        /// The command will fail if enableNetworkAddressIdentity is set and
        /// administrator is not System/Provisioning level administrator.
        /// Following attributes are only used in IMS mode:
        /// implicitRegistrationSetSupportPolicy
        /// useSystemImplicitRegistrationSetSupportPolicy
        /// sipIdentityForPilotAndProxyTrunkModesPolicy
        /// useSystemSIPIdentityForPilotAndProxyTrunkModesPolicy
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupModifyInstanceRequest20sp1Async(this OcipClient client, GroupTrunkGroupModifyInstanceRequest20sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the maximum and bursting maximum permissible active Trunk Group calls for the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupModifyRequest14sp9Async instead.")]
        public static async Task<SuccessResponse> GroupTrunkGroupModifyRequest14sp9(this OcipClient client, GroupTrunkGroupModifyRequest14sp9 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the maximum and bursting maximum permissible active Trunk Group calls for the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupModifyRequest14sp9Async(this OcipClient client, GroupTrunkGroupModifyRequest14sp9 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a list of trunk group level successful SIP OPTIONS message respoonse status codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupOptionsMessageResponseStatusCodeAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupTrunkGroupOptionsMessageResponseStatusCodeAddListRequest(this OcipClient client, GroupTrunkGroupOptionsMessageResponseStatusCodeAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of trunk group level successful SIP OPTIONS message respoonse status codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupOptionsMessageResponseStatusCodeAddListRequestAsync(this OcipClient client, GroupTrunkGroupOptionsMessageResponseStatusCodeAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a user creation task for a trunk group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupUserCreationTaskAddRequest14sp4Async instead.")]
        public static async Task<SuccessResponse> GroupTrunkGroupUserCreationTaskAddRequest14sp4(this OcipClient client, GroupTrunkGroupUserCreationTaskAddRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a user creation task for a trunk group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupUserCreationTaskAddRequest14sp4Async(this OcipClient client, GroupTrunkGroupUserCreationTaskAddRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a user creation task for a trunk group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupUserCreationTaskDeleteRequest14sp4Async instead.")]
        public static async Task<SuccessResponse> GroupTrunkGroupUserCreationTaskDeleteRequest14sp4(this OcipClient client, GroupTrunkGroupUserCreationTaskDeleteRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a user creation task for a trunk group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupUserCreationTaskDeleteRequest14sp4Async(this OcipClient client, GroupTrunkGroupUserCreationTaskDeleteRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of user creation tasks for a trunk group.
        /// The response is either GroupTrunkGroupUserCreationTaskGetListResponse14sp4 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupUserCreationTaskGetListRequest14sp4Async instead.")]
        public static async Task<GroupTrunkGroupUserCreationTaskGetListResponse14sp4> GroupTrunkGroupUserCreationTaskGetListRequest14sp4(this OcipClient client, GroupTrunkGroupUserCreationTaskGetListRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupTrunkGroupUserCreationTaskGetListResponse14sp4;
        }

        /// <summary>
        /// Get the list of user creation tasks for a trunk group.
        /// The response is either GroupTrunkGroupUserCreationTaskGetListResponse14sp4 or ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupUserCreationTaskGetListResponse14sp4> GroupTrunkGroupUserCreationTaskGetListRequest14sp4Async(this OcipClient client, GroupTrunkGroupUserCreationTaskGetListRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupTrunkGroupUserCreationTaskGetListResponse14sp4;
        }
        /// <summary>
        /// Request the details of a specified user creation task for a trunk group.
        /// The response is either GroupTrunkGroupUserCreationTaskGetResponse14sp4 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupTrunkGroupUserCreationTaskGetRequest14sp4Async instead.")]
        public static async Task<GroupTrunkGroupUserCreationTaskGetResponse14sp4> GroupTrunkGroupUserCreationTaskGetRequest14sp4(this OcipClient client, GroupTrunkGroupUserCreationTaskGetRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupTrunkGroupUserCreationTaskGetResponse14sp4;
        }

        /// <summary>
        /// Request the details of a specified user creation task for a trunk group.
        /// The response is either GroupTrunkGroupUserCreationTaskGetResponse14sp4 or ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupUserCreationTaskGetResponse14sp4> GroupTrunkGroupUserCreationTaskGetRequest14sp4Async(this OcipClient client, GroupTrunkGroupUserCreationTaskGetRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupTrunkGroupUserCreationTaskGetResponse14sp4;
        }
        /// <summary>
        /// Get the maximum and bursting maximum permissible active Trunk Group calls for the service provider.
        /// The response is either a ServiceProviderTrunkGroupGetResponse23 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderTrunkGroupGetRequest23Async instead.")]
        public static async Task<ServiceProviderTrunkGroupGetResponse23> ServiceProviderTrunkGroupGetRequest23(this OcipClient client, ServiceProviderTrunkGroupGetRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderTrunkGroupGetResponse23;
        }

        /// <summary>
        /// Get the maximum and bursting maximum permissible active Trunk Group calls for the service provider.
        /// The response is either a ServiceProviderTrunkGroupGetResponse23 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderTrunkGroupGetResponse23> ServiceProviderTrunkGroupGetRequest23Async(this OcipClient client, ServiceProviderTrunkGroupGetRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderTrunkGroupGetResponse23;
        }
        /// <summary>
        /// Modify the maximum and bursting maximum permissible active Trunk Group calls for the service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderTrunkGroupModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderTrunkGroupModifyRequest(this OcipClient client, ServiceProviderTrunkGroupModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the maximum and bursting maximum permissible active Trunk Group calls for the service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderTrunkGroupModifyRequestAsync(this OcipClient client, ServiceProviderTrunkGroupModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with the Enterprise Trunk service.
        /// The response is either SystemEnterpriseTrunkGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemEnterpriseTrunkGetRequestAsync instead.")]
        public static async Task<SystemEnterpriseTrunkGetResponse> SystemEnterpriseTrunkGetRequest(this OcipClient client, SystemEnterpriseTrunkGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemEnterpriseTrunkGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with the Enterprise Trunk service.
        /// The response is either SystemEnterpriseTrunkGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemEnterpriseTrunkGetResponse> SystemEnterpriseTrunkGetRequestAsync(this OcipClient client, SystemEnterpriseTrunkGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemEnterpriseTrunkGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with the Enterprise Trunk Service.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemEnterpriseTrunkModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemEnterpriseTrunkModifyRequest(this OcipClient client, SystemEnterpriseTrunkModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with the Enterprise Trunk Service.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemEnterpriseTrunkModifyRequestAsync(this OcipClient client, SystemEnterpriseTrunkModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with the Trunk Group service.
        /// The response is either SystemTrunkGroupGetResponse24 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTrunkGroupGetRequest24Async instead.")]
        public static async Task<SystemTrunkGroupGetResponse24> SystemTrunkGroupGetRequest24(this OcipClient client, SystemTrunkGroupGetRequest24 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTrunkGroupGetResponse24;
        }

        /// <summary>
        /// Request the system level data associated with the Trunk Group service.
        /// The response is either SystemTrunkGroupGetResponse24 or ErrorResponse.
        /// </summary>
        public static async Task<SystemTrunkGroupGetResponse24> SystemTrunkGroupGetRequest24Async(this OcipClient client, SystemTrunkGroupGetRequest24 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTrunkGroupGetResponse24;
        }
        /// <summary>
        /// Modify the system level data associated with the Trunk Group Service.
        /// Following attributes are only used in IMS mode. The values are saved if specified not in IMS mode:
        /// implicitRegistrationSetSupportPolicy
        /// sipIdentityForPilotAndProxyTrunkModesPolicy
        /// useMostRecentEntryOnDeflection
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTrunkGroupModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTrunkGroupModifyRequest(this OcipClient client, SystemTrunkGroupModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with the Trunk Group Service.
        /// Following attributes are only used in IMS mode. The values are saved if specified not in IMS mode:
        /// implicitRegistrationSetSupportPolicy
        /// sipIdentityForPilotAndProxyTrunkModesPolicy
        /// useMostRecentEntryOnDeflection
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTrunkGroupModifyRequestAsync(this OcipClient client, SystemTrunkGroupModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a list of system level successful SIP OPTIONS message respoonse status codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTrunkGroupOptionsMessageResponseStatusCodeAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTrunkGroupOptionsMessageResponseStatusCodeAddListRequest(this OcipClient client, SystemTrunkGroupOptionsMessageResponseStatusCodeAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of system level successful SIP OPTIONS message respoonse status codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTrunkGroupOptionsMessageResponseStatusCodeAddListRequestAsync(this OcipClient client, SystemTrunkGroupOptionsMessageResponseStatusCodeAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of system level successful SIP OPTIONS message respoonse status codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTrunkGroupOptionsMessageResponseStatusCodeDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTrunkGroupOptionsMessageResponseStatusCodeDeleteListRequest(this OcipClient client, SystemTrunkGroupOptionsMessageResponseStatusCodeDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of system level successful SIP OPTIONS message respoonse status codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTrunkGroupOptionsMessageResponseStatusCodeDeleteListRequestAsync(this OcipClient client, SystemTrunkGroupOptionsMessageResponseStatusCodeDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of system level successful SIP OPTIONS message respoonse status codes.
        /// The response is either SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTrunkGroupOptionsMessageResponseStatusCodeGetListRequestAsync instead.")]
        public static async Task<SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse> SystemTrunkGroupOptionsMessageResponseStatusCodeGetListRequest(this OcipClient client, SystemTrunkGroupOptionsMessageResponseStatusCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse;
        }

        /// <summary>
        /// Get the list of system level successful SIP OPTIONS message respoonse status codes.
        /// The response is either SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse> SystemTrunkGroupOptionsMessageResponseStatusCodeGetListRequestAsync(this OcipClient client, SystemTrunkGroupOptionsMessageResponseStatusCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse;
        }
        /// <summary>
        /// Get the list of user creation tasks in the system.
        /// The response is either SystemTrunkGroupUserCreationTaskGetListResponse14sp4 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTrunkGroupUserCreationTaskGetListRequest14sp4Async instead.")]
        public static async Task<SystemTrunkGroupUserCreationTaskGetListResponse14sp4> SystemTrunkGroupUserCreationTaskGetListRequest14sp4(this OcipClient client, SystemTrunkGroupUserCreationTaskGetListRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTrunkGroupUserCreationTaskGetListResponse14sp4;
        }

        /// <summary>
        /// Get the list of user creation tasks in the system.
        /// The response is either SystemTrunkGroupUserCreationTaskGetListResponse14sp4 or ErrorResponse.
        /// </summary>
        public static async Task<SystemTrunkGroupUserCreationTaskGetListResponse14sp4> SystemTrunkGroupUserCreationTaskGetListRequest14sp4Async(this OcipClient client, SystemTrunkGroupUserCreationTaskGetListRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTrunkGroupUserCreationTaskGetListResponse14sp4;
        }

    }
}
