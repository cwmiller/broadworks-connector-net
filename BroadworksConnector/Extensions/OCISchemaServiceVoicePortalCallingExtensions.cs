using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceVoicePortalCallingExtensions
    {

        /// <summary>
        /// Request the user level data associated with Voice Portal Calling.
        /// The response is either a UserVoicePortalCallingGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserVoicePortalCallingGetResponse> UserVoicePortalCallingGetRequest(this OcipClient client, UserVoicePortalCallingGetRequest request)
        {
            return await client.Call(request) as UserVoicePortalCallingGetResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Voice Portal Calling.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserVoicePortalCallingModifyRequest(this OcipClient client, UserVoicePortalCallingModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
