using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceMeetMeConferencingExtensions
    {

        /// <summary>
        /// Add a Meet-Me Conferencing bridge to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMeetMeConferencingAddInstanceRequest19Async instead.")]
        public static async Task<SuccessResponse> GroupMeetMeConferencingAddInstanceRequest19(this OcipClient client, GroupMeetMeConferencingAddInstanceRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Meet-Me Conferencing bridge to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupMeetMeConferencingAddInstanceRequest19Async(this OcipClient client, GroupMeetMeConferencingAddInstanceRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Meet-Me Conferencing bridge from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMeetMeConferencingDeleteInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupMeetMeConferencingDeleteInstanceRequest(this OcipClient client, GroupMeetMeConferencingDeleteInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Meet-Me Conferencing bridge from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupMeetMeConferencingDeleteInstanceRequestAsync(this OcipClient client, GroupMeetMeConferencingDeleteInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of users that can be assigned to a Meet-Me Conferencing bridge.
        /// Searching for users by group only makes sense when the Meet-Me Conferencing is part of an Enterprise.
        /// The response is either GroupMeetMeConferencingGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMeetMeConferencingGetAvailableUserListRequestAsync instead.")]
        public static async Task<GroupMeetMeConferencingGetAvailableUserListResponse> GroupMeetMeConferencingGetAvailableUserListRequest(this OcipClient client, GroupMeetMeConferencingGetAvailableUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupMeetMeConferencingGetAvailableUserListResponse;
        }

        /// <summary>
        /// Get a list of users that can be assigned to a Meet-Me Conferencing bridge.
        /// Searching for users by group only makes sense when the Meet-Me Conferencing is part of an Enterprise.
        /// The response is either GroupMeetMeConferencingGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupMeetMeConferencingGetAvailableUserListResponse> GroupMeetMeConferencingGetAvailableUserListRequestAsync(this OcipClient client, GroupMeetMeConferencingGetAvailableUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupMeetMeConferencingGetAvailableUserListResponse;
        }
        /// <summary>
        /// Get a list of Meet-Me Conferencing instances within a group.
        /// The response is either GroupMeetMeConferencingGetInstanceListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMeetMeConferencingGetInstanceListRequestAsync instead.")]
        public static async Task<GroupMeetMeConferencingGetInstanceListResponse> GroupMeetMeConferencingGetInstanceListRequest(this OcipClient client, GroupMeetMeConferencingGetInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupMeetMeConferencingGetInstanceListResponse;
        }

        /// <summary>
        /// Get a list of Meet-Me Conferencing instances within a group.
        /// The response is either GroupMeetMeConferencingGetInstanceListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        public static async Task<GroupMeetMeConferencingGetInstanceListResponse> GroupMeetMeConferencingGetInstanceListRequestAsync(this OcipClient client, GroupMeetMeConferencingGetInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupMeetMeConferencingGetInstanceListResponse;
        }
        /// <summary>
        /// Request to get all the information of a Meet-Me Conferencing bridge.
        /// The response is either GroupMeetMeConferencingGetInstanceResponse19sp1 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMeetMeConferencingGetInstanceRequest19sp1Async instead.")]
        public static async Task<GroupMeetMeConferencingGetInstanceResponse19sp1> GroupMeetMeConferencingGetInstanceRequest19sp1(this OcipClient client, GroupMeetMeConferencingGetInstanceRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupMeetMeConferencingGetInstanceResponse19sp1;
        }

        /// <summary>
        /// Request to get all the information of a Meet-Me Conferencing bridge.
        /// The response is either GroupMeetMeConferencingGetInstanceResponse19sp1 or ErrorResponse.
        /// </summary>
        public static async Task<GroupMeetMeConferencingGetInstanceResponse19sp1> GroupMeetMeConferencingGetInstanceRequest19sp1Async(this OcipClient client, GroupMeetMeConferencingGetInstanceRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupMeetMeConferencingGetInstanceResponse19sp1;
        }
        /// <summary>
        /// Request the group level data associated with Meet-Me Conferencing functions.
        /// The response is either a GroupMeetMeConferencingGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMeetMeConferencingGetRequestAsync instead.")]
        public static async Task<GroupMeetMeConferencingGetResponse> GroupMeetMeConferencingGetRequest(this OcipClient client, GroupMeetMeConferencingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupMeetMeConferencingGetResponse;
        }

        /// <summary>
        /// Request the group level data associated with Meet-Me Conferencing functions.
        /// The response is either a GroupMeetMeConferencingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupMeetMeConferencingGetResponse> GroupMeetMeConferencingGetRequestAsync(this OcipClient client, GroupMeetMeConferencingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupMeetMeConferencingGetResponse;
        }
        /// <summary>
        /// Request to set the active status of Meet-Me Conferencing instances.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMeetMeConferencingModifyActiveInstanceListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupMeetMeConferencingModifyActiveInstanceListRequest(this OcipClient client, GroupMeetMeConferencingModifyActiveInstanceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to set the active status of Meet-Me Conferencing instances.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupMeetMeConferencingModifyActiveInstanceListRequestAsync(this OcipClient client, GroupMeetMeConferencingModifyActiveInstanceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify a Meet-Me Conferencing bridge.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMeetMeConferencingModifyInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupMeetMeConferencingModifyInstanceRequest(this OcipClient client, GroupMeetMeConferencingModifyInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Meet-Me Conferencing bridge.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupMeetMeConferencingModifyInstanceRequestAsync(this OcipClient client, GroupMeetMeConferencingModifyInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the group level data associated with Meet-Me Conferencing functions.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMeetMeConferencingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupMeetMeConferencingModifyRequest(this OcipClient client, GroupMeetMeConferencingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group level data associated with Meet-Me Conferencing functions.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupMeetMeConferencingModifyRequestAsync(this OcipClient client, GroupMeetMeConferencingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the reseller level data associated with Meet-Me Conferencing functions.
        /// The response is either a ResellerMeetMeConferencingGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerMeetMeConferencingGetRequestAsync instead.")]
        public static async Task<ResellerMeetMeConferencingGetResponse> ResellerMeetMeConferencingGetRequest(this OcipClient client, ResellerMeetMeConferencingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerMeetMeConferencingGetResponse;
        }

        /// <summary>
        /// Request the reseller level data associated with Meet-Me Conferencing functions.
        /// The response is either a ResellerMeetMeConferencingGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<ResellerMeetMeConferencingGetResponse> ResellerMeetMeConferencingGetRequestAsync(this OcipClient client, ResellerMeetMeConferencingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerMeetMeConferencingGetResponse;
        }
        /// <summary>
        /// Modify the reseller level data associated with Meet-Me Conferencing functions.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerMeetMeConferencingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerMeetMeConferencingModifyRequest(this OcipClient client, ResellerMeetMeConferencingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the reseller level data associated with Meet-Me Conferencing functions.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerMeetMeConferencingModifyRequestAsync(this OcipClient client, ResellerMeetMeConferencingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the service provider/enterprise level data associated with Meet-Me Conferencing functions.
        /// The response is either a ServiceProviderMeetMeConferencingGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderMeetMeConferencingGetRequestAsync instead.")]
        public static async Task<ServiceProviderMeetMeConferencingGetResponse> ServiceProviderMeetMeConferencingGetRequest(this OcipClient client, ServiceProviderMeetMeConferencingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderMeetMeConferencingGetResponse;
        }

        /// <summary>
        /// Request the service provider/enterprise level data associated with Meet-Me Conferencing functions.
        /// The response is either a ServiceProviderMeetMeConferencingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderMeetMeConferencingGetResponse> ServiceProviderMeetMeConferencingGetRequestAsync(this OcipClient client, ServiceProviderMeetMeConferencingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderMeetMeConferencingGetResponse;
        }
        /// <summary>
        /// Modify the service provider/enterprise level data associated with Meet-Me Conferencing functions.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderMeetMeConferencingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderMeetMeConferencingModifyRequest(this OcipClient client, ServiceProviderMeetMeConferencingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the service provider/enterprise level data associated with Meet-Me Conferencing functions.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderMeetMeConferencingModifyRequestAsync(this OcipClient client, ServiceProviderMeetMeConferencingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with Meet-Me Conferencing functions.
        /// The response is either a SystemMeetMeConferencingGetResponse19 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMeetMeConferencingGetRequest19Async instead.")]
        public static async Task<SystemMeetMeConferencingGetResponse19> SystemMeetMeConferencingGetRequest19(this OcipClient client, SystemMeetMeConferencingGetRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMeetMeConferencingGetResponse19;
        }

        /// <summary>
        /// Request the system level data associated with Meet-Me Conferencing functions.
        /// The response is either a SystemMeetMeConferencingGetResponse19 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemMeetMeConferencingGetResponse19> SystemMeetMeConferencingGetRequest19Async(this OcipClient client, SystemMeetMeConferencingGetRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMeetMeConferencingGetResponse19;
        }
        /// <summary>
        /// Modify the system level data associated with Meet-Me Conferencing.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMeetMeConferencingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMeetMeConferencingModifyRequest(this OcipClient client, SystemMeetMeConferencingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Meet-Me Conferencing.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMeetMeConferencingModifyRequestAsync(this OcipClient client, SystemMeetMeConferencingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Meet-Me conference.
        /// The response is either UserMeetMeConferencingAddConferenceResponse19 or ErrorResponse.
        /// The startTime element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startTime.
        /// The startTime, endTime and recurrence information for a conferenceSchedule element will be adjusted to the user Host time zone.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMeetMeConferencingAddConferenceRequest19Async instead.")]
        public static async Task<UserMeetMeConferencingAddConferenceResponse19> UserMeetMeConferencingAddConferenceRequest19(this OcipClient client, UserMeetMeConferencingAddConferenceRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserMeetMeConferencingAddConferenceResponse19;
        }

        /// <summary>
        /// Add a Meet-Me conference.
        /// The response is either UserMeetMeConferencingAddConferenceResponse19 or ErrorResponse.
        /// The startTime element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startTime.
        /// The startTime, endTime and recurrence information for a conferenceSchedule element will be adjusted to the user Host time zone.
        /// </summary>
        public static async Task<UserMeetMeConferencingAddConferenceResponse19> UserMeetMeConferencingAddConferenceRequest19Async(this OcipClient client, UserMeetMeConferencingAddConferenceRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserMeetMeConferencingAddConferenceResponse19;
        }
        /// <summary>
        /// Add a Meet-Me conference.
        /// The response is either UserMeetMeConferencingAddConferenceResponse23 or ErrorResponse.
        /// The startTime element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startTime.
        /// The startTime, endTime and recurrence information for a conferenceSchedule element will be adjusted to the user Host time zone.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMeetMeConferencingAddConferenceRequest23Async instead.")]
        public static async Task<UserMeetMeConferencingAddConferenceResponse23> UserMeetMeConferencingAddConferenceRequest23(this OcipClient client, UserMeetMeConferencingAddConferenceRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserMeetMeConferencingAddConferenceResponse23;
        }

        /// <summary>
        /// Add a Meet-Me conference.
        /// The response is either UserMeetMeConferencingAddConferenceResponse23 or ErrorResponse.
        /// The startTime element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startTime.
        /// The startTime, endTime and recurrence information for a conferenceSchedule element will be adjusted to the user Host time zone.
        /// </summary>
        public static async Task<UserMeetMeConferencingAddConferenceResponse23> UserMeetMeConferencingAddConferenceRequest23Async(this OcipClient client, UserMeetMeConferencingAddConferenceRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserMeetMeConferencingAddConferenceResponse23;
        }
        /// <summary>
        /// Request to delete one or more conferences which are owned by the user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMeetMeConferencingDeleteConferenceListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserMeetMeConferencingDeleteConferenceListRequest(this OcipClient client, UserMeetMeConferencingDeleteConferenceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete one or more conferences which are owned by the user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserMeetMeConferencingDeleteConferenceListRequestAsync(this OcipClient client, UserMeetMeConferencingDeleteConferenceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete one or more conference recordings owned by the user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMeetMeConferencingDeleteConferenceRecordingListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserMeetMeConferencingDeleteConferenceRecordingListRequest(this OcipClient client, UserMeetMeConferencingDeleteConferenceRecordingListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete one or more conference recordings owned by the user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserMeetMeConferencingDeleteConferenceRecordingListRequestAsync(this OcipClient client, UserMeetMeConferencingDeleteConferenceRecordingListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of users that can be assigned as a delegate to a Meet-Me Conference.
        /// Searching for users, who are host on a Meet-Me Conferencing bridge.
        /// The response is either UserMeetMeConferencingGetAvailableDelegateListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMeetMeConferencingGetAvailableDelegateListRequestAsync instead.")]
        public static async Task<UserMeetMeConferencingGetAvailableDelegateListResponse> UserMeetMeConferencingGetAvailableDelegateListRequest(this OcipClient client, UserMeetMeConferencingGetAvailableDelegateListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserMeetMeConferencingGetAvailableDelegateListResponse;
        }

        /// <summary>
        /// Get a list of users that can be assigned as a delegate to a Meet-Me Conference.
        /// Searching for users, who are host on a Meet-Me Conferencing bridge.
        /// The response is either UserMeetMeConferencingGetAvailableDelegateListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserMeetMeConferencingGetAvailableDelegateListResponse> UserMeetMeConferencingGetAvailableDelegateListRequestAsync(this OcipClient client, UserMeetMeConferencingGetAvailableDelegateListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserMeetMeConferencingGetAvailableDelegateListResponse;
        }
        /// <summary>
        /// Get the list of Meet-Me Conferencing bridges for which the user is a host.
        /// The response is either UserMeetMeConferencingGetBridgeListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMeetMeConferencingGetBridgeListRequestAsync instead.")]
        public static async Task<UserMeetMeConferencingGetBridgeListResponse> UserMeetMeConferencingGetBridgeListRequest(this OcipClient client, UserMeetMeConferencingGetBridgeListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserMeetMeConferencingGetBridgeListResponse;
        }

        /// <summary>
        /// Get the list of Meet-Me Conferencing bridges for which the user is a host.
        /// The response is either UserMeetMeConferencingGetBridgeListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserMeetMeConferencingGetBridgeListResponse> UserMeetMeConferencingGetBridgeListRequestAsync(this OcipClient client, UserMeetMeConferencingGetBridgeListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserMeetMeConferencingGetBridgeListResponse;
        }
        /// <summary>
        /// Get the conference delegates for this conference.
        /// The response is either UserMeetMeConferencingGetConferenceDelegateListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMeetMeConferencingGetConferenceDelegateListRequestAsync instead.")]
        public static async Task<UserMeetMeConferencingGetConferenceDelegateListResponse> UserMeetMeConferencingGetConferenceDelegateListRequest(this OcipClient client, UserMeetMeConferencingGetConferenceDelegateListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserMeetMeConferencingGetConferenceDelegateListResponse;
        }

        /// <summary>
        /// Get the conference delegates for this conference.
        /// The response is either UserMeetMeConferencingGetConferenceDelegateListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserMeetMeConferencingGetConferenceDelegateListResponse> UserMeetMeConferencingGetConferenceDelegateListRequestAsync(this OcipClient client, UserMeetMeConferencingGetConferenceDelegateListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserMeetMeConferencingGetConferenceDelegateListResponse;
        }
        /// <summary>
        /// Get the information of a conference custom greeting.
        /// The response is either UserMeetMeConferencingGetConferenceGreetingResponse20 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMeetMeConferencingGetConferenceGreetingRequest20Async instead.")]
        public static async Task<UserMeetMeConferencingGetConferenceGreetingResponse20> UserMeetMeConferencingGetConferenceGreetingRequest20(this OcipClient client, UserMeetMeConferencingGetConferenceGreetingRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserMeetMeConferencingGetConferenceGreetingResponse20;
        }

        /// <summary>
        /// Get the information of a conference custom greeting.
        /// The response is either UserMeetMeConferencingGetConferenceGreetingResponse20 or ErrorResponse.
        /// </summary>
        public static async Task<UserMeetMeConferencingGetConferenceGreetingResponse20> UserMeetMeConferencingGetConferenceGreetingRequest20Async(this OcipClient client, UserMeetMeConferencingGetConferenceGreetingRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserMeetMeConferencingGetConferenceGreetingResponse20;
        }
        /// <summary>
        /// Get the list of all conferences for which user is a host or a delegate.
        /// The response is either UserMeetMeConferencingGetConferenceListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMeetMeConferencingGetConferenceListRequestAsync instead.")]
        public static async Task<UserMeetMeConferencingGetConferenceListResponse> UserMeetMeConferencingGetConferenceListRequest(this OcipClient client, UserMeetMeConferencingGetConferenceListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserMeetMeConferencingGetConferenceListResponse;
        }

        /// <summary>
        /// Get the list of all conferences for which user is a host or a delegate.
        /// The response is either UserMeetMeConferencingGetConferenceListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserMeetMeConferencingGetConferenceListResponse> UserMeetMeConferencingGetConferenceListRequestAsync(this OcipClient client, UserMeetMeConferencingGetConferenceListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserMeetMeConferencingGetConferenceListResponse;
        }
        /// <summary>
        /// Get the list of recordings of the conferences owned by the host.
        /// The response is either UserMeetMeConferencingGetConferenceRecordingListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMeetMeConferencingGetConferenceRecordingListRequestAsync instead.")]
        public static async Task<UserMeetMeConferencingGetConferenceRecordingListResponse> UserMeetMeConferencingGetConferenceRecordingListRequest(this OcipClient client, UserMeetMeConferencingGetConferenceRecordingListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserMeetMeConferencingGetConferenceRecordingListResponse;
        }

        /// <summary>
        /// Get the list of recordings of the conferences owned by the host.
        /// The response is either UserMeetMeConferencingGetConferenceRecordingListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserMeetMeConferencingGetConferenceRecordingListResponse> UserMeetMeConferencingGetConferenceRecordingListRequestAsync(this OcipClient client, UserMeetMeConferencingGetConferenceRecordingListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserMeetMeConferencingGetConferenceRecordingListResponse;
        }
        /// <summary>
        /// Get the information of a conference owned by the user.
        /// The response is either UserMeetMeConferencingGetConferenceResponse20 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMeetMeConferencingGetConferenceRequest20Async instead.")]
        public static async Task<UserMeetMeConferencingGetConferenceResponse20> UserMeetMeConferencingGetConferenceRequest20(this OcipClient client, UserMeetMeConferencingGetConferenceRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserMeetMeConferencingGetConferenceResponse20;
        }

        /// <summary>
        /// Get the information of a conference owned by the user.
        /// The response is either UserMeetMeConferencingGetConferenceResponse20 or ErrorResponse.
        /// </summary>
        public static async Task<UserMeetMeConferencingGetConferenceResponse20> UserMeetMeConferencingGetConferenceRequest20Async(this OcipClient client, UserMeetMeConferencingGetConferenceRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserMeetMeConferencingGetConferenceResponse20;
        }
        /// <summary>
        /// Get the information of a conference owned by the user.
        /// The response is either UserMeetMeConferencingGetConferenceResponse23 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMeetMeConferencingGetConferenceRequest23Async instead.")]
        public static async Task<UserMeetMeConferencingGetConferenceResponse23> UserMeetMeConferencingGetConferenceRequest23(this OcipClient client, UserMeetMeConferencingGetConferenceRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserMeetMeConferencingGetConferenceResponse23;
        }

        /// <summary>
        /// Get the information of a conference owned by the user.
        /// The response is either UserMeetMeConferencingGetConferenceResponse23 or ErrorResponse.
        /// </summary>
        public static async Task<UserMeetMeConferencingGetConferenceResponse23> UserMeetMeConferencingGetConferenceRequest23Async(this OcipClient client, UserMeetMeConferencingGetConferenceRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserMeetMeConferencingGetConferenceResponse23;
        }
        /// <summary>
        /// Modify the existing conference delegates list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMeetMeConferencingModifyConferenceDelegateListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserMeetMeConferencingModifyConferenceDelegateListRequest(this OcipClient client, UserMeetMeConferencingModifyConferenceDelegateListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the existing conference delegates list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserMeetMeConferencingModifyConferenceDelegateListRequestAsync(this OcipClient client, UserMeetMeConferencingModifyConferenceDelegateListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify an existing custom greeting audio file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMeetMeConferencingModifyConferenceGreetingRequest20Async instead.")]
        public static async Task<SuccessResponse> UserMeetMeConferencingModifyConferenceGreetingRequest20(this OcipClient client, UserMeetMeConferencingModifyConferenceGreetingRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing custom greeting audio file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserMeetMeConferencingModifyConferenceGreetingRequest20Async(this OcipClient client, UserMeetMeConferencingModifyConferenceGreetingRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify an existing conference.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The startTime element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startTime.
        /// The startTime, endTime and recurrence information for a conferenceSchedule element will be adjusted to the user Host time zone.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMeetMeConferencingModifyConferenceRequestAsync instead.")]
        public static async Task<SuccessResponse> UserMeetMeConferencingModifyConferenceRequest(this OcipClient client, UserMeetMeConferencingModifyConferenceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing conference.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The startTime element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startTime.
        /// The startTime, endTime and recurrence information for a conferenceSchedule element will be adjusted to the user Host time zone.
        /// </summary>
        public static async Task<SuccessResponse> UserMeetMeConferencingModifyConferenceRequestAsync(this OcipClient client, UserMeetMeConferencingModifyConferenceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
