using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceINIntegrationExtensions
    {

        /// <summary>
        /// Request to get the user level IN Integration service attributes
        /// The response is either UserINIntegrationGetResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use UserINIntegrationGetRequestAsync instead.")]
        public static async Task<UserINIntegrationGetResponse> UserINIntegrationGetRequest(this OcipClient client, UserINIntegrationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserINIntegrationGetResponse;
        }

        /// <summary>
        /// Request to get the user level IN Integration service attributes
        /// The response is either UserINIntegrationGetResponse or ErrorResponse
        /// </summary>
        public static async Task<UserINIntegrationGetResponse> UserINIntegrationGetRequestAsync(this OcipClient client, UserINIntegrationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserINIntegrationGetResponse;
        }
        /// <summary>
        /// Request to modify the user level IN Integration service attributes
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        [Obsolete("This method is deprecated. Use UserINIntegrationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserINIntegrationModifyRequest(this OcipClient client, UserINIntegrationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the user level IN Integration service attributes
        /// The response is either SuccessResponse or ErrorResponse
        /// </summary>
        public static async Task<SuccessResponse> UserINIntegrationModifyRequestAsync(this OcipClient client, UserINIntegrationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
