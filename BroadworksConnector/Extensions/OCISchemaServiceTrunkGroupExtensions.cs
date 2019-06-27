using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceTrunkGroupExtensions
    {

        /// <summary>
        /// Request to add an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkAddRequest21(this OcipClient client, EnterpriseEnterpriseTrunkAddRequest21 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add users to an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkAddUserListRequest(this OcipClient client, EnterpriseEnterpriseTrunkAddUserListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkDeleteRequest(this OcipClient client, EnterpriseEnterpriseTrunkDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete users from an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkDeleteUserListRequest(this OcipClient client, EnterpriseEnterpriseTrunkDeleteUserListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add users to an enterprise trunk in an enterprise. If the user is already assigned to another enterprise trunk,
        /// it will be unassigned from the old enterprise trunk and assigned to the new enterprise trunk specified in this request.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkForceAssignUserListRequest(this OcipClient client, EnterpriseEnterpriseTrunkForceAssignUserListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the list of all available trunk groups defined in an enterprise.  It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListResponse> EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListRequest(this OcipClient client, EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListRequest request)
        {
            return await client.Call(request) as EnterpriseEnterpriseTrunkGetAvailableTrunkGroupListResponse;
        }

        /// <summary>
        /// Request the list of users that are available to be added to an enterprise trunk.  This list contains users in the enterprise that are trunk users and not already assigned to an enterprise trunk.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either an EnterpriseEnterpriseTrunkGetAvailableUserListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseEnterpriseTrunkGetAvailableUserListResponse> EnterpriseEnterpriseTrunkGetAvailableUserListRequest(this OcipClient client, EnterpriseEnterpriseTrunkGetAvailableUserListRequest request)
        {
            return await client.Call(request) as EnterpriseEnterpriseTrunkGetAvailableUserListResponse;
        }

        /// <summary>
        /// Request to get the list of all enterprise trunks defined in an enterprise.
        /// The response is either a EnterpriseEnterpriseTrunkGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseEnterpriseTrunkGetListResponse> EnterpriseEnterpriseTrunkGetListRequest(this OcipClient client, EnterpriseEnterpriseTrunkGetListRequest request)
        {
            return await client.Call(request) as EnterpriseEnterpriseTrunkGetListResponse;
        }

        /// <summary>
        /// Request to get an enterprise trunk
        /// The response is either an EnterpriseEnterpriseTrunkGetResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseEnterpriseTrunkGetResponse21> EnterpriseEnterpriseTrunkGetRequest21(this OcipClient client, EnterpriseEnterpriseTrunkGetRequest21 request)
        {
            return await client.Call(request) as EnterpriseEnterpriseTrunkGetResponse21;
        }

        /// <summary>
        /// Request the list of users in an enterprise trunk.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a EnterpriseEnterpriseTrunkGetUserListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseEnterpriseTrunkGetUserListResponse> EnterpriseEnterpriseTrunkGetUserListRequest(this OcipClient client, EnterpriseEnterpriseTrunkGetUserListRequest request)
        {
            return await client.Call(request) as EnterpriseEnterpriseTrunkGetUserListResponse;
        }

        /// <summary>
        /// Request to modify an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkModifyRequest(this OcipClient client, EnterpriseEnterpriseTrunkModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEnterpriseTrunkAddRequest21(this OcipClient client, GroupEnterpriseTrunkAddRequest21 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add users to an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEnterpriseTrunkAddUserListRequest(this OcipClient client, GroupEnterpriseTrunkAddUserListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEnterpriseTrunkDeleteRequest(this OcipClient client, GroupEnterpriseTrunkDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete users from an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEnterpriseTrunkDeleteUserListRequest(this OcipClient client, GroupEnterpriseTrunkDeleteUserListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add users to an enterprise trunk in a group. If the user is already assigned to another enterprise trunk,
        /// it will be unassigned from the old enterprise trunk and assigned to the new enterprise trunk specified in this request.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEnterpriseTrunkForceAssignUserListRequest(this OcipClient client, GroupEnterpriseTrunkForceAssignUserListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the list of all available trunk groups defined in a group.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a GroupEnterpriseTrunkGetAvailableTrunkGroupListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupEnterpriseTrunkGetAvailableTrunkGroupListResponse> GroupEnterpriseTrunkGetAvailableTrunkGroupListRequest(this OcipClient client, GroupEnterpriseTrunkGetAvailableTrunkGroupListRequest request)
        {
            return await client.Call(request) as GroupEnterpriseTrunkGetAvailableTrunkGroupListResponse;
        }

        /// <summary>
        /// Request the list of users that are available to be added to an enterprise trunk.  This list contains users in the group that are trunk users and not already assigned to an enterprise trunk.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a GroupEnterpriseTrunkGetAvailableUserListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupEnterpriseTrunkGetAvailableUserListResponse> GroupEnterpriseTrunkGetAvailableUserListRequest(this OcipClient client, GroupEnterpriseTrunkGetAvailableUserListRequest request)
        {
            return await client.Call(request) as GroupEnterpriseTrunkGetAvailableUserListResponse;
        }

        /// <summary>
        /// Request to get the list of all enterprise trunks defined in a group.
        /// The response is either a GroupEnterpriseTrunkGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupEnterpriseTrunkGetListResponse> GroupEnterpriseTrunkGetListRequest(this OcipClient client, GroupEnterpriseTrunkGetListRequest request)
        {
            return await client.Call(request) as GroupEnterpriseTrunkGetListResponse;
        }

        /// <summary>
        /// Request to get an enterprise trunk
        /// The response is either an GroupEnterpriseTrunkGetResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupEnterpriseTrunkGetResponse21> GroupEnterpriseTrunkGetRequest21(this OcipClient client, GroupEnterpriseTrunkGetRequest21 request)
        {
            return await client.Call(request) as GroupEnterpriseTrunkGetResponse21;
        }

        /// <summary>
        /// Request the list of users in an enterprise trunk.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a GroupEnterpriseTrunkGetUserListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupEnterpriseTrunkGetUserListResponse> GroupEnterpriseTrunkGetUserListRequest(this OcipClient client, GroupEnterpriseTrunkGetUserListRequest request)
        {
            return await client.Call(request) as GroupEnterpriseTrunkGetUserListResponse;
        }

        /// <summary>
        /// Request to modify an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupEnterpriseTrunkModifyRequest(this OcipClient client, GroupEnterpriseTrunkModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a Trunk Group instance to a group.
        /// The command will fail if enableNetworkAddressIdentity is set to
        /// true and administrator is not System/Provisioning level administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Following attributes are only used in IMS mode:
        /// implicitRegistrationSetSupportPolicy
        /// useSystemImplicitRegistrationSetSupportPolicy
        /// sipIdentityForPilotAndProxyTrunkModesPolicy
        /// useSystemSIPIdentityForPilotAndProxyTrunkModesPolicy
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupAddInstanceRequest21(this OcipClient client, GroupTrunkGroupAddInstanceRequest21 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a Trunk Group instance to a group.
        /// The command will fail if enableNetworkAddressIdentity is set to
        /// true and administrator is not System/Provisioning level administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Following attributes are only used in IMS mode:
        /// implicitRegistrationSetSupportPolicy
        /// useSystemImplicitRegistrationSetSupportPolicy
        /// sipIdentityForPilotAndProxyTrunkModesPolicy
        /// useSystemSIPIdentityForPilotAndProxyTrunkModesPolicy
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupAddInstanceRequest22(this OcipClient client, GroupTrunkGroupAddInstanceRequest22 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Trunk Group Instance from a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupDeleteInstanceRequest14sp4(this OcipClient client, GroupTrunkGroupDeleteInstanceRequest14sp4 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a list of hosted users that can be assigned to a Trunk Group.
        /// The response is either GroupTrunkGroupGetAvailableHostedUserListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupGetAvailableHostedUserListResponse> GroupTrunkGroupGetAvailableHostedUserListRequest(this OcipClient client, GroupTrunkGroupGetAvailableHostedUserListRequest request)
        {
            return await client.Call(request) as GroupTrunkGroupGetAvailableHostedUserListResponse;
        }

        /// <summary>
        /// Get a list of Trunk Groups for the group or enterprise.
        /// It is possible to restrict the results to a particular department, or expand the list to the entire enterprise.
        /// The response is either a GroupTrunkGroupGetInstanceListResponse14sp4 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceListResponse14sp4> GroupTrunkGroupGetInstanceListRequest14sp4(this OcipClient client, GroupTrunkGroupGetInstanceListRequest14sp4 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceListResponse14sp4;
        }

        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse23 or an ErrorResponse.
        /// The response contains a hosted user table with column headings: "User Id", "Last Name",
        /// "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number", "Extension",
        /// "Department", "Email Address".
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceResponse23> GroupTrunkGroupGetInstanceRequest23(this OcipClient client, GroupTrunkGroupGetInstanceRequest23 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceResponse23;
        }

        /// <summary>
        /// Get a list of user's on a Trunk Group Instance.
        /// The response is either a GroupTrunkGroupGetInstanceUserListResponse14sp4 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceUserListResponse14sp4> GroupTrunkGroupGetInstanceUserListRequest14sp4(this OcipClient client, GroupTrunkGroupGetInstanceUserListRequest14sp4 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceUserListResponse14sp4;
        }

        /// <summary>
        /// Get the maximum and bursting maximum permissible active trunk group calls for the group.
        /// The response is either a GroupTrunkGroupGetResponse14sp9 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupGetResponse14sp9> GroupTrunkGroupGetRequest14sp9(this OcipClient client, GroupTrunkGroupGetRequest14sp9 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetResponse14sp9;
        }

        /// <summary>
        /// Modify a Trunk Group Instance in a group.
        /// The access device cannot be modified or cleared if there are any users assigned to the Trunk Group.
        /// The command will fail if enableNetworkAddressIdentity is set and
        /// administrator is not System/Provisioning level administrator.
        /// Following attributes are only used in IMS mode:
        /// implicitRegistrationSetSupportPolicy
        /// useSystemImplicitRegistrationSetSupportPolicy
        /// sipIdentityForPilotAndProxyTrunkModesPolicy
        /// useSystemSIPIdentityForPilotAndProxyTrunkModesPolicy
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupModifyInstanceRequest20sp1(this OcipClient client, GroupTrunkGroupModifyInstanceRequest20sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the maximum and bursting maximum permissible active Trunk Group calls for the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupModifyRequest14sp9(this OcipClient client, GroupTrunkGroupModifyRequest14sp9 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of trunk group level successful SIP OPTIONS message respoonse status codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupOptionsMessageResponseStatusCodeAddListRequest(this OcipClient client, GroupTrunkGroupOptionsMessageResponseStatusCodeAddListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a user creation task for a trunk group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupUserCreationTaskAddRequest14sp4(this OcipClient client, GroupTrunkGroupUserCreationTaskAddRequest14sp4 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a user creation task for a trunk group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupUserCreationTaskDeleteRequest14sp4(this OcipClient client, GroupTrunkGroupUserCreationTaskDeleteRequest14sp4 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the list of user creation tasks for a trunk group.
        /// The response is either GroupTrunkGroupUserCreationTaskGetListResponse14sp4 or ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupUserCreationTaskGetListResponse14sp4> GroupTrunkGroupUserCreationTaskGetListRequest14sp4(this OcipClient client, GroupTrunkGroupUserCreationTaskGetListRequest14sp4 request)
        {
            return await client.Call(request) as GroupTrunkGroupUserCreationTaskGetListResponse14sp4;
        }

        /// <summary>
        /// Request the details of a specified user creation task for a trunk group.
        /// The response is either GroupTrunkGroupUserCreationTaskGetResponse14sp4 or ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupUserCreationTaskGetResponse14sp4> GroupTrunkGroupUserCreationTaskGetRequest14sp4(this OcipClient client, GroupTrunkGroupUserCreationTaskGetRequest14sp4 request)
        {
            return await client.Call(request) as GroupTrunkGroupUserCreationTaskGetResponse14sp4;
        }

        /// <summary>
        /// Get the maximum and bursting maximum permissible active Trunk Group calls for the service provider.
        /// The response is either a ServiceProviderTrunkGroupGetResponse14sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderTrunkGroupGetResponse14sp1> ServiceProviderTrunkGroupGetRequest14sp1(this OcipClient client, ServiceProviderTrunkGroupGetRequest14sp1 request)
        {
            return await client.Call(request) as ServiceProviderTrunkGroupGetResponse14sp1;
        }

        /// <summary>
        /// Modify the maximum and bursting maximum permissible active Trunk Group calls for the service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderTrunkGroupModifyRequest(this OcipClient client, ServiceProviderTrunkGroupModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the system level data associated with the Trunk Group service.
        /// The response is either SystemTrunkGroupGetResponse23 or ErrorResponse.
        /// </summary>
        public static async Task<SystemTrunkGroupGetResponse23> SystemTrunkGroupGetRequest23(this OcipClient client, SystemTrunkGroupGetRequest23 request)
        {
            return await client.Call(request) as SystemTrunkGroupGetResponse23;
        }

        /// <summary>
        /// Modify the system level data associated with the Trunk Group Service.
        /// Following attributes are only used in IMS mode. The values are saved if specified not in IMS mode:
        /// implicitRegistrationSetSupportPolicy
        /// sipIdentityForPilotAndProxyTrunkModesPolicy
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTrunkGroupModifyRequest(this OcipClient client, SystemTrunkGroupModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of system level successful SIP OPTIONS message respoonse status codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTrunkGroupOptionsMessageResponseStatusCodeAddListRequest(this OcipClient client, SystemTrunkGroupOptionsMessageResponseStatusCodeAddListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of system level successful SIP OPTIONS message respoonse status codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTrunkGroupOptionsMessageResponseStatusCodeDeleteListRequest(this OcipClient client, SystemTrunkGroupOptionsMessageResponseStatusCodeDeleteListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the list of system level successful SIP OPTIONS message respoonse status codes.
        /// The response is either SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse> SystemTrunkGroupOptionsMessageResponseStatusCodeGetListRequest(this OcipClient client, SystemTrunkGroupOptionsMessageResponseStatusCodeGetListRequest request)
        {
            return await client.Call(request) as SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse;
        }

        /// <summary>
        /// Get the list of user creation tasks in the system.
        /// The response is either SystemTrunkGroupUserCreationTaskGetListResponse14sp4 or ErrorResponse.
        /// </summary>
        public static async Task<SystemTrunkGroupUserCreationTaskGetListResponse14sp4> SystemTrunkGroupUserCreationTaskGetListRequest14sp4(this OcipClient client, SystemTrunkGroupUserCreationTaskGetListRequest14sp4 request)
        {
            return await client.Call(request) as SystemTrunkGroupUserCreationTaskGetListResponse14sp4;
        }


    }
}
