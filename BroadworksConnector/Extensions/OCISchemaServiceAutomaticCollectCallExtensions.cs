using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceAutomaticCollectCallExtensions
    {

        /// <summary>
        /// Get system Automatic Collect Call service settings.
        /// The response is either SystemAutomaticCollectCallGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemAutomaticCollectCallGetResponse> SystemAutomaticCollectCallGetRequest(this OcipClient client, SystemAutomaticCollectCallGetRequest request)
        {
            return await client.Call(request) as SystemAutomaticCollectCallGetResponse;
        }

        /// <summary>
        /// Modify system Automatic Collect Call service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAutomaticCollectCallModifyRequest(this OcipClient client, SystemAutomaticCollectCallModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a system automatic collect call prefix digits entry.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAutomaticCollectCallPrefixDigitsAddListRequest(this OcipClient client, SystemAutomaticCollectCallPrefixDigitsAddListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete an entry in system automatic collect call prefix table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAutomaticCollectCallPrefixDigitsDeleteListRequest(this OcipClient client, SystemAutomaticCollectCallPrefixDigitsDeleteListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the system automatic collect call prefix digits lists.
        /// The response is either SystemAutomaticCollectCallPrefixDigitsGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemAutomaticCollectCallPrefixDigitsGetListResponse> SystemAutomaticCollectCallPrefixDigitsGetListRequest(this OcipClient client, SystemAutomaticCollectCallPrefixDigitsGetListRequest request)
        {
            return await client.Call(request) as SystemAutomaticCollectCallPrefixDigitsGetListResponse;
        }

        /// <summary>
        /// Get user Automatic Collect Call service settings.
        /// The response is either UserAutomaticCollectCallGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserAutomaticCollectCallGetResponse> UserAutomaticCollectCallGetRequest(this OcipClient client, UserAutomaticCollectCallGetRequest request)
        {
            return await client.Call(request) as UserAutomaticCollectCallGetResponse;
        }

        /// <summary>
        /// Modify user Automatic Collect Call service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserAutomaticCollectCallModifyRequest(this OcipClient client, UserAutomaticCollectCallModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
