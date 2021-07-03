using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceOutgoingCallingPlanExtensions
    {

        /// <summary>
        /// Request the list of authorization codes for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanAuthorizationCodeGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanAuthorizationCodeGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanAuthorizationCodeGetListResponse> GroupOutgoingCallingPlanAuthorizationCodeGetListRequest(this OcipClient client, GroupOutgoingCallingPlanAuthorizationCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanAuthorizationCodeGetListResponse;
        }

        /// <summary>
        /// Request the list of authorization codes for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanAuthorizationCodeGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanAuthorizationCodeGetListResponse> GroupOutgoingCallingPlanAuthorizationCodeGetListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanAuthorizationCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanAuthorizationCodeGetListResponse;
        }
        /// <summary>
        /// Request the Call Me Now call permissions for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanCallMeNowGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanCallMeNowGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanCallMeNowGetListResponse> GroupOutgoingCallingPlanCallMeNowGetListRequest(this OcipClient client, GroupOutgoingCallingPlanCallMeNowGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanCallMeNowGetListResponse;
        }

        /// <summary>
        /// Request the Call Me Now call permissions for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanCallMeNowGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanCallMeNowGetListResponse> GroupOutgoingCallingPlanCallMeNowGetListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanCallMeNowGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanCallMeNowGetListResponse;
        }
        /// <summary>
        /// Modify the Call Me Now call permissions for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanCallMeNowModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanCallMeNowModifyListRequest(this OcipClient client, GroupOutgoingCallingPlanCallMeNowModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Call Me Now call permissions for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanCallMeNowModifyListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanCallMeNowModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a list of authorization codes to the group's default or a department. When department is not
        /// specified, it is for the group default.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanDepartmentAuthorizationCodeAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanDepartmentAuthorizationCodeAddListRequest(this OcipClient client, GroupOutgoingCallingPlanDepartmentAuthorizationCodeAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of authorization codes to the group's default or a department. When department is not
        /// specified, it is for the group default.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanDepartmentAuthorizationCodeAddListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanDepartmentAuthorizationCodeAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of authorization codes from the group's default or a department. When department is not
        /// specified, it is for the group default.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanDepartmentAuthorizationCodeDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanDepartmentAuthorizationCodeDeleteListRequest(this OcipClient client, GroupOutgoingCallingPlanDepartmentAuthorizationCodeDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of authorization codes from the group's default or a department. When department is not
        /// specified, it is for the group default.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanDepartmentAuthorizationCodeDeleteListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanDepartmentAuthorizationCodeDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the list of authorization codes for a group default or a department.  When department is not
        /// specified, it is for the group default.
        /// The response is either a GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListResponse> GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListRequest(this OcipClient client, GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListResponse;
        }

        /// <summary>
        /// Request the list of authorization codes for a group default or a department.  When department is not
        /// specified, it is for the group default.
        /// The response is either a GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListResponse> GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListResponse;
        }
        /// <summary>
        /// Request the Call Me Now call permissions for digit patterns for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanDigitPlanCallMeNowGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanDigitPlanCallMeNowGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanDigitPlanCallMeNowGetListResponse> GroupOutgoingCallingPlanDigitPlanCallMeNowGetListRequest(this OcipClient client, GroupOutgoingCallingPlanDigitPlanCallMeNowGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanDigitPlanCallMeNowGetListResponse;
        }

        /// <summary>
        /// Request the Call Me Now call permissions for digit patterns for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanDigitPlanCallMeNowGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanDigitPlanCallMeNowGetListResponse> GroupOutgoingCallingPlanDigitPlanCallMeNowGetListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanDigitPlanCallMeNowGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanDigitPlanCallMeNowGetListResponse;
        }
        /// <summary>
        /// Modify the Call Me Now call permissions for digit patterns for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanDigitPlanCallMeNowModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanDigitPlanCallMeNowModifyListRequest(this OcipClient client, GroupOutgoingCallingPlanDigitPlanCallMeNowModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Call Me Now call permissions for digit patterns for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanDigitPlanCallMeNowModifyListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanDigitPlanCallMeNowModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the originating permissions for digit patterns for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanDigitPlanOriginatingGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanDigitPlanOriginatingGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanDigitPlanOriginatingGetListResponse> GroupOutgoingCallingPlanDigitPlanOriginatingGetListRequest(this OcipClient client, GroupOutgoingCallingPlanDigitPlanOriginatingGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanDigitPlanOriginatingGetListResponse;
        }

        /// <summary>
        /// Request the originating permissions for digit patterns for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanDigitPlanOriginatingGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanDigitPlanOriginatingGetListResponse> GroupOutgoingCallingPlanDigitPlanOriginatingGetListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanDigitPlanOriginatingGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanDigitPlanOriginatingGetListResponse;
        }
        /// <summary>
        /// Modify the originating permissions for digit patterns for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanDigitPlanOriginatingModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanDigitPlanOriginatingModifyListRequest(this OcipClient client, GroupOutgoingCallingPlanDigitPlanOriginatingModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the originating permissions for digit patterns for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanDigitPlanOriginatingModifyListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanDigitPlanOriginatingModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the redirecting permissions for digit patterns for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanDigitPlanRedirectingGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanDigitPlanRedirectingGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanDigitPlanRedirectingGetListResponse> GroupOutgoingCallingPlanDigitPlanRedirectingGetListRequest(this OcipClient client, GroupOutgoingCallingPlanDigitPlanRedirectingGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanDigitPlanRedirectingGetListResponse;
        }

        /// <summary>
        /// Request the redirecting permissions for digit patterns for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanDigitPlanRedirectingGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanDigitPlanRedirectingGetListResponse> GroupOutgoingCallingPlanDigitPlanRedirectingGetListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanDigitPlanRedirectingGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanDigitPlanRedirectingGetListResponse;
        }
        /// <summary>
        /// Modify the redirecting permissions for digit patterns for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanDigitPlanRedirectingModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanDigitPlanRedirectingModifyListRequest(this OcipClient client, GroupOutgoingCallingPlanDigitPlanRedirectingModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the redirecting permissions for digit patterns for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanDigitPlanRedirectingModifyListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanDigitPlanRedirectingModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the originating permissions for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanOriginatingGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanOriginatingGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanOriginatingGetListResponse> GroupOutgoingCallingPlanOriginatingGetListRequest(this OcipClient client, GroupOutgoingCallingPlanOriginatingGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanOriginatingGetListResponse;
        }

        /// <summary>
        /// Request the originating permissions for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanOriginatingGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanOriginatingGetListResponse> GroupOutgoingCallingPlanOriginatingGetListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanOriginatingGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanOriginatingGetListResponse;
        }
        /// <summary>
        /// Modify the originating permissions for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanOriginatingModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanOriginatingModifyListRequest(this OcipClient client, GroupOutgoingCallingPlanOriginatingModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the originating permissions for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanOriginatingModifyListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanOriginatingModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a new calling plan Pinhole digit string.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanPinholeDigitPatternAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPatternAddRequest(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPatternAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new calling plan Pinhole digit string.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPatternAddRequestAsync(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPatternAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete one or more calling plan Pinhole digit strings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanPinholeDigitPatternDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPatternDeleteListRequest(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPatternDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete one or more calling plan Pinhole digit strings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPatternDeleteListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPatternDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the list of calling plan Pinhole digit strings for a group.
        /// The response is either a GroupOutgoingCallingPlanPinholeDigitPatternGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanPinholeDigitPatternGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanPinholeDigitPatternGetListResponse> GroupOutgoingCallingPlanPinholeDigitPatternGetListRequest(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPatternGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanPinholeDigitPatternGetListResponse;
        }

        /// <summary>
        /// Get the list of calling plan Pinhole digit strings for a group.
        /// The response is either a GroupOutgoingCallingPlanPinholeDigitPatternGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanPinholeDigitPatternGetListResponse> GroupOutgoingCallingPlanPinholeDigitPatternGetListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPatternGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanPinholeDigitPatternGetListResponse;
        }
        /// <summary>
        /// Modify a calling plan Pinhole digit string. The name is a key; it cannot be changed.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanPinholeDigitPatternModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPatternModifyRequest(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPatternModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a calling plan Pinhole digit string. The name is a key; it cannot be changed.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPatternModifyRequestAsync(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPatternModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the Call Me Now permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListResponse> GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListRequest(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListResponse;
        }

        /// <summary>
        /// Request the Call Me Now permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListResponse> GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListResponse;
        }
        /// <summary>
        /// Modify the Call Me Now permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyListRequest(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Call Me Now permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the originating permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListResponse> GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListRequest(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListResponse;
        }

        /// <summary>
        /// Request the originating permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListResponse> GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListResponse;
        }
        /// <summary>
        /// Modify the originating permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanPinholeDigitPlanOriginatingModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPlanOriginatingModifyListRequest(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPlanOriginatingModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the originating permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPlanOriginatingModifyListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPlanOriginatingModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the redirecting permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListResponse> GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListRequest(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListResponse;
        }

        /// <summary>
        /// Request the redirecting permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListResponse> GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListResponse;
        }
        /// <summary>
        /// Modify the redirecting permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanPinholeDigitPlanRedirectingModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPlanRedirectingModifyListRequest(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPlanRedirectingModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the redirecting permissions for Pinhole digit patterns for a group default and its departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPlanRedirectingModifyListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPlanRedirectingModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the call forwarded/transferred permissions for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanRedirectedGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanRedirectedGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanRedirectedGetListResponse> GroupOutgoingCallingPlanRedirectedGetListRequest(this OcipClient client, GroupOutgoingCallingPlanRedirectedGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanRedirectedGetListResponse;
        }

        /// <summary>
        /// Request the call forwarded/transferred permissions for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanRedirectedGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanRedirectedGetListResponse> GroupOutgoingCallingPlanRedirectedGetListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanRedirectedGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanRedirectedGetListResponse;
        }
        /// <summary>
        /// Modify the call forwarded/transferred permissions for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanRedirectedModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanRedirectedModifyListRequest(this OcipClient client, GroupOutgoingCallingPlanRedirectedModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the call forwarded/transferred permissions for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanRedirectedModifyListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanRedirectedModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the initiating call forwards/transfer permissions for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanRedirectingGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanRedirectingGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanRedirectingGetListResponse> GroupOutgoingCallingPlanRedirectingGetListRequest(this OcipClient client, GroupOutgoingCallingPlanRedirectingGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanRedirectingGetListResponse;
        }

        /// <summary>
        /// Request the initiating call forwards/transfer permissions for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanRedirectingGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanRedirectingGetListResponse> GroupOutgoingCallingPlanRedirectingGetListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanRedirectingGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanRedirectingGetListResponse;
        }
        /// <summary>
        /// Modify the initiating call forwards/transfer permissions for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanRedirectingModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanRedirectingModifyListRequest(this OcipClient client, GroupOutgoingCallingPlanRedirectingModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the initiating call forwards/transfer permissions for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanRedirectingModifyListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanRedirectingModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the list of transfer numbers for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanTransferNumbersGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanTransferNumbersGetListRequestAsync instead.")]
        public static async Task<GroupOutgoingCallingPlanTransferNumbersGetListResponse> GroupOutgoingCallingPlanTransferNumbersGetListRequest(this OcipClient client, GroupOutgoingCallingPlanTransferNumbersGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupOutgoingCallingPlanTransferNumbersGetListResponse;
        }

        /// <summary>
        /// Request the list of transfer numbers for a group default and it's departments.
        /// The response is either a GroupOutgoingCallingPlanTransferNumbersGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupOutgoingCallingPlanTransferNumbersGetListResponse> GroupOutgoingCallingPlanTransferNumbersGetListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanTransferNumbersGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupOutgoingCallingPlanTransferNumbersGetListResponse;
        }
        /// <summary>
        /// Modify the list of transfer numbers for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupOutgoingCallingPlanTransferNumbersModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanTransferNumbersModifyListRequest(this OcipClient client, GroupOutgoingCallingPlanTransferNumbersModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the list of transfer numbers for a group default and it's departments.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupOutgoingCallingPlanTransferNumbersModifyListRequestAsync(this OcipClient client, GroupOutgoingCallingPlanTransferNumbersModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a system outgoing calling plan call type mapping.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOutgoingCallingPlanCallTypeAddMappingRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOutgoingCallingPlanCallTypeAddMappingRequest(this OcipClient client, SystemOutgoingCallingPlanCallTypeAddMappingRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a system outgoing calling plan call type mapping.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOutgoingCallingPlanCallTypeAddMappingRequestAsync(this OcipClient client, SystemOutgoingCallingPlanCallTypeAddMappingRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a system outgoing calling plan call type mapping.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOutgoingCallingPlanCallTypeDeleteMappingRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOutgoingCallingPlanCallTypeDeleteMappingRequest(this OcipClient client, SystemOutgoingCallingPlanCallTypeDeleteMappingRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a system outgoing calling plan call type mapping.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOutgoingCallingPlanCallTypeDeleteMappingRequestAsync(this OcipClient client, SystemOutgoingCallingPlanCallTypeDeleteMappingRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of call types of outgoing calling plan.
        /// The response is SystemOutgoingCallingPlanCallTypeGetListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOutgoingCallingPlanCallTypeGetListRequestAsync instead.")]
        public static async Task<SystemOutgoingCallingPlanCallTypeGetListResponse> SystemOutgoingCallingPlanCallTypeGetListRequest(this OcipClient client, SystemOutgoingCallingPlanCallTypeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOutgoingCallingPlanCallTypeGetListResponse;
        }

        /// <summary>
        /// Request to get the list of call types of outgoing calling plan.
        /// The response is SystemOutgoingCallingPlanCallTypeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemOutgoingCallingPlanCallTypeGetListResponse> SystemOutgoingCallingPlanCallTypeGetListRequestAsync(this OcipClient client, SystemOutgoingCallingPlanCallTypeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOutgoingCallingPlanCallTypeGetListResponse;
        }
        /// <summary>
        /// Get a list of system outgoing calling plan call type mappings.
        /// The response is either SystemOutgoingCallingPlanCallTypeGetMappingListResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOutgoingCallingPlanCallTypeGetMappingListRequestAsync instead.")]
        public static async Task<SystemOutgoingCallingPlanCallTypeGetMappingListResponse> SystemOutgoingCallingPlanCallTypeGetMappingListRequest(this OcipClient client, SystemOutgoingCallingPlanCallTypeGetMappingListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOutgoingCallingPlanCallTypeGetMappingListResponse;
        }

        /// <summary>
        /// Get a list of system outgoing calling plan call type mappings.
        /// The response is either SystemOutgoingCallingPlanCallTypeGetMappingListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemOutgoingCallingPlanCallTypeGetMappingListResponse> SystemOutgoingCallingPlanCallTypeGetMappingListRequestAsync(this OcipClient client, SystemOutgoingCallingPlanCallTypeGetMappingListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOutgoingCallingPlanCallTypeGetMappingListResponse;
        }
        /// <summary>
        /// Request the system level data associated with Outgoing Calling Plan.
        /// The response is either a SystemOutgoingCallingPlanGetResponse17sp3 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOutgoingCallingPlanGetRequest17sp3Async instead.")]
        public static async Task<SystemOutgoingCallingPlanGetResponse17sp3> SystemOutgoingCallingPlanGetRequest17sp3(this OcipClient client, SystemOutgoingCallingPlanGetRequest17sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemOutgoingCallingPlanGetResponse17sp3;
        }

        /// <summary>
        /// Request the system level data associated with Outgoing Calling Plan.
        /// The response is either a SystemOutgoingCallingPlanGetResponse17sp3 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemOutgoingCallingPlanGetResponse17sp3> SystemOutgoingCallingPlanGetRequest17sp3Async(this OcipClient client, SystemOutgoingCallingPlanGetRequest17sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemOutgoingCallingPlanGetResponse17sp3;
        }
        /// <summary>
        /// Modify the system level data associated with Outgoing Calling Plan.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOutgoingCallingPlanModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemOutgoingCallingPlanModifyRequest(this OcipClient client, SystemOutgoingCallingPlanModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Outgoing Calling Plan.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOutgoingCallingPlanModifyRequestAsync(this OcipClient client, SystemOutgoingCallingPlanModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a list of authorization codes to a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanAuthorizationCodeAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanAuthorizationCodeAddListRequest(this OcipClient client, UserOutgoingCallingPlanAuthorizationCodeAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of authorization codes to a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanAuthorizationCodeAddListRequestAsync(this OcipClient client, UserOutgoingCallingPlanAuthorizationCodeAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a list of authorization codes from a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanAuthorizationCodeDeleteListRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanAuthorizationCodeDeleteListRequest(this OcipClient client, UserOutgoingCallingPlanAuthorizationCodeDeleteListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of authorization codes from a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanAuthorizationCodeDeleteListRequestAsync(this OcipClient client, UserOutgoingCallingPlanAuthorizationCodeDeleteListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the list of authorization codes for a user.
        /// The response is either a UserOutgoingCallingPlanAuthorizationCodeGetListResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanAuthorizationCodeGetListRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanAuthorizationCodeGetListResponse> UserOutgoingCallingPlanAuthorizationCodeGetListRequest(this OcipClient client, UserOutgoingCallingPlanAuthorizationCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanAuthorizationCodeGetListResponse;
        }

        /// <summary>
        /// Request the list of authorization codes for a user.
        /// The response is either a UserOutgoingCallingPlanAuthorizationCodeGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanAuthorizationCodeGetListResponse> UserOutgoingCallingPlanAuthorizationCodeGetListRequestAsync(this OcipClient client, UserOutgoingCallingPlanAuthorizationCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanAuthorizationCodeGetListResponse;
        }
        /// <summary>
        /// Request the authorization code setting for a user.
        /// The response is either a UserOutgoingCallingPlanAuthorizationCodeGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanAuthorizationCodeGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanAuthorizationCodeGetResponse> UserOutgoingCallingPlanAuthorizationCodeGetRequest(this OcipClient client, UserOutgoingCallingPlanAuthorizationCodeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanAuthorizationCodeGetResponse;
        }

        /// <summary>
        /// Request the authorization code setting for a user.
        /// The response is either a UserOutgoingCallingPlanAuthorizationCodeGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanAuthorizationCodeGetResponse> UserOutgoingCallingPlanAuthorizationCodeGetRequestAsync(this OcipClient client, UserOutgoingCallingPlanAuthorizationCodeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanAuthorizationCodeGetResponse;
        }
        /// <summary>
        /// Modify the authorization setting for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanAuthorizationCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanAuthorizationCodeModifyRequest(this OcipClient client, UserOutgoingCallingPlanAuthorizationCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the authorization setting for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanAuthorizationCodeModifyRequestAsync(this OcipClient client, UserOutgoingCallingPlanAuthorizationCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the Call Me Now call permissions for a user.
        /// The response is either a UserOutgoingCallingPlanCallMeNowGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanCallMeNowGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanCallMeNowGetResponse> UserOutgoingCallingPlanCallMeNowGetRequest(this OcipClient client, UserOutgoingCallingPlanCallMeNowGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanCallMeNowGetResponse;
        }

        /// <summary>
        /// Request the Call Me Now call permissions for a user.
        /// The response is either a UserOutgoingCallingPlanCallMeNowGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanCallMeNowGetResponse> UserOutgoingCallingPlanCallMeNowGetRequestAsync(this OcipClient client, UserOutgoingCallingPlanCallMeNowGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanCallMeNowGetResponse;
        }
        /// <summary>
        /// Modify the Call Me Now call permissions for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanCallMeNowModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanCallMeNowModifyRequest(this OcipClient client, UserOutgoingCallingPlanCallMeNowModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Call Me Now call permissions for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanCallMeNowModifyRequestAsync(this OcipClient client, UserOutgoingCallingPlanCallMeNowModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the Call Me Now call permissions for digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanDigitPlanCallMeNowGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanDigitPlanCallMeNowGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanDigitPlanCallMeNowGetResponse> UserOutgoingCallingPlanDigitPlanCallMeNowGetRequest(this OcipClient client, UserOutgoingCallingPlanDigitPlanCallMeNowGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanDigitPlanCallMeNowGetResponse;
        }

        /// <summary>
        /// Request the Call Me Now call permissions for digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanDigitPlanCallMeNowGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanDigitPlanCallMeNowGetResponse> UserOutgoingCallingPlanDigitPlanCallMeNowGetRequestAsync(this OcipClient client, UserOutgoingCallingPlanDigitPlanCallMeNowGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanDigitPlanCallMeNowGetResponse;
        }
        /// <summary>
        /// Modify the Call Me Now call permissions for digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanDigitPlanCallMeNowModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanDigitPlanCallMeNowModifyRequest(this OcipClient client, UserOutgoingCallingPlanDigitPlanCallMeNowModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Call Me Now call permissions for digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanDigitPlanCallMeNowModifyRequestAsync(this OcipClient client, UserOutgoingCallingPlanDigitPlanCallMeNowModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the originating permissions for digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanDigitPlanOriginatingGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanDigitPlanOriginatingGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanDigitPlanOriginatingGetResponse> UserOutgoingCallingPlanDigitPlanOriginatingGetRequest(this OcipClient client, UserOutgoingCallingPlanDigitPlanOriginatingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanDigitPlanOriginatingGetResponse;
        }

        /// <summary>
        /// Request the originating permissions for digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanDigitPlanOriginatingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanDigitPlanOriginatingGetResponse> UserOutgoingCallingPlanDigitPlanOriginatingGetRequestAsync(this OcipClient client, UserOutgoingCallingPlanDigitPlanOriginatingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanDigitPlanOriginatingGetResponse;
        }
        /// <summary>
        /// Modify the originating permissions for digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanDigitPlanOriginatingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanDigitPlanOriginatingModifyRequest(this OcipClient client, UserOutgoingCallingPlanDigitPlanOriginatingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the originating permissions for digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanDigitPlanOriginatingModifyRequestAsync(this OcipClient client, UserOutgoingCallingPlanDigitPlanOriginatingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the redirecting permissions for digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanDigitPlanRedirectingGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanDigitPlanRedirectingGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanDigitPlanRedirectingGetResponse> UserOutgoingCallingPlanDigitPlanRedirectingGetRequest(this OcipClient client, UserOutgoingCallingPlanDigitPlanRedirectingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanDigitPlanRedirectingGetResponse;
        }

        /// <summary>
        /// Request the redirecting permissions for digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanDigitPlanRedirectingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanDigitPlanRedirectingGetResponse> UserOutgoingCallingPlanDigitPlanRedirectingGetRequestAsync(this OcipClient client, UserOutgoingCallingPlanDigitPlanRedirectingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanDigitPlanRedirectingGetResponse;
        }
        /// <summary>
        /// Modify the redirecting permissions for digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanDigitPlanRedirectingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanDigitPlanRedirectingModifyRequest(this OcipClient client, UserOutgoingCallingPlanDigitPlanRedirectingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the redirecting permissions for digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanDigitPlanRedirectingModifyRequestAsync(this OcipClient client, UserOutgoingCallingPlanDigitPlanRedirectingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the originating permissions for a user.
        /// The response is either a UserOutgoingCallingPlanOriginatingGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanOriginatingGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanOriginatingGetResponse> UserOutgoingCallingPlanOriginatingGetRequest(this OcipClient client, UserOutgoingCallingPlanOriginatingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanOriginatingGetResponse;
        }

        /// <summary>
        /// Request the originating permissions for a user.
        /// The response is either a UserOutgoingCallingPlanOriginatingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanOriginatingGetResponse> UserOutgoingCallingPlanOriginatingGetRequestAsync(this OcipClient client, UserOutgoingCallingPlanOriginatingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanOriginatingGetResponse;
        }
        /// <summary>
        /// Modify the originating permissions for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanOriginatingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanOriginatingModifyRequest(this OcipClient client, UserOutgoingCallingPlanOriginatingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the originating permissions for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanOriginatingModifyRequestAsync(this OcipClient client, UserOutgoingCallingPlanOriginatingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the Call Me Now permissions for Pinhole digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetResponse> UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetRequest(this OcipClient client, UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetResponse;
        }

        /// <summary>
        /// Request the Call Me Now permissions for Pinhole digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetResponse> UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetRequestAsync(this OcipClient client, UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetResponse;
        }
        /// <summary>
        /// Modify the Call Me Now permissions for Pinhole digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyRequest(this OcipClient client, UserOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Call Me Now permissions for Pinhole digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyRequestAsync(this OcipClient client, UserOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the originating permissions for Pinhole digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetResponse> UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetRequest(this OcipClient client, UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetResponse;
        }

        /// <summary>
        /// Request the originating permissions for Pinhole digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetResponse> UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetRequestAsync(this OcipClient client, UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetResponse;
        }
        /// <summary>
        /// Modify the originating permissions for Pinhole digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanPinholeDigitPlanOriginatingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanPinholeDigitPlanOriginatingModifyRequest(this OcipClient client, UserOutgoingCallingPlanPinholeDigitPlanOriginatingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the originating permissions for Pinhole digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanPinholeDigitPlanOriginatingModifyRequestAsync(this OcipClient client, UserOutgoingCallingPlanPinholeDigitPlanOriginatingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the redirecting permissions for Pinhole digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetResponse> UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetRequest(this OcipClient client, UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetResponse;
        }

        /// <summary>
        /// Request the redirecting permissions for Pinhole digit patterns for a user.
        /// The response is either a UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetResponse> UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetRequestAsync(this OcipClient client, UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetResponse;
        }
        /// <summary>
        /// Modify the redirecting permissions for Pinhole digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanPinholeDigitPlanRedirectingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanPinholeDigitPlanRedirectingModifyRequest(this OcipClient client, UserOutgoingCallingPlanPinholeDigitPlanRedirectingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the redirecting permissions for Pinhole digit patterns for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanPinholeDigitPlanRedirectingModifyRequestAsync(this OcipClient client, UserOutgoingCallingPlanPinholeDigitPlanRedirectingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the call forwarded/transferred permissions for a user.
        /// The response is either a UserOutgoingCallingPlanRedirectedGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanRedirectedGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanRedirectedGetResponse> UserOutgoingCallingPlanRedirectedGetRequest(this OcipClient client, UserOutgoingCallingPlanRedirectedGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanRedirectedGetResponse;
        }

        /// <summary>
        /// Request the call forwarded/transferred permissions for a user.
        /// The response is either a UserOutgoingCallingPlanRedirectedGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanRedirectedGetResponse> UserOutgoingCallingPlanRedirectedGetRequestAsync(this OcipClient client, UserOutgoingCallingPlanRedirectedGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanRedirectedGetResponse;
        }
        /// <summary>
        /// Modify the call forwarded/transferred permissions for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanRedirectedModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanRedirectedModifyRequest(this OcipClient client, UserOutgoingCallingPlanRedirectedModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the call forwarded/transferred permissions for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanRedirectedModifyRequestAsync(this OcipClient client, UserOutgoingCallingPlanRedirectedModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the initiating call forwards/transfer permissions for a user.
        /// The response is either a UserOutgoingCallingPlanRedirectingGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanRedirectingGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanRedirectingGetResponse> UserOutgoingCallingPlanRedirectingGetRequest(this OcipClient client, UserOutgoingCallingPlanRedirectingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanRedirectingGetResponse;
        }

        /// <summary>
        /// Request the initiating call forwards/transfer permissions for a user.
        /// The response is either a UserOutgoingCallingPlanRedirectingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanRedirectingGetResponse> UserOutgoingCallingPlanRedirectingGetRequestAsync(this OcipClient client, UserOutgoingCallingPlanRedirectingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanRedirectingGetResponse;
        }
        /// <summary>
        /// Modify the initiating call forwards/transfer permissions for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanRedirectingModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanRedirectingModifyRequest(this OcipClient client, UserOutgoingCallingPlanRedirectingModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the initiating call forwards/transfer permissions for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanRedirectingModifyRequestAsync(this OcipClient client, UserOutgoingCallingPlanRedirectingModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the sustained authorization code setting for a user.
        /// The response is either a UserOutgoingCallingPlanSustainedAuthorizationCodeGetResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanSustainedAuthorizationCodeGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanSustainedAuthorizationCodeGetResponse> UserOutgoingCallingPlanSustainedAuthorizationCodeGetRequest(this OcipClient client, UserOutgoingCallingPlanSustainedAuthorizationCodeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanSustainedAuthorizationCodeGetResponse;
        }

        /// <summary>
        /// Request the sustained authorization code setting for a user.
        /// The response is either a UserOutgoingCallingPlanSustainedAuthorizationCodeGetResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanSustainedAuthorizationCodeGetResponse> UserOutgoingCallingPlanSustainedAuthorizationCodeGetRequestAsync(this OcipClient client, UserOutgoingCallingPlanSustainedAuthorizationCodeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanSustainedAuthorizationCodeGetResponse;
        }
        /// <summary>
        /// Modify or clear the sustained authorization code for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanSustainedAuthorizationCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanSustainedAuthorizationCodeModifyRequest(this OcipClient client, UserOutgoingCallingPlanSustainedAuthorizationCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify or clear the sustained authorization code for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanSustainedAuthorizationCodeModifyRequestAsync(this OcipClient client, UserOutgoingCallingPlanSustainedAuthorizationCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the transfer numbers for a user.
        /// The response is either a UserOutgoingCallingPlanTransferNumbersGetResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanTransferNumbersGetRequestAsync instead.")]
        public static async Task<UserOutgoingCallingPlanTransferNumbersGetResponse> UserOutgoingCallingPlanTransferNumbersGetRequest(this OcipClient client, UserOutgoingCallingPlanTransferNumbersGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserOutgoingCallingPlanTransferNumbersGetResponse;
        }

        /// <summary>
        /// Request the transfer numbers for a user.
        /// The response is either a UserOutgoingCallingPlanTransferNumbersGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserOutgoingCallingPlanTransferNumbersGetResponse> UserOutgoingCallingPlanTransferNumbersGetRequestAsync(this OcipClient client, UserOutgoingCallingPlanTransferNumbersGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserOutgoingCallingPlanTransferNumbersGetResponse;
        }
        /// <summary>
        /// Modify the transfer numbers for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserOutgoingCallingPlanTransferNumbersModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserOutgoingCallingPlanTransferNumbersModifyRequest(this OcipClient client, UserOutgoingCallingPlanTransferNumbersModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the transfer numbers for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserOutgoingCallingPlanTransferNumbersModifyRequestAsync(this OcipClient client, UserOutgoingCallingPlanTransferNumbersModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
