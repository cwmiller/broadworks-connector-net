using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceAutomaticCollectCallExtensions
    {

        /// <summary>
        /// Get system Automatic Collect Call service settings.
        /// The response is either SystemAutomaticCollectCallGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAutomaticCollectCallGetRequestAsync instead.")]
        public static async Task<SystemAutomaticCollectCallGetResponse> SystemAutomaticCollectCallGetRequest(this OcipClient client, SystemAutomaticCollectCallGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAutomaticCollectCallGetResponse;
        }

        /// <summary>
        /// Get system Automatic Collect Call service settings.
        /// The response is either SystemAutomaticCollectCallGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemAutomaticCollectCallGetResponse> SystemAutomaticCollectCallGetRequestAsync(this OcipClient client, SystemAutomaticCollectCallGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAutomaticCollectCallGetResponse;
        }
        /// <summary>
        /// Modify system Automatic Collect Call service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAutomaticCollectCallModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAutomaticCollectCallModifyRequest(this OcipClient client, SystemAutomaticCollectCallModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify system Automatic Collect Call service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAutomaticCollectCallModifyRequestAsync(this OcipClient client, SystemAutomaticCollectCallModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a system automatic collect call prefix digits entry.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAutomaticCollectCallPrefixDigitsAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAutomaticCollectCallPrefixDigitsAddListRequest(this OcipClient client, SystemAutomaticCollectCallPrefixDigitsAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a system automatic collect call prefix digits entry.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAutomaticCollectCallPrefixDigitsAddListRequestAsync(this OcipClient client, SystemAutomaticCollectCallPrefixDigitsAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete an entry in system automatic collect call prefix table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAutomaticCollectCallPrefixDigitsDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAutomaticCollectCallPrefixDigitsDeleteListRequest(this OcipClient client, SystemAutomaticCollectCallPrefixDigitsDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete an entry in system automatic collect call prefix table.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemAutomaticCollectCallPrefixDigitsDeleteListRequestAsync(this OcipClient client, SystemAutomaticCollectCallPrefixDigitsDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the system automatic collect call prefix digits lists.
        /// The response is either SystemAutomaticCollectCallPrefixDigitsGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAutomaticCollectCallPrefixDigitsGetListRequestAsync instead.")]
        public static async Task<SystemAutomaticCollectCallPrefixDigitsGetListResponse> SystemAutomaticCollectCallPrefixDigitsGetListRequest(this OcipClient client, SystemAutomaticCollectCallPrefixDigitsGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAutomaticCollectCallPrefixDigitsGetListResponse;
        }

        /// <summary>
        /// Get the system automatic collect call prefix digits lists.
        /// The response is either SystemAutomaticCollectCallPrefixDigitsGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemAutomaticCollectCallPrefixDigitsGetListResponse> SystemAutomaticCollectCallPrefixDigitsGetListRequestAsync(this OcipClient client, SystemAutomaticCollectCallPrefixDigitsGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAutomaticCollectCallPrefixDigitsGetListResponse;
        }
        /// <summary>
        /// Get user Automatic Collect Call service settings.
        /// The response is either UserAutomaticCollectCallGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAutomaticCollectCallGetRequestAsync instead.")]
        public static async Task<UserAutomaticCollectCallGetResponse> UserAutomaticCollectCallGetRequest(this OcipClient client, UserAutomaticCollectCallGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserAutomaticCollectCallGetResponse;
        }

        /// <summary>
        /// Get user Automatic Collect Call service settings.
        /// The response is either UserAutomaticCollectCallGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserAutomaticCollectCallGetResponse> UserAutomaticCollectCallGetRequestAsync(this OcipClient client, UserAutomaticCollectCallGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserAutomaticCollectCallGetResponse;
        }
        /// <summary>
        /// Modify user Automatic Collect Call service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAutomaticCollectCallModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserAutomaticCollectCallModifyRequest(this OcipClient client, UserAutomaticCollectCallModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify user Automatic Collect Call service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserAutomaticCollectCallModifyRequestAsync(this OcipClient client, UserAutomaticCollectCallModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
