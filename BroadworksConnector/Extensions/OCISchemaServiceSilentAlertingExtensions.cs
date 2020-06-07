using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceSilentAlertingExtensions
    {

        /// <summary>
        /// Request the user level data associated with Silent Alerting service.
        /// The response is either a UserSilentAlertingGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSilentAlertingGetRequestAsync instead.")]
        public static async Task<UserSilentAlertingGetResponse> UserSilentAlertingGetRequest(this OcipClient client, UserSilentAlertingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserSilentAlertingGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Silent Alerting service.
        /// The response is either a UserSilentAlertingGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserSilentAlertingGetResponse> UserSilentAlertingGetRequestAsync(this OcipClient client, UserSilentAlertingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserSilentAlertingGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Silent Alerting service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSilentAlertingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserSilentAlertingModifyRequest(this OcipClient client, UserSilentAlertingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Silent Alerting service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSilentAlertingModifyRequestAsync(this OcipClient client, UserSilentAlertingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
