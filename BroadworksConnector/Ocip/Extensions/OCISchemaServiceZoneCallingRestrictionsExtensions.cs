using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceZoneCallingRestrictionsExtensions
    {

        /// <summary>
        /// Gets the Service Provider/Enterprise level Zone Calling Restrictions Policies.
        /// The response is ServiceProviderZoneCallingRestrictionsGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderZoneCallingRestrictionsGetResponse> ServiceProviderZoneCallingRestrictionsGetRequest(this OcipClient client, ServiceProviderZoneCallingRestrictionsGetRequest request)
        {
            return await client.Call(request) as ServiceProviderZoneCallingRestrictionsGetResponse;
        }

        /// <summary>
        /// Modifies the Service Provider/Enterprise level Zone Calling Restrictions Policies.
        /// The response is SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderZoneCallingRestrictionsModifyRequest(this OcipClient client, ServiceProviderZoneCallingRestrictionsModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Gets the home zone for a user
        /// The response is either a UserZoneCallingRestrictionsGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserZoneCallingRestrictionsGetResponse> UserZoneCallingRestrictionsGetRequest(this OcipClient client, UserZoneCallingRestrictionsGetRequest request)
        {
            return await client.Call(request) as UserZoneCallingRestrictionsGetResponse;
        }

        /// <summary>
        /// Modify the home zone for a user
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserZoneCallingRestrictionsModifyRequest(this OcipClient client, UserZoneCallingRestrictionsModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
