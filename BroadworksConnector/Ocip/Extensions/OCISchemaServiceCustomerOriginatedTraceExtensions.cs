using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceCustomerOriginatedTraceExtensions
    {

        /// <summary>
        /// Request the system level data associated with Customer Originated Trace.
        /// The response is either a SystemCustomerOriginatedTraceGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCustomerOriginatedTraceGetResponse> SystemCustomerOriginatedTraceGetRequest(this OcipClient client, SystemCustomerOriginatedTraceGetRequest request)
        {
            return await client.Call(request) as SystemCustomerOriginatedTraceGetResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Customer Originated Trace.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCustomerOriginatedTraceModifyRequest(this OcipClient client, SystemCustomerOriginatedTraceModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
