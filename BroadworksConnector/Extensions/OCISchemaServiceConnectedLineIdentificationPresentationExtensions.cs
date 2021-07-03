using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceConnectedLineIdentificationPresentationExtensions
    {

        /// <summary>
        /// Request the system level data associated with the COLP service.
        /// The response is either a SystemConnectedLineIdentificationPresentationGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemConnectedLineIdentificationPresentationGetRequestAsync instead.")]
        public static async Task<SystemConnectedLineIdentificationPresentationGetResponse> SystemConnectedLineIdentificationPresentationGetRequest(this OcipClient client, SystemConnectedLineIdentificationPresentationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemConnectedLineIdentificationPresentationGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with the COLP service.
        /// The response is either a SystemConnectedLineIdentificationPresentationGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemConnectedLineIdentificationPresentationGetResponse> SystemConnectedLineIdentificationPresentationGetRequestAsync(this OcipClient client, SystemConnectedLineIdentificationPresentationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemConnectedLineIdentificationPresentationGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with the COLP Service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemConnectedLineIdentificationPresentationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemConnectedLineIdentificationPresentationModifyRequest(this OcipClient client, SystemConnectedLineIdentificationPresentationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with the COLP Service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemConnectedLineIdentificationPresentationModifyRequestAsync(this OcipClient client, SystemConnectedLineIdentificationPresentationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
