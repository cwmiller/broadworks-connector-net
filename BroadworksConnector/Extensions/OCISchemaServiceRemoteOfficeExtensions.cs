using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceRemoteOfficeExtensions
    {

        /// <summary>
        /// Request the user level data associated with Remote Office.
        /// The response is either a UserRemoteOfficeGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserRemoteOfficeGetRequestAsync instead.")]
        public static async Task<UserRemoteOfficeGetResponse> UserRemoteOfficeGetRequest(this OcipClient client, UserRemoteOfficeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserRemoteOfficeGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Remote Office.
        /// The response is either a UserRemoteOfficeGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserRemoteOfficeGetResponse> UserRemoteOfficeGetRequestAsync(this OcipClient client, UserRemoteOfficeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserRemoteOfficeGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Remote Office.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserRemoteOfficeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserRemoteOfficeModifyRequest(this OcipClient client, UserRemoteOfficeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Remote Office.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserRemoteOfficeModifyRequestAsync(this OcipClient client, UserRemoteOfficeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
