using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceConnectedLineIdentificationRestrictionExtensions
    {

        /// <summary>
        /// Request the user level data associated with Connected Line ID Restriction.
        /// The response is either a UserConnectedLineIdentificationRestrictionGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserConnectedLineIdentificationRestrictionGetRequestAsync instead.")]
        public static async Task<UserConnectedLineIdentificationRestrictionGetResponse> UserConnectedLineIdentificationRestrictionGetRequest(this OcipClient client, UserConnectedLineIdentificationRestrictionGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserConnectedLineIdentificationRestrictionGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Connected Line ID Restriction.
        /// The response is either a UserConnectedLineIdentificationRestrictionGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserConnectedLineIdentificationRestrictionGetResponse> UserConnectedLineIdentificationRestrictionGetRequestAsync(this OcipClient client, UserConnectedLineIdentificationRestrictionGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserConnectedLineIdentificationRestrictionGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Connected Line ID Restriction.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserConnectedLineIdentificationRestrictionModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserConnectedLineIdentificationRestrictionModifyRequest(this OcipClient client, UserConnectedLineIdentificationRestrictionModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Connected Line ID Restriction.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserConnectedLineIdentificationRestrictionModifyRequestAsync(this OcipClient client, UserConnectedLineIdentificationRestrictionModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
