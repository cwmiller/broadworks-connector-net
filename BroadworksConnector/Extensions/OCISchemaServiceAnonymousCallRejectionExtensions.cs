using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceAnonymousCallRejectionExtensions
    {

        /// <summary>
        /// Get Anonymous Call Rejection system parameters.
        /// The response is either a SystemAnonymousCallRejectionGetResponse or
        /// an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAnonymousCallRejectionGetRequestAsync instead.")]
        public static async Task<SystemAnonymousCallRejectionGetResponse> SystemAnonymousCallRejectionGetRequest(this OcipClient client, SystemAnonymousCallRejectionGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAnonymousCallRejectionGetResponse;
        }

        /// <summary>
        /// Get Anonymous Call Rejection system parameters.
        /// The response is either a SystemAnonymousCallRejectionGetResponse or
        /// an ErrorResponse.
        /// </summary>
        public static async Task<SystemAnonymousCallRejectionGetResponse> SystemAnonymousCallRejectionGetRequestAsync(this OcipClient client, SystemAnonymousCallRejectionGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAnonymousCallRejectionGetResponse;
        }
        /// <summary>
        /// Modify a system Anonymous Call Rejection parameter.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAnonymousCallRejectionModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAnonymousCallRejectionModifyRequest(this OcipClient client, SystemAnonymousCallRejectionModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a system Anonymous Call Rejection parameter.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAnonymousCallRejectionModifyRequestAsync(this OcipClient client, SystemAnonymousCallRejectionModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with Anonymous Call Rejection.
        /// The response is either a UserAnonymousCallRejectionGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAnonymousCallRejectionGetRequestAsync instead.")]
        public static async Task<UserAnonymousCallRejectionGetResponse> UserAnonymousCallRejectionGetRequest(this OcipClient client, UserAnonymousCallRejectionGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserAnonymousCallRejectionGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Anonymous Call Rejection.
        /// The response is either a UserAnonymousCallRejectionGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserAnonymousCallRejectionGetResponse> UserAnonymousCallRejectionGetRequestAsync(this OcipClient client, UserAnonymousCallRejectionGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserAnonymousCallRejectionGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Anonymous Call Rejection.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAnonymousCallRejectionModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserAnonymousCallRejectionModifyRequest(this OcipClient client, UserAnonymousCallRejectionModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Anonymous Call Rejection.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserAnonymousCallRejectionModifyRequestAsync(this OcipClient client, UserAnonymousCallRejectionModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
