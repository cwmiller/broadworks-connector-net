using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceVoicePortalCallingExtensions
    {

        /// <summary>
        /// Request the user level data associated with Voice Portal Calling.
        /// The response is either a UserVoicePortalCallingGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoicePortalCallingGetRequestAsync instead.")]
        public static async Task<UserVoicePortalCallingGetResponse> UserVoicePortalCallingGetRequest(this OcipClient client, UserVoicePortalCallingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserVoicePortalCallingGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Voice Portal Calling.
        /// The response is either a UserVoicePortalCallingGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserVoicePortalCallingGetResponse> UserVoicePortalCallingGetRequestAsync(this OcipClient client, UserVoicePortalCallingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserVoicePortalCallingGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Voice Portal Calling.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoicePortalCallingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserVoicePortalCallingModifyRequest(this OcipClient client, UserVoicePortalCallingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Voice Portal Calling.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserVoicePortalCallingModifyRequestAsync(this OcipClient client, UserVoicePortalCallingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
