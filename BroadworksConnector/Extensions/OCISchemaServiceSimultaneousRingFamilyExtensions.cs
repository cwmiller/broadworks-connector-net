using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceSimultaneousRingFamilyExtensions
    {

        /// <summary>
        /// Add a criteria to the user's simultaneous ring family service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSimultaneousRingFamilyAddCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserSimultaneousRingFamilyAddCriteriaRequest(this OcipClient client, UserSimultaneousRingFamilyAddCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a criteria to the user's simultaneous ring family service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSimultaneousRingFamilyAddCriteriaRequestAsync(this OcipClient client, UserSimultaneousRingFamilyAddCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a criteria from the user's simultaneous ring family service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSimultaneousRingFamilyDeleteCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserSimultaneousRingFamilyDeleteCriteriaRequest(this OcipClient client, UserSimultaneousRingFamilyDeleteCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a criteria from the user's simultaneous ring family service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSimultaneousRingFamilyDeleteCriteriaRequestAsync(this OcipClient client, UserSimultaneousRingFamilyDeleteCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a criteria for the user's simultaneous ring family service.
        /// The response is either a UserSimultaneousRingFamilyGetCriteriaResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSimultaneousRingFamilyGetCriteriaRequestAsync instead.")]
        public static async Task<UserSimultaneousRingFamilyGetCriteriaResponse> UserSimultaneousRingFamilyGetCriteriaRequest(this OcipClient client, UserSimultaneousRingFamilyGetCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserSimultaneousRingFamilyGetCriteriaResponse;
        }

        /// <summary>
        /// Get a criteria for the user's simultaneous ring family service.
        /// The response is either a UserSimultaneousRingFamilyGetCriteriaResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserSimultaneousRingFamilyGetCriteriaResponse> UserSimultaneousRingFamilyGetCriteriaRequestAsync(this OcipClient client, UserSimultaneousRingFamilyGetCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserSimultaneousRingFamilyGetCriteriaResponse;
        }
        /// <summary>
        /// Get the user's simultaneous ring family service setting.
        /// The response is either a UserSimultaneousRingFamilyGetResponse17 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSimultaneousRingFamilyGetRequest17Async instead.")]
        public static async Task<UserSimultaneousRingFamilyGetResponse17> UserSimultaneousRingFamilyGetRequest17(this OcipClient client, UserSimultaneousRingFamilyGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserSimultaneousRingFamilyGetResponse17;
        }

        /// <summary>
        /// Get the user's simultaneous ring family service setting.
        /// The response is either a UserSimultaneousRingFamilyGetResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<UserSimultaneousRingFamilyGetResponse17> UserSimultaneousRingFamilyGetRequest17Async(this OcipClient client, UserSimultaneousRingFamilyGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserSimultaneousRingFamilyGetResponse17;
        }
        /// <summary>
        /// Modify a criteria for the user's simultaneous ring family service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSimultaneousRingFamilyModifyCriteriaRequestAsync instead.")]
        public static async Task<SuccessResponse> UserSimultaneousRingFamilyModifyCriteriaRequest(this OcipClient client, UserSimultaneousRingFamilyModifyCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a criteria for the user's simultaneous ring family service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSimultaneousRingFamilyModifyCriteriaRequestAsync(this OcipClient client, UserSimultaneousRingFamilyModifyCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the user's simultaneous ring family service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSimultaneousRingFamilyModifyRequest17Async instead.")]
        public static async Task<SuccessResponse> UserSimultaneousRingFamilyModifyRequest17(this OcipClient client, UserSimultaneousRingFamilyModifyRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's simultaneous ring family service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSimultaneousRingFamilyModifyRequest17Async(this OcipClient client, UserSimultaneousRingFamilyModifyRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
