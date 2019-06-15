using System.Threading.Tasks;
    using BroadWorksConnector.Ocip.Models;
    using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip.Extensions
{
public static class OCISchemaServiceHuntGroupExtensions
{

    /// <summary>
    /// Add a Hunt Group instance to a group.
    /// The domain is required in the serviceUserId.
    /// The response is either SuccessResponse or ErrorResponse.
    /// The following elements are only used in AS data mode:
    /// useSystemHuntGroupCLIDSetting, use value "true" in XS data mode
    /// includeHuntGroupNameInCLID, use value "true" in XS data mode
    /// </summary>
    public static async Task<SuccessResponse> GroupHuntGroupAddInstanceRequest20(this OcipClient client, GroupHuntGroupAddInstanceRequest20 request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Add a Hunt Group instance to a group.
    /// The domain is required in the serviceUserId.
    /// 
    /// If the phoneNumber has not been assigned to the group and addPhoneNumberToGroup is set to true,
    /// it will be added to group if the command is executed by a service provider administrator or above
    /// and the number is already assigned to the service provider. The command will fail otherwise.
    /// 
    /// The response is either SuccessResponse or ErrorResponse.
    /// The following elements are only used in AS data mode:
    /// useSystemHuntGroupCLIDSetting, use value "true" in XS data mode
    /// includeHuntGroupNameInCLID, use value "true" in XS data mode
    /// </summary>
    public static async Task<SuccessResponse> GroupHuntGroupConsolidatedAddInstanceRequest(this OcipClient client, GroupHuntGroupConsolidatedAddInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Delete a Hunt Group instance from a group.
    /// 
    /// If UnassignPhoneNumbersLevel is set to 'Group', the user's primary phone number, fax number and any alternate numbers, will be un-assigned from the group if the command is executed by a service provider administrator or above.
    /// When set to 'Service Provider', they will be un-assigned from the group and service provider if the command is executed by a provisioning administrator or above.
    /// When omitted, the number(s) will be left assigned to the group.
    /// An ErrorResponse will be returned if any number cannot be unassigned because of insufficient privilege.
    /// 
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupHuntGroupConsolidatedDeleteInstanceRequest(this OcipClient client, GroupHuntGroupConsolidatedDeleteInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request to modify a Hunt Group instance.
    /// 
    /// When phone numbers are un-assigned from the user, the unused numbers may be un-assigned from the group and service provider. If UnassignPhoneNumbersLevel is set to 'Group', the user's primary phone number, fax number and any alternate numbers, will be un-assigned from the group if the command is executed by a service provider administrator or above.
    /// When set to 'Service Provider', they will be un-assigned from the group and service provider if the command is executed by a provisioning administrator or above.
    /// When omitted, the number(s) will be left assigned to the group.
    /// An ErrorResponse will be returned if any number cannot be unassigned because of insufficient privilege.
    /// 
    /// If the phoneNumber has not been assigned to the group and addPhoneNumberToGroup is set to true, it will be added to group if needed if the command is executed by a service provider administrator and above. The command will fail otherwise.
    /// 
    /// The response is either SuccessResponse or ErrorResponse.
    /// The following elements are only used in AS data mode:
    /// useSystemHuntGroupCLIDSetting
    /// includeHuntGroupNameInCLID
    /// </summary>
    public static async Task<SuccessResponse> GroupHuntGroupConsolidatedModifyInstanceRequest(this OcipClient client, GroupHuntGroupConsolidatedModifyInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Delete a Hunt Group instance from a group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupHuntGroupDeleteInstanceRequest(this OcipClient client, GroupHuntGroupDeleteInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Get a list of users that can be assigned to a Hunt Group group.
    /// Searching for users by group only makes sense when the hunt group is part of an Enterprise.
    /// The response is either GroupHuntGroupGetAvailableUserListResponse or ErrorResponse.
    /// </summary>
    public static async Task<GroupHuntGroupGetAvailableUserListResponse> GroupHuntGroupGetAvailableUserListRequest(this OcipClient client, GroupHuntGroupGetAvailableUserListRequest request) {
        return await client.Call(request) as GroupHuntGroupGetAvailableUserListResponse;
    }

    /// <summary>
    /// Get a list of users that can be assigned to a Hunt Group group.
    /// Searching for users by group only makes sense when the hunt group is part of an Enterprise.
    /// 
    /// A limitation to the search by DN activation exists when the Number Activation mode is set to
    /// Off. In this case DNs not assigned to users are never returned by queries with the
    /// "dnActivationSearchCriteria" included.
    /// 
    /// The response is either GroupHuntGroupGetAvailableUserPagedSortedListResponse or ErrorResponse.
    /// If no sortOrder is included, the response is sorted by User Id ascending by default.
    /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1 by
    /// default, and the responsePageSize will be set to the maximum responsePageSize by default.
    /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is
    /// included. Then the search criteria are logically ORed together.
    /// </summary>
    public static async Task<GroupHuntGroupGetAvailableUserPagedSortedListResponse> GroupHuntGroupGetAvailableUserPagedSortedListRequest(this OcipClient client, GroupHuntGroupGetAvailableUserPagedSortedListRequest request) {
        return await client.Call(request) as GroupHuntGroupGetAvailableUserPagedSortedListResponse;
    }

    /// <summary>
    /// Get a list of Hunt Group instances within a group.
    /// The response is either GroupHuntGroupGetInstanceListResponse or ErrorResponse.
    /// It is possible to get the instances within a specified department.
    /// </summary>
    public static async Task<GroupHuntGroupGetInstanceListResponse> GroupHuntGroupGetInstanceListRequest(this OcipClient client, GroupHuntGroupGetInstanceListRequest request) {
        return await client.Call(request) as GroupHuntGroupGetInstanceListResponse;
    }

    /// <summary>
    /// Get a list of Hunt Group instances within a group.
    /// The response is either GroupHuntGroupGetInstancePagedSortedListResponse or ErrorResponse.
    /// It is possible to get the instances within a specified department.
    /// 
    /// The department in both the search criteria and sort by fields refer to the department to which
    /// the dn belongs.
    /// If no sortOrder is included, the response is sorted by User Id ascending by default.
    /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1 by
    /// default, and the responsePageSize will be set to the maximum responsePageSize by default.
    /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is
    /// included. Then the search criteria are logically ORed together.
    /// </summary>
    public static async Task<GroupHuntGroupGetInstancePagedSortedListResponse> GroupHuntGroupGetInstancePagedSortedListRequest(this OcipClient client, GroupHuntGroupGetInstancePagedSortedListRequest request) {
        return await client.Call(request) as GroupHuntGroupGetInstancePagedSortedListResponse;
    }

    /// <summary>
    /// Request to get all the information of a Hunt Group instance.
    /// The response is either GroupHuntGroupGetInstanceResponse20 or ErrorResponse.
    /// </summary>
    public static async Task<GroupHuntGroupGetInstanceResponse20> GroupHuntGroupGetInstanceRequest20(this OcipClient client, GroupHuntGroupGetInstanceRequest20 request) {
        return await client.Call(request) as GroupHuntGroupGetInstanceResponse20;
    }

    /// <summary>
    /// Request to set the active status of Hunt Group instances.
    /// The response is either SuccessResponse or ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> GroupHuntGroupModifyActiveInstanceListRequest(this OcipClient client, GroupHuntGroupModifyActiveInstanceListRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request to modify a Hunt Group instance.
    /// The response is either SuccessResponse or ErrorResponse.
    /// The following elements are only used in AS data mode:
    /// useSystemHuntGroupCLIDSetting
    /// includeHuntGroupNameInCLID
    /// applyGroupBusyWhenTerminatingToAgent
    /// networkClassOfService
    /// </summary>
    public static async Task<SuccessResponse> GroupHuntGroupModifyInstanceRequest(this OcipClient client, GroupHuntGroupModifyInstanceRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request to modify the weighted call distribution of a Hunt Group instance.
    /// The response is either SuccessResponse or ErrorResponse.
    /// NOTE: Prior to release 14, any agents who were not in the list kept their
    /// existing weight setting. In release 14, any agents who are not in the list
    /// will have their weight set to 0.
    /// </summary>
    public static async Task<SuccessResponse> GroupHuntGroupModifyInstanceWeightedCallDistributionRequest(this OcipClient client, GroupHuntGroupModifyInstanceWeightedCallDistributionRequest request) {
        return await client.Call(request) as SuccessResponse;
    }

    /// <summary>
    /// Request the system level data associated with Hunt Group.
    /// The response is either a SystemHuntGroupGetResponse21 or an
    /// ErrorResponse.
    /// </summary>
    public static async Task<SystemHuntGroupGetResponse21> SystemHuntGroupGetRequest21(this OcipClient client, SystemHuntGroupGetRequest21 request) {
        return await client.Call(request) as SystemHuntGroupGetResponse21;
    }

    /// <summary>
    /// Modify the system level data associated with Hunt Group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// </summary>
    public static async Task<SuccessResponse> SystemHuntGroupModifyRequest21(this OcipClient client, SystemHuntGroupModifyRequest21 request) {
        return await client.Call(request) as SuccessResponse;
    }


}
}
