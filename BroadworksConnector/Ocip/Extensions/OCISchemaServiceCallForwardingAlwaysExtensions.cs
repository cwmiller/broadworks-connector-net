using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceCallForwardingAlwaysExtensions
    {

        /// <summary>
        /// Request the user level data associated with Call Forwarding Always.
        /// The response is either a UserCallForwardingAlwaysGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallForwardingAlwaysGetResponse> UserCallForwardingAlwaysGetRequest(this OcipClient client, UserCallForwardingAlwaysGetRequest request)
        {
            return await client.Call(request) as UserCallForwardingAlwaysGetResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Call Forwarding Always.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        public static async Task<SuccessResponse> UserCallForwardingAlwaysModifyRequest(this OcipClient client, UserCallForwardingAlwaysModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
