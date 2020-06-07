using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallParkExtensions
    {

        /// <summary>
        /// Adds a Call Park group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallParkAddInstanceRequest16sp2Async instead.")]
        public static async Task<SuccessResponse> GroupCallParkAddInstanceRequest16sp2(this OcipClient client, GroupCallParkAddInstanceRequest16sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Adds a Call Park group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallParkAddInstanceRequest16sp2Async(this OcipClient client, GroupCallParkAddInstanceRequest16sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Deletes a Call Park group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallParkDeleteInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallParkDeleteInstanceRequest(this OcipClient client, GroupCallParkDeleteInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Deletes a Call Park group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallParkDeleteInstanceRequestAsync(this OcipClient client, GroupCallParkDeleteInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of hunt groups that are available to select as an alternate recall user.
        /// The response is either GroupCallParkGetAvailableAlternateRecallUserListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallParkGetAvailableAlternateRecallUserListRequestAsync instead.")]
        public static async Task<GroupCallParkGetAvailableAlternateRecallUserListResponse> GroupCallParkGetAvailableAlternateRecallUserListRequest(this OcipClient client, GroupCallParkGetAvailableAlternateRecallUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallParkGetAvailableAlternateRecallUserListResponse;
        }

        /// <summary>
        /// Get a list of hunt groups that are available to select as an alternate recall user.
        /// The response is either GroupCallParkGetAvailableAlternateRecallUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallParkGetAvailableAlternateRecallUserListResponse> GroupCallParkGetAvailableAlternateRecallUserListRequestAsync(this OcipClient client, GroupCallParkGetAvailableAlternateRecallUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallParkGetAvailableAlternateRecallUserListResponse;
        }
        /// <summary>
        /// Get a list of hunt groups that are available to select as an alternate recall user.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending by default.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// The response is either GroupCallParkGetAvailableAlternateRecallUserPagedSortedListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallParkGetAvailableAlternateRecallUserPagedSortedListRequestAsync instead.")]
        public static async Task<GroupCallParkGetAvailableAlternateRecallUserPagedSortedListResponse> GroupCallParkGetAvailableAlternateRecallUserPagedSortedListRequest(this OcipClient client, GroupCallParkGetAvailableAlternateRecallUserPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallParkGetAvailableAlternateRecallUserPagedSortedListResponse;
        }

        /// <summary>
        /// Get a list of hunt groups that are available to select as an alternate recall user.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending by default.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// The response is either GroupCallParkGetAvailableAlternateRecallUserPagedSortedListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallParkGetAvailableAlternateRecallUserPagedSortedListResponse> GroupCallParkGetAvailableAlternateRecallUserPagedSortedListRequestAsync(this OcipClient client, GroupCallParkGetAvailableAlternateRecallUserPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallParkGetAvailableAlternateRecallUserPagedSortedListResponse;
        }
        /// <summary>
        /// Get a list of users that can be assigned to a Call Park group.
        /// The available user list for a new Call Park group can be obtained
        /// by not setting the name.
        /// The response is either GroupCallParkGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallParkGetAvailableUserListRequestAsync instead.")]
        public static async Task<GroupCallParkGetAvailableUserListResponse> GroupCallParkGetAvailableUserListRequest(this OcipClient client, GroupCallParkGetAvailableUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallParkGetAvailableUserListResponse;
        }

        /// <summary>
        /// Get a list of users that can be assigned to a Call Park group.
        /// The available user list for a new Call Park group can be obtained
        /// by not setting the name.
        /// The response is either GroupCallParkGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallParkGetAvailableUserListResponse> GroupCallParkGetAvailableUserListRequestAsync(this OcipClient client, GroupCallParkGetAvailableUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallParkGetAvailableUserListResponse;
        }
        /// <summary>
        /// Get a list of users that can be assigned to a Call Park group.
        /// The available user list for a new Call Park group can be obtained
        /// by not setting the name.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending by default.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// The response is either GroupCallParkGetAvailableUserPagedSortedListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallParkGetAvailableUserPagedSortedListRequestAsync instead.")]
        public static async Task<GroupCallParkGetAvailableUserPagedSortedListResponse> GroupCallParkGetAvailableUserPagedSortedListRequest(this OcipClient client, GroupCallParkGetAvailableUserPagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallParkGetAvailableUserPagedSortedListResponse;
        }

        /// <summary>
        /// Get a list of users that can be assigned to a Call Park group.
        /// The available user list for a new Call Park group can be obtained
        /// by not setting the name.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// If no sortOrder is included the response is sorted by User Id ascending by default.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// The response is either GroupCallParkGetAvailableUserPagedSortedListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallParkGetAvailableUserPagedSortedListResponse> GroupCallParkGetAvailableUserPagedSortedListRequestAsync(this OcipClient client, GroupCallParkGetAvailableUserPagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallParkGetAvailableUserPagedSortedListResponse;
        }
        /// <summary>
        /// Request to get a list of Call Park group instances within a group.
        /// The response is either GroupCallParkGetInstanceListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallParkGetInstanceListRequestAsync instead.")]
        public static async Task<GroupCallParkGetInstanceListResponse> GroupCallParkGetInstanceListRequest(this OcipClient client, GroupCallParkGetInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallParkGetInstanceListResponse;
        }

        /// <summary>
        /// Request to get a list of Call Park group instances within a group.
        /// The response is either GroupCallParkGetInstanceListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallParkGetInstanceListResponse> GroupCallParkGetInstanceListRequestAsync(this OcipClient client, GroupCallParkGetInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallParkGetInstanceListResponse;
        }
        /// <summary>
        /// Request to get a list of Call Park group instances within a group.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// The response is either GroupCallParkGetInstancePagedSortedListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallParkGetInstancePagedSortedListRequestAsync instead.")]
        public static async Task<GroupCallParkGetInstancePagedSortedListResponse> GroupCallParkGetInstancePagedSortedListRequest(this OcipClient client, GroupCallParkGetInstancePagedSortedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallParkGetInstancePagedSortedListResponse;
        }

        /// <summary>
        /// Request to get a list of Call Park group instances within a group.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// The response is either GroupCallParkGetInstancePagedSortedListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallParkGetInstancePagedSortedListResponse> GroupCallParkGetInstancePagedSortedListRequestAsync(this OcipClient client, GroupCallParkGetInstancePagedSortedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallParkGetInstancePagedSortedListResponse;
        }
        /// <summary>
        /// Gets a Call Park group.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// The sort order is based on the user order provided when creating or modifying the call park instance.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// The response is either GroupCallParkGetInstancePagedSortedResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallParkGetInstancePagedSortedRequestAsync instead.")]
        public static async Task<GroupCallParkGetInstancePagedSortedResponse> GroupCallParkGetInstancePagedSortedRequest(this OcipClient client, GroupCallParkGetInstancePagedSortedRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallParkGetInstancePagedSortedResponse;
        }

        /// <summary>
        /// Gets a Call Park group.
        /// 
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
        /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// 
        /// The sort order is based on the user order provided when creating or modifying the call park instance.
        /// 
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
        /// Then the search criteria are logically ORed together.
        /// 
        /// The response is either GroupCallParkGetInstancePagedSortedResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallParkGetInstancePagedSortedResponse> GroupCallParkGetInstancePagedSortedRequestAsync(this OcipClient client, GroupCallParkGetInstancePagedSortedRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallParkGetInstancePagedSortedResponse;
        }
        /// <summary>
        /// Gets a Call Park group.
        /// The response is either GroupCallParkGetInstanceResponse16sp2 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallParkGetInstanceRequest16sp2Async instead.")]
        public static async Task<GroupCallParkGetInstanceResponse16sp2> GroupCallParkGetInstanceRequest16sp2(this OcipClient client, GroupCallParkGetInstanceRequest16sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallParkGetInstanceResponse16sp2;
        }

        /// <summary>
        /// Gets a Call Park group.
        /// The response is either GroupCallParkGetInstanceResponse16sp2 or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallParkGetInstanceResponse16sp2> GroupCallParkGetInstanceRequest16sp2Async(this OcipClient client, GroupCallParkGetInstanceRequest16sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallParkGetInstanceResponse16sp2;
        }
        /// <summary>
        /// Gets the Call Park Group settings.
        /// The response is either GroupCallParkGetResponse16sp2 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallParkGetRequest16sp2Async instead.")]
        public static async Task<GroupCallParkGetResponse16sp2> GroupCallParkGetRequest16sp2(this OcipClient client, GroupCallParkGetRequest16sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallParkGetResponse16sp2;
        }

        /// <summary>
        /// Gets the Call Park Group settings.
        /// The response is either GroupCallParkGetResponse16sp2 or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallParkGetResponse16sp2> GroupCallParkGetRequest16sp2Async(this OcipClient client, GroupCallParkGetRequest16sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallParkGetResponse16sp2;
        }
        /// <summary>
        /// Modifies a Call Park group. Replaces the entire list of users in the group.
        /// The users are in the list are in the order they will try to be parked on.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallParkModifyInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallParkModifyInstanceRequest(this OcipClient client, GroupCallParkModifyInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies a Call Park group. Replaces the entire list of users in the group.
        /// The users are in the list are in the order they will try to be parked on.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallParkModifyInstanceRequestAsync(this OcipClient client, GroupCallParkModifyInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modifies the Group's Call Park settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallParkModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallParkModifyRequest(this OcipClient client, GroupCallParkModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the Group's Call Park settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallParkModifyRequestAsync(this OcipClient client, GroupCallParkModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Identifies which Call Park group the user belongs to if any and the list of users in the group.
        /// The response is either UserCallParkGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallParkGetRequestAsync instead.")]
        public static async Task<UserCallParkGetResponse> UserCallParkGetRequest(this OcipClient client, UserCallParkGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallParkGetResponse;
        }

        /// <summary>
        /// Identifies which Call Park group the user belongs to if any and the list of users in the group.
        /// The response is either UserCallParkGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserCallParkGetResponse> UserCallParkGetRequestAsync(this OcipClient client, UserCallParkGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallParkGetResponse;
        }

    }
}
