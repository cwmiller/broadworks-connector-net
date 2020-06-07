using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceChargeNumberExtensions
    {

        /// <summary>
        /// Request the user level data associated with Charge Number.
        /// The response is either a UserChargeNumberGetResponse14sp9 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserChargeNumberGetRequest14sp9Async instead.")]
        public static async Task<UserChargeNumberGetResponse14sp9> UserChargeNumberGetRequest14sp9(this OcipClient client, UserChargeNumberGetRequest14sp9 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserChargeNumberGetResponse14sp9;
        }

        /// <summary>
        /// Request the user level data associated with Charge Number.
        /// The response is either a UserChargeNumberGetResponse14sp9 or an ErrorResponse.
        /// </summary>
        public static async Task<UserChargeNumberGetResponse14sp9> UserChargeNumberGetRequest14sp9Async(this OcipClient client, UserChargeNumberGetRequest14sp9 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserChargeNumberGetResponse14sp9;
        }
        /// <summary>
        /// Modify the user level data associated with Charge Number.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserChargeNumberModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserChargeNumberModifyRequest(this OcipClient client, UserChargeNumberModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Charge Number.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserChargeNumberModifyRequestAsync(this OcipClient client, UserChargeNumberModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
