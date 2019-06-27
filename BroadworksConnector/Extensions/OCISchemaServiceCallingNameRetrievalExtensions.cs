using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallingNameRetrievalExtensions
    {

        /// <summary>
        /// Request the system's calling name retrieval attributes.
        /// The response is either a SystemCallingNameRetrievalGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallingNameRetrievalGetResponse20> SystemCallingNameRetrievalGetRequest20(this OcipClient client, SystemCallingNameRetrievalGetRequest20 request)
        {
            return await client.Call(request) as SystemCallingNameRetrievalGetResponse20;
        }

        /// <summary>
        /// Modifies the system's calling name retrieval attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallingNameRetrievalModifyRequest20(this OcipClient client, SystemCallingNameRetrievalModifyRequest20 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the user level data associated with Calling Name Retrieval.
        /// The response is either a UserCallingNameRetrievalGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallingNameRetrievalGetResponse> UserCallingNameRetrievalGetRequest(this OcipClient client, UserCallingNameRetrievalGetRequest request)
        {
            return await client.Call(request) as UserCallingNameRetrievalGetResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Calling Name Retrieval.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallingNameRetrievalModifyRequest(this OcipClient client, UserCallingNameRetrievalModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
