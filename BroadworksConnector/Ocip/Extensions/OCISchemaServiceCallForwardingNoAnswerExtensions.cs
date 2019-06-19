using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceCallForwardingNoAnswerExtensions
    {

        /// <summary>
        /// Request the user level data associated with Call Forwarding No Answer.
        /// The response is either a UserCallForwardingNoAnswerGetResponse13mp16 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallForwardingNoAnswerGetResponse13mp16> UserCallForwardingNoAnswerGetRequest13mp16(this OcipClient client, UserCallForwardingNoAnswerGetRequest13mp16 request)
        {
            return await client.Call(request) as UserCallForwardingNoAnswerGetResponse13mp16;
        }

        /// <summary>
        /// Modify the user level data associated with Call Forwarding No Answer.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        public static async Task<SuccessResponse> UserCallForwardingNoAnswerModifyRequest(this OcipClient client, UserCallForwardingNoAnswerModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
