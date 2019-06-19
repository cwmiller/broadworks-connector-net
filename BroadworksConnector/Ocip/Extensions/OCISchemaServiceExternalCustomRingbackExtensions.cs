using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceExternalCustomRingbackExtensions
    {

        /// <summary>
        /// Request the service provider level data associated with External Custom Ringback.
        /// The response is either a ServiceProviderExternalCustomRingbackGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderExternalCustomRingbackGetResponse> ServiceProviderExternalCustomRingbackGetRequest(this OcipClient client, ServiceProviderExternalCustomRingbackGetRequest request)
        {
            return await client.Call(request) as ServiceProviderExternalCustomRingbackGetResponse;
        }

        /// <summary>
        /// Modify the service provider level data associated with External Custom Ringback.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderExternalCustomRingbackModifyRequest(this OcipClient client, ServiceProviderExternalCustomRingbackModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the user level data associated with External Custom Ringback.
        /// The response is either a UserExternalCustomRingbackGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserExternalCustomRingbackGetResponse> UserExternalCustomRingbackGetRequest(this OcipClient client, UserExternalCustomRingbackGetRequest request)
        {
            return await client.Call(request) as UserExternalCustomRingbackGetResponse;
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
        public static async Task<SuccessResponse> UserExternalCustomRingbackModifyRequest(this OcipClient client, UserExternalCustomRingbackModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
