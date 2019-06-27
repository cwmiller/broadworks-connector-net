using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallForwardingAlwaysSecondaryExtensions
    {

        /// <summary>
        /// Request the user level data associated with Call Forwarding Always Secondary service.
        /// The response is either a UserCallForwardingAlwaysSecondaryGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallForwardingAlwaysSecondaryGetResponse> UserCallForwardingAlwaysSecondaryGetRequest(this OcipClient client, UserCallForwardingAlwaysSecondaryGetRequest request)
        {
            return await client.Call(request) as UserCallForwardingAlwaysSecondaryGetResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Call Forwarding Always Secondary service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallForwardingAlwaysSecondaryModifyRequest(this OcipClient client, UserCallForwardingAlwaysSecondaryModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
