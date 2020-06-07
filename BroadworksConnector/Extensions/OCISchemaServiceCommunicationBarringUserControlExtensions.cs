using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceCommunicationBarringUserControlExtensions
    {

        /// <summary>
        /// Gets the Communication Barring system level settings.
        /// The response is either SystemCommunicationBarringUserControlGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringUserControlGetRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringUserControlGetResponse> SystemCommunicationBarringUserControlGetRequest(this OcipClient client, SystemCommunicationBarringUserControlGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringUserControlGetResponse;
        }

        /// <summary>
        /// Gets the Communication Barring system level settings.
        /// The response is either SystemCommunicationBarringUserControlGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringUserControlGetResponse> SystemCommunicationBarringUserControlGetRequestAsync(this OcipClient client, SystemCommunicationBarringUserControlGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringUserControlGetResponse;
        }
        /// <summary>
        /// Modifies the system's Communication Barring User-Control settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringUserControlModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringUserControlModifyRequest(this OcipClient client, SystemCommunicationBarringUserControlModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the system's Communication Barring User-Control settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringUserControlModifyRequestAsync(this OcipClient client, SystemCommunicationBarringUserControlModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Lists the Communication Barring profiles available to a user and
        /// indicates which profile if any is currently active for the user..
        /// The response is either UserCommunicationBarringUserControlGetResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCommunicationBarringUserControlGetRequestAsync instead.")]
        public static async Task<UserCommunicationBarringUserControlGetResponse> UserCommunicationBarringUserControlGetRequest(this OcipClient client, UserCommunicationBarringUserControlGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCommunicationBarringUserControlGetResponse;
        }

        /// <summary>
        /// Lists the Communication Barring profiles available to a user and
        /// indicates which profile if any is currently active for the user..
        /// The response is either UserCommunicationBarringUserControlGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserCommunicationBarringUserControlGetResponse> UserCommunicationBarringUserControlGetRequestAsync(this OcipClient client, UserCommunicationBarringUserControlGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCommunicationBarringUserControlGetResponse;
        }
        /// <summary>
        /// Enabling a profile automatically disables the currently active profile.
        /// Also allows the passcode for the service to be modified and the lockout to be reset.
        /// Admins only need to populate the newPasscode field when changing the passcode.
        /// Users must populate both the oldPasscode and new Passcode fields when changing the passcode.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCommunicationBarringUserControlModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserCommunicationBarringUserControlModifyRequest(this OcipClient client, UserCommunicationBarringUserControlModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Enabling a profile automatically disables the currently active profile.
        /// Also allows the passcode for the service to be modified and the lockout to be reset.
        /// Admins only need to populate the newPasscode field when changing the passcode.
        /// Users must populate both the oldPasscode and new Passcode fields when changing the passcode.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCommunicationBarringUserControlModifyRequestAsync(this OcipClient client, UserCommunicationBarringUserControlModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
