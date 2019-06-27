using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceGroupPagingExtensions
    {

        /// <summary>
        /// Add a Group Paging instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingAddInstanceRequest(this OcipClient client, GroupGroupPagingAddInstanceRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add originator(s) to a paging group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingAddOriginatorListRequest(this OcipClient client, GroupGroupPagingAddOriginatorListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add target(s) to a paging group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingAddTargetListRequest(this OcipClient client, GroupGroupPagingAddTargetListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Group Paging instance from a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingDeleteInstanceRequest(this OcipClient client, GroupGroupPagingDeleteInstanceRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete originator(s) from a paging group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingDeleteOriginatorListRequest(this OcipClient client, GroupGroupPagingDeleteOriginatorListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete target(s) from a paging group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingDeleteTargetListRequest(this OcipClient client, GroupGroupPagingDeleteTargetListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a list of users that can be assigned as originators to a given paging group.
        /// Searching for users by group only makes sense when the paging group is part of an Enterprise.
        /// The response is either GroupGroupPagingGetAvailableOriginatorListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupGroupPagingGetAvailableOriginatorListResponse> GroupGroupPagingGetAvailableOriginatorListRequest(this OcipClient client, GroupGroupPagingGetAvailableOriginatorListRequest request)
        {
            return await client.Call(request) as GroupGroupPagingGetAvailableOriginatorListResponse;
        }

        /// <summary>
        /// Get a list of users that can be assigned as targets to a given paging group.
        /// Searching for users by group only makes sense when the paging group is part of an Enterprise.
        /// The response is either GroupGroupPagingGetAvailableTargetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupGroupPagingGetAvailableTargetListResponse> GroupGroupPagingGetAvailableTargetListRequest(this OcipClient client, GroupGroupPagingGetAvailableTargetListRequest request)
        {
            return await client.Call(request) as GroupGroupPagingGetAvailableTargetListResponse;
        }

        /// <summary>
        /// Get a list of Paging Groups instances within a group.
        /// The response is either GroupGroupPagingGetInstanceListResponse or ErrorResponse.
        /// It is possible to get the instances within a specified department.
        /// </summary>
        public static async Task<GroupGroupPagingGetInstanceListResponse> GroupGroupPagingGetInstanceListRequest(this OcipClient client, GroupGroupPagingGetInstanceListRequest request)
        {
            return await client.Call(request) as GroupGroupPagingGetInstanceListResponse;
        }

        /// <summary>
        /// Request to get all the information of a Group Paging instance.
        /// The response is either GroupGroupPagingGetInstanceResponse19sp1 or ErrorResponse.
        /// </summary>
        public static async Task<GroupGroupPagingGetInstanceResponse19sp1> GroupGroupPagingGetInstanceRequest19sp1(this OcipClient client, GroupGroupPagingGetInstanceRequest19sp1 request)
        {
            return await client.Call(request) as GroupGroupPagingGetInstanceResponse19sp1;
        }

        /// <summary>
        /// Get a list of originators assigned to a paging group.
        /// The response is either a GroupGroupPagingGetOriginatorListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupGroupPagingGetOriginatorListResponse> GroupGroupPagingGetOriginatorListRequest(this OcipClient client, GroupGroupPagingGetOriginatorListRequest request)
        {
            return await client.Call(request) as GroupGroupPagingGetOriginatorListResponse;
        }

        /// <summary>
        /// Get a list of targets assigned to a paging group.
        /// The response is either a GroupGroupPagingGetTargetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupGroupPagingGetTargetListResponse> GroupGroupPagingGetTargetListRequest(this OcipClient client, GroupGroupPagingGetTargetListRequest request)
        {
            return await client.Call(request) as GroupGroupPagingGetTargetListResponse;
        }

        /// <summary>
        /// Request to set the active status of Group Paging instances.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingModifyActiveInstanceListRequest(this OcipClient client, GroupGroupPagingModifyActiveInstanceListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Group Paging instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingModifyInstanceRequest(this OcipClient client, GroupGroupPagingModifyInstanceRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the originator list for a paging group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingModifyOriginatorListRequest(this OcipClient client, GroupGroupPagingModifyOriginatorListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the target list for a paging group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingModifyTargetListRequest(this OcipClient client, GroupGroupPagingModifyTargetListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the maximum number of target users per paging group configured for a group.
        /// The response is either a GroupGroupPagingTargetsCapacityGetResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<GroupGroupPagingTargetsCapacityGetResponse> GroupGroupPagingTargetsCapacityGetRequest(this OcipClient client, GroupGroupPagingTargetsCapacityGetRequest request)
        {
            return await client.Call(request) as GroupGroupPagingTargetsCapacityGetResponse;
        }

        /// <summary>
        /// Modify the maximum number of target users per paging group configured for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingTargetsCapacityModifyRequest(this OcipClient client, GroupGroupPagingTargetsCapacityModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the maximum number of target users per paging group configured for a service provider.
        /// The response is either a ServiceProviderGroupPagingTargetsCapacityGetResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderGroupPagingTargetsCapacityGetResponse> ServiceProviderGroupPagingTargetsCapacityGetRequest(this OcipClient client, ServiceProviderGroupPagingTargetsCapacityGetRequest request)
        {
            return await client.Call(request) as ServiceProviderGroupPagingTargetsCapacityGetResponse;
        }

        /// <summary>
        /// Modify the maximum number of target users per paging group configured for a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderGroupPagingTargetsCapacityModifyRequest(this OcipClient client, ServiceProviderGroupPagingTargetsCapacityModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the list of all the Paging Groups a user was assigned as an originator.
        /// The response is either a UserGroupPagingGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserGroupPagingGetListResponse> UserGroupPagingGetListRequest(this OcipClient client, UserGroupPagingGetListRequest request)
        {
            return await client.Call(request) as UserGroupPagingGetListResponse;
        }


    }
}
