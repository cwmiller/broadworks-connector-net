using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceNumberPortabilityAnnouncementExtensions
    {

        /// <summary>
        /// Get the Number Portability Announcement attributes for the user.
        /// The response is either UserNumberPortabilityAnnouncementGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserNumberPortabilityAnnouncementGetRequestAsync instead.")]
        public static async Task<UserNumberPortabilityAnnouncementGetResponse> UserNumberPortabilityAnnouncementGetRequest(this OcipClient client, UserNumberPortabilityAnnouncementGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserNumberPortabilityAnnouncementGetResponse;
        }

        /// <summary>
        /// Get the Number Portability Announcement attributes for the user.
        /// The response is either UserNumberPortabilityAnnouncementGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserNumberPortabilityAnnouncementGetResponse> UserNumberPortabilityAnnouncementGetRequestAsync(this OcipClient client, UserNumberPortabilityAnnouncementGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserNumberPortabilityAnnouncementGetResponse;
        }
        /// <summary>
        /// Modify the Number Portability Announcement attributes for the user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserNumberPortabilityAnnouncementModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserNumberPortabilityAnnouncementModifyRequest(this OcipClient client, UserNumberPortabilityAnnouncementModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Number Portability Announcement attributes for the user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserNumberPortabilityAnnouncementModifyRequestAsync(this OcipClient client, UserNumberPortabilityAnnouncementModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
