using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceResourcePriorityExtensions
    {

        /// <summary>
        /// Get the Resource Priority service attributes for the reseller.
        /// The response is either ResellerResourcePriorityGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<ResellerResourcePriorityGetResponse> ResellerResourcePriorityGetRequest(this OcipClient client, ResellerResourcePriorityGetRequest request)
        {
            return await client.Call(request) as ResellerResourcePriorityGetResponse;
        }

        /// <summary>
        /// Modify the Resource Priority service attributes for the reseller.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerResourcePriorityModifyRequest(this OcipClient client, ResellerResourcePriorityModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the system Resource Priority service attributes.
        /// The response is either SystemResourcePriorityGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemResourcePriorityGetResponse> SystemResourcePriorityGetRequest(this OcipClient client, SystemResourcePriorityGetRequest request)
        {
            return await client.Call(request) as SystemResourcePriorityGetResponse;
        }

        /// <summary>
        /// Modify the system Resource Priority service attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemResourcePriorityModifyRequest(this OcipClient client, SystemResourcePriorityModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the Resource Priority settings of a user.
        /// The response is either UserResourcePriorityGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserResourcePriorityGetResponse> UserResourcePriorityGetRequest(this OcipClient client, UserResourcePriorityGetRequest request)
        {
            return await client.Call(request) as UserResourcePriorityGetResponse;
        }

        /// <summary>
        /// Modify the Resource Priority settings of a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserResourcePriorityModifyRequest(this OcipClient client, UserResourcePriorityModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
