using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceNumberPortabilityAnnouncementExtensions
    {

        /// <summary>
        /// Get the Number Portability Announcement attributes for the user.
        /// The response is either UserNumberPortabilityAnnouncementGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserNumberPortabilityAnnouncementGetResponse> UserNumberPortabilityAnnouncementGetRequest(this OcipClient client, UserNumberPortabilityAnnouncementGetRequest request)
        {
            return await client.Call(request) as UserNumberPortabilityAnnouncementGetResponse;
        }

        /// <summary>
        /// Modify the Number Portability Announcement attributes for the user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserNumberPortabilityAnnouncementModifyRequest(this OcipClient client, UserNumberPortabilityAnnouncementModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
