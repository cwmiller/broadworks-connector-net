using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServicePrepaidExtensions
    {

        /// <summary>
        /// Request the user level data associated with Prepaid.
        /// The response is either a UserPrepaidGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserPrepaidGetResponse> UserPrepaidGetRequest(this OcipClient client, UserPrepaidGetRequest request)
        {
            return await client.Call(request) as UserPrepaidGetResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Prepaid.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        public static async Task<SuccessResponse> UserPrepaidModifyRequest(this OcipClient client, UserPrepaidModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
