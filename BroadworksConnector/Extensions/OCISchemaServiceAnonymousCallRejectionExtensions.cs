using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceAnonymousCallRejectionExtensions
    {

        /// <summary>
        /// Get Anonymous Call Rejection system parameters.
        /// The response is either a SystemAnonymousCallRejectionGetResponse or
        /// an ErrorResponse.
        /// </summary>
        public static async Task<SystemAnonymousCallRejectionGetResponse> SystemAnonymousCallRejectionGetRequest(this OcipClient client, SystemAnonymousCallRejectionGetRequest request)
        {
            return await client.Call(request) as SystemAnonymousCallRejectionGetResponse;
        }

        /// <summary>
        /// Modify a system Anonymous Call Rejection parameter.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAnonymousCallRejectionModifyRequest(this OcipClient client, SystemAnonymousCallRejectionModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the user level data associated with Anonymous Call Rejection.
        /// The response is either a UserAnonymousCallRejectionGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserAnonymousCallRejectionGetResponse> UserAnonymousCallRejectionGetRequest(this OcipClient client, UserAnonymousCallRejectionGetRequest request)
        {
            return await client.Call(request) as UserAnonymousCallRejectionGetResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Anonymous Call Rejection.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserAnonymousCallRejectionModifyRequest(this OcipClient client, UserAnonymousCallRejectionModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
