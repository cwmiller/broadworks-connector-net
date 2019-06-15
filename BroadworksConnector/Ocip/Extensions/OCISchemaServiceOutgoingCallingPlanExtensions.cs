using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceOutgoingCallingPlanExtensions
{

    /// <summary>
    /// Request the list of authorization codes for a group default and it's departments.
    /// The response is either a GroupOutgoingCallingPlanAuthorizationCodeGetListResponse or an ErrorResponse.
    /// </summary>
    public static async Task<GroupOutgoingCallingPlanAuthorizationCodeGetListResponse> GroupOutgoingCallingPlanAuthorizationCodeGetListRequest(this OcipClient client, GroupOutgoingCallingPlanAuthorizationCodeGetListRequest request) {
        return await client.Call(request) as GroupOutgoingCallingPlanAuthorizationCodeGetListResponse;
    }

    /// <summary>
    /// Request the Call Me Now call permissions for a group default and it's departments.
    /// The response is either a GroupOutgoingCallingPlanCallMeNowGetListResponse or an ErrorResponse.
    /// </summary>
    public static async Task<GroupOutgoingCallingPlanCallMeNowGetListResponse> GroupOutgoingCallingPlanCallMeNowGetListRequest(this OcipClient client, GroupOutgoingCallingPlanCallMeNowGetListRequest request) {
        return await client.Call(request) as GroupOutgoingCallingPlanCallMeNowGetListResponse;
    }

    /// <summary>
    /// Modify the Call Me Now call permissions for a group default and it's departments.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupOutgoingCallingPlanCallMeNowModifyListRequest(this OcipClient client, GroupOutgoingCallingPlanCallMeNowModifyListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Add a list of authorization codes to the group's default or a department. When department is not
    /// specified, it is for the group default.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupOutgoingCallingPlanDepartmentAuthorizationCodeAddListRequest(this OcipClient client, GroupOutgoingCallingPlanDepartmentAuthorizationCodeAddListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Delete a list of authorization codes from the group's default or a department. When department is not
    /// specified, it is for the group default.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupOutgoingCallingPlanDepartmentAuthorizationCodeDeleteListRequest(this OcipClient client, GroupOutgoingCallingPlanDepartmentAuthorizationCodeDeleteListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the list of authorization codes for a group default or a department.  When department is not
    /// specified, it is for the group default.
    /// The response is either a GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListResponse or an ErrorResponse.
    /// </summary>
    public static async Task<GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListResponse> GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListRequest(this OcipClient client, GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListRequest request) {
        return await client.Call(request) as GroupOutgoingCallingPlanDepartmentAuthorizationCodeGetListResponse;
    }

    /// <summary>
    /// Request the Call Me Now call permissions for digit patterns for a group default and it's departments.
    /// The response is either a GroupOutgoingCallingPlanDigitPlanCallMeNowGetListResponse or an ErrorResponse.
    /// </summary>
    public static async Task<GroupOutgoingCallingPlanDigitPlanCallMeNowGetListResponse> GroupOutgoingCallingPlanDigitPlanCallMeNowGetListRequest(this OcipClient client, GroupOutgoingCallingPlanDigitPlanCallMeNowGetListRequest request) {
        return await client.Call(request) as GroupOutgoingCallingPlanDigitPlanCallMeNowGetListResponse;
    }

    /// <summary>
    /// Modify the Call Me Now call permissions for digit patterns for a group default and it's departments.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupOutgoingCallingPlanDigitPlanCallMeNowModifyListRequest(this OcipClient client, GroupOutgoingCallingPlanDigitPlanCallMeNowModifyListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the originating permissions for digit patterns for a group default and it's departments.
    /// The response is either a GroupOutgoingCallingPlanDigitPlanOriginatingGetListResponse or an ErrorResponse.
    /// </summary>
    public static async Task<GroupOutgoingCallingPlanDigitPlanOriginatingGetListResponse> GroupOutgoingCallingPlanDigitPlanOriginatingGetListRequest(this OcipClient client, GroupOutgoingCallingPlanDigitPlanOriginatingGetListRequest request) {
        return await client.Call(request) as GroupOutgoingCallingPlanDigitPlanOriginatingGetListResponse;
    }

    /// <summary>
    /// Modify the originating permissions for digit patterns for a group default and it's departments.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupOutgoingCallingPlanDigitPlanOriginatingModifyListRequest(this OcipClient client, GroupOutgoingCallingPlanDigitPlanOriginatingModifyListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the redirecting permissions for digit patterns for a group default and it's departments.
    /// The response is either a GroupOutgoingCallingPlanDigitPlanRedirectingGetListResponse or an ErrorResponse.
    /// </summary>
    public static async Task<GroupOutgoingCallingPlanDigitPlanRedirectingGetListResponse> GroupOutgoingCallingPlanDigitPlanRedirectingGetListRequest(this OcipClient client, GroupOutgoingCallingPlanDigitPlanRedirectingGetListRequest request) {
        return await client.Call(request) as GroupOutgoingCallingPlanDigitPlanRedirectingGetListResponse;
    }

    /// <summary>
    /// Modify the redirecting permissions for digit patterns for a group default and it's departments.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupOutgoingCallingPlanDigitPlanRedirectingModifyListRequest(this OcipClient client, GroupOutgoingCallingPlanDigitPlanRedirectingModifyListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the originating permissions for a group default and it's departments.
    /// The response is either a GroupOutgoingCallingPlanOriginatingGetListResponse or an ErrorResponse.
    /// </summary>
    public static async Task<GroupOutgoingCallingPlanOriginatingGetListResponse> GroupOutgoingCallingPlanOriginatingGetListRequest(this OcipClient client, GroupOutgoingCallingPlanOriginatingGetListRequest request) {
        return await client.Call(request) as GroupOutgoingCallingPlanOriginatingGetListResponse;
    }

    /// <summary>
    /// Modify the originating permissions for a group default and it's departments.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupOutgoingCallingPlanOriginatingModifyListRequest(this OcipClient client, GroupOutgoingCallingPlanOriginatingModifyListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Add a new calling plan Pinhole digit string.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPatternAddRequest(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPatternAddRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Delete one or more calling plan Pinhole digit strings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPatternDeleteListRequest(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPatternDeleteListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get the list of calling plan Pinhole digit strings for a group.
    /// The response is either a GroupOutgoingCallingPlanPinholeDigitPatternGetListResponse or an ErrorResponse.
    /// </summary>
    public static async Task<GroupOutgoingCallingPlanPinholeDigitPatternGetListResponse> GroupOutgoingCallingPlanPinholeDigitPatternGetListRequest(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPatternGetListRequest request) {
        return await client.Call(request) as GroupOutgoingCallingPlanPinholeDigitPatternGetListResponse;
    }

    /// <summary>
    /// Modify a calling plan Pinhole digit string. The name is a key; it cannot be changed.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPatternModifyRequest(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPatternModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the Call Me Now permissions for Pinhole digit patterns for a group default and its departments.
    /// The response is either a GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListResponse or an ErrorResponse.
    /// </summary>
    public static async Task<GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListResponse> GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListRequest(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListRequest request) {
        return await client.Call(request) as GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowGetListResponse;
    }

    /// <summary>
    /// Modify the Call Me Now permissions for Pinhole digit patterns for a group default and its departments.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyListRequest(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the originating permissions for Pinhole digit patterns for a group default and its departments.
    /// The response is either a GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListResponse or an ErrorResponse.
    /// </summary>
    public static async Task<GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListResponse> GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListRequest(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListRequest request) {
        return await client.Call(request) as GroupOutgoingCallingPlanPinholeDigitPlanOriginatingGetListResponse;
    }

    /// <summary>
    /// Modify the originating permissions for Pinhole digit patterns for a group default and its departments.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPlanOriginatingModifyListRequest(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPlanOriginatingModifyListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the redirecting permissions for Pinhole digit patterns for a group default and its departments.
    /// The response is either a GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListResponse or an ErrorResponse.
    /// </summary>
    public static async Task<GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListResponse> GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListRequest(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListRequest request) {
        return await client.Call(request) as GroupOutgoingCallingPlanPinholeDigitPlanRedirectingGetListResponse;
    }

    /// <summary>
    /// Modify the redirecting permissions for Pinhole digit patterns for a group default and its departments.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupOutgoingCallingPlanPinholeDigitPlanRedirectingModifyListRequest(this OcipClient client, GroupOutgoingCallingPlanPinholeDigitPlanRedirectingModifyListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the call forwarded/transferred permissions for a group default and it's departments.
    /// The response is either a GroupOutgoingCallingPlanRedirectedGetListResponse or an ErrorResponse.
    /// </summary>
    public static async Task<GroupOutgoingCallingPlanRedirectedGetListResponse> GroupOutgoingCallingPlanRedirectedGetListRequest(this OcipClient client, GroupOutgoingCallingPlanRedirectedGetListRequest request) {
        return await client.Call(request) as GroupOutgoingCallingPlanRedirectedGetListResponse;
    }

    /// <summary>
    /// Modify the call forwarded/transferred permissions for a group default and it's departments.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupOutgoingCallingPlanRedirectedModifyListRequest(this OcipClient client, GroupOutgoingCallingPlanRedirectedModifyListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the initiating call forwards/transfer permissions for a group default and it's departments.
    /// The response is either a GroupOutgoingCallingPlanRedirectingGetListResponse or an ErrorResponse.
    /// </summary>
    public static async Task<GroupOutgoingCallingPlanRedirectingGetListResponse> GroupOutgoingCallingPlanRedirectingGetListRequest(this OcipClient client, GroupOutgoingCallingPlanRedirectingGetListRequest request) {
        return await client.Call(request) as GroupOutgoingCallingPlanRedirectingGetListResponse;
    }

    /// <summary>
    /// Modify the initiating call forwards/transfer permissions for a group default and it's departments.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupOutgoingCallingPlanRedirectingModifyListRequest(this OcipClient client, GroupOutgoingCallingPlanRedirectingModifyListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the list of transfer numbers for a group default and it's departments.
    /// The response is either a GroupOutgoingCallingPlanTransferNumbersGetListResponse or an ErrorResponse.
    /// </summary>
    public static async Task<GroupOutgoingCallingPlanTransferNumbersGetListResponse> GroupOutgoingCallingPlanTransferNumbersGetListRequest(this OcipClient client, GroupOutgoingCallingPlanTransferNumbersGetListRequest request) {
        return await client.Call(request) as GroupOutgoingCallingPlanTransferNumbersGetListResponse;
    }

    /// <summary>
    /// Modify the list of transfer numbers for a group default and it's departments.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupOutgoingCallingPlanTransferNumbersModifyListRequest(this OcipClient client, GroupOutgoingCallingPlanTransferNumbersModifyListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Add a system outgoing calling plan call type mapping.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> SystemOutgoingCallingPlanCallTypeAddMappingRequest(this OcipClient client, SystemOutgoingCallingPlanCallTypeAddMappingRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Delete a system outgoing calling plan call type mapping.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> SystemOutgoingCallingPlanCallTypeDeleteMappingRequest(this OcipClient client, SystemOutgoingCallingPlanCallTypeDeleteMappingRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request to get the list of call types of outgoing calling plan
    /// The response is SystemOutgoingCallingPlanCallTypeGetListResponse or ErrorResponse.
    /// </summary>
    public static async Task<SystemOutgoingCallingPlanCallTypeGetListResponse> SystemOutgoingCallingPlanCallTypeGetListRequest(this OcipClient client, SystemOutgoingCallingPlanCallTypeGetListRequest request) {
        return await client.Call(request) as SystemOutgoingCallingPlanCallTypeGetListResponse;
    }

    /// <summary>
    /// Get a list of system outgoing calling plan call type mappings.
    /// The response is either SystemOutgoingCallingPlanCallTypeGetMappingListResponse or ErrorResponse.
    /// </summary>
    public static async Task<SystemOutgoingCallingPlanCallTypeGetMappingListResponse> SystemOutgoingCallingPlanCallTypeGetMappingListRequest(this OcipClient client, SystemOutgoingCallingPlanCallTypeGetMappingListRequest request) {
        return await client.Call(request) as SystemOutgoingCallingPlanCallTypeGetMappingListResponse;
    }

    /// <summary>
    /// Request the system level data associated with Outgoing Calling Plan.
    /// The response is either a SystemOutgoingCallingPlanGetResponse17sp3 or an ErrorResponse.
    /// </summary>
    public static async Task<SystemOutgoingCallingPlanGetResponse17sp3> SystemOutgoingCallingPlanGetRequest17sp3(this OcipClient client, SystemOutgoingCallingPlanGetRequest17sp3 request) {
        return await client.Call(request) as SystemOutgoingCallingPlanGetResponse17sp3;
    }

    /// <summary>
    /// Modify the system level data associated with Outgoing Calling Plan.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> SystemOutgoingCallingPlanModifyRequest(this OcipClient client, SystemOutgoingCallingPlanModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Add a list of authorization codes to a user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserOutgoingCallingPlanAuthorizationCodeAddListRequest(this OcipClient client, UserOutgoingCallingPlanAuthorizationCodeAddListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Delete a list of authorization codes from a user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserOutgoingCallingPlanAuthorizationCodeDeleteListRequest(this OcipClient client, UserOutgoingCallingPlanAuthorizationCodeDeleteListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the list of authorization codes for a user.
    /// The response is either a UserOutgoingCallingPlanAuthorizationCodeGetListResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserOutgoingCallingPlanAuthorizationCodeGetListResponse> UserOutgoingCallingPlanAuthorizationCodeGetListRequest(this OcipClient client, UserOutgoingCallingPlanAuthorizationCodeGetListRequest request) {
        return await client.Call(request) as UserOutgoingCallingPlanAuthorizationCodeGetListResponse;
    }

    /// <summary>
    /// Request the authorization code setting for a user.
    /// The response is either a UserOutgoingCallingPlanAuthorizationCodeGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserOutgoingCallingPlanAuthorizationCodeGetResponse> UserOutgoingCallingPlanAuthorizationCodeGetRequest(this OcipClient client, UserOutgoingCallingPlanAuthorizationCodeGetRequest request) {
        return await client.Call(request) as UserOutgoingCallingPlanAuthorizationCodeGetResponse;
    }

    /// <summary>
    /// Modify the authorization setting for a user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserOutgoingCallingPlanAuthorizationCodeModifyRequest(this OcipClient client, UserOutgoingCallingPlanAuthorizationCodeModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the Call Me Now call permissions for a user.
    /// The response is either a UserOutgoingCallingPlanCallMeNowGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserOutgoingCallingPlanCallMeNowGetResponse> UserOutgoingCallingPlanCallMeNowGetRequest(this OcipClient client, UserOutgoingCallingPlanCallMeNowGetRequest request) {
        return await client.Call(request) as UserOutgoingCallingPlanCallMeNowGetResponse;
    }

    /// <summary>
    /// Modify the Call Me Now call permissions for a user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserOutgoingCallingPlanCallMeNowModifyRequest(this OcipClient client, UserOutgoingCallingPlanCallMeNowModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the Call Me Now call permissions for digit patterns for a user.
    /// The response is either a UserOutgoingCallingPlanDigitPlanCallMeNowGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserOutgoingCallingPlanDigitPlanCallMeNowGetResponse> UserOutgoingCallingPlanDigitPlanCallMeNowGetRequest(this OcipClient client, UserOutgoingCallingPlanDigitPlanCallMeNowGetRequest request) {
        return await client.Call(request) as UserOutgoingCallingPlanDigitPlanCallMeNowGetResponse;
    }

    /// <summary>
    /// Modify the Call Me Now call permissions for digit patterns for a user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserOutgoingCallingPlanDigitPlanCallMeNowModifyRequest(this OcipClient client, UserOutgoingCallingPlanDigitPlanCallMeNowModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the originating permissions for digit patterns for a user.
    /// The response is either a UserOutgoingCallingPlanDigitPlanOriginatingGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserOutgoingCallingPlanDigitPlanOriginatingGetResponse> UserOutgoingCallingPlanDigitPlanOriginatingGetRequest(this OcipClient client, UserOutgoingCallingPlanDigitPlanOriginatingGetRequest request) {
        return await client.Call(request) as UserOutgoingCallingPlanDigitPlanOriginatingGetResponse;
    }

    /// <summary>
    /// Modify the originating permissions for digit patterns for a user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserOutgoingCallingPlanDigitPlanOriginatingModifyRequest(this OcipClient client, UserOutgoingCallingPlanDigitPlanOriginatingModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the redirecting permissions for digit patterns for a user.
    /// The response is either a UserOutgoingCallingPlanDigitPlanRedirectingGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserOutgoingCallingPlanDigitPlanRedirectingGetResponse> UserOutgoingCallingPlanDigitPlanRedirectingGetRequest(this OcipClient client, UserOutgoingCallingPlanDigitPlanRedirectingGetRequest request) {
        return await client.Call(request) as UserOutgoingCallingPlanDigitPlanRedirectingGetResponse;
    }

    /// <summary>
    /// Modify the redirecting permissions for digit patterns for a user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserOutgoingCallingPlanDigitPlanRedirectingModifyRequest(this OcipClient client, UserOutgoingCallingPlanDigitPlanRedirectingModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the originating permissions for a user.
    /// The response is either a UserOutgoingCallingPlanOriginatingGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserOutgoingCallingPlanOriginatingGetResponse> UserOutgoingCallingPlanOriginatingGetRequest(this OcipClient client, UserOutgoingCallingPlanOriginatingGetRequest request) {
        return await client.Call(request) as UserOutgoingCallingPlanOriginatingGetResponse;
    }

    /// <summary>
    /// Modify the originating permissions for a user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserOutgoingCallingPlanOriginatingModifyRequest(this OcipClient client, UserOutgoingCallingPlanOriginatingModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the Call Me Now permissions for Pinhole digit patterns for a user.
    /// The response is either a UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetResponse> UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetRequest(this OcipClient client, UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetRequest request) {
        return await client.Call(request) as UserOutgoingCallingPlanPinholeDigitPlanCallMeNowGetResponse;
    }

    /// <summary>
    /// Modify the Call Me Now permissions for Pinhole digit patterns for a user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyRequest(this OcipClient client, UserOutgoingCallingPlanPinholeDigitPlanCallMeNowModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the originating permissions for Pinhole digit patterns for a user.
    /// The response is either a UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetResponse> UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetRequest(this OcipClient client, UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetRequest request) {
        return await client.Call(request) as UserOutgoingCallingPlanPinholeDigitPlanOriginatingGetResponse;
    }

    /// <summary>
    /// Modify the originating permissions for Pinhole digit patterns for a user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserOutgoingCallingPlanPinholeDigitPlanOriginatingModifyRequest(this OcipClient client, UserOutgoingCallingPlanPinholeDigitPlanOriginatingModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the redirecting permissions for Pinhole digit patterns for a user.
    /// The response is either a UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetResponse> UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetRequest(this OcipClient client, UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetRequest request) {
        return await client.Call(request) as UserOutgoingCallingPlanPinholeDigitPlanRedirectingGetResponse;
    }

    /// <summary>
    /// Modify the redirecting permissions for Pinhole digit patterns for a user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserOutgoingCallingPlanPinholeDigitPlanRedirectingModifyRequest(this OcipClient client, UserOutgoingCallingPlanPinholeDigitPlanRedirectingModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the call forwarded/transferred permissions for a user.
    /// The response is either a UserOutgoingCallingPlanRedirectedGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserOutgoingCallingPlanRedirectedGetResponse> UserOutgoingCallingPlanRedirectedGetRequest(this OcipClient client, UserOutgoingCallingPlanRedirectedGetRequest request) {
        return await client.Call(request) as UserOutgoingCallingPlanRedirectedGetResponse;
    }

    /// <summary>
    /// Modify the call forwarded/transferred permissions for a user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserOutgoingCallingPlanRedirectedModifyRequest(this OcipClient client, UserOutgoingCallingPlanRedirectedModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the initiating call forwards/transfer permissions for a user.
    /// The response is either a UserOutgoingCallingPlanRedirectingGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserOutgoingCallingPlanRedirectingGetResponse> UserOutgoingCallingPlanRedirectingGetRequest(this OcipClient client, UserOutgoingCallingPlanRedirectingGetRequest request) {
        return await client.Call(request) as UserOutgoingCallingPlanRedirectingGetResponse;
    }

    /// <summary>
    /// Modify the initiating call forwards/transfer permissions for a user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserOutgoingCallingPlanRedirectingModifyRequest(this OcipClient client, UserOutgoingCallingPlanRedirectingModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the sustained authorization code setting for a user.
    /// The response is either a UserOutgoingCallingPlanSustainedAuthorizationCodeGetResponse or an ErrorResponse.
    /// Engineering Note: This command is used internally by Call Processing.
    /// </summary>
    public static async Task<UserOutgoingCallingPlanSustainedAuthorizationCodeGetResponse> UserOutgoingCallingPlanSustainedAuthorizationCodeGetRequest(this OcipClient client, UserOutgoingCallingPlanSustainedAuthorizationCodeGetRequest request) {
        return await client.Call(request) as UserOutgoingCallingPlanSustainedAuthorizationCodeGetResponse;
    }

    /// <summary>
    /// Modify or clear the sustained authorization code for a user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Engineering Note: This command is used internally by Call Processing.
    /// </summary>
    public static async Task<SuccessResponse> UserOutgoingCallingPlanSustainedAuthorizationCodeModifyRequest(this OcipClient client, UserOutgoingCallingPlanSustainedAuthorizationCodeModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the transfer numbers for a user.
    /// The response is either a UserOutgoingCallingPlanTransferNumbersGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserOutgoingCallingPlanTransferNumbersGetResponse> UserOutgoingCallingPlanTransferNumbersGetRequest(this OcipClient client, UserOutgoingCallingPlanTransferNumbersGetRequest request) {
        return await client.Call(request) as UserOutgoingCallingPlanTransferNumbersGetResponse;
    }

    /// <summary>
    /// Modify the transfer numbers for a user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserOutgoingCallingPlanTransferNumbersModifyRequest(this OcipClient client, UserOutgoingCallingPlanTransferNumbersModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
