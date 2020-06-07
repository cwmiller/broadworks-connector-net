using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallingNameDeliveryExtensions
    {

        /// <summary>
        /// Request the user level data associated with Calling
        /// Name Delivery. The response is either a UserCallingNameDeliveryGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallingNameDeliveryGetRequestAsync instead.")]
        public static async Task<UserCallingNameDeliveryGetResponse> UserCallingNameDeliveryGetRequest(this OcipClient client, UserCallingNameDeliveryGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallingNameDeliveryGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Calling
        /// Name Delivery. The response is either a UserCallingNameDeliveryGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallingNameDeliveryGetResponse> UserCallingNameDeliveryGetRequestAsync(this OcipClient client, UserCallingNameDeliveryGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallingNameDeliveryGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Calling Name Delivery.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallingNameDeliveryModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallingNameDeliveryModifyRequest(this OcipClient client, UserCallingNameDeliveryModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Calling Name Delivery.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallingNameDeliveryModifyRequestAsync(this OcipClient client, UserCallingNameDeliveryModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
