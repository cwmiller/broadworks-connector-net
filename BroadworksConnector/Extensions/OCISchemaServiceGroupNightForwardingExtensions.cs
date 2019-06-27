using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceGroupNightForwardingExtensions
    {

        /// <summary>
        /// Request to get the Group Night Forwarding group parameters.
        /// The response is either GroupGroupNightForwardingGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupGroupNightForwardingGetResponse> GroupGroupNightForwardingGetRequest(this OcipClient client, GroupGroupNightForwardingGetRequest request)
        {
            return await client.Call(request) as GroupGroupNightForwardingGetResponse;
        }

        /// <summary>
        /// Request to modify the Group Night Forwarding group parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupNightForwardingModifyRequest(this OcipClient client, GroupGroupNightForwardingModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the Group Night Forwarding system parameters.
        /// The response is either SystemGroupNightForwardingGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemGroupNightForwardingGetResponse> SystemGroupNightForwardingGetRequest(this OcipClient client, SystemGroupNightForwardingGetRequest request)
        {
            return await client.Call(request) as SystemGroupNightForwardingGetResponse;
        }

        /// <summary>
        /// Request to modify the Group Night Forwarding system parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemGroupNightForwardingModifyRequest(this OcipClient client, SystemGroupNightForwardingModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the Group Night Forwarding user parameters.
        /// The response is either UserGroupNightForwardingGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserGroupNightForwardingGetResponse> UserGroupNightForwardingGetRequest(this OcipClient client, UserGroupNightForwardingGetRequest request)
        {
            return await client.Call(request) as UserGroupNightForwardingGetResponse;
        }

        /// <summary>
        /// Request to modify the Group Night Forwarding user parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserGroupNightForwardingModifyRequest(this OcipClient client, UserGroupNightForwardingModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
