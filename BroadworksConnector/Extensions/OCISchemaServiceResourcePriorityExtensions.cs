using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceResourcePriorityExtensions
    {

        /// <summary>
        /// Get the Resource Priority service attributes for the reseller.
        /// The response is either ResellerResourcePriorityGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerResourcePriorityGetRequestAsync instead.")]
        public static async Task<ResellerResourcePriorityGetResponse> ResellerResourcePriorityGetRequest(this OcipClient client, ResellerResourcePriorityGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerResourcePriorityGetResponse;
        }

        /// <summary>
        /// Get the Resource Priority service attributes for the reseller.
        /// The response is either ResellerResourcePriorityGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<ResellerResourcePriorityGetResponse> ResellerResourcePriorityGetRequestAsync(this OcipClient client, ResellerResourcePriorityGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerResourcePriorityGetResponse;
        }
        /// <summary>
        /// Modify the Resource Priority service attributes for the reseller.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerResourcePriorityModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerResourcePriorityModifyRequest(this OcipClient client, ResellerResourcePriorityModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Resource Priority service attributes for the reseller.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerResourcePriorityModifyRequestAsync(this OcipClient client, ResellerResourcePriorityModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the system Resource Priority service attributes.
        /// The response is either SystemResourcePriorityGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemResourcePriorityGetRequestAsync instead.")]
        public static async Task<SystemResourcePriorityGetResponse> SystemResourcePriorityGetRequest(this OcipClient client, SystemResourcePriorityGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemResourcePriorityGetResponse;
        }

        /// <summary>
        /// Get the system Resource Priority service attributes.
        /// The response is either SystemResourcePriorityGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemResourcePriorityGetResponse> SystemResourcePriorityGetRequestAsync(this OcipClient client, SystemResourcePriorityGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemResourcePriorityGetResponse;
        }
        /// <summary>
        /// Modify the system Resource Priority service attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemResourcePriorityModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemResourcePriorityModifyRequest(this OcipClient client, SystemResourcePriorityModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system Resource Priority service attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemResourcePriorityModifyRequestAsync(this OcipClient client, SystemResourcePriorityModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the Resource Priority settings of a user.
        /// The response is either UserResourcePriorityGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserResourcePriorityGetRequestAsync instead.")]
        public static async Task<UserResourcePriorityGetResponse> UserResourcePriorityGetRequest(this OcipClient client, UserResourcePriorityGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserResourcePriorityGetResponse;
        }

        /// <summary>
        /// Get the Resource Priority settings of a user.
        /// The response is either UserResourcePriorityGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserResourcePriorityGetResponse> UserResourcePriorityGetRequestAsync(this OcipClient client, UserResourcePriorityGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserResourcePriorityGetResponse;
        }
        /// <summary>
        /// Modify the Resource Priority settings of a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserResourcePriorityModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserResourcePriorityModifyRequest(this OcipClient client, UserResourcePriorityModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Resource Priority settings of a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserResourcePriorityModifyRequestAsync(this OcipClient client, UserResourcePriorityModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
