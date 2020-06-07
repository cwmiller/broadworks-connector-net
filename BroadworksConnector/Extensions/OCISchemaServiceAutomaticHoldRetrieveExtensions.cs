using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceAutomaticHoldRetrieveExtensions
    {

        /// <summary>
        /// Request the user level data associated with Automatic Hold/Retrieve.
        /// The response is either a UserAutomaticHoldRetrieveGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAutomaticHoldRetrieveGetRequestAsync instead.")]
        public static async Task<UserAutomaticHoldRetrieveGetResponse> UserAutomaticHoldRetrieveGetRequest(this OcipClient client, UserAutomaticHoldRetrieveGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserAutomaticHoldRetrieveGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Automatic Hold/Retrieve.
        /// The response is either a UserAutomaticHoldRetrieveGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserAutomaticHoldRetrieveGetResponse> UserAutomaticHoldRetrieveGetRequestAsync(this OcipClient client, UserAutomaticHoldRetrieveGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserAutomaticHoldRetrieveGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Automatic Hold/Retrieve.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAutomaticHoldRetrieveModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserAutomaticHoldRetrieveModifyRequest(this OcipClient client, UserAutomaticHoldRetrieveModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Automatic Hold/Retrieve.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserAutomaticHoldRetrieveModifyRequestAsync(this OcipClient client, UserAutomaticHoldRetrieveModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
