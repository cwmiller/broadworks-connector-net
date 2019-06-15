using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceCollaborateExtensions
{

    /// <summary>
    /// Add a collaborate bridge to a group.
    /// The domain is required in the serviceUserId.
    /// The request fails when supportOutdial is enabled and the system-level collaborate supportOutdial setting is disabled.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupCollaborateBridgeAddInstanceRequest20sp1(this OcipClient client, GroupCollaborateBridgeAddInstanceRequest20sp1 request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Add a collaborate bridge to a group.
    /// The domain is required in the serviceUserId.
    /// The request fails when supportOutdial is enabled and the system-level collaborate supportOutdial setting is disabled.
    /// If the phoneNumber has not been assigned to the group and addPhoneNumberToGroup is set to true,
    /// it will be added to group if the command is executed by a service provider administrator or above
    /// and the number is already assigned to the service provider. The command will fail otherwise.
    /// 
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupCollaborateBridgeConsolidatedAddInstanceRequest(this OcipClient client, GroupCollaborateBridgeConsolidatedAddInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Delete a collaborate bridge from a group.
    /// The request fails when attempting to delete the default collaborate bridge.
    /// If UnassignPhoneNumbersLevel is set to 'Group', the user's primary phone number, fax number and any alternate numbers, will be un-assigned from the group if the command is executed by a service provider administrator or above.
    /// When set to 'Service Provider', they will be un-assigned from the group and service provider if the command is executed by a provisioning administrator or above.
    /// When omitted, the number(s) will be left assigned to the group.
    /// An ErrorResponse will be returned if any number cannot be unassigned because of insufficient privilege.
    /// 
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupCollaborateBridgeConsolidatedDeleteInstanceRequest(this OcipClient client, GroupCollaborateBridgeConsolidatedDeleteInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request to modify a Collaborate bridge.
    /// The request fails when the collaborateOwnerUserIdList is included in the request for the default collaborate bridge.
    /// The request fails when the supportOutdial is included in the request and the system-level collaborate supportOutdial setting is disabled.
    /// When phone numbers are un-assigned from the user, the unused numbers may be un-assigned from the group and service provider. If UnassignPhoneNumbersLevel is set to 'Group', the user's primary phone number, fax number and any alternate numbers, will be un-assigned from the group if the command is executed by a service provider administrator or above.
    /// When set to 'Service Provider', they will be un-assigned from the group and service provider if the command is executed by a provisioning administrator or above.
    /// When omitted, the number(s) will be left assigned to the group.
    /// An ErrorResponse will be returned if any number cannot be unassigned because of insufficient privilege.
    /// 
    /// If the phoneNumber has not been assigned to the group and addPhoneNumberToGroup is set to true, it will be added to group if needed if the command is executed by a service provider administrator and above. The command will fail otherwise.
    /// 
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupCollaborateBridgeConsolidatedModifyInstanceRequest(this OcipClient client, GroupCollaborateBridgeConsolidatedModifyInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Delete a collaborate bridge from a group.
    /// The request fails when attempting to delete the default collaborate bridge.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupCollaborateBridgeDeleteInstanceRequest(this OcipClient client, GroupCollaborateBridgeDeleteInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get a list of users with the Collaborate – Audio service assigned that can be assigned to a collaborate bridge.  For an Enterprise Group this will include all users in the group’s enterprise.
    /// The SearchCriteriaExactUserGroup parameter is only applicable for enterprise groups.
    /// The response is either GroupCollaborateBridgeGetAvailableUserListResponse or ErrorResponse.
    /// </summary>
    public static async Task<GroupCollaborateBridgeGetAvailableUserListResponse> GroupCollaborateBridgeGetAvailableUserListRequest(this OcipClient client, GroupCollaborateBridgeGetAvailableUserListRequest request) {
        return await client.Call(request) as GroupCollaborateBridgeGetAvailableUserListResponse;
    }

    /// <summary>
    /// Get a list of users with the Collaborate – Audio service assigned that can be assigned to a collaborate bridge.  For an Enterprise Group this will include all users in the group’s enterprise.
    /// The searchCriteriaGroupId parameter is only applicable for enterprise groups.
    /// If no sortOrder is included the response is sorted by Last Name ascending by default.
    /// 
    /// A limitation to the search by DN activation exists when the Number Activation mode is set to
    /// Off. In this case DNs not assigned to users are never returned by queries with the
    /// "dnActivationSearchCriteria" included.
    /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
    /// Then the search criteria are logically ORed together.
    /// 
    /// The response is either GroupCollaborateBridgeGetAvailableUserPagedSortedListResponse or ErrorResponse.
    /// </summary>
    public static async Task<GroupCollaborateBridgeGetAvailableUserPagedSortedListResponse> GroupCollaborateBridgeGetAvailableUserPagedSortedListRequest(this OcipClient client, GroupCollaborateBridgeGetAvailableUserPagedSortedListRequest request) {
        return await client.Call(request) as GroupCollaborateBridgeGetAvailableUserPagedSortedListResponse;
    }

    /// <summary>
    /// Get a list of collaborate bridges within a group.
    /// The response is either GroupCollaborateBridgeGetInstanceListResponse or ErrorResponse.
    /// It is possible to get the instances within a specified department.
    /// </summary>
    public static async Task<GroupCollaborateBridgeGetInstanceListResponse> GroupCollaborateBridgeGetInstanceListRequest(this OcipClient client, GroupCollaborateBridgeGetInstanceListRequest request) {
        return await client.Call(request) as GroupCollaborateBridgeGetInstanceListResponse;
    }

    /// <summary>
    /// Get a list of collaborate bridges within a group.
    /// The response is either GroupCollaborateBridgeGetInstancePagedSortedListResponse or ErrorResponse.
    /// 
    /// If the responsePagingControl element is not provided,
    /// the paging startIndex will be set to 1 by default,
    /// and the responsePageSize will be set to the maximum responsePageSize by
    /// default.
    /// 
    /// If no sortOrder is included the response is sorted by Name ascending by default. .
    /// 
    /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
    /// Then the search criteria are logically ORed together.
    /// </summary>
    public static async Task<GroupCollaborateBridgeGetInstancePagedSortedListResponse> GroupCollaborateBridgeGetInstancePagedSortedListRequest(this OcipClient client, GroupCollaborateBridgeGetInstancePagedSortedListRequest request) {
        return await client.Call(request) as GroupCollaborateBridgeGetInstancePagedSortedListResponse;
    }

    /// <summary>
    /// Request to get all the information of a collaborate bridge.
    /// The response is either GroupCollaborateBridgeGetInstanceResponse20sp1 or ErrorResponse.
    /// </summary>
    public static async Task<GroupCollaborateBridgeGetInstanceResponse20sp1> GroupCollaborateBridgeGetInstanceRequest20sp1(this OcipClient client, GroupCollaborateBridgeGetInstanceRequest20sp1 request) {
        return await client.Call(request) as GroupCollaborateBridgeGetInstanceResponse20sp1;
    }

    /// <summary>
    /// Request to modify a Collaborate bridge.
    /// The request fails when the collaborateOwnerUserIdList is included in the request for the default collaborate bridge.
    /// The request fails when the supportOutdial is included in the request and the system-level collaborate supportOutdial setting is disabled.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupCollaborateBridgeModifyInstanceRequest20sp1(this OcipClient client, GroupCollaborateBridgeModifyInstanceRequest20sp1 request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the reseller level data associated with Collaborate.
    /// The response is either a ResellerCollaborateGetResponse or an
    /// ErrorResponse.
    /// </summary>
    public static async Task<ResellerCollaborateGetResponse> ResellerCollaborateGetRequest(this OcipClient client, ResellerCollaborateGetRequest request) {
        return await client.Call(request) as ResellerCollaborateGetResponse;
    }

    /// <summary>
    /// Modify the reseller level data associated with Collaborate.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> ResellerCollaborateModifyRequest(this OcipClient client, ResellerCollaborateModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the system level data associated with collaborate services.
    /// The response is either a SystemCollaborateGetResponse20sp1V2 or an ErrorResponse.
    /// </summary>
    public static async Task<SystemCollaborateGetResponse20sp1V2> SystemCollaborateGetRequest20sp1V2(this OcipClient client, SystemCollaborateGetRequest20sp1V2 request) {
        return await client.Call(request) as SystemCollaborateGetResponse20sp1V2;
    }

    /// <summary>
    /// Modify the system level data associated with collaborate services.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> SystemCollaborateModifyRequest20sp1V2(this OcipClient client, SystemCollaborateModifyRequest20sp1V2 request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the collaborate bridged assigned to the user. The user can only be assigned to one collaborate bridge at any given time.
    /// The response is either UserCollaborateBridgeGetResponse20sp1 or
    /// ErrorResponse.
    /// </summary>
    public static async Task<UserCollaborateBridgeGetResponse20sp1> UserCollaborateBridgeGetRequest20sp1(this OcipClient client, UserCollaborateBridgeGetRequest20sp1 request) {
        return await client.Call(request) as UserCollaborateBridgeGetResponse20sp1;
    }

    /// <summary>
    /// Request to delete a collaborate room.  The request only applies to project rooms and instant rooms.
    /// The request fails when deleting a collaborate My Room.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCollaborateDeleteRoomRequest(this OcipClient client, UserCollaborateDeleteRoomRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request to add collaborate instant room.
    /// The response is either a UserCollaborateInstantRoomAddResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserCollaborateInstantRoomAddResponse> UserCollaborateInstantRoomAddRequest(this OcipClient client, UserCollaborateInstantRoomAddRequest request) {
        return await client.Call(request) as UserCollaborateInstantRoomAddResponse;
    }

    /// <summary>
    /// Request the collaborate room settings for an instant room.
    /// The request fails when requesting collaborate room settings for My Room or project rooms.
    /// The response is either UserCollaborateInstantRoomGetResponse or
    /// ErrorResponse.
    /// </summary>
    public static async Task<UserCollaborateInstantRoomGetResponse> UserCollaborateInstantRoomGetRequest(this OcipClient client, UserCollaborateInstantRoomGetRequest request) {
        return await client.Call(request) as UserCollaborateInstantRoomGetResponse;
    }

    /// <summary>
    /// Request collaborate instant room settings.
    /// The response is either UserCollaborateInstantRoomParametersGetResponse or
    /// ErrorResponse.
    /// </summary>
    public static async Task<UserCollaborateInstantRoomParametersGetResponse> UserCollaborateInstantRoomParametersGetRequest(this OcipClient client, UserCollaborateInstantRoomParametersGetRequest request) {
        return await client.Call(request) as UserCollaborateInstantRoomParametersGetResponse;
    }

    /// <summary>
    /// Request to modify collaborate instant room settings.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCollaborateInstantRoomParametersModifyRequest(this OcipClient client, UserCollaborateInstantRoomParametersModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request collaborate room settings for MyRoom.
    /// The response is either UserCollaborateMyRoomGetResponse or
    /// ErrorResponse.
    /// </summary>
    public static async Task<UserCollaborateMyRoomGetResponse> UserCollaborateMyRoomGetRequest(this OcipClient client, UserCollaborateMyRoomGetRequest request) {
        return await client.Call(request) as UserCollaborateMyRoomGetResponse;
    }

    /// <summary>
    /// Request to modify collaborate room settings for MyRoom.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCollaborateMyRoomModifyRequest(this OcipClient client, UserCollaborateMyRoomModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request to add collaborate project room.
    /// The response is either a UserCollaborateProjectRoomAddResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserCollaborateProjectRoomAddResponse> UserCollaborateProjectRoomAddRequest(this OcipClient client, UserCollaborateProjectRoomAddRequest request) {
        return await client.Call(request) as UserCollaborateProjectRoomAddResponse;
    }

    /// <summary>
    /// Request collaborate room settings for a project room.
    /// The request fails when requesting collaborate room settings for instant rooms or My Room.
    /// The response is either UserCollaborateProjectRoomGetResponse or
    /// ErrorResponse.
    /// </summary>
    public static async Task<UserCollaborateProjectRoomGetResponse> UserCollaborateProjectRoomGetRequest(this OcipClient client, UserCollaborateProjectRoomGetRequest request) {
        return await client.Call(request) as UserCollaborateProjectRoomGetResponse;
    }

    /// <summary>
    /// Request to modify collaborate room settings for a project room.
    /// The request fails when modifying collaborate room settings for instant rooms or My Room.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCollaborateProjectRoomModifyRequest(this OcipClient client, UserCollaborateProjectRoomModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request to get the settings for My Room, Instant Room or Project Room.
    /// The roomType and roomName parameters are returned for all rooms.
    /// For My room and Project Room, the following parameters are returned:
    /// attendeeNotification, endRoomSessionOnOwnerExit and ownerRequired.
    /// In addition, the roomSchedule is returned for Project Room and
    /// the roomStartTime and roomEndTime are returned for Instant Room.
    /// The response is either UserCollaborateRoomGetResponse or
    /// ErrorResponse.
    /// </summary>
    public static async Task<UserCollaborateRoomGetResponse> UserCollaborateRoomGetRequest(this OcipClient client, UserCollaborateRoomGetRequest request) {
        return await client.Call(request) as UserCollaborateRoomGetResponse;
    }

    /// <summary>
    /// Request to regenerate collaborate room id for MyRoom and project room.
    /// The request fails when requesting to regenerate room ID for an instant room.
    /// The response is either a UserCollaborateRoomIDRegenerateResponse or an
    /// ErrorResponse.
    /// </summary>
    public static async Task<UserCollaborateRoomIDRegenerateResponse> UserCollaborateRoomIDRegenerateRequest(this OcipClient client, UserCollaborateRoomIDRegenerateRequest request) {
        return await client.Call(request) as UserCollaborateRoomIDRegenerateResponse;
    }

    /// <summary>
    /// Request the list of collaborate room instances for this specific user.
    /// The response is either a UserCollaborateRoomListGetResponse or an
    /// ErrorResponse.
    /// </summary>
    public static async Task<UserCollaborateRoomListGetResponse> UserCollaborateRoomListGetRequest(this OcipClient client, UserCollaborateRoomListGetRequest request) {
        return await client.Call(request) as UserCollaborateRoomListGetResponse;
    }

    /// <summary>
    /// Request to modify room settings for a specific Project Room or My Room.
    /// Request to modify room settings for a specific Instant Room is responded
    /// with an ErrorResponse. The roomSchedule parameter is applicable for
    /// Project Room only. If the roomSchedule parameter is specified in the
    /// request to modify My Room, the request will be failed.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserCollaborateRoomModifyRequest(this OcipClient client, UserCollaborateRoomModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
