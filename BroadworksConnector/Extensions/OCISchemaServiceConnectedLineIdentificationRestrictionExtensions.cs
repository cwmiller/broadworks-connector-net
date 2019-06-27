using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceConnectedLineIdentificationRestrictionExtensions
    {

        /// <summary>
        /// Request the user level data associated with Connected Line ID Restriction.
        /// The response is either a UserConnectedLineIdentificationRestrictionGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserConnectedLineIdentificationRestrictionGetResponse> UserConnectedLineIdentificationRestrictionGetRequest(this OcipClient client, UserConnectedLineIdentificationRestrictionGetRequest request)
        {
            return await client.Call(request) as UserConnectedLineIdentificationRestrictionGetResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Connected Line ID Restriction.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserConnectedLineIdentificationRestrictionModifyRequest(this OcipClient client, UserConnectedLineIdentificationRestrictionModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
