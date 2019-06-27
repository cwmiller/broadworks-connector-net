using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceSimultaneousRingPersonalExtensions
    {

        /// <summary>
        /// Add a criteria to the user's simultaneous ring personal service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSimultaneousRingPersonalAddCriteriaRequest(this OcipClient client, UserSimultaneousRingPersonalAddCriteriaRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a criteria from the user's simultaneous ring personal service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSimultaneousRingPersonalDeleteCriteriaRequest(this OcipClient client, UserSimultaneousRingPersonalDeleteCriteriaRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a criteria for the user's simultaneous ring personal service.
        /// The response is either a UserSimultaneousRingPersonalGetCriteriaResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserSimultaneousRingPersonalGetCriteriaResponse> UserSimultaneousRingPersonalGetCriteriaRequest(this OcipClient client, UserSimultaneousRingPersonalGetCriteriaRequest request)
        {
            return await client.Call(request) as UserSimultaneousRingPersonalGetCriteriaResponse;
        }

        /// <summary>
        /// Get the user's simultaneous ring personal service setting.
        /// The response is either a UserSimultaneousRingPersonalGetResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<UserSimultaneousRingPersonalGetResponse17> UserSimultaneousRingPersonalGetRequest17(this OcipClient client, UserSimultaneousRingPersonalGetRequest17 request)
        {
            return await client.Call(request) as UserSimultaneousRingPersonalGetResponse17;
        }

        /// <summary>
        /// Modify a criteria for the user's simultaneous ring personal service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSimultaneousRingPersonalModifyCriteriaRequest(this OcipClient client, UserSimultaneousRingPersonalModifyCriteriaRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's simultaneous ring personal service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSimultaneousRingPersonalModifyRequest17(this OcipClient client, UserSimultaneousRingPersonalModifyRequest17 request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
