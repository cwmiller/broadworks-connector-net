using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCustomerOriginatedTraceExtensions
    {

        /// <summary>
        /// Request the system level data associated with Customer Originated Trace.
        /// The response is either a SystemCustomerOriginatedTraceGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCustomerOriginatedTraceGetRequestAsync instead.")]
        public static async Task<SystemCustomerOriginatedTraceGetResponse> SystemCustomerOriginatedTraceGetRequest(this OcipClient client, SystemCustomerOriginatedTraceGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCustomerOriginatedTraceGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Customer Originated Trace.
        /// The response is either a SystemCustomerOriginatedTraceGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCustomerOriginatedTraceGetResponse> SystemCustomerOriginatedTraceGetRequestAsync(this OcipClient client, SystemCustomerOriginatedTraceGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCustomerOriginatedTraceGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Customer Originated Trace.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCustomerOriginatedTraceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCustomerOriginatedTraceModifyRequest(this OcipClient client, SystemCustomerOriginatedTraceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Customer Originated Trace.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCustomerOriginatedTraceModifyRequestAsync(this OcipClient client, SystemCustomerOriginatedTraceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
