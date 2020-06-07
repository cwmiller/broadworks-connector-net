using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCommunicatorExtensions
    {

        /// <summary>
        /// Request to get Configuration Server for a specified service
        /// provider. The response is either a ServiceProviderBroadWorksCommunicatorGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderBroadWorksCommunicatorGetRequestAsync instead.")]
        public static async Task<ServiceProviderBroadWorksCommunicatorGetResponse> ServiceProviderBroadWorksCommunicatorGetRequest(this OcipClient client, ServiceProviderBroadWorksCommunicatorGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderBroadWorksCommunicatorGetResponse;
        }

        /// <summary>
        /// Request to get Configuration Server for a specified service
        /// provider. The response is either a ServiceProviderBroadWorksCommunicatorGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderBroadWorksCommunicatorGetResponse> ServiceProviderBroadWorksCommunicatorGetRequestAsync(this OcipClient client, ServiceProviderBroadWorksCommunicatorGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderBroadWorksCommunicatorGetResponse;
        }
        /// <summary>
        /// Request to modify the Configuration URL. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderBroadWorksCommunicatorModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderBroadWorksCommunicatorModifyRequest(this OcipClient client, ServiceProviderBroadWorksCommunicatorModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the Configuration URL. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderBroadWorksCommunicatorModifyRequestAsync(this OcipClient client, ServiceProviderBroadWorksCommunicatorModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the Configuration Server for a specified user.
        /// The response is either a UserBroadWorksCommunicatorGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksCommunicatorGetRequestAsync instead.")]
        public static async Task<UserBroadWorksCommunicatorGetResponse> UserBroadWorksCommunicatorGetRequest(this OcipClient client, UserBroadWorksCommunicatorGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserBroadWorksCommunicatorGetResponse;
        }

        /// <summary>
        /// Request to get the Configuration Server for a specified user.
        /// The response is either a UserBroadWorksCommunicatorGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserBroadWorksCommunicatorGetResponse> UserBroadWorksCommunicatorGetRequestAsync(this OcipClient client, UserBroadWorksCommunicatorGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserBroadWorksCommunicatorGetResponse;
        }

    }
}
