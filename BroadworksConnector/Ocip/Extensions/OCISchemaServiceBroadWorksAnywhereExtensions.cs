using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceBroadWorksAnywhereExtensions
{

    /// <summary>
    /// Add a BroadWorks Anywhere instance to a group.
    /// The domain is required in the serviceUserId.
    /// The following elements are only used in AS data mode:
    /// networkClassOfService
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupBroadWorksAnywhereAddInstanceRequest(this OcipClient client, GroupBroadWorksAnywhereAddInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Delete a BroadWorks Anywhere instance from a group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupBroadWorksAnywhereDeleteInstanceRequest(this OcipClient client, GroupBroadWorksAnywhereDeleteInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get a list of BroadWorks Anywhere instances within a group.
    /// The response is either GroupBroadWorksAnywhereGetInstanceListResponse or ErrorResponse.
    /// It is possible to get the instances within a specified department.
    /// </summary>
    public static async Task<GroupBroadWorksAnywhereGetInstanceListResponse> GroupBroadWorksAnywhereGetInstanceListRequest(this OcipClient client, GroupBroadWorksAnywhereGetInstanceListRequest request) {
        return await client.Call(request) as GroupBroadWorksAnywhereGetInstanceListResponse;
    }

    /// <summary>
    /// Request to get all the information of a BroadWorks Anywhere instance.
    /// The response is either GroupBroadWorksAnywhereGetInstanceResponse19sp1 or ErrorResponse.
    /// </summary>
    public static async Task<GroupBroadWorksAnywhereGetInstanceResponse19sp1> GroupBroadWorksAnywhereGetInstanceRequest19sp1(this OcipClient client, GroupBroadWorksAnywhereGetInstanceRequest19sp1 request) {
        return await client.Call(request) as GroupBroadWorksAnywhereGetInstanceResponse19sp1;
    }

    /// <summary>
    /// Request to set the active status of BroadWorks Anywhere instances.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupBroadWorksAnywhereModifyActiveInstanceListRequest(this OcipClient client, GroupBroadWorksAnywhereModifyActiveInstanceListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request to modify a BroadWorks Anywhere instance.
    /// The following elements are only used in AS data mode:
    /// networkClassOfService
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupBroadWorksAnywhereModifyInstanceRequest(this OcipClient client, GroupBroadWorksAnywhereModifyInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get the Broadworks Anywhere system parameters.
    /// The response is either a SystemBroadWorksAnywhereGetResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SystemBroadWorksAnywhereGetResponse> SystemBroadWorksAnywhereGetRequest(this OcipClient client, SystemBroadWorksAnywhereGetRequest request) {
        return await client.Call(request) as SystemBroadWorksAnywhereGetResponse;
    }

    /// <summary>
    /// Modify the BroadWorks Anywhere system parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> SystemBroadWorksAnywhereModifyRequest(this OcipClient client, SystemBroadWorksAnywhereModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Add a broadworks Anywhere phone number.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserBroadWorksAnywhereAddPhoneNumberRequest(this OcipClient client, UserBroadWorksAnywhereAddPhoneNumberRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Add a criteria to the user's BroadWorks Anywhere phone number.
    /// The following elements are only used in AS data mode:
    /// callToNumber
    /// 
    /// For the callToNumber, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserBroadWorksAnywhereAddSelectiveCriteriaRequest16(this OcipClient client, UserBroadWorksAnywhereAddSelectiveCriteriaRequest16 request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Delete a broadworks anywhere phone number. Also deletes all the selective criteria for the phone number.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserBroadWorksAnywhereDeletePhoneNumberRequest(this OcipClient client, UserBroadWorksAnywhereDeletePhoneNumberRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Delete a criteria from the user's BroadWorks Anywhere phone number.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserBroadWorksAnywhereDeleteSelectiveCriteriaRequest(this OcipClient client, UserBroadWorksAnywhereDeleteSelectiveCriteriaRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get a list of all the available BroadWorks Anywhere portal instances for a specific user
    /// The response is either UserBroadWorksAnywhereGetAvailablePortalListResponse21sp1 or ErrorResponse.
    /// </summary>
    public static async Task<UserBroadWorksAnywhereGetAvailablePortalListResponse21sp1> UserBroadWorksAnywhereGetAvailablePortalListRequest21sp1(this OcipClient client, UserBroadWorksAnywhereGetAvailablePortalListRequest21sp1 request) {
        return await client.Call(request) as UserBroadWorksAnywhereGetAvailablePortalListResponse21sp1;
    }

    /// <summary>
    /// Get the list of all the BroadWorks Anywhere phone numbers for the user.
    /// If no sortOrder is included the response is sorted by Phone Number ascending by default.
    /// The response is either a UserBroadWorksAnywhereGetPhoneNumberPagedSortedListResponse or an ErrorResponse.
    /// </summary>
    public static async Task<UserBroadWorksAnywhereGetPhoneNumberPagedSortedListResponse> UserBroadWorksAnywhereGetPhoneNumberPagedSortedListRequest(this OcipClient client, UserBroadWorksAnywhereGetPhoneNumberPagedSortedListRequest request) {
        return await client.Call(request) as UserBroadWorksAnywhereGetPhoneNumberPagedSortedListResponse;
    }

    /// <summary>
    /// Get a broadworks anywhere phone number
    /// The response is UserBroadWorksAnywhereGetPhoneNumberResponse.
    /// </summary>
    public static async Task<UserBroadWorksAnywhereGetPhoneNumberResponse> UserBroadWorksAnywhereGetPhoneNumberRequest(this OcipClient client, UserBroadWorksAnywhereGetPhoneNumberRequest request) {
        return await client.Call(request) as UserBroadWorksAnywhereGetPhoneNumberResponse;
    }

    /// <summary>
    /// Get the list of all the BroadWorks Anywhere phone numbers for the user.
    /// The response is either a UserBroadWorksAnywhereGetResponse16sp2 or an ErrorResponse.
    /// </summary>
    public static async Task<UserBroadWorksAnywhereGetResponse16sp2> UserBroadWorksAnywhereGetRequest16sp2(this OcipClient client, UserBroadWorksAnywhereGetRequest16sp2 request) {
        return await client.Call(request) as UserBroadWorksAnywhereGetResponse16sp2;
    }

    /// <summary>
    /// Get a criteria for the user's BroadWorks Anywhere phone number.
    /// The response is either a UserBroadWorksAnywhereGetSelectiveCriteriaResponse21 or an ErrorResponse.
    /// </summary>
    public static async Task<UserBroadWorksAnywhereGetSelectiveCriteriaResponse21> UserBroadWorksAnywhereGetSelectiveCriteriaRequest21(this OcipClient client, UserBroadWorksAnywhereGetSelectiveCriteriaRequest21 request) {
        return await client.Call(request) as UserBroadWorksAnywhereGetSelectiveCriteriaResponse21;
    }

    /// <summary>
    /// Modify a BroadWorks Anywhere phone number
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserBroadWorksAnywhereModifyPhoneNumberRequest(this OcipClient client, UserBroadWorksAnywhereModifyPhoneNumberRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request to modify the user-level settings for the BroadWorks Anywhere service for a specified user.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserBroadWorksAnywhereModifyRequest(this OcipClient client, UserBroadWorksAnywhereModifyRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Modify selective criteria for the user's BroadWorks Anywhere phone number.
    /// The following elements are only used in AS data mode:
    /// callToNumbers
    /// 
    /// For the callToNumbers in the callToNumberList, the extension element is not used and the number element is only used when the type is BroadWorks Mobility.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> UserBroadWorksAnywhereModifySelectiveCriteriaRequest(this OcipClient client, UserBroadWorksAnywhereModifySelectiveCriteriaRequest request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
