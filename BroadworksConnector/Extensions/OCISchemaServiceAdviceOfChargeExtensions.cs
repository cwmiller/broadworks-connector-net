using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceAdviceOfChargeExtensions
    {

        /// <summary>
        /// Request to get the list of Advice of Charge group parameters.
        /// The response is either GroupAdviceOfChargeGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupAdviceOfChargeGetResponse> GroupAdviceOfChargeGetRequest(this OcipClient client, GroupAdviceOfChargeGetRequest request)
        {
            return await client.Call(request) as GroupAdviceOfChargeGetResponse;
        }

        /// <summary>
        /// Modify the service provider level Advice Of Charge group settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAdviceOfChargeModifyRequest(this OcipClient client, GroupAdviceOfChargeModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the list of Advice of Charge service provider parameters.
        /// The response is either ServiceProviderAdviceOfChargeGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAdviceOfChargeGetResponse> ServiceProviderAdviceOfChargeGetRequest(this OcipClient client, ServiceProviderAdviceOfChargeGetRequest request)
        {
            return await client.Call(request) as ServiceProviderAdviceOfChargeGetResponse;
        }

        /// <summary>
        /// Modify the service provider level Advice Of Charge service provider settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAdviceOfChargeModifyRequest(this OcipClient client, ServiceProviderAdviceOfChargeModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a cost information source. The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAdviceOfChargeCostInformationSourceAddRequest(this OcipClient client, SystemAdviceOfChargeCostInformationSourceAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a cost information source.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAdviceOfChargeCostInformationSourceDeleteRequest(this OcipClient client, SystemAdviceOfChargeCostInformationSourceDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a list of cost information sources.
        /// The response is either SystemAdviceOfChargeCostInformationSourceGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemAdviceOfChargeCostInformationSourceGetListResponse> SystemAdviceOfChargeCostInformationSourceGetListRequest(this OcipClient client, SystemAdviceOfChargeCostInformationSourceGetListRequest request)
        {
            return await client.Call(request) as SystemAdviceOfChargeCostInformationSourceGetListResponse;
        }

        /// <summary>
        /// Modify a cost information source.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAdviceOfChargeCostInformationSourceModifyRequest(this OcipClient client, SystemAdviceOfChargeCostInformationSourceModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the list of Advice of Charge system parameters.
        /// The response is either SystemAdviceOfChargeGetResponse19sp1 or ErrorResponse.
        /// </summary>
        public static async Task<SystemAdviceOfChargeGetResponse19sp1> SystemAdviceOfChargeGetRequest19sp1(this OcipClient client, SystemAdviceOfChargeGetRequest19sp1 request)
        {
            return await client.Call(request) as SystemAdviceOfChargeGetResponse19sp1;
        }

        /// <summary>
        /// Request to modify Advice of Charge system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAdviceOfChargeModifyRequest19sp1(this OcipClient client, SystemAdviceOfChargeModifyRequest19sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the user level data associated with Advice Of Charge.
        /// The response is either a UserAdviceOfChargeGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserAdviceOfChargeGetResponse> UserAdviceOfChargeGetRequest(this OcipClient client, UserAdviceOfChargeGetRequest request)
        {
            return await client.Call(request) as UserAdviceOfChargeGetResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Advice of Charge.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserAdviceOfChargeModifyRequest(this OcipClient client, UserAdviceOfChargeModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
