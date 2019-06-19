using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceExecutiveAssistantExtensions
    {

        /// <summary>
        /// Get the setting of an executive assistant.
        /// The response is either UserExecutiveAssistantGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserExecutiveAssistantGetResponse> UserExecutiveAssistantGetRequest(this OcipClient client, UserExecutiveAssistantGetRequest request)
        {
            return await client.Call(request) as UserExecutiveAssistantGetResponse;
        }

        /// <summary>
        /// Modify the setting for executive assistant.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserExecutiveAssistantModifyRequest(this OcipClient client, UserExecutiveAssistantModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
