using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceClassMarkExtensions
    {

        /// <summary>
        /// Add a Class Mark to system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemClassmarkAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemClassmarkAddRequest(this OcipClient client, SystemClassmarkAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Class Mark to system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemClassmarkAddRequestAsync(this OcipClient client, SystemClassmarkAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Class Mark from system. It cannot be deleted if it is in use by any users.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemClassmarkDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemClassmarkDeleteRequest(this OcipClient client, SystemClassmarkDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Class Mark from system. It cannot be deleted if it is in use by any users.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemClassmarkDeleteRequestAsync(this OcipClient client, SystemClassmarkDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of all Class Mark in system.
        /// The response is either a SystemClassmarkGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemClassmarkGetListRequestAsync instead.")]
        public static async Task<SystemClassmarkGetListResponse> SystemClassmarkGetListRequest(this OcipClient client, SystemClassmarkGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemClassmarkGetListResponse;
        }

        /// <summary>
        /// Get the list of all Class Mark in system.
        /// The response is either a SystemClassmarkGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemClassmarkGetListResponse> SystemClassmarkGetListRequestAsync(this OcipClient client, SystemClassmarkGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemClassmarkGetListResponse;
        }
        /// <summary>
        /// Get the list of all users associated with a Class Mark in system. It is possible to search by various criteria.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a SystemClassmarkGetUtilizationListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemClassmarkGetUtilizationListRequestAsync instead.")]
        public static async Task<SystemClassmarkGetUtilizationListResponse> SystemClassmarkGetUtilizationListRequest(this OcipClient client, SystemClassmarkGetUtilizationListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemClassmarkGetUtilizationListResponse;
        }

        /// <summary>
        /// Get the list of all users associated with a Class Mark in system. It is possible to search by various criteria.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a SystemClassmarkGetUtilizationListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemClassmarkGetUtilizationListResponse> SystemClassmarkGetUtilizationListRequestAsync(this OcipClient client, SystemClassmarkGetUtilizationListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemClassmarkGetUtilizationListResponse;
        }
        /// <summary>
        /// Modify a Class Mark in system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemClassmarkModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemClassmarkModifyRequest(this OcipClient client, SystemClassmarkModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Class Mark in system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemClassmarkModifyRequestAsync(this OcipClient client, SystemClassmarkModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the Class Mark data associated with User.
        /// The response is either a UserClassmarkGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserClassmarkGetRequestAsync instead.")]
        public static async Task<UserClassmarkGetResponse> UserClassmarkGetRequest(this OcipClient client, UserClassmarkGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserClassmarkGetResponse;
        }

        /// <summary>
        /// Request the Class Mark data associated with User.
        /// The response is either a UserClassmarkGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserClassmarkGetResponse> UserClassmarkGetRequestAsync(this OcipClient client, UserClassmarkGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserClassmarkGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Class Mark.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserClassmarkModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserClassmarkModifyRequest(this OcipClient client, UserClassmarkModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Class Mark.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserClassmarkModifyRequestAsync(this OcipClient client, UserClassmarkModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
