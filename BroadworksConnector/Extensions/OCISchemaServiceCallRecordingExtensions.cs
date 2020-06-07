using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallRecordingExtensions
    {

        /// <summary>
        /// Get the Call Recording platform for a group.
        /// The response is either a GroupCallRecordingGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallRecordingGetRequestAsync instead.")]
        public static async Task<GroupCallRecordingGetResponse> GroupCallRecordingGetRequest(this OcipClient client, GroupCallRecordingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallRecordingGetResponse;
        }

        /// <summary>
        /// Get the Call Recording platform for a group.
        /// The response is either a GroupCallRecordingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallRecordingGetResponse> GroupCallRecordingGetRequestAsync(this OcipClient client, GroupCallRecordingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallRecordingGetResponse;
        }
        /// <summary>
        /// Modify the Call Recording platform assignment for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallRecordingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallRecordingModifyRequest(this OcipClient client, GroupCallRecordingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Call Recording platform assignment for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallRecordingModifyRequestAsync(this OcipClient client, GroupCallRecordingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Call Recording platform.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallRecordingAddPlatformRequest20Async instead.")]
        public static async Task<SuccessResponse> SystemCallRecordingAddPlatformRequest20(this OcipClient client, SystemCallRecordingAddPlatformRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Recording platform.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallRecordingAddPlatformRequest20Async(this OcipClient client, SystemCallRecordingAddPlatformRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Call Recording platform.
        /// The first system level call recording platform added is made the system default
        /// call recording platform.  The first reseller level call recording platform added
        /// for a reseller is made the reseller default call recording platform.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallRecordingAddPlatformRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemCallRecordingAddPlatformRequest22(this OcipClient client, SystemCallRecordingAddPlatformRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Recording platform.
        /// The first system level call recording platform added is made the system default
        /// call recording platform.  The first reseller level call recording platform added
        /// for a reseller is made the reseller default call recording platform.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallRecordingAddPlatformRequest22Async(this OcipClient client, SystemCallRecordingAddPlatformRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Call Recording platform.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallRecordingDeletePlatformRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallRecordingDeletePlatformRequest(this OcipClient client, SystemCallRecordingDeletePlatformRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Call Recording platform.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallRecordingDeletePlatformRequestAsync(this OcipClient client, SystemCallRecordingDeletePlatformRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the list of all system-level call recording platforms and all reseller level call recording platforms.
        /// If an excludeReseller is specified, returns all the system-level call recording platforms only.
        /// If a resellerId is specified, returns all the system-level call recording platforms and the given reseller's call recording platforms.
        /// If a reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// The response is either SystemCallRecordingGetPlatformListResponse22V2 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallRecordingGetPlatformListRequest22V2Async instead.")]
        public static async Task<SystemCallRecordingGetPlatformListResponse22V2> SystemCallRecordingGetPlatformListRequest22V2(this OcipClient client, SystemCallRecordingGetPlatformListRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallRecordingGetPlatformListResponse22V2;
        }

        /// <summary>
        /// Requests the list of all system-level call recording platforms and all reseller level call recording platforms.
        /// If an excludeReseller is specified, returns all the system-level call recording platforms only.
        /// If a resellerId is specified, returns all the system-level call recording platforms and the given reseller's call recording platforms.
        /// If a reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// The response is either SystemCallRecordingGetPlatformListResponse22V2 or ErrorResponse.
        /// </summary>
        public static async Task<SystemCallRecordingGetPlatformListResponse22V2> SystemCallRecordingGetPlatformListRequest22V2Async(this OcipClient client, SystemCallRecordingGetPlatformListRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallRecordingGetPlatformListResponse22V2;
        }
        /// <summary>
        /// Get the list of groups currently associated to the specified Call Recording platform.
        /// The response is either SystemCallRecordingGetPlatformUsageResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallRecordingGetPlatformUsageRequest22Async instead.")]
        public static async Task<SystemCallRecordingGetPlatformUsageResponse22> SystemCallRecordingGetPlatformUsageRequest22(this OcipClient client, SystemCallRecordingGetPlatformUsageRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallRecordingGetPlatformUsageResponse22;
        }

        /// <summary>
        /// Get the list of groups currently associated to the specified Call Recording platform.
        /// The response is either SystemCallRecordingGetPlatformUsageResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemCallRecordingGetPlatformUsageResponse22> SystemCallRecordingGetPlatformUsageRequest22Async(this OcipClient client, SystemCallRecordingGetPlatformUsageRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallRecordingGetPlatformUsageResponse22;
        }
        /// <summary>
        /// Request the system level data associated with Call Recording.
        /// The response is either a SystemCallRecordingGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallRecordingGetRequest22Async instead.")]
        public static async Task<SystemCallRecordingGetResponse22> SystemCallRecordingGetRequest22(this OcipClient client, SystemCallRecordingGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallRecordingGetResponse22;
        }

        /// <summary>
        /// Request the system level data associated with Call Recording.
        /// The response is either a SystemCallRecordingGetResponse22 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallRecordingGetResponse22> SystemCallRecordingGetRequest22Async(this OcipClient client, SystemCallRecordingGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallRecordingGetResponse22;
        }
        /// <summary>
        /// Request the system level data associated with Call Recording.
        /// The response is either a SystemCallRecordingGetResponse23 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallRecordingGetRequest23Async instead.")]
        public static async Task<SystemCallRecordingGetResponse23> SystemCallRecordingGetRequest23(this OcipClient client, SystemCallRecordingGetRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallRecordingGetResponse23;
        }

        /// <summary>
        /// Request the system level data associated with Call Recording.
        /// The response is either a SystemCallRecordingGetResponse23 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallRecordingGetResponse23> SystemCallRecordingGetRequest23Async(this OcipClient client, SystemCallRecordingGetRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallRecordingGetResponse23;
        }
        /// <summary>
        /// Modify the specified Call Recording platform.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallRecordingModifyPlatformRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallRecordingModifyPlatformRequest(this OcipClient client, SystemCallRecordingModifyPlatformRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the specified Call Recording platform.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallRecordingModifyPlatformRequestAsync(this OcipClient client, SystemCallRecordingModifyPlatformRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the specified Call Recording platform.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallRecordingModifyPlatformRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemCallRecordingModifyPlatformRequest22(this OcipClient client, SystemCallRecordingModifyPlatformRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the specified Call Recording platform.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallRecordingModifyPlatformRequest22Async(this OcipClient client, SystemCallRecordingModifyPlatformRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Call Recording.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallRecordingModifyRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemCallRecordingModifyRequest22(this OcipClient client, SystemCallRecordingModifyRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Call Recording.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallRecordingModifyRequest22Async(this OcipClient client, SystemCallRecordingModifyRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the Call Recording attributes for a user.
        /// The response is either a UserCallRecordingGetResponse20 or an ErrorResponse.
        /// 
        /// The following parameters are not returned for service instance:
        /// - pauseResumeNotification
        /// - enableCallRecordingAnnouncement
        /// - enableRecordCallRepeatWarningTone
        /// - recordCallRepeatWarningToneTimerSeconds
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallRecordingGetRequest20Async instead.")]
        public static async Task<UserCallRecordingGetResponse20> UserCallRecordingGetRequest20(this OcipClient client, UserCallRecordingGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallRecordingGetResponse20;
        }

        /// <summary>
        /// Get the Call Recording attributes for a user.
        /// The response is either a UserCallRecordingGetResponse20 or an ErrorResponse.
        /// 
        /// The following parameters are not returned for service instance:
        /// - pauseResumeNotification
        /// - enableCallRecordingAnnouncement
        /// - enableRecordCallRepeatWarningTone
        /// - recordCallRepeatWarningToneTimerSeconds
        /// </summary>
        public static async Task<UserCallRecordingGetResponse20> UserCallRecordingGetRequest20Async(this OcipClient client, UserCallRecordingGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallRecordingGetResponse20;
        }
        /// <summary>
        /// Modify the Call Recording attributes for a user. The recording options
        /// "Always with Pause/Resume", "On Demand", and "On Demand with User
        /// Initiated Start" are not accepted for service instances.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following parameters are not accepted for service
        /// instance:
        /// - pauseResumeNotification
        /// - enableCallRecordingAnnouncement
        /// - enableRecordCallRepeatWarningTone
        /// - recordCallRepeatWarningToneTimerSeconds
        /// 
        /// The enableVoiceMailRecording parameter is only applicable
        /// if the Voice Messaging User service is assigned to the user.
        /// This applies to both users and service instances.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallRecordingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallRecordingModifyRequest(this OcipClient client, UserCallRecordingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Call Recording attributes for a user. The recording options
        /// "Always with Pause/Resume", "On Demand", and "On Demand with User
        /// Initiated Start" are not accepted for service instances.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following parameters are not accepted for service
        /// instance:
        /// - pauseResumeNotification
        /// - enableCallRecordingAnnouncement
        /// - enableRecordCallRepeatWarningTone
        /// - recordCallRepeatWarningToneTimerSeconds
        /// 
        /// The enableVoiceMailRecording parameter is only applicable
        /// if the Voice Messaging User service is assigned to the user.
        /// This applies to both users and service instances.
        /// </summary>
        public static async Task<SuccessResponse> UserCallRecordingModifyRequestAsync(this OcipClient client, UserCallRecordingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
