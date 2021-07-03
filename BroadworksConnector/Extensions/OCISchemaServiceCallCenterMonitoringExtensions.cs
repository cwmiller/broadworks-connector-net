using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallCenterMonitoringExtensions
    {

        /// <summary>
        /// Request the enterprise level data associated with Call Center Monitoring.
        /// The response is either an EnterpriseCallCenterMonitoringGetResponse23 or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterMonitoringGetRequest23Async instead.")]
        public static async Task<EnterpriseCallCenterMonitoringGetResponse23> EnterpriseCallCenterMonitoringGetRequest23(this OcipClient client, EnterpriseCallCenterMonitoringGetRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterMonitoringGetResponse23;
        }

        /// <summary>
        /// Request the enterprise level data associated with Call Center Monitoring.
        /// The response is either an EnterpriseCallCenterMonitoringGetResponse23 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseCallCenterMonitoringGetResponse23> EnterpriseCallCenterMonitoringGetRequest23Async(this OcipClient client, EnterpriseCallCenterMonitoringGetRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterMonitoringGetResponse23;
        }
        /// <summary>
        /// Modify the enterprise level data associated with Call Center Monitoring
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterMonitoringModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> EnterpriseCallCenterMonitoringModifyRequest(this OcipClient client, EnterpriseCallCenterMonitoringModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the enterprise level data associated with Call Center Monitoring
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterMonitoringModifyRequestAsync(this OcipClient client, EnterpriseCallCenterMonitoringModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the Group level data associated with Call Center Monitoring.
        /// The response is either a GroupCallCenterMonitoringGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterMonitoringGetRequestAsync instead.")]
        public static async Task<GroupCallCenterMonitoringGetResponse> GroupCallCenterMonitoringGetRequest(this OcipClient client, GroupCallCenterMonitoringGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterMonitoringGetResponse;
        }

        /// <summary>
        /// Request the Group level data associated with Call Center Monitoring.
        /// The response is either a GroupCallCenterMonitoringGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterMonitoringGetResponse> GroupCallCenterMonitoringGetRequestAsync(this OcipClient client, GroupCallCenterMonitoringGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterMonitoringGetResponse;
        }
        /// <summary>
        /// Modify the group level data associated with Call Center Monitoring
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterMonitoringModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallCenterMonitoringModifyRequest(this OcipClient client, GroupCallCenterMonitoringModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group level data associated with Call Center Monitoring
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterMonitoringModifyRequestAsync(this OcipClient client, GroupCallCenterMonitoringModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user's Call Center Monitoring settings.
        /// The response is either a UserCallCenterMonitoringGetResponse23 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterMonitoringGetRequest23Async instead.")]
        public static async Task<UserCallCenterMonitoringGetResponse23> UserCallCenterMonitoringGetRequest23(this OcipClient client, UserCallCenterMonitoringGetRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallCenterMonitoringGetResponse23;
        }

        /// <summary>
        /// Request the user's Call Center Monitoring settings.
        /// The response is either a UserCallCenterMonitoringGetResponse23 or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallCenterMonitoringGetResponse23> UserCallCenterMonitoringGetRequest23Async(this OcipClient client, UserCallCenterMonitoringGetRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallCenterMonitoringGetResponse23;
        }
        /// <summary>
        /// Modify the user's Call Center Monitoring settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterMonitoringModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallCenterMonitoringModifyRequest(this OcipClient client, UserCallCenterMonitoringModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's Call Center Monitoring settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallCenterMonitoringModifyRequestAsync(this OcipClient client, UserCallCenterMonitoringModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
