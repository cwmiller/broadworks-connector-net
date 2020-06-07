using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceTwoStageDialingExtensions
    {

        /// <summary>
        /// Request to add Two Stage Dialing number to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTwoStageDialingAddDnRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTwoStageDialingAddDnRequest(this OcipClient client, SystemTwoStageDialingAddDnRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add Two Stage Dialing number to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTwoStageDialingAddDnRequestAsync(this OcipClient client, SystemTwoStageDialingAddDnRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to delete a Two Stage Dialing number from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTwoStageDialingDeleteDnRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTwoStageDialingDeleteDnRequest(this OcipClient client, SystemTwoStageDialingDeleteDnRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a Two Stage Dialing number from the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTwoStageDialingDeleteDnRequestAsync(this OcipClient client, SystemTwoStageDialingDeleteDnRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a list of Two Stage Dialing dns defined in the system.
        /// The response is either a SystemTwoStageDialingGetDnListResponse
        /// or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTwoStageDialingGetDnListRequestAsync instead.")]
        public static async Task<SystemTwoStageDialingGetDnListResponse> SystemTwoStageDialingGetDnListRequest(this OcipClient client, SystemTwoStageDialingGetDnListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTwoStageDialingGetDnListResponse;
        }

        /// <summary>
        /// Request to get a list of Two Stage Dialing dns defined in the system.
        /// The response is either a SystemTwoStageDialingGetDnListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemTwoStageDialingGetDnListResponse> SystemTwoStageDialingGetDnListRequestAsync(this OcipClient client, SystemTwoStageDialingGetDnListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTwoStageDialingGetDnListResponse;
        }
        /// <summary>
        /// Request to modify a Two Stage Dialing number's description in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTwoStageDialingModifyDnRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTwoStageDialingModifyDnRequest(this OcipClient client, SystemTwoStageDialingModifyDnRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Two Stage Dialing number's description in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTwoStageDialingModifyDnRequestAsync(this OcipClient client, SystemTwoStageDialingModifyDnRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with Two Stage Dialing.
        /// The response is either a UserTwoStageDialingGetResponse13Mp20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserTwoStageDialingGetRequest13Mp20Async instead.")]
        public static async Task<UserTwoStageDialingGetResponse13Mp20> UserTwoStageDialingGetRequest13Mp20(this OcipClient client, UserTwoStageDialingGetRequest13Mp20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserTwoStageDialingGetResponse13Mp20;
        }

        /// <summary>
        /// Request the user level data associated with Two Stage Dialing.
        /// The response is either a UserTwoStageDialingGetResponse13Mp20 or an ErrorResponse.
        /// </summary>
        public static async Task<UserTwoStageDialingGetResponse13Mp20> UserTwoStageDialingGetRequest13Mp20Async(this OcipClient client, UserTwoStageDialingGetRequest13Mp20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserTwoStageDialingGetResponse13Mp20;
        }
        /// <summary>
        /// Modify the user level data associated with Two Stage Dialing.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserTwoStageDialingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserTwoStageDialingModifyRequest(this OcipClient client, UserTwoStageDialingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Two Stage Dialing.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserTwoStageDialingModifyRequestAsync(this OcipClient client, UserTwoStageDialingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
