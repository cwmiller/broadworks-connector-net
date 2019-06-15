using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceCallParkExtensions
{

    /// <summary>
    /// Adds a Call Park group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupCallParkAddInstanceRequest16sp2(this OcipClient client, GroupCallParkAddInstanceRequest16sp2 request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Deletes a Call Park group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupCallParkDeleteInstanceRequest(this OcipClient client, GroupCallParkDeleteInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get a list of hunt groups that are available to select as an alternate recall user.
    /// The response is either GroupCallParkGetAvailableAlternateRecallUserListResponse or ErrorResponse.
    /// </summary>
    public static async Task<GroupCallParkGetAvailableAlternateRecallUserListResponse> GroupCallParkGetAvailableAlternateRecallUserListRequest(this OcipClient client, GroupCallParkGetAvailableAlternateRecallUserListRequest request) {
        return await client.Call(request) as GroupCallParkGetAvailableAlternateRecallUserListResponse;
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
    public static async Task<GroupCallParkGetAvailableAlternateRecallUserPagedSortedListResponse> GroupCallParkGetAvailableAlternateRecallUserPagedSortedListRequest(this OcipClient client, GroupCallParkGetAvailableAlternateRecallUserPagedSortedListRequest request) {
        return await client.Call(request) as GroupCallParkGetAvailableAlternateRecallUserPagedSortedListResponse;
    }

    /// <summary>
    /// Get a list of users that can be assigned to a Call Park group.
    /// The available user list for a new Call Park group can be obtained
    /// by not setting the name.
    /// The response is either GroupCallParkGetAvailableUserListResponse or ErrorResponse.
    /// </summary>
    public static async Task<GroupCallParkGetAvailableUserListResponse> GroupCallParkGetAvailableUserListRequest(this OcipClient client, GroupCallParkGetAvailableUserListRequest request) {
        return await client.Call(request) as GroupCallParkGetAvailableUserListResponse;
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
    public static async Task<GroupCallParkGetAvailableUserPagedSortedListResponse> GroupCallParkGetAvailableUserPagedSortedListRequest(this OcipClient client, GroupCallParkGetAvailableUserPagedSortedListRequest request) {
        return await client.Call(request) as GroupCallParkGetAvailableUserPagedSortedListResponse;
    }

    /// <summary>
    /// Request to get a list of Call Park group instances within a group.
    /// The response is either GroupCallParkGetInstanceListResponse or ErrorResponse.
    /// </summary>
    public static async Task<GroupCallParkGetInstanceListResponse> GroupCallParkGetInstanceListRequest(this OcipClient client, GroupCallParkGetInstanceListRequest request) {
        return await client.Call(request) as GroupCallParkGetInstanceListResponse;
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
    public static async Task<GroupCallParkGetInstancePagedSortedListResponse> GroupCallParkGetInstancePagedSortedListRequest(this OcipClient client, GroupCallParkGetInstancePagedSortedListRequest request) {
        return await client.Call(request) as GroupCallParkGetInstancePagedSortedListResponse;
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
    public static async Task<GroupCallParkGetInstancePagedSortedResponse> GroupCallParkGetInstancePagedSortedRequest(this OcipClient client, GroupCallParkGetInstancePagedSortedRequest request) {
        return await client.Call(request) as GroupCallParkGetInstancePagedSortedResponse;
    }

    /// <summary>
    /// Gets a Call Park group.
    /// The response is either GroupCallParkGetInstanceResponse16sp2 or ErrorResponse.
    /// </summary>
    public static async Task<GroupCallParkGetInstanceResponse16sp2> GroupCallParkGetInstanceRequest16sp2(this OcipClient client, GroupCallParkGetInstanceRequest16sp2 request) {
        return await client.Call(request) as GroupCallParkGetInstanceResponse16sp2;
    }

    /// <summary>
    /// Gets the Call Park Group settings.
    /// The response is either GroupCallParkGetResponse16sp2 or ErrorResponse.
    /// </summary>
    public static async Task<GroupCallParkGetResponse16sp2> GroupCallParkGetRequest16sp2(this OcipClient client, GroupCallParkGetRequest16sp2 request) {
        return await client.Call(request) as GroupCallParkGetResponse16sp2;
    }

    /// <summary>
    /// Modifies a Call Park group. Replaces the entire list of users in the group.
    /// The users are in the list are in the order they will try to be parked on.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupCallParkModifyInstanceRequest(this OcipClient client, GroupCallParkModifyInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Modifies the Group's Call Park settings.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupCallParkModifyRequest(this OcipClient client, GroupCallParkModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Identifies which Call Park group the user belongs to if any and the list of users in the group.
    /// The response is either UserCallParkGetResponse or ErrorResponse.
    /// </summary>
    public static async Task<UserCallParkGetResponse> UserCallParkGetRequest(this OcipClient client, UserCallParkGetRequest request) {
        return await client.Call(request) as UserCallParkGetResponse;
    }


}
}
