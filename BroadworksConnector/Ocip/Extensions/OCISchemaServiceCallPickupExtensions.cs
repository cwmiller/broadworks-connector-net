using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceCallPickupExtensions
{

    /// <summary>
    /// Adds a Call Pickup group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupCallPickupAddInstanceRequest(this OcipClient client, GroupCallPickupAddInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Deletes a Call Pickup group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupCallPickupDeleteInstanceRequest(this OcipClient client, GroupCallPickupDeleteInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get a list of users that can be assigned to a Call Pickup group.
    /// The available user list for a new Call Pickup group can be obtained
    /// by not setting the name.
    /// The response is either GroupCallPickupGetAvailableUserListResponse or ErrorResponse.
    /// </summary>
    public static async Task<GroupCallPickupGetAvailableUserListResponse> GroupCallPickupGetAvailableUserListRequest(this OcipClient client, GroupCallPickupGetAvailableUserListRequest request) {
        return await client.Call(request) as GroupCallPickupGetAvailableUserListResponse;
    }

    /// <summary>
    /// Get a list of users that can be assigned to a Call Pickup group.
    /// The available user list for a new Call Pickup group can be obtained
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
    /// The response is either GroupCallPickupGetAvailableUserPagedSortedListResponse or ErrorResponse.
    /// </summary>
    public static async Task<GroupCallPickupGetAvailableUserPagedSortedListResponse> GroupCallPickupGetAvailableUserPagedSortedListRequest(this OcipClient client, GroupCallPickupGetAvailableUserPagedSortedListRequest request) {
        return await client.Call(request) as GroupCallPickupGetAvailableUserPagedSortedListResponse;
    }

    /// <summary>
    /// Request to get a list of Call Pickup instances within a group.
    /// The response is either GroupCallPickupGetInstanceListResponse or ErrorResponse.
    /// </summary>
    public static async Task<GroupCallPickupGetInstanceListResponse> GroupCallPickupGetInstanceListRequest(this OcipClient client, GroupCallPickupGetInstanceListRequest request) {
        return await client.Call(request) as GroupCallPickupGetInstanceListResponse;
    }

    /// <summary>
    /// Request to get a list of Call Pickup instances within a group.
    /// 
    /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
    /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
    /// It is possible to search by various criteria to restrict the number of rows returned.
    /// 
    /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
    /// Then the search criteria are logically ORed together.
    /// 
    /// The response is either GroupCallPickupGetInstancePagedSortedListResponse or ErrorResponse.
    /// </summary>
    public static async Task<GroupCallPickupGetInstancePagedSortedListResponse> GroupCallPickupGetInstancePagedSortedListRequest(this OcipClient client, GroupCallPickupGetInstancePagedSortedListRequest request) {
        return await client.Call(request) as GroupCallPickupGetInstancePagedSortedListResponse;
    }

    /// <summary>
    /// Gets a Call Pickup group.
    /// 
    /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
    /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
    /// It is possible to search by various criteria to restrict the number of rows returned.
    /// 
    /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
    /// Then the search criteria are logically ORed together.
    /// 
    /// If no sortOrder is included the response is sorted by User Id ascending by default.
    /// 
    /// The response is either GroupCallPickupGetInstancePagedSortedResponse or ErrorResponse.
    /// </summary>
    public static async Task<GroupCallPickupGetInstancePagedSortedResponse> GroupCallPickupGetInstancePagedSortedRequest(this OcipClient client, GroupCallPickupGetInstancePagedSortedRequest request) {
        return await client.Call(request) as GroupCallPickupGetInstancePagedSortedResponse;
    }

    /// <summary>
    /// Gets a Call Pickup group.
    /// The response is either GroupCallPickupGetInstanceResponse or ErrorResponse.
    /// </summary>
    public static async Task<GroupCallPickupGetInstanceResponse> GroupCallPickupGetInstanceRequest(this OcipClient client, GroupCallPickupGetInstanceRequest request) {
        return await client.Call(request) as GroupCallPickupGetInstanceResponse;
    }

    /// <summary>
    /// Modifies a Call Pickup group. Replaces the entire list of users in the group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupCallPickupModifyInstanceRequest(this OcipClient client, GroupCallPickupModifyInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Gets the details of the Call Pickup group that a user belongs to (if any).
    /// Any user can only belong to one Call Pickup group.
    /// The response is either UserCallPickupGetResponse or ErrorResponse.
    /// </summary>
    public static async Task<UserCallPickupGetResponse> UserCallPickupGetRequest(this OcipClient client, UserCallPickupGetRequest request) {
        return await client.Call(request) as UserCallPickupGetResponse;
    }


}
}
