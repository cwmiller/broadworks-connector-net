using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceFaxMessagingExtensions
    {

        /// <summary>
        /// Request the system level data associated with Fax Messaging.
        /// The response is either a SystemFaxMessagingGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFaxMessagingGetRequestAsync instead.")]
        public static async Task<SystemFaxMessagingGetResponse> SystemFaxMessagingGetRequest(this OcipClient client, SystemFaxMessagingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemFaxMessagingGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Fax Messaging.
        /// The response is either a SystemFaxMessagingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemFaxMessagingGetResponse> SystemFaxMessagingGetRequestAsync(this OcipClient client, SystemFaxMessagingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemFaxMessagingGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Fax Messaging.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// statusDurationHours
        /// statusAuditIntervalHours
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFaxMessagingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemFaxMessagingModifyRequest(this OcipClient client, SystemFaxMessagingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Fax Messaging.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// statusDurationHours
        /// statusAuditIntervalHours
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemFaxMessagingModifyRequestAsync(this OcipClient client, SystemFaxMessagingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with Fax Messaging.
        /// The response is either a UserFaxMessagingGetResponse17sp1 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserFaxMessagingGetRequest17sp1Async instead.")]
        public static async Task<UserFaxMessagingGetResponse17sp1> UserFaxMessagingGetRequest17sp1(this OcipClient client, UserFaxMessagingGetRequest17sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserFaxMessagingGetResponse17sp1;
        }

        /// <summary>
        /// Request the user level data associated with Fax Messaging.
        /// The response is either a UserFaxMessagingGetResponse17sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<UserFaxMessagingGetResponse17sp1> UserFaxMessagingGetRequest17sp1Async(this OcipClient client, UserFaxMessagingGetRequest17sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserFaxMessagingGetResponse17sp1;
        }
        /// <summary>
        /// Modify the user level data associated with Fax Messaging.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserFaxMessagingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserFaxMessagingModifyRequest(this OcipClient client, UserFaxMessagingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Fax Messaging.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserFaxMessagingModifyRequestAsync(this OcipClient client, UserFaxMessagingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
