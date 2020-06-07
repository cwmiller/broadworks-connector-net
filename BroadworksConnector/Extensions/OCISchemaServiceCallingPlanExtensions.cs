using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCallingPlanExtensions
    {

        /// <summary>
        /// Add a new calling plan digit string.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallingPlanAddDigitPatternRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallingPlanAddDigitPatternRequest(this OcipClient client, GroupCallingPlanAddDigitPatternRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new calling plan digit string.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallingPlanAddDigitPatternRequestAsync(this OcipClient client, GroupCallingPlanAddDigitPatternRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete one or more calling plan digit strings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallingPlanDeleteDigitPatternListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallingPlanDeleteDigitPatternListRequest(this OcipClient client, GroupCallingPlanDeleteDigitPatternListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete one or more calling plan digit strings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallingPlanDeleteDigitPatternListRequestAsync(this OcipClient client, GroupCallingPlanDeleteDigitPatternListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of calling plan digit strings for a group.
        /// The response is either a GroupCallingPlanGetDigitPatternListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallingPlanGetDigitPatternListRequestAsync instead.")]
        public static async Task<GroupCallingPlanGetDigitPatternListResponse> GroupCallingPlanGetDigitPatternListRequest(this OcipClient client, GroupCallingPlanGetDigitPatternListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallingPlanGetDigitPatternListResponse;
        }

        /// <summary>
        /// Get the list of calling plan digit strings for a group.
        /// The response is either a GroupCallingPlanGetDigitPatternListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallingPlanGetDigitPatternListResponse> GroupCallingPlanGetDigitPatternListRequestAsync(this OcipClient client, GroupCallingPlanGetDigitPatternListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallingPlanGetDigitPatternListResponse;
        }
        /// <summary>
        /// Modify a calling plan digit string. The name is a key; it cannot be changed.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallingPlanModifyDigitPatternRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCallingPlanModifyDigitPatternRequest(this OcipClient client, GroupCallingPlanModifyDigitPatternRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a calling plan digit string. The name is a key; it cannot be changed.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallingPlanModifyDigitPatternRequestAsync(this OcipClient client, GroupCallingPlanModifyDigitPatternRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
