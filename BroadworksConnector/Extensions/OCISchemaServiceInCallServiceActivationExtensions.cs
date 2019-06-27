using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceInCallServiceActivationExtensions
    {

        /// <summary>
        /// Request the service provider's DTMF based in-call service activation trigger attributes.The response is either a ServiceProviderInCallServiceActivationGetResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderInCallServiceActivationGetResponse17> ServiceProviderInCallServiceActivationGetRequest17(this OcipClient client, ServiceProviderInCallServiceActivationGetRequest17 request)
        {
            return await client.Call(request) as ServiceProviderInCallServiceActivationGetResponse17;
        }

        /// <summary>
        /// Modifies the service provider's DTMF based in-call service activation trigger attributes.The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderInCallServiceActivationModifyRequest17(this OcipClient client, ServiceProviderInCallServiceActivationModifyRequest17 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the system's DTMF based in-call service activation trigger attributes. The response is either a SystemInCallServiceActivationGetResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemInCallServiceActivationGetResponse17> SystemInCallServiceActivationGetRequest17(this OcipClient client, SystemInCallServiceActivationGetRequest17 request)
        {
            return await client.Call(request) as SystemInCallServiceActivationGetResponse17;
        }

        /// <summary>
        /// Modifies the system's DTMF based in-call service activation trigger  attributes.The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemInCallServiceActivationModifyRequest17(this OcipClient client, SystemInCallServiceActivationModifyRequest17 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the user level data associated with In-Call Service Activation.
        /// The response is either a UserInCallServiceActivationGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserInCallServiceActivationGetResponse> UserInCallServiceActivationGetRequest(this OcipClient client, UserInCallServiceActivationGetRequest request)
        {
            return await client.Call(request) as UserInCallServiceActivationGetResponse;
        }

        /// <summary>
        /// Modify the user level data associated with In-Call Service Activation.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserInCallServiceActivationModifyRequest(this OcipClient client, UserInCallServiceActivationModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
