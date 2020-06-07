using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCommPilotExpressExtensions
    {

        /// <summary>
        /// Get the user's commPilot express service setting.
        /// The response is either a UserCommPilotExpressGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCommPilotExpressGetRequestAsync instead.")]
        public static async Task<UserCommPilotExpressGetResponse> UserCommPilotExpressGetRequest(this OcipClient client, UserCommPilotExpressGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCommPilotExpressGetResponse;
        }

        /// <summary>
        /// Get the user's commPilot express service setting.
        /// The response is either a UserCommPilotExpressGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserCommPilotExpressGetResponse> UserCommPilotExpressGetRequestAsync(this OcipClient client, UserCommPilotExpressGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCommPilotExpressGetResponse;
        }
        /// <summary>
        /// Modify the user's commPilot express service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCommPilotExpressModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCommPilotExpressModifyRequest(this OcipClient client, UserCommPilotExpressModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's commPilot express service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        public static async Task<SuccessResponse> UserCommPilotExpressModifyRequestAsync(this OcipClient client, UserCommPilotExpressModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
