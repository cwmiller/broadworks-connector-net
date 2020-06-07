using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceExternalCallingLineIDDeliveryExtensions
    {

        /// <summary>
        /// Request the user level data associated with External Calling Line ID Delivery.
        /// The response is either a UserExternalCallingLineIDDeliveryGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserExternalCallingLineIDDeliveryGetRequestAsync instead.")]
        public static async Task<UserExternalCallingLineIDDeliveryGetResponse> UserExternalCallingLineIDDeliveryGetRequest(this OcipClient client, UserExternalCallingLineIDDeliveryGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserExternalCallingLineIDDeliveryGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with External Calling Line ID Delivery.
        /// The response is either a UserExternalCallingLineIDDeliveryGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserExternalCallingLineIDDeliveryGetResponse> UserExternalCallingLineIDDeliveryGetRequestAsync(this OcipClient client, UserExternalCallingLineIDDeliveryGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserExternalCallingLineIDDeliveryGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with External Calling Line ID Delivery.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserExternalCallingLineIDDeliveryModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserExternalCallingLineIDDeliveryModifyRequest(this OcipClient client, UserExternalCallingLineIDDeliveryModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with External Calling Line ID Delivery.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserExternalCallingLineIDDeliveryModifyRequestAsync(this OcipClient client, UserExternalCallingLineIDDeliveryModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
