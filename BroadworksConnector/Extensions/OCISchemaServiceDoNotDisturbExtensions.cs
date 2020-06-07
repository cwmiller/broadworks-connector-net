using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceDoNotDisturbExtensions
    {

        /// <summary>
        /// Request the user level data associated with Do Not Disturb.
        /// The response is either a UserDoNotDisturbGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserDoNotDisturbGetRequestAsync instead.")]
        public static async Task<UserDoNotDisturbGetResponse> UserDoNotDisturbGetRequest(this OcipClient client, UserDoNotDisturbGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserDoNotDisturbGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Do Not Disturb.
        /// The response is either a UserDoNotDisturbGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserDoNotDisturbGetResponse> UserDoNotDisturbGetRequestAsync(this OcipClient client, UserDoNotDisturbGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserDoNotDisturbGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Do Not Disturb.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserDoNotDisturbModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserDoNotDisturbModifyRequest(this OcipClient client, UserDoNotDisturbModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Do Not Disturb.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        public static async Task<SuccessResponse> UserDoNotDisturbModifyRequestAsync(this OcipClient client, UserDoNotDisturbModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
