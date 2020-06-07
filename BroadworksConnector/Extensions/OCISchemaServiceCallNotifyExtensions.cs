using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallNotifyExtensions
    {

        /// <summary>
        /// Request the reseller level data associated with Call Notify.
        /// The response is either a ResellerCallNotifyGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerCallNotifyGetRequestAsync instead.")]
        public static async Task<ResellerCallNotifyGetResponse> ResellerCallNotifyGetRequest(this OcipClient client, ResellerCallNotifyGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerCallNotifyGetResponse;
        }

        /// <summary>
        /// Request the reseller level data associated with Call Notify.
        /// The response is either a ResellerCallNotifyGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<ResellerCallNotifyGetResponse> ResellerCallNotifyGetRequestAsync(this OcipClient client, ResellerCallNotifyGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerCallNotifyGetResponse;
        }
        /// <summary>
        /// Modify the reseller level data associated with Call Notify.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerCallNotifyModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ResellerCallNotifyModifyRequest(this OcipClient client, ResellerCallNotifyModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the reseller level data associated with Call Notify.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerCallNotifyModifyRequestAsync(this OcipClient client, ResellerCallNotifyModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with Call Notify.
        /// The response is either a SystemCallNotifyGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallNotifyGetRequestAsync instead.")]
        public static async Task<SystemCallNotifyGetResponse> SystemCallNotifyGetRequest(this OcipClient client, SystemCallNotifyGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallNotifyGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Call Notify.
        /// The response is either a SystemCallNotifyGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallNotifyGetResponse> SystemCallNotifyGetRequestAsync(this OcipClient client, SystemCallNotifyGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallNotifyGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Call Notify.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallNotifyModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCallNotifyModifyRequest(this OcipClient client, SystemCallNotifyModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Call Notify.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallNotifyModifyRequestAsync(this OcipClient client, SystemCallNotifyModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a criteria to the user's call notify service.
        /// The following elements are only used in AS data mode:
        /// callToNumber
        /// 
        /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallNotifyAddCriteriaRequest16Async instead.")]
        public static async Task<SuccessResponse> UserCallNotifyAddCriteriaRequest16(this OcipClient client, UserCallNotifyAddCriteriaRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a criteria to the user's call notify service.
        /// The following elements are only used in AS data mode:
        /// callToNumber
        /// 
        /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallNotifyAddCriteriaRequest16Async(this OcipClient client, UserCallNotifyAddCriteriaRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a criteria from the user's call notify service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallNotifyDeleteCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallNotifyDeleteCriteriaRequest(this OcipClient client, UserCallNotifyDeleteCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a criteria from the user's call notify service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallNotifyDeleteCriteriaRequestAsync(this OcipClient client, UserCallNotifyDeleteCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a criteria for the user's call notify service.
        /// The response is either a UserCallNotifyGetCriteriaResponse21 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallNotifyGetCriteriaRequest21Async instead.")]
        public static async Task<UserCallNotifyGetCriteriaResponse21> UserCallNotifyGetCriteriaRequest21(this OcipClient client, UserCallNotifyGetCriteriaRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallNotifyGetCriteriaResponse21;
        }

        /// <summary>
        /// Get a criteria for the user's call notify service.
        /// The response is either a UserCallNotifyGetCriteriaResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallNotifyGetCriteriaResponse21> UserCallNotifyGetCriteriaRequest21Async(this OcipClient client, UserCallNotifyGetCriteriaRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallNotifyGetCriteriaResponse21;
        }
        /// <summary>
        /// Get the user's call notify service setting.
        /// The response is either a UserCallNotifyGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallNotifyGetRequestAsync instead.")]
        public static async Task<UserCallNotifyGetResponse> UserCallNotifyGetRequest(this OcipClient client, UserCallNotifyGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallNotifyGetResponse;
        }

        /// <summary>
        /// Get the user's call notify service setting.
        /// The response is either a UserCallNotifyGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallNotifyGetResponse> UserCallNotifyGetRequestAsync(this OcipClient client, UserCallNotifyGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallNotifyGetResponse;
        }
        /// <summary>
        /// Modify a criteria for the user's call notify service.
        /// The following elements are only used in AS data mode:
        /// callToNumber
        /// 
        /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallNotifyModifyCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallNotifyModifyCriteriaRequest(this OcipClient client, UserCallNotifyModifyCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a criteria for the user's call notify service.
        /// The following elements are only used in AS data mode:
        /// callToNumber
        /// 
        /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallNotifyModifyCriteriaRequestAsync(this OcipClient client, UserCallNotifyModifyCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the user's call notify service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallNotifyModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCallNotifyModifyRequest(this OcipClient client, UserCallNotifyModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's call notify service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallNotifyModifyRequestAsync(this OcipClient client, UserCallNotifyModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
