using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceBusyLampFieldExtensions
    {

        /// <summary>
        /// Request the system level data associated with the Busy Lamp
        /// Field service. The response is either a SystemBusyLampFieldGetResponse23V2 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBusyLampFieldGetRequest23V2Async instead.")]
        public static async Task<SystemBusyLampFieldGetResponse23V2> SystemBusyLampFieldGetRequest23V2(this OcipClient client, SystemBusyLampFieldGetRequest23V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemBusyLampFieldGetResponse23V2;
        }

        /// <summary>
        /// Request the system level data associated with the Busy Lamp
        /// Field service. The response is either a SystemBusyLampFieldGetResponse23V2 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemBusyLampFieldGetResponse23V2> SystemBusyLampFieldGetRequest23V2Async(this OcipClient client, SystemBusyLampFieldGetRequest23V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemBusyLampFieldGetResponse23V2;
        }
        /// <summary>
        /// Modify the system level data associated with the Busy Lamp Field
        /// Service. The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// forceUseOfTCP
        /// 
        /// The following elements are only used in AS data mode and ignored in Amplify and XS data mode:
        /// enableRedundancy
        /// redundancyTaskDelayMilliseconds
        /// redundancyTaskIntervalMilliseconds
        /// maxNumberOfSubscriptionsPerRedundancyTaskInterval
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// ignoreUnansweredTerminatingCalls
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBusyLampFieldModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemBusyLampFieldModifyRequest(this OcipClient client, SystemBusyLampFieldModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with the Busy Lamp Field
        /// Service. The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// forceUseOfTCP
        /// 
        /// The following elements are only used in AS data mode and ignored in Amplify and XS data mode:
        /// enableRedundancy
        /// redundancyTaskDelayMilliseconds
        /// redundancyTaskIntervalMilliseconds
        /// maxNumberOfSubscriptionsPerRedundancyTaskInterval
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// ignoreUnansweredTerminatingCalls
        /// </summary>
        public static async Task<SuccessResponse> SystemBusyLampFieldModifyRequestAsync(this OcipClient client, SystemBusyLampFieldModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of available users for the busy lamp field service.
        /// The response is either UserBusyLampFieldGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBusyLampFieldGetAvailableUserListRequestAsync instead.")]
        public static async Task<UserBusyLampFieldGetAvailableUserListResponse> UserBusyLampFieldGetAvailableUserListRequest(this OcipClient client, UserBusyLampFieldGetAvailableUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserBusyLampFieldGetAvailableUserListResponse;
        }

        /// <summary>
        /// Get a list of available users for the busy lamp field service.
        /// The response is either UserBusyLampFieldGetAvailableUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserBusyLampFieldGetAvailableUserListResponse> UserBusyLampFieldGetAvailableUserListRequestAsync(this OcipClient client, UserBusyLampFieldGetAvailableUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserBusyLampFieldGetAvailableUserListResponse;
        }
        /// <summary>
        /// Request the settings for the busy lamp field service.
        /// The response is either a UserBusyLampFieldGetResponse16sp2 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBusyLampFieldGetRequest16sp2Async instead.")]
        public static async Task<UserBusyLampFieldGetResponse16sp2> UserBusyLampFieldGetRequest16sp2(this OcipClient client, UserBusyLampFieldGetRequest16sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserBusyLampFieldGetResponse16sp2;
        }

        /// <summary>
        /// Request the settings for the busy lamp field service.
        /// The response is either a UserBusyLampFieldGetResponse16sp2 or an ErrorResponse.
        /// </summary>
        public static async Task<UserBusyLampFieldGetResponse16sp2> UserBusyLampFieldGetRequest16sp2Async(this OcipClient client, UserBusyLampFieldGetRequest16sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserBusyLampFieldGetResponse16sp2;
        }
        /// <summary>
        /// Modify the settings for the busy lamp field service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBusyLampFieldModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserBusyLampFieldModifyRequest(this OcipClient client, UserBusyLampFieldModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the settings for the busy lamp field service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserBusyLampFieldModifyRequestAsync(this OcipClient client, UserBusyLampFieldModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
