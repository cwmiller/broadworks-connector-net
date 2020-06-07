using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServicePolycomPhoneServicesExtensions
    {

        /// <summary>
        /// Request the group's Polycom Phone Services attributes.
        /// The response is either a GroupPolycomPhoneServicesGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPolycomPhoneServicesGetRequestAsync instead.")]
        public static async Task<GroupPolycomPhoneServicesGetResponse> GroupPolycomPhoneServicesGetRequest(this OcipClient client, GroupPolycomPhoneServicesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupPolycomPhoneServicesGetResponse;
        }

        /// <summary>
        /// Request the group's Polycom Phone Services attributes.
        /// The response is either a GroupPolycomPhoneServicesGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupPolycomPhoneServicesGetResponse> GroupPolycomPhoneServicesGetRequestAsync(this OcipClient client, GroupPolycomPhoneServicesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupPolycomPhoneServicesGetResponse;
        }
        /// <summary>
        /// Modify the group's Polycom Phone Services attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPolycomPhoneServicesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupPolycomPhoneServicesModifyRequest(this OcipClient client, GroupPolycomPhoneServicesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group's Polycom Phone Services attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupPolycomPhoneServicesModifyRequestAsync(this OcipClient client, GroupPolycomPhoneServicesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user's list of device profiles on which the user is the primary user.
        /// The response is either a UserPolycomPhoneServicesGetPrimaryEndpointListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPolycomPhoneServicesGetPrimaryEndpointListRequestAsync instead.")]
        public static async Task<UserPolycomPhoneServicesGetPrimaryEndpointListResponse> UserPolycomPhoneServicesGetPrimaryEndpointListRequest(this OcipClient client, UserPolycomPhoneServicesGetPrimaryEndpointListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPolycomPhoneServicesGetPrimaryEndpointListResponse;
        }

        /// <summary>
        /// Request the user's list of device profiles on which the user is the primary user.
        /// The response is either a UserPolycomPhoneServicesGetPrimaryEndpointListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserPolycomPhoneServicesGetPrimaryEndpointListResponse> UserPolycomPhoneServicesGetPrimaryEndpointListRequestAsync(this OcipClient client, UserPolycomPhoneServicesGetPrimaryEndpointListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPolycomPhoneServicesGetPrimaryEndpointListResponse;
        }
        /// <summary>
        /// Request the user's Polycom Phone Services attributes.
        /// The response is either a UserPolycomPhoneServicesGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPolycomPhoneServicesGetRequestAsync instead.")]
        public static async Task<UserPolycomPhoneServicesGetResponse> UserPolycomPhoneServicesGetRequest(this OcipClient client, UserPolycomPhoneServicesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPolycomPhoneServicesGetResponse;
        }

        /// <summary>
        /// Request the user's Polycom Phone Services attributes.
        /// The response is either a UserPolycomPhoneServicesGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserPolycomPhoneServicesGetResponse> UserPolycomPhoneServicesGetRequestAsync(this OcipClient client, UserPolycomPhoneServicesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPolycomPhoneServicesGetResponse;
        }
        /// <summary>
        /// Modify the user's Polycom Phone Services attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPolycomPhoneServicesModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPolycomPhoneServicesModifyRequest(this OcipClient client, UserPolycomPhoneServicesModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's Polycom Phone Services attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPolycomPhoneServicesModifyRequestAsync(this OcipClient client, UserPolycomPhoneServicesModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
