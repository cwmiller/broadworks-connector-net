using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceInternalCallingLineIDDeliveryExtensions
    {

        /// <summary>
        /// Request the user level data associated with Internal Calling Line ID Delivery.
        /// The response is either a UserInternalCallingLineIDDeliveryGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserInternalCallingLineIDDeliveryGetRequestAsync instead.")]
        public static async Task<UserInternalCallingLineIDDeliveryGetResponse> UserInternalCallingLineIDDeliveryGetRequest(this OcipClient client, UserInternalCallingLineIDDeliveryGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserInternalCallingLineIDDeliveryGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Internal Calling Line ID Delivery.
        /// The response is either a UserInternalCallingLineIDDeliveryGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserInternalCallingLineIDDeliveryGetResponse> UserInternalCallingLineIDDeliveryGetRequestAsync(this OcipClient client, UserInternalCallingLineIDDeliveryGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserInternalCallingLineIDDeliveryGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Internal Calling Line ID Delivery.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserInternalCallingLineIDDeliveryModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserInternalCallingLineIDDeliveryModifyRequest(this OcipClient client, UserInternalCallingLineIDDeliveryModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Internal Calling Line ID Delivery.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserInternalCallingLineIDDeliveryModifyRequestAsync(this OcipClient client, UserInternalCallingLineIDDeliveryModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
