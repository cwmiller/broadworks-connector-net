using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallingNumberDeliveryExtensions
    {

        /// <summary>
        /// Request the user level data associated with Calling
        /// Name Delivery. The response is either a UserCallingNumberDeliveryGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallingNumberDeliveryGetRequestAsync instead.")]
        public static async Task<UserCallingNumberDeliveryGetResponse> UserCallingNumberDeliveryGetRequest(this OcipClient client, UserCallingNumberDeliveryGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallingNumberDeliveryGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Calling
        /// Name Delivery. The response is either a UserCallingNumberDeliveryGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallingNumberDeliveryGetResponse> UserCallingNumberDeliveryGetRequestAsync(this OcipClient client, UserCallingNumberDeliveryGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallingNumberDeliveryGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Calling Number Delivery.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallingNumberDeliveryModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallingNumberDeliveryModifyRequest(this OcipClient client, UserCallingNumberDeliveryModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Calling Number Delivery.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallingNumberDeliveryModifyRequestAsync(this OcipClient client, UserCallingNumberDeliveryModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
