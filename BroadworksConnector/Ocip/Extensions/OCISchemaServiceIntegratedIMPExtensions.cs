using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceIntegratedIMPExtensions
    {

        /// <summary>
        /// Get the Integrated IMP service attributes for the group.
        /// The response is either GroupIntegratedIMPGetResponse21sp1 or ErrorResponse.
        /// </summary>
        public static async Task<GroupIntegratedIMPGetResponse21sp1> GroupIntegratedIMPGetRequest21sp1(this OcipClient client, GroupIntegratedIMPGetRequest21sp1 request)
        {
            return await client.Call(request) as GroupIntegratedIMPGetResponse21sp1;
        }

        /// <summary>
        /// Modify the Integrated IMP service attributes for the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupIntegratedIMPModifyRequest(this OcipClient client, GroupIntegratedIMPModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the Integrated IMP service attributes for the reseller.
        /// The response is either ResellerIntegratedIMPGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<ResellerIntegratedIMPGetResponse22> ResellerIntegratedIMPGetRequest22(this OcipClient client, ResellerIntegratedIMPGetRequest22 request)
        {
            return await client.Call(request) as ResellerIntegratedIMPGetResponse22;
        }

        /// <summary>
        /// Modify the Integrated IMP service attributes for the reseller.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerIntegratedIMPModifyRequest(this OcipClient client, ResellerIntegratedIMPModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the Integrated IMP service attributes for the service provider.
        /// The response is either ServiceProviderIntegratedIMPGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderIntegratedIMPGetResponse22> ServiceProviderIntegratedIMPGetRequest22(this OcipClient client, ServiceProviderIntegratedIMPGetRequest22 request)
        {
            return await client.Call(request) as ServiceProviderIntegratedIMPGetResponse22;
        }

        /// <summary>
        /// Modify the Integrated IMP service attributes for the service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// If the service provider is within a reseller, useSystemServiceDomain means using reseller level service
        /// domain setting. And useSystemMessagingServer means using the reseller level messaging server setting.
        /// 
        /// The following elements are only used in AS data mode:
        /// servicePort
        /// useSystemMessagingServer
        /// provisioningUrl
        /// provisioningUserId
        /// provisioningPassword
        /// boshURL
        /// defaultImpIdType
        /// useResellerIMPIdSetting
        /// 
        /// The element useResellerIMPIdSetting is only applicable for a service provider within a reseller.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderIntegratedIMPModifyRequest(this OcipClient client, ServiceProviderIntegratedIMPModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the system Integrated IMP service attributes.
        /// The response is either SystemIntegratedIMPGetResponse19 or ErrorResponse.
        /// </summary>
        public static async Task<SystemIntegratedIMPGetResponse19> SystemIntegratedIMPGetRequest21(this OcipClient client, SystemIntegratedIMPGetRequest21 request)
        {
            return await client.Call(request) as SystemIntegratedIMPGetResponse19;
        }

        /// <summary>
        /// Modify the system Integrated IMP service attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// boshURL
        /// allowImpPasswordRetrieval
        /// </summary>
        public static async Task<SuccessResponse> SystemIntegratedIMPModifyRequest(this OcipClient client, SystemIntegratedIMPModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Generate a new IMP password for the user. The new generated password is synchronized to BroadCloud/service Messaging Server.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserIntegratedIMPGeneratePasswordRequest(this OcipClient client, UserIntegratedIMPGeneratePasswordRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the Integrated IMP specific service attribute for the user.
        /// The response is either UserIntegratedIMPGetResponse21sp1 or ErrorResponse.
        /// </summary>
        public static async Task<UserIntegratedIMPGetResponse21sp1> UserIntegratedIMPGetRequest21sp1(this OcipClient client, UserIntegratedIMPGetRequest21sp1 request)
        {
            return await client.Call(request) as UserIntegratedIMPGetResponse21sp1;
        }

        /// <summary>
        /// Modifies the Integrated IMP specific service attribute for the user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// If the impId element is set in the request, the impId element does
        /// not take effect on the service for the user unless the request also
        /// has the isActive element set to true to turn the service from off
        /// to on.
        /// If impId is based on an alternate user ID and the impId and userId
        /// are identical, isAlternateImpId should be set to true to determine
        /// that impId is the user's alternate ID.
        /// The following elements are only used in AS data mode and ignored in
        /// XS data mode:
        /// impId
        /// isAlternateImpId
        /// </summary>
        public static async Task<SuccessResponse> UserIntegratedIMPModifyRequest(this OcipClient client, UserIntegratedIMPModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
