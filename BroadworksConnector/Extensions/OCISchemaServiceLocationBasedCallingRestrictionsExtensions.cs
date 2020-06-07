using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceLocationBasedCallingRestrictionsExtensions
    {

        /// <summary>
        /// Gets system level the Location Based Calling Restrictions attributes.
        /// The response is either a SystemLocationBasedCallingRestrictionsGetResponse17sp3 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLocationBasedCallingRestrictionsGetRequest17sp3Async instead.")]
        public static async Task<SystemLocationBasedCallingRestrictionsGetResponse17sp3> SystemLocationBasedCallingRestrictionsGetRequest17sp3(this OcipClient client, SystemLocationBasedCallingRestrictionsGetRequest17sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemLocationBasedCallingRestrictionsGetResponse17sp3;
        }

        /// <summary>
        /// Gets system level the Location Based Calling Restrictions attributes.
        /// The response is either a SystemLocationBasedCallingRestrictionsGetResponse17sp3 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemLocationBasedCallingRestrictionsGetResponse17sp3> SystemLocationBasedCallingRestrictionsGetRequest17sp3Async(this OcipClient client, SystemLocationBasedCallingRestrictionsGetRequest17sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemLocationBasedCallingRestrictionsGetResponse17sp3;
        }
        /// <summary>
        /// Modifies the system level Location Based Calling Restriction attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLocationBasedCallingRestrictionsModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemLocationBasedCallingRestrictionsModifyRequest(this OcipClient client, SystemLocationBasedCallingRestrictionsModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the system level Location Based Calling Restriction attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemLocationBasedCallingRestrictionsModifyRequestAsync(this OcipClient client, SystemLocationBasedCallingRestrictionsModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
