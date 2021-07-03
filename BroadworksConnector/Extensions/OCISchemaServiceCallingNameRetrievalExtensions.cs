using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallingNameRetrievalExtensions
    {

        /// <summary>
        /// Request the system's calling name retrieval attributes.
        /// The response is either a SystemCallingNameRetrievalGetResponse24 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallingNameRetrievalGetRequest24Async instead.")]
        public static async Task<SystemCallingNameRetrievalGetResponse24> SystemCallingNameRetrievalGetRequest24(this OcipClient client, SystemCallingNameRetrievalGetRequest24 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallingNameRetrievalGetResponse24;
        }

        /// <summary>
        /// Request the system's calling name retrieval attributes.
        /// The response is either a SystemCallingNameRetrievalGetResponse24 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallingNameRetrievalGetResponse24> SystemCallingNameRetrievalGetRequest24Async(this OcipClient client, SystemCallingNameRetrievalGetRequest24 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallingNameRetrievalGetResponse24;
        }
        /// <summary>
        /// Modifies the system's calling name retrieval attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallingNameRetrievalModifyRequest20Async instead.")]
        public static async Task<SuccessResponse> SystemCallingNameRetrievalModifyRequest20(this OcipClient client, SystemCallingNameRetrievalModifyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the system's calling name retrieval attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallingNameRetrievalModifyRequest20Async(this OcipClient client, SystemCallingNameRetrievalModifyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with Calling Name Retrieval.
        /// The response is either a UserCallingNameRetrievalGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallingNameRetrievalGetRequestAsync instead.")]
        public static async Task<UserCallingNameRetrievalGetResponse> UserCallingNameRetrievalGetRequest(this OcipClient client, UserCallingNameRetrievalGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallingNameRetrievalGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Calling Name Retrieval.
        /// The response is either a UserCallingNameRetrievalGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallingNameRetrievalGetResponse> UserCallingNameRetrievalGetRequestAsync(this OcipClient client, UserCallingNameRetrievalGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallingNameRetrievalGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Calling Name Retrieval.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallingNameRetrievalModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallingNameRetrievalModifyRequest(this OcipClient client, UserCallingNameRetrievalModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Calling Name Retrieval.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallingNameRetrievalModifyRequestAsync(this OcipClient client, UserCallingNameRetrievalModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
