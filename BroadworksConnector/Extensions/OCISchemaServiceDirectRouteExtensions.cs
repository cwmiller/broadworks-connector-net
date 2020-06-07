using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceDirectRouteExtensions
    {

        /// <summary>
        /// Get the direct route setting and the list of DTGs/Trunk Identities assigned to a user.
        /// The response is either UserDirectRouteGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserDirectRouteGetRequestAsync instead.")]
        public static async Task<UserDirectRouteGetResponse> UserDirectRouteGetRequest(this OcipClient client, UserDirectRouteGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserDirectRouteGetResponse;
        }

        /// <summary>
        /// Get the direct route setting and the list of DTGs/Trunk Identities assigned to a user.
        /// The response is either UserDirectRouteGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserDirectRouteGetResponse> UserDirectRouteGetRequestAsync(this OcipClient client, UserDirectRouteGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserDirectRouteGetResponse;
        }
        /// <summary>
        /// Modify the direct route setting and the list of DTGs/Trunk Identities assigned to a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserDirectRouteModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserDirectRouteModifyRequest(this OcipClient client, UserDirectRouteModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the direct route setting and the list of DTGs/Trunk Identities assigned to a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserDirectRouteModifyRequestAsync(this OcipClient client, UserDirectRouteModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
