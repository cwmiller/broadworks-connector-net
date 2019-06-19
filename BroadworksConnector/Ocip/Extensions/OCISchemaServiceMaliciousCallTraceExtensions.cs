using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceMaliciousCallTraceExtensions
    {

        /// <summary>
        /// Get the service provider's Malicious Call Trace settings.
        /// The response is either a ServiceProviderMaliciousCallTraceGetResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderMaliciousCallTraceGetResponse> ServiceProviderMaliciousCallTraceGetRequest(this OcipClient client, ServiceProviderMaliciousCallTraceGetRequest request)
        {
            return await client.Call(request) as ServiceProviderMaliciousCallTraceGetResponse;
        }

        /// <summary>
        /// Modify the service provider's Malicious Call Trace settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderMaliciousCallTraceModifyRequest(this OcipClient client, ServiceProviderMaliciousCallTraceModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get Malicious Call Trace system parameters and the list of users that use the
        /// Malicious Call Trace feature.
        /// The response is either a SystemMaliciousCallTraceGetResponse or
        /// an ErrorResponse.
        /// </summary>
        public static async Task<SystemMaliciousCallTraceGetResponse> SystemMaliciousCallTraceGetRequest(this OcipClient client, SystemMaliciousCallTraceGetRequest request)
        {
            return await client.Call(request) as SystemMaliciousCallTraceGetResponse;
        }

        /// <summary>
        /// Modify a Malicious Call Trace system parameter.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMaliciousCallTraceModifyRequest(this OcipClient client, SystemMaliciousCallTraceModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the user level data associated with Malicious Call Trace.
        /// The response is either a UserMaliciousCallTraceGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserMaliciousCallTraceGetResponse> UserMaliciousCallTraceGetRequest(this OcipClient client, UserMaliciousCallTraceGetRequest request)
        {
            return await client.Call(request) as UserMaliciousCallTraceGetResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Malicious Call Trace.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserMaliciousCallTraceModifyRequest(this OcipClient client, UserMaliciousCallTraceModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
