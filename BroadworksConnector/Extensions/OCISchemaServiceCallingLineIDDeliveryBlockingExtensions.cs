using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallingLineIDDeliveryBlockingExtensions
    {

        /// <summary>
        /// Request the user level data associated with Calling Line ID Delivery Blocking.
        /// The response is either a UserCallingLineIDDeliveryBlockingGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallingLineIDDeliveryBlockingGetRequestAsync instead.")]
        public static async Task<UserCallingLineIDDeliveryBlockingGetResponse> UserCallingLineIDDeliveryBlockingGetRequest(this OcipClient client, UserCallingLineIDDeliveryBlockingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallingLineIDDeliveryBlockingGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Calling Line ID Delivery Blocking.
        /// The response is either a UserCallingLineIDDeliveryBlockingGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallingLineIDDeliveryBlockingGetResponse> UserCallingLineIDDeliveryBlockingGetRequestAsync(this OcipClient client, UserCallingLineIDDeliveryBlockingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallingLineIDDeliveryBlockingGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Calling Line ID Delivery Blocking.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallingLineIDDeliveryBlockingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallingLineIDDeliveryBlockingModifyRequest(this OcipClient client, UserCallingLineIDDeliveryBlockingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Calling Line ID Delivery Blocking.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallingLineIDDeliveryBlockingModifyRequestAsync(this OcipClient client, UserCallingLineIDDeliveryBlockingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
