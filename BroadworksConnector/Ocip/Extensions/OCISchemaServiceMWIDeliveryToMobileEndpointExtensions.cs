using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceMWIDeliveryToMobileEndpointExtensions
    {

        /// <summary>
        /// Create a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupMWIDeliveryToMobileEndpointCustomTemplateAddRequest(this OcipClient client, GroupMWIDeliveryToMobileEndpointCustomTemplateAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupMWIDeliveryToMobileEndpointCustomTemplateDeleteRequest(this OcipClient client, GroupMWIDeliveryToMobileEndpointCustomTemplateDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a GroupMWIDeliveryToMobileEndpointCustomTemplateGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupMWIDeliveryToMobileEndpointCustomTemplateGetResponse> GroupMWIDeliveryToMobileEndpointCustomTemplateGetRequest(this OcipClient client, GroupMWIDeliveryToMobileEndpointCustomTemplateGetRequest request)
        {
            return await client.Call(request) as GroupMWIDeliveryToMobileEndpointCustomTemplateGetResponse;
        }

        /// <summary>
        /// Modify a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupMWIDeliveryToMobileEndpointCustomTemplateModifyRequest(this OcipClient client, GroupMWIDeliveryToMobileEndpointCustomTemplateModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests group MWI custom notifications settings.
        /// The response is either a GroupMWIDeliveryToMobileEndpointGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupMWIDeliveryToMobileEndpointGetResponse> GroupMWIDeliveryToMobileEndpointGetRequest(this OcipClient client, GroupMWIDeliveryToMobileEndpointGetRequest request)
        {
            return await client.Call(request) as GroupMWIDeliveryToMobileEndpointGetResponse;
        }

        /// <summary>
        /// Modify the group level MWI custom notifications settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// If the request is executed by a group administrator and modifies the useSettingLevel, the request is rejected.
        /// </summary>
        public static async Task<SuccessResponse> GroupMWIDeliveryToMobileEndpointModifyRequest(this OcipClient client, GroupMWIDeliveryToMobileEndpointModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Create a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateAddRequest(this OcipClient client, ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateDeleteRequest(this OcipClient client, ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetResponse> ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetRequest(this OcipClient client, ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetRequest request)
        {
            return await client.Call(request) as ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateGetResponse;
        }

        /// <summary>
        /// Modify a MWI Delivery to Mobile Endpoint Custom Template.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateModifyRequest(this OcipClient client, ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the service provider level data associated with MWI Delivery to Mobile Endpoint service.
        /// The response is either a ServiceProviderMWIDeliveryToMobileEndpointGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderMWIDeliveryToMobileEndpointGetResponse> ServiceProviderMWIDeliveryToMobileEndpointGetRequest(this OcipClient client, ServiceProviderMWIDeliveryToMobileEndpointGetRequest request)
        {
            return await client.Call(request) as ServiceProviderMWIDeliveryToMobileEndpointGetResponse;
        }

        /// <summary>
        /// Modify the service provider level MWI custom notifications settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderMWIDeliveryToMobileEndpointModifyRequest(this OcipClient client, ServiceProviderMWIDeliveryToMobileEndpointModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the user level data associated with MWI Delivery to Mobile Endpoint service.
        /// The response is either a UserMWIDeliveryToMobileEndpointGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserMWIDeliveryToMobileEndpointGetResponse> UserMWIDeliveryToMobileEndpointGetRequest(this OcipClient client, UserMWIDeliveryToMobileEndpointGetRequest request)
        {
            return await client.Call(request) as UserMWIDeliveryToMobileEndpointGetResponse;
        }

        /// <summary>
        /// Request to modify the user level data associated with MWI Delivery to Mobile Endpoint service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserMWIDeliveryToMobileEndpointModifyRequest(this OcipClient client, UserMWIDeliveryToMobileEndpointModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
