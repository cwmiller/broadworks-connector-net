using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaServiceRouteListExtensions
    {

        /// <summary>
        /// Request a list of number prefixes that are assigned to an enterprise and still available for assignment to users within the enterprise.
        /// The response is either EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse> EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest(this OcipClient client, EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest request)
        {
            return await client.Call(request) as EnterpriseRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse;
        }

        /// <summary>
        /// Request a summary table of all enterprise trunk number prefixes in the enterprise.
        /// The response is either EnterpriseRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse> EnterpriseRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest(this OcipClient client, EnterpriseRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest request)
        {
            return await client.Call(request) as EnterpriseRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse;
        }

        /// <summary>
        /// Request a list of number ranges that are assigned to an enterprise and still available for assignment to users within the enterprise.
        /// The response is either EnterpriseRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse> EnterpriseRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest(this OcipClient client, EnterpriseRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest request)
        {
            return await client.Call(request) as EnterpriseRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse;
        }

        /// <summary>
        /// Request a summary table of all enterprise trunk number ranges in the enterprise.
        /// The response is either EnterpriseRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse or ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse> EnterpriseRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest(this OcipClient client, EnterpriseRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest request)
        {
            return await client.Call(request) as EnterpriseRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse;
        }

        /// <summary>
        /// Assign a list of service provider number prefixes to a group.
        /// The number prefixes must have previously been added to the service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRouteListEnterpriseTrunkNumberPrefixAssignListRequest(this OcipClient client, GroupRouteListEnterpriseTrunkNumberPrefixAssignListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request a list of number prefixess that are assigned to a group and still available for assignment to users within the group.
        /// The response is either GroupRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse> GroupRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest(this OcipClient client, GroupRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest request)
        {
            return await client.Call(request) as GroupRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse;
        }

        /// <summary>
        /// Get the list of assigned and unassigned enterprise trunknumber prefixes in a group.
        /// The response is either GroupRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse> GroupRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest(this OcipClient client, GroupRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest request)
        {
            return await client.Call(request) as GroupRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse;
        }

        /// <summary>
        /// Unassign a list of service provider number prefixes from a group. The number prefixes then become available for assignment to other groups.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRouteListEnterpriseTrunkNumberPrefixUnassignListRequest(this OcipClient client, GroupRouteListEnterpriseTrunkNumberPrefixUnassignListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of service provider number ranges to a group.
        /// The number ranges must have previously been added to the service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRouteListEnterpriseTrunkNumberRangeAssignListRequest(this OcipClient client, GroupRouteListEnterpriseTrunkNumberRangeAssignListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request a list of number ranges that are assigned to a group and still available for assignment to users within the group.
        /// The response is either GroupRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse> GroupRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest(this OcipClient client, GroupRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest request)
        {
            return await client.Call(request) as GroupRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse;
        }

        /// <summary>
        /// Get the list of assigned and unassigned enterprise trunknumber ranges in a group.
        /// The response is either GroupRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse> GroupRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest(this OcipClient client, GroupRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest request)
        {
            return await client.Call(request) as GroupRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse;
        }

        /// <summary>
        /// Unassign a list of service provider number ranges from a group. The number ranges then become available for assignment to other groups.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRouteListEnterpriseTrunkNumberRangeUnassignListRequest(this OcipClient client, GroupRouteListEnterpriseTrunkNumberRangeUnassignListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Activate number prefixes in a service provider.
        /// It is not an error to activate an already activated number prefix.
        /// The command fails if executed when system level enterprise trunk number prefix activation is disabled.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberPrefixActivateListRequest(this OcipClient client, ServiceProviderRouteListEnterpriseTrunkNumberPrefixActivateListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add number prefixes to a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberPrefixAddListRequest(this OcipClient client, ServiceProviderRouteListEnterpriseTrunkNumberPrefixAddListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Deactivate number prefixes in a service provider.
        /// It is not an error to deactivate an already deactivated number prefix.
        /// The command fails if executed when system level enterprise trunk number prefix activation is disabled.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberPrefixDeactivateListRequest(this OcipClient client, ServiceProviderRouteListEnterpriseTrunkNumberPrefixDeactivateListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete number prefixes from a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberPrefixDeleteListRequest(this OcipClient client, ServiceProviderRouteListEnterpriseTrunkNumberPrefixDeleteListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request a list of available number prefixes not yet assigned to any group.
        /// The response is either ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse> ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest(this OcipClient client, ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetAvailableListRequest request)
        {
            return await client.Call(request) as ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse;
        }

        /// <summary>
        /// Request a summary table of all enterprise trunk number prefixes in the service provider.
        /// The response is either ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse> ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest(this OcipClient client, ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest request)
        {
            return await client.Call(request) as ServiceProviderRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse;
        }

        /// <summary>
        /// Activate number ranges in a service provider.
        /// It is not an error to activate an already activated number range.
        /// The command fails if executed when system level enterprise trunk number range activation is disabled.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberRangeActivateListRequest(this OcipClient client, ServiceProviderRouteListEnterpriseTrunkNumberRangeActivateListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add number ranges to a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberRangeAddListRequest(this OcipClient client, ServiceProviderRouteListEnterpriseTrunkNumberRangeAddListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Deactivate number ranges in a service provider.
        /// It is not an error to deactivate an already deactivated number range.
        /// The command fails if executed when system level enterprise trunk number range activation is disabled.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberRangeDeactivateListRequest(this OcipClient client, ServiceProviderRouteListEnterpriseTrunkNumberRangeDeactivateListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete number ranges from a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberRangeDeleteListRequest(this OcipClient client, ServiceProviderRouteListEnterpriseTrunkNumberRangeDeleteListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request a list of available number ranges not yet assigned to any group.
        /// The response is either ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse> ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest(this OcipClient client, ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListRequest request)
        {
            return await client.Call(request) as ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse;
        }

        /// <summary>
        /// Request a summary table of all enterprise trunk number ranges in the service provider.
        /// The response is either ServiceProviderRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse> ServiceProviderRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest(this OcipClient client, ServiceProviderRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest request)
        {
            return await client.Call(request) as ServiceProviderRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse;
        }

        /// <summary>
        /// Request a summary table of all enterprise trunk prefixes in the system.
        /// If resellerId is specified, only the prefixes assigned to the enterprise/service provider within
        /// the given reseller are returned.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// 
        /// The response is either SystemRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse> SystemRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest(this OcipClient client, SystemRouteListEnterpriseTrunkNumberPrefixGetSummaryListRequest request)
        {
            return await client.Call(request) as SystemRouteListEnterpriseTrunkNumberPrefixGetSummaryListResponse;
        }

        /// <summary>
        /// Request a summary table of all enterprise trunk number ranges in the system.
        /// If resellerId is specified, the number ranges assigned to the enterprises/service providers
        /// within the reseller are returned.
        /// If reseller administrator sends the request and resellerId is not specified, the administrator's resellerId is used.
        /// 
        /// The response is either SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse> SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest(this OcipClient client, SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListRequest request)
        {
            return await client.Call(request) as SystemRouteListEnterpriseTrunkNumberRangeGetSummaryListResponse;
        }

        /// <summary>
        /// Get the route list setting and the list of number ranges assigned to a user.
        /// The response is either UserRouteListGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<UserRouteListGetResponse22> UserRouteListGetRequest22(this OcipClient client, UserRouteListGetRequest22 request)
        {
            return await client.Call(request) as UserRouteListGetResponse22;
        }

        /// <summary>
        /// Modify the route list setting and the list of number ranges and number prefixes assigned to a user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserRouteListModifyRequest(this OcipClient client, UserRouteListModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
