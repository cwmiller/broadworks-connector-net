using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceCallCapacityManagementExtensions
{

    /// <summary>
    /// Adds a Call Capacity Management group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupCallCapacityManagementAddInstanceRequest(this OcipClient client, GroupCallCapacityManagementAddInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Adds one or more users to a Call Capacity Management group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupCallCapacityManagementAddUserListRequest(this OcipClient client, GroupCallCapacityManagementAddUserListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Deletes one or more Call Capacity Management groups.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupCallCapacityManagementDeleteInstanceListRequest(this OcipClient client, GroupCallCapacityManagementDeleteInstanceListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Deletes one or more users from a Call Capacity Management group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupCallCapacityManagementDeleteUserListRequest(this OcipClient client, GroupCallCapacityManagementDeleteUserListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get a list of users that can be assigned to a Call Capacity Management group.
    /// The available user list for a new Call Capacity Management group can be obtained
    /// by not setting the name.
    /// The response is either GroupCallCapacityManagementGetAvailableUserListResponse or ErrorResponse.
    /// </summary>
    public static async Task<GroupCallCapacityManagementGetAvailableUserListResponse> GroupCallCapacityManagementGetAvailableUserListRequest(this OcipClient client, GroupCallCapacityManagementGetAvailableUserListRequest request) {
        return await client.Call(request) as GroupCallCapacityManagementGetAvailableUserListResponse;
    }

    /// <summary>
    /// Request to get a list of Call Capacity Management instances within a group.
    /// The response is either GroupCallCapacityManagementGetInstanceListResponse or ErrorResponse.
    /// </summary>
    public static async Task<GroupCallCapacityManagementGetInstanceListResponse> GroupCallCapacityManagementGetInstanceListRequest(this OcipClient client, GroupCallCapacityManagementGetInstanceListRequest request) {
        return await client.Call(request) as GroupCallCapacityManagementGetInstanceListResponse;
    }

    /// <summary>
    /// Gets a Call Capacity Management group.
    /// The response is either GroupCallCapacityManagementGetInstanceResponse or ErrorResponse.
    /// </summary>
    public static async Task<GroupCallCapacityManagementGetInstanceResponse> GroupCallCapacityManagementGetInstanceRequest(this OcipClient client, GroupCallCapacityManagementGetInstanceRequest request) {
        return await client.Call(request) as GroupCallCapacityManagementGetInstanceResponse;
    }

    /// <summary>
    /// Modifies a Call Capacity Management group. Replaces the entire list of users in the group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupCallCapacityManagementModifyInstanceRequest(this OcipClient client, GroupCallCapacityManagementModifyInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
