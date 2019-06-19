using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector.Ocip
{
    public static class OCISchemaDeprecatedExtensions
    {

        /// <summary>
        /// AuthenticationVerifyRequest is used to authenticate a user using the user Id and password.
        /// The response is a AuthenticationVerifyResponse or an ErrorResponse
        /// Replaced By: AuthenticationVerifyRequest14sp8
        /// </summary>
        public static async Task<AuthenticationVerifyResponse> AuthenticationVerifyRequest(this OcipClient client, AuthenticationVerifyRequest request)
        {
            return await client.Call(request) as AuthenticationVerifyResponse;
        }

        /// <summary>
        /// Request to get a session admission control group for the enterprise.
        /// The response is either an EnterpriseSessionAdmissionControlGroupGetResponse19sp1 or an ErrorResponse.
        /// 
        /// Replaced by: EnterpriseSessionAdmissionControlGroupGetRequest21sp1
        /// </summary>
        public static async Task<EnterpriseSessionAdmissionControlGroupGetResponse19sp1> EnterpriseSessionAdmissionControlGroupGetRequest19sp1(this OcipClient client, EnterpriseSessionAdmissionControlGroupGetRequest19sp1 request)
        {
            return await client.Call(request) as EnterpriseSessionAdmissionControlGroupGetResponse19sp1;
        }

        /// <summary>
        /// Request to get a session admission control group for the enterprise.
        /// The response is either an EnterpriseSessionAdmissionControlGroupGetResponse21sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseSessionAdmissionControlGroupGetResponse21sp1> EnterpriseSessionAdmissionControlGroupGetRequest21sp1(this OcipClient client, EnterpriseSessionAdmissionControlGroupGetRequest21sp1 request)
        {
            return await client.Call(request) as EnterpriseSessionAdmissionControlGroupGetResponse21sp1;
        }

        /// <summary>
        /// Request the enterprise level data associated with Voice VPN.
        /// The response is either a EnterpriseVoiceVPNGetResponse or an ErrorResponse.
        /// Replaced By: EnterpriseVoiceVPNGetRequest14sp3
        /// </summary>
        public static async Task<EnterpriseVoiceVPNGetResponse> EnterpriseVoiceVPNGetRequest(this OcipClient client, EnterpriseVoiceVPNGetRequest request)
        {
            return await client.Call(request) as EnterpriseVoiceVPNGetResponse;
        }

        /// <summary>
        /// Request to get the list of device files managed by the Device Management System, on a per-device profile
        /// basis.
        /// The response is either GroupAccessDeviceFileGetListResponse or ErrorResponse.
        /// Replaced By: GroupAccessDeviceFileGetListRequest14sp8
        /// </summary>
        public static async Task<GroupAccessDeviceFileGetListResponse> GroupAccessDeviceFileGetListRequest(this OcipClient client, GroupAccessDeviceFileGetListRequest request)
        {
            return await client.Call(request) as GroupAccessDeviceFileGetListResponse;
        }

        /// <summary>
        /// Request to get a group device profile file.
        /// The response is either GroupAccessDeviceFileGetResponse or ErrorResponse.
        /// Replaced By: GroupAccessDeviceFileGetRequest14sp8
        /// </summary>
        public static async Task<GroupAccessDeviceFileGetResponse> GroupAccessDeviceFileGetRequest(this OcipClient client, GroupAccessDeviceFileGetRequest request)
        {
            return await client.Call(request) as GroupAccessDeviceFileGetResponse;
        }

        /// <summary>
        /// Request to modify a specified group access device file.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By: GroupAccessDeviceFileModifyRequest14sp8
        /// </summary>
        public static async Task<SuccessResponse> GroupAccessDeviceFileModifyRequest(this OcipClient client, GroupAccessDeviceFileModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests the configuration of a specified group access device.
        /// The response is either GroupAccessDeviceGetResponse14 or ErrorResponse.
        /// Replaced By: GroupAccessDeviceGetRequest14sp3
        /// </summary>
        public static async Task<GroupAccessDeviceGetResponse14> GroupAccessDeviceGetRequest14(this OcipClient client, GroupAccessDeviceGetRequest14 request)
        {
            return await client.Call(request) as GroupAccessDeviceGetResponse14;
        }

        /// <summary>
        /// Requests the configuration of a specified group access device.
        /// The response is either GroupAccessDeviceGetResponse14sp3 or ErrorResponse.
        /// Replaced By: GroupAccessDeviceGetRequest14sp6
        /// </summary>
        public static async Task<GroupAccessDeviceGetResponse14sp3> GroupAccessDeviceGetRequest14sp3(this OcipClient client, GroupAccessDeviceGetRequest14sp3 request)
        {
            return await client.Call(request) as GroupAccessDeviceGetResponse14sp3;
        }

        /// <summary>
        /// Requests the Group administrator's policy settings.
        /// The response is either GroupAdminGetPolicyResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupAdminGetPolicyResponse> GroupAdminGetPolicyRequest(this OcipClient client, GroupAdminGetPolicyRequest request)
        {
            return await client.Call(request) as GroupAdminGetPolicyResponse;
        }

        /// <summary>
        /// Add a Call Center instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By: GroupCallCenterAddInstanceRequest14sp3
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterAddInstanceRequest14(this OcipClient client, GroupCallCenterAddInstanceRequest14 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Center instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By: GroupCallCenterAddInstanceRequest14sp9
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterAddInstanceRequest14sp3(this OcipClient client, GroupCallCenterAddInstanceRequest14sp3 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a call center's announcement settings.
        /// The response is either a GroupCallCenterGetAnnouncementResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetAnnouncementResponse> GroupCallCenterGetAnnouncementRequest(this OcipClient client, GroupCallCenterGetAnnouncementRequest request)
        {
            return await client.Call(request) as GroupCallCenterGetAnnouncementResponse;
        }

        /// <summary>
        /// Request to get all the information of a Call Center instance.
        /// The response is either GroupCallCenterGetInstanceResponse14 or ErrorResponse.
        /// Replaced By: GroupCallCenterGetInstanceRequest14sp3
        /// </summary>
        public static async Task<GroupCallCenterGetInstanceResponse14> GroupCallCenterGetInstanceRequest14(this OcipClient client, GroupCallCenterGetInstanceRequest14 request)
        {
            return await client.Call(request) as GroupCallCenterGetInstanceResponse14;
        }

        /// <summary>
        /// Request to get all the information of a Call Center instance.
        /// The response is either GroupCallCenterGetInstanceResponse14sp3 or ErrorResponse.
        /// Replaced By: GroupCallCenterGetInstanceRequest14sp9
        /// </summary>
        public static async Task<GroupCallCenterGetInstanceResponse14sp3> GroupCallCenterGetInstanceRequest14sp3(this OcipClient client, GroupCallCenterGetInstanceRequest14sp3 request)
        {
            return await client.Call(request) as GroupCallCenterGetInstanceResponse14sp3;
        }

        /// <summary>
        /// Get Call Center queue and agent statistics.
        /// The response is either GroupCallCenterGetInstanceStatisticsResponse13mp8 or ErrorResponse.
        /// Replaced By: GroupCallCenterGetInstanceStatisticsRequest14sp9
        /// </summary>
        public static async Task<GroupCallCenterGetInstanceStatisticsResponse13mp8> GroupCallCenterGetInstanceStatisticsRequest13mp8(this OcipClient client, GroupCallCenterGetInstanceStatisticsRequest13mp8 request)
        {
            return await client.Call(request) as GroupCallCenterGetInstanceStatisticsResponse13mp8;
        }

        /// <summary>
        /// Get a list of supervisors assigned to a call center.
        /// Only users in the same group or enterprise as this call center can
        /// successfully execute this request.
        /// The response is either a GroupCallCenterGetSupervisorListResponse
        /// or an ErrorResponse.
        /// Replaced By: GroupCallCenterSupervisorReportingGetRequest
        /// </summary>
        public static async Task<GroupCallCenterGetSupervisorListResponse> GroupCallCenterGetSupervisorListRequest(this OcipClient client, GroupCallCenterGetSupervisorListRequest request)
        {
            return await client.Call(request) as GroupCallCenterGetSupervisorListResponse;
        }

        /// <summary>
        /// Modify a call center's announcement settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyAnnouncementRequest(this OcipClient client, GroupCallCenterModifyAnnouncementRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Call Center statistics reporting frequency and destination.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By: GroupCallCenterModifyInstanceStatisticsReportingRequest14sp9
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyInstanceStatisticsReportingRequest(this OcipClient client, GroupCallCenterModifyInstanceStatisticsReportingRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Replaces a list of users as supervisors for a call center.
        /// Also allows the modification of the reporting server URL address.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Element "reportingServerURL"" will always be ignored.
        /// Replaced By: GroupCallCenterSupervisorReportingModifyRequest
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifySupervisorListRequest(this OcipClient client, GroupCallCenterModifySupervisorListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the calling line id settings for a group.
        /// The response is either a GroupCallingLineIdGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallingLineIdGetResponse> GroupCallingLineIdGetRequest(this OcipClient client, GroupCallingLineIdGetRequest request)
        {
            return await client.Call(request) as GroupCallingLineIdGetResponse;
        }

        /// <summary>
        /// Modify the calling line id settings for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallingLineIdModifyRequest(this OcipClient client, GroupCallingLineIdModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse14 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<GroupCallProcessingGetPolicyResponse14> GroupCallProcessingGetPolicyRequest14(this OcipClient client, GroupCallProcessingGetPolicyRequest14 request)
        {
            return await client.Call(request) as GroupCallProcessingGetPolicyResponse14;
        }

        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse14sp1 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<GroupCallProcessingGetPolicyResponse14sp1> GroupCallProcessingGetPolicyRequest14sp1(this OcipClient client, GroupCallProcessingGetPolicyRequest14sp1 request)
        {
            return await client.Call(request) as GroupCallProcessingGetPolicyResponse14sp1;
        }

        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse14sp4 or an
        /// ErrorResponse.
        /// Replaced By : GroupCallProcessingGetPolicyRequest15
        /// </summary>
        public static async Task<GroupCallProcessingGetPolicyResponse14sp4> GroupCallProcessingGetPolicyRequest14sp4(this OcipClient client, GroupCallProcessingGetPolicyRequest14sp4 request)
        {
            return await client.Call(request) as GroupCallProcessingGetPolicyResponse14sp4;
        }

        /// <summary>
        /// Modify the group level data associated with Call Processing Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By : GroupCallProcessingModifyPolicyRequest15
        /// </summary>
        public static async Task<SuccessResponse> GroupCallProcessingModifyPolicyRequest14(this OcipClient client, GroupCallProcessingModifyPolicyRequest14 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the list of device type files managed by the Device Management System, on a per-group
        /// basis.
        /// The response is either GroupDeviceTypeFileGetListResponse or ErrorResponse.
        /// Replaced By: GroupDeviceTypeFileGetListRequest14sp8
        /// </summary>
        public static async Task<GroupDeviceTypeFileGetListResponse> GroupDeviceTypeFileGetListRequest(this OcipClient client, GroupDeviceTypeFileGetListRequest request)
        {
            return await client.Call(request) as GroupDeviceTypeFileGetListResponse;
        }

        /// <summary>
        /// Request to get a group device type file.
        /// The response is either GroupDeviceTypeFileGetResponse or ErrorResponse.
        /// Replaced By: GroupDeviceTypeFileGetRequest14sp8
        /// </summary>
        public static async Task<GroupDeviceTypeFileGetResponse> GroupDeviceTypeFileGetRequest(this OcipClient client, GroupDeviceTypeFileGetRequest request)
        {
            return await client.Call(request) as GroupDeviceTypeFileGetResponse;
        }

        /// <summary>
        /// Request to modify a specified device type file for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By: GroupDeviceTypeFileModifyRequest14sp8
        /// </summary>
        public static async Task<SuccessResponse> GroupDeviceTypeFileModifyRequest(this OcipClient client, GroupDeviceTypeFileModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the list of feature access codes for a group.
        /// The response is either a GroupFeatureAccessCodeGetListResponse or an ErrorResponse.
        /// Replaced by: GroupFeatureAccessCodeGetRequest
        /// </summary>
        public static async Task<GroupFeatureAccessCodeGetListResponse> GroupFeatureAccessCodeGetListRequest(this OcipClient client, GroupFeatureAccessCodeGetListRequest request)
        {
            return await client.Call(request) as GroupFeatureAccessCodeGetListResponse;
        }

        /// <summary>
        /// Modify a list of feature access codes for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by: GroupFeatureAccessCodeModifyRequest
        /// </summary>
        public static async Task<SuccessResponse> GroupFeatureAccessCodeModifyListRequest(this OcipClient client, GroupFeatureAccessCodeModifyListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the profile for a group.
        /// The response is either a GroupGetResponse or an ErrorResponse.
        /// Replaced By: GroupGetRequest14sp7
        /// </summary>
        public static async Task<GroupGetResponse> GroupGetRequest(this OcipClient client, GroupGetRequest request)
        {
            return await client.Call(request) as GroupGetResponse;
        }

        /// <summary>
        /// Get the profile for a group.
        /// The response is either a GroupGetResponse14sp7 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupGetResponse14sp7> GroupGetRequest14sp7(this OcipClient client, GroupGetRequest14sp7 request)
        {
            return await client.Call(request) as GroupGetResponse14sp7;
        }

        /// <summary>
        /// Add a Music On Hold Instance to a department.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By: GroupMusicOnHoldAddInstanceRequest14Sp4
        /// </summary>
        public static async Task<SuccessResponse> GroupMusicOnHoldAddInstanceRequest14(this OcipClient client, GroupMusicOnHoldAddInstanceRequest14 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a Music On Hold Instance to a department.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupMusicOnHoldAddInstanceRequest14sp4(this OcipClient client, GroupMusicOnHoldAddInstanceRequest14sp4 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse14 or ErrorResponse.
        /// Replaced By: GroupMusicOnHoldGetInstanceRequest14Sp4
        /// </summary>
        public static async Task<GroupMusicOnHoldGetInstanceResponse14> GroupMusicOnHoldGetInstanceRequest14(this OcipClient client, GroupMusicOnHoldGetInstanceRequest14 request)
        {
            return await client.Call(request) as GroupMusicOnHoldGetInstanceResponse14;
        }

        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse14sp4 or ErrorResponse.
        /// </summary>
        public static async Task<GroupMusicOnHoldGetInstanceResponse14sp4> GroupMusicOnHoldGetInstanceRequest14sp4(this OcipClient client, GroupMusicOnHoldGetInstanceRequest14sp4 request)
        {
            return await client.Call(request) as GroupMusicOnHoldGetInstanceResponse14sp4;
        }

        /// <summary>
        /// Modify data for a group or department Music On Hold Instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupMusicOnHoldModifyInstanceRequest14(this OcipClient client, GroupMusicOnHoldModifyInstanceRequest14 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request a table containing the phone directory for a group.
        /// If the specified group is part of an enterprise, the directory
        /// includes all users in the enterprise and all entries in the enterprise
        /// common phone list and the common phone list of the specified group.
        /// 
        /// If the specified group is part of a service provider, the directory
        /// includes all users in the group and all entries in the common phone
        /// list of the specified group.
        /// 
        /// It is possible to search by various criteria to restrict the number of
        /// rows returned.
        /// 
        /// Multiple search criteria are logically ANDed together.
        /// The response is either GroupPhoneDirectoryGetPagedListResponse or
        /// ErrorResponse.
        /// 
        /// Replaced By: GroupPhoneDirectoryGetPagedSortedListRequest
        /// </summary>
        public static async Task<GroupPhoneDirectoryGetPagedListResponse> GroupPhoneDirectoryGetPagedListRequest(this OcipClient client, GroupPhoneDirectoryGetPagedListRequest request)
        {
            return await client.Call(request) as GroupPhoneDirectoryGetPagedListResponse;
        }

        /// <summary>
        /// Requests the Group's policy settings.
        /// The response is either GroupPolicyGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupPolicyGetResponse> GroupPolicyGetRequest(this OcipClient client, GroupPolicyGetRequest request)
        {
            return await client.Call(request) as GroupPolicyGetResponse;
        }

        /// <summary>
        /// Requests the Group's policy settings.
        /// The response is either GroupPolicyGetResponse14sp1 or ErrorResponse.
        /// Replaced By : GroupPolicyGetRequest14sp4
        /// </summary>
        public static async Task<GroupPolicyGetResponse14sp1> GroupPolicyGetRequest14sp1(this OcipClient client, GroupPolicyGetRequest14sp1 request)
        {
            return await client.Call(request) as GroupPolicyGetResponse14sp1;
        }

        /// <summary>
        /// Request to get a session admission control group for the group.
        /// The response is either a GroupSessionAdmissionControlGroupGetResponse19sp1 or an ErrorResponse.
        /// 
        /// Replaced by: GroupSessionAdmissionControlGroupGetRequest21sp1
        /// </summary>
        public static async Task<GroupSessionAdmissionControlGroupGetResponse19sp1> GroupSessionAdmissionControlGroupGetRequest19sp1(this OcipClient client, GroupSessionAdmissionControlGroupGetRequest19sp1 request)
        {
            return await client.Call(request) as GroupSessionAdmissionControlGroupGetResponse19sp1;
        }

        /// <summary>
        /// Request to get a session admission control group for the group.
        /// The response is either a GroupSessionAdmissionControlGroupGetResponse21sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupSessionAdmissionControlGroupGetResponse21sp1> GroupSessionAdmissionControlGroupGetRequest21sp1(this OcipClient client, GroupSessionAdmissionControlGroupGetRequest21sp1 request)
        {
            return await client.Call(request) as GroupSessionAdmissionControlGroupGetResponse21sp1;
        }

        /// <summary>
        /// Add a Trunk Group instance to a group.
        /// The domain is required in the serviceUserId.
        /// The publicUserIdentity in the ServiceInstanceAddProfile is not allowed for trunk groups.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupAddInstanceRequest14(this OcipClient client, GroupTrunkGroupAddInstanceRequest14 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a Trunk Group instance to a group.
        /// The domain is required in the serviceUserId.
        /// The publicUserIdentity in the ServiceInstanceAddProfile is not allowed for trunk groups.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupAddInstanceRequest14sp1(this OcipClient client, GroupTrunkGroupAddInstanceRequest14sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a Trunk Group instance to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupAddInstanceRequest14sp4(this OcipClient client, GroupTrunkGroupAddInstanceRequest14sp4 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a Trunk Group instance to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupAddInstanceRequest14sp9(this OcipClient client, GroupTrunkGroupAddInstanceRequest14sp9 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a Trunk Group instance to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupAddInstanceRequest14sp9A(this OcipClient client, GroupTrunkGroupAddInstanceRequest14sp9A request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Trunk Group Instance from a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupDeleteInstanceRequest(this OcipClient client, GroupTrunkGroupDeleteInstanceRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a list of Trunk Groups for the group or enterprise.
        /// It is possible to restrict the results to a particular department, or expand the list to the entire
        /// enterprise.
        /// The response is either a GroupTrunkGroupGetInstanceListResponse14 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceListResponse14> GroupTrunkGroupGetInstanceListRequest14(this OcipClient client, GroupTrunkGroupGetInstanceListRequest14 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceListResponse14;
        }

        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse14 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceResponse14> GroupTrunkGroupGetInstanceRequest14(this OcipClient client, GroupTrunkGroupGetInstanceRequest14 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceResponse14;
        }

        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse14sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceResponse14sp1> GroupTrunkGroupGetInstanceRequest14sp1(this OcipClient client, GroupTrunkGroupGetInstanceRequest14sp1 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceResponse14sp1;
        }

        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse14sp4 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceResponse14sp4> GroupTrunkGroupGetInstanceRequest14sp4(this OcipClient client, GroupTrunkGroupGetInstanceRequest14sp4 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceResponse14sp4;
        }

        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse14sp5 or an ErrorResponse.
        /// The response contains a hosted user table with column headings: "User Id", "Last Name",
        /// "First Name", "Hiragana Last Name", "Hiragana First Name".
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceResponse14sp5> GroupTrunkGroupGetInstanceRequest14sp5(this OcipClient client, GroupTrunkGroupGetInstanceRequest14sp5 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceResponse14sp5;
        }

        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse14sp9 or an ErrorResponse.
        /// The response contains a hosted user table with column headings: "User Id", "Last Name",
        /// "First Name", "Hiragana Last Name", "Hiragana First Name".
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceResponse14sp9> GroupTrunkGroupGetInstanceRequest14sp9(this OcipClient client, GroupTrunkGroupGetInstanceRequest14sp9 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceResponse14sp9;
        }

        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse14sp9A or an ErrorResponse.
        /// The response contains a hosted user table with column headings: "User Id", "Last Name",
        /// "First Name", "Hiragana Last Name", "Hiragana First Name".
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceResponse14sp9> GroupTrunkGroupGetInstanceRequest14sp9A(this OcipClient client, GroupTrunkGroupGetInstanceRequest14sp9A request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceResponse14sp9;
        }

        /// <summary>
        /// Get a list of user's on a Trunk Group Instance.
        /// The response is either a GroupTrunkGroupGetInstanceUserListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceUserListResponse> GroupTrunkGroupGetInstanceUserListRequest(this OcipClient client, GroupTrunkGroupGetInstanceUserListRequest request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceUserListResponse;
        }

        /// <summary>
        /// Get the maximum permissible active trunk group calls for the group.
        /// The response is either a GroupTrunkGroupGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupGetResponse> GroupTrunkGroupGetRequest(this OcipClient client, GroupTrunkGroupGetRequest request)
        {
            return await client.Call(request) as GroupTrunkGroupGetResponse;
        }

        /// <summary>
        /// Get the maximum and bursting maximum permissible active trunk group calls for the group.
        /// The response is either a GroupTrunkGroupGetResponse14sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupGetResponse14sp1> GroupTrunkGroupGetRequest14sp1(this OcipClient client, GroupTrunkGroupGetRequest14sp1 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetResponse14sp1;
        }

        /// <summary>
        /// Modify a Trunk Group Instance in a group.
        /// The publicUserIdentity in the ServiceInstanceModifyProfile is not allowed for trunk groups.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupModifyInstanceRequest14(this OcipClient client, GroupTrunkGroupModifyInstanceRequest14 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Trunk Group Instance in a group.
        /// The access device cannot be modified or cleared if there are any users assigned to the Trunk Group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupModifyInstanceRequest14sp4(this OcipClient client, GroupTrunkGroupModifyInstanceRequest14sp4 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify a Trunk Group Instance in a group.
        /// The access device cannot be modified or cleared if there are any users assigned to the Trunk Group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupModifyInstanceRequest14sp9A(this OcipClient client, GroupTrunkGroupModifyInstanceRequest14sp9A request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the maximum and bursting maximum permissible active Trunk Group calls for the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupModifyRequest(this OcipClient client, GroupTrunkGroupModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a user creation task for a trunk group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupUserCreationTaskAddRequest(this OcipClient client, GroupTrunkGroupUserCreationTaskAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a user creation task for a trunk group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupUserCreationTaskDeleteRequest(this OcipClient client, GroupTrunkGroupUserCreationTaskDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the list of user creation tasks for a trunk group.
        /// The response is either GroupTrunkGroupUserCreationTaskGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupUserCreationTaskGetListResponse> GroupTrunkGroupUserCreationTaskGetListRequest(this OcipClient client, GroupTrunkGroupUserCreationTaskGetListRequest request)
        {
            return await client.Call(request) as GroupTrunkGroupUserCreationTaskGetListResponse;
        }

        /// <summary>
        /// Request the details of a specified user creation task for a trunk group.
        /// The response is either GroupTrunkGroupUserCreationTaskGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupTrunkGroupUserCreationTaskGetResponse> GroupTrunkGroupUserCreationTaskGetRequest(this OcipClient client, GroupTrunkGroupUserCreationTaskGetRequest request)
        {
            return await client.Call(request) as GroupTrunkGroupUserCreationTaskGetResponse;
        }

        /// <summary>
        /// Requests the group's voice portal passcode rules setting.
        /// The response is either GroupVoiceMessagingGroupGetPasscodeRulesResponse or ErrorResponse.
        /// Replaced By: GroupPortalPasscodeRulesGetRequest
        /// </summary>
        public static async Task<GroupVoiceMessagingGroupGetPasscodeRulesResponse> GroupVoiceMessagingGroupGetPasscodeRulesRequest(this OcipClient client, GroupVoiceMessagingGroupGetPasscodeRulesRequest request)
        {
            return await client.Call(request) as GroupVoiceMessagingGroupGetPasscodeRulesResponse;
        }

        /// <summary>
        /// Requests the group's voice messaging settings
        /// The response is either GroupVoiceMessagingGroupGetVoicePortalResponse14 or ErrorResponse.
        /// Replaced by GroupVoiceMessagingGroupGetVoicePortalRequest15
        /// </summary>
        public static async Task<GroupVoiceMessagingGroupGetVoicePortalResponse14> GroupVoiceMessagingGroupGetVoicePortalRequest14(this OcipClient client, GroupVoiceMessagingGroupGetVoicePortalRequest14 request)
        {
            return await client.Call(request) as GroupVoiceMessagingGroupGetVoicePortalResponse14;
        }

        /// <summary>
        /// Request to modify the group's voice portal passcode rules setting.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By: GroupPortalPasscodeRulesModifyRequest
        /// </summary>
        public static async Task<SuccessResponse> GroupVoiceMessagingGroupModifyPasscodeRulesRequest(this OcipClient client, GroupVoiceMessagingGroupModifyPasscodeRulesRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// LoginRequest13mp10 is 2nd stage of the 2 stage OCI login process.
        /// The signedPassword is not required for external authentication login from a trusted host (ACL).
        /// The response is either LoginResponse13mp10 or ErrorResponse
        /// </summary>
        public static async Task<LoginResponse13mp10> LoginRequest13mp10(this OcipClient client, LoginRequest13mp10 request)
        {
            return await client.Call(request) as LoginResponse13mp10;
        }

        /// <summary>
        /// Request to get the list of device files managed by the Device Management System, on a per-device profile
        /// basis.
        /// The response is either ServiceProviderAccessDeviceFileGetListResponse or ErrorResponse.
        /// Replaced By: ServiceProviderAccessDeviceFileGetListRequest14sp8
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceFileGetListResponse> ServiceProviderAccessDeviceFileGetListRequest(this OcipClient client, ServiceProviderAccessDeviceFileGetListRequest request)
        {
            return await client.Call(request) as ServiceProviderAccessDeviceFileGetListResponse;
        }

        /// <summary>
        /// Request to get a service provider device profile file.
        /// The response is either ServiceProviderAccessDeviceFileGetResponse or ErrorResponse.
        /// Replaced By: ServiceProviderAccessDeviceFileGetRequest14sp8
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceFileGetResponse> ServiceProviderAccessDeviceFileGetRequest(this OcipClient client, ServiceProviderAccessDeviceFileGetRequest request)
        {
            return await client.Call(request) as ServiceProviderAccessDeviceFileGetResponse;
        }

        /// <summary>
        /// Request to modify a specified service provider/enterprise access device file.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By: ServiceProviderAccessDeviceFileModifyRequest14sp8
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceFileModifyRequest(this OcipClient client, ServiceProviderAccessDeviceFileModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests the configuration of a specified service provider access device.
        /// The response is either ServiceProviderAccessDeviceGetResponse14 or ErrorResponse.
        /// Replaced By: ServiceProviderAccessDeviceGetRequest14sp3
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetResponse14> ServiceProviderAccessDeviceGetRequest14(this OcipClient client, ServiceProviderAccessDeviceGetRequest14 request)
        {
            return await client.Call(request) as ServiceProviderAccessDeviceGetResponse14;
        }

        /// <summary>
        /// Requests the configuration of a specified service provider access device.
        /// The response is either ServiceProviderAccessDeviceGetResponse14sp3 or ErrorResponse.
        /// Replaced By: ServiceProviderAccessDeviceGetRequest14sp6
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetResponse14sp3> ServiceProviderAccessDeviceGetRequest14sp3(this OcipClient client, ServiceProviderAccessDeviceGetRequest14sp3 request)
        {
            return await client.Call(request) as ServiceProviderAccessDeviceGetResponse14sp3;
        }

        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse14 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse14> ServiceProviderCallProcessingGetPolicyRequest14(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest14 request)
        {
            return await client.Call(request) as ServiceProviderCallProcessingGetPolicyResponse14;
        }

        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse14sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse14sp1> ServiceProviderCallProcessingGetPolicyRequest14sp1(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest14sp1 request)
        {
            return await client.Call(request) as ServiceProviderCallProcessingGetPolicyResponse14sp1;
        }

        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse14sp4 or an ErrorResponse.
        /// Replaced By : ServiceProviderCallProcessingGetPolicyRequest15
        /// </summary>
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse14sp4> ServiceProviderCallProcessingGetPolicyRequest14sp4(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest14sp4 request)
        {
            return await client.Call(request) as ServiceProviderCallProcessingGetPolicyResponse14sp4;
        }

        /// <summary>
        /// Modify the service provider level data associated with Call Processing
        /// Policy. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCallProcessingModifyPolicyRequest14(this OcipClient client, ServiceProviderCallProcessingModifyPolicyRequest14 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the service provider's password rules settings
        /// setting applicable to Administrators (Group and Department) and Users.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By: ServiceProviderPasswordRulesModifyRequest14sp3
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderPasswordRulesModifyRequest(this OcipClient client, ServiceProviderPasswordRulesModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests the details of a specified service pack migration task.
        /// The response is either ServiceProviderServicePackMigrationTaskGetResponse
        /// or ErrorResponse.
        /// Replaced By: ServiceProviderServicePackMigrationTaskGetRequest14sp4
        /// </summary>
        public static async Task<ServiceProviderServicePackMigrationTaskGetResponse> ServiceProviderServicePackMigrationTaskGetRequest(this OcipClient client, ServiceProviderServicePackMigrationTaskGetRequest request)
        {
            return await client.Call(request) as ServiceProviderServicePackMigrationTaskGetResponse;
        }

        /// <summary>
        /// Get the maximum permissible active Trunk Group calls for the service provider.
        /// The response is either a ServiceProviderTrunkGroupGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderTrunkGroupGetResponse> ServiceProviderTrunkGroupGetRequest(this OcipClient client, ServiceProviderTrunkGroupGetRequest request)
        {
            return await client.Call(request) as ServiceProviderTrunkGroupGetResponse;
        }

        /// <summary>
        /// Requests the service provider's voice portal passcode rules setting.
        /// The response is either ServiceProviderVoiceMessagingGroupGetPasscodeRulesResponse or ErrorResponse.
        /// Replaced By: ServiceProviderPortalPasscodeRulesGetRequest
        /// </summary>
        public static async Task<ServiceProviderVoiceMessagingGroupGetPasscodeRulesResponse> ServiceProviderVoiceMessagingGroupGetPasscodeRulesRequest(this OcipClient client, ServiceProviderVoiceMessagingGroupGetPasscodeRulesRequest request)
        {
            return await client.Call(request) as ServiceProviderVoiceMessagingGroupGetPasscodeRulesResponse;
        }

        /// <summary>
        /// Request to modify the service provider's voice portal passcode rules setting.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By: ServiceProviderPortalPasscodeRulesModifyRequest
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderVoiceMessagingGroupModifyPasscodeRulesRequest(this OcipClient client, ServiceProviderVoiceMessagingGroupModifyPasscodeRulesRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the list of device files managed by the Device Management System, on a per-device profile
        /// basis.
        /// The response is either SystemAccessDeviceFileGetListResponse or ErrorResponse.
        /// Replaced By: SystemAccessDeviceFileGetListRequest14sp8
        /// </summary>
        public static async Task<SystemAccessDeviceFileGetListResponse> SystemAccessDeviceFileGetListRequest(this OcipClient client, SystemAccessDeviceFileGetListRequest request)
        {
            return await client.Call(request) as SystemAccessDeviceFileGetListResponse;
        }

        /// <summary>
        /// Request to get a device profile file.
        /// The response is either SystemAccessDeviceFileGetResponse or ErrorResponse.
        /// Replaced By: SystemAccessDeviceFileGetRequest14sp8
        /// </summary>
        public static async Task<SystemAccessDeviceFileGetResponse> SystemAccessDeviceFileGetRequest(this OcipClient client, SystemAccessDeviceFileGetRequest request)
        {
            return await client.Call(request) as SystemAccessDeviceFileGetResponse;
        }

        /// <summary>
        /// Request to modify a specified system access device file.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By: SystemAccessDeviceFileModifyRequest14sp8
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceFileModifyRequest(this OcipClient client, SystemAccessDeviceFileModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests the configuration of a specified system access device.
        /// The response is either SystemAccessDeviceGetResponse or ErrorResponse.
        /// Replaced By: SystemAccessDeviceGetRequest14sp3
        /// </summary>
        public static async Task<SystemAccessDeviceGetResponse> SystemAccessDeviceGetRequest(this OcipClient client, SystemAccessDeviceGetRequest request)
        {
            return await client.Call(request) as SystemAccessDeviceGetResponse;
        }

        /// <summary>
        /// Requests the configuration of a specified system access device.
        /// The response is either SystemAccessDeviceGetResponse14sp3 or ErrorResponse.
        /// Replaced By: SystemAccessDeviceGetRequest14sp6
        /// </summary>
        public static async Task<SystemAccessDeviceGetResponse14sp3> SystemAccessDeviceGetRequest14sp3(this OcipClient client, SystemAccessDeviceGetRequest14sp3 request)
        {
            return await client.Call(request) as SystemAccessDeviceGetResponse14sp3;
        }

        /// <summary>
        /// Request to get the list of Application Server Registration system parameters.
        /// The response is either SystemASRParametersGetResponse or ErrorResponse.
        /// Replaced By: SystemASRParametersGetRequest14sp5
        /// </summary>
        public static async Task<SystemASRParametersGetResponse> SystemASRParametersGetRequest(this OcipClient client, SystemASRParametersGetRequest request)
        {
            return await client.Call(request) as SystemASRParametersGetResponse;
        }

        /// <summary>
        /// Request to get the list of Application Server Registration system parameters.
        /// The response is either SystemASRParametersGetResponse14sp5 or ErrorResponse.
        /// </summary>
        public static async Task<SystemASRParametersGetResponse14sp5> SystemASRParametersGetRequest14sp5(this OcipClient client, SystemASRParametersGetRequest14sp5 request)
        {
            return await client.Call(request) as SystemASRParametersGetResponse14sp5;
        }

        /// <summary>
        /// Request to modify Application Server Registration system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemASRParametersModifyRequest(this OcipClient client, SystemASRParametersModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the system's automatic callback attributes.
        /// The response is either a SystemAutomaticCallbackGetResponse or an ErrorResponse.
        /// Replaced By: SystemAutomaticCallbackGetRequest15
        /// </summary>
        public static async Task<SystemAutomaticCallbackGetResponse> SystemAutomaticCallbackGetRequest(this OcipClient client, SystemAutomaticCallbackGetRequest request)
        {
            return await client.Call(request) as SystemAutomaticCallbackGetResponse;
        }

        /// <summary>
        /// Modifies the system's automatic callback attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By: SystemAutomaticCallbackModifyRequest15
        /// </summary>
        public static async Task<SuccessResponse> SystemAutomaticCallbackModifyRequest(this OcipClient client, SystemAutomaticCallbackModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add an OCI entry to the Broadworks Common Communication Transport (BCCT) protocol to interface mapping
        /// table.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBCCTAddOCIInterfaceAddressRequest(this OcipClient client, SystemBCCTAddOCIInterfaceAddressRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete an OCI entry in the Broadworks Common Communication Transport (BCCT) protocol to interface
        /// mapping table.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemBCCTDeleteOCIInterfaceAddressRequest(this OcipClient client, SystemBCCTDeleteOCIInterfaceAddressRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the OCI entries from the Broadworks Common Communication Transport (BCCT) protocol to interface
        /// mapping list.
        /// The response is SystemBCCTGetOCIInterfaceAddressListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemBCCTGetOCIInterfaceAddressListResponse> SystemBCCTGetOCIInterfaceAddressListRequest(this OcipClient client, SystemBCCTGetOCIInterfaceAddressListRequest request)
        {
            return await client.Call(request) as SystemBCCTGetOCIInterfaceAddressListResponse;
        }

        /// <summary>
        /// Request the system level data associated with Call Center.
        /// The response is either a SystemCallCenterGetResponse or an
        /// ErrorResponse.
        /// Replaced By: SystemCallCenterGetRequest14sp9
        /// </summary>
        public static async Task<SystemCallCenterGetResponse> SystemCallCenterGetRequest(this OcipClient client, SystemCallCenterGetRequest request)
        {
            return await client.Call(request) as SystemCallCenterGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Call Processing Policy.
        /// The response is either a SystemCallProcessingGetPolicyResponse14 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse14> SystemCallProcessingGetPolicyRequest14(this OcipClient client, SystemCallProcessingGetPolicyRequest14 request)
        {
            return await client.Call(request) as SystemCallProcessingGetPolicyResponse14;
        }

        /// <summary>
        /// Request the system level data associated with Call Processing Policy.
        /// The response is either a SystemCallProcessingGetPolicyResponse14sp1 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse14sp1> SystemCallProcessingGetPolicyRequest14sp1(this OcipClient client, SystemCallProcessingGetPolicyRequest14sp1 request)
        {
            return await client.Call(request) as SystemCallProcessingGetPolicyResponse14sp1;
        }

        /// <summary>
        /// Request the system level data associated with Call Processing Policy.
        /// The response is either a SystemCallProcessingGetPolicyResponse14sp4 or an
        /// ErrorResponse.
        /// Replaced By : SystemCallProcessingGetPolicyRequest15
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse14sp4> SystemCallProcessingGetPolicyRequest14sp4(this OcipClient client, SystemCallProcessingGetPolicyRequest14sp4 request)
        {
            return await client.Call(request) as SystemCallProcessingGetPolicyResponse14sp4;
        }

        /// <summary>
        /// Modify the system level data associated with Call Processing Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By : SystemCallProcessingModifyPolicyRequest15
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingModifyPolicyRequest14(this OcipClient client, SystemCallProcessingModifyPolicyRequest14 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the system level data associated with Call Recording.
        /// The response is either a SystemCallRecordingGetResponse or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallRecordingGetRequest22
        /// </summary>
        public static async Task<SystemCallRecordingGetResponse> SystemCallRecordingGetRequest(this OcipClient client, SystemCallRecordingGetRequest request)
        {
            return await client.Call(request) as SystemCallRecordingGetResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Call Recording.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced By: SystemCallRecordingModifyRequest22
        /// </summary>
        public static async Task<SuccessResponse> SystemCallRecordingModifyRequest(this OcipClient client, SystemCallRecordingModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the system level data associated with collaborate services.
        /// The response is either a SystemCollaborateGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemCollaborateGetRequest20sp1
        /// </summary>
        public static async Task<SystemCollaborateGetResponse> SystemCollaborateGetRequest(this OcipClient client, SystemCollaborateGetRequest request)
        {
            return await client.Call(request) as SystemCollaborateGetResponse;
        }

        /// <summary>
        /// Modify the system level data associated with collaborate services.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemCollaborateModifyRequest20sp1
        /// </summary>
        public static async Task<SuccessResponse> SystemCollaborateModifyRequest(this OcipClient client, SystemCollaborateModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a device CPE config file server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By: SystemCPEConfigAddFileServerRequest14sp6
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigAddFileServerRequest(this OcipClient client, SystemCPEConfigAddFileServerRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests the list of device CPE config file servers.
        /// The response is either SystemCPEConfigGetFileServerListResponse or ErrorResponse.
        /// Replaced By: SystemCPEConfigGetFileServerListRequest14sp6
        /// </summary>
        public static async Task<SystemCPEConfigGetFileServerListResponse> SystemCPEConfigGetFileServerListRequest(this OcipClient client, SystemCPEConfigGetFileServerListRequest request)
        {
            return await client.Call(request) as SystemCPEConfigGetFileServerListResponse;
        }

        /// <summary>
        /// Modify a device CPE config file server.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By: SystemCPEConfigModifyFileServerRequest14sp6
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigModifyFileServerRequest(this OcipClient client, SystemCPEConfigModifyFileServerRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the list of CPE Config system parameters.
        /// The response is either SystemCPEConfigParametersGetResponse or ErrorResponse.
        /// Replaced By: SystemCPEConfigParametersGetRequest14sp6
        /// </summary>
        public static async Task<SystemCPEConfigParametersGetResponse> SystemCPEConfigParametersGetRequest(this OcipClient client, SystemCPEConfigParametersGetRequest request)
        {
            return await client.Call(request) as SystemCPEConfigParametersGetResponse;
        }

        /// <summary>
        /// Request to add a static configuration tag.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by: SystemDeviceManagementTagAddRequest21sp2
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceManagementTagAddRequest(this OcipClient client, SystemDeviceManagementTagAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a static configuration tag.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by: SystemDeviceManagementTagAddRequest22
        /// </summary>
        public static async Task<SuccessResponse> SystemDeviceManagementTagAddRequest21sp2(this OcipClient client, SystemDeviceManagementTagAddRequest21sp2 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests a list of non-obsolete Identity/device profile types defined in the system. It is possible
        /// to get either all conference device types or all non-conferernce types. This command is similar
        /// to the SystemSIPDeviceTypeGetListRequest and SystemMGCPDeviceTypeGetListRequest
        /// but gets both SIP and MGCP types.
        /// The response is either SystemDeviceTypeGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemDeviceTypeGetAvailableListResponse> SystemDeviceTypeGetAvailableListRequest(this OcipClient client, SystemDeviceTypeGetAvailableListRequest request)
        {
            return await client.Call(request) as SystemDeviceTypeGetAvailableListResponse;
        }

        /// <summary>
        /// Requests a list of non-obsolete Identity/device profile types defined in the system. It is possible
        /// to get either all conference device types or all non-conferernce types. This command is similar
        /// to the SystemSIPDeviceTypeGetListRequest and SystemMGCPDeviceTypeGetListRequest
        /// but gets both SIP and MGCP types.
        /// The response is either SystemDeviceTypeGetAvailableListResponse14sp1 or ErrorResponse.
        /// Replaced By: SystemDeviceTypeGetAvailableListRequest14sp3
        /// </summary>
        public static async Task<SystemDeviceTypeGetAvailableListResponse14sp1> SystemDeviceTypeGetAvailableListRequest14sp1(this OcipClient client, SystemDeviceTypeGetAvailableListRequest14sp1 request)
        {
            return await client.Call(request) as SystemDeviceTypeGetAvailableListResponse14sp1;
        }

        /// <summary>
        /// Requests the information about the specified device type without regard to whether the
        /// type is SIP or MGCP.
        /// The response is either SystemDeviceTypeGetResponse or ErrorResponse.
        /// Replaced By: SystemDeviceTypeGetRequest14sp3
        /// </summary>
        public static async Task<SystemDeviceTypeGetResponse> SystemDeviceTypeGetRequest(this OcipClient client, SystemDeviceTypeGetRequest request)
        {
            return await client.Call(request) as SystemDeviceTypeGetResponse;
        }

        /// <summary>
        /// Requests the information about the specified device type without regard to whether the
        /// type is SIP or MGCP.
        /// The response is either SystemDeviceTypeGetResponse14sp3 or ErrorResponse.
        /// Replaced By: SystemDeviceTypeGetRequest14sp6
        /// </summary>
        public static async Task<SystemDeviceTypeGetResponse14sp3> SystemDeviceTypeGetRequest14sp3(this OcipClient client, SystemDeviceTypeGetRequest14sp3 request)
        {
            return await client.Call(request) as SystemDeviceTypeGetResponse14sp3;
        }

        /// <summary>
        /// Get the utilization of a single DN.
        /// The response is either SystemDnGetUtilizationResponse or ErrorResponse.
        /// Replaced By: SystemDnGetUtilizationRequest14sp3
        /// </summary>
        public static async Task<SystemDnGetUtilizationResponse> SystemDnGetUtilizationRequest(this OcipClient client, SystemDnGetUtilizationRequest request)
        {
            return await client.Call(request) as SystemDnGetUtilizationResponse;
        }

        /// <summary>
        /// Add an entry to the external authentication access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExternalAuthenticationAddACLEntryRequest(this OcipClient client, SystemExternalAuthenticationAddACLEntryRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete an entry from the external authentication access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExternalAuthenticationDeleteACLEntryRequest(this OcipClient client, SystemExternalAuthenticationDeleteACLEntryRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify an entry from the external authentication access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemExternalAuthenticationModifyACLEntryRequest(this OcipClient client, SystemExternalAuthenticationModifyACLEntryRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get all the licensing information.
        /// The response is either SystemLicensingGetResponse or ErrorResponse.
        /// Replaced By: SystemLicensingGetRequest14sp3
        /// </summary>
        public static async Task<SystemLicensingGetResponse> SystemLicensingGetRequest(this OcipClient client, SystemLicensingGetRequest request)
        {
            return await client.Call(request) as SystemLicensingGetResponse;
        }

        /// <summary>
        /// Request to get the list of Network Server Sync system parameters.
        /// The response is either SystemNetworkServerSyncParametersGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemNetworkServerSyncParametersGetResponse> SystemNetworkServerSyncParametersGetRequest(this OcipClient client, SystemNetworkServerSyncParametersGetRequest request)
        {
            return await client.Call(request) as SystemNetworkServerSyncParametersGetResponse;
        }

        /// <summary>
        /// Request to add a Network Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by SystemNetworkSynchingServerAddRequest22V2
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkSynchingServerAddRequest(this OcipClient client, SystemNetworkSynchingServerAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a Network Server to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by SystemNetworkSynchingServerAddRequest22V2
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkSynchingServerAddRequest22(this OcipClient client, SystemNetworkSynchingServerAddRequest22 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Network Server in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// becomePreferred
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// order
        /// Replaced by SystemNetworkSynchingServerModifyRequest22
        /// </summary>
        public static async Task<SuccessResponse> SystemNetworkSynchingServerModifyRequest(this OcipClient client, SystemNetworkSynchingServerModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add an application to the OCI call control application list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemOCICallControlApplicationAddRequest(this OcipClient client, SystemOCICallControlApplicationAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the list of OCIReporting system parameters.
        /// The response is either SystemOCIReportingParametersGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemOCIReportingParametersGetResponse> SystemOCIReportingParametersGetRequest(this OcipClient client, SystemOCIReportingParametersGetRequest request)
        {
            return await client.Call(request) as SystemOCIReportingParametersGetResponse;
        }

        /// <summary>
        /// Request to modify the system providers password rule
        /// setting applicable to System Adminstrator, Provisioning Administrator,
        /// and/or Service Provider Administrator, Group Administrator, Department Administrator, User.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By: SystemPasswordRulesModifyRequest14sp3
        /// </summary>
        public static async Task<SuccessResponse> SystemPasswordRulesModifyRequest(this OcipClient client, SystemPasswordRulesModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse14 or ErrorResponse.
        /// </summary>
        public static async Task<SystemPolicyGetDefaultResponse14> SystemPolicyGetDefaultRequest14(this OcipClient client, SystemPolicyGetDefaultRequest14 request)
        {
            return await client.Call(request) as SystemPolicyGetDefaultResponse14;
        }

        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse14sp1 or ErrorResponse.
        /// Replaced By: SystemPolicyGetDefaultRequest14sp4
        /// </summary>
        public static async Task<SystemPolicyGetDefaultResponse14sp1> SystemPolicyGetDefaultRequest14sp1(this OcipClient client, SystemPolicyGetDefaultRequest14sp1 request)
        {
            return await client.Call(request) as SystemPolicyGetDefaultResponse14sp1;
        }

        /// <summary>
        /// Request to get the system's provisioning validation attributes.
        /// The response is either a SystemProvisioningValidationGetResponse or and ErrorResponse.
        /// </summary>
        public static async Task<SystemProvisioningValidationGetResponse> SystemProvisioningValidationGetRequest(this OcipClient client, SystemProvisioningValidationGetRequest request)
        {
            return await client.Call(request) as SystemProvisioningValidationGetResponse;
        }

        /// <summary>
        /// Get the session admission control settings for the system.
        /// The response is either a SystemSessionAdmissionControlGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemSessionAdmissionControlGetRequest21sp1.
        /// </summary>
        public static async Task<SystemSessionAdmissionControlGetResponse> SystemSessionAdmissionControlGetRequest(this OcipClient client, SystemSessionAdmissionControlGetRequest request)
        {
            return await client.Call(request) as SystemSessionAdmissionControlGetResponse;
        }

        /// <summary>
        /// Get the session admission control settings for the system.
        /// The response is either a SystemSessionAdmissionControlGetResponse21sp1 or an ErrorResponse.
        /// Replaced by: SystemSessionAdmissionControlGetRequest22.
        /// </summary>
        public static async Task<SystemSessionAdmissionControlGetResponse21sp1> SystemSessionAdmissionControlGetRequest21sp1(this OcipClient client, SystemSessionAdmissionControlGetRequest21sp1 request)
        {
            return await client.Call(request) as SystemSessionAdmissionControlGetResponse21sp1;
        }

        /// <summary>
        /// Request the system level data associated with session audit.
        /// The response is either a SystemSessionAuditGetResponse or an
        /// ErrorResponse.
        /// Replaced By: SystemSessionAuditGetRequest14sp3
        /// </summary>
        public static async Task<SystemSessionAuditGetResponse> SystemSessionAuditGetRequest(this OcipClient client, SystemSessionAuditGetRequest request)
        {
            return await client.Call(request) as SystemSessionAuditGetResponse;
        }

        /// <summary>
        /// Modify the system level data associated with session sudit.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By: SystemSessionAuditModifyRequest14sp3
        /// </summary>
        public static async Task<SuccessResponse> SystemSessionAuditModifyRequest(this OcipClient client, SystemSessionAuditModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add an entry to the SIP access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPAddACLEntryRequest14(this OcipClient client, SystemSIPAddACLEntryRequest14 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete an entry from the SIP access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeleteACLEntryRequest(this OcipClient client, SystemSIPDeleteACLEntryRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest(this OcipClient client, SystemSIPDeviceTypeAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By: SystemSIPDeviceTypeAddRequest14sp2
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest14sp1(this OcipClient client, SystemSIPDeviceTypeAddRequest14sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By: SystemSIPDeviceTypeAddRequest14sp3
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest14sp2(this OcipClient client, SystemSIPDeviceTypeAddRequest14sp2 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by: SystemSIPDeviceTypeAddRequest14sp6
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest14sp3(this OcipClient client, SystemSIPDeviceTypeAddRequest14sp3 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By : SystemSIPDeviceTypeAddRequest15
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest14sp6(this OcipClient client, SystemSIPDeviceTypeAddRequest14sp6 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By: SystemSIPDeviceTypeFileAddRequest14sp8
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileAddRequest(this OcipClient client, SystemSIPDeviceTypeFileAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By: SystemSIPDeviceTypeFileDeleteRequest14sp8
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileDeleteRequest(this OcipClient client, SystemSIPDeviceTypeFileDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the list of device files managed by the Device Management System, on a per-device type
        /// basis.
        /// The response is either SystemSIPDeviceTypeFileGetListResponse or ErrorResponse.
        /// Replaced By: SystemSIPDeviceTypeFileGetListRequest14sp8
        /// </summary>
        public static async Task<SystemSIPDeviceTypeFileGetListResponse> SystemSIPDeviceTypeFileGetListRequest(this OcipClient client, SystemSIPDeviceTypeFileGetListRequest request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeFileGetListResponse;
        }

        /// <summary>
        /// Request to get a sip device type file.
        /// The response is either SystemSIPDeviceTypeFileGetResponse or ErrorResponse.
        /// Replaced By: SystemSIPDeviceTypeFileGetRequest14sp8
        /// </summary>
        public static async Task<SystemSIPDeviceTypeFileGetResponse> SystemSIPDeviceTypeFileGetRequest(this OcipClient client, SystemSIPDeviceTypeFileGetRequest request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeFileGetResponse;
        }

        /// <summary>
        /// Request to modify a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By: SystemSIPDeviceTypeFileModifyRequest14sp8
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileModifyRequest(this OcipClient client, SystemSIPDeviceTypeFileModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse> SystemSIPDeviceTypeGetRequest(this OcipClient client, SystemSIPDeviceTypeGetRequest request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse14sp1 or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse14sp1> SystemSIPDeviceTypeGetRequest14sp1(this OcipClient client, SystemSIPDeviceTypeGetRequest14sp1 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse14sp1;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse14sp2 or ErrorResponse.
        /// Replaced By: SystemSIPDeviceTypeGetRequest14sp3
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse14sp2> SystemSIPDeviceTypeGetRequest14sp2(this OcipClient client, SystemSIPDeviceTypeGetRequest14sp2 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse14sp2;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse14sp3 or ErrorResponse.
        /// Replaced by: SystemSIPDeviceTypeGetRequest14sp6
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse14sp3> SystemSIPDeviceTypeGetRequest14sp3(this OcipClient client, SystemSIPDeviceTypeGetRequest14sp3 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse14sp3;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse14sp6 or ErrorResponse.
        /// Replaced By : SystemSIPDeviceTypeGetRequest15
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse14sp6> SystemSIPDeviceTypeGetRequest14sp6(this OcipClient client, SystemSIPDeviceTypeGetRequest14sp6 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse14sp6;
        }

        /// <summary>
        /// Request to modify a sip device type.
        /// The following elements are not changeable:
        /// numberOfPorts
        /// SignalingAddressType
        /// isConferenceDevice
        /// isMusicOnHoldDevice
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeModifyRequest(this OcipClient client, SystemSIPDeviceTypeModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a sip device type.
        /// The following elements are not changeable:
        /// numberOfPorts
        /// SignalingAddressType
        /// isConferenceDevice
        /// isMusicOnHoldDevice
        /// isMobilityManagerDevice
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By : SystemSIPDeviceTypeModifyRequest15
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeModifyRequest14sp2(this OcipClient client, SystemSIPDeviceTypeModifyRequest14sp2 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify an entry from the SIP access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPModifyACLEntryRequest(this OcipClient client, SystemSIPModifyACLEntryRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add an entry to the SMDI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIAddACLEntryRequest(this OcipClient client, SystemSMDIAddACLEntryRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete an entry from the SMDI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIDeleteACLEntryRequest(this OcipClient client, SystemSMDIDeleteACLEntryRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify an entry from the SMDI access control list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSMDIModifyACLEntryRequest(this OcipClient client, SystemSMDIModifyACLEntryRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the system level data associated with SMPP external interface.
        /// The response is either a SystemSMPPGetResponse or an ErrorResponse.
        /// Replaced By: SystemSMPPGetRequest14sp5
        /// </summary>
        public static async Task<SystemSMPPGetResponse> SystemSMPPGetRequest(this OcipClient client, SystemSMPPGetRequest request)
        {
            return await client.Call(request) as SystemSMPPGetResponse;
        }

        /// <summary>
        /// Get the system call processing configuration for all subscribers
        /// The response is either a SystemSubscriberGetCallProcessingParametersResponse or an ErrorResponse.
        /// Replaced By: SystemSubscriberGetCallProcessingParametersRequest14sp3
        /// </summary>
        public static async Task<SystemSubscriberGetCallProcessingParametersResponse> SystemSubscriberGetCallProcessingParametersRequest(this OcipClient client, SystemSubscriberGetCallProcessingParametersRequest request)
        {
            return await client.Call(request) as SystemSubscriberGetCallProcessingParametersResponse;
        }

        /// <summary>
        /// Get the system call processing configuration for all subscribers
        /// The response is either a SystemSubscriberGetCallProcessingParametersResponse14sp3 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSubscriberGetCallProcessingParametersResponse14sp3> SystemSubscriberGetCallProcessingParametersRequest14sp3(this OcipClient client, SystemSubscriberGetCallProcessingParametersRequest14sp3 request)
        {
            return await client.Call(request) as SystemSubscriberGetCallProcessingParametersResponse14sp3;
        }

        /// <summary>
        /// Modify the system call processing configuration for all subscribers.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// userCallingLineIdSelection
        /// isExtendedCallingLineIdActive
        /// isRingTimeOutActive
        /// ringTimeoutSeconds
        /// allowEmergencyRemoteOfficeOriginations
        /// Replaced By: SystemSubscriberModifyCallProcessingParametersRequest14sp7
        /// </summary>
        public static async Task<SuccessResponse> SystemSubscriberModifyCallProcessingParametersRequest(this OcipClient client, SystemSubscriberModifyCallProcessingParametersRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the list of user creation tasks in the system.
        /// The response is either SystemTrunkGroupUserCreationTaskGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemTrunkGroupUserCreationTaskGetListResponse> SystemTrunkGroupUserCreationTaskGetListRequest(this OcipClient client, SystemTrunkGroupUserCreationTaskGetListRequest request)
        {
            return await client.Call(request) as SystemTrunkGroupUserCreationTaskGetListResponse;
        }

        /// <summary>
        /// Requests the system voice portal passcode rules setting.
        /// The response is either SystemVoiceMessagingGroupGetPasscodeRulesResponse14 or ErrorResponse.
        /// Replaced By: SystemPortalPasscodeRulesGetRequest
        /// </summary>
        public static async Task<SystemVoiceMessagingGroupGetPasscodeRulesResponse14> SystemVoiceMessagingGroupGetPasscodeRulesRequest14(this OcipClient client, SystemVoiceMessagingGroupGetPasscodeRulesRequest14 request)
        {
            return await client.Call(request) as SystemVoiceMessagingGroupGetPasscodeRulesResponse14;
        }

        /// <summary>
        /// Request to modify the system voice portal passcode rules setting.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By: SystemPortalPasscodeRulesModifyRequest
        /// </summary>
        public static async Task<SuccessResponse> SystemVoiceMessagingGroupModifyPasscodeRulesRequest(this OcipClient client, SystemVoiceMessagingGroupModifyPasscodeRulesRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a user.
        /// The domain is required in the userId.
        /// The password is not required if external authentication is enabled.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserAddRequest14(this OcipClient client, UserAddRequest14 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request user's call logs.
        /// If the callLogType is not specified, all types of calls are returned.
        /// The response is either a UserBasicCallLogsGetListResponse or an ErrorResponse.
        /// Replaced By: UserBasicCallLogsGetListRequest14sp4
        /// </summary>
        public static async Task<UserBasicCallLogsGetListResponse> UserBasicCallLogsGetListRequest(this OcipClient client, UserBasicCallLogsGetListRequest request)
        {
            return await client.Call(request) as UserBasicCallLogsGetListResponse;
        }

        /// <summary>
        /// Get the list of call centers the specified user belongs to.
        /// The response is either a UserCallCenterGetListResponse or an ErrorResponse.
        /// Replaced By: UserCallCenterGetRequest
        /// </summary>
        public static async Task<UserCallCenterGetListResponse> UserCallCenterGetListRequest(this OcipClient client, UserCallCenterGetListRequest request)
        {
            return await client.Call(request) as UserCallCenterGetListResponse;
        }

        /// <summary>
        /// Request for an agent to login or logout of one or more Call Centers.
        /// Contains a list specifing the desired login status of one or more call centers.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By: UserCallCenterModifyRequest17sp4
        /// </summary>
        public static async Task<SuccessResponse> UserCallCenterModifyAvailabilityListRequest(this OcipClient client, UserCallCenterModifyAvailabilityListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Clear a user's call logs associated with Basic Call Logs and Enhanced
        /// Call Logs features.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By: UserCallLogsClearRequest14sp4
        /// </summary>
        public static async Task<SuccessResponse> UserCallLogsClearRequest(this OcipClient client, UserCallLogsClearRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the user level data associated with Call Processing Policy.
        /// The response is either a UserCallProcessingGetPolicyResponse14 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallProcessingGetPolicyResponse14> UserCallProcessingGetPolicyRequest14(this OcipClient client, UserCallProcessingGetPolicyRequest14 request)
        {
            return await client.Call(request) as UserCallProcessingGetPolicyResponse14;
        }

        /// <summary>
        /// Request the user level data associated with Call Processing Policy.
        /// The response is either a UserCallProcessingGetPolicyResponse14sp1 or an
        /// ErrorResponse.
        /// Replaced By: UserCallProcessingGetPolicyRequest14sp7
        /// </summary>
        public static async Task<UserCallProcessingGetPolicyResponse14sp1> UserCallProcessingGetPolicyRequest14sp1(this OcipClient client, UserCallProcessingGetPolicyRequest14sp1 request)
        {
            return await client.Call(request) as UserCallProcessingGetPolicyResponse14sp1;
        }

        /// <summary>
        /// Modify the user level data associated with Call Processing Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By: UserCallProcessingModifyPolicyRequest14sp7
        /// </summary>
        public static async Task<SuccessResponse> UserCallProcessingModifyPolicyRequest14(this OcipClient client, UserCallProcessingModifyPolicyRequest14 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the user level data associated with Call Transfer.
        /// The response is either a UserCallTransferGetResponse or an ErrorResponse.
        /// Replaced By: UserCallTransferGetRequest14Sp4
        /// </summary>
        public static async Task<UserCallTransferGetResponse> UserCallTransferGetRequest(this OcipClient client, UserCallTransferGetRequest request)
        {
            return await client.Call(request) as UserCallTransferGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Charge Number.
        /// The response is either a UserChargeNumberGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserChargeNumberGetResponse> UserChargeNumberGetRequest(this OcipClient client, UserChargeNumberGetRequest request)
        {
            return await client.Call(request) as UserChargeNumberGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Directed Call Pickup With Barge In.
        /// The response is either a UserDirectedCallPickupWithBargeInGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserDirectedCallPickupWithBargeInGetResponse> UserDirectedCallPickupWithBargeInGetRequest(this OcipClient client, UserDirectedCallPickupWithBargeInGetRequest request)
        {
            return await client.Call(request) as UserDirectedCallPickupWithBargeInGetResponse;
        }

        /// <summary>
        /// Request user's call logs. It is possible to get a subset of the total list of calls
        /// by specifying a starting offset and the number of calls to get.
        /// If the callLogType is not specified, all types of calls are returned.
        /// The response is either a UserEnhancedCallLogsGetListResponse or an ErrorResponse.
        /// Replaced By: UserEnhancedCallLogsGetListRequest14sp4
        /// </summary>
        public static async Task<UserEnhancedCallLogsGetListResponse> UserEnhancedCallLogsGetListRequest(this OcipClient client, UserEnhancedCallLogsGetListRequest request)
        {
            return await client.Call(request) as UserEnhancedCallLogsGetListResponse;
        }

        /// <summary>
        /// Request to get the user information. The response is either UserGetResponse14
        /// or ErrorResponse.
        /// </summary>
        public static async Task<UserGetResponse14> UserGetRequest14(this OcipClient client, UserGetRequest14 request)
        {
            return await client.Call(request) as UserGetResponse14;
        }

        /// <summary>
        /// Request to get the user information. The response is either UserGetResponse14sp4
        /// or ErrorResponse.
        /// </summary>
        public static async Task<UserGetResponse14sp4> UserGetRequest14sp4(this OcipClient client, UserGetRequest14sp4 request)
        {
            return await client.Call(request) as UserGetResponse14sp4;
        }

        /// <summary>
        /// Request the user level data associated with Hoteling Guest.
        /// The response is either a UserHotelingGuestGetResponse14 or an ErrorResponse.
        /// </summary>
        public static async Task<UserHotelingGuestGetResponse14> UserHotelingGuestGetRequest14(this OcipClient client, UserHotelingGuestGetRequest14 request)
        {
            return await client.Call(request) as UserHotelingGuestGetResponse14;
        }

        /// <summary>
        /// Request the user level data associated with Hoteling Guest.
        /// The response is either a UserHotelingGuestGetResponse14 or an ErrorResponse.
        /// Replaced by: UserHotelingGuestGetRequest14sp4
        /// </summary>
        public static async Task<UserHotelingGuestGetResponse14> UserHotelingGuestGetRequest14sp2(this OcipClient client, UserHotelingGuestGetRequest14sp2 request)
        {
            return await client.Call(request) as UserHotelingGuestGetResponse14;
        }

        /// <summary>
        /// Request the user level data associated with Hoteling Host.
        /// The response is either a UserHotelingHostGetResponse14 or an ErrorResponse.
        /// Replaced by: UserHotelingHostGetRequest14sp4
        /// </summary>
        public static async Task<UserHotelingHostGetResponse14> UserHotelingHostGetRequest14(this OcipClient client, UserHotelingHostGetRequest14 request)
        {
            return await client.Call(request) as UserHotelingHostGetResponse14;
        }

        /// <summary>
        /// Request to modify a user. The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserModifyRequest14(this OcipClient client, UserModifyRequest14 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the User Personal Assistant information.
        /// The response is either a UserPersonalAssistantGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserPersonalAssistantGetRequest22
        /// </summary>
        public static async Task<UserPersonalAssistantGetResponse> UserPersonalAssistantGetRequest(this OcipClient client, UserPersonalAssistantGetRequest request)
        {
            return await client.Call(request) as UserPersonalAssistantGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Privacy.
        /// The response is either a UserPrivacyGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserPrivacyGetResponse> UserPrivacyGetRequest(this OcipClient client, UserPrivacyGetRequest request)
        {
            return await client.Call(request) as UserPrivacyGetResponse;
        }

        /// <summary>
        /// Get a user's Security Classifications configuration.
        /// The response is either UserSecurityClassificationGetResponse or ErrorResponse.
        /// 
        /// Replaced By: UserSecurityClassificationGetRequest22.
        /// </summary>
        public static async Task<UserSecurityClassificationGetResponse> UserSecurityClassificationGetRequest(this OcipClient client, UserSecurityClassificationGetRequest request)
        {
            return await client.Call(request) as UserSecurityClassificationGetResponse;
        }

        /// <summary>
        /// Get the user's sequential ring service setting.
        /// The response is either a UserSequentialRingGetResponse13mp16 or an ErrorResponse.
        /// Replaced By: UserSequentialRingGetRequest14sp4
        /// </summary>
        public static async Task<UserSequentialRingGetResponse13mp16> UserSequentialRingGetRequest13mp16(this OcipClient client, UserSequentialRingGetRequest13mp16 request)
        {
            return await client.Call(request) as UserSequentialRingGetResponse13mp16;
        }

        /// <summary>
        /// Associate an access device instance to the user's Shared Call Appearance.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSharedCallAppearanceAddEndpointRequest14(this OcipClient client, UserSharedCallAppearanceAddEndpointRequest14 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the user's Shared Call Appearance service setting.
        /// The response is either a UserSharedCallAppearanceGetResponse14 or an ErrorResponse.
        /// Replaced By: UserSharedCallAppearanceGetRequest14sp2
        /// </summary>
        public static async Task<UserSharedCallAppearanceGetResponse14> UserSharedCallAppearanceGetRequest14(this OcipClient client, UserSharedCallAppearanceGetRequest14 request)
        {
            return await client.Call(request) as UserSharedCallAppearanceGetResponse14;
        }

        /// <summary>
        /// Get the user's simultaneous ring service family setting.
        /// The response is either a UserSimultaneousRingFamilyGetResponse or an ErrorResponse.
        /// Replaced By: UserSimultaneousRingFamilyGetRequest14sp4
        /// </summary>
        public static async Task<UserSimultaneousRingFamilyGetResponse> UserSimultaneousRingFamilyGetRequest(this OcipClient client, UserSimultaneousRingFamilyGetRequest request)
        {
            return await client.Call(request) as UserSimultaneousRingFamilyGetResponse;
        }

        /// <summary>
        /// Modify the user's simultaneous ring family service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By: UserSimultaneousRingFamilyModifyRequest14sp4
        /// </summary>
        public static async Task<SuccessResponse> UserSimultaneousRingFamilyModifyRequest(this OcipClient client, UserSimultaneousRingFamilyModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the user's simultaneous ring service personal setting.
        /// The response is either a UserSimultaneousRingPersonalGetResponse or an ErrorResponse.
        /// Replaced By: UserSimultaneousRingPersonalGetRequest14sp4
        /// </summary>
        public static async Task<UserSimultaneousRingPersonalGetResponse> UserSimultaneousRingPersonalGetRequest(this OcipClient client, UserSimultaneousRingPersonalGetRequest request)
        {
            return await client.Call(request) as UserSimultaneousRingPersonalGetResponse;
        }

        /// <summary>
        /// Modify the user's simultaneous ring personal service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By: UserSimultaneousRingPersonalModifyRequest14sp4
        /// </summary>
        public static async Task<SuccessResponse> UserSimultaneousRingPersonalModifyRequest(this OcipClient client, UserSimultaneousRingPersonalModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the user's voice messaging advanced voice management service setting.
        /// The response is either a UserVoiceMessagingUserGetAdvancedVoiceManagementResponse or an ErrorResponse.
        /// Replaced By: UserVoiceMessagingUserGetAdvancedVoiceManagementRequest14sp3
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetAdvancedVoiceManagementResponse> UserVoiceMessagingUserGetAdvancedVoiceManagementRequest(this OcipClient client, UserVoiceMessagingUserGetAdvancedVoiceManagementRequest request)
        {
            return await client.Call(request) as UserVoiceMessagingUserGetAdvancedVoiceManagementResponse;
        }

        /// <summary>
        /// Request the user's voice portal password information.
        /// The response is either a UserVoiceMessagingUserGetVoicePortalPasswordInfoResponse or an ErrorResponse.
        /// Replaced By: UserPortalPasscodeGetInfoRequest
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetVoicePortalPasswordInfoResponse> UserVoiceMessagingUserGetVoicePortalPasswordInfoRequest(this OcipClient client, UserVoiceMessagingUserGetVoicePortalPasswordInfoRequest request)
        {
            return await client.Call(request) as UserVoiceMessagingUserGetVoicePortalPasswordInfoResponse;
        }

        /// <summary>
        /// Modify the user's Voice Portal password
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// Replaced By: UserPortalPasscodeModifyRequest
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyVoicePortalPasswordRequest(this OcipClient client, UserVoiceMessagingUserModifyVoicePortalPasswordRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests the configuration of a specified group access device.
        /// The response is either GroupAccessDeviceGetResponse14sp6 or ErrorResponse.
        /// Replaced by: GroupAccessDeviceGetRequest16
        /// </summary>
        public static async Task<GroupAccessDeviceGetResponse14sp6> GroupAccessDeviceGetRequest14sp6(this OcipClient client, GroupAccessDeviceGetRequest14sp6 request)
        {
            return await client.Call(request) as GroupAccessDeviceGetResponse14sp6;
        }

        /// <summary>
        /// Add a Auto Attendant instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By: GroupAutoAttendantAddInstanceRequest16
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantAddInstanceRequest14(this OcipClient client, GroupAutoAttendantAddInstanceRequest14 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get all the information of a Auto Attendant instance.
        /// The response is either GroupAutoAttendantGetInstanceResponse14 or ErrorResponse.
        /// Replaced By: GroupAutoAttendantGetInstanceRequest16
        /// </summary>
        public static async Task<GroupAutoAttendantGetInstanceResponse14> GroupAutoAttendantGetInstanceRequest14(this OcipClient client, GroupAutoAttendantGetInstanceRequest14 request)
        {
            return await client.Call(request) as GroupAutoAttendantGetInstanceResponse14;
        }

        /// <summary>
        /// Request to modify an Auto Attendant instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By: GroupAutoAttendantModifyInstanceRequest16
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantModifyInstanceRequest(this OcipClient client, GroupAutoAttendantModifyInstanceRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Center instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced By: GroupCallCenterAddInstanceRequest16,
        /// GroupCallCenterAddAgentListRequest,
        /// GroupCallCenterModifyPolicyRequest,
        /// GroupCallCenterModifyAnnouncementRequest16
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterAddInstanceRequest14sp9(this OcipClient client, GroupCallCenterAddInstanceRequest14sp9 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the Call Center Enhanced configuration data for a
        /// Call Center.
        /// The response is either GroupCallCenterEnhancedGetResponse or
        /// ErrorResponse.
        /// 
        /// Replaced By: GroupCallCenterGetInstanceResponse16
        /// </summary>
        public static async Task<GroupCallCenterEnhancedGetResponse> GroupCallCenterEnhancedGetRequest(this OcipClient client, GroupCallCenterEnhancedGetRequest request)
        {
            return await client.Call(request) as GroupCallCenterEnhancedGetResponse;
        }

        /// <summary>
        /// Modify the Call Center Enhanced configuration data for a Call
        /// Center.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced By: GroupCallCenterModifyInstanceRequest16
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterEnhancedModifyRequest(this OcipClient client, GroupCallCenterEnhancedModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a call center's announcement settings.
        /// The response is either a GroupCallCenterGetAnnouncementResponse14sp6 or an ErrorResponse.
        /// 
        /// Replaced By: GroupCallCenterGetAnnouncementRequest16
        /// </summary>
        public static async Task<GroupCallCenterGetAnnouncementResponse14sp6> GroupCallCenterGetAnnouncementRequest14sp6(this OcipClient client, GroupCallCenterGetAnnouncementRequest14sp6 request)
        {
            return await client.Call(request) as GroupCallCenterGetAnnouncementResponse14sp6;
        }

        /// <summary>
        /// Get a list of users that can be assigned to a Call Center group.
        /// Searching for users by group only makes sense when the call center is part of an Enterprise.
        /// The response is either GroupCallCenterGetAvailableUserListResponse or ErrorResponse.
        /// 
        /// Replaced By: GroupCallCenterGetAvailableAgentListRequest and
        /// GroupCallCenterGetAvailableSupervisorListRequest
        /// </summary>
        public static async Task<GroupCallCenterGetAvailableUserListResponse> GroupCallCenterGetAvailableUserListRequest(this OcipClient client, GroupCallCenterGetAvailableUserListRequest request)
        {
            return await client.Call(request) as GroupCallCenterGetAvailableUserListResponse;
        }

        /// <summary>
        /// Request to get all the information of a Call Center instance.
        /// The response is either GroupCallCenterGetInstanceResponse14sp9 or ErrorResponse.
        /// 
        /// Replaced By: GroupCallCenterGetInstanceRequest16
        /// </summary>
        public static async Task<GroupCallCenterGetInstanceResponse14sp9> GroupCallCenterGetInstanceRequest14sp9(this OcipClient client, GroupCallCenterGetInstanceRequest14sp9 request)
        {
            return await client.Call(request) as GroupCallCenterGetInstanceResponse14sp9;
        }

        /// <summary>
        /// Request to get the call center statistics reporting settings.
        /// The response is either GroupCallCenterGetInstanceStatisticsReportingResponse or ErrorResponse.
        /// 
        /// Replaced By: GroupCallCenterGetInstanceStatisticsReportingRequest16
        /// </summary>
        public static async Task<GroupCallCenterGetInstanceStatisticsReportingResponse> GroupCallCenterGetInstanceStatisticsReportingRequest(this OcipClient client, GroupCallCenterGetInstanceStatisticsReportingRequest request)
        {
            return await client.Call(request) as GroupCallCenterGetInstanceStatisticsReportingResponse;
        }

        /// <summary>
        /// Modify a call center's announcement settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced By: GroupCallCenterModifyAnnouncementRequest16
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyAnnouncementRequest14sp6(this OcipClient client, GroupCallCenterModifyAnnouncementRequest14sp6 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Call Center instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced By: GroupCallCenterModifyInstanceRequest16
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyInstanceRequest(this OcipClient client, GroupCallCenterModifyInstanceRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a list of supervisors assigned to a call center.
        /// Only users in the same group or enterprise as this call center
        /// can successfully execute this request.
        /// The response is either a GroupCallCenterSupervisorReportingGetResponse or an
        /// ErrorResponse.
        /// 
        /// Replaced By: GroupCallCenterGetSupervisorListRequest16
        /// </summary>
        public static async Task<GroupCallCenterSupervisorReportingGetResponse> GroupCallCenterSupervisorReportingGetRequest(this OcipClient client, GroupCallCenterSupervisorReportingGetRequest request)
        {
            return await client.Call(request) as GroupCallCenterSupervisorReportingGetResponse;
        }

        /// <summary>
        /// Replaces a list of users as supervisors for a call center.
        /// Also allows the modification of the reporting server URL address.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced By: GroupCallCenterModifySupervisorListRequest16
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterSupervisorReportingModifyRequest(this OcipClient client, GroupCallCenterSupervisorReportingModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse14sp7 or an
        /// ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName)
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls,
        /// maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls,
        /// maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth,
        /// maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations)
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan,
        /// overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
        /// Replaced By: GroupCallProcessingGetPolicyRequest16
        /// </summary>
        public static async Task<GroupCallProcessingGetPolicyResponse14sp7> GroupCallProcessingGetPolicyRequest14sp7(this OcipClient client, GroupCallProcessingGetPolicyRequest14sp7 request)
        {
            return await client.Call(request) as GroupCallProcessingGetPolicyResponse14sp7;
        }

        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse15 or an
        /// ErrorResponse.
        /// Replaced By: GroupCallProcessingGetPolicyRequest16
        /// </summary>
        public static async Task<GroupCallProcessingGetPolicyResponse15> GroupCallProcessingGetPolicyRequest15(this OcipClient client, GroupCallProcessingGetPolicyRequest15 request)
        {
            return await client.Call(request) as GroupCallProcessingGetPolicyResponse15;
        }

        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse15sp2 or an
        /// ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName)
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls,
        /// maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls,
        /// maxCallTimeForUnansweredCallsMinutes,
        /// useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth, maxRedirectionDepth,
        /// useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations)
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan,
        /// overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
        /// </summary>
        public static async Task<GroupCallProcessingGetPolicyResponse15sp2> GroupCallProcessingGetPolicyRequest15sp2(this OcipClient client, GroupCallProcessingGetPolicyRequest15sp2 request)
        {
            return await client.Call(request) as GroupCallProcessingGetPolicyResponse15sp2;
        }

        /// <summary>
        /// Modify the group level data associated with Call Processing Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName)
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls, useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls,
        /// useMaxCallTimeForAnsweredCalls, maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls,
        /// maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth,
        /// maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations)
        /// The useGroupTranslationRoutingSetting attribute controls the routing and
        /// translation settings (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan,
        /// overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
        /// Replaced By: GroupCallProcessingModifyPolicyRequest15sp2
        /// </summary>
        public static async Task<SuccessResponse> GroupCallProcessingModifyPolicyRequest14sp7(this OcipClient client, GroupCallProcessingModifyPolicyRequest14sp7 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group level data associated with Call Processing Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By: GroupCallProcessingModifyPolicyRequest15sp2
        /// </summary>
        public static async Task<SuccessResponse> GroupCallProcessingModifyPolicyRequest15(this OcipClient client, GroupCallProcessingModifyPolicyRequest15 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the group's custom ring back service settings.
        /// The response is either a GroupCustomRingbackGroupGetResponse or an ErrorResponse.
        /// Replaced By: GroupCustomRingbackGroupGetRequest16
        /// </summary>
        public static async Task<GroupCustomRingbackGroupGetResponse> GroupCustomRingbackGroupGetRequest(this OcipClient client, GroupCustomRingbackGroupGetRequest request)
        {
            return await client.Call(request) as GroupCustomRingbackGroupGetResponse;
        }

        /// <summary>
        /// Modify the group's custom ring back service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By: GroupCustomRingbackGroupModifyRequest16
        /// </summary>
        public static async Task<SuccessResponse> GroupCustomRingbackGroupModifyRequest(this OcipClient client, GroupCustomRingbackGroupModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the group's intercept group service settings.
        /// The response is either a GroupInterceptGroupGetResponse or an ErrorResponse.
        /// Replaced By: GroupInterceptGroupGetRequest16
        /// </summary>
        public static async Task<GroupInterceptGroupGetResponse> GroupInterceptGroupGetRequest(this OcipClient client, GroupInterceptGroupGetRequest request)
        {
            return await client.Call(request) as GroupInterceptGroupGetResponse;
        }

        /// <summary>
        /// Get the group's intercept group service settings.
        /// The response is either a GroupInterceptGroupGetResponse16 or an ErrorResponse.
        /// Replaced By: GroupInterceptGroupGetRequest16sp1
        /// </summary>
        public static async Task<GroupInterceptGroupGetResponse16> GroupInterceptGroupGetRequest16(this OcipClient client, GroupInterceptGroupGetRequest16 request)
        {
            return await client.Call(request) as GroupInterceptGroupGetResponse16;
        }

        /// <summary>
        /// Modify the group's intercept group service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By: GroupInterceptGroupModifyRequest16
        /// </summary>
        public static async Task<SuccessResponse> GroupInterceptGroupModifyRequest(this OcipClient client, GroupInterceptGroupModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a Music on Hold Instance to a department.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By: GroupMusicOnHoldAddInstanceRequest16
        /// </summary>
        public static async Task<SuccessResponse> GroupMusicOnHoldAddInstanceRequest14sp6(this OcipClient client, GroupMusicOnHoldAddInstanceRequest14sp6 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse14sp6 or ErrorResponse.
        /// Replaced By: GroupMusicOnHoldGetInstanceRequest16
        /// </summary>
        public static async Task<GroupMusicOnHoldGetInstanceResponse14sp6> GroupMusicOnHoldGetInstanceRequest14sp6(this OcipClient client, GroupMusicOnHoldGetInstanceRequest14sp6 request)
        {
            return await client.Call(request) as GroupMusicOnHoldGetInstanceResponse14sp6;
        }

        /// <summary>
        /// Modify data for a group or department Music On Hold Instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By: GroupMusicOnHoldModifyInstanceRequest16
        /// </summary>
        public static async Task<SuccessResponse> GroupMusicOnHoldModifyInstanceRequest14sp6(this OcipClient client, GroupMusicOnHoldModifyInstanceRequest14sp6 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests the group's password rules setting that is applicable to
        /// users within the group.
        /// The response is either GroupPasswordRulesGetResponse or ErrorResponse.
        /// Replaced by: GroupPasswordRulesGetRequest16
        /// </summary>
        public static async Task<GroupPasswordRulesGetResponse> GroupPasswordRulesGetRequest(this OcipClient client, GroupPasswordRulesGetRequest request)
        {
            return await client.Call(request) as GroupPasswordRulesGetResponse;
        }

        /// <summary>
        /// Add a Trunk Group instance to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupAddInstanceRequest15(this OcipClient client, GroupTrunkGroupAddInstanceRequest15 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse15 or an ErrorResponse.
        /// The response contains a hosted user table with column headings: "User Id", "Last Name",
        /// "First Name", "Hiragana Last Name", "Hiragana First Name".
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceResponse15> GroupTrunkGroupGetInstanceRequest15(this OcipClient client, GroupTrunkGroupGetInstanceRequest15 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceResponse15;
        }

        /// <summary>
        /// Get the group's voice portal branding settings.
        /// The response is either a GroupVoiceMessagingGroupGetVoicePortalBrandingResponse or an ErrorResponse.
        /// Replaced By: GroupVoiceMessagingGroupGetVoicePortalBrandingRequest16
        /// </summary>
        public static async Task<GroupVoiceMessagingGroupGetVoicePortalBrandingResponse> GroupVoiceMessagingGroupGetVoicePortalBrandingRequest(this OcipClient client, GroupVoiceMessagingGroupGetVoicePortalBrandingRequest request)
        {
            return await client.Call(request) as GroupVoiceMessagingGroupGetVoicePortalBrandingResponse;
        }

        /// <summary>
        /// Modify the group's voice portal branding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By: GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest16
        /// </summary>
        public static async Task<SuccessResponse> GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest(this OcipClient client, GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests the configuration of a specified service provider access device.
        /// The response is either ServiceProviderAccessDeviceGetResponse14sp6 or ErrorResponse.
        /// Replaced by: ServiceProviderAccessDeviceGetRequest16
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetResponse14sp6> ServiceProviderAccessDeviceGetRequest14sp6(this OcipClient client, ServiceProviderAccessDeviceGetRequest14sp6 request)
        {
            return await client.Call(request) as ServiceProviderAccessDeviceGetResponse14sp6;
        }

        /// <summary>
        /// Get a service provider or enterprise's answer confirmation settings.
        /// The response is either a ServiceProviderAnswerConfirmationGetResponse or an ErrorResponse.
        /// Replaced By: ServiceProviderAnswerConfirmationGetRequest16
        /// </summary>
        public static async Task<ServiceProviderAnswerConfirmationGetResponse> ServiceProviderAnswerConfirmationGetRequest(this OcipClient client, ServiceProviderAnswerConfirmationGetRequest request)
        {
            return await client.Call(request) as ServiceProviderAnswerConfirmationGetResponse;
        }

        /// <summary>
        /// Modify a service provider or enterprise's answer confirmation settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By: ServiceProviderAnswerConfirmationModifyRequest16
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAnswerConfirmationModifyRequest(this OcipClient client, ServiceProviderAnswerConfirmationModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse14sp7 or an ErrorResponse.
        /// Replaced By: ServiceProviderCallProcessingGetPolicyRequest16
        /// </summary>
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse14sp7> ServiceProviderCallProcessingGetPolicyRequest14sp7(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest14sp7 request)
        {
            return await client.Call(request) as ServiceProviderCallProcessingGetPolicyResponse14sp7;
        }

        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse15 or an ErrorResponse.
        /// Replaced By: ServiceProviderCallProcessingGetPolicyRequest16
        /// </summary>
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse15> ServiceProviderCallProcessingGetPolicyRequest15(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest15 request)
        {
            return await client.Call(request) as ServiceProviderCallProcessingGetPolicyResponse15;
        }

        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse15sp2 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse15sp2> ServiceProviderCallProcessingGetPolicyRequest15sp2(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest15sp2 request)
        {
            return await client.Call(request) as ServiceProviderCallProcessingGetPolicyResponse15sp2;
        }

        /// <summary>
        /// Requests the service provider's password rules setting applicable to
        /// Administrators (Group and Department) and Users.
        /// The response is either ServiceProviderPasswordRulesGetResponse13mp2 or ErrorResponse.
        /// Replaced By: ServiceProviderPasswordRulesGetRequest16
        /// </summary>
        public static async Task<ServiceProviderPasswordRulesGetResponse13mp2> ServiceProviderPasswordRulesGetRequest13mp2(this OcipClient client, ServiceProviderPasswordRulesGetRequest13mp2 request)
        {
            return await client.Call(request) as ServiceProviderPasswordRulesGetResponse13mp2;
        }

        /// <summary>
        /// Get the service provider's voice portal branding settings.
        /// The response is either a ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingResponse or an
        /// ErrorResponse.
        /// Replaced By: ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingRequest16
        /// </summary>
        public static async Task<ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingResponse> ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingRequest(this OcipClient client, ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingRequest request)
        {
            return await client.Call(request) as ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingResponse;
        }

        /// <summary>
        /// Modify the service provider's voice portal branding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By: ServiceProviderVoiceMessagingGroupModifyVoicePortalBrandingRequest16
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderVoiceMessagingGroupModifyVoicePortalBrandingRequest(this OcipClient client, ServiceProviderVoiceMessagingGroupModifyVoicePortalBrandingRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests the configuration of a specified system access device.
        /// The response is either SystemAccessDeviceGetResponse14sp6 or ErrorResponse.
        /// Replaced by: SystemAccessDeviceGetRequest16
        /// </summary>
        public static async Task<SystemAccessDeviceGetResponse14sp6> SystemAccessDeviceGetRequest14sp6(this OcipClient client, SystemAccessDeviceGetRequest14sp6 request)
        {
            return await client.Call(request) as SystemAccessDeviceGetResponse14sp6;
        }

        /// <summary>
        /// Request the system's automatic callback attributes.
        /// The response is either a SystemAutomaticCallbackGetResponse15 or an ErrorResponse.
        /// Replaced By: SystemAutomaticCallbackGetRequest15sp2
        /// </summary>
        public static async Task<SystemAutomaticCallbackGetResponse15> SystemAutomaticCallbackGetRequest15(this OcipClient client, SystemAutomaticCallbackGetRequest15 request)
        {
            return await client.Call(request) as SystemAutomaticCallbackGetResponse15;
        }

        /// <summary>
        /// Request the system level data associated with Call Center.
        /// The response is either a SystemCallCenterGetResponse14sp9 or an
        /// ErrorResponse.
        /// 
        /// Replaced By: SystemCallCenterGetRequest16
        /// </summary>
        public static async Task<SystemCallCenterGetResponse14sp9> SystemCallCenterGetRequest14sp9(this OcipClient client, SystemCallCenterGetRequest14sp9 request)
        {
            return await client.Call(request) as SystemCallCenterGetResponse14sp9;
        }

        /// <summary>
        /// Request the system level data associated with Call Processing Policy.
        /// The response is either a SystemCallProcessingGetPolicyResponse14sp7 or an
        /// ErrorResponse.
        /// Replaced By: SystemCallProcessingGetPolicyRequest16
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse14sp7> SystemCallProcessingGetPolicyRequest14sp7(this OcipClient client, SystemCallProcessingGetPolicyRequest14sp7 request)
        {
            return await client.Call(request) as SystemCallProcessingGetPolicyResponse14sp7;
        }

        /// <summary>
        /// Request the system level data associated with Call Processing Policy.
        /// The response is either a SystemCallProcessingGetPolicyResponse15 or an
        /// ErrorResponse.
        /// Replaced By: SystemCallProcessingGetPolicyRequest15sp2
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse15> SystemCallProcessingGetPolicyRequest15(this OcipClient client, SystemCallProcessingGetPolicyRequest15 request)
        {
            return await client.Call(request) as SystemCallProcessingGetPolicyResponse15;
        }

        /// <summary>
        /// Request the system level data associated with Call Processing Policy.
        /// The response is either a SystemCallProcessingGetPolicyResponse15sp2 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse15sp2> SystemCallProcessingGetPolicyRequest15sp2(this OcipClient client, SystemCallProcessingGetPolicyRequest15sp2 request)
        {
            return await client.Call(request) as SystemCallProcessingGetPolicyResponse15sp2;
        }

        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a SystemCommunicationBarringProfileGetResponse
        /// or an ErrorResponse.
        /// Replaced by: SystemCommunicationBarringProfileGetRequest16
        /// </summary>
        public static async Task<SystemCommunicationBarringProfileGetResponse> SystemCommunicationBarringProfileGetRequest(this OcipClient client, SystemCommunicationBarringProfileGetRequest request)
        {
            return await client.Call(request) as SystemCommunicationBarringProfileGetResponse;
        }

        /// <summary>
        /// Get all the attributes of a configurable treatment.
        /// The response is either a SystemConfigurableTreatmentGetResponse or an ErrorResponse.
        /// Replaced By: SystemConfigurableTreatmentGetRequest16
        /// </summary>
        public static async Task<SystemConfigurableTreatmentGetResponse> SystemConfigurableTreatmentGetRequest(this OcipClient client, SystemConfigurableTreatmentGetRequest request)
        {
            return await client.Call(request) as SystemConfigurableTreatmentGetResponse;
        }

        /// <summary>
        /// Requests the information about the specified device type without regard to whether the
        /// type is SIP or MGCP.
        /// The response is either SystemDeviceTypeGetResponse14sp6 or ErrorResponse.
        /// Replaced by: SystemDeviceTypeGetRequest16
        /// </summary>
        public static async Task<SystemDeviceTypeGetResponse14sp6> SystemDeviceTypeGetRequest14sp6(this OcipClient client, SystemDeviceTypeGetRequest14sp6 request)
        {
            return await client.Call(request) as SystemDeviceTypeGetResponse14sp6;
        }

        /// <summary>
        /// Add a new file repository.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemFileRepositoryDeviceAddRequest16
        /// </summary>
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceAddRequest(this OcipClient client, SystemFileRepositoryDeviceAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the file repository information.
        /// The response is either SystemFileRepositoryDeviceGetResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemFileRepositoryDeviceGetRequest16
        /// </summary>
        public static async Task<SystemFileRepositoryDeviceGetResponse> SystemFileRepositoryDeviceGetRequest(this OcipClient client, SystemFileRepositoryDeviceGetRequest request)
        {
            return await client.Call(request) as SystemFileRepositoryDeviceGetResponse;
        }

        /// <summary>
        /// Request to add a Media to the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemMediaAddRequest(this OcipClient client, SystemMediaAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the list of Network Server Sync system parameters.
        /// The response is either SystemNetworkServerSyncParametersGetResponse14sp2 or ErrorResponse.
        /// Replaced By: SystemNetworkServerSyncParametersGetRequest16
        /// </summary>
        public static async Task<SystemNetworkServerSyncParametersGetResponse14sp2> SystemNetworkServerSyncParametersGetRequest14sp2(this OcipClient client, SystemNetworkServerSyncParametersGetRequest14sp2 request)
        {
            return await client.Call(request) as SystemNetworkServerSyncParametersGetResponse14sp2;
        }

        /// <summary>
        /// Requests the system's password rules setting applicable to
        /// System administrator, Provisioning Administrator,
        /// and/or Service Provider Administrator, Group Administrator, Department Administrator, user.
        /// The response is either SystemPasswordRulesGetResponse13mp2 or ErrorResponse.
        /// Replaced By : SystemPasswordRulesGetRequest16
        /// </summary>
        public static async Task<SystemPasswordRulesGetResponse13mp2> SystemPasswordRulesGetRequest13mp2(this OcipClient client, SystemPasswordRulesGetRequest13mp2 request)
        {
            return await client.Call(request) as SystemPasswordRulesGetResponse13mp2;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By : SystemSIPDeviceTypeAddRequest16
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest15(this OcipClient client, SystemSIPDeviceTypeAddRequest15 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse15 or ErrorResponse.
        /// Replaced By : SystemSIPDeviceTypeGetRequest16
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse15> SystemSIPDeviceTypeGetRequest15(this OcipClient client, SystemSIPDeviceTypeGetRequest15 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse15;
        }

        /// <summary>
        /// Request to modify a sip device type.
        /// The following elements are not changeable:
        /// numberOfPorts
        /// SignalingAddressType
        /// isConferenceDevice
        /// isMusicOnHoldDevice
        /// isMobilityManagerDevice
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By : SystemSIPDeviceTypeModifyRequest16
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeModifyRequest15(this OcipClient client, SystemSIPDeviceTypeModifyRequest15 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the system call processing configuration for all subscribers
        /// The response is either a SystemSubscriberGetCallProcessingParametersResponse14sp7 or an ErrorResponse.
        /// Replaced By : SystemSubscriberGetCallProcessingParametersRequest15sp2
        /// </summary>
        public static async Task<SystemSubscriberGetCallProcessingParametersResponse14sp7> SystemSubscriberGetCallProcessingParametersRequest14sp7(this OcipClient client, SystemSubscriberGetCallProcessingParametersRequest14sp7 request)
        {
            return await client.Call(request) as SystemSubscriberGetCallProcessingParametersResponse14sp7;
        }

        /// <summary>
        /// Get the system call processing configuration for all subscribers
        /// The response is either a SystemSubscriberGetCallProcessingParametersResponse15 or an ErrorResponse.
        /// Replaced By: SystemSubscriberGetCallProcessingParametersRequest15sp2
        /// </summary>
        public static async Task<SystemSubscriberGetCallProcessingParametersResponse15> SystemSubscriberGetCallProcessingParametersRequest15(this OcipClient client, SystemSubscriberGetCallProcessingParametersRequest15 request)
        {
            return await client.Call(request) as SystemSubscriberGetCallProcessingParametersResponse15;
        }

        /// <summary>
        /// Request the system level data associated with Voice Messaging.
        /// The response is either a SystemVoiceMessagingGroupGetResponse14 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemVoiceMessagingGroupGetRequest16
        /// </summary>
        public static async Task<SystemVoiceMessagingGroupGetResponse14> SystemVoiceMessagingGroupGetRequest14(this OcipClient client, SystemVoiceMessagingGroupGetRequest14 request)
        {
            return await client.Call(request) as SystemVoiceMessagingGroupGetResponse14;
        }

        /// <summary>
        /// Modify the system level data associated with Voice Messaging.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemVoiceMessagingGroupModifyRequest(this OcipClient client, SystemVoiceMessagingGroupModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a criteria to the user's BroadWorks Anywhere phone number.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksAnywhereAddSelectiveCriteriaRequest(this OcipClient client, UserBroadWorksAnywhereAddSelectiveCriteriaRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a criteria for the user's BroadWorks Anywhere phone number.
        /// The response is either a UserBroadWorksAnywhereGetSelectiveCriteriaResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserBroadWorksAnywhereGetSelectiveCriteriaResponse> UserBroadWorksAnywhereGetSelectiveCriteriaRequest(this OcipClient client, UserBroadWorksAnywhereGetSelectiveCriteriaRequest request)
        {
            return await client.Call(request) as UserBroadWorksAnywhereGetSelectiveCriteriaResponse;
        }

        /// <summary>
        /// Get the user's ACD state and the list of call centers the specified user belongs to.
        /// The response is either a UserCallCenterGetResponse or an ErrorResponse.
        /// 
        /// Replaced By: UserCallCenterGetRequest16
        /// </summary>
        public static async Task<UserCallCenterGetResponse> UserCallCenterGetRequest(this OcipClient client, UserCallCenterGetRequest request)
        {
            return await client.Call(request) as UserCallCenterGetResponse;
        }

        /// <summary>
        /// Add a criteria to the user's call forwarding selective service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallForwardingSelectiveAddCriteriaRequest(this OcipClient client, UserCallForwardingSelectiveAddCriteriaRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a criteria for the user's call forwarding selective service.
        /// The response is either a UserCallForwardingSelectiveGetCriteriaResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallForwardingSelectiveGetCriteriaResponse> UserCallForwardingSelectiveGetCriteriaRequest(this OcipClient client, UserCallForwardingSelectiveGetCriteriaRequest request)
        {
            return await client.Call(request) as UserCallForwardingSelectiveGetCriteriaResponse;
        }

        /// <summary>
        /// Get the user's call forwarding selective service setting.
        /// The response is either a UserCallForwardingSelectiveGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallForwardingSelectiveGetResponse> UserCallForwardingSelectiveGetRequest(this OcipClient client, UserCallForwardingSelectiveGetRequest request)
        {
            return await client.Call(request) as UserCallForwardingSelectiveGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Calling Party Category.
        /// The response is either a UserCallingPartyCategoryGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallingPartyCategoryGetResponse> UserCallingPartyCategoryGetRequest(this OcipClient client, UserCallingPartyCategoryGetRequest request)
        {
            return await client.Call(request) as UserCallingPartyCategoryGetResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Calling Party Category.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallingPartyCategoryModifyRequest(this OcipClient client, UserCallingPartyCategoryModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a criteria to the user's call notify service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCallNotifyAddCriteriaRequest(this OcipClient client, UserCallNotifyAddCriteriaRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a criteria for the user's call notify service.
        /// The response is either a UserCallNotifyGetCriteriaResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallNotifyGetCriteriaResponse> UserCallNotifyGetCriteriaRequest(this OcipClient client, UserCallNotifyGetCriteriaRequest request)
        {
            return await client.Call(request) as UserCallNotifyGetCriteriaResponse;
        }

        /// <summary>
        /// Request the user level data associated with Call Processing Policy.
        /// The response is either a UserCallProcessingGetPolicyResponse14sp7 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallProcessingGetPolicyResponse14sp7> UserCallProcessingGetPolicyRequest14sp7(this OcipClient client, UserCallProcessingGetPolicyRequest14sp7 request)
        {
            return await client.Call(request) as UserCallProcessingGetPolicyResponse14sp7;
        }

        /// <summary>
        /// Add a criteria to the user's custom ringback service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserCustomRingbackUserAddCriteriaRequest(this OcipClient client, UserCustomRingbackUserAddCriteriaRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a criteria for the user's custom ringback service.
        /// The response is either a UserCustomRingbackUserGetCriteriaResponse or an ErrorResponse.
        /// Replaced By: UserCustomRingbackUserGetCriteriaRequest15Sp2
        /// </summary>
        public static async Task<UserCustomRingbackUserGetCriteriaResponse> UserCustomRingbackUserGetCriteriaRequest(this OcipClient client, UserCustomRingbackUserGetCriteriaRequest request)
        {
            return await client.Call(request) as UserCustomRingbackUserGetCriteriaResponse;
        }

        /// <summary>
        /// Get a criteria for the user's custom ringback service.
        /// The response is either a UserCustomRingbackUserGetCriteriaResponse15sp2 or an ErrorResponse.
        /// Replaced By: UserCustomRingbackUserGetCriteriaRequest16
        /// </summary>
        public static async Task<UserCustomRingbackUserGetCriteriaResponse15sp2> UserCustomRingbackUserGetCriteriaRequest15sp2(this OcipClient client, UserCustomRingbackUserGetCriteriaRequest15sp2 request)
        {
            return await client.Call(request) as UserCustomRingbackUserGetCriteriaResponse15sp2;
        }

        /// <summary>
        /// Modify a criteria for the user's custom ringback service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By: UserCustomRingbackUserModifyCriteriaRequest16
        /// </summary>
        public static async Task<SuccessResponse> UserCustomRingbackUserModifyCriteriaRequest(this OcipClient client, UserCustomRingbackUserModifyCriteriaRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request user's call logs. It is possible to get a subset of the total list of calls
        /// by specifying a starting offset and the number of calls to get.
        /// If the callLogType is not specified, all types of calls are returned.
        /// The response is either a UserEnhancedCallLogsGetListResponse14sp4 or an ErrorResponse.
        /// Replaced by:
        /// UserEnhancedCallLogsGetListRequest16
        /// </summary>
        public static async Task<UserEnhancedCallLogsGetListResponse14sp4> UserEnhancedCallLogsGetListRequest14sp4(this OcipClient client, UserEnhancedCallLogsGetListRequest14sp4 request)
        {
            return await client.Call(request) as UserEnhancedCallLogsGetListResponse14sp4;
        }

        /// <summary>
        /// Request to get the user information. The response is either UserGetResponse14sp4
        /// or ErrorResponse.
        /// </summary>
        public static async Task<UserGetResponse14sp4> UserGetRequest14sp9(this OcipClient client, UserGetRequest14sp9 request)
        {
            return await client.Call(request) as UserGetResponse14sp4;
        }

        /// <summary>
        /// Get the user's intercept user service settings.
        /// The response is either a UserInterceptUserGetResponse or an ErrorResponse.
        /// Replaced By: UserInterceptUserGetRequest16
        /// </summary>
        public static async Task<UserInterceptUserGetResponse> UserInterceptUserGetRequest(this OcipClient client, UserInterceptUserGetRequest request)
        {
            return await client.Call(request) as UserInterceptUserGetResponse;
        }

        /// <summary>
        /// Get the user's intercept user service settings.
        /// The response is either a UserInterceptUserGetResponse16 or an ErrorResponse.
        /// Replaced By: UserInterceptUserGetRequest16sp1
        /// </summary>
        public static async Task<UserInterceptUserGetResponse16> UserInterceptUserGetRequest16(this OcipClient client, UserInterceptUserGetRequest16 request)
        {
            return await client.Call(request) as UserInterceptUserGetResponse16;
        }

        /// <summary>
        /// Modify the user's intercept user service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By: UserInterceptUserModifyRequest16
        /// </summary>
        public static async Task<SuccessResponse> UserInterceptUserModifyRequest(this OcipClient client, UserInterceptUserModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a user. The response is either SuccessResponse or ErrorResponse.
        /// Replaced by: UserModifyRequest16
        /// </summary>
        public static async Task<SuccessResponse> UserModifyRequest14sp9(this OcipClient client, UserModifyRequest14sp9 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the user level data associated with Music On Hold User.
        /// The response is either a UserMusicOnHoldUserGetResponse or an ErrorResponse.
        /// Replaced By: UserMusicOnHoldUserGetRequest16
        /// </summary>
        public static async Task<UserMusicOnHoldUserGetResponse> UserMusicOnHoldUserGetRequest(this OcipClient client, UserMusicOnHoldUserGetRequest request)
        {
            return await client.Call(request) as UserMusicOnHoldUserGetResponse;
        }

        /// <summary>
        /// Modify data for Music On Hold User.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By: UserMusicOnHoldUserModifyRequest16
        /// </summary>
        public static async Task<SuccessResponse> UserMusicOnHoldUserModifyRequest(this OcipClient client, UserMusicOnHoldUserModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a criteria to the user's priority alert service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserPriorityAlertAddCriteriaRequest(this OcipClient client, UserPriorityAlertAddCriteriaRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a criteria for the user's priority alert service.
        /// The response is either a UserPriorityAlertGetCriteriaResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserPriorityAlertGetCriteriaResponse> UserPriorityAlertGetCriteriaRequest(this OcipClient client, UserPriorityAlertGetCriteriaRequest request)
        {
            return await client.Call(request) as UserPriorityAlertGetCriteriaResponse;
        }

        /// <summary>
        /// Add a criteria to the user's selective call acceptance service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSelectiveCallAcceptanceAddCriteriaRequest(this OcipClient client, UserSelectiveCallAcceptanceAddCriteriaRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a criteria for the user's selective call acceptance service.
        /// The response is either a UserSelectiveCallAcceptanceGetCriteriaResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserSelectiveCallAcceptanceGetCriteriaResponse> UserSelectiveCallAcceptanceGetCriteriaRequest(this OcipClient client, UserSelectiveCallAcceptanceGetCriteriaRequest request)
        {
            return await client.Call(request) as UserSelectiveCallAcceptanceGetCriteriaResponse;
        }

        /// <summary>
        /// Add a criteria to the user's selective call rejection service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSelectiveCallRejectionAddCriteriaRequest(this OcipClient client, UserSelectiveCallRejectionAddCriteriaRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a criteria for the user's selective call rejection service.
        /// The response is either a UserSelectiveCallRejectionGetCriteriaResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserSelectiveCallRejectionGetCriteriaResponse> UserSelectiveCallRejectionGetCriteriaRequest(this OcipClient client, UserSelectiveCallRejectionGetCriteriaRequest request)
        {
            return await client.Call(request) as UserSelectiveCallRejectionGetCriteriaResponse;
        }

        /// <summary>
        /// Modify a criteria for the user's selective call rejection service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSelectiveCallRejectionModifyCriteriaRequest(this OcipClient client, UserSelectiveCallRejectionModifyCriteriaRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a criteria to the user's sequential ring service.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSequentialRingAddCriteriaRequest(this OcipClient client, UserSequentialRingAddCriteriaRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a criteria for the user's sequential ring service.
        /// The response is either a UserSequentialRingGetCriteriaResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserSequentialRingGetCriteriaResponse> UserSequentialRingGetCriteriaRequest(this OcipClient client, UserSequentialRingGetCriteriaRequest request)
        {
            return await client.Call(request) as UserSequentialRingGetCriteriaResponse;
        }

        /// <summary>
        /// Get the user's voice messaging greeting information.
        /// The response is either a UserVoiceMessagingUserGetGreetingResponse13mp16 or an ErrorResponse.
        /// Replaced By: UserVoiceMessagingUserGetGreetingRequest16
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetGreetingResponse13mp16> UserVoiceMessagingUserGetGreetingRequest13mp16(this OcipClient client, UserVoiceMessagingUserGetGreetingRequest13mp16 request)
        {
            return await client.Call(request) as UserVoiceMessagingUserGetGreetingResponse13mp16;
        }

        /// <summary>
        /// Get the user's voice messaging voice portal settings.
        /// The response is either a UserVoiceMessagingUserGetVoicePortalResponse or an ErrorResponse.
        /// Replaced By: UserVoiceMessagingUserGetVoicePortalRequest16
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetVoicePortalResponse> UserVoiceMessagingUserGetVoicePortalRequest(this OcipClient client, UserVoiceMessagingUserGetVoicePortalRequest request)
        {
            return await client.Call(request) as UserVoiceMessagingUserGetVoicePortalResponse;
        }

        /// <summary>
        /// Modify the user's voice messaging greeting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// Replaced By: UserVoiceMessagingUserModifyGreetingRequest16
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyGreetingRequest(this OcipClient client, UserVoiceMessagingUserModifyGreetingRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's voice messaging voice portal settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// Replaced By: UserVoiceMessagingUserModifyVoicePortalRequest16
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyVoicePortalRequest(this OcipClient client, UserVoiceMessagingUserModifyVoicePortalRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the address and credentials of the File Repository hosting the requested access device file. Also
        /// get the file name and path on the File Repository. The response is either a DeviceManagementFileAuthLocationGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<DeviceManagementFileAuthLocationGetResponse> DeviceManagementFileAuthLocationGetRequest(this OcipClient client, DeviceManagementFileAuthLocationGetRequest request)
        {
            return await client.Call(request) as DeviceManagementFileAuthLocationGetResponse;
        }

        /// <summary>
        /// Request a table containing the phone directory for an enterprise.
        /// The directory includes all users in the enterprise and all entries in the enterprise common phone list.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either EnterprisePhoneDirectoryGetListResponse or ErrorResponse.
        /// Replace by: EnterprisePhoneDirectoryGetListRequest17
        /// </summary>
        public static async Task<EnterprisePhoneDirectoryGetListResponse> EnterprisePhoneDirectoryGetListRequest(this OcipClient client, EnterprisePhoneDirectoryGetListRequest request)
        {
            return await client.Call(request) as EnterprisePhoneDirectoryGetListResponse;
        }

        /// <summary>
        /// Request to get a group device profile file.
        /// The response is either GroupAccessDeviceFileGetResponse14sp8 or ErrorResponse.
        /// Replaced by: GroupAccessDeviceFileGetRequest16sp1
        /// </summary>
        public static async Task<GroupAccessDeviceFileGetResponse14sp8> GroupAccessDeviceFileGetRequest14sp8(this OcipClient client, GroupAccessDeviceFileGetRequest14sp8 request)
        {
            return await client.Call(request) as GroupAccessDeviceFileGetResponse14sp8;
        }

        /// <summary>
        /// Requests the Group administrator's policy settings.
        /// The response is either GroupAdminGetPolicyResponse14sp1 or ErrorResponse.
        /// </summary>
        public static async Task<GroupAdminGetPolicyResponse14sp1> GroupAdminGetPolicyRequest14sp1(this OcipClient client, GroupAdminGetPolicyRequest14sp1 request)
        {
            return await client.Call(request) as GroupAdminGetPolicyResponse14sp1;
        }

        /// <summary>
        /// Requests the Group administrator's policy settings.
        /// The response is either GroupAdminGetPolicyResponse16sp1 or ErrorResponse.
        /// Replaced by: GroupAdminGetPolicyRequest17
        /// </summary>
        public static async Task<GroupAdminGetPolicyResponse16sp1> GroupAdminGetPolicyRequest16sp1(this OcipClient client, GroupAdminGetPolicyRequest16sp1 request)
        {
            return await client.Call(request) as GroupAdminGetPolicyResponse16sp1;
        }

        /// <summary>
        /// Requests the Group administrator's policy settings.
        /// The response is either GroupAdminGetPolicyResponse16sp2 or ErrorResponse.
        /// </summary>
        public static async Task<GroupAdminGetPolicyResponse16sp2> GroupAdminGetPolicyRequest16sp2(this OcipClient client, GroupAdminGetPolicyRequest16sp2 request)
        {
            return await client.Call(request) as GroupAdminGetPolicyResponse16sp2;
        }

        /// <summary>
        /// Request to get all the information of a Auto Attendant instance.
        /// The response is either GroupAutoAttendantGetInstanceResponse16 or ErrorResponse.
        /// </summary>
        public static async Task<GroupAutoAttendantGetInstanceResponse16> GroupAutoAttendantGetInstanceRequest16(this OcipClient client, GroupAutoAttendantGetInstanceRequest16 request)
        {
            return await client.Call(request) as GroupAutoAttendantGetInstanceResponse16;
        }

        /// <summary>
        /// Request to get all the information of a BroadWorks Anywhere instance.
        /// The response is either GroupBroadWorksAnywhereGetInstanceResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupBroadWorksAnywhereGetInstanceResponse> GroupBroadWorksAnywhereGetInstanceRequest(this OcipClient client, GroupBroadWorksAnywhereGetInstanceRequest request)
        {
            return await client.Call(request) as GroupBroadWorksAnywhereGetInstanceResponse;
        }

        /// <summary>
        /// Add a Call Center instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced by: GroupCallCenterAddInstanceRequest17
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterAddInstanceRequest16(this OcipClient client, GroupCallCenterAddInstanceRequest16 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a call center's bounced call settings.
        /// The response is either a GroupCallCenterBouncedCallGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupCallCenterBouncedCallGetRequest17
        /// </summary>
        public static async Task<GroupCallCenterBouncedCallGetResponse> GroupCallCenterBouncedCallGetRequest(this OcipClient client, GroupCallCenterBouncedCallGetRequest request)
        {
            return await client.Call(request) as GroupCallCenterBouncedCallGetResponse;
        }

        /// <summary>
        /// Get a call center's comfort message bypass settings.
        /// The response is either a GroupCallCenterComfortMessageBypassGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterComfortMessageBypassGetResponse> GroupCallCenterComfortMessageBypassGetRequest(this OcipClient client, GroupCallCenterComfortMessageBypassGetRequest request)
        {
            return await client.Call(request) as GroupCallCenterComfortMessageBypassGetResponse;
        }

        /// <summary>
        /// Modify a call center's comfort message bypass settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterComfortMessageBypassModifyRequest(this OcipClient client, GroupCallCenterComfortMessageBypassModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a call center's forced forwarding settings.
        /// The response is either a GroupCallCenterForcedForwardingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterForcedForwardingGetResponse> GroupCallCenterForcedForwardingGetRequest(this OcipClient client, GroupCallCenterForcedForwardingGetRequest request)
        {
            return await client.Call(request) as GroupCallCenterForcedForwardingGetResponse;
        }

        /// <summary>
        /// Modify a call center's forced forwarding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterForcedForwardingModifyRequest(this OcipClient client, GroupCallCenterForcedForwardingModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a call center's announcement settings.
        /// The response is either a GroupCallCenterGetAnnouncementResponse16 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetAnnouncementResponse16> GroupCallCenterGetAnnouncementRequest16(this OcipClient client, GroupCallCenterGetAnnouncementRequest16 request)
        {
            return await client.Call(request) as GroupCallCenterGetAnnouncementResponse16;
        }

        /// <summary>
        /// Request to get all the information of a Call Center instance.
        /// The response is either GroupCallCenterGetInstanceResponse16 or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetInstanceResponse16> GroupCallCenterGetInstanceRequest16(this OcipClient client, GroupCallCenterGetInstanceRequest16 request)
        {
            return await client.Call(request) as GroupCallCenterGetInstanceResponse16;
        }

        /// <summary>
        /// Get a call center's holiday service settings.
        /// The response is either a GroupCallCenterHolidayServiceGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterHolidayServiceGetResponse> GroupCallCenterHolidayServiceGetRequest(this OcipClient client, GroupCallCenterHolidayServiceGetRequest request)
        {
            return await client.Call(request) as GroupCallCenterHolidayServiceGetResponse;
        }

        /// <summary>
        /// Modify a call center's holiday service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterHolidayServiceModifyRequest(this OcipClient client, GroupCallCenterHolidayServiceModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call center's announcement settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyAnnouncementRequest16(this OcipClient client, GroupCallCenterModifyAnnouncementRequest16 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a call center's night service settings.
        /// The response is either a GroupCallCenterNightServiceGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterNightServiceGetResponse> GroupCallCenterNightServiceGetRequest(this OcipClient client, GroupCallCenterNightServiceGetRequest request)
        {
            return await client.Call(request) as GroupCallCenterNightServiceGetResponse;
        }

        /// <summary>
        /// Modify a call center's night service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterNightServiceModifyRequest(this OcipClient client, GroupCallCenterNightServiceModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a call center's overflow settings.
        /// The response is either a GroupCallCenterOverflowGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterOverflowGetResponse> GroupCallCenterOverflowGetRequest(this OcipClient client, GroupCallCenterOverflowGetRequest request)
        {
            return await client.Call(request) as GroupCallCenterOverflowGetResponse;
        }

        /// <summary>
        /// Modify a call center's overflow settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterOverflowModifyRequest(this OcipClient client, GroupCallCenterOverflowModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a call center's stranded call settings.
        /// The response is either a GroupCallCenterStrandedCallGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterStrandedCallGetResponse> GroupCallCenterStrandedCallGetRequest(this OcipClient client, GroupCallCenterStrandedCallGetRequest request)
        {
            return await client.Call(request) as GroupCallCenterStrandedCallGetResponse;
        }

        /// <summary>
        /// Modify a call center's stranded call settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterStrandedCallModifyRequest(this OcipClient client, GroupCallCenterStrandedCallModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse16 or an
        /// ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName)
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls,
        /// maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls,
        /// maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth,
        /// maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations)
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan,
        /// overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
        /// </summary>
        public static async Task<GroupCallProcessingGetPolicyResponse16> GroupCallProcessingGetPolicyRequest16(this OcipClient client, GroupCallProcessingGetPolicyRequest16 request)
        {
            return await client.Call(request) as GroupCallProcessingGetPolicyResponse16;
        }

        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse16sp2 or an
        /// ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName)
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls,
        /// maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls,
        /// maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth,
        /// maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations)
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan,
        /// overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
        /// The useGroupDCLIDSetting controls the Dialable Caller ID settings (enableDialableCallerID)
        /// </summary>
        public static async Task<GroupCallProcessingGetPolicyResponse16sp2> GroupCallProcessingGetPolicyRequest16sp2(this OcipClient client, GroupCallProcessingGetPolicyRequest16sp2 request)
        {
            return await client.Call(request) as GroupCallProcessingGetPolicyResponse16sp2;
        }

        /// <summary>
        /// Adds a Custom Contact Directory to a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replace by: GroupCustomContactDirectoryAddRequest17
        /// </summary>
        public static async Task<SuccessResponse> GroupCustomContactDirectoryAddRequest(this OcipClient client, GroupCustomContactDirectoryAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a list of users that can be part of a custom contact directory.
        /// The response is either GroupCustomContactDirectoryGetAvailableUserListResponse or ErrorResponse.
        /// Replace by: GroupCustomContactDirectoryGetAvailableUserListRequest17
        /// </summary>
        public static async Task<GroupCustomContactDirectoryGetAvailableUserListResponse> GroupCustomContactDirectoryGetAvailableUserListRequest(this OcipClient client, GroupCustomContactDirectoryGetAvailableUserListRequest request)
        {
            return await client.Call(request) as GroupCustomContactDirectoryGetAvailableUserListResponse;
        }

        /// <summary>
        /// Gets a Custom Contact Directory in a group.
        /// The response is either GroupCustomContactDirectoryGetResponse or ErrorResponse.
        /// Replace by: GroupCustomContactDirectoryGetRequest17
        /// </summary>
        public static async Task<GroupCustomContactDirectoryGetResponse> GroupCustomContactDirectoryGetRequest(this OcipClient client, GroupCustomContactDirectoryGetRequest request)
        {
            return await client.Call(request) as GroupCustomContactDirectoryGetResponse;
        }

        /// <summary>
        /// Adds a Custom Contact Directory to a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replace by: GroupCustomContactDirectoryModifyRequest17
        /// </summary>
        public static async Task<SuccessResponse> GroupCustomContactDirectoryModifyRequest(this OcipClient client, GroupCustomContactDirectoryModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get a group device type file.
        /// The response is either GroupDeviceTypeFileGetResponse14sp8 or ErrorResponse.
        /// Replaced by: GroupDeviceTypeFileGetRequest16sp1
        /// </summary>
        public static async Task<GroupDeviceTypeFileGetResponse14sp8> GroupDeviceTypeFileGetRequest14sp8(this OcipClient client, GroupDeviceTypeFileGetRequest14sp8 request)
        {
            return await client.Call(request) as GroupDeviceTypeFileGetResponse14sp8;
        }

        /// <summary>
        /// Request the Group level data associated with Dial Plan Policy.
        /// The response is either a GroupDialPlanPolicyGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupDialPlanPolicyGetRequest17
        /// </summary>
        public static async Task<GroupDialPlanPolicyGetResponse> GroupDialPlanPolicyGetRequest(this OcipClient client, GroupDialPlanPolicyGetRequest request)
        {
            return await client.Call(request) as GroupDialPlanPolicyGetResponse;
        }

        /// <summary>
        /// Request the group's extension length.
        /// The response is either a GroupExtensionLengthGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupExtensionLengthGetResponse> GroupExtensionLengthGetRequest(this OcipClient client, GroupExtensionLengthGetRequest request)
        {
            return await client.Call(request) as GroupExtensionLengthGetResponse;
        }

        /// <summary>
        /// Modify the group's extension length.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupExtensionLengthModifyRequest(this OcipClient client, GroupExtensionLengthModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a holiday schedule to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupHolidayScheduleAddRequest(this OcipClient client, GroupHolidayScheduleAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a holiday schedule from a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupHolidayScheduleDeleteRequest(this OcipClient client, GroupHolidayScheduleDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a holiday schedule in a group.
        /// The response is either a GroupHolidayScheduleGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupHolidayScheduleGetListResponse> GroupHolidayScheduleGetListRequest(this OcipClient client, GroupHolidayScheduleGetListRequest request)
        {
            return await client.Call(request) as GroupHolidayScheduleGetListResponse;
        }

        /// <summary>
        /// Get a holiday schedule in a group.
        /// The response is either a GroupHolidayScheduleGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupHolidayScheduleGetResponse> GroupHolidayScheduleGetRequest(this OcipClient client, GroupHolidayScheduleGetRequest request)
        {
            return await client.Call(request) as GroupHolidayScheduleGetResponse;
        }

        /// <summary>
        /// Modify a holiday schedule in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupHolidayScheduleModifyRequest(this OcipClient client, GroupHolidayScheduleModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get all the information of a Hunt Group instance.
        /// The response is either GroupHuntGroupGetInstanceResponse14 or ErrorResponse.
        /// </summary>
        public static async Task<GroupHuntGroupGetInstanceResponse14> GroupHuntGroupGetInstanceRequest14(this OcipClient client, GroupHuntGroupGetInstanceRequest14 request)
        {
            return await client.Call(request) as GroupHuntGroupGetInstanceResponse14;
        }

        /// <summary>
        /// Request to get all the information of an Instant Group Call service instance.
        /// The response is either GroupInstantGroupCallGetInstanceResponse14 or ErrorResponse.
        /// </summary>
        public static async Task<GroupInstantGroupCallGetInstanceResponse14> GroupInstantGroupCallGetInstanceRequest14(this OcipClient client, GroupInstantGroupCallGetInstanceRequest14 request)
        {
            return await client.Call(request) as GroupInstantGroupCallGetInstanceResponse14;
        }

        /// <summary>
        /// Request a table containing the phone directory for a group.
        /// If the specified group is part of an enterprise, the directory includes all users in the enterprise
        /// and all entries in the enterprise common phone list and the common phone list of the specified group.
        /// If the specified group is part of a service provider, the directory includes all users in the group
        /// and all entries in the common phone list of the specified group.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either GroupPhoneDirectoryGetListResponse or ErrorResponse.
        /// 
        /// Replace by: GroupPhoneDirectoryGetListRequest17
        /// </summary>
        public static async Task<GroupPhoneDirectoryGetListResponse> GroupPhoneDirectoryGetListRequest(this OcipClient client, GroupPhoneDirectoryGetListRequest request)
        {
            return await client.Call(request) as GroupPhoneDirectoryGetListResponse;
        }

        /// <summary>
        /// Requests the Group's policy settings.
        /// The response is either GroupPolicyGetResponse14sp4 or ErrorResponse.
        /// </summary>
        public static async Task<GroupPolicyGetResponse14sp4> GroupPolicyGetRequest14sp4(this OcipClient client, GroupPolicyGetRequest14sp4 request)
        {
            return await client.Call(request) as GroupPolicyGetResponse14sp4;
        }

        /// <summary>
        /// Add a time schedule to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTimeScheduleAddRequest(this OcipClient client, GroupTimeScheduleAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a time schedule from a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTimeScheduleDeleteRequest(this OcipClient client, GroupTimeScheduleDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request a list of all time schedules in a group.
        /// The response is either a GroupTimeScheduleGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupTimeScheduleGetListResponse> GroupTimeScheduleGetListRequest(this OcipClient client, GroupTimeScheduleGetListRequest request)
        {
            return await client.Call(request) as GroupTimeScheduleGetListResponse;
        }

        /// <summary>
        /// Request to get a group time schedule.
        /// The response is either a GroupTimeScheduleGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupTimeScheduleGetResponse> GroupTimeScheduleGetRequest(this OcipClient client, GroupTimeScheduleGetRequest request)
        {
            return await client.Call(request) as GroupTimeScheduleGetResponse;
        }

        /// <summary>
        /// Modify a specified time schedule in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTimeScheduleModifyRequest(this OcipClient client, GroupTimeScheduleModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a Trunk Group instance to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupAddInstanceRequest15sp2(this OcipClient client, GroupTrunkGroupAddInstanceRequest15sp2 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse15sp2 or an ErrorResponse.
        /// The response contains a hosted user table with column headings: "User Id", "Last Name",
        /// "First Name", "Hiragana Last Name", "Hiragana First Name".
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceResponse15sp2> GroupTrunkGroupGetInstanceRequest15sp2(this OcipClient client, GroupTrunkGroupGetInstanceRequest15sp2 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceResponse15sp2;
        }

        /// <summary>
        /// Request to get the group voice portal information for a voice messaging group.
        /// The response is either GroupVoiceMessagingGroupGetVoicePortalResponse15 or ErrorResponse.
        /// </summary>
        public static async Task<GroupVoiceMessagingGroupGetVoicePortalResponse15> GroupVoiceMessagingGroupGetVoicePortalRequest15(this OcipClient client, GroupVoiceMessagingGroupGetVoicePortalRequest15 request)
        {
            return await client.Call(request) as GroupVoiceMessagingGroupGetVoicePortalResponse15;
        }

        /// <summary>
        /// Request to get a service provider device profile file.
        /// The response is either ServiceProviderAccessDeviceFileGetResponse14sp8 or ErrorResponse.
        /// Replaced by: ServiceProviderAccessDeviceFileGetRequest16sp1
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceFileGetResponse14sp8> ServiceProviderAccessDeviceFileGetRequest14sp8(this OcipClient client, ServiceProviderAccessDeviceFileGetRequest14sp8 request)
        {
            return await client.Call(request) as ServiceProviderAccessDeviceFileGetResponse14sp8;
        }

        /// <summary>
        /// Requests the service provider administrator's policy settings.
        /// The response is either ServiceProviderAdminGetPolicyResponse14 or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAdminGetPolicyResponse14> ServiceProviderAdminGetPolicyRequest14(this OcipClient client, ServiceProviderAdminGetPolicyRequest14 request)
        {
            return await client.Call(request) as ServiceProviderAdminGetPolicyResponse14;
        }

        /// <summary>
        /// Requests the service provider administrator's policy settings.
        /// The response is either ServiceProviderAdminGetPolicyResponse16sp1 or ErrorResponse.
        /// Replaced by: ServiceProviderAdminGetPolicyRequest17
        /// </summary>
        public static async Task<ServiceProviderAdminGetPolicyResponse16sp1> ServiceProviderAdminGetPolicyRequest16sp1(this OcipClient client, ServiceProviderAdminGetPolicyRequest16sp1 request)
        {
            return await client.Call(request) as ServiceProviderAdminGetPolicyResponse16sp1;
        }

        /// <summary>
        /// Requests the service provider administrator's policy settings.
        /// The response is either ServiceProviderAdminGetPolicyResponse16sp2 or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAdminGetPolicyResponse16sp2> ServiceProviderAdminGetPolicyRequest16sp2(this OcipClient client, ServiceProviderAdminGetPolicyRequest16sp2 request)
        {
            return await client.Call(request) as ServiceProviderAdminGetPolicyResponse16sp2;
        }

        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse16 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse16> ServiceProviderCallProcessingGetPolicyRequest16(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest16 request)
        {
            return await client.Call(request) as ServiceProviderCallProcessingGetPolicyResponse16;
        }

        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse16sp2 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse16sp2> ServiceProviderCallProcessingGetPolicyRequest16sp2(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest16sp2 request)
        {
            return await client.Call(request) as ServiceProviderCallProcessingGetPolicyResponse16sp2;
        }

        /// <summary>
        /// Request the Service Provider level data associated with Dial Plan Policy.
        /// The response is either a ServiceProviderDialPlanPolicyGetResponse
        /// or an ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderDialPlanPolicyGetRequest17
        /// </summary>
        public static async Task<ServiceProviderDialPlanPolicyGetResponse> ServiceProviderDialPlanPolicyGetRequest(this OcipClient client, ServiceProviderDialPlanPolicyGetRequest request)
        {
            return await client.Call(request) as ServiceProviderDialPlanPolicyGetResponse;
        }

        /// <summary>
        /// Request the service provider's DTMF based in-call service activation trigger attributes.
        /// The response is either a ServiceProviderInCallServiceActivationGetResponse or an ErrorResponse.
        /// Replaced by: ServiceProviderInCallServiceActivationGetRequest17
        /// </summary>
        public static async Task<ServiceProviderInCallServiceActivationGetResponse> ServiceProviderInCallServiceActivationGetRequest(this OcipClient client, ServiceProviderInCallServiceActivationGetRequest request)
        {
            return await client.Call(request) as ServiceProviderInCallServiceActivationGetResponse;
        }

        /// <summary>
        /// Modifies the service provider's DTMF based in-call service activation trigger attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by: ServiceProviderInCallServiceActivationModifyRequest17
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderInCallServiceActivationModifyRequest(this OcipClient client, ServiceProviderInCallServiceActivationModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get a device profile file.
        /// The response is either SystemAccessDeviceFileGetResponse14sp8 or ErrorResponse.
        /// Replaced by: SystemAccessDeviceFileGetRequest16sp1
        /// </summary>
        public static async Task<SystemAccessDeviceFileGetResponse14sp8> SystemAccessDeviceFileGetRequest14sp8(this OcipClient client, SystemAccessDeviceFileGetRequest14sp8 request)
        {
            return await client.Call(request) as SystemAccessDeviceFileGetResponse14sp8;
        }

        /// <summary>
        /// Request the system's automatic callback attributes.
        /// The response is either a SystemAutomaticCallbackGetResponse15sp2 or an ErrorResponse.
        /// Replaced by: SystemAutomaticCallbackGetRequest17
        /// </summary>
        public static async Task<SystemAutomaticCallbackGetResponse15sp2> SystemAutomaticCallbackGetRequest15sp2(this OcipClient client, SystemAutomaticCallbackGetRequest15sp2 request)
        {
            return await client.Call(request) as SystemAutomaticCallbackGetResponse15sp2;
        }

        /// <summary>
        /// Request the system level data associated with Call Center.
        /// The response is either a SystemCallCenterGetResponse16 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallCenterGetRequest17
        /// </summary>
        public static async Task<SystemCallCenterGetResponse16> SystemCallCenterGetRequest16(this OcipClient client, SystemCallCenterGetRequest16 request)
        {
            return await client.Call(request) as SystemCallCenterGetResponse16;
        }

        /// <summary>
        /// Request the system's calling name retrieval attributes.
        /// The response is either a SystemCallingNameRetrievalGetResponse14 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallingNameRetrievalGetResponse14> SystemCallingNameRetrievalGetRequest14(this OcipClient client, SystemCallingNameRetrievalGetRequest14 request)
        {
            return await client.Call(request) as SystemCallingNameRetrievalGetResponse14;
        }

        /// <summary>
        /// Modifies the system's calling name retrieval attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemCallingNameRetrievalModifyRequest16sp1
        /// </summary>
        public static async Task<SuccessResponse> SystemCallingNameRetrievalModifyRequest(this OcipClient client, SystemCallingNameRetrievalModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the system level data associated with Call Processing Policy.
        /// The response is either a SystemCallProcessingGetPolicyResponse16 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse16> SystemCallProcessingGetPolicyRequest16(this OcipClient client, SystemCallProcessingGetPolicyRequest16 request)
        {
            return await client.Call(request) as SystemCallProcessingGetPolicyResponse16;
        }

        /// <summary>
        /// Request the system level data associated with Call Processing Policy.
        /// The response is either a SystemCallProcessingGetPolicyResponse16sp2 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse16sp2> SystemCallProcessingGetPolicyRequest16sp2(this OcipClient client, SystemCallProcessingGetPolicyRequest16sp2 request)
        {
            return await client.Call(request) as SystemCallProcessingGetPolicyResponse16sp2;
        }

        /// <summary>
        /// Add a new Communication Barring Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by: SystemCommunicationBarringCriteriaAddRequest17
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringCriteriaAddRequest(this OcipClient client, SystemCommunicationBarringCriteriaAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get an existing Communication Barring Criteria.
        /// The response is either a SystemCommunicationBarringCriteriaGetResponse
        /// or an ErrorResponse.
        /// Replaced by: SystemCommunicationBarringCriteriaGetRequest17
        /// </summary>
        public static async Task<SystemCommunicationBarringCriteriaGetResponse> SystemCommunicationBarringCriteriaGetRequest(this OcipClient client, SystemCommunicationBarringCriteriaGetRequest request)
        {
            return await client.Call(request) as SystemCommunicationBarringCriteriaGetResponse;
        }

        /// <summary>
        /// Get an existing Communication Barring Criteria.
        /// The response is either a SystemCommunicationBarringCriteriaGetResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringCriteriaGetResponse17> SystemCommunicationBarringCriteriaGetRequest17(this OcipClient client, SystemCommunicationBarringCriteriaGetRequest17 request)
        {
            return await client.Call(request) as SystemCommunicationBarringCriteriaGetResponse17;
        }

        /// <summary>
        /// Requests the information about the specified device type without regard to whether the
        /// type is SIP or MGCP.
        /// The response is either SystemDeviceTypeGetResponse16 or ErrorResponse.
        /// Replaced by: SystemDeviceTypeGetRequest16sp1
        /// </summary>
        public static async Task<SystemDeviceTypeGetResponse16> SystemDeviceTypeGetRequest16(this OcipClient client, SystemDeviceTypeGetRequest16 request)
        {
            return await client.Call(request) as SystemDeviceTypeGetResponse16;
        }

        /// <summary>
        /// Request the system level data associated with Dial Plan Policy.
        /// The response is either a SystemDialPlanPolicyGetResponse or an ErrorResponse.
        /// Replaced by: SystemDialPlanPolicyGetRequest17
        /// </summary>
        public static async Task<SystemDialPlanPolicyGetResponse> SystemDialPlanPolicyGetRequest(this OcipClient client, SystemDialPlanPolicyGetRequest request)
        {
            return await client.Call(request) as SystemDialPlanPolicyGetResponse;
        }

        /// <summary>
        /// Request to get the list of expensive alternate call indicators in the system.
        /// The response is either a SystemExpensiveCallTypeGetListResponse or an ErrorResponse.
        /// Replaced by: SystemExpensiveCallTypeGetListRequest16sp1
        /// </summary>
        public static async Task<SystemExpensiveCallTypeGetListResponse> SystemExpensiveCallTypeGetListRequest(this OcipClient client, SystemExpensiveCallTypeGetListRequest request)
        {
            return await client.Call(request) as SystemExpensiveCallTypeGetListResponse;
        }

        /// <summary>
        /// Add a system holiday schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemHolidayScheduleAddRequest(this OcipClient client, SystemHolidayScheduleAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a system holiday schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemHolidayScheduleDeleteRequest(this OcipClient client, SystemHolidayScheduleDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request a list of all system holiday schedules.
        /// The response is either a SystemHolidayScheduleGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemHolidayScheduleGetListResponse> SystemHolidayScheduleGetListRequest(this OcipClient client, SystemHolidayScheduleGetListRequest request)
        {
            return await client.Call(request) as SystemHolidayScheduleGetListResponse;
        }

        /// <summary>
        /// Get a system holiday schedule.
        /// The response is either a SystemHolidayScheduleGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemHolidayScheduleGetResponse> SystemHolidayScheduleGetRequest(this OcipClient client, SystemHolidayScheduleGetRequest request)
        {
            return await client.Call(request) as SystemHolidayScheduleGetResponse;
        }

        /// <summary>
        /// Modify a system holiday schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemHolidayScheduleModifyRequest(this OcipClient client, SystemHolidayScheduleModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the system level data associated with Hunt Group.
        /// The response is either a SystemHuntGroupGetResponse or an
        /// ErrorResponse.
        /// Replaced by: SystemHuntGroupGetRequest17
        /// </summary>
        public static async Task<SystemHuntGroupGetResponse> SystemHuntGroupGetRequest(this OcipClient client, SystemHuntGroupGetRequest request)
        {
            return await client.Call(request) as SystemHuntGroupGetResponse;
        }

        /// <summary>
        /// Request the system's DTMF based in-call service activation trigger attributes.
        /// The response is either a SystemInCallServiceActivationGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemInCallServiceActivationGetRequest17
        /// </summary>
        public static async Task<SystemInCallServiceActivationGetResponse> SystemInCallServiceActivationGetRequest(this OcipClient client, SystemInCallServiceActivationGetRequest request)
        {
            return await client.Call(request) as SystemInCallServiceActivationGetResponse;
        }

        /// <summary>
        /// Modifies the system's DTMF based in-call service activation trigger attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by: SystemInCallServiceActivationModifyRequest17
        /// </summary>
        public static async Task<SuccessResponse> SystemInCallServiceActivationModifyRequest(this OcipClient client, SystemInCallServiceActivationModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the list of users that use the Malicious Call Trace feature.
        /// The response is either a SystemMaliciousCallTraceGetUserListResponse or an
        /// ErrorResponse.
        /// Replaced By: SystemMaliciousCallTraceGetRequest
        /// </summary>
        public static async Task<SystemMaliciousCallTraceGetUserListResponse> SystemMaliciousCallTraceGetUserListRequest(this OcipClient client, SystemMaliciousCallTraceGetUserListRequest request)
        {
            return await client.Call(request) as SystemMaliciousCallTraceGetUserListResponse;
        }

        /// <summary>
        /// Get an existing Network Class of Service.
        /// The response is either a SystemNetworkClassOfServiceGetResponse
        /// or an ErrorResponse.
        /// Replaced by: SystemNetworkClassOfServiceGetRequest17
        /// </summary>
        public static async Task<SystemNetworkClassOfServiceGetResponse> SystemNetworkClassOfServiceGetRequest(this OcipClient client, SystemNetworkClassOfServiceGetRequest request)
        {
            return await client.Call(request) as SystemNetworkClassOfServiceGetResponse;
        }

        /// <summary>
        /// Add an application to the OCI call control application list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemOCICallControlApplicationAddRequest17
        /// </summary>
        public static async Task<SuccessResponse> SystemOCICallControlApplicationAddRequest14sp9(this OcipClient client, SystemOCICallControlApplicationAddRequest14sp9 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse14sp4 or ErrorResponse.
        /// </summary>
        public static async Task<SystemPolicyGetDefaultResponse14sp4> SystemPolicyGetDefaultRequest14sp4(this OcipClient client, SystemPolicyGetDefaultRequest14sp4 request)
        {
            return await client.Call(request) as SystemPolicyGetDefaultResponse14sp4;
        }

        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse16sp1 or ErrorResponse.
        /// </summary>
        public static async Task<SystemPolicyGetDefaultResponse16sp1> SystemPolicyGetDefaultRequest16sp1(this OcipClient client, SystemPolicyGetDefaultRequest16sp1 request)
        {
            return await client.Call(request) as SystemPolicyGetDefaultResponse16sp1;
        }

        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse16sp2 or ErrorResponse.
        /// </summary>
        public static async Task<SystemPolicyGetDefaultResponse16sp2> SystemPolicyGetDefaultRequest16sp2(this OcipClient client, SystemPolicyGetDefaultRequest16sp2 request)
        {
            return await client.Call(request) as SystemPolicyGetDefaultResponse16sp2;
        }

        /// <summary>
        /// Retrieves the Sh Interface system parameters.
        /// The response is either a SystemShInterfaceParametersGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemShInterfaceParametersGetRequest17
        /// </summary>
        public static async Task<SystemShInterfaceParametersGetResponse> SystemShInterfaceParametersGetRequest(this OcipClient client, SystemShInterfaceParametersGetRequest request)
        {
            return await client.Call(request) as SystemShInterfaceParametersGetResponse;
        }

        /// <summary>
        /// Modifies the Sh Interface system parameters. This request must be submitted on both nodes in the
        /// redundant Application Server cluster in order for the changes to take effect on each node without
        /// requiring a restart.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemShInterfaceParametersModifyRequest17
        /// </summary>
        public static async Task<SuccessResponse> SystemShInterfaceParametersModifyRequest(this OcipClient client, SystemShInterfaceParametersModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by: SystemSIPDeviceTypeAddRequest16sp1
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest16(this OcipClient client, SystemSIPDeviceTypeAddRequest16 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemSIPDeviceTypeAddRequest17
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest16sp1(this OcipClient client, SystemSIPDeviceTypeAddRequest16sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileAddRequest14sp8(this OcipClient client, SystemSIPDeviceTypeFileAddRequest14sp8 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get a sip device type file.
        /// The response is either SystemSIPDeviceTypeFileGetResponse14sp8 or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeFileGetResponse14sp8> SystemSIPDeviceTypeFileGetRequest14sp8(this OcipClient client, SystemSIPDeviceTypeFileGetRequest14sp8 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeFileGetResponse14sp8;
        }

        /// <summary>
        /// Request to modify a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileModifyRequest14sp8(this OcipClient client, SystemSIPDeviceTypeFileModifyRequest14sp8 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse16 or ErrorResponse.
        /// Replaced by: SystemSIPDeviceTypeGetRequest16sp1
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse16> SystemSIPDeviceTypeGetRequest16(this OcipClient client, SystemSIPDeviceTypeGetRequest16 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse16;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse16sp1 or ErrorResponse.
        /// 
        /// Replaced by: SystemSIPDeviceTypeGetRequest17
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse16sp1> SystemSIPDeviceTypeGetRequest16sp1(this OcipClient client, SystemSIPDeviceTypeGetRequest16sp1 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse16sp1;
        }

        /// <summary>
        /// Request to modify a sip device type.
        /// The following elements are not changeable:
        /// numberOfPorts
        /// SignalingAddressType
        /// isConferenceDevice
        /// isMusicOnHoldDevice
        /// isMobilityManagerDevice
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by: SystemSIPDeviceTypeModifyRequest16sp1
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeModifyRequest16(this OcipClient client, SystemSIPDeviceTypeModifyRequest16 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a sip device type.
        /// The following elements are not changeable:
        /// numberOfPorts
        /// SignalingAddressType
        /// isConferenceDevice
        /// isMusicOnHoldDevice
        /// isMobilityManagerDevice
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeModifyRequest16sp1(this OcipClient client, SystemSIPDeviceTypeModifyRequest16sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the system call processing configuration for all subscribers
        /// The response is either a SystemSubscriberGetCallProcessingParametersResponse15sp2 or an ErrorResponse.
        /// Replaced by: SystemSubscriberGetCallProcessingParametersRequest17
        /// </summary>
        public static async Task<SystemSubscriberGetCallProcessingParametersResponse15sp2> SystemSubscriberGetCallProcessingParametersRequest15sp2(this OcipClient client, SystemSubscriberGetCallProcessingParametersRequest15sp2 request)
        {
            return await client.Call(request) as SystemSubscriberGetCallProcessingParametersResponse15sp2;
        }

        /// <summary>
        /// Add a system time schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTimeScheduleAddRequest(this OcipClient client, SystemTimeScheduleAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a system time schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTimeScheduleDeleteRequest(this OcipClient client, SystemTimeScheduleDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request a list of all system time schedules.
        /// The response is either a SystemTimeScheduleGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemTimeScheduleGetListResponse> SystemTimeScheduleGetListRequest(this OcipClient client, SystemTimeScheduleGetListRequest request)
        {
            return await client.Call(request) as SystemTimeScheduleGetListResponse;
        }

        /// <summary>
        /// Request to get a system time schedule.
        /// The response is either a SystemTimeScheduleGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemTimeScheduleGetResponse> SystemTimeScheduleGetRequest(this OcipClient client, SystemTimeScheduleGetRequest request)
        {
            return await client.Call(request) as SystemTimeScheduleGetResponse;
        }

        /// <summary>
        /// Modify a specified system time schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTimeScheduleModifyRequest(this OcipClient client, SystemTimeScheduleModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Adds a list of IP addresses to a zone
        /// The response is SuccessResponse or an ErrorResponse.
        /// Replaced by: SystemZoneNetAddressAddListRequest
        /// </summary>
        public static async Task<SuccessResponse> SystemZoneCallingRestrictionsNetAddressAddListRequest(this OcipClient client, SystemZoneCallingRestrictionsNetAddressAddListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Deletes a list of IP addresses from a zone
        /// The response is SuccessResponse or an ErrorResponse.
        /// Replaced by: SystemZoneNetAddressDeleteListRequest
        /// </summary>
        public static async Task<SuccessResponse> SystemZoneCallingRestrictionsNetAddressDeleteListRequest(this OcipClient client, SystemZoneCallingRestrictionsNetAddressDeleteListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Gets a list of IP Addresses and/or Ranges assigned to a zone
        /// The response is SystemZoneCallingRestrictionsNetAddressGetListResponse.
        /// Replaced by: SystemZoneNetAddressGetListRequest
        /// </summary>
        public static async Task<SystemZoneCallingRestrictionsNetAddressGetListResponse> SystemZoneCallingRestrictionsNetAddressGetListRequest(this OcipClient client, SystemZoneCallingRestrictionsNetAddressGetListRequest request)
        {
            return await client.Call(request) as SystemZoneCallingRestrictionsNetAddressGetListResponse;
        }

        /// <summary>
        /// Add a zone.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by: SystemZoneAddRequest
        /// </summary>
        public static async Task<SuccessResponse> SystemZoneCallingRestrictionsZoneAddRequest(this OcipClient client, SystemZoneCallingRestrictionsZoneAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Deletes a zone from the system
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by: SystemZoneDeleteRequest
        /// </summary>
        public static async Task<SuccessResponse> SystemZoneCallingRestrictionsZoneDeleteRequest(this OcipClient client, SystemZoneCallingRestrictionsZoneDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Gets a list of all zones defined in the system
        /// The response is SystemZoneCallingRestrictionsZoneGetListResponse or an ErrorResponse.
        /// Replaced by: SystemZoneGetListRequest
        /// </summary>
        public static async Task<SystemZoneCallingRestrictionsZoneGetListResponse> SystemZoneCallingRestrictionsZoneGetListRequest(this OcipClient client, SystemZoneCallingRestrictionsZoneGetListRequest request)
        {
            return await client.Call(request) as SystemZoneCallingRestrictionsZoneGetListResponse;
        }

        /// <summary>
        /// Modifies attributes of a zone in the system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by: SystemZonePhysicalLocationAddListRequest and
        /// SystemZonePhysicalLocationDeleteListRequest
        /// </summary>
        public static async Task<SuccessResponse> SystemZoneCallingRestrictionsZoneModifyRequest(this OcipClient client, SystemZoneCallingRestrictionsZoneModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the user level data associated with Alternate Numbers.
        /// The response is either a UserAlternateNumbersGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserAlternateNumbersGetResponse> UserAlternateNumbersGetRequest(this OcipClient client, UserAlternateNumbersGetRequest request)
        {
            return await client.Call(request) as UserAlternateNumbersGetResponse;
        }

        /// <summary>
        /// Request user's attendant console settings.
        /// The response is either a UserAttendantConsoleGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserAttendantConsoleGetResponse> UserAttendantConsoleGetRequest(this OcipClient client, UserAttendantConsoleGetRequest request)
        {
            return await client.Call(request) as UserAttendantConsoleGetResponse;
        }

        /// <summary>
        /// Get the list of all the BroadWorks Anywhere phone numbers for the user.
        /// The response is either a UserBroadWorksAnywhereGetResponse or an ErrorResponse.
        /// Replaced by: UserBroadWorksAnywhereGetRequest16sp2
        /// </summary>
        public static async Task<UserBroadWorksAnywhereGetResponse> UserBroadWorksAnywhereGetRequest(this OcipClient client, UserBroadWorksAnywhereGetRequest request)
        {
            return await client.Call(request) as UserBroadWorksAnywhereGetResponse;
        }

        /// <summary>
        /// Get the user's call center settings and the list of call centers the specified user belongs to.
        /// The response is either a UserCallCenterGetResponse16 or an ErrorResponse.
        /// 
        /// Replaced by: UserCallCenterGetRequest17
        /// </summary>
        public static async Task<UserCallCenterGetResponse16> UserCallCenterGetRequest16(this OcipClient client, UserCallCenterGetRequest16 request)
        {
            return await client.Call(request) as UserCallCenterGetResponse16;
        }

        /// <summary>
        /// Request the user level data associated with Call Policies.
        /// The response is either a UserCallPoliciesGetResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallPoliciesGetResponse> UserCallPoliciesGetRequest(this OcipClient client, UserCallPoliciesGetRequest request)
        {
            return await client.Call(request) as UserCallPoliciesGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Call Processing Policy.
        /// The response is either a UserCallProcessingGetPolicyResponse16 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallProcessingGetPolicyResponse16> UserCallProcessingGetPolicyRequest16(this OcipClient client, UserCallProcessingGetPolicyRequest16 request)
        {
            return await client.Call(request) as UserCallProcessingGetPolicyResponse16;
        }

        /// <summary>
        /// Request the user level data associated with Call Processing Policy.
        /// The response is either a UserCallProcessingGetPolicyResponse16 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: UserCallProcessingGetPolicyRequest17sp4
        /// </summary>
        public static async Task<UserCallProcessingGetPolicyResponse16> UserCallProcessingGetPolicyRequest16sp2(this OcipClient client, UserCallProcessingGetPolicyRequest16sp2 request)
        {
            return await client.Call(request) as UserCallProcessingGetPolicyResponse16;
        }

        /// <summary>
        /// Request the user level data associated with Fax Messaging.
        /// The response is either a UserFaxMessagingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserFaxMessagingGetResponse> UserFaxMessagingGetRequest(this OcipClient client, UserFaxMessagingGetRequest request)
        {
            return await client.Call(request) as UserFaxMessagingGetResponse;
        }

        /// <summary>
        /// Request to get the user information.
        /// The response is either UserGetResponse15sp2 or ErrorResponse.
        /// </summary>
        public static async Task<UserGetResponse15sp2> UserGetRequest15sp2(this OcipClient client, UserGetRequest15sp2 request)
        {
            return await client.Call(request) as UserGetResponse15sp2;
        }

        /// <summary>
        /// Add a holiday schedule to a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserHolidayScheduleAddRequest(this OcipClient client, UserHolidayScheduleAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a holiday schedule from a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserHolidayScheduleDeleteRequest(this OcipClient client, UserHolidayScheduleDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a holiday schedule list for a user.
        /// The response is either a UserHolidayScheduleGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserHolidayScheduleGetListResponse> UserHolidayScheduleGetListRequest(this OcipClient client, UserHolidayScheduleGetListRequest request)
        {
            return await client.Call(request) as UserHolidayScheduleGetListResponse;
        }

        /// <summary>
        /// Get a holiday schedule a user.
        /// The response is either a UserHolidayScheduleGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserHolidayScheduleGetResponse> UserHolidayScheduleGetRequest(this OcipClient client, UserHolidayScheduleGetRequest request)
        {
            return await client.Call(request) as UserHolidayScheduleGetResponse;
        }

        /// <summary>
        /// Modify a holiday schedule for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserHolidayScheduleModifyRequest(this OcipClient client, UserHolidayScheduleModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the user level data associated with Hoteling Host.
        /// The response is either a UserHotelingHostGetResponse14sp4 or an ErrorResponse.
        /// </summary>
        public static async Task<UserHotelingHostGetResponse14sp4> UserHotelingHostGetRequest14sp4(this OcipClient client, UserHotelingHostGetRequest14sp4 request)
        {
            return await client.Call(request) as UserHotelingHostGetResponse14sp4;
        }

        /// <summary>
        /// Get a criteria for the user's selective call rejection service.
        /// The response is either a UserSelectiveCallRejectionGetCriteriaResponse16 or an ErrorResponse.
        /// Replaced by: UserSelectiveCallRejectionGetCriteriaRequest16sp1
        /// </summary>
        public static async Task<UserSelectiveCallRejectionGetCriteriaResponse16> UserSelectiveCallRejectionGetCriteriaRequest16(this OcipClient client, UserSelectiveCallRejectionGetCriteriaRequest16 request)
        {
            return await client.Call(request) as UserSelectiveCallRejectionGetCriteriaResponse16;
        }

        /// <summary>
        /// Add a new phone number and set the answer confirmation setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSimultaneousRingFamilyAddPhoneNumberRequest(this OcipClient client, UserSimultaneousRingFamilyAddPhoneNumberRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete the phone number specified.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSimultaneousRingFamilyDeletePhoneNumberRequest(this OcipClient client, UserSimultaneousRingFamilyDeletePhoneNumberRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the answer confirmation setting for the phone number specified.
        /// The response is either a UserSimultaneousRingFamilyGetPhoneNumberResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserSimultaneousRingFamilyGetPhoneNumberResponse> UserSimultaneousRingFamilyGetPhoneNumberRequest(this OcipClient client, UserSimultaneousRingFamilyGetPhoneNumberRequest request)
        {
            return await client.Call(request) as UserSimultaneousRingFamilyGetPhoneNumberResponse;
        }

        /// <summary>
        /// Get the user's simultaneous ring service Family setting.
        /// The response is either a UserSimultaneousRingFamilyGetResponse14sp4 or an ErrorResponse.
        /// </summary>
        public static async Task<UserSimultaneousRingFamilyGetResponse14sp4> UserSimultaneousRingFamilyGetRequest14sp4(this OcipClient client, UserSimultaneousRingFamilyGetRequest14sp4 request)
        {
            return await client.Call(request) as UserSimultaneousRingFamilyGetResponse14sp4;
        }

        /// <summary>
        /// Modify the require confirmation setting for the destination.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSimultaneousRingFamilyModifyPhoneNumberRequest(this OcipClient client, UserSimultaneousRingFamilyModifyPhoneNumberRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's simultaneous ring family service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSimultaneousRingFamilyModifyRequest14sp4(this OcipClient client, UserSimultaneousRingFamilyModifyRequest14sp4 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a new phone number and set the answer confirmation setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSimultaneousRingPersonalAddPhoneNumberRequest(this OcipClient client, UserSimultaneousRingPersonalAddPhoneNumberRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete the phone number specified.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSimultaneousRingPersonalDeletePhoneNumberRequest(this OcipClient client, UserSimultaneousRingPersonalDeletePhoneNumberRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the answer confirmation setting for the phone number specified.
        /// The response is either a UserSimultaneousRingPersonalGetPhoneNumberResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserSimultaneousRingPersonalGetPhoneNumberResponse> UserSimultaneousRingPersonalGetPhoneNumberRequest(this OcipClient client, UserSimultaneousRingPersonalGetPhoneNumberRequest request)
        {
            return await client.Call(request) as UserSimultaneousRingPersonalGetPhoneNumberResponse;
        }

        /// <summary>
        /// Get the user's simultaneous ring service personal setting.
        /// The response is either a UserSimultaneousRingPersonalGetResponse14sp4 or an ErrorResponse.
        /// </summary>
        public static async Task<UserSimultaneousRingPersonalGetResponse14sp4> UserSimultaneousRingPersonalGetRequest14sp4(this OcipClient client, UserSimultaneousRingPersonalGetRequest14sp4 request)
        {
            return await client.Call(request) as UserSimultaneousRingPersonalGetResponse14sp4;
        }

        /// <summary>
        /// Modify the require confirmation setting for the destination.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSimultaneousRingPersonalModifyPhoneNumberRequest(this OcipClient client, UserSimultaneousRingPersonalModifyPhoneNumberRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's simultaneous ring personal service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserSimultaneousRingPersonalModifyRequest14sp4(this OcipClient client, UserSimultaneousRingPersonalModifyRequest14sp4 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the user level data associated with Third-Party Voice Mail Support.
        /// The response is either a UserThirdPartyVoiceMailSupportGetResponse13mp16 or an
        /// ErrorResponse.
        /// Replaced by: UserThirdPartyVoiceMailSupportGetRequest17
        /// </summary>
        public static async Task<UserThirdPartyVoiceMailSupportGetResponse13mp16> UserThirdPartyVoiceMailSupportGetRequest13mp16(this OcipClient client, UserThirdPartyVoiceMailSupportGetRequest13mp16 request)
        {
            return await client.Call(request) as UserThirdPartyVoiceMailSupportGetResponse13mp16;
        }

        /// <summary>
        /// Add a time schedule for a user.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserTimeScheduleAddRequest(this OcipClient client, UserTimeScheduleAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a user time schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserTimeScheduleDeleteRequest(this OcipClient client, UserTimeScheduleDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get all time schedules for a user. This includes the user's personal schedules and user's group's
        /// schedules.
        /// The response is either a UserTimeScheduleGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserTimeScheduleGetListResponse> UserTimeScheduleGetListRequest(this OcipClient client, UserTimeScheduleGetListRequest request)
        {
            return await client.Call(request) as UserTimeScheduleGetListResponse;
        }

        /// <summary>
        /// Request to get a user time schedule.
        /// The response is either a UserTimeScheduleGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserTimeScheduleGetResponse> UserTimeScheduleGetRequest(this OcipClient client, UserTimeScheduleGetRequest request)
        {
            return await client.Call(request) as UserTimeScheduleGetResponse;
        }

        /// <summary>
        /// Modify a user time schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserTimeScheduleModifyRequest(this OcipClient client, UserTimeScheduleModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the user's voice messaging voice management service settings.
        /// The response is either a UserVoiceMessagingUserGetVoiceManagementResponse13mp8 or an ErrorResponse.
        /// Replaced by: UserVoiceMessagingUserGetVoiceManagementRequest17
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetVoiceManagementResponse13mp8> UserVoiceMessagingUserGetVoiceManagementRequest13mp8(this OcipClient client, UserVoiceMessagingUserGetVoiceManagementRequest13mp8 request)
        {
            return await client.Call(request) as UserVoiceMessagingUserGetVoiceManagementResponse13mp8;
        }

        /// <summary>
        /// Get the address and credentials of the File Repository hosting the requested access device file.
        /// Also get the file name and path on the File Repository.
        /// The response is either a DeviceManagementFileAuthLocationGetResponse17 or an ErrorResponse.
        /// 
        /// Replaced by: DeviceManagementFileAuthLocationGetRequest18
        /// </summary>
        public static async Task<DeviceManagementFileAuthLocationGetResponse17> DeviceManagementFileAuthLocationGetRequest17(this OcipClient client, DeviceManagementFileAuthLocationGetRequest17 request)
        {
            return await client.Call(request) as DeviceManagementFileAuthLocationGetResponse17;
        }

        /// <summary>
        /// Request a table containing the phone directory for an enterprise.
        /// The directory includes all users in the enterprise and all entries in the enterprise common phone list.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either EnterprisePhoneDirectoryGetListResponse17 or ErrorResponse.
        /// 
        /// Replaced by: EnterprisePhoneDirectoryGetListRequest18
        /// </summary>
        public static async Task<EnterprisePhoneDirectoryGetListResponse17> EnterprisePhoneDirectoryGetListRequest17(this OcipClient client, EnterprisePhoneDirectoryGetListRequest17 request)
        {
            return await client.Call(request) as EnterprisePhoneDirectoryGetListResponse17;
        }

        /// <summary>
        /// Request a table containing the phone directory for an enterprise.
        /// The directory includes all users in the enterprise and all entries in the enterprise common phone list.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either EnterprisePhoneDirectoryGetListResponse17sp3 or ErrorResponse.
        /// 
        /// Replaced by: EnterprisePhoneDirectoryGetListRequest18
        /// </summary>
        public static async Task<EnterprisePhoneDirectoryGetListResponse17sp3> EnterprisePhoneDirectoryGetListRequest17sp3(this OcipClient client, EnterprisePhoneDirectoryGetListRequest17sp3 request)
        {
            return await client.Call(request) as EnterprisePhoneDirectoryGetListResponse17sp3;
        }

        /// <summary>
        /// Requests the Group administrator's policy settings.
        /// The response is either GroupAdminGetPolicyResponse17 or ErrorResponse.
        /// </summary>
        public static async Task<GroupAdminGetPolicyResponse17> GroupAdminGetPolicyRequest17(this OcipClient client, GroupAdminGetPolicyRequest17 request)
        {
            return await client.Call(request) as GroupAdminGetPolicyResponse17;
        }

        /// <summary>
        /// Requests the Group administrator's policy settings.
        /// The response is either GroupAdminGetPolicyResponse17sp3 or ErrorResponse.
        /// </summary>
        public static async Task<GroupAdminGetPolicyResponse17sp3> GroupAdminGetPolicyRequest17sp3(this OcipClient client, GroupAdminGetPolicyRequest17sp3 request)
        {
            return await client.Call(request) as GroupAdminGetPolicyResponse17sp3;
        }

        /// <summary>
        /// Add a Auto Attendant instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantAddInstanceRequest16(this OcipClient client, GroupAutoAttendantAddInstanceRequest16 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get all the information of a Auto Attendant instance.
        /// The response is either GroupAutoAttendantGetInstanceResponse17 or ErrorResponse.
        /// </summary>
        public static async Task<GroupAutoAttendantGetInstanceResponse17> GroupAutoAttendantGetInstanceRequest17(this OcipClient client, GroupAutoAttendantGetInstanceRequest17 request)
        {
            return await client.Call(request) as GroupAutoAttendantGetInstanceResponse17;
        }

        /// <summary>
        /// Request to modify an Auto Attendant instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantModifyInstanceRequest16(this OcipClient client, GroupAutoAttendantModifyInstanceRequest16 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Center instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterAddInstanceRequest17(this OcipClient client, GroupCallCenterAddInstanceRequest17 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Center instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced by: GroupCallCenterAddInstanceRequest17sp3
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterAddInstanceRequest17sp1(this OcipClient client, GroupCallCenterAddInstanceRequest17sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get all the information of a Call Center instance.
        /// The response is either GroupCallCenterGetInstanceResponse17 or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetInstanceResponse17> GroupCallCenterGetInstanceRequest17(this OcipClient client, GroupCallCenterGetInstanceRequest17 request)
        {
            return await client.Call(request) as GroupCallCenterGetInstanceResponse17;
        }

        /// <summary>
        /// Request to get all the information of a Call Center instance.
        /// The response is either GroupCallCenterGetInstanceResponse17sp1 or ErrorResponse.
        /// 
        /// Replaced by: GroupCallCenterGetInstanceRequest17sp3
        /// </summary>
        public static async Task<GroupCallCenterGetInstanceResponse17sp1> GroupCallCenterGetInstanceRequest17sp1(this OcipClient client, GroupCallCenterGetInstanceRequest17sp1 request)
        {
            return await client.Call(request) as GroupCallCenterGetInstanceResponse17sp1;
        }

        /// <summary>
        /// Request to get the call center statistics reporting settings.
        /// The response is either GroupCallCenterGetInstanceStatisticsReportingResponse16 or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetInstanceStatisticsReportingResponse16> GroupCallCenterGetInstanceStatisticsReportingRequest16(this OcipClient client, GroupCallCenterGetInstanceStatisticsReportingRequest16 request)
        {
            return await client.Call(request) as GroupCallCenterGetInstanceStatisticsReportingResponse16;
        }

        /// <summary>
        /// Get a call center's holiday service settings.
        /// The response is either a GroupCallCenterHolidayServiceGetResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterHolidayServiceGetResponse17> GroupCallCenterHolidayServiceGetRequest17(this OcipClient client, GroupCallCenterHolidayServiceGetRequest17 request)
        {
            return await client.Call(request) as GroupCallCenterHolidayServiceGetResponse17;
        }

        /// <summary>
        /// Modify a call center's holiday service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterHolidayServiceModifyRequest17(this OcipClient client, GroupCallCenterHolidayServiceModifyRequest17 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Call Center instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyInstanceRequest16(this OcipClient client, GroupCallCenterModifyInstanceRequest16 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Call Center statistics reporting frequency and destination.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyInstanceStatisticsReportingRequest14sp9(this OcipClient client, GroupCallCenterModifyInstanceStatisticsReportingRequest14sp9 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a call center's night service settings.
        /// The response is either a GroupCallCenterNightServiceGetResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterNightServiceGetResponse17> GroupCallCenterNightServiceGetRequest17(this OcipClient client, GroupCallCenterNightServiceGetRequest17 request)
        {
            return await client.Call(request) as GroupCallCenterNightServiceGetResponse17;
        }

        /// <summary>
        /// Modify a call center's night service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterNightServiceModifyRequest17(this OcipClient client, GroupCallCenterNightServiceModifyRequest17 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Adds a Call Park group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallParkAddInstanceRequest(this OcipClient client, GroupCallParkAddInstanceRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Gets a Call Park group.
        /// The response is either GroupCallParkGetInstanceResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallParkGetInstanceResponse> GroupCallParkGetInstanceRequest(this OcipClient client, GroupCallParkGetInstanceRequest request)
        {
            return await client.Call(request) as GroupCallParkGetInstanceResponse;
        }

        /// <summary>
        /// Gets the Call Park Group settings.
        /// The response is either GroupCallParkGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupCallParkGetResponse> GroupCallParkGetRequest(this OcipClient client, GroupCallParkGetRequest request)
        {
            return await client.Call(request) as GroupCallParkGetResponse;
        }

        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse17 or an
        /// ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName)
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls,
        /// maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls,
        /// maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth,
        /// maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations)
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan,
        /// overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
        /// </summary>
        public static async Task<GroupCallProcessingGetPolicyResponse17> GroupCallProcessingGetPolicyRequest17(this OcipClient client, GroupCallProcessingGetPolicyRequest17 request)
        {
            return await client.Call(request) as GroupCallProcessingGetPolicyResponse17;
        }

        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse17sp3 or an
        /// ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName)
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls,
        /// maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls,
        /// maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth,
        /// maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations)
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan,
        /// overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
        /// The useGroupDCLIDSetting controls the Dialable Caller ID settings (enableDialableCallerID)
        /// 
        /// The following elements are only used in AS data mode:
        /// useGroupDCLIDSetting
        /// enableDialableCallerID
        /// 
        /// Replaced by GroupCallProcessingGetPolicyRequest17sp4
        /// </summary>
        public static async Task<GroupCallProcessingGetPolicyResponse17sp3> GroupCallProcessingGetPolicyRequest17sp3(this OcipClient client, GroupCallProcessingGetPolicyRequest17sp3 request)
        {
            return await client.Call(request) as GroupCallProcessingGetPolicyResponse17sp3;
        }

        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse17sp4 or an
        /// ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName,
        /// allowConfigurableCLIDForRedirectingIdentity)
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls,
        /// maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls,
        /// maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth,
        /// maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations)
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan,
        /// overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
        /// The following elements are only used in AS data mode:
        /// useGroupDCLIDSetting
        /// enableDialableCallerID
        /// 
        /// Replaced by GroupCallProcessingGetPolicyRequest18
        /// </summary>
        public static async Task<GroupCallProcessingGetPolicyResponse17sp4> GroupCallProcessingGetPolicyRequest17sp4(this OcipClient client, GroupCallProcessingGetPolicyRequest17sp4 request)
        {
            return await client.Call(request) as GroupCallProcessingGetPolicyResponse17sp4;
        }

        /// <summary>
        /// Request a list of departments in a group. You may request only the
        /// list of departments defined at the group-level, or you may request
        /// the list of all departments in the group including all the departments
        /// defined within the enterprise the group belongs to.
        /// The response is either GroupDepartmentGetListResponse or ErrorResponse.
        /// 
        /// Replaced by: GroupDepartmentGetListRequest18
        /// </summary>
        public static async Task<GroupDepartmentGetListResponse> GroupDepartmentGetListRequest(this OcipClient client, GroupDepartmentGetListRequest request)
        {
            return await client.Call(request) as GroupDepartmentGetListResponse;
        }

        /// <summary>
        /// Get the list of assigned and unassigned DNs in a group. Each DN can be assigned
        /// to a user and/or department. Ranges of DNs with identical assignment and activation properties
        /// are coalesced to a single table row entry.
        /// The response is either a GroupDnGetAssignmentListResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupDnGetAssignmentListRequest18
        /// </summary>
        public static async Task<GroupDnGetAssignmentListResponse> GroupDnGetAssignmentListRequest(this OcipClient client, GroupDnGetAssignmentListRequest request)
        {
            return await client.Call(request) as GroupDnGetAssignmentListResponse;
        }

        /// <summary>
        /// Replaced by: GroupGroupPagingGetInstanceRequest17sp3
        /// Request to get all the information of a Group Paging instance.
        /// The response is either GroupGroupPagingGetInstanceResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupGroupPagingGetInstanceResponse> GroupGroupPagingGetInstanceRequest(this OcipClient client, GroupGroupPagingGetInstanceRequest request)
        {
            return await client.Call(request) as GroupGroupPagingGetInstanceResponse;
        }

        /// <summary>
        /// Add a Hunt Group instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupHuntGroupAddInstanceRequest14(this OcipClient client, GroupHuntGroupAddInstanceRequest14 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a Hunt Group instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// useSystemHuntGroupCLIDSetting, use value "true" in XS data mode
        /// includeHuntGroupNameInCLID, use value "true" in XS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupHuntGroupAddInstanceRequest17sp3(this OcipClient client, GroupHuntGroupAddInstanceRequest17sp3 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get all the information of a Hunt Group instance.
        /// The response is either GroupHuntGroupGetInstanceResponse17 or ErrorResponse.
        /// </summary>
        public static async Task<GroupHuntGroupGetInstanceResponse17> GroupHuntGroupGetInstanceRequest17(this OcipClient client, GroupHuntGroupGetInstanceRequest17 request)
        {
            return await client.Call(request) as GroupHuntGroupGetInstanceResponse17;
        }

        /// <summary>
        /// Request to get all the information of a Hunt Group instance.
        /// The response is either GroupHuntGroupGetInstanceResponse17sp3 or ErrorResponse.
        /// </summary>
        public static async Task<GroupHuntGroupGetInstanceResponse17sp3> GroupHuntGroupGetInstanceRequest17sp3(this OcipClient client, GroupHuntGroupGetInstanceRequest17sp3 request)
        {
            return await client.Call(request) as GroupHuntGroupGetInstanceResponse17sp3;
        }

        /// <summary>
        /// Add a Meet-Me Conferencing bridge to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupMeetMeConferencingAddInstanceRequest(this OcipClient client, GroupMeetMeConferencingAddInstanceRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get all the information of a Meet-Me Conferencing bridge.
        /// The response is either GroupMeetMeConferencingGetInstanceResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupMeetMeConferencingGetInstanceResponse> GroupMeetMeConferencingGetInstanceRequest(this OcipClient client, GroupMeetMeConferencingGetInstanceRequest request)
        {
            return await client.Call(request) as GroupMeetMeConferencingGetInstanceResponse;
        }

        /// <summary>
        /// Request to get all the information of a Meet-Me Conferencing bridge.
        /// The response is either GroupMeetMeConferencingGetInstanceResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupMeetMeConferencingGetInstanceResponse> GroupMeetMeConferencingGetInstanceRequest17sp3(this OcipClient client, GroupMeetMeConferencingGetInstanceRequest17sp3 request)
        {
            return await client.Call(request) as GroupMeetMeConferencingGetInstanceResponse;
        }

        /// <summary>
        /// Request to get all the information of a Meet-Me Conferencing bridge.
        /// The response is either GroupMeetMeConferencingGetInstanceResponse17sp4 or ErrorResponse.
        /// </summary>
        public static async Task<GroupMeetMeConferencingGetInstanceResponse17sp4> GroupMeetMeConferencingGetInstanceRequest17sp4(this OcipClient client, GroupMeetMeConferencingGetInstanceRequest17sp4 request)
        {
            return await client.Call(request) as GroupMeetMeConferencingGetInstanceResponse17sp4;
        }

        /// <summary>
        /// Request a table containing the phone directory for a group.
        /// If the specified group is part of an enterprise, the directory
        /// includes all users in the enterprise and all entries in the enterprise
        /// common phone list and the common phone list of the specified group.
        /// If the specified group is part of a service provider, the directory
        /// includes all users in the group and all entries in the common phone
        /// list of the specified group.
        /// It is possible to search by various criteria to restrict the number of
        /// rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either GroupPhoneDirectoryGetListResponse17 or
        /// ErrorResponse.
        /// 
        /// Replaced by: GroupPhoneDirectoryGetListRequest18
        /// </summary>
        public static async Task<GroupPhoneDirectoryGetListResponse17> GroupPhoneDirectoryGetListRequest17(this OcipClient client, GroupPhoneDirectoryGetListRequest17 request)
        {
            return await client.Call(request) as GroupPhoneDirectoryGetListResponse17;
        }

        /// <summary>
        /// Request a table containing the phone directory for a group.
        /// If the specified group is part of an enterprise, the directory
        /// includes all users in the enterprise and all entries in the enterprise
        /// common phone list and the common phone list of the specified group.
        /// If the specified group is part of a service provider, the directory
        /// includes all users in the group and all entries in the common phone
        /// list of the specified group.
        /// It is possible to search by various criteria to restrict the number of
        /// rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either GroupPhoneDirectoryGetListResponse17sp3 or
        /// ErrorResponse.
        /// 
        /// Replaced by: GroupPhoneDirectoryGetListRequest18
        /// </summary>
        public static async Task<GroupPhoneDirectoryGetListResponse17sp3> GroupPhoneDirectoryGetListRequest17sp3(this OcipClient client, GroupPhoneDirectoryGetListRequest17sp3 request)
        {
            return await client.Call(request) as GroupPhoneDirectoryGetListResponse17sp3;
        }

        /// <summary>
        /// Get a route point's holiday service settings.
        /// The response is either a GroupRoutePointHolidayServiceGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointHolidayServiceGetResponse> GroupRoutePointHolidayServiceGetRequest(this OcipClient client, GroupRoutePointHolidayServiceGetRequest request)
        {
            return await client.Call(request) as GroupRoutePointHolidayServiceGetResponse;
        }

        /// <summary>
        /// Modify a route point's holiday service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointHolidayServiceModifyRequest(this OcipClient client, GroupRoutePointHolidayServiceModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a route point's night service settings.
        /// The response is either a GroupRoutePointNightServiceGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointNightServiceGetResponse> GroupRoutePointNightServiceGetRequest(this OcipClient client, GroupRoutePointNightServiceGetRequest request)
        {
            return await client.Call(request) as GroupRoutePointNightServiceGetResponse;
        }

        /// <summary>
        /// Modify a route point's night service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointNightServiceModifyRequest(this OcipClient client, GroupRoutePointNightServiceModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the list of a group schedules. The list can be filtered by schedule type.
        /// The response is either a GroupScheduleGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupScheduleGetListResponse> GroupScheduleGetListRequest(this OcipClient client, GroupScheduleGetListRequest request)
        {
            return await client.Call(request) as GroupScheduleGetListResponse;
        }

        /// <summary>
        /// Request the data associated with Privacy for a service instance.
        /// The response is either a GroupServiceInstancePrivacyGetResponse.
        /// Replaced by: GroupServiceInstancePrivacyGetRequest17sp4
        /// </summary>
        public static async Task<GroupServiceInstancePrivacyGetResponse> GroupServiceInstancePrivacyGetRequest(this OcipClient client, GroupServiceInstancePrivacyGetRequest request)
        {
            return await client.Call(request) as GroupServiceInstancePrivacyGetResponse;
        }

        /// <summary>
        /// Get the speed dial 100 service settings for a group.
        /// The response is either a GroupSpeedDial100GetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupSpeedDial100GetResponse> GroupSpeedDial100GetRequest(this OcipClient client, GroupSpeedDial100GetRequest request)
        {
            return await client.Call(request) as GroupSpeedDial100GetResponse;
        }

        /// <summary>
        /// Replaced by: GroupTrunkGroupAddInstanceRequest17sp4
        /// 
        /// Add a Trunk Group instance to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupAddInstanceRequest17(this OcipClient client, GroupTrunkGroupAddInstanceRequest17 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a Trunk Group instance to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupTrunkGroupAddInstanceRequest17sp4
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupAddInstanceRequest17sp3(this OcipClient client, GroupTrunkGroupAddInstanceRequest17sp3 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse17 or an ErrorResponse.
        /// The response contains a hosted user table with column headings: "User Id", "Last Name",
        /// "First Name", "Hiragana Last Name", "Hiragana First Name".
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceResponse17> GroupTrunkGroupGetInstanceRequest17(this OcipClient client, GroupTrunkGroupGetInstanceRequest17 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceResponse17;
        }

        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse17sp3 or an ErrorResponse.
        /// The response contains a hosted user table with column headings: "User Id", "Last Name",
        /// "First Name", "Hiragana Last Name", "Hiragana First Name".
        /// 
        /// Replaced by: GroupTrunkGroupGetInstanceRequest17sp4
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceResponse17sp3> GroupTrunkGroupGetInstanceRequest17sp3(this OcipClient client, GroupTrunkGroupGetInstanceRequest17sp3 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceResponse17sp3;
        }

        /// <summary>
        /// Request to get the group voice portal information for a voice messaging group.
        /// The response is either GroupVoiceMessagingGroupGetVoicePortalResponse17 or ErrorResponse.
        /// </summary>
        public static async Task<GroupVoiceMessagingGroupGetVoicePortalResponse17> GroupVoiceMessagingGroupGetVoicePortalRequest17(this OcipClient client, GroupVoiceMessagingGroupGetVoicePortalRequest17 request)
        {
            return await client.Call(request) as GroupVoiceMessagingGroupGetVoicePortalResponse17;
        }

        /// <summary>
        /// Requests the service provider administrator's policy settings.
        /// The response is either ServiceProviderAdminGetPolicyResponse17 or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAdminGetPolicyResponse17> ServiceProviderAdminGetPolicyRequest17(this OcipClient client, ServiceProviderAdminGetPolicyRequest17 request)
        {
            return await client.Call(request) as ServiceProviderAdminGetPolicyResponse17;
        }

        /// <summary>
        /// Requests the service provider administrator's policy settings.
        /// The response is either ServiceProviderAdminGetPolicyResponse17sp1 or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAdminGetPolicyResponse17sp1> ServiceProviderAdminGetPolicyRequest17sp1(this OcipClient client, ServiceProviderAdminGetPolicyRequest17sp1 request)
        {
            return await client.Call(request) as ServiceProviderAdminGetPolicyResponse17sp1;
        }

        /// <summary>
        /// Requests the service provider administrator's policy settings.
        /// The response is either ServiceProviderAdminGetPolicyResponse17sp3 or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAdminGetPolicyResponse17sp3> ServiceProviderAdminGetPolicyRequest17sp3(this OcipClient client, ServiceProviderAdminGetPolicyRequest17sp3 request)
        {
            return await client.Call(request) as ServiceProviderAdminGetPolicyResponse17sp3;
        }

        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse17> ServiceProviderCallProcessingGetPolicyRequest17(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest17 request)
        {
            return await client.Call(request) as ServiceProviderCallProcessingGetPolicyResponse17;
        }

        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse17sp3 or an ErrorResponse.
        /// 
        /// Replaced by ServiceProviderCallProcessingGetPolicyResponse17sp4
        /// </summary>
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse17sp3> ServiceProviderCallProcessingGetPolicyRequest17sp3(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest17sp3 request)
        {
            return await client.Call(request) as ServiceProviderCallProcessingGetPolicyResponse17sp3;
        }

        /// <summary>
        /// Add a new Communication Barring Profile.
        /// The priorities for OriginatingRules, RedirectingRules and IncomingRules are requantized to consecutive
        /// integers as part of the add.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringProfileAddRequest(this OcipClient client, ServiceProviderCommunicationBarringProfileAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringProfileGetResponse> ServiceProviderCommunicationBarringProfileGetRequest(this OcipClient client, ServiceProviderCommunicationBarringProfileGetRequest request)
        {
            return await client.Call(request) as ServiceProviderCommunicationBarringProfileGetResponse;
        }

        /// <summary>
        /// Get the service provider's enhanced call log settings.
        /// The response is either a ServiceProviderEnhancedCallLogsGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderEnhancedCallLogsGetResponse> ServiceProviderEnhancedCallLogsGetRequest(this OcipClient client, ServiceProviderEnhancedCallLogsGetRequest request)
        {
            return await client.Call(request) as ServiceProviderEnhancedCallLogsGetResponse;
        }

        /// <summary>
        /// Get the profile for a service provider or enterprise.
        /// The response is either a ServiceProviderGetResponse13mp2 or an ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderGetRequest17sp1
        /// </summary>
        public static async Task<ServiceProviderGetResponse13mp2> ServiceProviderGetRequest13mp2(this OcipClient client, ServiceProviderGetRequest13mp2 request)
        {
            return await client.Call(request) as ServiceProviderGetResponse13mp2;
        }

        /// <summary>
        /// Get the broadworks mobility system parameters.
        /// The response is either a SystemBroadWorksMobilityGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemBroadWorksMobilityGetRequest17sp4.
        /// </summary>
        public static async Task<SystemBroadWorksMobilityGetResponse> SystemBroadWorksMobilityGetRequest(this OcipClient client, SystemBroadWorksMobilityGetRequest request)
        {
            return await client.Call(request) as SystemBroadWorksMobilityGetResponse;
        }

        /// <summary>
        /// Modify the BroadWorks Mobility system parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemBroadWorksMobilityModifyRequest17sp4.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksMobilityModifyRequest(this OcipClient client, SystemBroadWorksMobilityModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the system level data associated with the Busy Lamp
        /// Field service. The response is either a SystemBusyLampFieldGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemBusyLampFieldGetResponse> SystemBusyLampFieldGetRequest(this OcipClient client, SystemBusyLampFieldGetRequest request)
        {
            return await client.Call(request) as SystemBusyLampFieldGetResponse;
        }

        /// <summary>
        /// Requests the list of System Diameter base parameters.
        /// The response is either SystemBwDiameterBaseDataGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemBwDiameterBaseDataGetResponse> SystemBwDiameterBaseDataGetRequest(this OcipClient client, SystemBwDiameterBaseDataGetRequest request)
        {
            return await client.Call(request) as SystemBwDiameterBaseDataGetResponse;
        }

        /// <summary>
        /// Request the system's calling name retrieval attributes.
        /// The response is either a SystemCallingNameRetrievalGetResponse16sp1 or an ErrorResponse.
        /// 
        /// Replaced by: SystemCallingNameRetrievalGetRequest17sp4
        /// </summary>
        public static async Task<SystemCallingNameRetrievalGetResponse16sp1> SystemCallingNameRetrievalGetRequest16sp1(this OcipClient client, SystemCallingNameRetrievalGetRequest16sp1 request)
        {
            return await client.Call(request) as SystemCallingNameRetrievalGetResponse16sp1;
        }

        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse17 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse17> SystemCallProcessingGetPolicyRequest17(this OcipClient client, SystemCallProcessingGetPolicyRequest17 request)
        {
            return await client.Call(request) as SystemCallProcessingGetPolicyResponse17;
        }

        /// <summary>
        /// Request the system level data associated with Call Processing Policy.
        /// The response is either a SystemCallProcessingGetPolicyResponse17sp3 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingGetPolicyRequest17sp4
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse17sp3> SystemCallProcessingGetPolicyRequest17sp3(this OcipClient client, SystemCallProcessingGetPolicyRequest17sp3 request)
        {
            return await client.Call(request) as SystemCallProcessingGetPolicyResponse17sp3;
        }

        /// <summary>
        /// Add a new Communication Barring Profile.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringProfileAddRequest(this OcipClient client, SystemCommunicationBarringProfileAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Communication Barring Profile.
        /// The priorities for IncomingRules are requantized to consecutive integers as part of the add.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in XS data mode:
        /// incomingDefaultAction
        /// incomingDefaultCallTimeout
        /// incomingRule
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringProfileAddRequest17sp1(this OcipClient client, SystemCommunicationBarringProfileAddRequest17sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a SystemCommunicationBarringProfileGetResponse16
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringProfileGetResponse16> SystemCommunicationBarringProfileGetRequest16(this OcipClient client, SystemCommunicationBarringProfileGetRequest16 request)
        {
            return await client.Call(request) as SystemCommunicationBarringProfileGetResponse16;
        }

        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a SystemCommunicationBarringProfileGetResponse17sp1
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCommunicationBarringProfileGetResponse17sp1> SystemCommunicationBarringProfileGetRequest17sp1(this OcipClient client, SystemCommunicationBarringProfileGetRequest17sp1 request)
        {
            return await client.Call(request) as SystemCommunicationBarringProfileGetResponse17sp1;
        }

        /// <summary>
        /// Replaced by: SystemDeviceTypeGetRequest18.
        /// Requests the information about the specified device type without regard to whether the
        /// type is SIP or MGCP.
        /// The response is either SystemDeviceTypeGetResponse16sp1 or ErrorResponse.
        /// </summary>
        public static async Task<SystemDeviceTypeGetResponse16sp1> SystemDeviceTypeGetRequest16sp1(this OcipClient client, SystemDeviceTypeGetRequest16sp1 request)
        {
            return await client.Call(request) as SystemDeviceTypeGetResponse16sp1;
        }

        /// <summary>
        /// Request the system level data associated with Enhanced Call Logs.
        /// The response is either a SystemEnhancedCallLogsGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemEnhancedCallLogsGetResponse> SystemEnhancedCallLogsGetRequest(this OcipClient client, SystemEnhancedCallLogsGetRequest request)
        {
            return await client.Call(request) as SystemEnhancedCallLogsGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Enhanced Call Logs.
        /// The response is either a SystemEnhancedCallLogsGetResponse20sp1 or an ErrorResponse.
        /// Replaced by:SystemEnhancedCallLogsGetRequest22 in AS data mode
        /// </summary>
        public static async Task<SystemEnhancedCallLogsGetResponse20sp1> SystemEnhancedCallLogsGetRequest20sp1(this OcipClient client, SystemEnhancedCallLogsGetRequest20sp1 request)
        {
            return await client.Call(request) as SystemEnhancedCallLogsGetResponse20sp1;
        }

        /// <summary>
        /// Modify the system level data associated with Enhanced Call Logs.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// isSendEnabled
        /// server1NetAddress
        /// server1SendPort
        /// server1RetrievePort
        /// server2NetAddress
        /// server2SendPort
        /// server2RetrievePort
        /// sharedSecret
        /// retransmissionDelayMilliSeconds
        /// maxTransmissions
        /// soapTimeoutSeconds
        /// useDBS
        /// eclQueryApplicationURL
        /// eclQueryDataRepositoryURL
        /// </summary>
        public static async Task<SuccessResponse> SystemEnhancedCallLogsModifyRequest(this OcipClient client, SystemEnhancedCallLogsModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Gets system level the Location Based Calling Restrictions attributes.
        /// The response is either a SystemLocationBasedCallingRestrictionsGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemLocationBasedCallingRestrictionsGetRequest17sp3
        /// </summary>
        public static async Task<SystemLocationBasedCallingRestrictionsGetResponse> SystemLocationBasedCallingRestrictionsGetRequest(this OcipClient client, SystemLocationBasedCallingRestrictionsGetRequest request)
        {
            return await client.Call(request) as SystemLocationBasedCallingRestrictionsGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Meet-Me Conferencing functions.
        /// The response is either a SystemMeetMeConferencingGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemMeetMeConferencingGetRequest17sp3
        /// </summary>
        public static async Task<SystemMeetMeConferencingGetResponse> SystemMeetMeConferencingGetRequest(this OcipClient client, SystemMeetMeConferencingGetRequest request)
        {
            return await client.Call(request) as SystemMeetMeConferencingGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Meet-Me Conferencing functions.
        /// The response is either a SystemMeetMeConferencingGetResponse17sp3 or an ErrorResponse.
        /// 
        /// Replaced by: SystemMeetMeConferencingGetRequest18
        /// </summary>
        public static async Task<SystemMeetMeConferencingGetResponse17sp3> SystemMeetMeConferencingGetRequest17sp3(this OcipClient client, SystemMeetMeConferencingGetRequest17sp3 request)
        {
            return await client.Call(request) as SystemMeetMeConferencingGetResponse17sp3;
        }

        /// <summary>
        /// Request to get the list of Network Server Sync system parameters.
        /// The response is either SystemNetworkServerSyncParametersGetResponse16 or ErrorResponse.
        /// Replaced By: SystemNetworkServerSyncParametersGetRequest17sp4
        /// </summary>
        public static async Task<SystemNetworkServerSyncParametersGetResponse16> SystemNetworkServerSyncParametersGetRequest16(this OcipClient client, SystemNetworkServerSyncParametersGetRequest16 request)
        {
            return await client.Call(request) as SystemNetworkServerSyncParametersGetResponse16;
        }

        /// <summary>
        /// Request the system level data associated with Outgoing Calling Plan.
        /// The response is either a SystemOutgoingCallingPlanGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemOutgoingCallingPlanGetResponse> SystemOutgoingCallingPlanGetRequest(this OcipClient client, SystemOutgoingCallingPlanGetRequest request)
        {
            return await client.Call(request) as SystemOutgoingCallingPlanGetResponse;
        }

        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse17 or ErrorResponse.
        /// </summary>
        public static async Task<SystemPolicyGetDefaultResponse17> SystemPolicyGetDefaultRequest17(this OcipClient client, SystemPolicyGetDefaultRequest17 request)
        {
            return await client.Call(request) as SystemPolicyGetDefaultResponse17;
        }

        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse17sp1 or ErrorResponse.
        /// </summary>
        public static async Task<SystemPolicyGetDefaultResponse17sp1> SystemPolicyGetDefaultRequest17sp1(this OcipClient client, SystemPolicyGetDefaultRequest17sp1 request)
        {
            return await client.Call(request) as SystemPolicyGetDefaultResponse17sp1;
        }

        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse17sp3 or ErrorResponse.
        /// </summary>
        public static async Task<SystemPolicyGetDefaultResponse17sp3> SystemPolicyGetDefaultRequest17sp3(this OcipClient client, SystemPolicyGetDefaultRequest17sp3 request)
        {
            return await client.Call(request) as SystemPolicyGetDefaultResponse17sp3;
        }

        /// <summary>
        /// Replaced by: SystemRedundancyParametersGetRequest16sp2
        /// 
        /// Request to get the list of Redundancy system parameters.
        /// The response is either SystemRedundancyParametersGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemRedundancyParametersGetResponse> SystemRedundancyParametersGetRequest(this OcipClient client, SystemRedundancyParametersGetRequest request)
        {
            return await client.Call(request) as SystemRedundancyParametersGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with session audit.
        /// The response is either a SystemSessionAuditGetResponse14sp3 or
        /// an ErrorResponse.
        /// </summary>
        public static async Task<SystemSessionAuditGetResponse14sp3> SystemSessionAuditGetRequest14sp3(this OcipClient client, SystemSessionAuditGetRequest14sp3 request)
        {
            return await client.Call(request) as SystemSessionAuditGetResponse14sp3;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest17(this OcipClient client, SystemSIPDeviceTypeAddRequest17 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by: SystemSIPDeviceTypeAddRequest18
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest17sp4(this OcipClient client, SystemSIPDeviceTypeAddRequest17sp4 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Replaced by: SystemSIPDeviceTypeFileAddRequest18.
        /// Request to add a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileAddRequest16sp1(this OcipClient client, SystemSIPDeviceTypeFileAddRequest16sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Replaced by: SystemSIPDeviceTypeFileGetRequest18.
        /// Request to get a sip device type file.
        /// The response is either SystemSIPDeviceTypeFileGetResponse16sp1 or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeFileGetResponse16sp1> SystemSIPDeviceTypeFileGetRequest16sp1(this OcipClient client, SystemSIPDeviceTypeFileGetRequest16sp1 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeFileGetResponse16sp1;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse17 or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse17> SystemSIPDeviceTypeGetRequest17(this OcipClient client, SystemSIPDeviceTypeGetRequest17 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse17;
        }

        /// <summary>
        /// Replaced by: SystemSIPDeviceTypeGetRequest18.
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse17sp4 or ErrorResponse.
        /// Replaced by: SystemSIPDeviceTypeGetRequest18
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse17sp4> SystemSIPDeviceTypeGetRequest17sp4(this OcipClient client, SystemSIPDeviceTypeGetRequest17sp4 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse17sp4;
        }

        /// <summary>
        /// Get the speed dial 100 system-wide default setting.
        /// The response is either a SystemSpeedDial100GetResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemSpeedDial100GetRequest17sp1
        /// </summary>
        public static async Task<SystemSpeedDial100GetResponse> SystemSpeedDial100GetRequest(this OcipClient client, SystemSpeedDial100GetRequest request)
        {
            return await client.Call(request) as SystemSpeedDial100GetResponse;
        }

        /// <summary>
        /// Get the system call processing configuration for all subscribers
        /// The response is either a SystemSubscriberGetCallProcessingParametersResponse17
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSubscriberGetCallProcessingParametersResponse17> SystemSubscriberGetCallProcessingParametersRequest17(this OcipClient client, SystemSubscriberGetCallProcessingParametersRequest17 request)
        {
            return await client.Call(request) as SystemSubscriberGetCallProcessingParametersResponse17;
        }

        /// <summary>
        /// Get the system call processing configuration for all subscribers
        /// The response is either a SystemSubscriberGetCallProcessingParametersResponse17sp3
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSubscriberGetCallProcessingParametersResponse17sp3> SystemSubscriberGetCallProcessingParametersRequest17sp3(this OcipClient client, SystemSubscriberGetCallProcessingParametersRequest17sp3 request)
        {
            return await client.Call(request) as SystemSubscriberGetCallProcessingParametersResponse17sp3;
        }

        /// <summary>
        /// Request the system level data associated with Voice Messaging.
        /// The response is either a SystemVoiceMessagingGroupGetResponse16 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemVoiceMessagingGroupGetRequest16sp2
        /// </summary>
        public static async Task<SystemVoiceMessagingGroupGetResponse16> SystemVoiceMessagingGroupGetRequest16(this OcipClient client, SystemVoiceMessagingGroupGetRequest16 request)
        {
            return await client.Call(request) as SystemVoiceMessagingGroupGetResponse16;
        }

        /// <summary>
        /// Requests the system voice portal Menus setting.
        /// The response is either SystemVoiceMessagingGroupGetVoicePortalMenusResponse14 or ErrorResponse.
        /// </summary>
        public static async Task<SystemVoiceMessagingGroupGetVoicePortalMenusResponse14> SystemVoiceMessagingGroupGetVoicePortalMenusRequest14(this OcipClient client, SystemVoiceMessagingGroupGetVoicePortalMenusRequest14 request)
        {
            return await client.Call(request) as SystemVoiceMessagingGroupGetVoicePortalMenusResponse14;
        }

        /// <summary>
        /// Replaced by: UserAddRequest17sp4
        /// 
        /// Request to add a user.
        /// The domain is required in the userId.
        /// The password is not required if external authentication is enabled.
        /// The officeZoneName and primaryZoneName elements are ignored and provided here for backwards
        /// compatibility only.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserAddRequest14sp9(this OcipClient client, UserAddRequest14sp9 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the settings for the busy lamp field service.
        /// The response is either a UserBusyLampFieldGetResponse or an ErrorResponse.
        /// Replaced by: UserBusyLampFieldGetRequest16sp2
        /// </summary>
        public static async Task<UserBusyLampFieldGetResponse> UserBusyLampFieldGetRequest(this OcipClient client, UserBusyLampFieldGetRequest request)
        {
            return await client.Call(request) as UserBusyLampFieldGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Call Processing Policy.
        /// The response is either a UserCallProcessingGetPolicyResponse17 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserCallProcessingGetPolicyResponse17> UserCallProcessingGetPolicyRequest17(this OcipClient client, UserCallProcessingGetPolicyRequest17 request)
        {
            return await client.Call(request) as UserCallProcessingGetPolicyResponse17;
        }

        /// <summary>
        /// Request the user level data associated with Call Processing Policy.
        /// The response is either a UserCallProcessingGetPolicyResponse17sp3 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: UserCallProcessingGetPolicyRequest17Sp4
        /// </summary>
        public static async Task<UserCallProcessingGetPolicyResponse17sp3> UserCallProcessingGetPolicyRequest17sp3(this OcipClient client, UserCallProcessingGetPolicyRequest17sp3 request)
        {
            return await client.Call(request) as UserCallProcessingGetPolicyResponse17sp3;
        }

        /// <summary>
        /// Request the user level data associated with Call Processing Policy.
        /// The response is either a UserCallProcessingGetPolicyResponse17sp4 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: UserCallProcessingGetPolicyRequest18
        /// </summary>
        public static async Task<UserCallProcessingGetPolicyResponse17sp4> UserCallProcessingGetPolicyRequest17sp4(this OcipClient client, UserCallProcessingGetPolicyRequest17sp4 request)
        {
            return await client.Call(request) as UserCallProcessingGetPolicyResponse17sp4;
        }

        /// <summary>
        /// Request the user level data associated with Call Waiting.
        /// The response is either a UserCallWaitingGetResponse or an
        /// ErrorResponse.
        /// Replaced by: UserCallWaitingGetRequest17sp4
        /// </summary>
        public static async Task<UserCallWaitingGetResponse> UserCallWaitingGetRequest(this OcipClient client, UserCallWaitingGetRequest request)
        {
            return await client.Call(request) as UserCallWaitingGetResponse;
        }

        /// <summary>
        /// Request user's call logs.
        /// If the callLogType is not specified, all types of calls logs (placed, received, missed) are returned.
        /// It is possible to restrict the number of rows returned using responsePagingControl.
        /// The response is either a UserEnhancedCallLogsGetListResponse16 or an ErrorResponse.
        /// 
        /// Replaced by UserEnhancedCallLogsGetListRequest17sp4
        /// </summary>
        public static async Task<UserEnhancedCallLogsGetListResponse16> UserEnhancedCallLogsGetListRequest16(this OcipClient client, UserEnhancedCallLogsGetListRequest16 request)
        {
            return await client.Call(request) as UserEnhancedCallLogsGetListResponse16;
        }

        /// <summary>
        /// Request user's call logs.
        /// If the callLogType is not specified, all types of calls logs (placed, received, missed) are returned.
        /// The filters "dateTimeRange", "numberFilter", "redirectedNumberFilter", accountAuthorizationCodeFilter"
        /// and ""subscriberType" are ignored if call logs are stored in CDS. When "ReceivedOrMissed" is specified
        /// as "callLogType" and call logs are stored in CDS, all call logs including placed will be returned.
        /// It is possible to restrict the number of rows returned using responsePagingControl. If
        /// responsePagingControl
        /// is not specified, the value of Enhanced Call Logs system parameter maxNonPagedResponseSize will control
        /// the maximum number of call logs can be returned.
        /// The response is either a UserEnhancedCallLogsGetListResponse17sp4 or an ErrorResponse.
        /// Replaced by UserEnhancedCallLogsGetListRequest17sp4V2.
        /// Originally deprecated in release 20.
        /// </summary>
        public static async Task<UserEnhancedCallLogsGetListResponse17sp4> UserEnhancedCallLogsGetListRequest17sp4(this OcipClient client, UserEnhancedCallLogsGetListRequest17sp4 request)
        {
            return await client.Call(request) as UserEnhancedCallLogsGetListResponse17sp4;
        }

        /// <summary>
        /// Request the user level data associated with Fax Messaging.
        /// The response is either a UserFaxMessagingGetResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<UserFaxMessagingGetResponse17> UserFaxMessagingGetRequest17(this OcipClient client, UserFaxMessagingGetRequest17 request)
        {
            return await client.Call(request) as UserFaxMessagingGetResponse17;
        }

        /// <summary>
        /// Replaced by: UserGetRequest17sp4
        /// 
        /// Request to get the user information.
        /// The response is either UserGetResponse17 or ErrorResponse.
        /// </summary>
        public static async Task<UserGetResponse17> UserGetRequest17(this OcipClient client, UserGetRequest17 request)
        {
            return await client.Call(request) as UserGetResponse17;
        }

        /// <summary>
        /// Replaced by: UserGetRequest18
        /// 
        /// Request to get the user information.
        /// The response is either UserGetResponse17sp3 or ErrorResponse.
        /// </summary>
        public static async Task<UserGetResponse17sp3> UserGetRequest17sp3(this OcipClient client, UserGetRequest17sp3 request)
        {
            return await client.Call(request) as UserGetResponse17sp3;
        }

        /// <summary>
        /// Replaced by: UserGetRequest18
        /// 
        /// Request to get the user information.
        /// The response is either UserGetResponse17sp4 or ErrorResponse.
        /// </summary>
        public static async Task<UserGetResponse17sp4> UserGetRequest17sp4(this OcipClient client, UserGetRequest17sp4 request)
        {
            return await client.Call(request) as UserGetResponse17sp4;
        }

        /// <summary>
        /// Replaced by: UserModifyRequest17sp4
        /// 
        /// Request to modify a user.
        /// When oldPassword is specified, all password rule applies. If oldPassword in not specified,
        /// any password rule related to old password does not apply.
        /// The request will fail if officeZoneName or primaryZoneName is present but the Location-Based Calling
        /// Restrictions service is not assigned to the user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserModifyRequest16(this OcipClient client, UserModifyRequest16 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the list of a user schedules. The list can be filtered by schedule type.
        /// The response is either a UserScheduleGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserScheduleGetListResponse> UserScheduleGetListRequest(this OcipClient client, UserScheduleGetListRequest request)
        {
            return await client.Call(request) as UserScheduleGetListResponse;
        }

        /// <summary>
        /// Get the user's Shared Call Appearance service setting.
        /// The response is either a UserSharedCallAppearanceGetResponse14sp2 or an ErrorResponse.
        /// </summary>
        public static async Task<UserSharedCallAppearanceGetResponse14sp2> UserSharedCallAppearanceGetRequest14sp2(this OcipClient client, UserSharedCallAppearanceGetRequest14sp2 request)
        {
            return await client.Call(request) as UserSharedCallAppearanceGetResponse14sp2;
        }

        /// <summary>
        /// Get the speed dial 100 settings for a user.
        /// The response is either a UserSpeedDial100GetListResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserSpeedDial100GetListRequest17Sp1
        /// </summary>
        public static async Task<UserSpeedDial100GetListResponse> UserSpeedDial100GetListRequest(this OcipClient client, UserSpeedDial100GetListRequest request)
        {
            return await client.Call(request) as UserSpeedDial100GetListResponse;
        }

        /// <summary>
        /// Get the user's voice messaging greeting information.
        /// The response is either a UserVoiceMessagingUserGetGreetingResponse16 or an ErrorResponse.
        /// 
        /// Replaced by: UserVoiceMessagingUserGetGreetingRequest18
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetGreetingResponse16> UserVoiceMessagingUserGetGreetingRequest16(this OcipClient client, UserVoiceMessagingUserGetGreetingRequest16 request)
        {
            return await client.Call(request) as UserVoiceMessagingUserGetGreetingResponse16;
        }

        /// <summary>
        /// Request the enterprise level data associated with Call Center Agents Unavailable Code Settings.
        /// The response is either an EnterpriseCallCenterAgentUnavailableCodeSettingsGetResponse or an
        /// ErrorResponse.
        /// 
        /// Replaced by EnterpriseCallCenterAgentUnavailableCodeSettingsGetRequest17sp4.
        /// </summary>
        public static async Task<EnterpriseCallCenterAgentUnavailableCodeSettingsGetResponse> EnterpriseCallCenterAgentUnavailableCodeSettingsGetRequest(this OcipClient client, EnterpriseCallCenterAgentUnavailableCodeSettingsGetRequest request)
        {
            return await client.Call(request) as EnterpriseCallCenterAgentUnavailableCodeSettingsGetResponse;
        }

        /// <summary>
        /// Request to get an enterprise level call center enhanced reporting setting.
        /// The response is either an EnterpriseCallCenterEnhancedReportingGetResponse or an ErrorResponse.
        /// 
        /// Replaced by EnterpriseCallCenterEnhancedReportingGetRequest19
        /// </summary>
        public static async Task<EnterpriseCallCenterEnhancedReportingGetResponse> EnterpriseCallCenterEnhancedReportingGetRequest(this OcipClient client, EnterpriseCallCenterEnhancedReportingGetRequest request)
        {
            return await client.Call(request) as EnterpriseCallCenterEnhancedReportingGetResponse;
        }

        /// <summary>
        /// Request to modify enterprise level call center enhanced reporting settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by EnterpriseCallCenterEnhancedReportingModifyRequest19
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseCallCenterEnhancedReportingModifyRequest(this OcipClient client, EnterpriseCallCenterEnhancedReportingModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the enterprise level data associated with Call Center.
        /// The response is either an EnterpriseCallCenterGetResponse or an
        /// ErrorResponse.
        /// 
        /// Replaced by EnterpriseCallCenterGetRequest17sp4.
        /// </summary>
        public static async Task<EnterpriseCallCenterGetResponse> EnterpriseCallCenterGetRequest(this OcipClient client, EnterpriseCallCenterGetRequest request)
        {
            return await client.Call(request) as EnterpriseCallCenterGetResponse;
        }

        /// <summary>
        /// Requests the list of available access devices for assignment to a user
        /// within a group. The list includes devices created at the system, service provider, and group levels.
        /// The response is either GroupAccessDeviceGetAvailableDetailListResponse14 or
        /// ErrorResponse.
        /// 
        /// Replaced by: GroupAccessDeviceGetAvailableDetailListRequest19.
        /// </summary>
        public static async Task<GroupAccessDeviceGetAvailableDetailListResponse14> GroupAccessDeviceGetAvailableDetailListRequest14(this OcipClient client, GroupAccessDeviceGetAvailableDetailListRequest14 request)
        {
            return await client.Call(request) as GroupAccessDeviceGetAvailableDetailListResponse14;
        }

        /// <summary>
        /// Requests the configuration of a specified group access device.
        /// The response is either GroupAccessDeviceGetResponse16 or ErrorResponse.
        /// 
        /// Replaced by: GroupAccessDeviceGetRequest18sp1
        /// </summary>
        public static async Task<GroupAccessDeviceGetResponse16> GroupAccessDeviceGetRequest16(this OcipClient client, GroupAccessDeviceGetRequest16 request)
        {
            return await client.Call(request) as GroupAccessDeviceGetResponse16;
        }

        /// <summary>
        /// Add a Auto Attendant instance to a group.
        /// The domain is required in the serviceUserId.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantAddInstanceRequest17sp1(this OcipClient client, GroupAutoAttendantAddInstanceRequest17sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get all the information of a Auto Attendant instance.
        /// The response is either GroupAutoAttendantGetInstanceResponse17sp1 or ErrorResponse.
        /// </summary>
        public static async Task<GroupAutoAttendantGetInstanceResponse17sp1> GroupAutoAttendantGetInstanceRequest17sp1(this OcipClient client, GroupAutoAttendantGetInstanceRequest17sp1 request)
        {
            return await client.Call(request) as GroupAutoAttendantGetInstanceResponse17sp1;
        }

        /// <summary>
        /// Add a Call Center instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced by GroupCallCenterAddInstanceRequest19
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterAddInstanceRequest17sp3(this OcipClient client, GroupCallCenterAddInstanceRequest17sp3 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the group level data associated with Call Center Agents Unavailable Code Settings.
        /// The response is either an GroupCallCenterAgentUnavailableCodeSettingsGetResponse or an
        /// ErrorResponse.
        /// 
        /// Replaced by GroupCallCenterAgentUnavailableCodeSettingsGetRequest17sp4.
        /// </summary>
        public static async Task<GroupCallCenterAgentUnavailableCodeSettingsGetResponse> GroupCallCenterAgentUnavailableCodeSettingsGetRequest(this OcipClient client, GroupCallCenterAgentUnavailableCodeSettingsGetRequest request)
        {
            return await client.Call(request) as GroupCallCenterAgentUnavailableCodeSettingsGetResponse;
        }

        /// <summary>
        /// Request to get a group level call center enhanced reporting setting.
        /// The response is either a GroupCallCenterEnhancedReportingGetResponse or an ErrorResponse.
        /// 
        /// Replaced by GroupCallCenterEnhancedReportingGetRequest19
        /// </summary>
        public static async Task<GroupCallCenterEnhancedReportingGetResponse> GroupCallCenterEnhancedReportingGetRequest(this OcipClient client, GroupCallCenterEnhancedReportingGetRequest request)
        {
            return await client.Call(request) as GroupCallCenterEnhancedReportingGetResponse;
        }

        /// <summary>
        /// Request to modify group level call center enhanced reporting settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by GroupCallCenterEnhancedReportingModifyRequest19
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterEnhancedReportingModifyRequest(this OcipClient client, GroupCallCenterEnhancedReportingModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a call center's announcement settings.
        /// The response is either a GroupCallCenterGetAnnouncementResponse17 or an ErrorResponse.
        /// 
        /// Replaced by GroupCallCenterGetAnnouncementRequest17sp4
        /// </summary>
        public static async Task<GroupCallCenterGetAnnouncementResponse17> GroupCallCenterGetAnnouncementRequest17(this OcipClient client, GroupCallCenterGetAnnouncementRequest17 request)
        {
            return await client.Call(request) as GroupCallCenterGetAnnouncementResponse17;
        }

        /// <summary>
        /// Get a call center's announcement settings.
        /// The response is either a GroupCallCenterGetAnnouncementResponse17sp4 or an ErrorResponse.
        /// 
        /// Replaced by: GroupCallCenterGetAnnouncementRequest19.
        /// </summary>
        public static async Task<GroupCallCenterGetAnnouncementResponse17sp4> GroupCallCenterGetAnnouncementRequest17sp4(this OcipClient client, GroupCallCenterGetAnnouncementRequest17sp4 request)
        {
            return await client.Call(request) as GroupCallCenterGetAnnouncementResponse17sp4;
        }

        /// <summary>
        /// Get a call center's DNIS Announcements
        /// The response is either a GroupCallCenterGetDNISAnnouncementResponse or an ErrorResponse.
        /// 
        /// Replaced by GroupCallCenterGetDNISAnnouncementRequest17sp4
        /// </summary>
        public static async Task<GroupCallCenterGetDNISAnnouncementResponse> GroupCallCenterGetDNISAnnouncementRequest(this OcipClient client, GroupCallCenterGetDNISAnnouncementRequest request)
        {
            return await client.Call(request) as GroupCallCenterGetDNISAnnouncementResponse;
        }

        /// <summary>
        /// Get a call center's DNIS Announcements
        /// The response is either a GroupCallCenterGetDNISAnnouncementResponse17sp4 or an ErrorResponse.
        /// 
        /// Replaced by: GroupCallCenterGetDNISAnnouncementRequest19.
        /// </summary>
        public static async Task<GroupCallCenterGetDNISAnnouncementResponse17sp4> GroupCallCenterGetDNISAnnouncementRequest17sp4(this OcipClient client, GroupCallCenterGetDNISAnnouncementRequest17sp4 request)
        {
            return await client.Call(request) as GroupCallCenterGetDNISAnnouncementResponse17sp4;
        }

        /// <summary>
        /// Request to get all the information of a Call Center instance.
        /// The response is either GroupCallCenterGetInstanceResponse17sp3 or ErrorResponse.
        /// Replaced by GroupCallCenterGetInstanceRequest19
        /// </summary>
        public static async Task<GroupCallCenterGetInstanceResponse17sp3> GroupCallCenterGetInstanceRequest17sp3(this OcipClient client, GroupCallCenterGetInstanceRequest17sp3 request)
        {
            return await client.Call(request) as GroupCallCenterGetInstanceResponse17sp3;
        }

        /// <summary>
        /// Request the Group level data associated with Call Center.
        /// The response is either a GroupCallCenterGetResponse or an
        /// ErrorResponse.
        /// 
        /// Replaced by GroupCallCenterGetRequest17sp4.
        /// </summary>
        public static async Task<GroupCallCenterGetResponse> GroupCallCenterGetRequest(this OcipClient client, GroupCallCenterGetRequest request)
        {
            return await client.Call(request) as GroupCallCenterGetResponse;
        }

        /// <summary>
        /// Request to modify a Call Center instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced by: GroupCallCenterModifyInstanceRequest19
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyInstanceRequest17sp1(this OcipClient client, GroupCallCenterModifyInstanceRequest17sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a Hunt Group instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in XS data mode:
        /// allowMembersToControlGroupBusy, use value "false" in AS data mode
        /// enableGroupBusy, use value "false" in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupHuntGroupAddInstanceRequest17sp1V1(this OcipClient client, GroupHuntGroupAddInstanceRequest17sp1V1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a Hunt Group instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// useSystemHuntGroupCLIDSetting, use value "true" in XS data mode
        /// includeHuntGroupNameInCLID, use value "true" in XS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupHuntGroupAddInstanceRequest17sp4(this OcipClient client, GroupHuntGroupAddInstanceRequest17sp4 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get all the information of a Hunt Group instance.
        /// The response is either GroupHuntGroupGetInstanceResponse17sp1V1 or ErrorResponse.
        /// </summary>
        public static async Task<GroupHuntGroupGetInstanceResponse17sp1V1> GroupHuntGroupGetInstanceRequest17sp1V1(this OcipClient client, GroupHuntGroupGetInstanceRequest17sp1V1 request)
        {
            return await client.Call(request) as GroupHuntGroupGetInstanceResponse17sp1V1;
        }

        /// <summary>
        /// Request to get all the information of a Hunt Group instance.
        /// The response is either GroupHuntGroupGetInstanceResponse17sp4 or ErrorResponse.
        /// </summary>
        public static async Task<GroupHuntGroupGetInstanceResponse17sp4> GroupHuntGroupGetInstanceRequest17sp4(this OcipClient client, GroupHuntGroupGetInstanceRequest17sp4 request)
        {
            return await client.Call(request) as GroupHuntGroupGetInstanceResponse17sp4;
        }

        /// <summary>
        /// Add a Meet-Me Conferencing bridge to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupMeetMeConferencingAddInstanceRequest18(this OcipClient client, GroupMeetMeConferencingAddInstanceRequest18 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get all the information of a Meet-Me Conferencing bridge.
        /// The response is either GroupMeetMeConferencingGetInstanceResponse18 or ErrorResponse.
        /// </summary>
        public static async Task<GroupMeetMeConferencingGetInstanceResponse18> GroupMeetMeConferencingGetInstanceRequest18(this OcipClient client, GroupMeetMeConferencingGetInstanceRequest18 request)
        {
            return await client.Call(request) as GroupMeetMeConferencingGetInstanceResponse18;
        }

        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse16 or ErrorResponse.
        /// 
        /// Replaced by: GroupMusicOnHoldGetInstanceRequest19.
        /// </summary>
        public static async Task<GroupMusicOnHoldGetInstanceResponse16> GroupMusicOnHoldGetInstanceRequest16(this OcipClient client, GroupMusicOnHoldGetInstanceRequest16 request)
        {
            return await client.Call(request) as GroupMusicOnHoldGetInstanceResponse16;
        }

        /// <summary>
        /// Requests the group's passcode rules setting.
        /// The response is either GroupPortalPasscodeRulesGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupPortalPasscodeRulesGetResponse> GroupPortalPasscodeRulesGetRequest(this OcipClient client, GroupPortalPasscodeRulesGetRequest request)
        {
            return await client.Call(request) as GroupPortalPasscodeRulesGetResponse;
        }

        /// <summary>
        /// Get a route point's announcement settings.
        /// The response is either a GroupRoutePointGetAnnouncementResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupRoutePointGetAnnouncementRequest19.
        /// </summary>
        public static async Task<GroupRoutePointGetAnnouncementResponse> GroupRoutePointGetAnnouncementRequest(this OcipClient client, GroupRoutePointGetAnnouncementRequest request)
        {
            return await client.Call(request) as GroupRoutePointGetAnnouncementResponse;
        }

        /// <summary>
        /// Get a route point's DNIS Announcements
        /// The response is either a GroupRoutePointGetDNISAnnouncementResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupRoutePointGetDNISAnnouncementRequest19.
        /// </summary>
        public static async Task<GroupRoutePointGetDNISAnnouncementResponse> GroupRoutePointGetDNISAnnouncementRequest(this OcipClient client, GroupRoutePointGetDNISAnnouncementRequest request)
        {
            return await client.Call(request) as GroupRoutePointGetDNISAnnouncementResponse;
        }

        /// <summary>
        /// Add a Trunk Group instance to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupAddInstanceRequest17sp4(this OcipClient client, GroupTrunkGroupAddInstanceRequest17sp4 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse17sp4 or an ErrorResponse.
        /// The response contains a hosted user table with column headings: "User Id", "Last Name",
        /// "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number", "Extension",
        /// "Department", "Email Address".
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceResponse17sp4> GroupTrunkGroupGetInstanceRequest17sp4(this OcipClient client, GroupTrunkGroupGetInstanceRequest17sp4 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceResponse17sp4;
        }

        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse17sp4V2 or an ErrorResponse.
        /// The response contains a hosted user table with column headings: "User Id", "Last Name",
        /// "First Name", "Hiragana Last Name", "Hiragana First Name".
        /// 
        /// Replaced by: GroupTrunkGroupGetInstanceRequest19V2
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceResponse17sp4V2> GroupTrunkGroupGetInstanceRequest17sp4V2(this OcipClient client, GroupTrunkGroupGetInstanceRequest17sp4V2 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceResponse17sp4V2;
        }

        /// <summary>
        /// Requests the configuration of a specified service provider access device.
        /// The response is either ServiceProviderAccessDeviceGetResponse16 or ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderAccessDeviceGetRequest19
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetResponse16> ServiceProviderAccessDeviceGetRequest16(this OcipClient client, ServiceProviderAccessDeviceGetRequest16 request)
        {
            return await client.Call(request) as ServiceProviderAccessDeviceGetResponse16;
        }

        /// <summary>
        /// Requests the service provider's passcode rules setting.
        /// The response is either ServiceProviderPortalPasscodeRulesGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderPortalPasscodeRulesGetResponse> ServiceProviderPortalPasscodeRulesGetRequest(this OcipClient client, ServiceProviderPortalPasscodeRulesGetRequest request)
        {
            return await client.Call(request) as ServiceProviderPortalPasscodeRulesGetResponse;
        }

        /// <summary>
        /// Requests the configuration of a specified system access device.
        /// The response is either SystemAccessDeviceGetResponse16 or ErrorResponse.
        /// 
        /// Replaced by: SystemAccessDeviceGetRequest19
        /// </summary>
        public static async Task<SystemAccessDeviceGetResponse16> SystemAccessDeviceGetRequest16(this OcipClient client, SystemAccessDeviceGetRequest16 request)
        {
            return await client.Call(request) as SystemAccessDeviceGetResponse16;
        }

        /// <summary>
        /// Request the system level data associated with Call Center.
        /// The response is either a SystemCallCenterGetResponse17 or an
        /// ErrorResponse.
        /// 
        /// Replaced by SystemCallCenterGetRequest17sp4.
        /// </summary>
        public static async Task<SystemCallCenterGetResponse17> SystemCallCenterGetRequest17(this OcipClient client, SystemCallCenterGetRequest17 request)
        {
            return await client.Call(request) as SystemCallCenterGetResponse17;
        }

        /// <summary>
        /// Request the system level data associated with Call Center.
        /// The response is either a SystemCallCenterGetResponse17sp4 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallCenterGetRequest19
        /// </summary>
        public static async Task<SystemCallCenterGetResponse17sp4> SystemCallCenterGetRequest17sp4(this OcipClient client, SystemCallCenterGetRequest17sp4 request)
        {
            return await client.Call(request) as SystemCallCenterGetResponse17sp4;
        }

        /// <summary>
        /// Request to get a list of Call Center Reporting Server.
        /// The response is either SystemCallCenterReportingServerGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemCallCenterReportingServerGetListResponse> SystemCallCenterReportingServerGetListRequest(this OcipClient client, SystemCallCenterReportingServerGetListRequest request)
        {
            return await client.Call(request) as SystemCallCenterReportingServerGetListResponse;
        }

        /// <summary>
        /// Add a Call Recording platform.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemCallRecordingAddPlatformRequest19
        /// </summary>
        public static async Task<SuccessResponse> SystemCallRecordingAddPlatformRequest(this OcipClient client, SystemCallRecordingAddPlatformRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests a list of non-obsolete Identity/device profile types defined in the system. It is possible
        /// to get either all conference device types or all non-conferernce types. This command is similar
        /// to the SystemSIPDeviceTypeGetListRequest and SystemMGCPDeviceTypeGetListRequest
        /// but gets both SIP and MGCP types.
        /// The response is either SystemDeviceTypeGetAvailableListResponse14sp3 or ErrorResponse.
        /// 
        /// Replaced by: SystemDeviceTypeGetAvailableListRequest19.
        /// </summary>
        public static async Task<SystemDeviceTypeGetAvailableListResponse14sp3> SystemDeviceTypeGetAvailableListRequest14sp3(this OcipClient client, SystemDeviceTypeGetAvailableListRequest14sp3 request)
        {
            return await client.Call(request) as SystemDeviceTypeGetAvailableListResponse14sp3;
        }

        /// <summary>
        /// Requests the information about the specified device type without regard to whether the
        /// type is SIP or MGCP.
        /// The response is either SystemDeviceTypeGetResponse18 or ErrorResponse.
        /// Note: The elements deviceTypeConfigurationOption applies to SIP device types only. Therefore, only
        /// present in the response when the device type is SIP.
        /// Replaced by: SystemSIPDeviceTypeGetRequest19.
        /// </summary>
        public static async Task<SystemDeviceTypeGetResponse18> SystemDeviceTypeGetRequest18(this OcipClient client, SystemDeviceTypeGetRequest18 request)
        {
            return await client.Call(request) as SystemDeviceTypeGetResponse18;
        }

        /// <summary>
        /// Requests the information about the specified device type without regard to whether the
        /// type is SIP or MGCP.
        /// The response is either SystemDeviceTypeGetResponse19 or ErrorResponse.
        /// Note: The elements deviceTypeConfigurationOption and staticLineOrdering apply to SIP device types only.
        /// Therefore, only present in the response when the device type is SIP.
        /// 
        /// Replaced by: SystemSIPDeviceTypeGetRequest21sp1.
        /// </summary>
        public static async Task<SystemDeviceTypeGetResponse19> SystemDeviceTypeGetRequest19(this OcipClient client, SystemDeviceTypeGetRequest19 request)
        {
            return await client.Call(request) as SystemDeviceTypeGetResponse19;
        }

        /// <summary>
        /// Get the system Integrated IMP service attributes.
        /// The response is either SystemIntegratedIMPGetResponse or ErrorResponse.
        /// 
        /// Replaced by SystemIntegratedIMPGetRequest19.
        /// </summary>
        public static async Task<SystemIntegratedIMPGetResponse> SystemIntegratedIMPGetRequest(this OcipClient client, SystemIntegratedIMPGetRequest request)
        {
            return await client.Call(request) as SystemIntegratedIMPGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Meet-Me Conferencing functions.
        /// The response is either a SystemMeetMeConferencingGetResponse18 or an ErrorResponse.
        /// 
        /// Replaced by SystemMeetMeConferencingGetRequest19
        /// </summary>
        public static async Task<SystemMeetMeConferencingGetResponse18> SystemMeetMeConferencingGetRequest18(this OcipClient client, SystemMeetMeConferencingGetRequest18 request)
        {
            return await client.Call(request) as SystemMeetMeConferencingGetResponse18;
        }

        /// <summary>
        /// Request to get the Number Activation state.
        /// The response is either SystemNumberActivationGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemNumberActivationGetResponse> SystemNumberActivationGetRequest(this OcipClient client, SystemNumberActivationGetRequest request)
        {
            return await client.Call(request) as SystemNumberActivationGetResponse;
        }

        /// <summary>
        /// Request to modify system number activation setting.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemNumberActivationModifyRequest(this OcipClient client, SystemNumberActivationModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests the system passcode rules setting.
        /// The response is either SystemPortalPasscodeRulesGetResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemPortalPasscodeRulesGetRequest19
        /// </summary>
        public static async Task<SystemPortalPasscodeRulesGetResponse> SystemPortalPasscodeRulesGetRequest(this OcipClient client, SystemPortalPasscodeRulesGetRequest request)
        {
            return await client.Call(request) as SystemPortalPasscodeRulesGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Selective Services.
        /// The response is either a SystemSelectiveServicesGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemSelectiveServicesGetResponse> SystemSelectiveServicesGetRequest(this OcipClient client, SystemSelectiveServicesGetRequest request)
        {
            return await client.Call(request) as SystemSelectiveServicesGetResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in XS data mode:
        /// enable3G4GContinuity
        /// 
        /// Replaced by: SystemSIPDeviceTypeAddRequest19
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest18(this OcipClient client, SystemSIPDeviceTypeAddRequest18 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in XS data mode:
        /// enable3G4GContinuity, use value "false" in AS data mode
        /// The following elements are only used in AS data mode:
        /// holdAnnouncementMethod, use value "useInactive" in XS data mode
        /// The following element values are only applicable in AS data mode:
        /// holdNormalization=useRfc3264Hold will raise an error in XS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest18sp1(this OcipClient client, SystemSIPDeviceTypeAddRequest18sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in XS data mode:
        /// enable3G4GContinuity, use value "false" in AS data mode
        /// The following elements are only used in AS data mode:
        /// holdAnnouncementMethod, use value "useInactive" in XS data mode
        /// supportRFC3398, use value "false" in XS data mode
        /// The following element values are only applicable in AS data mode:
        /// holdNormalization=useRfc3264Hold will raise an error in XS data mode
        /// Replaced by: SystemSIPDeviceTypeAddRequest19.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest18sp1V2(this OcipClient client, SystemSIPDeviceTypeAddRequest18sp1V2 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileAddRequest18(this OcipClient client, SystemSIPDeviceTypeFileAddRequest18 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get a sip device type file.
        /// The response is either SystemSIPDeviceTypeFileGetResponse18 or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeFileGetResponse18> SystemSIPDeviceTypeFileGetRequest18(this OcipClient client, SystemSIPDeviceTypeFileGetRequest18 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeFileGetResponse18;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse18 or ErrorResponse.
        /// 
        /// Replaced by: SystemSIPDeviceTypeGetRequest19
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse18> SystemSIPDeviceTypeGetRequest18(this OcipClient client, SystemSIPDeviceTypeGetRequest18 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse18;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse18sp1 or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse18sp1> SystemSIPDeviceTypeGetRequest18sp1(this OcipClient client, SystemSIPDeviceTypeGetRequest18sp1 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse18sp1;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse19 or ErrorResponse.
        /// 
        /// Replaced by: SystemSIPDeviceTypeGetRequest19.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse19> SystemSIPDeviceTypeGetRequest18sp1V2(this OcipClient client, SystemSIPDeviceTypeGetRequest18sp1V2 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse19;
        }

        /// <summary>
        /// Request to modify a sip device type.
        /// The following elements are not changeable:
        /// numberOfPorts
        /// SignalingAddressType
        /// isConferenceDevice
        /// isMusicOnHoldDevice
        /// isMobilityManagerDevice
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in XS data mode:
        /// enable3G4GContinuity
        /// 
        /// Replaced by: SystemSIPDeviceTypeModifyRequest19
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeModifyRequest17(this OcipClient client, SystemSIPDeviceTypeModifyRequest17 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the system call processing configuration for all subscribers
        /// The response is either a SystemSubscriberGetCallProcessingParametersResponse17sp4
        /// or an ErrorResponse.
        /// 
        /// Replaced by SystemSubscriberGetCallProcessingParametersRequest18sp1.
        /// </summary>
        public static async Task<SystemSubscriberGetCallProcessingParametersResponse17sp4> SystemSubscriberGetCallProcessingParametersRequest17sp4(this OcipClient client, SystemSubscriberGetCallProcessingParametersRequest17sp4 request)
        {
            return await client.Call(request) as SystemSubscriberGetCallProcessingParametersResponse17sp4;
        }

        /// <summary>
        /// Get the system Third-Party IMP service attributes.
        /// The response is either SystemThirdPartyIMPGetResponse or ErrorResponse.
        /// 
        /// Replaced by SystemThirdPartyIMPGetRequest19.
        /// </summary>
        public static async Task<SystemThirdPartyIMPGetResponse> SystemThirdPartyIMPGetRequest(this OcipClient client, SystemThirdPartyIMPGetRequest request)
        {
            return await client.Call(request) as SystemThirdPartyIMPGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Third-party Voice Mail Support.
        /// The response is either a SystemThirdPartyVoiceMailSupportGetResponse or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemThirdPartyVoiceMailSupportGetRequest17sp4
        /// </summary>
        public static async Task<SystemThirdPartyVoiceMailSupportGetResponse> SystemThirdPartyVoiceMailSupportGetRequest(this OcipClient client, SystemThirdPartyVoiceMailSupportGetRequest request)
        {
            return await client.Call(request) as SystemThirdPartyVoiceMailSupportGetResponse;
        }

        /// <summary>
        /// Requests the system voice portal Menus setting.
        /// The response is either SystemVoiceMessagingGroupGetVoicePortalMenusResponse18 or ErrorResponse.
        /// 
        /// Replaced by SystemVoiceMessagingGroupGetVoicePortalMenusRequest19
        /// </summary>
        public static async Task<SystemVoiceMessagingGroupGetVoicePortalMenusResponse18> SystemVoiceMessagingGroupGetVoicePortalMenusRequest18(this OcipClient client, SystemVoiceMessagingGroupGetVoicePortalMenusRequest18 request)
        {
            return await client.Call(request) as SystemVoiceMessagingGroupGetVoicePortalMenusResponse18;
        }

        /// <summary>
        /// Requests the system voice portal Menus setting.
        /// The response is either SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1 or ErrorResponse.
        /// 
        /// Replaced by SystemVoiceMessagingGroupGetVoicePortalMenusRequest19sp1
        /// </summary>
        public static async Task<SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1> SystemVoiceMessagingGroupGetVoicePortalMenusRequest18sp1(this OcipClient client, SystemVoiceMessagingGroupGetVoicePortalMenusRequest18sp1 request)
        {
            return await client.Call(request) as SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1;
        }

        /// <summary>
        /// Requests the system voice portal Menus setting.
        /// The response is either SystemVoiceMessagingGroupGetVoicePortalMenusResponse19 or ErrorResponse.
        /// 
        /// Replaced by: SystemVoiceMessagingGroupGetVoicePortalMenusRequest19sp1
        /// </summary>
        public static async Task<SystemVoiceMessagingGroupGetVoicePortalMenusResponse19> SystemVoiceMessagingGroupGetVoicePortalMenusRequest19(this OcipClient client, SystemVoiceMessagingGroupGetVoicePortalMenusRequest19 request)
        {
            return await client.Call(request) as SystemVoiceMessagingGroupGetVoicePortalMenusResponse19;
        }

        /// <summary>
        /// Request to modify the system voice portal menus setting.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemVoiceMessagingGroupModifyVoicePortalMenusRequest(this OcipClient client, SystemVoiceMessagingGroupModifyVoicePortalMenusRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the user's call center settings and the list of call centers the specified user belongs to.
        /// The response is either a UserCallCenterGetResponse17 or an ErrorResponse.
        /// 
        /// Replaced by UserCallCenterGetRequest17sp4.
        /// </summary>
        public static async Task<UserCallCenterGetResponse17> UserCallCenterGetRequest17(this OcipClient client, UserCallCenterGetRequest17 request)
        {
            return await client.Call(request) as UserCallCenterGetResponse17;
        }

        /// <summary>
        /// Get the user's call center settings and the list of call centers the specified user belongs to.
        /// The response is either a UserCallCenterGetResponse17sp4 or an ErrorResponse.
        /// 
        /// Replaced by UserCallCenterGetRequest19
        /// </summary>
        public static async Task<UserCallCenterGetResponse17sp4> UserCallCenterGetRequest17sp4(this OcipClient client, UserCallCenterGetRequest17sp4 request)
        {
            return await client.Call(request) as UserCallCenterGetResponse17sp4;
        }

        /// <summary>
        /// Modifies the agents call center settings and the availability for an agent in one or more Call Centers.
        /// Contains a list specifying the desired availability status of one or more call centers.
        /// A default unavailable code will be used if the parameter agentUnavailableCode is not active, included or
        /// is invalid.
        /// Changing the agentACDState from unavailable to any other state will automatically clear the unavailable
        /// code.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by UserCallCenterModifyRequest17sp4.
        /// </summary>
        public static async Task<SuccessResponse> UserCallCenterModifyRequest(this OcipClient client, UserCallCenterModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modifies the agents call center settings and the availability for an agent in one or more Call Centers.
        /// Contains a list specifying the desired availability status of one or more call centers.
        /// A default unavailable code will be used if the parameter agentUnavailableCode is not active, included or
        /// is invalid.
        /// Changing the agentACDState from unavailable to any other state will automatically clear the unavailable
        /// code.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by UserCallCenterModifyRequest19.
        /// </summary>
        public static async Task<SuccessResponse> UserCallCenterModifyRequest17sp4(this OcipClient client, UserCallCenterModifyRequest17sp4 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the user information.
        /// The response is either UserGetResponse18 or ErrorResponse.
        /// 
        /// Replaced by: UserGetRequest19.
        /// </summary>
        public static async Task<UserGetResponse18> UserGetRequest18(this OcipClient client, UserGetRequest18 request)
        {
            return await client.Call(request) as UserGetResponse18;
        }

        /// <summary>
        /// Add a Meet-Me conference.
        /// The response is either UserMeetMeConferencingAddConferenceResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserMeetMeConferencingAddConferenceResponse> UserMeetMeConferencingAddConferenceRequest(this OcipClient client, UserMeetMeConferencingAddConferenceRequest request)
        {
            return await client.Call(request) as UserMeetMeConferencingAddConferenceResponse;
        }

        /// <summary>
        /// Get the information of a conference owned by the user.
        /// The response is either UserMeetMeConferencingGetConferenceResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserMeetMeConferencingGetConferenceResponse> UserMeetMeConferencingGetConferenceRequest(this OcipClient client, UserMeetMeConferencingGetConferenceRequest request)
        {
            return await client.Call(request) as UserMeetMeConferencingGetConferenceResponse;
        }

        /// <summary>
        /// Get the user's Video Add-On service setting.
        /// The response is either a UserVideoAddOnGetResponse14 or an ErrorResponse.
        /// 
        /// Replaced by: UserVideoAddOnGetRequest19.
        /// </summary>
        public static async Task<UserVideoAddOnGetResponse14> UserVideoAddOnGetRequest14(this OcipClient client, UserVideoAddOnGetRequest14 request)
        {
            return await client.Call(request) as UserVideoAddOnGetResponse14;
        }

        /// <summary>
        /// Request to add a session admission control group for the enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseSessionAdmissionControlGroupAddRequest(this OcipClient client, EnterpriseSessionAdmissionControlGroupAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get a session admission control group for the enterprise.
        /// The response is either an EnterpriseSessionAdmissionControlGroupGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<EnterpriseSessionAdmissionControlGroupGetResponse> EnterpriseSessionAdmissionControlGroupGetRequest(this OcipClient client, EnterpriseSessionAdmissionControlGroupGetRequest request)
        {
            return await client.Call(request) as EnterpriseSessionAdmissionControlGroupGetResponse;
        }

        /// <summary>
        /// Get the groups BroadWorks Mobility settings.
        /// The response is either a GroupBroadWorksMobilityGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupBroadWorksMobilityGetResponse> GroupBroadWorksMobilityGetRequest(this OcipClient client, GroupBroadWorksMobilityGetRequest request)
        {
            return await client.Call(request) as GroupBroadWorksMobilityGetResponse;
        }

        /// <summary>
        /// Add a Call Center instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by GroupCallCenterAddInstanceRequest22
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterAddInstanceRequest19(this OcipClient client, GroupCallCenterAddInstanceRequest19 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a call center's comfort message bypass settings.
        /// The response is either a GroupCallCenterComfortMessageBypassGetResponse17 or an ErrorResponse.
        /// 
        /// Replaced by: GroupCallCenterComfortMessageBypassGetRequest20
        /// </summary>
        public static async Task<GroupCallCenterComfortMessageBypassGetResponse17> GroupCallCenterComfortMessageBypassGetRequest17(this OcipClient client, GroupCallCenterComfortMessageBypassGetRequest17 request)
        {
            return await client.Call(request) as GroupCallCenterComfortMessageBypassGetResponse17;
        }

        /// <summary>
        /// Modify a call center's comfort message bypass
        /// settings.
        /// The response is either a SuccessResponse
        /// or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterComfortMessageBypassModifyRequest17(this OcipClient client, GroupCallCenterComfortMessageBypassModifyRequest17 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a call center's forced forwarding settings.
        /// The response is either a GroupCallCenterForcedForwardingGetResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterForcedForwardingGetResponse17> GroupCallCenterForcedForwardingGetRequest17(this OcipClient client, GroupCallCenterForcedForwardingGetRequest17 request)
        {
            return await client.Call(request) as GroupCallCenterForcedForwardingGetResponse17;
        }

        /// <summary>
        /// Get a call center's DNIS Announcements
        /// The response is either a GroupCallCenterGetDNISAnnouncementResponse19 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetDNISAnnouncementResponse19> GroupCallCenterGetDNISAnnouncementRequest19(this OcipClient client, GroupCallCenterGetDNISAnnouncementRequest19 request)
        {
            return await client.Call(request) as GroupCallCenterGetDNISAnnouncementResponse19;
        }

        /// <summary>
        /// Request to get all the information of a Call Center instance.
        /// The response is either GroupCallCenterGetInstanceResponse19 or ErrorResponse.
        /// 
        /// Replaced by: GroupCallCenterGetInstanceRequest19sp1
        /// </summary>
        public static async Task<GroupCallCenterGetInstanceResponse19> GroupCallCenterGetInstanceRequest19(this OcipClient client, GroupCallCenterGetInstanceRequest19 request)
        {
            return await client.Call(request) as GroupCallCenterGetInstanceResponse19;
        }

        /// <summary>
        /// Request to get all the information of a Call Center instance.
        /// The response is either GroupCallCenterGetInstanceResponse19sp1 or ErrorResponse.
        /// Replaced by GroupCallCenterGetInstanceRequest22.
        /// </summary>
        public static async Task<GroupCallCenterGetInstanceResponse19sp1> GroupCallCenterGetInstanceRequest19sp1(this OcipClient client, GroupCallCenterGetInstanceRequest19sp1 request)
        {
            return await client.Call(request) as GroupCallCenterGetInstanceResponse19sp1;
        }

        /// <summary>
        /// Get a call center's holiday service settings.
        /// The response is either a GroupCallCenterHolidayServiceGetResponse17sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterHolidayServiceGetResponse17sp1> GroupCallCenterHolidayServiceGetRequest17sp1(this OcipClient client, GroupCallCenterHolidayServiceGetRequest17sp1 request)
        {
            return await client.Call(request) as GroupCallCenterHolidayServiceGetResponse17sp1;
        }

        /// <summary>
        /// Modify a call center's holiday service settings.
        /// Only Group and Enterprise level schedules are
        /// accepted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterHolidayServiceModifyRequest17sp1(this OcipClient client, GroupCallCenterHolidayServiceModifyRequest17sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call center DNIS announcement settings.
        /// The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyDNISAnnouncementRequest(this OcipClient client, GroupCallCenterModifyDNISAnnouncementRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Call Center instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyInstanceRequest19(this OcipClient client, GroupCallCenterModifyInstanceRequest19 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a call center's stranded call settings.
        /// The response is either a GroupCallCenterStrandedCallGetResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterStrandedCallGetResponse17> GroupCallCenterStrandedCallGetRequest17(this OcipClient client, GroupCallCenterStrandedCallGetRequest17 request)
        {
            return await client.Call(request) as GroupCallCenterStrandedCallGetResponse17;
        }

        /// <summary>
        /// Modify a call center's stranded call settings.
        /// The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterStrandedCallModifyRequest17(this OcipClient client, GroupCallCenterStrandedCallModifyRequest17 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a call center's stranded calls - unavailable settings.
        /// The response is either a GroupCallCenterStrandedCallUnavailableGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterStrandedCallUnavailableGetResponse> GroupCallCenterStrandedCallUnavailableGetRequest(this OcipClient client, GroupCallCenterStrandedCallUnavailableGetRequest request)
        {
            return await client.Call(request) as GroupCallCenterStrandedCallUnavailableGetResponse;
        }

        /// <summary>
        /// Modify a call center's stranded calls -
        /// unavailable settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterStrandedCallUnavailableModifyRequest(this OcipClient client, GroupCallCenterStrandedCallUnavailableModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the properties of the DNH service for a specified serviceUserId.
        /// It gets the agents of a call center or hunt group that are members
        /// of a directory number hunting group. They are agents that are not already
        /// assigned to any other directory number hunting group.
        /// The response is either GroupDirectoryNumberHuntingGetResponse or ErrorResponse.
        /// 
        /// Replaced by: GroupDirectoryNumberHuntingGetRequest17sp1
        /// </summary>
        public static async Task<GroupDirectoryNumberHuntingGetResponse> GroupDirectoryNumberHuntingGetRequest(this OcipClient client, GroupDirectoryNumberHuntingGetRequest request)
        {
            return await client.Call(request) as GroupDirectoryNumberHuntingGetResponse;
        }

        /// <summary>
        /// Request to get all the information of a Find-me/Follow-me instance.
        /// The response is either GroupFindMeFollowMeGetInstanceResponse or ErrorResponse.
        /// Replaced by: GroupFindMeFollowMeGetInstanceRequest19sp1
        /// </summary>
        public static async Task<GroupFindMeFollowMeGetInstanceResponse> GroupFindMeFollowMeGetInstanceRequest(this OcipClient client, GroupFindMeFollowMeGetInstanceRequest request)
        {
            return await client.Call(request) as GroupFindMeFollowMeGetInstanceResponse;
        }

        /// <summary>
        /// Request to get all the information of a Group Paging instance.
        /// The response is either GroupGroupPagingGetInstanceResponse17sp3 or ErrorResponse.
        /// 
        /// Replaced by: GroupGroupPagingGetInstanceRequest19sp1
        /// </summary>
        public static async Task<GroupGroupPagingGetInstanceResponse17sp3> GroupGroupPagingGetInstanceRequest17sp3(this OcipClient client, GroupGroupPagingGetInstanceRequest17sp3 request)
        {
            return await client.Call(request) as GroupGroupPagingGetInstanceResponse17sp3;
        }

        /// <summary>
        /// Request to get all the information of a Hunt Group instance.
        /// The response is either GroupHuntGroupGetInstanceResponse19sp1 or ErrorResponse.
        /// 
        /// Replaced by: GroupHuntGroupGetInstanceRequest20
        /// </summary>
        public static async Task<GroupHuntGroupGetInstanceResponse19sp1> GroupHuntGroupGetInstanceRequest19sp1(this OcipClient client, GroupHuntGroupGetInstanceRequest19sp1 request)
        {
            return await client.Call(request) as GroupHuntGroupGetInstanceResponse19sp1;
        }

        /// <summary>
        /// Request to get all the information of an Instant Group Call service instance.
        /// The response is either GroupInstantGroupCallGetInstanceResponse17 or ErrorResponse.
        /// 
        /// Replaced by: GroupInstantGroupCallGetInstanceRequest19sp1
        /// </summary>
        public static async Task<GroupInstantGroupCallGetInstanceResponse17> GroupInstantGroupCallGetInstanceRequest17(this OcipClient client, GroupInstantGroupCallGetInstanceRequest17 request)
        {
            return await client.Call(request) as GroupInstantGroupCallGetInstanceResponse17;
        }

        /// <summary>
        /// Request to get all the information of a Meet-Me Conferencing bridge.
        /// The response is either GroupMeetMeConferencingGetInstanceResponse19 or ErrorResponse.
        /// 
        /// Replaced by: GroupMeetMeConferencingGetInstanceRequest19sp1
        /// </summary>
        public static async Task<GroupMeetMeConferencingGetInstanceResponse19> GroupMeetMeConferencingGetInstanceRequest19(this OcipClient client, GroupMeetMeConferencingGetInstanceRequest19 request)
        {
            return await client.Call(request) as GroupMeetMeConferencingGetInstanceResponse19;
        }

        /// <summary>
        /// Add a Music on Hold Instance to a department.
        /// The response is either SuccessResponse or
        /// ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupMusicOnHoldAddInstanceRequest16(this OcipClient client, GroupMusicOnHoldAddInstanceRequest16 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify data for a group or department Music On
        /// Hold Instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupMusicOnHoldModifyInstanceRequest16(this OcipClient client, GroupMusicOnHoldModifyInstanceRequest16 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a route point's forced forwarding settings.
        /// The response is either a GroupRoutePointForcedForwardingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointForcedForwardingGetResponse> GroupRoutePointForcedForwardingGetRequest(this OcipClient client, GroupRoutePointForcedForwardingGetRequest request)
        {
            return await client.Call(request) as GroupRoutePointForcedForwardingGetResponse;
        }

        /// <summary>
        /// Modify a route point's forced forwarding
        /// settings.
        /// The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointForcedForwardingModifyRequest(this OcipClient client, GroupRoutePointForcedForwardingModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a route point's announcement settings.
        /// The response is either a GroupRoutePointGetAnnouncementResponse19 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetAnnouncementResponse19> GroupRoutePointGetAnnouncementRequest19(this OcipClient client, GroupRoutePointGetAnnouncementRequest19 request)
        {
            return await client.Call(request) as GroupRoutePointGetAnnouncementResponse19;
        }

        /// <summary>
        /// Get a route point's DNIS Announcements
        /// The response is either a GroupRoutePointGetDNISAnnouncementResponse19 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointGetDNISAnnouncementResponse19> GroupRoutePointGetDNISAnnouncementRequest19(this OcipClient client, GroupRoutePointGetDNISAnnouncementRequest19 request)
        {
            return await client.Call(request) as GroupRoutePointGetDNISAnnouncementResponse19;
        }

        /// <summary>
        /// Request to get all the information of a Route Point instance.
        /// The response is either GroupRoutePointGetInstanceResponse or ErrorResponse.
        /// 
        /// Replaced by: GroupRoutePointGetInstanceRequest19sp1
        /// </summary>
        public static async Task<GroupRoutePointGetInstanceResponse> GroupRoutePointGetInstanceRequest(this OcipClient client, GroupRoutePointGetInstanceRequest request)
        {
            return await client.Call(request) as GroupRoutePointGetInstanceResponse;
        }

        /// <summary>
        /// Get a route point's holiday service settings.
        /// The response is either a GroupRoutePointHolidayServiceGetResponse17sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointHolidayServiceGetResponse17sp1> GroupRoutePointHolidayServiceGetRequest17sp1(this OcipClient client, GroupRoutePointHolidayServiceGetRequest17sp1 request)
        {
            return await client.Call(request) as GroupRoutePointHolidayServiceGetResponse17sp1;
        }

        /// <summary>
        /// Modify a route point's holiday service settings.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointHolidayServiceModifyRequest17sp1(this OcipClient client, GroupRoutePointHolidayServiceModifyRequest17sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify a route point's announcement settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyAnnouncementRequest(this OcipClient client, GroupRoutePointModifyAnnouncementRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify a route point DNIS announcement settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyDNISAnnouncementRequest(this OcipClient client, GroupRoutePointModifyDNISAnnouncementRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a route point's night service settings.
        /// The response is either a GroupRoutePointNightServiceGetResponse17sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointNightServiceGetResponse17sp1> GroupRoutePointNightServiceGetRequest17sp1(this OcipClient client, GroupRoutePointNightServiceGetRequest17sp1 request)
        {
            return await client.Call(request) as GroupRoutePointNightServiceGetResponse17sp1;
        }

        /// <summary>
        /// Modify a route point's night service settings.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointNightServiceModifyRequest17sp1(this OcipClient client, GroupRoutePointNightServiceModifyRequest17sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a route point's overflow settings.
        /// The response is either a GroupRoutePointOverflowGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupRoutePointOverflowGetResponse> GroupRoutePointOverflowGetRequest(this OcipClient client, GroupRoutePointOverflowGetRequest request)
        {
            return await client.Call(request) as GroupRoutePointOverflowGetResponse;
        }

        /// <summary>
        /// Modify a route point's overflow settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointOverflowModifyRequest(this OcipClient client, GroupRoutePointOverflowModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a session admission control group for the group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupSessionAdmissionControlGroupAddRequest(this OcipClient client, GroupSessionAdmissionControlGroupAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get a session admission control group for the group.
        /// The response is either a GroupSessionAdmissionControlGroupGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupSessionAdmissionControlGroupGetResponse> GroupSessionAdmissionControlGroupGetRequest(this OcipClient client, GroupSessionAdmissionControlGroupGetRequest request)
        {
            return await client.Call(request) as GroupSessionAdmissionControlGroupGetResponse;
        }

        /// <summary>
        /// Add a Trunk Group instance to a group.
        /// The command will fail if enableNetworkAddressIdentity is set to
        /// true and administrator is not System/Provisioning level administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by GroupTrunkGroupAddInstanceRequest19sp1.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupAddInstanceRequest19(this OcipClient client, GroupTrunkGroupAddInstanceRequest19 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse19 or an ErrorResponse.
        /// The response contains a hosted user table with column headings: "User Id", "Last Name",
        /// "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number", "Extension",
        /// "Department", "Email Address".
        /// 
        /// Replaced by GroupTrunkGroupGetInstanceRequest19sp1.
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceResponse19> GroupTrunkGroupGetInstanceRequest19(this OcipClient client, GroupTrunkGroupGetInstanceRequest19 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceResponse19;
        }

        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse19sp1 or an ErrorResponse.
        /// The response contains a hosted user table with column headings: "User Id", "Last Name",
        /// "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number", "Extension",
        /// "Department", "Email Address".
        /// 
        /// Replaced by GroupTrunkGroupGetInstanceRequest19sp1V2.
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceResponse19sp1> GroupTrunkGroupGetInstanceRequest19sp1(this OcipClient client, GroupTrunkGroupGetInstanceRequest19sp1 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceResponse19sp1;
        }

        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse19V2 or an ErrorResponse.
        /// The response contains a hosted user table with column headings: "User Id", "Last Name",
        /// "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number", "Extension",
        /// "Department", "Email Address".
        /// 
        /// Replaced by GroupTrunkGroupGetInstanceRequest19sp1V2.
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceResponse19V2> GroupTrunkGroupGetInstanceRequest19V2(this OcipClient client, GroupTrunkGroupGetInstanceRequest19V2 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceResponse19V2;
        }

        /// <summary>
        /// Modify a Trunk Group Instance in a group.
        /// The access device cannot be modified or cleared if there are any users assigned to the Trunk Group.
        /// The command will fail if enableNetworkAddressIdentity is set and
        /// administrator is not System/Provisioning level administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by GroupTrunkGroupModifyInstanceRequest19sp1.
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupModifyInstanceRequest15(this OcipClient client, GroupTrunkGroupModifyInstanceRequest15 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the service provider BroadWorks Mobility service settings.
        /// The response is either a ServiceProviderBroadWorksMobilityGetResponse or an ErrorResponse.
        /// Replaced by: ServiceProviderBroadWorksMobilityGetRequest19sp1
        /// </summary>
        public static async Task<ServiceProviderBroadWorksMobilityGetResponse> ServiceProviderBroadWorksMobilityGetRequest(this OcipClient client, ServiceProviderBroadWorksMobilityGetRequest request)
        {
            return await client.Call(request) as ServiceProviderBroadWorksMobilityGetResponse;
        }

        /// <summary>
        /// Get the broadworks mobility system parameters.
        /// The response is either a SystemBroadWorksMobilityGetResponse17sp4 or an ErrorResponse.
        /// Replaced by: SystemBroadWorksMobilityGetRequest19sp1
        /// </summary>
        public static async Task<SystemBroadWorksMobilityGetResponse17sp4> SystemBroadWorksMobilityGetRequest17sp4(this OcipClient client, SystemBroadWorksMobilityGetRequest17sp4 request)
        {
            return await client.Call(request) as SystemBroadWorksMobilityGetResponse17sp4;
        }

        /// <summary>
        /// Request the system's calling name retrieval attributes.
        /// The response is either a SystemCallingNameRetrievalGetResponse17sp4 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallingNameRetrievalGetResponse17sp4> SystemCallingNameRetrievalGetRequest17sp4(this OcipClient client, SystemCallingNameRetrievalGetRequest17sp4 request)
        {
            return await client.Call(request) as SystemCallingNameRetrievalGetResponse17sp4;
        }

        /// <summary>
        /// Modifies the system's calling name retrieval attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemCallingNameRetrievalModifyRequest20
        /// </summary>
        public static async Task<SuccessResponse> SystemCallingNameRetrievalModifyRequest16sp1(this OcipClient client, SystemCallingNameRetrievalModifyRequest16sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a call processing policy profile to system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by SystemCallProcessingPolicyProfileAddRequest20.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileAddRequest(this OcipClient client, SystemCallProcessingPolicyProfileAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get a call processing policy profile in system.
        /// The response is either a SystemCallProcessingPolicyProfileGetResponse or an ErrorResponse.
        /// 
        /// Replaced by SystemCallProcessingPolicyProfileGetRequest20.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileGetResponse> SystemCallProcessingPolicyProfileGetRequest(this OcipClient client, SystemCallProcessingPolicyProfileGetRequest request)
        {
            return await client.Call(request) as SystemCallProcessingPolicyProfileGetResponse;
        }

        /// <summary>
        /// Modify a call processing policy profile in system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by SystemCallProcessingPolicyProfileModifyRequest20.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileModifyRequest(this OcipClient client, SystemCallProcessingPolicyProfileModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Recording platform.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemCallRecordingAddPlatformRequest20
        /// </summary>
        public static async Task<SuccessResponse> SystemCallRecordingAddPlatformRequest19(this OcipClient client, SystemCallRecordingAddPlatformRequest19 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in XS data mode:
        /// enable3G4GContinuity, use value "false" in AS data mode
        /// The following elements are only used in AS data mode:
        /// holdAnnouncementMethod, use value "useInactive" in XS data mode
        /// supportRFC3398, use value "false" in XS data mode
        /// The following element values are only applicable in AS data mode:
        /// holdNormalization=useRfc3264Hold will raise an error in XS data mode
        /// Replaced by: SystemSIPDeviceTypeAddRequest19sp1
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest19(this OcipClient client, SystemSIPDeviceTypeAddRequest19 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in XS data mode:
        /// enable3G4GContinuity, use value "false" in AS data mode
        /// The following elements are only used in AS data mode:
        /// holdAnnouncementMethod, use value "useInactive" in XS data mode
        /// supportRFC3398, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// 
        /// The following element values are only applicable in AS data mode:
        /// holdNormalization=useRfc3264Hold will raise an error in XS data mode
        /// Replaced by: SystemSIPDeviceTypeAddRequest20
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest19sp1(this OcipClient client, SystemSIPDeviceTypeAddRequest19sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemSIPDeviceTypeFileAddRequest20
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileAddRequest19(this OcipClient client, SystemSIPDeviceTypeFileAddRequest19 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get a sip device type file.
        /// The response is either SystemSIPDeviceTypeFileGetResponse19 or ErrorResponse.
        /// 
        /// Replaced by: SystemSIPDeviceTypeFileGetRequest20
        /// </summary>
        public static async Task<SystemSIPDeviceTypeFileGetResponse19> SystemSIPDeviceTypeFileGetRequest19(this OcipClient client, SystemSIPDeviceTypeFileGetRequest19 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeFileGetResponse19;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse19 or ErrorResponse.
        /// Replaced by: SystemSIPDeviceTypeGetRequest19sp1
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse19> SystemSIPDeviceTypeGetRequest19(this OcipClient client, SystemSIPDeviceTypeGetRequest19 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse19;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse19sp1 or ErrorResponse.
        /// 
        /// Replaced by: SystemSIPDeviceTypeGetRequest20
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse19sp1> SystemSIPDeviceTypeGetRequest19sp1(this OcipClient client, SystemSIPDeviceTypeGetRequest19sp1 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse19sp1;
        }

        /// <summary>
        /// Request the system level data associated with the Trunk Group service.
        /// The response is either SystemTrunkGroupGetResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemTrunkGroupGetRequest19sp1.
        /// </summary>
        public static async Task<SystemTrunkGroupGetResponse> SystemTrunkGroupGetRequest(this OcipClient client, SystemTrunkGroupGetRequest request)
        {
            return await client.Call(request) as SystemTrunkGroupGetResponse;
        }

        /// <summary>
        /// Requests the system voice portal Menus setting.
        /// The response is either SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1 or ErrorResponse.
        /// 
        /// Replaced by SystemVoiceMessagingGroupGetVoicePortalMenusRequest20
        /// </summary>
        public static async Task<SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1> SystemVoiceMessagingGroupGetVoicePortalMenusRequest19sp1(this OcipClient client, SystemVoiceMessagingGroupGetVoicePortalMenusRequest19sp1 request)
        {
            return await client.Call(request) as SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1;
        }

        /// <summary>
        /// Get the Call Recording attributes for a user.
        /// The response is either a UserCallRecordingGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserCallRecordingGetResponse> UserCallRecordingGetRequest(this OcipClient client, UserCallRecordingGetRequest request)
        {
            return await client.Call(request) as UserCallRecordingGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Device Policy.
        /// The response is either a UserDevicePoliciesGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserDevicePoliciesGetResponse> UserDevicePoliciesGetRequest(this OcipClient client, UserDevicePoliciesGetRequest request)
        {
            return await client.Call(request) as UserDevicePoliciesGetResponse;
        }

        /// <summary>
        /// Request the user level data associated with Device Policy.
        /// The response is either a UserDevicePoliciesGetResponse19sp1 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserDevicePoliciesGetResponse19sp1> UserDevicePoliciesGetRequest19sp1(this OcipClient client, UserDevicePoliciesGetRequest19sp1 request)
        {
            return await client.Call(request) as UserDevicePoliciesGetResponse19sp1;
        }

        /// <summary>
        /// Request user's call logs.
        /// If the callLogType is not specified, all types of calls logs (placed, received, missed) are returned.
        /// The filters "dateTimeRange", "numberFilter", "redirectedNumberFilter", "accountAuthorizationCodeFilter"
        /// "callAuthorizationCodeFilter" and "subscriberType" are ignored if call logs are stored in CDS. When
        /// "ReceivedOrMissed" is specified as "callLogType" and call logs are stored in CDS, all call logs
        /// including
        /// placed will be returned.
        /// It is possible to restrict the number of rows returned using responsePagingControl. If
        /// responsePagingControl
        /// is not specified, the value of Enhanced Call Logs system parameter maxNonPagedResponseSize will control
        /// the maximum number of call logs can be returned.
        /// The response is either a UserEnhancedCallLogsGetListResponse17sp4V2 or an ErrorResponse.
        /// The following elements are only used in AS data mode and not returned in XS data mode:
        /// callAuthorizationCodeFilter
        /// </summary>
        public static async Task<UserEnhancedCallLogsGetListResponse17sp4V2> UserEnhancedCallLogsGetListRequest17sp4V2(this OcipClient client, UserEnhancedCallLogsGetListRequest17sp4V2 request)
        {
            return await client.Call(request) as UserEnhancedCallLogsGetListResponse17sp4V2;
        }

        /// <summary>
        /// Request to get the user information. The response is either UserGetResponse19 or ErrorResponse.
        /// </summary>
        public static async Task<UserGetResponse19> UserGetRequest19(this OcipClient client, UserGetRequest19 request)
        {
            return await client.Call(request) as UserGetResponse19;
        }

        /// <summary>
        /// Get the information of a conference custom greeting.
        /// The response is either UserMeetMeConferencingGetConferenceGreetingResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserMeetMeConferencingGetConferenceGreetingResponse> UserMeetMeConferencingGetConferenceGreetingRequest(this OcipClient client, UserMeetMeConferencingGetConferenceGreetingRequest request)
        {
            return await client.Call(request) as UserMeetMeConferencingGetConferenceGreetingResponse;
        }

        /// <summary>
        /// Get the information of a conference owned by the user.
        /// The response is either UserMeetMeConferencingGetConferenceResponse19 or ErrorResponse.
        /// </summary>
        public static async Task<UserMeetMeConferencingGetConferenceResponse19> UserMeetMeConferencingGetConferenceRequest19(this OcipClient client, UserMeetMeConferencingGetConferenceRequest19 request)
        {
            return await client.Call(request) as UserMeetMeConferencingGetConferenceResponse19;
        }

        /// <summary>
        /// Modify an existing custom greeting audio file.
        /// The response is either SuccessResponse or
        /// ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserMeetMeConferencingModifyConferenceGreetingRequest(this OcipClient client, UserMeetMeConferencingModifyConferenceGreetingRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the address and credentials of the File Repository hosting the requested access device file.
        /// Also get the file name and path on the File Repository.
        /// The response is either a DeviceManagementFileAuthLocationGetResponse18 or an ErrorResponse.
        /// Replaced by: DeviceManagementFileAuthLocationGetRequest21.
        /// </summary>
        public static async Task<DeviceManagementFileAuthLocationGetResponse18> DeviceManagementFileAuthLocationGetRequest18(this OcipClient client, DeviceManagementFileAuthLocationGetRequest18 request)
        {
            return await client.Call(request) as DeviceManagementFileAuthLocationGetResponse18;
        }

        /// <summary>
        /// Get the address and credentials of the File Repository hosting the requested access device file.
        /// Also get the file name and path on the File Repository.
        /// The response is either DeviceManagementFileAuthLocationGetResponse21 or ErrorResponse.
        /// The following elements are only used in AS data mode and will fail in XS data mode:
        /// deviceToken
        /// 
        /// Replaced by: DeviceManagementFileAuthLocationGetRequest21sp1.
        /// </summary>
        public static async Task<DeviceManagementFileAuthLocationGetResponse21> DeviceManagementFileAuthLocationGetRequest21(this OcipClient client, DeviceManagementFileAuthLocationGetRequest21 request)
        {
            return await client.Call(request) as DeviceManagementFileAuthLocationGetResponse21;
        }

        /// <summary>
        /// Request to add an enterprise trunk in an enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by: EnterpriseEnterpriseTrunkAddRequest21
        /// </summary>
        public static async Task<SuccessResponse> EnterpriseEnterpriseTrunkAddRequest(this OcipClient client, EnterpriseEnterpriseTrunkAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get an enterprise trunk
        /// The response is either an EnterpriseEnterpriseTrunkGetResponse or an ErrorResponse.
        /// Replaced by: EnterpriseEnterpriseTrunkGetRequest21
        /// </summary>
        public static async Task<EnterpriseEnterpriseTrunkGetResponse> EnterpriseEnterpriseTrunkGetRequest(this OcipClient client, EnterpriseEnterpriseTrunkGetRequest request)
        {
            return await client.Call(request) as EnterpriseEnterpriseTrunkGetResponse;
        }

        /// <summary>
        /// Request to add an enterprise trunk in a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by: GroupEnterpriseTrunkAddRequest21.
        /// </summary>
        public static async Task<SuccessResponse> GroupEnterpriseTrunkAddRequest(this OcipClient client, GroupEnterpriseTrunkAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get an enterprise trunk
        /// The response is either an GroupEnterpriseTrunkGetResponse or an ErrorResponse.
        /// Replaced by: GroupEnterpriseTrunkGetRequest21.
        /// </summary>
        public static async Task<GroupEnterpriseTrunkGetResponse> GroupEnterpriseTrunkGetRequest(this OcipClient client, GroupEnterpriseTrunkGetRequest request)
        {
            return await client.Call(request) as GroupEnterpriseTrunkGetResponse;
        }

        /// <summary>
        /// Get group FAC code level and the list of feature access codes for a group.
        /// The response is either a GroupFeatureAccessCodeGetResponse20 or an
        /// ErrorResponse.
        /// Returned Feature Access Codes may be group specific, or Service Provider
        /// Feature Access Codes, depending on FAC code level.
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// Replaced by: GroupFeatureAccessCodeGetRequest21
        /// </summary>
        public static async Task<GroupFeatureAccessCodeGetResponse20> GroupFeatureAccessCodeGetRequest20(this OcipClient client, GroupFeatureAccessCodeGetRequest20 request)
        {
            return await client.Call(request) as GroupFeatureAccessCodeGetResponse20;
        }

        /// <summary>
        /// Modify group FAC code level and the list of feature access codes for a
        /// group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Note: choice element is only valid when useFeatureAccessCodeLevel is set
        /// to "Group", otherwise an ErrorResponse will be returned.
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// Replaced by: GroupFeatureAccessCodeModifyRequest21
        /// </summary>
        public static async Task<SuccessResponse> GroupFeatureAccessCodeModifyRequest20(this OcipClient client, GroupFeatureAccessCodeModifyRequest20 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get all the information of a specific Find-me/Follow-me alerting group selective criteria.
        /// The response is either GroupFindMeFollowMeGetAlertingGroupResponse or ErrorResponse.
        /// Replaced by: GroupFindMeFollowMeGetAlertingGroupSelectiveCriteriaRequest21
        /// </summary>
        public static async Task<GroupFindMeFollowMeGetAlertingGroupResponse> GroupFindMeFollowMeGetAlertingGroupSelectiveCriteriaRequest(this OcipClient client, GroupFindMeFollowMeGetAlertingGroupSelectiveCriteriaRequest request)
        {
            return await client.Call(request) as GroupFindMeFollowMeGetAlertingGroupResponse;
        }

        /// <summary>
        /// Add a Trunk Group instance to a group.
        /// The command will fail if enableNetworkAddressIdentity is set to
        /// true and administrator is not System/Provisioning level administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by: GroupTrunkGroupAddInstanceRequest20sp1
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupAddInstanceRequest19sp1(this OcipClient client, GroupTrunkGroupAddInstanceRequest19sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a Trunk Group instance to a group.
        /// The command will fail if enableNetworkAddressIdentity is set to
        /// true and administrator is not System/Provisioning level administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupTrunkGroupAddInstanceRequest21
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupAddInstanceRequest20sp1(this OcipClient client, GroupTrunkGroupAddInstanceRequest20sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse19sp1V2 or an ErrorResponse.
        /// The response contains a hosted user table with column headings: "User Id", "Last Name",
        /// "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number", "Extension",
        /// "Department", "Email Address".
        /// Replaced by: GroupTrunkGroupGetInstanceRequest20sp1
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceResponse19sp1V2> GroupTrunkGroupGetInstanceRequest19sp1V2(this OcipClient client, GroupTrunkGroupGetInstanceRequest19sp1V2 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceResponse19sp1V2;
        }

        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse20sp1 or an ErrorResponse.
        /// The response contains a hosted user table with column headings: "User Id", "Last Name",
        /// "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number", "Extension",
        /// "Department", "Email Address".
        /// 
        /// Replaced by: GroupTrunkGroupGetInstanceRequest21
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceResponse20sp1> GroupTrunkGroupGetInstanceRequest20sp1(this OcipClient client, GroupTrunkGroupGetInstanceRequest20sp1 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceResponse20sp1;
        }

        /// <summary>
        /// Get a Trunk Group Instance's profile.
        /// The response is either a GroupTrunkGroupGetInstanceResponse21 or an ErrorResponse.
        /// The response contains a hosted user table with column headings: "User Id", "Last Name",
        /// "First Name", "Hiragana Last Name", "Hiragana First Name", "Phone Number", "Extension",
        /// "Department", "Email Address".
        /// Replaced by: GroupTrunkGroupGetInstanceResponse23
        /// </summary>
        public static async Task<GroupTrunkGroupGetInstanceResponse21> GroupTrunkGroupGetInstanceRequest21(this OcipClient client, GroupTrunkGroupGetInstanceRequest21 request)
        {
            return await client.Call(request) as GroupTrunkGroupGetInstanceResponse21;
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
        /// Replaced by: GroupTrunkGroupModifyInstanceRequest20sp1
        /// </summary>
        public static async Task<SuccessResponse> GroupTrunkGroupModifyInstanceRequest19sp1(this OcipClient client, GroupTrunkGroupModifyInstanceRequest19sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Adds Mobile Subscriber Directory Numbers to a service provider. It is possible to add a single DN,
        /// or a list of DNs.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberAddListRequest21.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberAddListRequest(this OcipClient client, ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberAddListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the list of feature access codes for a service provider or enterprise.
        /// The response is either a ServiceProviderFeatureAccessCodeGetListResponse20
        /// or an ErrorResponse.
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// Replaced by: ServiceProviderFeatureAccessCodeGetListRequest21
        /// </summary>
        public static async Task<ServiceProviderFeatureAccessCodeGetListResponse20> ServiceProviderFeatureAccessCodeGetListRequest20(this OcipClient client, ServiceProviderFeatureAccessCodeGetListRequest20 request)
        {
            return await client.Call(request) as ServiceProviderFeatureAccessCodeGetListResponse20;
        }

        /// <summary>
        /// Modify a list of feature access codes for a service provider or enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// Replaced by: ServiceProviderFeatureAccessCodeModifyListRequest21
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderFeatureAccessCodeModifyListRequest20(this OcipClient client, ServiceProviderFeatureAccessCodeModifyListRequest20 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the list of Advice of Charge system parameters.
        /// The response is either SystemAdviceOfChargeGetResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemAdviceOfChargeGetRequest19sp1
        /// </summary>
        public static async Task<SystemAdviceOfChargeGetResponse> SystemAdviceOfChargeGetRequest(this OcipClient client, SystemAdviceOfChargeGetRequest request)
        {
            return await client.Call(request) as SystemAdviceOfChargeGetResponse;
        }

        /// <summary>
        /// Request to modify Advice of Charge system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemAdviceOfChargeModifyRequest19sp1
        /// </summary>
        public static async Task<SuccessResponse> SystemAdviceOfChargeModifyRequest(this OcipClient client, SystemAdviceOfChargeModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the broadworks mobility system parameters.
        /// The response is either a SystemBroadWorksMobilityGetResponse19sp1 or an ErrorResponse.
        /// Replaced by SystemBroadWorksMobilityGetRequest21
        /// </summary>
        public static async Task<SystemBroadWorksMobilityGetResponse19sp1> SystemBroadWorksMobilityGetRequest19sp1(this OcipClient client, SystemBroadWorksMobilityGetRequest19sp1 request)
        {
            return await client.Call(request) as SystemBroadWorksMobilityGetResponse19sp1;
        }

        /// <summary>
        /// Modify the BroadWorks Mobility system parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by SystemBroadWorksMobilityModifyRequest21.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksMobilityModifyRequest17sp4(this OcipClient client, SystemBroadWorksMobilityModifyRequest17sp4 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a system service access code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by SystemBroadWorksMobilityServiceAccessCodeAddRequest21.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksMobilityServiceAccessCodeAddRequest(this OcipClient client, SystemBroadWorksMobilityServiceAccessCodeAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a system service access code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by SystemBroadWorksMobilityServiceAccessCodeDeleteRequest21.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksMobilityServiceAccessCodeDeleteRequest(this OcipClient client, SystemBroadWorksMobilityServiceAccessCodeDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a list of system service access codes.
        /// The response is either SystemBroadWorksMobilityServiceAccessCodeGetListResponse or ErrorResponse.
        /// Replaced by SystemBroadWorksMobilityServiceAccessCodeGetListRequest21.
        /// </summary>
        public static async Task<SystemBroadWorksMobilityServiceAccessCodeGetListResponse> SystemBroadWorksMobilityServiceAccessCodeGetListRequest(this OcipClient client, SystemBroadWorksMobilityServiceAccessCodeGetListRequest request)
        {
            return await client.Call(request) as SystemBroadWorksMobilityServiceAccessCodeGetListResponse;
        }

        /// <summary>
        /// Modify a system service access code.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by SystemBroadWorksMobilityServiceAccessCodeModifyRequest21.
        /// </summary>
        public static async Task<SuccessResponse> SystemBroadWorksMobilityServiceAccessCodeModifyRequest(this OcipClient client, SystemBroadWorksMobilityServiceAccessCodeModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the system level data associated with Call Center.
        /// The response is either a SystemCallCenterGetResponse19 or an
        /// ErrorResponse.
        /// Replaced by SystemCallCenterGetRequest21.
        /// </summary>
        public static async Task<SystemCallCenterGetResponse19> SystemCallCenterGetRequest19(this OcipClient client, SystemCallCenterGetRequest19 request)
        {
            return await client.Call(request) as SystemCallCenterGetResponse19;
        }

        /// <summary>
        /// Add a call processing policy profile to system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileAddRequest20(this OcipClient client, SystemCallProcessingPolicyProfileAddRequest20 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get a call processing policy profile in system.
        /// The response is either a SystemCallProcessingPolicyProfileGetResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileGetResponse20> SystemCallProcessingPolicyProfileGetRequest20(this OcipClient client, SystemCallProcessingPolicyProfileGetRequest20 request)
        {
            return await client.Call(request) as SystemCallProcessingPolicyProfileGetResponse20;
        }

        /// <summary>
        /// Modify a call processing policy profile in system.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemCallProcessingPolicyProfileModifyRequest20(this OcipClient client, SystemCallProcessingPolicyProfileModifyRequest20 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get list of Call Recording platforms.
        /// The response is either SystemCallRecordingGetPlatformListResponse or ErrorResponse.
        /// 
        /// The possible values for "Support Video Rec" can be either true or false.
        /// Schema version values include: 1.0, 2.0, 3.0
        /// 
        /// Replaced by: SystemCallRecordingGetPlatformListRequest20sp1 in AS data mode
        /// </summary>
        public static async Task<SystemCallRecordingGetPlatformListResponse> SystemCallRecordingGetPlatformListRequest(this OcipClient client, SystemCallRecordingGetPlatformListRequest request)
        {
            return await client.Call(request) as SystemCallRecordingGetPlatformListResponse;
        }

        /// <summary>
        /// Request to get the list of CPE Config system parameters.
        /// The response is either SystemCPEConfigParametersGetResponse14sp6 or ErrorResponse.
        /// 
        /// Replaced by: SystemCPEConfigParametersGetRequest20
        /// </summary>
        public static async Task<SystemCPEConfigParametersGetResponse14sp6> SystemCPEConfigParametersGetRequest14sp6(this OcipClient client, SystemCPEConfigParametersGetRequest14sp6 request)
        {
            return await client.Call(request) as SystemCPEConfigParametersGetResponse14sp6;
        }

        /// <summary>
        /// Request to get the list of CPE Config system parameters.
        /// The response is either SystemCPEConfigParametersGetResponse20 or ErrorResponse.
        /// 
        /// Replaced by: SystemCPEConfigParametersGetRequest21
        /// </summary>
        public static async Task<SystemCPEConfigParametersGetResponse20> SystemCPEConfigParametersGetRequest20(this OcipClient client, SystemCPEConfigParametersGetRequest20 request)
        {
            return await client.Call(request) as SystemCPEConfigParametersGetResponse20;
        }

        /// <summary>
        /// Request to modify CPE Config system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemCPEConfigParametersModifyRequest20.
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigParametersModifyRequest(this OcipClient client, SystemCPEConfigParametersModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify CPE Config system parameters.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemCPEConfigParametersModifyRequest21
        /// </summary>
        public static async Task<SuccessResponse> SystemCPEConfigParametersModifyRequest20(this OcipClient client, SystemCPEConfigParametersModifyRequest20 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get list of default Feature Access Codes defined on system
        /// level.
        /// The response is either SystemFeatureAccessCodeGetListResponse20 or
        /// ErrorResponse.
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// Replaced by: SystemFeatureAccessCodeGetListRequest21
        /// </summary>
        public static async Task<SystemFeatureAccessCodeGetListResponse20> SystemFeatureAccessCodeGetListRequest20(this OcipClient client, SystemFeatureAccessCodeGetListRequest20 request)
        {
            return await client.Call(request) as SystemFeatureAccessCodeGetListResponse20;
        }

        /// <summary>
        /// Modify default Feature Access Codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// Replaced by: SystemFeatureAccessCodeModifyListRequest21
        /// </summary>
        public static async Task<SuccessResponse> SystemFeatureAccessCodeModifyListRequest20(this OcipClient client, SystemFeatureAccessCodeModifyListRequest20 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a system Security Classifications parameters.
        /// The response is either SystemSecurityClassificationGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemSecurityClassificationGetResponse> SystemSecurityClassificationGetRequest(this OcipClient client, SystemSecurityClassificationGetRequest request)
        {
            return await client.Call(request) as SystemSecurityClassificationGetResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in XS data mode:
        /// enable3G4GContinuity, use value "false" in AS data mode
        /// The following elements are only used in AS data mode:
        /// holdAnnouncementMethod, use value "useInactive" in XS data mode
        /// supportRFC3398, use value "false" in XS data mode
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// The following element values are only applicable in AS data mode:
        /// holdNormalization=useRfc3264Hold will raise an error in XS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest20(this OcipClient client, SystemSIPDeviceTypeAddRequest20 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemSIPDeviceTypeFileAddRequest20Sp1
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileAddRequest20(this OcipClient client, SystemSIPDeviceTypeFileAddRequest20 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get a sip device type file.
        /// The response is either SystemSIPDeviceTypeFileGetResponse20 or ErrorResponse.
        /// 
        /// Replaced by: SystemSIPDeviceTypeFileGetRequest20Sp1
        /// </summary>
        public static async Task<SystemSIPDeviceTypeFileGetResponse20> SystemSIPDeviceTypeFileGetRequest20(this OcipClient client, SystemSIPDeviceTypeFileGetRequest20 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeFileGetResponse20;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse20 or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse20> SystemSIPDeviceTypeGetRequest20(this OcipClient client, SystemSIPDeviceTypeGetRequest20 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse20;
        }

        /// <summary>
        /// Request to modify a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are not changeable:
        /// numberOfPorts
        /// SignalingAddressType
        /// isConferenceDevice
        /// isMusicOnHoldDevice
        /// isMobilityManagerDevice
        /// deviceTypeConfigurationOption
        /// staticLineOrdering
        /// The following elements are only used in XS data mode:
        /// enable3G4GContinuity
        /// allowTerminationBasedOnICSI
        /// The following elements are only used in AS data mode:
        /// holdAnnouncementMethod
        /// supportRFC3398
        /// supportClientSessionInfo
        /// supportCallInfoConferenceSubscriptionURI
        /// supportRemotePartyInfo
        /// The following element values are only applicable in AS data mode:
        /// holdNormalization=useRfc3264Hold will raise an error in XS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeModifyRequest18sp1(this OcipClient client, SystemSIPDeviceTypeModifyRequest18sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the system level data associated with the Trunk Group service.
        /// The response is either SystemTrunkGroupGetResponse19sp1 or ErrorResponse.
        /// Replaced by: SystemTrunkGroupGetRequest21
        /// </summary>
        public static async Task<SystemTrunkGroupGetResponse19sp1> SystemTrunkGroupGetRequest19sp1(this OcipClient client, SystemTrunkGroupGetRequest19sp1 request)
        {
            return await client.Call(request) as SystemTrunkGroupGetResponse19sp1;
        }

        /// <summary>
        /// Request the system level data associated with Voice Messaging.
        /// The response is either a SystemVoiceMessagingGroupGetResponse20 or an ErrorResponse.
        /// Replaced by: SystemVoiceMessagingGroupGetRequest21
        /// </summary>
        public static async Task<SystemVoiceMessagingGroupGetResponse20> SystemVoiceMessagingGroupGetRequest20(this OcipClient client, SystemVoiceMessagingGroupGetRequest20 request)
        {
            return await client.Call(request) as SystemVoiceMessagingGroupGetResponse20;
        }

        /// <summary>
        /// Requests the system voice portal Menus setting.
        /// The response is either SystemVoiceMessagingGroupGetVoicePortalMenusResponse20 or ErrorResponse.
        /// </summary>
        public static async Task<SystemVoiceMessagingGroupGetVoicePortalMenusResponse20> SystemVoiceMessagingGroupGetVoicePortalMenusRequest20(this OcipClient client, SystemVoiceMessagingGroupGetVoicePortalMenusRequest20 request)
        {
            return await client.Call(request) as SystemVoiceMessagingGroupGetVoicePortalMenusResponse20;
        }

        /// <summary>
        /// Get a criteria for the user's custom ringback service.
        /// The response is either a UserCustomRingbackUserGetCriteriaResponse20 or an ErrorResponse.
        /// Replaced by: UserCustomRingbackUserGetCriteriaRequest21
        /// </summary>
        public static async Task<UserCustomRingbackUserGetCriteriaResponse20> UserCustomRingbackUserGetCriteriaRequest20(this OcipClient client, UserCustomRingbackUserGetCriteriaRequest20 request)
        {
            return await client.Call(request) as UserCustomRingbackUserGetCriteriaResponse20;
        }

        /// <summary>
        /// Request the user level data associated with Device Policy.
        /// The response is either a UserDevicePoliciesGetResponse20 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<UserDevicePoliciesGetResponse20> UserDevicePoliciesGetRequest20(this OcipClient client, UserDevicePoliciesGetRequest20 request)
        {
            return await client.Call(request) as UserDevicePoliciesGetResponse20;
        }

        /// <summary>
        /// Request user's call logs.
        /// If the callLogType is not specified, all types of calls logs (placed, received, missed) are returned.
        /// The filters "dateTimeRange", "numberFilter", "redirectedNumberFilter", "accountAuthorizationCodeFilter"
        /// "callAuthorizationCodeFilter" and "subscriberType" are ignored if call logs are stored in CDS. When
        /// "ReceivedOrMissed" is specified as "callLogType" and call logs are stored in CDS, all call logs
        /// including
        /// placed will be returned.
        /// It is possible to restrict the number of rows returned using responsePagingControl. If
        /// responsePagingControl
        /// is not specified, the value of Enhanced Call Logs system parameter maxNonPagedResponseSize will control
        /// the maximum number of call logs can be returned.
        /// The response is either a UserEnhancedCallLogsGetListResponse20 or an ErrorResponse.
        /// The following elements are only used in AS data mode and not returned in XS data mode:
        /// callAuthorizationCodeFilter
        /// </summary>
        public static async Task<UserEnhancedCallLogsGetListResponse20> UserEnhancedCallLogsGetListRequest20(this OcipClient client, UserEnhancedCallLogsGetListRequest20 request)
        {
            return await client.Call(request) as UserEnhancedCallLogsGetListResponse20;
        }

        /// <summary>
        /// Get a filtering criteria for an executive user.
        /// Both executive and the executive assistant can run this command.
        /// The response is either UserExecutiveGetFilteringSelectiveCriteriaResponse or ErrorResponse.
        /// Replaced by: UserExecutiveGetFilteringSelectiveCriteriaRequest21
        /// </summary>
        public static async Task<UserExecutiveGetFilteringSelectiveCriteriaResponse> UserExecutiveGetFilteringSelectiveCriteriaRequest(this OcipClient client, UserExecutiveGetFilteringSelectiveCriteriaRequest request)
        {
            return await client.Call(request) as UserExecutiveGetFilteringSelectiveCriteriaResponse;
        }

        /// <summary>
        /// Get the list of feature access codes for a user.
        /// The response is either a UserFeatureAccessCodeGetListResponse20 or an ErrorResponse.
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording Start".
        /// Replaced by: UserFeatureAccessCodeGetListRequest21 in AS data mode
        /// </summary>
        public static async Task<UserFeatureAccessCodeGetListResponse20> UserFeatureAccessCodeGetListRequest20(this OcipClient client, UserFeatureAccessCodeGetListRequest20 request)
        {
            return await client.Call(request) as UserFeatureAccessCodeGetListResponse20;
        }

        /// <summary>
        /// Request to get the user information. The response is either UserGetResponse20 or ErrorResponse.
        /// Replaced by: UserGetRequest21
        /// </summary>
        public static async Task<UserGetResponse20> UserGetRequest20(this OcipClient client, UserGetRequest20 request)
        {
            return await client.Call(request) as UserGetResponse20;
        }

        /// <summary>
        /// Get the address and credentials of the File Repository hosting the requested access device file.
        /// Also get the file name and path on the File Repository.
        /// The response is either a DeviceManagementFileAuthLocationGetResponse20sp1 or an ErrorResponse.
        /// Replaced by: DeviceManagementFileAuthLocationGetRequest21sp1.
        /// </summary>
        public static async Task<DeviceManagementFileAuthLocationGetResponse20sp1> DeviceManagementFileAuthLocationGetRequest20sp1(this OcipClient client, DeviceManagementFileAuthLocationGetRequest20sp1 request)
        {
            return await client.Call(request) as DeviceManagementFileAuthLocationGetResponse20sp1;
        }

        /// <summary>
        /// Get the group's BroadWorks Mobility settings.
        /// The response is either a GroupBroadWorksMobilityGetResponse19sp1 or an ErrorResponse.
        /// 
        /// Replaced by: GroupBroadWorksMobilityGetRequest22 in AS data mode
        /// </summary>
        public static async Task<GroupBroadWorksMobilityGetResponse19sp1> GroupBroadWorksMobilityGetRequest19sp1(this OcipClient client, GroupBroadWorksMobilityGetRequest19sp1 request)
        {
            return await client.Call(request) as GroupBroadWorksMobilityGetResponse19sp1;
        }

        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse18 or an
        /// ErrorResponse.
        /// 
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName,
        /// allowDepartmentCLIDNameOverride)
        /// 
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls,
        /// maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls,
        /// maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth,
        /// maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations)
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan,
        /// overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
        /// The following elements are only used in AS data mode:
        /// useGroupDCLIDSetting
        /// enableDialableCallerID
        /// allowDepartmentCLIDNameOverride
        /// 
        /// Replaced By : GroupCallProcessingGetPolicyRequest18sp1
        /// </summary>
        public static async Task<GroupCallProcessingGetPolicyResponse18> GroupCallProcessingGetPolicyRequest18(this OcipClient client, GroupCallProcessingGetPolicyRequest18 request)
        {
            return await client.Call(request) as GroupCallProcessingGetPolicyResponse18;
        }

        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse18sp1 or an
        /// ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy,enterpriseCallsCLIDPolicy, groupCallsCLIDPolicy, emergencyClidPolicy,
        /// allowAlternateNumbersForRedirectingIdentity, useGroupName, allowDepartmentCLIDNameOverride)
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls,
        /// maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls,
        /// maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth,
        /// maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations)
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan,
        /// overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
        /// Replaced by: GroupCallProcessingGetPolicyRequest19sp1
        /// </summary>
        public static async Task<GroupCallProcessingGetPolicyResponse18sp1> GroupCallProcessingGetPolicyRequest18sp1(this OcipClient client, GroupCallProcessingGetPolicyRequest18sp1 request)
        {
            return await client.Call(request) as GroupCallProcessingGetPolicyResponse18sp1;
        }

        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse19sp1 or an
        /// ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy,enterpriseCallsCLIDPolicy, groupCallsCLIDPolicy, emergencyClidPolicy,
        /// allowAlternateNumbersForRedirectingIdentity, useGroupName, allowDepartmentCLIDNameOverride)
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls,
        /// maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls,
        /// maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth,
        /// maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations)
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan,
        /// overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
        /// 
        /// Replaced by: GroupCallProcessingGetPolicyRequest21sp1
        /// </summary>
        public static async Task<GroupCallProcessingGetPolicyResponse19sp1> GroupCallProcessingGetPolicyRequest19sp1(this OcipClient client, GroupCallProcessingGetPolicyRequest19sp1 request)
        {
            return await client.Call(request) as GroupCallProcessingGetPolicyResponse19sp1;
        }

        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse21sp1 or an
        /// ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy,enterpriseCallsCLIDPolicy, groupCallsCLIDPolicy, emergencyClidPolicy,
        /// allowAlternateNumbersForRedirectingIdentity, useGroupName, allowDepartmentCLIDNameOverride)
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls,
        /// maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls,
        /// maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth,
        /// maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations)
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan,
        /// overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
        /// 
        /// Replaced by: GroupCallProcessingGetPolicyRequest21sp2
        /// </summary>
        public static async Task<GroupCallProcessingGetPolicyResponse21sp1> GroupCallProcessingGetPolicyRequest21sp1(this OcipClient client, GroupCallProcessingGetPolicyRequest21sp1 request)
        {
            return await client.Call(request) as GroupCallProcessingGetPolicyResponse21sp1;
        }

        /// <summary>
        /// Add a collaborate bridge to a group.
        /// The domain is required in the serviceUserId.
        /// The request fails when supportOutdial is enabled and the system-level collaborate supportOutdial setting
        /// is disabled.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced by GroupCollaborateBridgeAddInstanceRequest20sp1
        /// </summary>
        public static async Task<SuccessResponse> GroupCollaborateBridgeAddInstanceRequest(this OcipClient client, GroupCollaborateBridgeAddInstanceRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get all the information of a collaborate bridge.
        /// The response is either GroupCollaborateBridgeGetInstanceResponse or ErrorResponse.
        /// 
        /// Replaced by: GroupCollaborateBridgeGetInstanceRequest20sp1
        /// </summary>
        public static async Task<GroupCollaborateBridgeGetInstanceResponse> GroupCollaborateBridgeGetInstanceRequest(this OcipClient client, GroupCollaborateBridgeGetInstanceRequest request)
        {
            return await client.Call(request) as GroupCollaborateBridgeGetInstanceResponse;
        }

        /// <summary>
        /// Request to modify a Collaborate bridge.
        /// The request fails when the collaborateOwnerUserIdList is included in the request for the default
        /// collaborate bridge.
        /// The request fails when the supportOutdial is included in the request and the system-level collaborate
        /// supportOutdial setting is disabled.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced by: GroupCollaborateBridgeModifyInstanceRequest20sp1
        /// </summary>
        public static async Task<SuccessResponse> GroupCollaborateBridgeModifyInstanceRequest(this OcipClient client, GroupCollaborateBridgeModifyInstanceRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the list of device type files managed by the Device Management System, on a per-group
        /// basis.
        /// The response is either GroupDeviceTypeFileGetListResponse14sp8 or ErrorResponse.
        /// 
        /// Replaced by: GroupDeviceTypeFileGetListRequest21
        /// </summary>
        public static async Task<GroupDeviceTypeFileGetListResponse14sp8> GroupDeviceTypeFileGetListRequest14sp8(this OcipClient client, GroupDeviceTypeFileGetListRequest14sp8 request)
        {
            return await client.Call(request) as GroupDeviceTypeFileGetListResponse14sp8;
        }

        /// <summary>
        /// Get the service provider BroadWorks Mobility service settings.
        /// The response is either a ServiceProviderBroadWorksMobilityGetResponse19sp1 or an ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderBroadWorksMobilityGetRequest22 in AS data mode
        /// </summary>
        public static async Task<ServiceProviderBroadWorksMobilityGetResponse19sp1> ServiceProviderBroadWorksMobilityGetRequest19sp1(this OcipClient client, ServiceProviderBroadWorksMobilityGetRequest19sp1 request)
        {
            return await client.Call(request) as ServiceProviderBroadWorksMobilityGetResponse19sp1;
        }

        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse17sp4 or an ErrorResponse.
        /// 
        /// Replaced By : ServiceProviderCallProcessingGetPolicyRequest18sp1
        /// </summary>
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse17sp4> ServiceProviderCallProcessingGetPolicyRequest17sp4(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest17sp4 request)
        {
            return await client.Call(request) as ServiceProviderCallProcessingGetPolicyResponse17sp4;
        }

        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse18sp1 or an ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderCallProcessingGetPolicyRequest19sp1
        /// </summary>
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse18sp1> ServiceProviderCallProcessingGetPolicyRequest18sp1(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest18sp1 request)
        {
            return await client.Call(request) as ServiceProviderCallProcessingGetPolicyResponse18sp1;
        }

        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse19sp1 or an ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderCallProcessingGetPolicyRequest21sp1
        /// </summary>
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse19sp1> ServiceProviderCallProcessingGetPolicyRequest19sp1(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest19sp1 request)
        {
            return await client.Call(request) as ServiceProviderCallProcessingGetPolicyResponse19sp1;
        }

        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse21sp1 or an ErrorResponse.
        /// Replaced by: ServiceProviderCallProcessingGetPolicyRequest21sp2
        /// </summary>
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse21sp1> ServiceProviderCallProcessingGetPolicyRequest21sp1(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest21sp1 request)
        {
            return await client.Call(request) as ServiceProviderCallProcessingGetPolicyResponse21sp1;
        }

        /// <summary>
        /// Get the broadworks mobility system parameters.
        /// The response is either a SystemBroadWorksMobilityGetResponse21 or an ErrorResponse.
        /// 
        /// Replaced by: SystemBroadWorksMobilityGetRequest22 in AS data mode
        /// </summary>
        public static async Task<SystemBroadWorksMobilityGetResponse21> SystemBroadWorksMobilityGetRequest21(this OcipClient client, SystemBroadWorksMobilityGetRequest21 request)
        {
            return await client.Call(request) as SystemBroadWorksMobilityGetResponse21;
        }

        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse17sp4 or an
        /// ErrorResponse.
        /// Replaced By : SystemCallProcessingGetPolicyRequest18sp1
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse17sp4> SystemCallProcessingGetPolicyRequest17sp4(this OcipClient client, SystemCallProcessingGetPolicyRequest17sp4 request)
        {
            return await client.Call(request) as SystemCallProcessingGetPolicyResponse17sp4;
        }

        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse18sp1 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingGetPolicyRequest19sp1
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse18sp1> SystemCallProcessingGetPolicyRequest18sp1(this OcipClient client, SystemCallProcessingGetPolicyRequest18sp1 request)
        {
            return await client.Call(request) as SystemCallProcessingGetPolicyResponse18sp1;
        }

        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse19sp1 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingGetPolicyRequest21sp1
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse19sp1> SystemCallProcessingGetPolicyRequest19sp1(this OcipClient client, SystemCallProcessingGetPolicyRequest19sp1 request)
        {
            return await client.Call(request) as SystemCallProcessingGetPolicyResponse19sp1;
        }

        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse21sp1 or an
        /// ErrorResponse.
        /// Replaced by: SystemCallProcessingGetPolicyRequest1sp2.
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse21sp1> SystemCallProcessingGetPolicyRequest21sp1(this OcipClient client, SystemCallProcessingGetPolicyRequest21sp1 request)
        {
            return await client.Call(request) as SystemCallProcessingGetPolicyResponse21sp1;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Auto Attendant subscriber type
        /// profile.
        /// The response is either a SystemCallProcessingPolicyProfileAutoAttendantProfileGetResponse or an
        /// ErrorResponse.
        /// The response contains the call processing policy profile setting for Auto Attendant.
        /// 
        /// Replaced by: SystemCallProcessingPolicyProfileAutoAttendantProfileGetRequest22
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileAutoAttendantProfileGetResponse> SystemCallProcessingPolicyProfileAutoAttendantProfileGetRequest(this OcipClient client, SystemCallProcessingPolicyProfileAutoAttendantProfileGetRequest request)
        {
            return await client.Call(request) as SystemCallProcessingPolicyProfileAutoAttendantProfileGetResponse;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile BroadWorks Anywhere subscriber
        /// type profile.
        /// The response is either a SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetResponse or
        /// an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetRequest22
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetResponse> SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetRequest(this OcipClient client, SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetRequest request)
        {
            return await client.Call(request) as SystemCallProcessingPolicyProfileBroadWorksAnywhereProfileGetResponse;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Call Center subscriber type
        /// profile.
        /// The response is either a SystemCallProcessingPolicyProfileCallCenterProfileGetResponse or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingPolicyProfileCallCenterProfileGetRequest22
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileCallCenterProfileGetResponse> SystemCallProcessingPolicyProfileCallCenterProfileGetRequest(this OcipClient client, SystemCallProcessingPolicyProfileCallCenterProfileGetRequest request)
        {
            return await client.Call(request) as SystemCallProcessingPolicyProfileCallCenterProfileGetResponse;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Collaborate subscriber type
        /// profile.
        /// The response is either a SystemCallProcessingPolicyProfileCollaborateProfileGetResponse or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingPolicyProfileCollaborateProfileGetRequest22
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileCollaborateProfileGetResponse> SystemCallProcessingPolicyProfileCollaborateProfileGetRequest(this OcipClient client, SystemCallProcessingPolicyProfileCollaborateProfileGetRequest request)
        {
            return await client.Call(request) as SystemCallProcessingPolicyProfileCollaborateProfileGetResponse;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Find-me/Follow-me subscriber type
        /// profile.
        /// The response is either a SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetResponse or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetRequest22
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetResponse> SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetRequest(this OcipClient client, SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetRequest request)
        {
            return await client.Call(request) as SystemCallProcessingPolicyProfileFindMeFollowMeProfileGetResponse;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Flexible Seating Host subscriber
        /// type profile.
        /// The response is either a SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetResponse or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetRequest22
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetResponse> SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetRequest(this OcipClient client, SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetRequest request)
        {
            return await client.Call(request) as SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetResponse;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Group Paging subscriber type
        /// profile.
        /// The response is either a SystemCallProcessingPolicyProfileGroupPagingProfileGetResponse or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingPolicyProfileGroupPagingProfileGetRequest22
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileGroupPagingProfileGetResponse> SystemCallProcessingPolicyProfileGroupPagingProfileGetRequest(this OcipClient client, SystemCallProcessingPolicyProfileGroupPagingProfileGetRequest request)
        {
            return await client.Call(request) as SystemCallProcessingPolicyProfileGroupPagingProfileGetResponse;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Hunt Group subscriber type
        /// profile.
        /// The response is either a SystemCallProcessingPolicyProfileHuntGroupProfileGetResponse or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingPolicyProfileHuntGroupProfileGetRequest22
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileHuntGroupProfileGetResponse> SystemCallProcessingPolicyProfileHuntGroupProfileGetRequest(this OcipClient client, SystemCallProcessingPolicyProfileHuntGroupProfileGetRequest request)
        {
            return await client.Call(request) as SystemCallProcessingPolicyProfileHuntGroupProfileGetResponse;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Instant Group Call subscriber type
        /// profile.
        /// The response is either a SystemCallProcessingPolicyProfileInstantGroupCallProfileGetResponse22 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingPolicyProfileInstantGroupCallProfileGetRequest22
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileInstantGroupCallProfileGetResponse22> SystemCallProcessingPolicyProfileInstantGroupCallProfileGetRequest(this OcipClient client, SystemCallProcessingPolicyProfileInstantGroupCallProfileGetRequest request)
        {
            return await client.Call(request) as SystemCallProcessingPolicyProfileInstantGroupCallProfileGetResponse22;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Meet-Me Conferencing subscriber
        /// type profile.
        /// The response is either a SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetResponse or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetRequest22
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetResponse> SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetRequest(this OcipClient client, SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetRequest request)
        {
            return await client.Call(request) as SystemCallProcessingPolicyProfileMeetMeConferencingProfileGetResponse;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Route Point subscriber type
        /// profile.
        /// The response is either a SystemCallProcessingPolicyProfileRoutePointProfileGetResponse or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingPolicyProfileRoutePointProfileGetRequest22
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileRoutePointProfileGetResponse> SystemCallProcessingPolicyProfileRoutePointProfileGetRequest(this OcipClient client, SystemCallProcessingPolicyProfileRoutePointProfileGetRequest request)
        {
            return await client.Call(request) as SystemCallProcessingPolicyProfileRoutePointProfileGetResponse;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Trunk Group Pilot user subscriber
        /// type profile.
        /// The response is either a SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest22
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse> SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest(this OcipClient client, SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetRequest request)
        {
            return await client.Call(request) as SystemCallProcessingPolicyProfileTrunkGroupPilotProfileGetResponse;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile user subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileUserProfileGetResponse or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingPolicyProfileUserProfileGetRequest21sp1 in AS data mode
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileUserProfileGetResponse> SystemCallProcessingPolicyProfileUserProfileGetRequest(this OcipClient client, SystemCallProcessingPolicyProfileUserProfileGetRequest request)
        {
            return await client.Call(request) as SystemCallProcessingPolicyProfileUserProfileGetResponse;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile user subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileUserProfileGetResponse21sp1 or an
        /// ErrorResponse.
        /// Replaced by: SystemCallProcessingPolicyProfileUserProfileGetRequest22 in AS data mode
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileUserProfileGetResponse21sp1> SystemCallProcessingPolicyProfileUserProfileGetRequest21sp1(this OcipClient client, SystemCallProcessingPolicyProfileUserProfileGetRequest21sp1 request)
        {
            return await client.Call(request) as SystemCallProcessingPolicyProfileUserProfileGetResponse21sp1;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile Voice Portal subscriber type
        /// profile.
        /// The response is either a SystemCallProcessingPolicyProfileVoicePortalProfileGetResponse or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingPolicyProfileVoicePortalProfileGetRequest22
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileVoicePortalProfileGetResponse> SystemCallProcessingPolicyProfileVoicePortalProfileGetRequest(this OcipClient client, SystemCallProcessingPolicyProfileVoicePortalProfileGetRequest request)
        {
            return await client.Call(request) as SystemCallProcessingPolicyProfileVoicePortalProfileGetResponse;
        }

        /// <summary>
        /// Request to get the configuration for a call processing policy profile VoiceXML subscriber type profile.
        /// The response is either a SystemCallProcessingPolicyProfileVoiceXMLProfileGetResponse or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingPolicyProfileVoiceXMLProfileGetRequest22
        /// </summary>
        public static async Task<SystemCallProcessingPolicyProfileVoiceXMLProfileGetResponse> SystemCallProcessingPolicyProfileVoiceXMLProfileGetRequest(this OcipClient client, SystemCallProcessingPolicyProfileVoiceXMLProfileGetRequest request)
        {
            return await client.Call(request) as SystemCallProcessingPolicyProfileVoiceXMLProfileGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with collaborate services.
        /// The response is either a SystemCollaborateGetResponse20sp1 or an ErrorResponse.
        /// 
        /// Replaced by: SystemCollaborateGetRequest20sp1V2
        /// </summary>
        public static async Task<SystemCollaborateGetResponse20sp1> SystemCollaborateGetRequest20sp1(this OcipClient client, SystemCollaborateGetRequest20sp1 request)
        {
            return await client.Call(request) as SystemCollaborateGetResponse20sp1;
        }

        /// <summary>
        /// Modify the system level data associated with collaborate services.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by SystemCollaborateModifyRequest20sp1V2
        /// </summary>
        public static async Task<SuccessResponse> SystemCollaborateModifyRequest20sp1(this OcipClient client, SystemCollaborateModifyRequest20sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Gets the system level attributes of the Cr Interface.
        /// The response is either a SystemCrInterfaceGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SystemCrInterfaceGetResponse> SystemCrInterfaceGetRequest(this OcipClient client, SystemCrInterfaceGetRequest request)
        {
            return await client.Call(request) as SystemCrInterfaceGetResponse;
        }

        /// <summary>
        /// Get the list of users that are unreachable from the primary application server.
        /// The response is a SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest22 in AS data mode
        /// </summary>
        public static async Task<SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse> SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest(this OcipClient client, SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest request)
        {
            return await client.Call(request) as SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse;
        }

        /// <summary>
        /// Get the list of registration contacts.
        /// This request handles all levels of administration privileges. The content of the response will only
        /// contain
        /// items within the scope of the requester's login id. At the system level any of the choice parameters may
        /// be
        /// specified to filter the registrations listed. At the reseller level, the resellerId must be specified.
        /// ResellerId is not valid at service provider, group or user level. At the service provider level the
        /// serviceProviderId must be specified for the service provider and group options. When using the userId or
        /// linePort options the specified value must be valid for that service provider login. At the group level
        /// the servicProviderId and the groupId must be specified for the group option. When using the userId or
        /// linePort
        /// options the specified value must be valid for that group login.
        /// The serviceProviderId option is not valid at the group level. At the user level when using the userId or
        /// linePort options the specified value must be valid for that user login. The serviceProviderId and
        /// groupId
        /// options are not valid at the user level.
        /// The response is either SystemGetRegistrationContactListResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// resellerId
        /// </summary>
        public static async Task<SystemGetRegistrationContactListResponse> SystemGetRegistrationContactListRequest(this OcipClient client, SystemGetRegistrationContactListRequest request)
        {
            return await client.Call(request) as SystemGetRegistrationContactListResponse;
        }

        /// <summary>
        /// Request to get the list of Mail system parameters.
        /// The response is either SystemMailParametersGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemMailParametersGetResponse> SystemMailParametersGetRequest(this OcipClient client, SystemMailParametersGetRequest request)
        {
            return await client.Call(request) as SystemMailParametersGetResponse;
        }

        /// <summary>
        /// Requests the performance measurements reporting settings.
        /// The response is either SystemPerformanceMeasurementReportingGetResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemPerformanceMeasurementReportingGetRequest22
        /// </summary>
        public static async Task<SystemPerformanceMeasurementReportingGetResponse> SystemPerformanceMeasurementReportingGetRequest(this OcipClient client, SystemPerformanceMeasurementReportingGetRequest request)
        {
            return await client.Call(request) as SystemPerformanceMeasurementReportingGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Selective Services.
        /// The response is either a SystemSelectiveServicesGetResponse18sp1 or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SystemSelectiveServicesGetResponse18sp1> SystemSelectiveServicesGetRequest18sp1(this OcipClient client, SystemSelectiveServicesGetRequest18sp1 request)
        {
            return await client.Call(request) as SystemSelectiveServicesGetResponse18sp1;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in HSS data mode:
        /// enable3G4GContinuity, use value "false" in AS data mode
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// The following elements are only used in AS data mode:
        /// holdAnnouncementMethod, use value "useInactive" in HSS data mode
        /// supportRFC3398, use value "false" in HSS data mode
        /// supportClientSessionInfo, use value "false" in HSS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in HSS data mode
        /// supportRemotePartyInfo, use value "false" in HSS data mode
        /// The following element values are only applicable in AS data mode:
        /// holdNormalization=useRfc3264Hold will raise an error in HSS data mode
        /// 
        /// Replaced by: SystemSIPDeviceTypeAddRequest21sp1V2.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest20sp1(this OcipClient client, SystemSIPDeviceTypeAddRequest20sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in XS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// The following elements are only used in AS data mode:
        /// holdAnnouncementMethod, use value "useInactive" in XS data mode
        /// supportRFC3398, use value "false" in XS data mode
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// The following element values are only applicable in AS data mode:
        /// holdNormalization=useRfc3264Hold will raise an error in XS data mode
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// supportCauseParameter
        /// Replaced by: SystemSIPDeviceTypeAddRequest21sp1
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest21(this OcipClient client, SystemSIPDeviceTypeAddRequest21 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in XS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// The following elements are only used in AS data mode:
        /// holdAnnouncementMethod, use value "useInactive" in XS data mode
        /// supportRFC3398, use value "false" in XS data mode
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// The following element values are only applicable in AS data mode:
        /// holdNormalization=useRfc3264Hold will raise an error in XS data mode
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// supportCauseParameter
        /// 
        /// Replaced by: SystemSIPDeviceTypeAddRequest21Sp1V2
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest21sp1(this OcipClient client, SystemSIPDeviceTypeAddRequest21sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is
        /// specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS
        /// supports3G4GContinuity
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportRFC3398, use value "false" in XS data mode
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// resellerId
        /// 
        /// The following values for element profile are only used in AS data mode and an error is returned in the
        /// XS data mode:
        /// Non-intelligent Device Addressing
        /// Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// 
        /// Deprecated by: SystemSIPDeviceTypeAddRequest22V2
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest22(this OcipClient client, SystemSIPDeviceTypeAddRequest22 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is
        /// specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS
        /// supports3G4GContinuity
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportRFC3398, use value "false" in XS data mode
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// resellerId
        /// 
        /// The following values for element profile are only used in AS data mode and an error is returned in the
        /// XS data mode:
        /// Non-intelligent Device Addressing
        /// Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// 
        /// Deprecated by SystemSIPDeviceTypeAddRequest22V3
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest22V2(this OcipClient client, SystemSIPDeviceTypeAddRequest22V2 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse20 or ErrorResponse.
        /// Replaced by: SystemSIPDeviceTypeGetRequest21sp1V2.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse20> SystemSIPDeviceTypeGetRequest20sp1(this OcipClient client, SystemSIPDeviceTypeGetRequest20sp1 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse20;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse21 or ErrorResponse.
        /// 
        /// Replaced by: SystemSIPDeviceTypeGetRequest21Sp1
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse21> SystemSIPDeviceTypeGetRequest21(this OcipClient client, SystemSIPDeviceTypeGetRequest21 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse21;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse21sp1 or ErrorResponse.
        /// 
        /// Replaced by: SystemSIPDeviceTypeGetRequest21sp1V2
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse21sp1> SystemSIPDeviceTypeGetRequest21sp1(this OcipClient client, SystemSIPDeviceTypeGetRequest21sp1 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse21sp1;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse22 or ErrorResponse.
        /// 
        /// Deprecated by: SystemSIPDeviceTypeGetRequest22V2
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse22> SystemSIPDeviceTypeGetRequest22(this OcipClient client, SystemSIPDeviceTypeGetRequest22 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse22;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse22V2 or ErrorResponse.
        /// 
        /// Deprecated by SystemSIPDeviceTypeGetRequest22V3
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse22V2> SystemSIPDeviceTypeGetRequest22V2(this OcipClient client, SystemSIPDeviceTypeGetRequest22V2 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse22V2;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse22V3 or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse22V3> SystemSIPDeviceTypeGetRequest22V3(this OcipClient client, SystemSIPDeviceTypeGetRequest22V3 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse22V3;
        }

        /// <summary>
        /// Requests a table of all the existing Call Blocking Service Mappings in the system.
        /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse19sp1
        /// or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceGetListRequest22
        /// </summary>
        public static async Task<SystemTreatmentMappingCallBlockingServiceGetListResponse19sp1> SystemTreatmentMappingCallBlockingServiceGetListRequest19sp1(this OcipClient client, SystemTreatmentMappingCallBlockingServiceGetListRequest19sp1 request)
        {
            return await client.Call(request) as SystemTreatmentMappingCallBlockingServiceGetListResponse19sp1;
        }

        /// <summary>
        /// Get the user's BroadWorks Mobility service settings.
        /// The response is either a UserBroadWorksMobilityGetResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<UserBroadWorksMobilityGetResponse21> UserBroadWorksMobilityGetRequest21(this OcipClient client, UserBroadWorksMobilityGetRequest21 request)
        {
            return await client.Call(request) as UserBroadWorksMobilityGetResponse21;
        }

        /// <summary>
        /// Add a mobile identity to the user's list of mobile identities.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The request fails when the devicesToRing is set to Mobile and the mobileNumberAlerted list is empty.
        /// 
        /// Replaced by: UserBroadWorksMobilityMobileIdentityAddRequest21sp1.
        /// </summary>
        public static async Task<SuccessResponse> UserBroadWorksMobilityMobileIdentityAddRequest(this OcipClient client, UserBroadWorksMobilityMobileIdentityAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the settings for a user's specified mobile identity.
        /// The response is either a UserBroadWorksMobilityMobileIdentityGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserBroadWorksMobilityMobileIdentityGetRequest21sp1.
        /// </summary>
        public static async Task<UserBroadWorksMobilityMobileIdentityGetResponse> UserBroadWorksMobilityMobileIdentityGetRequest(this OcipClient client, UserBroadWorksMobilityMobileIdentityGetRequest request)
        {
            return await client.Call(request) as UserBroadWorksMobilityMobileIdentityGetResponse;
        }

        /// <summary>
        /// Get the settings for a user's specified mobile identity.
        /// The response is either a UserBroadWorksMobilityMobileIdentityGetResponse21sp1 or an ErrorResponse.
        /// 
        /// Replaced by: UserBroadWorksMobilityMobileIdentityGetRequest21sp1V2.
        /// </summary>
        public static async Task<UserBroadWorksMobilityMobileIdentityGetResponse21sp1> UserBroadWorksMobilityMobileIdentityGetRequest21sp1(this OcipClient client, UserBroadWorksMobilityMobileIdentityGetRequest21sp1 request)
        {
            return await client.Call(request) as UserBroadWorksMobilityMobileIdentityGetResponse21sp1;
        }

        /// <summary>
        /// Request the user level data associated with Call Processing Policy.
        /// The response is either a UserCallProcessingGetPolicyResponse18 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: UserCallProcessingGetPolicyRequest19sp1
        /// </summary>
        public static async Task<UserCallProcessingGetPolicyResponse18> UserCallProcessingGetPolicyRequest18(this OcipClient client, UserCallProcessingGetPolicyRequest18 request)
        {
            return await client.Call(request) as UserCallProcessingGetPolicyResponse18;
        }

        /// <summary>
        /// Request the user level data associated with Call Processing Policy.
        /// The response is either a UserCallProcessingGetPolicyResponse19sp1 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: UserCallProcessingGetPolicyRequest21sp1
        /// </summary>
        public static async Task<UserCallProcessingGetPolicyResponse19sp1> UserCallProcessingGetPolicyRequest19sp1(this OcipClient client, UserCallProcessingGetPolicyRequest19sp1 request)
        {
            return await client.Call(request) as UserCallProcessingGetPolicyResponse19sp1;
        }

        /// <summary>
        /// Request the user level data associated with Call Processing Policy.
        /// The response is either a UserCallProcessingGetPolicyResponse21sp1 or an
        /// ErrorResponse.
        /// Replaced by: UserCallProcessingGetPolicyRequest21sp2
        /// </summary>
        public static async Task<UserCallProcessingGetPolicyResponse21sp1> UserCallProcessingGetPolicyRequest21sp1(this OcipClient client, UserCallProcessingGetPolicyRequest21sp1 request)
        {
            return await client.Call(request) as UserCallProcessingGetPolicyResponse21sp1;
        }

        /// <summary>
        /// Request the collaborate bridged assigned to the user. The user can only be assigned to one collaborate
        /// bridge at any given time.
        /// The response is either UserCollaborateBridgeGetResponse or ErrorResponse.
        /// 
        /// Replaced by: UserCollaborateBridgeGetRequest20sp1
        /// </summary>
        public static async Task<UserCollaborateBridgeGetResponse> UserCollaborateBridgeGetRequest(this OcipClient client, UserCollaborateBridgeGetRequest request)
        {
            return await client.Call(request) as UserCollaborateBridgeGetResponse;
        }

        /// <summary>
        /// AuthenticationVerifyRequest14sp8 is used to authenticate a user either by userId/password, userId/sip
        /// username/sip password,
        /// dn/passcode or a token previously authorized with the ExternalAuthenticationAuthorizeTokenRequest.
        /// The phone number may be any DN associated with a user.
        /// 
        /// The response is a AuthenticationVerifyResponse14sp8 or an ErrorResponse
        /// 
        /// Replaced by AuthenticationVerifyRequest22.
        /// </summary>
        public static async Task<AuthenticationVerifyResponse14sp8> AuthenticationVerifyRequest14sp8(this OcipClient client, AuthenticationVerifyRequest14sp8 request)
        {
            return await client.Call(request) as AuthenticationVerifyResponse14sp8;
        }

        /// <summary>
        /// AuthenticationVerifyRequest21sp1 is used to authenticate a user either by userId/password, userId/sip
        /// username/sip password,
        /// dn/passcode, lineport/password or a token previously authorized with the
        /// ExternalAuthenticationAuthorizeTokenRequest.
        /// The phone number may be any DN associated with a user.
        /// The lineport may be any lineport associated with a user.
        /// The password used for the lineport is the user’s password associated with userId.
        /// 
        /// The response is a AuthenticationVerifyResponse21sp1 or an ErrorResponse
        /// Replaced by AuthenticationVerifyRequest22V2.
        /// </summary>
        public static async Task<AuthenticationVerifyResponse21sp1> AuthenticationVerifyRequest21sp1(this OcipClient client, AuthenticationVerifyRequest21sp1 request)
        {
            return await client.Call(request) as AuthenticationVerifyResponse21sp1;
        }

        /// <summary>
        /// AuthenticationVerifyRequest22 is used to authenticate a user either by userId/password, userId/sip
        /// username/sip password,
        /// dn/passcode, lineport/password or a token previously authorized with the
        /// ExternalAuthenticationAuthorizeTokenRequest.
        /// The phone number may be any DN associated with a user.
        /// The lineport may be any lineport associated with a user.
        /// The password used for the lineport is the user's password associated with userId.
        /// 
        /// The response is a AuthenticationVerifyResponse22 or an ErrorResponse
        /// Replaced by AuthenticationVerifyRequest22V2.
        /// </summary>
        public static async Task<AuthenticationVerifyResponse22> AuthenticationVerifyRequest22(this OcipClient client, AuthenticationVerifyRequest22 request)
        {
            return await client.Call(request) as AuthenticationVerifyResponse22;
        }

        /// <summary>
        /// Request a table containing the phone directory for an enterprise.
        /// The directory includes all users in the enterprise and all entries in the enterprise common phone list.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either EnterprisePhoneDirectoryGetPagedListResponse or ErrorResponse.
        /// 
        /// Replaced By: EnterprisePhoneDirectoryGetPagedSortedListRequest
        /// </summary>
        public static async Task<EnterprisePhoneDirectoryGetPagedListResponse> EnterprisePhoneDirectoryGetPagedListRequest(this OcipClient client, EnterprisePhoneDirectoryGetPagedListRequest request)
        {
            return await client.Call(request) as EnterprisePhoneDirectoryGetPagedListResponse;
        }

        /// <summary>
        /// Request to get a group device profile file.
        /// The response is either GroupAccessDeviceFileGetResponse16sp1 or ErrorResponse.
        /// 
        /// Replaced by: GroupAccessDeviceFileGetRequest20
        /// </summary>
        public static async Task<GroupAccessDeviceFileGetResponse16sp1> GroupAccessDeviceFileGetRequest16sp1(this OcipClient client, GroupAccessDeviceFileGetRequest16sp1 request)
        {
            return await client.Call(request) as GroupAccessDeviceFileGetResponse16sp1;
        }

        /// <summary>
        /// Get the group's BroadWorks Mobility settings.
        /// The response is either a GroupBroadWorksMobilityGetResponse21sp1 or an ErrorResponse.
        /// 
        /// Replaced by GroupBroadWorksMobilityGetRequest22V2.
        /// </summary>
        public static async Task<GroupBroadWorksMobilityGetResponse21sp1> GroupBroadWorksMobilityGetRequest21sp1(this OcipClient client, GroupBroadWorksMobilityGetRequest21sp1 request)
        {
            return await client.Call(request) as GroupBroadWorksMobilityGetResponse21sp1;
        }

        /// <summary>
        /// Get the group's BroadWorks Mobility settings.
        /// The response is either a GroupBroadWorksMobilityGetResponse21sp1V2 or an ErrorResponse.
        /// 
        /// Replaced by GroupBroadWorksMobilityGetRequest22V2.
        /// </summary>
        public static async Task<GroupBroadWorksMobilityGetResponse21sp1V2> GroupBroadWorksMobilityGetRequest21sp1V2(this OcipClient client, GroupBroadWorksMobilityGetRequest21sp1V2 request)
        {
            return await client.Call(request) as GroupBroadWorksMobilityGetResponse21sp1V2;
        }

        /// <summary>
        /// Get the group's BroadWorks Mobility settings.
        /// The response is either a GroupBroadWorksMobilityGetResponse22 or an ErrorResponse.
        /// 
        /// Replaced by GroupBroadWorksMobilityGetRequest22V2.
        /// </summary>
        public static async Task<GroupBroadWorksMobilityGetResponse22> GroupBroadWorksMobilityGetRequest22(this OcipClient client, GroupBroadWorksMobilityGetRequest22 request)
        {
            return await client.Call(request) as GroupBroadWorksMobilityGetResponse22;
        }

        /// <summary>
        /// Request device management's events for a specific queue.
        /// It is possible to restrict the number of rows returned using
        /// responseSizeLimit.
        /// If eventQueueType is not specified, the events from all the
        /// event queues are returned.
        /// The response is either a GroupDeviceManagementEventGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<GroupDeviceManagementEventGetListResponse> GroupDeviceManagementEventGetListRequest(this OcipClient client, GroupDeviceManagementEventGetListRequest request)
        {
            return await client.Call(request) as GroupDeviceManagementEventGetListResponse;
        }

        /// <summary>
        /// Request to get a service provider device profile file.
        /// The response is either ServiceProviderAccessDeviceFileGetResponse16sp1 or ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderAccessDeviceFileGetRequest20
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceFileGetResponse16sp1> ServiceProviderAccessDeviceFileGetRequest16sp1(this OcipClient client, ServiceProviderAccessDeviceFileGetRequest16sp1 request)
        {
            return await client.Call(request) as ServiceProviderAccessDeviceFileGetResponse16sp1;
        }

        /// <summary>
        /// Get the service provider BroadWorks Mobility service settings.
        /// The response is either a ServiceProviderBroadWorksMobilityGetResponse21sp1 or an ErrorResponse.
        /// 
        /// Replaced by ServiceProviderBroadWorksMobilityGetRequest22V2.
        /// </summary>
        public static async Task<ServiceProviderBroadWorksMobilityGetResponse21sp1> ServiceProviderBroadWorksMobilityGetRequest21sp1(this OcipClient client, ServiceProviderBroadWorksMobilityGetRequest21sp1 request)
        {
            return await client.Call(request) as ServiceProviderBroadWorksMobilityGetResponse21sp1;
        }

        /// <summary>
        /// Get the service provider BroadWorks Mobility service settings.
        /// The response is either a ServiceProviderBroadWorksMobilityGetResponse21sp1V2 or an ErrorResponse.
        /// 
        /// Replaced by ServiceProviderBroadWorksMobilityGetRequest22V2.
        /// </summary>
        public static async Task<ServiceProviderBroadWorksMobilityGetResponse21sp1V2> ServiceProviderBroadWorksMobilityGetRequest21sp1V2(this OcipClient client, ServiceProviderBroadWorksMobilityGetRequest21sp1V2 request)
        {
            return await client.Call(request) as ServiceProviderBroadWorksMobilityGetResponse21sp1V2;
        }

        /// <summary>
        /// Get the service provider BroadWorks Mobility service settings.
        /// The response is either a ServiceProviderBroadWorksMobilityGetResponse22 or an ErrorResponse.
        /// 
        /// Replaced by ServiceProviderBroadWorksMobilityGetRequest22V2.
        /// </summary>
        public static async Task<ServiceProviderBroadWorksMobilityGetResponse22> ServiceProviderBroadWorksMobilityGetRequest22(this OcipClient client, ServiceProviderBroadWorksMobilityGetRequest22 request)
        {
            return await client.Call(request) as ServiceProviderBroadWorksMobilityGetResponse22;
        }

        /// <summary>
        /// Request device management's events for a specific queue.
        /// It is possible to restrict the number of rows returned using
        /// responseSizeLimit.
        /// If eventQueueType is not specified, the events from all the
        /// event queues are returned.
        /// The response is either a ServiceProviderDeviceManagementEventGetListResponse or an ErrorResponse.
        /// 
        /// Deprecated by: ServiceProviderDeviceManagementEventGetListRequest22.
        /// </summary>
        public static async Task<ServiceProviderDeviceManagementEventGetListResponse> ServiceProviderDeviceManagementEventGetListRequest(this OcipClient client, ServiceProviderDeviceManagementEventGetListRequest request)
        {
            return await client.Call(request) as ServiceProviderDeviceManagementEventGetListResponse;
        }

        /// <summary>
        /// Get the profile for a service provider or enterprise.
        /// The response is either a ServiceProviderGetResponse17sp1 or an ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderGetRequest22.
        /// </summary>
        public static async Task<ServiceProviderGetResponse17sp1> ServiceProviderGetRequest17sp1(this OcipClient client, ServiceProviderGetRequest17sp1 request)
        {
            return await client.Call(request) as ServiceProviderGetResponse17sp1;
        }

        /// <summary>
        /// Get the profile for a service provider or enterprise.
        /// The response is either a ServiceProviderGetResponse22 or an ErrorResponse.
        /// 
        /// Replaced by ServiceProviderGetRequest22V2.
        /// </summary>
        public static async Task<ServiceProviderGetResponse22> ServiceProviderGetRequest22(this OcipClient client, ServiceProviderGetRequest22 request)
        {
            return await client.Call(request) as ServiceProviderGetResponse22;
        }

        /// <summary>
        /// Request to get a device profile file.
        /// The response is either SystemAccessDeviceFileGetResponse16sp1 or ErrorResponse.
        /// 
        /// Replaced by: SystemAccessDeviceFileGetRequest20
        /// </summary>
        public static async Task<SystemAccessDeviceFileGetResponse16sp1> SystemAccessDeviceFileGetRequest16sp1(this OcipClient client, SystemAccessDeviceFileGetRequest16sp1 request)
        {
            return await client.Call(request) as SystemAccessDeviceFileGetResponse16sp1;
        }

        /// <summary>
        /// Get the broadworks mobility system parameters.
        /// The response is either a SystemBroadWorksMobilityGetResponse21sp1 or an ErrorResponse.
        /// 
        /// Replaced by SystemBroadWorksMobilityGetRequest22V2.
        /// </summary>
        public static async Task<SystemBroadWorksMobilityGetResponse21sp1> SystemBroadWorksMobilityGetRequest21sp1(this OcipClient client, SystemBroadWorksMobilityGetRequest21sp1 request)
        {
            return await client.Call(request) as SystemBroadWorksMobilityGetResponse21sp1;
        }

        /// <summary>
        /// Get the broadworks mobility system parameters.
        /// The response is either a SystemBroadWorksMobilityGetResponse21sp1V2 or an ErrorResponse.
        /// 
        /// Replaced by SystemBroadWorksMobilityGetRequest22V2.
        /// </summary>
        public static async Task<SystemBroadWorksMobilityGetResponse21sp1V2> SystemBroadWorksMobilityGetRequest21sp1V2(this OcipClient client, SystemBroadWorksMobilityGetRequest21sp1V2 request)
        {
            return await client.Call(request) as SystemBroadWorksMobilityGetResponse21sp1V2;
        }

        /// <summary>
        /// Get the broadworks mobility system parameters.
        /// The response is either a SystemBroadWorksMobilityGetResponse22 or an ErrorResponse.
        /// 
        /// Replaced by SystemBroadWorksMobilityGetRequest22V2.
        /// </summary>
        public static async Task<SystemBroadWorksMobilityGetResponse22> SystemBroadWorksMobilityGetRequest22(this OcipClient client, SystemBroadWorksMobilityGetRequest22 request)
        {
            return await client.Call(request) as SystemBroadWorksMobilityGetResponse22;
        }

        /// <summary>
        /// Get list of Call Recording platforms.
        /// The response is either SystemCallRecordingGetPlatformListResponse20sp1 or ErrorResponse.
        /// 
        /// The possible values for "Support Video Rec" can be either true or false.
        /// Schema version values include: 1.0, 2.0, 3.0
        /// 
        /// Replaced by SystemCallRecordingGetPlatformListRequest22 in AS data mode.
        /// </summary>
        public static async Task<SystemCallRecordingGetPlatformListResponse20sp1> SystemCallRecordingGetPlatformListRequest20sp1(this OcipClient client, SystemCallRecordingGetPlatformListRequest20sp1 request)
        {
            return await client.Call(request) as SystemCallRecordingGetPlatformListResponse20sp1;
        }

        /// <summary>
        /// Get the list of groups currently associated to the specified Call Recording platform.
        /// The response is either SystemCallRecordingGetPlatformUsageResponse or ErrorResponse.
        /// 
        /// Replaced by SystemCallRecordingGetPlatformUsageRequest22 in AS data mode.
        /// </summary>
        public static async Task<SystemCallRecordingGetPlatformUsageResponse> SystemCallRecordingGetPlatformUsageRequest(this OcipClient client, SystemCallRecordingGetPlatformUsageRequest request)
        {
            return await client.Call(request) as SystemCallRecordingGetPlatformUsageResponse;
        }

        /// <summary>
        /// Request device management's events for a specific queue.
        /// It is possible to restrict the number of rows returned using
        /// responseSizeLimit.
        /// If eventQueueType is not specified, the events from all the
        /// event queues are returned.
        /// The response is either a SystemDeviceManagementEventGetListResponse or an ErrorResponse.
        /// 
        /// Deprecated by: SystemDeviceManagementEventGetListRequest22.
        /// </summary>
        public static async Task<SystemDeviceManagementEventGetListResponse> SystemDeviceManagementEventGetListRequest(this OcipClient client, SystemDeviceManagementEventGetListRequest request)
        {
            return await client.Call(request) as SystemDeviceManagementEventGetListResponse;
        }

        /// <summary>
        /// Requests the information about the specified device type without regard to whether the
        /// type is SIP or MGCP.
        /// The response is either SystemDeviceTypeGetResponse21sp1 or ErrorResponse.
        /// Note: The elements deviceTypeConfigurationOption and staticLineOrdering apply to SIP device types only.
        /// Therefore, only present in the response when the device type is SIP.
        /// </summary>
        public static async Task<SystemDeviceTypeGetResponse21sp1> SystemDeviceTypeGetRequest21sp1(this OcipClient client, SystemDeviceTypeGetRequest21sp1 request)
        {
            return await client.Call(request) as SystemDeviceTypeGetResponse21sp1;
        }

        /// <summary>
        /// Add a new file repository.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemFileRepositoryDeviceAddRequest20
        /// </summary>
        public static async Task<SuccessResponse> SystemFileRepositoryDeviceAddRequest16(this OcipClient client, SystemFileRepositoryDeviceAddRequest16 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the file repository information.
        /// The response is either SystemFileRepositoryDeviceGetResponse16 or ErrorResponse.
        /// 
        /// Replaced by: SystemFileRepositoryDeviceGetRequest20
        /// </summary>
        public static async Task<SystemFileRepositoryDeviceGetResponse16> SystemFileRepositoryDeviceGetRequest16(this OcipClient client, SystemFileRepositoryDeviceGetRequest16 request)
        {
            return await client.Call(request) as SystemFileRepositoryDeviceGetResponse16;
        }

        /// <summary>
        /// Get a list of migrated users.
        /// The response is either SystemMigratedUsersGetListResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemMigratedUsersGetListRequest22 in AS data mode
        /// </summary>
        public static async Task<SystemMigratedUsersGetListResponse> SystemMigratedUsersGetListRequest(this OcipClient client, SystemMigratedUsersGetListRequest request)
        {
            return await client.Call(request) as SystemMigratedUsersGetListResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS
        /// supports3G4GContinuity
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportRFC3398, use value "false" in XS data mode
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// 
        /// The following values for element profile are only used in AS data mode and an error is returned in the
        /// XS data mode:
        /// Non-intelligent Device Addressing
        /// Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// 
        /// Replaced by: SystemSIPDeviceTypeAddRequest22 in AS data mode.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest21sp1V2(this OcipClient client, SystemSIPDeviceTypeAddRequest21sp1V2 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse21sp1V2 or ErrorResponse.
        /// 
        /// Replaced by: SystemSIPDeviceTypeGetRequest22 in AS data mode.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse21sp1V2> SystemSIPDeviceTypeGetRequest21sp1V2(this OcipClient client, SystemSIPDeviceTypeGetRequest21sp1V2 request)
        {
            return await client.Call(request) as SystemSIPDeviceTypeGetResponse21sp1V2;
        }

        /// <summary>
        /// Request to modify a sip device type.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are not changeable:
        /// numberOfPorts
        /// SignalingAddressType
        /// isConferenceDevice
        /// isMusicOnHoldDevice
        /// isMobilityManagerDevice
        /// deviceTypeConfigurationOption
        /// staticLineOrdering
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// holdAnnouncementMethod
        /// supportRFC3398
        /// supportClientSessionInfo
        /// supportCallInfoConferenceSubscriptionURI
        /// supportRemotePartyInfo
        /// supportVisualDeviceManagement
        /// bypassMediaTreatment
        /// supportCauseParameter
        /// The following elements are only used in XS data mode and ignored in AS mode:
        /// enhancedForICS
        /// supports3G4GContinuity
        /// publishesOwnPresence
        /// locationNetwork
        /// roamingMode
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// When macInCert is set to true, macInNonRequestURI will be reset to false.
        /// When macInNonRequestURI is set to true, macInCert will be reset to false.
        /// Replaced by: SystemSIPDeviceTypeModifyRequest22
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeModifyRequest21(this OcipClient client, SystemSIPDeviceTypeModifyRequest21 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a system voice portal instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in IMS mode:
        /// publicUserIdentity, ignored in standalone mode if provided.
        /// 
        /// Replaced by: SystemSystemVoicePortalAddRequest21sp1.
        /// </summary>
        public static async Task<SuccessResponse> SystemSystemVoicePortalAddRequest(this OcipClient client, SystemSystemVoicePortalAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get a system voice portal instance.
        /// The response is either SystemSystemVoicePortalGetResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemSystemVoicePortalGetRequest21sp1.
        /// </summary>
        public static async Task<SystemSystemVoicePortalGetResponse> SystemSystemVoicePortalGetRequest(this OcipClient client, SystemSystemVoicePortalGetRequest request)
        {
            return await client.Call(request) as SystemSystemVoicePortalGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with the Trunk Group service.
        /// The response is either SystemTrunkGroupGetResponse21 or ErrorResponse.
        /// 
        /// Replaced by: SystemTrunkGroupGetRequest22
        /// </summary>
        public static async Task<SystemTrunkGroupGetResponse21> SystemTrunkGroupGetRequest21(this OcipClient client, SystemTrunkGroupGetRequest21 request)
        {
            return await client.Call(request) as SystemTrunkGroupGetResponse21;
        }

        /// <summary>
        /// Request the system level data associated with the Trunk Group service.
        /// The response is either SystemTrunkGroupGetResponse22 or ErrorResponse.
        /// 
        /// Replaced by: SystemTrunkGroupGetRequest23
        /// </summary>
        public static async Task<SystemTrunkGroupGetResponse22> SystemTrunkGroupGetRequest22(this OcipClient client, SystemTrunkGroupGetRequest22 request)
        {
            return await client.Call(request) as SystemTrunkGroupGetResponse22;
        }

        /// <summary>
        /// UserGetLoginInfoRequest is used to access login information for a user
        /// either by a userId or dn.
        /// The phone number may be any DN associated with a user.
        /// 
        /// The response is a UserGetLoginInfoResponse or an ErrorResponse
        /// 
        /// Replaced by UserGetLoginInfoRequest22.
        /// </summary>
        public static async Task<UserGetLoginInfoResponse> UserGetLoginInfoRequest(this OcipClient client, UserGetLoginInfoRequest request)
        {
            return await client.Call(request) as UserGetLoginInfoResponse;
        }

        /// <summary>
        /// UserGetLoginInfoRequest21sp1 is used to access login information for a user
        /// either by a userId, dn or lineport.
        /// The phone number may be any DN associated with a user.
        /// The lineport may be any lineport associated with a user.
        /// 
        /// The response is a UserGetLoginInfoResponse21sp1 or an ErrorResponse
        /// 
        /// Replaced by UserGetLoginInfoRequest22V2.
        /// </summary>
        public static async Task<UserGetLoginInfoResponse21sp1> UserGetLoginInfoRequest21sp1(this OcipClient client, UserGetLoginInfoRequest21sp1 request)
        {
            return await client.Call(request) as UserGetLoginInfoResponse21sp1;
        }

        /// <summary>
        /// UserGetLoginInfoRequest22 is used to access login information for a user
        /// either by a userId, dn or lineport.
        /// The phone number may be any DN associated with a user.
        /// The lineport may be any lineport associated with a user.
        /// 
        /// The response is a UserGetLoginInfoResponse22 or an ErrorResponse
        /// Replaced by UserGetLoginInfoRequest22V2.
        /// </summary>
        public static async Task<UserGetLoginInfoResponse22> UserGetLoginInfoRequest22(this OcipClient client, UserGetLoginInfoRequest22 request)
        {
            return await client.Call(request) as UserGetLoginInfoResponse22;
        }

        /// <summary>
        /// Request to get the user information. The response is either UserGetResponse21 or ErrorResponse.
        /// 
        /// Replaced by UserGetRequest21sp1
        /// </summary>
        public static async Task<UserGetResponse21> UserGetRequest21(this OcipClient client, UserGetRequest21 request)
        {
            return await client.Call(request) as UserGetResponse21;
        }

        /// <summary>
        /// Request to get the user information. The response is either UserGetResponse21sp1 or ErrorResponse.
        /// 
        /// Replaced by UserGetRequest22
        /// </summary>
        public static async Task<UserGetResponse21sp1> UserGetRequest21sp1(this OcipClient client, UserGetRequest21sp1 request)
        {
            return await client.Call(request) as UserGetResponse21sp1;
        }

        /// <summary>
        /// Request to get the user information. The response is either UserGetResponse21sp1V2 or ErrorResponse.
        /// 
        /// Replaced by UserGetRequest22V3 in AS data mode
        /// </summary>
        public static async Task<UserGetResponse21sp1V2> UserGetRequest21sp1V2(this OcipClient client, UserGetRequest21sp1V2 request)
        {
            return await client.Call(request) as UserGetResponse21sp1V2;
        }

        /// <summary>
        /// Request to get the user information. The response is either UserGetResponse22 or ErrorResponse.
        /// 
        /// Replaced by UserGetRequest22V2
        /// </summary>
        public static async Task<UserGetResponse22> UserGetRequest22(this OcipClient client, UserGetRequest22 request)
        {
            return await client.Call(request) as UserGetResponse22;
        }

        /// <summary>
        /// Request to get the user information. The response is either UserGetResponse22V2 or ErrorResponse.
        /// 
        /// Replaced by UserGetRequest22V3.
        /// </summary>
        public static async Task<UserGetResponse22V2> UserGetRequest22V2(this OcipClient client, UserGetRequest22V2 request)
        {
            return await client.Call(request) as UserGetResponse22V2;
        }


    }
}
