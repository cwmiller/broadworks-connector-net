using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCommunicatorExtensions
    {

        /// <summary>
        /// Request to get Configuration Server for a specified service
        /// provider. The response is either a ServiceProviderBroadWorksCommunicatorGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderBroadWorksCommunicatorGetResponse> ServiceProviderBroadWorksCommunicatorGetRequest(this OcipClient client, ServiceProviderBroadWorksCommunicatorGetRequest request)
        {
            return await client.Call(request) as ServiceProviderBroadWorksCommunicatorGetResponse;
        }

        /// <summary>
        /// Request to modify the Configuration URL. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderBroadWorksCommunicatorModifyRequest(this OcipClient client, ServiceProviderBroadWorksCommunicatorModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the Configuration Server for a specified user.
        /// The response is either a UserBroadWorksCommunicatorGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserBroadWorksCommunicatorGetResponse> UserBroadWorksCommunicatorGetRequest(this OcipClient client, UserBroadWorksCommunicatorGetRequest request)
        {
            return await client.Call(request) as UserBroadWorksCommunicatorGetResponse;
        }


    }
}
