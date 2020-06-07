using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceExternalCustomRingbackExtensions
    {

        /// <summary>
        /// Request the service provider level data associated with External Custom Ringback.
        /// The response is either a ServiceProviderExternalCustomRingbackGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderExternalCustomRingbackGetRequestAsync instead.")]
        public static async Task<ServiceProviderExternalCustomRingbackGetResponse> ServiceProviderExternalCustomRingbackGetRequest(this OcipClient client, ServiceProviderExternalCustomRingbackGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderExternalCustomRingbackGetResponse;
        }

        /// <summary>
        /// Request the service provider level data associated with External Custom Ringback.
        /// The response is either a ServiceProviderExternalCustomRingbackGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderExternalCustomRingbackGetResponse> ServiceProviderExternalCustomRingbackGetRequestAsync(this OcipClient client, ServiceProviderExternalCustomRingbackGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderExternalCustomRingbackGetResponse;
        }
        /// <summary>
        /// Modify the service provider level data associated with External Custom Ringback.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderExternalCustomRingbackModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderExternalCustomRingbackModifyRequest(this OcipClient client, ServiceProviderExternalCustomRingbackModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the service provider level data associated with External Custom Ringback.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderExternalCustomRingbackModifyRequestAsync(this OcipClient client, ServiceProviderExternalCustomRingbackModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with External Custom Ringback.
        /// The response is either a UserExternalCustomRingbackGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserExternalCustomRingbackGetRequestAsync instead.")]
        public static async Task<UserExternalCustomRingbackGetResponse> UserExternalCustomRingbackGetRequest(this OcipClient client, UserExternalCustomRingbackGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserExternalCustomRingbackGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with External Custom Ringback.
        /// The response is either a UserExternalCustomRingbackGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserExternalCustomRingbackGetResponse> UserExternalCustomRingbackGetRequestAsync(this OcipClient client, UserExternalCustomRingbackGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserExternalCustomRingbackGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with External Custom Ringback.
        /// The user SIP URI, when selected, it replaces the SP address, port and prefix.
        /// The user SIP URI, if selected, is the Request URI of the SIP INVITE sent
        /// to the external server.  When the service provider data is used instead,
        /// the Request URI is constructed using the prefix, address, port and the user DN.
        /// The timeout value is the only SP configuration used when the user SIP URI is selected.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserExternalCustomRingbackModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserExternalCustomRingbackModifyRequest(this OcipClient client, UserExternalCustomRingbackModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with External Custom Ringback.
        /// The user SIP URI, when selected, it replaces the SP address, port and prefix.
        /// The user SIP URI, if selected, is the Request URI of the SIP INVITE sent
        /// to the external server.  When the service provider data is used instead,
        /// the Request URI is constructed using the prefix, address, port and the user DN.
        /// The timeout value is the only SP configuration used when the user SIP URI is selected.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserExternalCustomRingbackModifyRequestAsync(this OcipClient client, UserExternalCustomRingbackModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
