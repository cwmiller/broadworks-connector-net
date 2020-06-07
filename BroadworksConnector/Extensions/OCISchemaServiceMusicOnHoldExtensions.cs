using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceMusicOnHoldExtensions
    {

        /// <summary>
        /// Add a Music on Hold Instance to a department.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldAddInstanceRequest22Async instead.")]
        public static async Task<SuccessResponse> GroupMusicOnHoldAddInstanceRequest22(this OcipClient client, GroupMusicOnHoldAddInstanceRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Music on Hold Instance to a department.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupMusicOnHoldAddInstanceRequest22Async(this OcipClient client, GroupMusicOnHoldAddInstanceRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Music On Hold department instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldDeleteInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupMusicOnHoldDeleteInstanceRequest(this OcipClient client, GroupMusicOnHoldDeleteInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Music On Hold department instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupMusicOnHoldDeleteInstanceRequestAsync(this OcipClient client, GroupMusicOnHoldDeleteInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Returns a list of all departments that have a Music On Hold instance.
        /// The response is either GroupMusicOnHoldGetDepartmentListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldGetDepartmentListRequestAsync instead.")]
        public static async Task<GroupMusicOnHoldGetDepartmentListResponse> GroupMusicOnHoldGetDepartmentListRequest(this OcipClient client, GroupMusicOnHoldGetDepartmentListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupMusicOnHoldGetDepartmentListResponse;
        }

        /// <summary>
        /// Returns a list of all departments that have a Music On Hold instance.
        /// The response is either GroupMusicOnHoldGetDepartmentListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        public static async Task<GroupMusicOnHoldGetDepartmentListResponse> GroupMusicOnHoldGetDepartmentListRequestAsync(this OcipClient client, GroupMusicOnHoldGetDepartmentListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupMusicOnHoldGetDepartmentListResponse;
        }
        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse22V2 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldGetInstanceRequest22V2Async instead.")]
        public static async Task<GroupMusicOnHoldGetInstanceResponse22V2> GroupMusicOnHoldGetInstanceRequest22V2(this OcipClient client, GroupMusicOnHoldGetInstanceRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse22V2;
        }

        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse22V2 or ErrorResponse.
        /// </summary>
        public static async Task<GroupMusicOnHoldGetInstanceResponse22V2> GroupMusicOnHoldGetInstanceRequest22V2Async(this OcipClient client, GroupMusicOnHoldGetInstanceRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse22V2;
        }
        /// <summary>
        /// Modify data for a group or department Music On Hold Instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldModifyInstanceRequest22Async instead.")]
        public static async Task<SuccessResponse> GroupMusicOnHoldModifyInstanceRequest22(this OcipClient client, GroupMusicOnHoldModifyInstanceRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify data for a group or department Music On Hold Instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupMusicOnHoldModifyInstanceRequest22Async(this OcipClient client, GroupMusicOnHoldModifyInstanceRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with Music On Hold.
        /// The response is either a SystemMusicOnHoldGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMusicOnHoldGetRequestAsync instead.")]
        public static async Task<SystemMusicOnHoldGetResponse> SystemMusicOnHoldGetRequest(this OcipClient client, SystemMusicOnHoldGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemMusicOnHoldGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Music On Hold.
        /// The response is either a SystemMusicOnHoldGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemMusicOnHoldGetResponse> SystemMusicOnHoldGetRequestAsync(this OcipClient client, SystemMusicOnHoldGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemMusicOnHoldGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Music On Hold.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemMusicOnHoldModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemMusicOnHoldModifyRequest(this OcipClient client, SystemMusicOnHoldModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Music On Hold.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMusicOnHoldModifyRequestAsync(this OcipClient client, SystemMusicOnHoldModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with Music On Hold.
        /// The response is either a UserMusicOnHoldGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMusicOnHoldGetRequestAsync instead.")]
        public static async Task<UserMusicOnHoldGetResponse> UserMusicOnHoldGetRequest(this OcipClient client, UserMusicOnHoldGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserMusicOnHoldGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Music On Hold.
        /// The response is either a UserMusicOnHoldGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserMusicOnHoldGetResponse> UserMusicOnHoldGetRequestAsync(this OcipClient client, UserMusicOnHoldGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserMusicOnHoldGetResponse;
        }
        /// <summary>
        /// Modify the user level data associated with Music On Hold.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMusicOnHoldModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserMusicOnHoldModifyRequest(this OcipClient client, UserMusicOnHoldModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Music On Hold.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserMusicOnHoldModifyRequestAsync(this OcipClient client, UserMusicOnHoldModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with Music On Hold User.
        /// The response is either a UserMusicOnHoldUserGetResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMusicOnHoldUserGetRequest20Async instead.")]
        public static async Task<UserMusicOnHoldUserGetResponse20> UserMusicOnHoldUserGetRequest20(this OcipClient client, UserMusicOnHoldUserGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserMusicOnHoldUserGetResponse20;
        }

        /// <summary>
        /// Request the user level data associated with Music On Hold User.
        /// The response is either a UserMusicOnHoldUserGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<UserMusicOnHoldUserGetResponse20> UserMusicOnHoldUserGetRequest20Async(this OcipClient client, UserMusicOnHoldUserGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserMusicOnHoldUserGetResponse20;
        }
        /// <summary>
        /// Modify data for Music On Hold User.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMusicOnHoldUserModifyRequest20Async instead.")]
        public static async Task<SuccessResponse> UserMusicOnHoldUserModifyRequest20(this OcipClient client, UserMusicOnHoldUserModifyRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify data for Music On Hold User.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserMusicOnHoldUserModifyRequest20Async(this OcipClient client, UserMusicOnHoldUserModifyRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
