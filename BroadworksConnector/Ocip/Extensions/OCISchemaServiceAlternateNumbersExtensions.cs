using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceAlternateNumbersExtensions
    {

        /// <summary>
        /// Request the user level data associated with alternate numbers.
        /// The response is either a UserAlternateNumbersGetResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<UserAlternateNumbersGetResponse21> UserAlternateNumbersGetRequest21(this OcipClient client, UserAlternateNumbersGetRequest21 request)
        {
            return await client.Call(request) as UserAlternateNumbersGetResponse21;
        }

        /// <summary>
        /// Modify the user level data associated with Alternate Numbers.
        /// The following element in AlternateNumberEntry21 datatype is only used in AS mode:
        /// description
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserAlternateNumbersModifyRequest(this OcipClient client, UserAlternateNumbersModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
