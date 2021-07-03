using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceLegacyAutomaticCallbackExtensions
    {

        /// <summary>
        /// Request the system's legacy automatic callback line type settings.
        /// The response is either a SystemLegacyAutomaticCallbackGetLineTypeListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLegacyAutomaticCallbackGetLineTypeListRequestAsync instead.")]
        public static async Task<SystemLegacyAutomaticCallbackGetLineTypeListResponse> SystemLegacyAutomaticCallbackGetLineTypeListRequest(this OcipClient client, SystemLegacyAutomaticCallbackGetLineTypeListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemLegacyAutomaticCallbackGetLineTypeListResponse;
        }

        /// <summary>
        /// Request the system's legacy automatic callback line type settings.
        /// The response is either a SystemLegacyAutomaticCallbackGetLineTypeListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemLegacyAutomaticCallbackGetLineTypeListResponse> SystemLegacyAutomaticCallbackGetLineTypeListRequestAsync(this OcipClient client, SystemLegacyAutomaticCallbackGetLineTypeListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemLegacyAutomaticCallbackGetLineTypeListResponse;
        }
        /// <summary>
        /// Request the system's legacy automatic callback attributes.
        /// The response is either a SystemLegacyAutomaticCallbackGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLegacyAutomaticCallbackGetRequestAsync instead.")]
        public static async Task<SystemLegacyAutomaticCallbackGetResponse> SystemLegacyAutomaticCallbackGetRequest(this OcipClient client, SystemLegacyAutomaticCallbackGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemLegacyAutomaticCallbackGetResponse;
        }

        /// <summary>
        /// Request the system's legacy automatic callback attributes.
        /// The response is either a SystemLegacyAutomaticCallbackGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemLegacyAutomaticCallbackGetResponse> SystemLegacyAutomaticCallbackGetRequestAsync(this OcipClient client, SystemLegacyAutomaticCallbackGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemLegacyAutomaticCallbackGetResponse;
        }
        /// <summary>
        /// Modifies the system's legacy automatic callback line type attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLegacyAutomaticCallbackModifyLineTypeRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemLegacyAutomaticCallbackModifyLineTypeRequest(this OcipClient client, SystemLegacyAutomaticCallbackModifyLineTypeRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the system's legacy automatic callback line type attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemLegacyAutomaticCallbackModifyLineTypeRequestAsync(this OcipClient client, SystemLegacyAutomaticCallbackModifyLineTypeRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modifies the system's legacy automatic callback attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLegacyAutomaticCallbackModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemLegacyAutomaticCallbackModifyRequest(this OcipClient client, SystemLegacyAutomaticCallbackModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the system's legacy automatic callback attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemLegacyAutomaticCallbackModifyRequestAsync(this OcipClient client, SystemLegacyAutomaticCallbackModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with Legacy Automatic Callback.
        /// The response is either a UserLegacyAutomaticCallbackGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserLegacyAutomaticCallbackGetRequestAsync instead.")]
        public static async Task<UserLegacyAutomaticCallbackGetResponse> UserLegacyAutomaticCallbackGetRequest(this OcipClient client, UserLegacyAutomaticCallbackGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserLegacyAutomaticCallbackGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Legacy Automatic Callback.
        /// The response is either a UserLegacyAutomaticCallbackGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserLegacyAutomaticCallbackGetResponse> UserLegacyAutomaticCallbackGetRequestAsync(this OcipClient client, UserLegacyAutomaticCallbackGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserLegacyAutomaticCallbackGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Legacy Automatic Callback.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserLegacyAutomaticCallbackModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserLegacyAutomaticCallbackModifyRequest(this OcipClient client, UserLegacyAutomaticCallbackModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Legacy Automatic Callback.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserLegacyAutomaticCallbackModifyRequestAsync(this OcipClient client, UserLegacyAutomaticCallbackModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
