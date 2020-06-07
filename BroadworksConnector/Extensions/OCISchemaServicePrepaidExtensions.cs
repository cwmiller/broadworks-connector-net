using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServicePrepaidExtensions
    {

        /// <summary>
        /// Request the user level data associated with Prepaid.
        /// The response is either a UserPrepaidGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPrepaidGetRequestAsync instead.")]
        public static async Task<UserPrepaidGetResponse> UserPrepaidGetRequest(this OcipClient client, UserPrepaidGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPrepaidGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Prepaid.
        /// The response is either a UserPrepaidGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserPrepaidGetResponse> UserPrepaidGetRequestAsync(this OcipClient client, UserPrepaidGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPrepaidGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Prepaid.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPrepaidModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPrepaidModifyRequest(this OcipClient client, UserPrepaidModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Prepaid.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        public static async Task<SuccessResponse> UserPrepaidModifyRequestAsync(this OcipClient client, UserPrepaidModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
