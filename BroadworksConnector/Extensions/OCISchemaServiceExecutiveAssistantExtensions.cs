using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceExecutiveAssistantExtensions
    {

        /// <summary>
        /// Get the setting of an executive assistant.
        /// The response is either UserExecutiveAssistantGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserExecutiveAssistantGetRequestAsync instead.")]
        public static async Task<UserExecutiveAssistantGetResponse> UserExecutiveAssistantGetRequest(this OcipClient client, UserExecutiveAssistantGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserExecutiveAssistantGetResponse;
        }

        /// <summary>
        /// Get the setting of an executive assistant.
        /// The response is either UserExecutiveAssistantGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserExecutiveAssistantGetResponse> UserExecutiveAssistantGetRequestAsync(this OcipClient client, UserExecutiveAssistantGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserExecutiveAssistantGetResponse;
        }
        /// <summary>
        /// Modify the setting for executive assistant.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserExecutiveAssistantModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserExecutiveAssistantModifyRequest(this OcipClient client, UserExecutiveAssistantModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the setting for executive assistant.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserExecutiveAssistantModifyRequestAsync(this OcipClient client, UserExecutiveAssistantModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
