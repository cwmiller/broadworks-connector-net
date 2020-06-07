using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServicePhysicalLocationExtensions
    {

        /// <summary>
        /// Request to get the list of Physical Location system parameters.
        /// The response is either SystemPhysicalLocationGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPhysicalLocationGetRequestAsync instead.")]
        public static async Task<SystemPhysicalLocationGetResponse> SystemPhysicalLocationGetRequest(this OcipClient client, SystemPhysicalLocationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPhysicalLocationGetResponse;
        }

        /// <summary>
        /// Request to get the list of Physical Location system parameters.
        /// The response is either SystemPhysicalLocationGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemPhysicalLocationGetResponse> SystemPhysicalLocationGetRequestAsync(this OcipClient client, SystemPhysicalLocationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPhysicalLocationGetResponse;
        }
        /// <summary>
        /// Request to modify Physical Location system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPhysicalLocationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemPhysicalLocationModifyRequest(this OcipClient client, SystemPhysicalLocationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify Physical Location system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemPhysicalLocationModifyRequestAsync(this OcipClient client, SystemPhysicalLocationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with Physical Location.
        /// The response is either a UserPhysicalLocationGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPhysicalLocationGetRequestAsync instead.")]
        public static async Task<UserPhysicalLocationGetResponse> UserPhysicalLocationGetRequest(this OcipClient client, UserPhysicalLocationGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPhysicalLocationGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Physical Location.
        /// The response is either a UserPhysicalLocationGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserPhysicalLocationGetResponse> UserPhysicalLocationGetRequestAsync(this OcipClient client, UserPhysicalLocationGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPhysicalLocationGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Physical Location.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPhysicalLocationModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPhysicalLocationModifyRequest(this OcipClient client, UserPhysicalLocationModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Physical Location.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPhysicalLocationModifyRequestAsync(this OcipClient client, UserPhysicalLocationModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
