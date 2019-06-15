using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceMeetMeConferencingExtensions
{

    /// <summary>
    /// Add a Meet-Me Conferencing bridge to a group.
    /// The domain is required in the serviceUserId.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupMeetMeConferencingAddInstanceRequest19(this OcipClient client, GroupMeetMeConferencingAddInstanceRequest19 request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Delete a Meet-Me Conferencing bridge from a group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupMeetMeConferencingDeleteInstanceRequest(this OcipClient client, GroupMeetMeConferencingDeleteInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get a list of users that can be assigned to a Meet-Me Conferencing bridge.
    /// Searching for users by group only makes sense when the Meet-Me Conferencing is part of an Enterprise.
    /// The response is either GroupMeetMeConferencingGetAvailableUserListResponse or ErrorResponse.
    /// </summary>
    public static async Task<GroupMeetMeConferencingGetAvailableUserListResponse> GroupMeetMeConferencingGetAvailableUserListRequest(this OcipClient client, GroupMeetMeConferencingGetAvailableUserListRequest request) {
        return await client.Call(request) as GroupMeetMeConferencingGetAvailableUserListResponse;
    }

    /// <summary>
    /// Get a list of Meet-Me Conferencing instances within a group.
    /// The response is either GroupMeetMeConferencingGetInstanceListResponse or ErrorResponse.
    /// It is possible to get the instances within a specified department.
    /// </summary>
    public static async Task<GroupMeetMeConferencingGetInstanceListResponse> GroupMeetMeConferencingGetInstanceListRequest(this OcipClient client, GroupMeetMeConferencingGetInstanceListRequest request) {
        return await client.Call(request) as GroupMeetMeConferencingGetInstanceListResponse;
    }

    /// <summary>
    /// Request to get all the information of a Meet-Me Conferencing bridge.
    /// The response is either GroupMeetMeConferencingGetInstanceResponse19sp1 or ErrorResponse.
    /// </summary>
    public static async Task<GroupMeetMeConferencingGetInstanceResponse19sp1> GroupMeetMeConferencingGetInstanceRequest19sp1(this OcipClient client, GroupMeetMeConferencingGetInstanceRequest19sp1 request) {
        return await client.Call(request) as GroupMeetMeConferencingGetInstanceResponse19sp1;
    }

    /// <summary>
    /// Request the group level data associated with Meet-Me Conferencing functions.
    /// The response is either a GroupMeetMeConferencingGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<GroupMeetMeConferencingGetResponse> GroupMeetMeConferencingGetRequest(this OcipClient client, GroupMeetMeConferencingGetRequest request) {
        return await client.Call(request) as GroupMeetMeConferencingGetResponse;
    }

    /// <summary>
    /// Request to set the active status of Meet-Me Conferencing instances.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupMeetMeConferencingModifyActiveInstanceListRequest(this OcipClient client, GroupMeetMeConferencingModifyActiveInstanceListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request to modify a Meet-Me Conferencing bridge.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupMeetMeConferencingModifyInstanceRequest(this OcipClient client, GroupMeetMeConferencingModifyInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Modify the group level data associated with Meet-Me Conferencing functions.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupMeetMeConferencingModifyRequest(this OcipClient client, GroupMeetMeConferencingModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the reseller level data associated with Meet-Me Conferencing functions.
    /// The response is either a ResellerMeetMeConferencingGetResponse or an
    /// ErrorResponse.
    /// </summary>
    public static async Task<ResellerMeetMeConferencingGetResponse> ResellerMeetMeConferencingGetRequest(this OcipClient client, ResellerMeetMeConferencingGetRequest request) {
        return await client.Call(request) as ResellerMeetMeConferencingGetResponse;
    }

    /// <summary>
    /// Modify the reseller level data associated with Meet-Me Conferencing functions.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> ResellerMeetMeConferencingModifyRequest(this OcipClient client, ResellerMeetMeConferencingModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the service provider/enterprise level data associated with Meet-Me Conferencing functions.
    /// The response is either a ServiceProviderMeetMeConferencingGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<ServiceProviderMeetMeConferencingGetResponse> ServiceProviderMeetMeConferencingGetRequest(this OcipClient client, ServiceProviderMeetMeConferencingGetRequest request) {
        return await client.Call(request) as ServiceProviderMeetMeConferencingGetResponse;
    }

    /// <summary>
    /// Modify the service provider/enterprise level data associated with Meet-Me Conferencing functions.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> ServiceProviderMeetMeConferencingModifyRequest(this OcipClient client, ServiceProviderMeetMeConferencingModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the system level data associated with Meet-Me Conferencing functions.
    /// The response is either a SystemMeetMeConferencingGetResponse19 or an ErrorResponse.
    /// </summary>
    public static async Task<SystemMeetMeConferencingGetResponse19> SystemMeetMeConferencingGetRequest19(this OcipClient client, SystemMeetMeConferencingGetRequest19 request) {
        return await client.Call(request) as SystemMeetMeConferencingGetResponse19;
    }

    /// <summary>
    /// Modify the system level data associated with Meet-Me Conferencing.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> SystemMeetMeConferencingModifyRequest(this OcipClient client, SystemMeetMeConferencingModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Add a Meet-Me conference.
    /// The response is either UserMeetMeConferencingAddConferenceResponse19 or ErrorResponse.
    /// The startTime element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startTime.
    /// The startTime, endTime and recurrence information for a conferenceSchedule element will be adjusted to the user Host time zone.
    /// </summary>
    public static async Task<UserMeetMeConferencingAddConferenceResponse19> UserMeetMeConferencingAddConferenceRequest19(this OcipClient client, UserMeetMeConferencingAddConferenceRequest19 request) {
        return await client.Call(request) as UserMeetMeConferencingAddConferenceResponse19;
    }

    /// <summary>
    /// Add a Meet-Me conference.
    /// The response is either UserMeetMeConferencingAddConferenceResponse23 or ErrorResponse.
    /// The startTime element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startTime.
    /// The startTime, endTime and recurrence information for a conferenceSchedule element will be adjusted to the user Host time zone.
    /// </summary>
    public static async Task<UserMeetMeConferencingAddConferenceResponse23> UserMeetMeConferencingAddConferenceRequest23(this OcipClient client, UserMeetMeConferencingAddConferenceRequest23 request) {
        return await client.Call(request) as UserMeetMeConferencingAddConferenceResponse23;
    }

    /// <summary>
    /// Request to delete one or more conferences which are owned by the user.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserMeetMeConferencingDeleteConferenceListRequest(this OcipClient client, UserMeetMeConferencingDeleteConferenceListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request to delete one or more conference recordings owned by the user.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserMeetMeConferencingDeleteConferenceRecordingListRequest(this OcipClient client, UserMeetMeConferencingDeleteConferenceRecordingListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get a list of users that can be assigned as a delegate to a Meet-Me Conference.
    /// Searching for users, who are host on a Meet-Me Conferencing bridge.
    /// The response is either UserMeetMeConferencingGetAvailableDelegateListResponse or ErrorResponse.
    /// </summary>
    public static async Task<UserMeetMeConferencingGetAvailableDelegateListResponse> UserMeetMeConferencingGetAvailableDelegateListRequest(this OcipClient client, UserMeetMeConferencingGetAvailableDelegateListRequest request) {
        return await client.Call(request) as UserMeetMeConferencingGetAvailableDelegateListResponse;
    }

    /// <summary>
    /// Get the list of Meet-Me Conferencing bridges for which the user is a host.
    /// The response is either UserMeetMeConferencingGetBridgeListResponse or ErrorResponse.
    /// </summary>
    public static async Task<UserMeetMeConferencingGetBridgeListResponse> UserMeetMeConferencingGetBridgeListRequest(this OcipClient client, UserMeetMeConferencingGetBridgeListRequest request) {
        return await client.Call(request) as UserMeetMeConferencingGetBridgeListResponse;
    }

    /// <summary>
    /// Get the conference delegates for this conference.
    /// The response is either UserMeetMeConferencingGetConferenceDelegateListResponse or ErrorResponse.
    /// </summary>
    public static async Task<UserMeetMeConferencingGetConferenceDelegateListResponse> UserMeetMeConferencingGetConferenceDelegateListRequest(this OcipClient client, UserMeetMeConferencingGetConferenceDelegateListRequest request) {
        return await client.Call(request) as UserMeetMeConferencingGetConferenceDelegateListResponse;
    }

    /// <summary>
    /// Get the information of a conference custom greeting.
    /// The response is either UserMeetMeConferencingGetConferenceGreetingResponse20 or ErrorResponse.
    /// </summary>
    public static async Task<UserMeetMeConferencingGetConferenceGreetingResponse20> UserMeetMeConferencingGetConferenceGreetingRequest20(this OcipClient client, UserMeetMeConferencingGetConferenceGreetingRequest20 request) {
        return await client.Call(request) as UserMeetMeConferencingGetConferenceGreetingResponse20;
    }

    /// <summary>
    /// Get the list of all conferences for which user is a host or a delegate.
    /// The response is either UserMeetMeConferencingGetConferenceListResponse or ErrorResponse.
    /// </summary>
    public static async Task<UserMeetMeConferencingGetConferenceListResponse> UserMeetMeConferencingGetConferenceListRequest(this OcipClient client, UserMeetMeConferencingGetConferenceListRequest request) {
        return await client.Call(request) as UserMeetMeConferencingGetConferenceListResponse;
    }

    /// <summary>
    /// Get the list of recordings of the conferences owned by the host.
    /// The response is either UserMeetMeConferencingGetConferenceRecordingListResponse or ErrorResponse.
    /// </summary>
    public static async Task<UserMeetMeConferencingGetConferenceRecordingListResponse> UserMeetMeConferencingGetConferenceRecordingListRequest(this OcipClient client, UserMeetMeConferencingGetConferenceRecordingListRequest request) {
        return await client.Call(request) as UserMeetMeConferencingGetConferenceRecordingListResponse;
    }

    /// <summary>
    /// Get the information of a conference owned by the user.
    /// The response is either UserMeetMeConferencingGetConferenceResponse20 or ErrorResponse.
    /// </summary>
    public static async Task<UserMeetMeConferencingGetConferenceResponse20> UserMeetMeConferencingGetConferenceRequest20(this OcipClient client, UserMeetMeConferencingGetConferenceRequest20 request) {
        return await client.Call(request) as UserMeetMeConferencingGetConferenceResponse20;
    }

    /// <summary>
    /// Get the information of a conference owned by the user.
    /// The response is either UserMeetMeConferencingGetConferenceResponse23 or ErrorResponse.
    /// </summary>
    public static async Task<UserMeetMeConferencingGetConferenceResponse23> UserMeetMeConferencingGetConferenceRequest23(this OcipClient client, UserMeetMeConferencingGetConferenceRequest23 request) {
        return await client.Call(request) as UserMeetMeConferencingGetConferenceResponse23;
    }

    /// <summary>
    /// Modify the existing conference delegates list.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserMeetMeConferencingModifyConferenceDelegateListRequest(this OcipClient client, UserMeetMeConferencingModifyConferenceDelegateListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Modify an existing custom greeting audio file.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserMeetMeConferencingModifyConferenceGreetingRequest20(this OcipClient client, UserMeetMeConferencingModifyConferenceGreetingRequest20 request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Modify an existing conference.
    /// The response is either SuccessResponse or ErrorResponse.
    /// The startTime element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startTime.
    /// The startTime, endTime and recurrence information for a conferenceSchedule element will be adjusted to the user Host time zone.
    /// </summary>
    public static async Task<SuccessResponse> UserMeetMeConferencingModifyConferenceRequest(this OcipClient client, UserMeetMeConferencingModifyConferenceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
