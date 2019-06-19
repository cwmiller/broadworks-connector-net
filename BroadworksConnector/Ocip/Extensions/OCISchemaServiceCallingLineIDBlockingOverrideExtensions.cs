using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceCallingLineIDBlockingOverrideExtensions
    {

        /// <summary>
        /// Request the user level data associated with Calling Line ID Blocking Override.
        /// The response is either a UserCallingLineIDBlockingOverrideGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallingLineIDBlockingOverrideGetResponse> UserCallingLineIDBlockingOverrideGetRequest(this OcipClient client, UserCallingLineIDBlockingOverrideGetRequest request)
        {
            return await client.Call(request) as UserCallingLineIDBlockingOverrideGetResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Calling Line ID Blocking Override.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallingLineIDBlockingOverrideModifyRequest(this OcipClient client, UserCallingLineIDBlockingOverrideModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
