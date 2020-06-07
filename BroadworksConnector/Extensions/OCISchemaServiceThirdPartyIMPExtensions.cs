using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceThirdPartyIMPExtensions
    {

        /// <summary>
        /// Get the system Third-Party IMP service attributes.
        /// The response is either SystemThirdPartyIMPGetResponse19 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemThirdPartyIMPGetRequest19Async instead.")]
        public static async Task<SystemThirdPartyIMPGetResponse19> SystemThirdPartyIMPGetRequest19(this OcipClient client, SystemThirdPartyIMPGetRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemThirdPartyIMPGetResponse19;
        }

        /// <summary>
        /// Get the system Third-Party IMP service attributes.
        /// The response is either SystemThirdPartyIMPGetResponse19 or ErrorResponse.
        /// </summary>
        public static async Task<SystemThirdPartyIMPGetResponse19> SystemThirdPartyIMPGetRequest19Async(this OcipClient client, SystemThirdPartyIMPGetRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemThirdPartyIMPGetResponse19;
        }
        /// <summary>
        /// Modify the system Third-Party IMP service attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemThirdPartyIMPModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemThirdPartyIMPModifyRequest(this OcipClient client, SystemThirdPartyIMPModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system Third-Party IMP service attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemThirdPartyIMPModifyRequestAsync(this OcipClient client, SystemThirdPartyIMPModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
