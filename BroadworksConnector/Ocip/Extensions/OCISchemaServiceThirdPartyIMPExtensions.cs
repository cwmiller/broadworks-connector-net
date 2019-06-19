using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceThirdPartyIMPExtensions
    {

        /// <summary>
        /// Get the system Third-Party IMP service attributes.
        /// The response is either SystemThirdPartyIMPGetResponse19 or ErrorResponse.
        /// </summary>
        public static async Task<SystemThirdPartyIMPGetResponse19> SystemThirdPartyIMPGetRequest19(this OcipClient client, SystemThirdPartyIMPGetRequest19 request)
        {
            return await client.Call(request) as SystemThirdPartyIMPGetResponse19;
        }

        /// <summary>
        /// Modify the system Third-Party IMP service attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemThirdPartyIMPModifyRequest(this OcipClient client, SystemThirdPartyIMPModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
