using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaDeprecatedASExtensions
    {

        /// <summary>
        /// AuthenticationRequest is 1st stage of the 2 stage OCI login process.
        /// 
        /// The response is either an AuthenticationResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use AuthenticationRequestAsync instead.")]
        public static async Task<AuthenticationResponse> AuthenticationRequest(this OcipClient client, AuthenticationRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as AuthenticationResponse;
        }

        /// <summary>
        /// AuthenticationRequest is 1st stage of the 2 stage OCI login process.
        /// 
        /// The response is either an AuthenticationResponse or an ErrorResponse.
        /// </summary>
        public static async Task<AuthenticationResponse> AuthenticationRequestAsync(this OcipClient client, AuthenticationRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as AuthenticationResponse;
        }
        /// <summary>
        /// Request the enterprise level data associated with Call Center.
        /// The response is either an EnterpriseCallCenterGetResponse17sp4 or an ErrorResponse.
        /// 
        /// Replaced by: EnterpriseCallCenterGetResponse23 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterpriseCallCenterGetRequest17sp4Async instead.")]
        public static async Task<EnterpriseCallCenterGetResponse17sp4> EnterpriseCallCenterGetRequest17sp4(this OcipClient client, EnterpriseCallCenterGetRequest17sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterpriseCallCenterGetResponse17sp4;
        }

        /// <summary>
        /// Request the enterprise level data associated with Call Center.
        /// The response is either an EnterpriseCallCenterGetResponse17sp4 or an ErrorResponse.
        /// 
        /// Replaced by: EnterpriseCallCenterGetResponse23 in AS data mode
        /// </summary>
        public static async Task<EnterpriseCallCenterGetResponse17sp4> EnterpriseCallCenterGetRequest17sp4Async(this OcipClient client, EnterpriseCallCenterGetRequest17sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterpriseCallCenterGetResponse17sp4;
        }
        /// <summary>
        /// Request a table containing the phone directory for an enterprise.
        /// The directory includes all users in the enterprise and all entries in the enterprise common phone list.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either EnterprisePhoneDirectoryGetListResponse18 or ErrorResponse.
        /// 
        /// Replaced By: EnterprisePhoneDirectoryGetPagedSortedListRequest
        /// </summary>
        [Obsolete("This method is deprecated. Use EnterprisePhoneDirectoryGetListRequest18Async instead.")]
        public static async Task<EnterprisePhoneDirectoryGetListResponse18> EnterprisePhoneDirectoryGetListRequest18(this OcipClient client, EnterprisePhoneDirectoryGetListRequest18 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as EnterprisePhoneDirectoryGetListResponse18;
        }

        /// <summary>
        /// Request a table containing the phone directory for an enterprise.
        /// The directory includes all users in the enterprise and all entries in the enterprise common phone list.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either EnterprisePhoneDirectoryGetListResponse18 or ErrorResponse.
        /// 
        /// Replaced By: EnterprisePhoneDirectoryGetPagedSortedListRequest
        /// </summary>
        public static async Task<EnterprisePhoneDirectoryGetListResponse18> EnterprisePhoneDirectoryGetListRequest18Async(this OcipClient client, EnterprisePhoneDirectoryGetListRequest18 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as EnterprisePhoneDirectoryGetListResponse18;
        }
        /// <summary>
        /// Request to add a group access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced by: GroupAccessDeviceAddRequest22
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceAddRequest14Async instead.")]
        public static async Task<SuccessResponse> GroupAccessDeviceAddRequest14(this OcipClient client, GroupAccessDeviceAddRequest14 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a group access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced by: GroupAccessDeviceAddRequest22
        /// </summary>
        public static async Task<SuccessResponse> GroupAccessDeviceAddRequest14Async(this OcipClient client, GroupAccessDeviceAddRequest14 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a group access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// hotlineContact
        /// useHotline
        /// groupExternalId
        /// deviceExternalId
        /// Replaced by: GroupAccessDeviceAddRequest22V2
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceAddRequest22Async instead.")]
        public static async Task<SuccessResponse> GroupAccessDeviceAddRequest22(this OcipClient client, GroupAccessDeviceAddRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a group access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// hotlineContact
        /// useHotline
        /// groupExternalId
        /// deviceExternalId
        /// Replaced by: GroupAccessDeviceAddRequest22V2
        /// </summary>
        public static async Task<SuccessResponse> GroupAccessDeviceAddRequest22Async(this OcipClient client, GroupAccessDeviceAddRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the configuration of a specified group access device.
        /// The response is either GroupAccessDeviceGetResponse18sp1 or ErrorResponse.
        /// 
        /// Replaced by: GroupAccessDeviceGetRequest22
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceGetRequest18sp1Async instead.")]
        public static async Task<GroupAccessDeviceGetResponse18sp1> GroupAccessDeviceGetRequest18sp1(this OcipClient client, GroupAccessDeviceGetRequest18sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAccessDeviceGetResponse18sp1;
        }

        /// <summary>
        /// Requests the configuration of a specified group access device.
        /// The response is either GroupAccessDeviceGetResponse18sp1 or ErrorResponse.
        /// 
        /// Replaced by: GroupAccessDeviceGetRequest22
        /// </summary>
        public static async Task<GroupAccessDeviceGetResponse18sp1> GroupAccessDeviceGetRequest18sp1Async(this OcipClient client, GroupAccessDeviceGetRequest18sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAccessDeviceGetResponse18sp1;
        }
        /// <summary>
        /// Requests the configuration of a specified group access device.
        /// The response is either GroupAccessDeviceGetResponse22 or ErrorResponse.
        /// Replaced by: GroupAccessDeviceGetRequest24
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceGetRequest22Async instead.")]
        public static async Task<GroupAccessDeviceGetResponse22> GroupAccessDeviceGetRequest22(this OcipClient client, GroupAccessDeviceGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAccessDeviceGetResponse22;
        }

        /// <summary>
        /// Requests the configuration of a specified group access device.
        /// The response is either GroupAccessDeviceGetResponse22 or ErrorResponse.
        /// Replaced by: GroupAccessDeviceGetRequest24
        /// </summary>
        public static async Task<GroupAccessDeviceGetResponse22> GroupAccessDeviceGetRequest22Async(this OcipClient client, GroupAccessDeviceGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAccessDeviceGetResponse22;
        }
        /// <summary>
        /// Requests the configuration of a specified group access device.
        /// The response is either GroupAccessDeviceGetResponse22V2 or ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// deviceExternalId
        /// Replaced by: GroupAccessDeviceGetRequest24 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceGetRequest22V2Async instead.")]
        public static async Task<GroupAccessDeviceGetResponse22V2> GroupAccessDeviceGetRequest22V2(this OcipClient client, GroupAccessDeviceGetRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAccessDeviceGetResponse22V2;
        }

        /// <summary>
        /// Requests the configuration of a specified group access device.
        /// The response is either GroupAccessDeviceGetResponse22V2 or ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// deviceExternalId
        /// Replaced by: GroupAccessDeviceGetRequest24 in AS data mode.
        /// </summary>
        public static async Task<GroupAccessDeviceGetResponse22V2> GroupAccessDeviceGetRequest22V2Async(this OcipClient client, GroupAccessDeviceGetRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAccessDeviceGetResponse22V2;
        }
        /// <summary>
        /// Requests the configuration of a specified group access device.
        /// The response is either GroupAccessDeviceGetResponse22V3 or ErrorResponse.
        /// Replaced by: GroupAccessDeviceGetRequest24
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceGetRequest22V3Async instead.")]
        public static async Task<GroupAccessDeviceGetResponse22V3> GroupAccessDeviceGetRequest22V3(this OcipClient client, GroupAccessDeviceGetRequest22V3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAccessDeviceGetResponse22V3;
        }

        /// <summary>
        /// Requests the configuration of a specified group access device.
        /// The response is either GroupAccessDeviceGetResponse22V3 or ErrorResponse.
        /// Replaced by: GroupAccessDeviceGetRequest24
        /// </summary>
        public static async Task<GroupAccessDeviceGetResponse22V3> GroupAccessDeviceGetRequest22V3Async(this OcipClient client, GroupAccessDeviceGetRequest22V3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAccessDeviceGetResponse22V3;
        }
        /// <summary>
        /// Requests the configuration of a specified group access device.
        /// The response is either GroupAccessDeviceGetUserListResponse or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaAccessDeviceEndpointPrivateIdentity
        /// 
        /// Replaced by: GroupAccessDeviceGetUserListRequest21sp1 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceGetUserListRequestAsync instead.")]
        public static async Task<GroupAccessDeviceGetUserListResponse> GroupAccessDeviceGetUserListRequest(this OcipClient client, GroupAccessDeviceGetUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAccessDeviceGetUserListResponse;
        }

        /// <summary>
        /// Requests the configuration of a specified group access device.
        /// The response is either GroupAccessDeviceGetUserListResponse or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaAccessDeviceEndpointPrivateIdentity
        /// 
        /// Replaced by: GroupAccessDeviceGetUserListRequest21sp1 in AS data mode.
        /// </summary>
        public static async Task<GroupAccessDeviceGetUserListResponse> GroupAccessDeviceGetUserListRequestAsync(this OcipClient client, GroupAccessDeviceGetUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAccessDeviceGetUserListResponse;
        }
        /// <summary>
        /// Request to modify a specified group access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// hotlineContact
        /// useHotline
        /// deviceExternalId
        /// Replaced by: GroupAccessDeviceModifyRequest22
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAccessDeviceModifyRequest14Async instead.")]
        public static async Task<SuccessResponse> GroupAccessDeviceModifyRequest14(this OcipClient client, GroupAccessDeviceModifyRequest14 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a specified group access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// hotlineContact
        /// useHotline
        /// deviceExternalId
        /// Replaced by: GroupAccessDeviceModifyRequest22
        /// </summary>
        public static async Task<SuccessResponse> GroupAccessDeviceModifyRequest14Async(this OcipClient client, GroupAccessDeviceModifyRequest14 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in Amplify data mode and ignored in AS and XS data mode:
        /// servicePolicy,
        /// callProcessingSliceId,
        /// provisioningSliceId,
        /// subscriberPartition.
        /// When the callProcessingSliceId or provisioningSliceId is not specified in the AmplifyDataMode,
        /// the default slice Id is assigned to the Group.
        /// Only Provisioning admin and above can change the callProcessingSliceId,
        /// provisioningSliceId, and subscriberPartition.
        /// 
        /// The following elements are only used in Amplify and XS data mode and ignored in AS mode:
        /// preferredDataCenter.
        /// Only Provisioning admin and above can change the preferredDataCenter.
        /// 
        /// The following elements are only used in XS data mode and ignored in Amplify and AS data mode:
        /// defaultUserCallingLineIdPhoneNumber.
        /// 
        /// Replaced by: GroupConsolidatedAddRequest in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAddRequest(this OcipClient client, GroupAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in Amplify data mode and ignored in AS and XS data mode:
        /// servicePolicy,
        /// callProcessingSliceId,
        /// provisioningSliceId,
        /// subscriberPartition.
        /// When the callProcessingSliceId or provisioningSliceId is not specified in the AmplifyDataMode,
        /// the default slice Id is assigned to the Group.
        /// Only Provisioning admin and above can change the callProcessingSliceId,
        /// provisioningSliceId, and subscriberPartition.
        /// 
        /// The following elements are only used in Amplify and XS data mode and ignored in AS mode:
        /// preferredDataCenter.
        /// Only Provisioning admin and above can change the preferredDataCenter.
        /// 
        /// The following elements are only used in XS data mode and ignored in Amplify and AS data mode:
        /// defaultUserCallingLineIdPhoneNumber.
        /// 
        /// Replaced by: GroupConsolidatedAddRequest in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupAddRequestAsync(this OcipClient client, GroupAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the Group administrator's policy settings.
        /// The response is either GroupAdminGetPolicyResponse18 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAdminGetPolicyRequest18Async instead.")]
        public static async Task<GroupAdminGetPolicyResponse18> GroupAdminGetPolicyRequest18(this OcipClient client, GroupAdminGetPolicyRequest18 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAdminGetPolicyResponse18;
        }

        /// <summary>
        /// Requests the Group administrator's policy settings.
        /// The response is either GroupAdminGetPolicyResponse18 or ErrorResponse.
        /// </summary>
        public static async Task<GroupAdminGetPolicyResponse18> GroupAdminGetPolicyRequest18Async(this OcipClient client, GroupAdminGetPolicyRequest18 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAdminGetPolicyResponse18;
        }
        /// <summary>
        /// Requests the Group administrator's policy settings.
        /// The response is either GroupAdminGetPolicyResponse19sp1 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAdminGetPolicyRequest19sp1Async instead.")]
        public static async Task<GroupAdminGetPolicyResponse19sp1> GroupAdminGetPolicyRequest19sp1(this OcipClient client, GroupAdminGetPolicyRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAdminGetPolicyResponse19sp1;
        }

        /// <summary>
        /// Requests the Group administrator's policy settings.
        /// The response is either GroupAdminGetPolicyResponse19sp1 or ErrorResponse.
        /// </summary>
        public static async Task<GroupAdminGetPolicyResponse19sp1> GroupAdminGetPolicyRequest19sp1Async(this OcipClient client, GroupAdminGetPolicyRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAdminGetPolicyResponse19sp1;
        }
        /// <summary>
        /// Get a group administrators profile.
        /// The response is either a GroupAdminGetResponse or an ErrorResponse.
        /// Replaced by GroupAdminGetRequest21sp1.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAdminGetRequestAsync instead.")]
        public static async Task<GroupAdminGetResponse> GroupAdminGetRequest(this OcipClient client, GroupAdminGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAdminGetResponse;
        }

        /// <summary>
        /// Get a group administrators profile.
        /// The response is either a GroupAdminGetResponse or an ErrorResponse.
        /// Replaced by GroupAdminGetRequest21sp1.
        /// </summary>
        public static async Task<GroupAdminGetResponse> GroupAdminGetRequestAsync(this OcipClient client, GroupAdminGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAdminGetResponse;
        }
        /// <summary>
        /// Get a group administrators profile.
        /// The response is either a GroupAdminGetResponse21sp1 or an ErrorResponse.
        /// Replaced by: GroupAdminGetRequest22.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAdminGetRequest21sp1Async instead.")]
        public static async Task<GroupAdminGetResponse21sp1> GroupAdminGetRequest21sp1(this OcipClient client, GroupAdminGetRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAdminGetResponse21sp1;
        }

        /// <summary>
        /// Get a group administrators profile.
        /// The response is either a GroupAdminGetResponse21sp1 or an ErrorResponse.
        /// Replaced by: GroupAdminGetRequest22.
        /// </summary>
        public static async Task<GroupAdminGetResponse21sp1> GroupAdminGetRequest21sp1Async(this OcipClient client, GroupAdminGetRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAdminGetResponse21sp1;
        }
        /// <summary>
        /// Add a Auto Attendant instance to a group.
        /// The domain is required in the serviceUserId.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// type, use value "Basic" in XS data mode
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// holidayMenu
        /// The following elements are only valid for Standard Auto Attendants:
        /// holidayMenu
        /// 
        /// Replaced by: GroupAutoAttendantAddInstanceRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantAddInstanceRequest19Async instead.")]
        public static async Task<SuccessResponse> GroupAutoAttendantAddInstanceRequest19(this OcipClient client, GroupAutoAttendantAddInstanceRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Auto Attendant instance to a group.
        /// The domain is required in the serviceUserId.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// type, use value "Basic" in XS data mode
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// holidayMenu
        /// The following elements are only valid for Standard Auto Attendants:
        /// holidayMenu
        /// 
        /// Replaced by: GroupAutoAttendantAddInstanceRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantAddInstanceRequest19Async(this OcipClient client, GroupAutoAttendantAddInstanceRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get all the information of a Auto Attendant instance.
        /// The response is either GroupAutoAttendantGetInstanceResponse19 or ErrorResponse.
        /// 
        /// Replaced by: GroupAutoAttendantGetInstanceRequest19sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantGetInstanceRequest19Async instead.")]
        public static async Task<GroupAutoAttendantGetInstanceResponse19> GroupAutoAttendantGetInstanceRequest19(this OcipClient client, GroupAutoAttendantGetInstanceRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAutoAttendantGetInstanceResponse19;
        }

        /// <summary>
        /// Request to get all the information of a Auto Attendant instance.
        /// The response is either GroupAutoAttendantGetInstanceResponse19 or ErrorResponse.
        /// 
        /// Replaced by: GroupAutoAttendantGetInstanceRequest19sp1 in AS data mode
        /// </summary>
        public static async Task<GroupAutoAttendantGetInstanceResponse19> GroupAutoAttendantGetInstanceRequest19Async(this OcipClient client, GroupAutoAttendantGetInstanceRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAutoAttendantGetInstanceResponse19;
        }
        /// <summary>
        /// Request to get all the information of a Auto Attendant instance.
        /// The response is either GroupAutoAttendantGetInstanceResponse19sp1 or ErrorResponse.
        /// 
        /// Replaced by: GroupAutoAttendantGetInstanceRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantGetInstanceRequest19sp1Async instead.")]
        public static async Task<GroupAutoAttendantGetInstanceResponse19sp1> GroupAutoAttendantGetInstanceRequest19sp1(this OcipClient client, GroupAutoAttendantGetInstanceRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAutoAttendantGetInstanceResponse19sp1;
        }

        /// <summary>
        /// Request to get all the information of a Auto Attendant instance.
        /// The response is either GroupAutoAttendantGetInstanceResponse19sp1 or ErrorResponse.
        /// 
        /// Replaced by: GroupAutoAttendantGetInstanceRequest20 in AS data mode
        /// </summary>
        public static async Task<GroupAutoAttendantGetInstanceResponse19sp1> GroupAutoAttendantGetInstanceRequest19sp1Async(this OcipClient client, GroupAutoAttendantGetInstanceRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAutoAttendantGetInstanceResponse19sp1;
        }
        /// <summary>
        /// Request to modify an Auto Attendant instance.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode and not returned in XS data mode:
        /// holidayMenu.
        /// The following elementsare only valid for Standard Auto Attendants:
        /// holidayMenu
        /// 
        /// Replaced by: GroupAutoAttendantModifyInstanceRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantModifyInstanceRequest17sp1Async instead.")]
        public static async Task<SuccessResponse> GroupAutoAttendantModifyInstanceRequest17sp1(this OcipClient client, GroupAutoAttendantModifyInstanceRequest17sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify an Auto Attendant instance.
        /// Only Group and Enterprise level schedules are accepted.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode and not returned in XS data mode:
        /// holidayMenu.
        /// The following elementsare only valid for Standard Auto Attendants:
        /// holidayMenu
        /// 
        /// Replaced by: GroupAutoAttendantModifyInstanceRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantModifyInstanceRequest17sp1Async(this OcipClient client, GroupAutoAttendantModifyInstanceRequest17sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add an Auto Attendant submenu instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// 
        /// Replaced by: GroupAutoAttendantSubmenuAddRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantSubmenuAddRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAutoAttendantSubmenuAddRequest(this OcipClient client, GroupAutoAttendantSubmenuAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add an Auto Attendant submenu instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// 
        /// Replaced by: GroupAutoAttendantSubmenuAddRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantSubmenuAddRequestAsync(this OcipClient client, GroupAutoAttendantSubmenuAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get an Auto Attendant submenu instance.
        /// The response is either GroupAutoAttendantSubmenuGetResponse or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// 
        /// Replaced by: GroupAutoAttendantSubmenuGetRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantSubmenuGetRequestAsync instead.")]
        public static async Task<GroupAutoAttendantSubmenuGetResponse> GroupAutoAttendantSubmenuGetRequest(this OcipClient client, GroupAutoAttendantSubmenuGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupAutoAttendantSubmenuGetResponse;
        }

        /// <summary>
        /// Request to get an Auto Attendant submenu instance.
        /// The response is either GroupAutoAttendantSubmenuGetResponse or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// 
        /// Replaced by: GroupAutoAttendantSubmenuGetRequest20 in AS data mode
        /// </summary>
        public static async Task<GroupAutoAttendantSubmenuGetResponse> GroupAutoAttendantSubmenuGetRequestAsync(this OcipClient client, GroupAutoAttendantSubmenuGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupAutoAttendantSubmenuGetResponse;
        }
        /// <summary>
        /// Request to modify an Auto Attendant submenu instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// 
        /// Replaced by: GroupAutoAttendantSubmenuModifyRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupAutoAttendantSubmenuModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupAutoAttendantSubmenuModifyRequest(this OcipClient client, GroupAutoAttendantSubmenuModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify an Auto Attendant submenu instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// This request is only valid for Standard auto attendants.
        /// 
        /// Replaced by: GroupAutoAttendantSubmenuModifyRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupAutoAttendantSubmenuModifyRequestAsync(this OcipClient client, GroupAutoAttendantSubmenuModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get all the information of a BroadWorks Anywhere instance.
        /// The response is either GroupBroadWorksAnywhereGetInstanceResponse17 or ErrorResponse.
        /// 
        /// Replaced by: GroupBroadWorksAnywhereGetInstanceRequest19sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupBroadWorksAnywhereGetInstanceRequest17Async instead.")]
        public static async Task<GroupBroadWorksAnywhereGetInstanceResponse17> GroupBroadWorksAnywhereGetInstanceRequest17(this OcipClient client, GroupBroadWorksAnywhereGetInstanceRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupBroadWorksAnywhereGetInstanceResponse17;
        }

        /// <summary>
        /// Request to get all the information of a BroadWorks Anywhere instance.
        /// The response is either GroupBroadWorksAnywhereGetInstanceResponse17 or ErrorResponse.
        /// 
        /// Replaced by: GroupBroadWorksAnywhereGetInstanceRequest19sp1 in AS data mode
        /// </summary>
        public static async Task<GroupBroadWorksAnywhereGetInstanceResponse17> GroupBroadWorksAnywhereGetInstanceRequest17Async(this OcipClient client, GroupBroadWorksAnywhereGetInstanceRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupBroadWorksAnywhereGetInstanceResponse17;
        }
        /// <summary>
        /// Get a call center's announcement settings.
        /// The response is either a GroupCallCenterGetAnnouncementResponse19 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetAnnouncementRequest19Async instead.")]
        public static async Task<GroupCallCenterGetAnnouncementResponse19> GroupCallCenterGetAnnouncementRequest19(this OcipClient client, GroupCallCenterGetAnnouncementRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetAnnouncementResponse19;
        }

        /// <summary>
        /// Get a call center's announcement settings.
        /// The response is either a GroupCallCenterGetAnnouncementResponse19 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetAnnouncementResponse19> GroupCallCenterGetAnnouncementRequest19Async(this OcipClient client, GroupCallCenterGetAnnouncementRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetAnnouncementResponse19;
        }
        /// <summary>
        /// Get a call center's announcement settings.
        /// The response is either a GroupCallCenterGetAnnouncementResponse20 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetAnnouncementRequest20Async instead.")]
        public static async Task<GroupCallCenterGetAnnouncementResponse20> GroupCallCenterGetAnnouncementRequest20(this OcipClient client, GroupCallCenterGetAnnouncementRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetAnnouncementResponse20;
        }

        /// <summary>
        /// Get a call center's announcement settings.
        /// The response is either a GroupCallCenterGetAnnouncementResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterGetAnnouncementResponse20> GroupCallCenterGetAnnouncementRequest20Async(this OcipClient client, GroupCallCenterGetAnnouncementRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetAnnouncementResponse20;
        }
        /// <summary>
        /// Request the Group level data associated with Call Center.
        /// The response is either a GroupCallCenterGetResponse17sp4 or an
        /// ErrorResponse.
        /// Replaced by: GroupCallCenterGetRequest23
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterGetRequest17sp4Async instead.")]
        public static async Task<GroupCallCenterGetResponse17sp4> GroupCallCenterGetRequest17sp4(this OcipClient client, GroupCallCenterGetRequest17sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterGetResponse17sp4;
        }

        /// <summary>
        /// Request the Group level data associated with Call Center.
        /// The response is either a GroupCallCenterGetResponse17sp4 or an
        /// ErrorResponse.
        /// Replaced by: GroupCallCenterGetRequest23
        /// </summary>
        public static async Task<GroupCallCenterGetResponse17sp4> GroupCallCenterGetRequest17sp4Async(this OcipClient client, GroupCallCenterGetRequest17sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterGetResponse17sp4;
        }
        /// <summary>
        /// Modify a call center's announcement settings.
        /// The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterModifyAnnouncementRequest17Async instead.")]
        public static async Task<SuccessResponse> GroupCallCenterModifyAnnouncementRequest17(this OcipClient client, GroupCallCenterModifyAnnouncementRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call center's announcement settings.
        /// The response is either a SuccessResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterModifyAnnouncementRequest17Async(this OcipClient client, GroupCallCenterModifyAnnouncementRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a call center's overflow settings.
        /// The response is either a GroupCallCenterOverflowGetResponse17 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterOverflowGetRequest17Async instead.")]
        public static async Task<GroupCallCenterOverflowGetResponse17> GroupCallCenterOverflowGetRequest17(this OcipClient client, GroupCallCenterOverflowGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallCenterOverflowGetResponse17;
        }

        /// <summary>
        /// Get a call center's overflow settings.
        /// The response is either a GroupCallCenterOverflowGetResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupCallCenterOverflowGetResponse17> GroupCallCenterOverflowGetRequest17Async(this OcipClient client, GroupCallCenterOverflowGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallCenterOverflowGetResponse17;
        }
        /// <summary>
        /// Modify a call center's overflow settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallCenterOverflowModifyRequest17Async instead.")]
        public static async Task<SuccessResponse> GroupCallCenterOverflowModifyRequest17(this OcipClient client, GroupCallCenterOverflowModifyRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a call center's overflow settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupCallCenterOverflowModifyRequest17Async(this OcipClient client, GroupCallCenterOverflowModifyRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse21sp2 or an ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy,enterpriseCallsCLIDPolicy, groupCallsCLIDPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName, allowDepartmentCLIDNameOverride)
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls, maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls, maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth, maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations)
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan, overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing, routeOverrideDomain, routeOverridePrefix)
        /// 
        /// Replaced by: GroupCallProcessingGetPolicyRequest22 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallProcessingGetPolicyRequest21sp2Async instead.")]
        public static async Task<GroupCallProcessingGetPolicyResponse21sp2> GroupCallProcessingGetPolicyRequest21sp2(this OcipClient client, GroupCallProcessingGetPolicyRequest21sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallProcessingGetPolicyResponse21sp2;
        }

        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse21sp2 or an ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy,enterpriseCallsCLIDPolicy, groupCallsCLIDPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName, allowDepartmentCLIDNameOverride)
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls, maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls, maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth, maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations)
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan, overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing, routeOverrideDomain, routeOverridePrefix)
        /// 
        /// Replaced by: GroupCallProcessingGetPolicyRequest22 in AS data mode
        /// </summary>
        public static async Task<GroupCallProcessingGetPolicyResponse21sp2> GroupCallProcessingGetPolicyRequest21sp2Async(this OcipClient client, GroupCallProcessingGetPolicyRequest21sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallProcessingGetPolicyResponse21sp2;
        }
        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse22 or an ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy,enterpriseCallsCLIDPolicy, groupCallsCLIDPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName, allowDepartmentCLIDNameOverride)
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls,
        /// maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls, maxCallTimeForUnansweredCallsMinutes,
        /// useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth, maxRedirectionDepth,
        /// useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations,
        /// useMaxConcurrentTerminatingAlertingRequests, maxConcurrentTerminatingAlertingRequests)
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan, overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
        /// Replaced by: GroupCallProcessingGetPolicyRequest22V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallProcessingGetPolicyRequest22Async instead.")]
        public static async Task<GroupCallProcessingGetPolicyResponse22> GroupCallProcessingGetPolicyRequest22(this OcipClient client, GroupCallProcessingGetPolicyRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallProcessingGetPolicyResponse22;
        }

        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse22 or an ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy,enterpriseCallsCLIDPolicy, groupCallsCLIDPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName, allowDepartmentCLIDNameOverride)
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls,
        /// maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls, maxCallTimeForUnansweredCallsMinutes,
        /// useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth, maxRedirectionDepth,
        /// useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations,
        /// useMaxConcurrentTerminatingAlertingRequests, maxConcurrentTerminatingAlertingRequests)
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan, overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
        /// Replaced by: GroupCallProcessingGetPolicyRequest22V2 in AS data mode.
        /// </summary>
        public static async Task<GroupCallProcessingGetPolicyResponse22> GroupCallProcessingGetPolicyRequest22Async(this OcipClient client, GroupCallProcessingGetPolicyRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallProcessingGetPolicyResponse22;
        }
        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse22V2 or an ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy,enterpriseCallsCLIDPolicy, groupCallsCLIDPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName, allowDepartmentCLIDNameOverride)
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls,
        /// maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls, maxCallTimeForUnansweredCallsMinutes,
        /// useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth, maxRedirectionDepth,
        /// useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations,
        /// useMaxConcurrentTerminatingAlertingRequests, maxConcurrentTerminatingAlertingRequests)
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan, overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
        /// Replaced by: GroupCallProcessingGetPolicyRequest22V3 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCallProcessingGetPolicyRequest22V2Async instead.")]
        public static async Task<GroupCallProcessingGetPolicyResponse22V2> GroupCallProcessingGetPolicyRequest22V2(this OcipClient client, GroupCallProcessingGetPolicyRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCallProcessingGetPolicyResponse22V2;
        }

        /// <summary>
        /// Request the group level data associated with Call Processing Policy.
        /// The response is either a GroupCallProcessingGetPolicyResponse22V2 or an ErrorResponse.
        /// The useGroupCLIDSetting attribute controls the CLID settings
        /// (clidPolicy,enterpriseCallsCLIDPolicy, groupCallsCLIDPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName, allowDepartmentCLIDNameOverride)
        /// The useGroupMediaSetting attribute controls the Media settings
        /// (medisPolicySelection, supportedMediaSetName)
        /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
        /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
        /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls,
        /// maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls, maxCallTimeForUnansweredCallsMinutes,
        /// useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth, maxRedirectionDepth,
        /// useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations,
        /// useMaxConcurrentTerminatingAlertingRequests, maxConcurrentTerminatingAlertingRequests)
        /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
        /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
        /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan, overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
        /// Replaced by: GroupCallProcessingGetPolicyRequest22V3 in AS data mode.
        /// </summary>
        public static async Task<GroupCallProcessingGetPolicyResponse22V2> GroupCallProcessingGetPolicyRequest22V2Async(this OcipClient client, GroupCallProcessingGetPolicyRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCallProcessingGetPolicyResponse22V2;
        }
        /// <summary>
        /// Add a list of Communication Barring Authorization codes to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupCommunicationBarringAuthorizationCodeAddListRequest21sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCommunicationBarringAuthorizationCodeAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupCommunicationBarringAuthorizationCodeAddListRequest(this OcipClient client, GroupCommunicationBarringAuthorizationCodeAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of Communication Barring Authorization codes to a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupCommunicationBarringAuthorizationCodeAddListRequest21sp1 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupCommunicationBarringAuthorizationCodeAddListRequestAsync(this OcipClient client, GroupCommunicationBarringAuthorizationCodeAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of Communication Barring Authorization Codes for a group.
        /// The response is either a GroupCommunicationBarringAuthorizationCodeGetListResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupCommunicationBarringAuthorizationCodeGetListRequest21sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCommunicationBarringAuthorizationCodeGetListRequestAsync instead.")]
        public static async Task<GroupCommunicationBarringAuthorizationCodeGetListResponse> GroupCommunicationBarringAuthorizationCodeGetListRequest(this OcipClient client, GroupCommunicationBarringAuthorizationCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCommunicationBarringAuthorizationCodeGetListResponse;
        }

        /// <summary>
        /// Get a list of Communication Barring Authorization Codes for a group.
        /// The response is either a GroupCommunicationBarringAuthorizationCodeGetListResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupCommunicationBarringAuthorizationCodeGetListRequest21sp1 in AS data mode
        /// </summary>
        public static async Task<GroupCommunicationBarringAuthorizationCodeGetListResponse> GroupCommunicationBarringAuthorizationCodeGetListRequestAsync(this OcipClient client, GroupCommunicationBarringAuthorizationCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCommunicationBarringAuthorizationCodeGetListResponse;
        }
        /// <summary>
        /// Get the group's custom ring back service settings.
        /// The response is either a GroupCustomRingbackGroupGetResponse16 or an ErrorResponse.
        /// 
        /// Replaced by: GroupCustomRingbackGroupGetRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCustomRingbackGroupGetRequest16Async instead.")]
        public static async Task<GroupCustomRingbackGroupGetResponse16> GroupCustomRingbackGroupGetRequest16(this OcipClient client, GroupCustomRingbackGroupGetRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupCustomRingbackGroupGetResponse16;
        }

        /// <summary>
        /// Get the group's custom ring back service settings.
        /// The response is either a GroupCustomRingbackGroupGetResponse16 or an ErrorResponse.
        /// 
        /// Replaced by: GroupCustomRingbackGroupGetRequest20 in AS data mode
        /// </summary>
        public static async Task<GroupCustomRingbackGroupGetResponse16> GroupCustomRingbackGroupGetRequest16Async(this OcipClient client, GroupCustomRingbackGroupGetRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupCustomRingbackGroupGetResponse16;
        }
        /// <summary>
        /// Modify the group's custom ring back service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupCustomRingbackGroupModifyRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupCustomRingbackGroupModifyRequest16Async instead.")]
        public static async Task<SuccessResponse> GroupCustomRingbackGroupModifyRequest16(this OcipClient client, GroupCustomRingbackGroupModifyRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group's custom ring back service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupCustomRingbackGroupModifyRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupCustomRingbackGroupModifyRequest16Async(this OcipClient client, GroupCustomRingbackGroupModifyRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the Group level data associated with Dial Plan Policy.
        /// The response is either a GroupDialPlanPolicyGetResponse17 or an ErrorResponse.
        /// 
        /// Replaced by: GroupDialPlanPolicyGetRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupDialPlanPolicyGetRequest17Async instead.")]
        public static async Task<GroupDialPlanPolicyGetResponse17> GroupDialPlanPolicyGetRequest17(this OcipClient client, GroupDialPlanPolicyGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupDialPlanPolicyGetResponse17;
        }

        /// <summary>
        /// Request the Group level data associated with Dial Plan Policy.
        /// The response is either a GroupDialPlanPolicyGetResponse17 or an ErrorResponse.
        /// 
        /// Replaced by: GroupDialPlanPolicyGetRequest22 in AS data mode.
        /// </summary>
        public static async Task<GroupDialPlanPolicyGetResponse17> GroupDialPlanPolicyGetRequest17Async(this OcipClient client, GroupDialPlanPolicyGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupDialPlanPolicyGetResponse17;
        }
        /// <summary>
        /// Request the group's extension length.
        /// The response is either a GroupExtensionLengthGetResponse17 or an ErrorResponse.
        /// 
        /// Replaced by: GroupExtensionLengthGetRequest22 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupExtensionLengthGetRequest17Async instead.")]
        public static async Task<GroupExtensionLengthGetResponse17> GroupExtensionLengthGetRequest17(this OcipClient client, GroupExtensionLengthGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupExtensionLengthGetResponse17;
        }

        /// <summary>
        /// Request the group's extension length.
        /// The response is either a GroupExtensionLengthGetResponse17 or an ErrorResponse.
        /// 
        /// Replaced by: GroupExtensionLengthGetRequest22 in AS data mode
        /// </summary>
        public static async Task<GroupExtensionLengthGetResponse17> GroupExtensionLengthGetRequest17Async(this OcipClient client, GroupExtensionLengthGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupExtensionLengthGetResponse17;
        }
        /// <summary>
        /// Get group FAC code level and the list of feature access codes for a group.
        /// The response is either a GroupFeatureAccessCodeGetResponse or an ErrorResponse.
        /// Returned Feature Access Codes may be group specific, or Service Provider Feature Access Codes, depending on FAC code level.
        /// 
        /// Replaced by: GroupFeatureAccessCodeGetRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFeatureAccessCodeGetRequestAsync instead.")]
        public static async Task<GroupFeatureAccessCodeGetResponse> GroupFeatureAccessCodeGetRequest(this OcipClient client, GroupFeatureAccessCodeGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupFeatureAccessCodeGetResponse;
        }

        /// <summary>
        /// Get group FAC code level and the list of feature access codes for a group.
        /// The response is either a GroupFeatureAccessCodeGetResponse or an ErrorResponse.
        /// Returned Feature Access Codes may be group specific, or Service Provider Feature Access Codes, depending on FAC code level.
        /// 
        /// Replaced by: GroupFeatureAccessCodeGetRequest21 in AS data mode
        /// </summary>
        public static async Task<GroupFeatureAccessCodeGetResponse> GroupFeatureAccessCodeGetRequestAsync(this OcipClient client, GroupFeatureAccessCodeGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupFeatureAccessCodeGetResponse;
        }
        /// <summary>
        /// Modify group FAC code level and the list of feature access codes for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Note: choice element is only valid when useFeatureAccessCodeLevel is set to "Group", otherwise an ErrorResponse will be returned.
        /// 
        /// Replaced by: GroupFeatureAccessCodeModifyRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupFeatureAccessCodeModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupFeatureAccessCodeModifyRequest(this OcipClient client, GroupFeatureAccessCodeModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify group FAC code level and the list of feature access codes for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Note: choice element is only valid when useFeatureAccessCodeLevel is set to "Group", otherwise an ErrorResponse will be returned.
        /// 
        /// Replaced by: GroupFeatureAccessCodeModifyRequest21 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupFeatureAccessCodeModifyRequestAsync(this OcipClient client, GroupFeatureAccessCodeModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the profile for a group.
        /// The response is either a GroupGetResponse22 or an ErrorResponse.
        /// 
        /// Replaced by GroupGetRequest22V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGetRequest22Async instead.")]
        public static async Task<GroupGetResponse22> GroupGetRequest22(this OcipClient client, GroupGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupGetResponse22;
        }

        /// <summary>
        /// Get the profile for a group.
        /// The response is either a GroupGetResponse22 or an ErrorResponse.
        /// 
        /// Replaced by GroupGetRequest22V2 in AS data mode.
        /// </summary>
        public static async Task<GroupGetResponse22> GroupGetRequest22Async(this OcipClient client, GroupGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupGetResponse22;
        }
        /// <summary>
        /// Get the profile for a group.
        /// The response is either a GroupGetResponse22V2 or an ErrorResponse.
        /// 
        /// Replaced by: GroupGetRequest22V3
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGetRequest22V2Async instead.")]
        public static async Task<GroupGetResponse22V2> GroupGetRequest22V2(this OcipClient client, GroupGetRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupGetResponse22V2;
        }

        /// <summary>
        /// Get the profile for a group.
        /// The response is either a GroupGetResponse22V2 or an ErrorResponse.
        /// 
        /// Replaced by: GroupGetRequest22V3
        /// </summary>
        public static async Task<GroupGetResponse22V2> GroupGetRequest22V2Async(this OcipClient client, GroupGetRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupGetResponse22V2;
        }
        /// <summary>
        /// Get the profile for a group.
        /// The response is either a GroupGetResponse22V3 or an ErrorResponse.
        /// 
        /// Replaced by GroupGetRequest22V4
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGetRequest22V3Async instead.")]
        public static async Task<GroupGetResponse22V3> GroupGetRequest22V3(this OcipClient client, GroupGetRequest22V3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupGetResponse22V3;
        }

        /// <summary>
        /// Get the profile for a group.
        /// The response is either a GroupGetResponse22V3 or an ErrorResponse.
        /// 
        /// Replaced by GroupGetRequest22V4
        /// </summary>
        public static async Task<GroupGetResponse22V3> GroupGetRequest22V3Async(this OcipClient client, GroupGetRequest22V3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupGetResponse22V3;
        }
        /// <summary>
        /// Get the profile for a group.
        /// The response is either a GroupGetResponse22V4 or an ErrorResponse.
        /// 
        /// Replaced by: GroupGetRequest22V5 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGetRequest22V4Async instead.")]
        public static async Task<GroupGetResponse22V4> GroupGetRequest22V4(this OcipClient client, GroupGetRequest22V4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupGetResponse22V4;
        }

        /// <summary>
        /// Get the profile for a group.
        /// The response is either a GroupGetResponse22V4 or an ErrorResponse.
        /// 
        /// Replaced by: GroupGetRequest22V5 in AS data mode.
        /// </summary>
        public static async Task<GroupGetResponse22V4> GroupGetRequest22V4Async(this OcipClient client, GroupGetRequest22V4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupGetResponse22V4;
        }
        /// <summary>
        /// Request the maximum number of target users per paging group configured for a group.
        /// The response is either a GroupGroupPagingTargetsCapacityGetResponse
        /// or an ErrorResponse.
        /// 
        /// Replaced by: GroupGroupPagingTargetsCapacityGetRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGroupPagingTargetsCapacityGetRequestAsync instead.")]
        public static async Task<GroupGroupPagingTargetsCapacityGetResponse> GroupGroupPagingTargetsCapacityGetRequest(this OcipClient client, GroupGroupPagingTargetsCapacityGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupGroupPagingTargetsCapacityGetResponse;
        }

        /// <summary>
        /// Request the maximum number of target users per paging group configured for a group.
        /// The response is either a GroupGroupPagingTargetsCapacityGetResponse
        /// or an ErrorResponse.
        /// 
        /// Replaced by: GroupGroupPagingTargetsCapacityGetRequest22 in AS data mode.
        /// </summary>
        public static async Task<GroupGroupPagingTargetsCapacityGetResponse> GroupGroupPagingTargetsCapacityGetRequestAsync(this OcipClient client, GroupGroupPagingTargetsCapacityGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupGroupPagingTargetsCapacityGetResponse;
        }
        /// <summary>
        /// Modify the maximum number of target users per paging group configured for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupGroupPagingTargetsCapacityModifyRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupGroupPagingTargetsCapacityModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupGroupPagingTargetsCapacityModifyRequest(this OcipClient client, GroupGroupPagingTargetsCapacityModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the maximum number of target users per paging group configured for a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupGroupPagingTargetsCapacityModifyRequest22 in AS data mode.
        /// </summary>
        public static async Task<SuccessResponse> GroupGroupPagingTargetsCapacityModifyRequestAsync(this OcipClient client, GroupGroupPagingTargetsCapacityModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Hunt Group instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// useSystemHuntGroupCLIDSetting, use value "true" in XS data mode
        /// includeHuntGroupNameInCLID, use value "true" in XS data mode
        /// 
        /// Replaced by: GroupHuntGroupAddInstanceRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupHuntGroupAddInstanceRequest19Async instead.")]
        public static async Task<SuccessResponse> GroupHuntGroupAddInstanceRequest19(this OcipClient client, GroupHuntGroupAddInstanceRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Hunt Group instance to a group.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// useSystemHuntGroupCLIDSetting, use value "true" in XS data mode
        /// includeHuntGroupNameInCLID, use value "true" in XS data mode
        /// 
        /// Replaced by: GroupHuntGroupAddInstanceRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupHuntGroupAddInstanceRequest19Async(this OcipClient client, GroupHuntGroupAddInstanceRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get all the information of a Hunt Group instance.
        /// The response is either GroupHuntGroupGetInstanceResponse19 or ErrorResponse.
        /// 
        /// Replaced by: GroupHuntGroupGetInstanceRequest19sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupHuntGroupGetInstanceRequest19Async instead.")]
        public static async Task<GroupHuntGroupGetInstanceResponse19> GroupHuntGroupGetInstanceRequest19(this OcipClient client, GroupHuntGroupGetInstanceRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupHuntGroupGetInstanceResponse19;
        }

        /// <summary>
        /// Request to get all the information of a Hunt Group instance.
        /// The response is either GroupHuntGroupGetInstanceResponse19 or ErrorResponse.
        /// 
        /// Replaced by: GroupHuntGroupGetInstanceRequest19sp1 in AS data mode
        /// </summary>
        public static async Task<GroupHuntGroupGetInstanceResponse19> GroupHuntGroupGetInstanceRequest19Async(this OcipClient client, GroupHuntGroupGetInstanceRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupHuntGroupGetInstanceResponse19;
        }
        /// <summary>
        /// Get the Integrated IMP service attributes for the group.
        /// The response is either GroupIntegratedIMPGetResponse or ErrorResponse.
        /// 
        /// Replaced by: GroupIntegratedIMPGetRequest21sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupIntegratedIMPGetRequestAsync instead.")]
        public static async Task<GroupIntegratedIMPGetResponse> GroupIntegratedIMPGetRequest(this OcipClient client, GroupIntegratedIMPGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupIntegratedIMPGetResponse;
        }

        /// <summary>
        /// Get the Integrated IMP service attributes for the group.
        /// The response is either GroupIntegratedIMPGetResponse or ErrorResponse.
        /// 
        /// Replaced by: GroupIntegratedIMPGetRequest21sp1 in AS data mode
        /// </summary>
        public static async Task<GroupIntegratedIMPGetResponse> GroupIntegratedIMPGetRequestAsync(this OcipClient client, GroupIntegratedIMPGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupIntegratedIMPGetResponse;
        }
        /// <summary>
        /// Get the group's intercept group service settings.
        /// The response is either a GroupInterceptGroupGetResponse16sp1 or an ErrorResponse.
        /// 
        /// Replaced by: GroupInterceptGroupGetRequest21sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupInterceptGroupGetRequest16sp1Async instead.")]
        public static async Task<GroupInterceptGroupGetResponse16sp1> GroupInterceptGroupGetRequest16sp1(this OcipClient client, GroupInterceptGroupGetRequest16sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupInterceptGroupGetResponse16sp1;
        }

        /// <summary>
        /// Get the group's intercept group service settings.
        /// The response is either a GroupInterceptGroupGetResponse16sp1 or an ErrorResponse.
        /// 
        /// Replaced by: GroupInterceptGroupGetRequest21sp1 in AS data mode
        /// </summary>
        public static async Task<GroupInterceptGroupGetResponse16sp1> GroupInterceptGroupGetRequest16sp1Async(this OcipClient client, GroupInterceptGroupGetRequest16sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupInterceptGroupGetResponse16sp1;
        }
        /// <summary>
        /// Modify the group's intercept group service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupInterceptGroupModifyResponse21sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupInterceptGroupModifyRequest16Async instead.")]
        public static async Task<SuccessResponse> GroupInterceptGroupModifyRequest16(this OcipClient client, GroupInterceptGroupModifyRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group's intercept group service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupInterceptGroupModifyResponse21sp1 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupInterceptGroupModifyRequest16Async(this OcipClient client, GroupInterceptGroupModifyRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Music on Hold Instance to a department.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by: GroupMusicOnHoldAddInstanceRequest21
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldAddInstanceRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupMusicOnHoldAddInstanceRequest20(this OcipClient client, GroupMusicOnHoldAddInstanceRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Music on Hold Instance to a department.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by: GroupMusicOnHoldAddInstanceRequest21
        /// </summary>
        public static async Task<SuccessResponse> GroupMusicOnHoldAddInstanceRequest20Async(this OcipClient client, GroupMusicOnHoldAddInstanceRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Music on Hold Instance to a department.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by GroupMusicOnHoldAddInstanceRequest22.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldAddInstanceRequest21Async instead.")]
        public static async Task<SuccessResponse> GroupMusicOnHoldAddInstanceRequest21(this OcipClient client, GroupMusicOnHoldAddInstanceRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Music on Hold Instance to a department.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by GroupMusicOnHoldAddInstanceRequest22.
        /// </summary>
        public static async Task<SuccessResponse> GroupMusicOnHoldAddInstanceRequest21Async(this OcipClient client, GroupMusicOnHoldAddInstanceRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Music on Hold Instance to a department.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by GroupMusicOnHoldAddInstanceRequest23.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldAddInstanceRequest22Async instead.")]
        public static async Task<SuccessResponse> GroupMusicOnHoldAddInstanceRequest22(this OcipClient client, GroupMusicOnHoldAddInstanceRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Music on Hold Instance to a department.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by GroupMusicOnHoldAddInstanceRequest23.
        /// </summary>
        public static async Task<SuccessResponse> GroupMusicOnHoldAddInstanceRequest22Async(this OcipClient client, GroupMusicOnHoldAddInstanceRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse19 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldGetInstanceRequest19Async instead.")]
        public static async Task<GroupMusicOnHoldGetInstanceResponse19> GroupMusicOnHoldGetInstanceRequest19(this OcipClient client, GroupMusicOnHoldGetInstanceRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse19;
        }

        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse19 or ErrorResponse.
        /// </summary>
        public static async Task<GroupMusicOnHoldGetInstanceResponse19> GroupMusicOnHoldGetInstanceRequest19Async(this OcipClient client, GroupMusicOnHoldGetInstanceRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse19;
        }
        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse20 or ErrorResponse.
        /// Replaced by: GroupMusicOnHoldGetInstanceRequest21
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldGetInstanceRequest20Async instead.")]
        public static async Task<GroupMusicOnHoldGetInstanceResponse20> GroupMusicOnHoldGetInstanceRequest20(this OcipClient client, GroupMusicOnHoldGetInstanceRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse20;
        }

        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse20 or ErrorResponse.
        /// Replaced by: GroupMusicOnHoldGetInstanceRequest21
        /// </summary>
        public static async Task<GroupMusicOnHoldGetInstanceResponse20> GroupMusicOnHoldGetInstanceRequest20Async(this OcipClient client, GroupMusicOnHoldGetInstanceRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse20;
        }
        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse21 or ErrorResponse.
        /// Replaced by GroupMusicOnHoldGetInstanceRequest22
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldGetInstanceRequest21Async instead.")]
        public static async Task<GroupMusicOnHoldGetInstanceResponse21> GroupMusicOnHoldGetInstanceRequest21(this OcipClient client, GroupMusicOnHoldGetInstanceRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse21;
        }

        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse21 or ErrorResponse.
        /// Replaced by GroupMusicOnHoldGetInstanceRequest22
        /// </summary>
        public static async Task<GroupMusicOnHoldGetInstanceResponse21> GroupMusicOnHoldGetInstanceRequest21Async(this OcipClient client, GroupMusicOnHoldGetInstanceRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse21;
        }
        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse22 or ErrorResponse.
        /// 
        /// Replaced by: GroupMusicOnHoldGetInstanceRequest22V2 in AS mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldGetInstanceRequest22Async instead.")]
        public static async Task<GroupMusicOnHoldGetInstanceResponse22> GroupMusicOnHoldGetInstanceRequest22(this OcipClient client, GroupMusicOnHoldGetInstanceRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse22;
        }

        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse22 or ErrorResponse.
        /// 
        /// Replaced by: GroupMusicOnHoldGetInstanceRequest22V2 in AS mode
        /// </summary>
        public static async Task<GroupMusicOnHoldGetInstanceResponse22> GroupMusicOnHoldGetInstanceRequest22Async(this OcipClient client, GroupMusicOnHoldGetInstanceRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse22;
        }
        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse22V2 or ErrorResponse.
        /// Replaced by: GroupMusicOnHoldGetInstanceRequest23
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldGetInstanceRequest22V2Async instead.")]
        public static async Task<GroupMusicOnHoldGetInstanceResponse22V2> GroupMusicOnHoldGetInstanceRequest22V2(this OcipClient client, GroupMusicOnHoldGetInstanceRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse22V2;
        }

        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse22V2 or ErrorResponse.
        /// Replaced by: GroupMusicOnHoldGetInstanceRequest23
        /// </summary>
        public static async Task<GroupMusicOnHoldGetInstanceResponse22V2> GroupMusicOnHoldGetInstanceRequest22V2Async(this OcipClient client, GroupMusicOnHoldGetInstanceRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse22V2;
        }
        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse22V3 or ErrorResponse.
        /// Replaced by: GroupMusicOnHoldGetInstanceRequest23V2
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldGetInstanceRequest22V3Async instead.")]
        public static async Task<GroupMusicOnHoldGetInstanceResponse22V3> GroupMusicOnHoldGetInstanceRequest22V3(this OcipClient client, GroupMusicOnHoldGetInstanceRequest22V3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse22V3;
        }

        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse22V3 or ErrorResponse.
        /// Replaced by: GroupMusicOnHoldGetInstanceRequest23V2
        /// </summary>
        public static async Task<GroupMusicOnHoldGetInstanceResponse22V3> GroupMusicOnHoldGetInstanceRequest22V3Async(this OcipClient client, GroupMusicOnHoldGetInstanceRequest22V3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse22V3;
        }
        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse23 or ErrorResponse.
        /// Replaced by: GroupMusicOnHoldGetInstanceRequest23V2
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldGetInstanceRequest23Async instead.")]
        public static async Task<GroupMusicOnHoldGetInstanceResponse23> GroupMusicOnHoldGetInstanceRequest23(this OcipClient client, GroupMusicOnHoldGetInstanceRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse23;
        }

        /// <summary>
        /// Get a Music On Hold data for a group or department instance.
        /// The response is either GroupMusicOnHoldGetInstanceResponse23 or ErrorResponse.
        /// Replaced by: GroupMusicOnHoldGetInstanceRequest23V2
        /// </summary>
        public static async Task<GroupMusicOnHoldGetInstanceResponse23> GroupMusicOnHoldGetInstanceRequest23Async(this OcipClient client, GroupMusicOnHoldGetInstanceRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupMusicOnHoldGetInstanceResponse23;
        }
        /// <summary>
        /// Modify data for a group or department Music On Hold Instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by: GroupMusicOnHoldModifyInstanceRequest21
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldModifyInstanceRequest20Async instead.")]
        public static async Task<SuccessResponse> GroupMusicOnHoldModifyInstanceRequest20(this OcipClient client, GroupMusicOnHoldModifyInstanceRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify data for a group or department Music On Hold Instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by: GroupMusicOnHoldModifyInstanceRequest21
        /// </summary>
        public static async Task<SuccessResponse> GroupMusicOnHoldModifyInstanceRequest20Async(this OcipClient client, GroupMusicOnHoldModifyInstanceRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify data for a group or department Music On Hold Instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupMusicOnHoldModifyInstanceRequest21Async instead.")]
        public static async Task<SuccessResponse> GroupMusicOnHoldModifyInstanceRequest21(this OcipClient client, GroupMusicOnHoldModifyInstanceRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify data for a group or department Music On Hold Instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupMusicOnHoldModifyInstanceRequest21Async(this OcipClient client, GroupMusicOnHoldModifyInstanceRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Assign a list of Network Classes of Service to a group.
        /// The Element defaultNetworkClassOfService is required only for the first
        /// assignment, for subsequent assignments it is optional.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupNetworkClassOfServiceAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupNetworkClassOfServiceAssignListRequest(this OcipClient client, GroupNetworkClassOfServiceAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of Network Classes of Service to a group.
        /// The Element defaultNetworkClassOfService is required only for the first
        /// assignment, for subsequent assignments it is optional.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupNetworkClassOfServiceAssignListRequestAsync(this OcipClient client, GroupNetworkClassOfServiceAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a list of users within a group that have a given Network Class
        /// of Service assigned.
        /// The response is either a GroupNetworkClassOfServiceGetAssignedUserListResponse
        /// or an ErorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupNetworkClassOfServiceGetAssignedUserListRequestAsync instead.")]
        public static async Task<GroupNetworkClassOfServiceGetAssignedUserListResponse> GroupNetworkClassOfServiceGetAssignedUserListRequest(this OcipClient client, GroupNetworkClassOfServiceGetAssignedUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupNetworkClassOfServiceGetAssignedUserListResponse;
        }

        /// <summary>
        /// Get a list of users within a group that have a given Network Class
        /// of Service assigned.
        /// The response is either a GroupNetworkClassOfServiceGetAssignedUserListResponse
        /// or an ErorResponse.
        /// </summary>
        public static async Task<GroupNetworkClassOfServiceGetAssignedUserListResponse> GroupNetworkClassOfServiceGetAssignedUserListRequestAsync(this OcipClient client, GroupNetworkClassOfServiceGetAssignedUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupNetworkClassOfServiceGetAssignedUserListResponse;
        }
        /// <summary>
        /// Unassign a list of Network Classes of Service from a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupNetworkClassOfServiceUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupNetworkClassOfServiceUnassignListRequest(this OcipClient client, GroupNetworkClassOfServiceUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of Network Classes of Service from a group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupNetworkClassOfServiceUnassignListRequestAsync(this OcipClient client, GroupNetworkClassOfServiceUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the group's password rules setting that is applicable to
        /// users within the group.
        /// The response is either GroupPasswordRulesGetResponse16 or ErrorResponse.
        /// 
        /// Replaced by: GroupPasswordRulesGetRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPasswordRulesGetRequest16Async instead.")]
        public static async Task<GroupPasswordRulesGetResponse16> GroupPasswordRulesGetRequest16(this OcipClient client, GroupPasswordRulesGetRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupPasswordRulesGetResponse16;
        }

        /// <summary>
        /// Requests the group's password rules setting that is applicable to
        /// users within the group.
        /// The response is either GroupPasswordRulesGetResponse16 or ErrorResponse.
        /// 
        /// Replaced by: GroupPasswordRulesGetRequest22 in AS data mode.
        /// </summary>
        public static async Task<GroupPasswordRulesGetResponse16> GroupPasswordRulesGetRequest16Async(this OcipClient client, GroupPasswordRulesGetRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupPasswordRulesGetResponse16;
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
        /// The response is either GroupPhoneDirectoryGetListResponse18 or
        /// ErrorResponse.
        /// 
        /// Replaced By: GroupPhoneDirectoryGetPagedSortedListRequest
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPhoneDirectoryGetListRequest18Async instead.")]
        public static async Task<GroupPhoneDirectoryGetListResponse18> GroupPhoneDirectoryGetListRequest18(this OcipClient client, GroupPhoneDirectoryGetListRequest18 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupPhoneDirectoryGetListResponse18;
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
        /// The response is either GroupPhoneDirectoryGetListResponse18 or
        /// ErrorResponse.
        /// 
        /// Replaced By: GroupPhoneDirectoryGetPagedSortedListRequest
        /// </summary>
        public static async Task<GroupPhoneDirectoryGetListResponse18> GroupPhoneDirectoryGetListRequest18Async(this OcipClient client, GroupPhoneDirectoryGetListRequest18 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupPhoneDirectoryGetListResponse18;
        }
        /// <summary>
        /// Requests the Group's policy settings.
        /// The response is either GroupPolicyGetResponse17 or ErrorResponse.
        /// 
        /// Replaced by: GroupPolicyGetRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPolicyGetRequest17Async instead.")]
        public static async Task<GroupPolicyGetResponse17> GroupPolicyGetRequest17(this OcipClient client, GroupPolicyGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupPolicyGetResponse17;
        }

        /// <summary>
        /// Requests the Group's policy settings.
        /// The response is either GroupPolicyGetResponse17 or ErrorResponse.
        /// 
        /// Replaced by: GroupPolicyGetRequest20 in AS data mode
        /// </summary>
        public static async Task<GroupPolicyGetResponse17> GroupPolicyGetRequest17Async(this OcipClient client, GroupPolicyGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupPolicyGetResponse17;
        }
        /// <summary>
        /// Requests the Group's policy settings.
        /// The response is either GroupPolicyGetResponse20 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPolicyGetRequest20Async instead.")]
        public static async Task<GroupPolicyGetResponse20> GroupPolicyGetRequest20(this OcipClient client, GroupPolicyGetRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupPolicyGetResponse20;
        }

        /// <summary>
        /// Requests the Group's policy settings.
        /// The response is either GroupPolicyGetResponse20 or ErrorResponse.
        /// </summary>
        public static async Task<GroupPolicyGetResponse20> GroupPolicyGetRequest20Async(this OcipClient client, GroupPolicyGetRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupPolicyGetResponse20;
        }
        /// <summary>
        /// Request to modify the policies for a Group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// userAutoAttendantNameDialingAccess
        /// 
        /// Replaced by: GroupPolicyModifyRequest22 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPolicyModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupPolicyModifyRequest(this OcipClient client, GroupPolicyModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the policies for a Group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// userAutoAttendantNameDialingAccess
        /// 
        /// Replaced by: GroupPolicyModifyRequest22 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupPolicyModifyRequestAsync(this OcipClient client, GroupPolicyModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the group PreAlertingservice settings.
        /// The response is either a GroupPreAlertingAnnouncementGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupPreAlertingAnnouncementGetRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPreAlertingAnnouncementGetRequestAsync instead.")]
        public static async Task<GroupPreAlertingAnnouncementGetResponse> GroupPreAlertingAnnouncementGetRequest(this OcipClient client, GroupPreAlertingAnnouncementGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupPreAlertingAnnouncementGetResponse;
        }

        /// <summary>
        /// Get the group PreAlertingservice settings.
        /// The response is either a GroupPreAlertingAnnouncementGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupPreAlertingAnnouncementGetRequest20 in AS data mode
        /// </summary>
        public static async Task<GroupPreAlertingAnnouncementGetResponse> GroupPreAlertingAnnouncementGetRequestAsync(this OcipClient client, GroupPreAlertingAnnouncementGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupPreAlertingAnnouncementGetResponse;
        }
        /// <summary>
        /// Modify the group level pre-alerting service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupPreAlertingAnnouncementModifyRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupPreAlertingAnnouncementModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupPreAlertingAnnouncementModifyRequest(this OcipClient client, GroupPreAlertingAnnouncementModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group level pre-alerting service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupPreAlertingAnnouncementModifyRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupPreAlertingAnnouncementModifyRequestAsync(this OcipClient client, GroupPreAlertingAnnouncementModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Route Point instance to a group.
        /// The Route Point is a Call Center queue that performs the same function but
        /// allows an external system to perform the distribution of calls instead of making
        /// those decisions itself.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replace by GroupRoutePointAddInstanceRequest22
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointAddInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointAddInstanceRequest(this OcipClient client, GroupRoutePointAddInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Route Point instance to a group.
        /// The Route Point is a Call Center queue that performs the same function but
        /// allows an external system to perform the distribution of calls instead of making
        /// those decisions itself.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replace by GroupRoutePointAddInstanceRequest22
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointAddInstanceRequestAsync(this OcipClient client, GroupRoutePointAddInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Route Point instance to a group.
        /// The Route Point is a Call Center queue that performs the same function but
        /// allows an external system to perform the distribution of calls instead of making
        /// those decisions itself.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by GroupRoutePointAddInstanceRequest23.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointAddInstanceRequest22Async instead.")]
        public static async Task<SuccessResponse> GroupRoutePointAddInstanceRequest22(this OcipClient client, GroupRoutePointAddInstanceRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Route Point instance to a group.
        /// The Route Point is a Call Center queue that performs the same function but
        /// allows an external system to perform the distribution of calls instead of making
        /// those decisions itself.
        /// The domain is required in the serviceUserId.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by GroupRoutePointAddInstanceRequest23.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointAddInstanceRequest22Async(this OcipClient client, GroupRoutePointAddInstanceRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get all the information of a Route Point instance.
        /// The response is either GroupRoutePointGetInstanceResponse19sp1 or ErrorResponse.
        /// Replace by GroupRoutePointGetInstanceRequest22.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointGetInstanceRequest19sp1Async instead.")]
        public static async Task<GroupRoutePointGetInstanceResponse19sp1> GroupRoutePointGetInstanceRequest19sp1(this OcipClient client, GroupRoutePointGetInstanceRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointGetInstanceResponse19sp1;
        }

        /// <summary>
        /// Request to get all the information of a Route Point instance.
        /// The response is either GroupRoutePointGetInstanceResponse19sp1 or ErrorResponse.
        /// Replace by GroupRoutePointGetInstanceRequest22.
        /// </summary>
        public static async Task<GroupRoutePointGetInstanceResponse19sp1> GroupRoutePointGetInstanceRequest19sp1Async(this OcipClient client, GroupRoutePointGetInstanceRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointGetInstanceResponse19sp1;
        }
        /// <summary>
        /// Request to get all the information of a Route Point instance.
        /// The response is either GroupRoutePointGetInstanceResponse19sp1 or ErrorResponse.
        /// Replaced by GroupRoutePointGetInstanceRequest23.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointGetInstanceRequest22Async instead.")]
        public static async Task<GroupRoutePointGetInstanceResponse19sp1> GroupRoutePointGetInstanceRequest22(this OcipClient client, GroupRoutePointGetInstanceRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupRoutePointGetInstanceResponse19sp1;
        }

        /// <summary>
        /// Request to get all the information of a Route Point instance.
        /// The response is either GroupRoutePointGetInstanceResponse19sp1 or ErrorResponse.
        /// Replaced by GroupRoutePointGetInstanceRequest23.
        /// </summary>
        public static async Task<GroupRoutePointGetInstanceResponse19sp1> GroupRoutePointGetInstanceRequest22Async(this OcipClient client, GroupRoutePointGetInstanceRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupRoutePointGetInstanceResponse19sp1;
        }
        /// <summary>
        /// Request to modify a Route Point instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by GroupRoutePointModifyInstanceRequest22.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupRoutePointModifyInstanceRequestAsync instead.")]
        public static async Task<SuccessResponse> GroupRoutePointModifyInstanceRequest(this OcipClient client, GroupRoutePointModifyInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a Route Point instance.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by GroupRoutePointModifyInstanceRequest22.
        /// </summary>
        public static async Task<SuccessResponse> GroupRoutePointModifyInstanceRequestAsync(this OcipClient client, GroupRoutePointModifyInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Returns a list of all Public User Identities and associated data in a group. The response is either a GroupShInterfaceGetUserListResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupShInterfaceGetUserListRequest21sp1 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupShInterfaceGetUserListRequestAsync instead.")]
        public static async Task<GroupShInterfaceGetUserListResponse> GroupShInterfaceGetUserListRequest(this OcipClient client, GroupShInterfaceGetUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupShInterfaceGetUserListResponse;
        }

        /// <summary>
        /// Returns a list of all Public User Identities and associated data in a group. The response is either a GroupShInterfaceGetUserListResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupShInterfaceGetUserListRequest21sp1 in AS data mode.
        /// </summary>
        public static async Task<GroupShInterfaceGetUserListResponse> GroupShInterfaceGetUserListRequestAsync(this OcipClient client, GroupShInterfaceGetUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupShInterfaceGetUserListResponse;
        }
        /// <summary>
        /// Get the group's voice portal branding settings.
        /// The response is either a GroupVoiceMessagingGroupGetVoicePortalBrandingResponse16 or an ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceMessagingGroupGetVoicePortalBrandingRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceMessagingGroupGetVoicePortalBrandingRequest16Async instead.")]
        public static async Task<GroupVoiceMessagingGroupGetVoicePortalBrandingResponse16> GroupVoiceMessagingGroupGetVoicePortalBrandingRequest16(this OcipClient client, GroupVoiceMessagingGroupGetVoicePortalBrandingRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupVoiceMessagingGroupGetVoicePortalBrandingResponse16;
        }

        /// <summary>
        /// Get the group's voice portal branding settings.
        /// The response is either a GroupVoiceMessagingGroupGetVoicePortalBrandingResponse16 or an ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceMessagingGroupGetVoicePortalBrandingRequest20 in AS data mode
        /// </summary>
        public static async Task<GroupVoiceMessagingGroupGetVoicePortalBrandingResponse16> GroupVoiceMessagingGroupGetVoicePortalBrandingRequest16Async(this OcipClient client, GroupVoiceMessagingGroupGetVoicePortalBrandingRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupVoiceMessagingGroupGetVoicePortalBrandingResponse16;
        }
        /// <summary>
        /// Request to get the group voice portal information for a voice messaging group.
        /// The response is either GroupVoiceMessagingGroupGetVoicePortalResponse17sp4 or ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceMessagingGroupGetVoicePortalRequest19sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceMessagingGroupGetVoicePortalRequest17sp4Async instead.")]
        public static async Task<GroupVoiceMessagingGroupGetVoicePortalResponse17sp4> GroupVoiceMessagingGroupGetVoicePortalRequest17sp4(this OcipClient client, GroupVoiceMessagingGroupGetVoicePortalRequest17sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupVoiceMessagingGroupGetVoicePortalResponse17sp4;
        }

        /// <summary>
        /// Request to get the group voice portal information for a voice messaging group.
        /// The response is either GroupVoiceMessagingGroupGetVoicePortalResponse17sp4 or ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceMessagingGroupGetVoicePortalRequest19sp1 in AS data mode
        /// </summary>
        public static async Task<GroupVoiceMessagingGroupGetVoicePortalResponse17sp4> GroupVoiceMessagingGroupGetVoicePortalRequest17sp4Async(this OcipClient client, GroupVoiceMessagingGroupGetVoicePortalRequest17sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupVoiceMessagingGroupGetVoicePortalResponse17sp4;
        }
        /// <summary>
        /// Request to get the group voice portal information for a voice messaging group.
        /// The response is either GroupVoiceMessagingGroupGetVoicePortalResponse19sp1 or ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceMessagingGroupGetVoicePortalRequest21sp1 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceMessagingGroupGetVoicePortalRequest19sp1Async instead.")]
        public static async Task<GroupVoiceMessagingGroupGetVoicePortalResponse19sp1> GroupVoiceMessagingGroupGetVoicePortalRequest19sp1(this OcipClient client, GroupVoiceMessagingGroupGetVoicePortalRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupVoiceMessagingGroupGetVoicePortalResponse19sp1;
        }

        /// <summary>
        /// Request to get the group voice portal information for a voice messaging group.
        /// The response is either GroupVoiceMessagingGroupGetVoicePortalResponse19sp1 or ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceMessagingGroupGetVoicePortalRequest21sp1 in AS data mode.
        /// </summary>
        public static async Task<GroupVoiceMessagingGroupGetVoicePortalResponse19sp1> GroupVoiceMessagingGroupGetVoicePortalRequest19sp1Async(this OcipClient client, GroupVoiceMessagingGroupGetVoicePortalRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupVoiceMessagingGroupGetVoicePortalResponse19sp1;
        }
        /// <summary>
        /// Modify the group's voice portal branding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest16Async instead.")]
        public static async Task<SuccessResponse> GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest16(this OcipClient client, GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group's voice portal branding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest16Async(this OcipClient client, GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get all the information of a VoiceXML instance.
        /// The response is either GroupVoiceXmlGetInstanceResponse or ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceXmlGetInstanceRequest19sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceXmlGetInstanceRequestAsync instead.")]
        public static async Task<GroupVoiceXmlGetInstanceResponse> GroupVoiceXmlGetInstanceRequest(this OcipClient client, GroupVoiceXmlGetInstanceRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupVoiceXmlGetInstanceResponse;
        }

        /// <summary>
        /// Request to get all the information of a VoiceXML instance.
        /// The response is either GroupVoiceXmlGetInstanceResponse or ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceXmlGetInstanceRequest19sp1 in AS data mode
        /// </summary>
        public static async Task<GroupVoiceXmlGetInstanceResponse> GroupVoiceXmlGetInstanceRequestAsync(this OcipClient client, GroupVoiceXmlGetInstanceRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupVoiceXmlGetInstanceResponse;
        }
        /// <summary>
        /// Request to get all the information of a VoiceXML instance.
        /// The response is either GroupVoiceXmlGetInstanceResponse19sp1 or ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceXmlGetInstanceRequest22 in AS mode
        /// </summary>
        [Obsolete("This method is deprecated. Use GroupVoiceXmlGetInstanceRequest19sp1Async instead.")]
        public static async Task<GroupVoiceXmlGetInstanceResponse19sp1> GroupVoiceXmlGetInstanceRequest19sp1(this OcipClient client, GroupVoiceXmlGetInstanceRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as GroupVoiceXmlGetInstanceResponse19sp1;
        }

        /// <summary>
        /// Request to get all the information of a VoiceXML instance.
        /// The response is either GroupVoiceXmlGetInstanceResponse19sp1 or ErrorResponse.
        /// 
        /// Replaced by: GroupVoiceXmlGetInstanceRequest22 in AS mode
        /// </summary>
        public static async Task<GroupVoiceXmlGetInstanceResponse19sp1> GroupVoiceXmlGetInstanceRequest19sp1Async(this OcipClient client, GroupVoiceXmlGetInstanceRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as GroupVoiceXmlGetInstanceResponse19sp1;
        }
        /// <summary>
        /// LoginRequest21sp1 is 2nd stage of the 2 stage OCI login process.
        /// The signedPassword is not required for external authentication login from a trusted host (ACL).
        /// The response is either LoginResponse21sp1 or ErrorResponse.
        /// Replaced by LoginRequest22V3 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use LoginRequest21sp1Async instead.")]
        public static async Task<LoginResponse21sp1> LoginRequest21sp1(this OcipClient client, LoginRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as LoginResponse21sp1;
        }

        /// <summary>
        /// LoginRequest21sp1 is 2nd stage of the 2 stage OCI login process.
        /// The signedPassword is not required for external authentication login from a trusted host (ACL).
        /// The response is either LoginResponse21sp1 or ErrorResponse.
        /// Replaced by LoginRequest22V3 in AS data mode.
        /// </summary>
        public static async Task<LoginResponse21sp1> LoginRequest21sp1Async(this OcipClient client, LoginRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as LoginResponse21sp1;
        }
        /// <summary>
        /// Request to login to OCI.
        /// password is not required for external authentication login from a trusted host (ACL).
        /// The response is either LoginResponse22 or ErrorResponse.
        /// 
        /// Replaced by LoginRequest22V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use LoginRequest22Async instead.")]
        public static async Task<LoginResponse22> LoginRequest22(this OcipClient client, LoginRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as LoginResponse22;
        }

        /// <summary>
        /// Request to login to OCI.
        /// password is not required for external authentication login from a trusted host (ACL).
        /// The response is either LoginResponse22 or ErrorResponse.
        /// 
        /// Replaced by LoginRequest22V2 in AS data mode.
        /// </summary>
        public static async Task<LoginResponse22> LoginRequest22Async(this OcipClient client, LoginRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as LoginResponse22;
        }
        /// <summary>
        /// Request to login to OCI.
        /// password is not required for external authentication login from a trusted host (ACL).
        /// The response is either LoginResponse22V2 or ErrorResponse.
        /// 
        /// Replaced by LoginRequest22V3 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use LoginRequest22V2Async instead.")]
        public static async Task<LoginResponse22V2> LoginRequest22V2(this OcipClient client, LoginRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as LoginResponse22V2;
        }

        /// <summary>
        /// Request to login to OCI.
        /// password is not required for external authentication login from a trusted host (ACL).
        /// The response is either LoginResponse22V2 or ErrorResponse.
        /// 
        /// Replaced by LoginRequest22V3 in AS data mode.
        /// </summary>
        public static async Task<LoginResponse22V2> LoginRequest22V2Async(this OcipClient client, LoginRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as LoginResponse22V2;
        }
        /// <summary>
        /// Request to login to OCI.
        /// password is not required for external authentication login from a trusted host (ACL).
        /// Replaced by LoginRequest22V4 in AS data mode.
        /// The response is either LoginResponse22V3 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use LoginRequest22V3Async instead.")]
        public static async Task<LoginResponse22V3> LoginRequest22V3(this OcipClient client, LoginRequest22V3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as LoginResponse22V3;
        }

        /// <summary>
        /// Request to login to OCI.
        /// password is not required for external authentication login from a trusted host (ACL).
        /// Replaced by LoginRequest22V4 in AS data mode.
        /// The response is either LoginResponse22V3 or ErrorResponse.
        /// </summary>
        public static async Task<LoginResponse22V3> LoginRequest22V3Async(this OcipClient client, LoginRequest22V3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as LoginResponse22V3;
        }
        /// <summary>
        /// Get a reseller administrators profile.
        /// The response is either a ResellerAdminGetResponse or an ErrorResponse.
        /// Replaced by ResellerAdminGetRequest22
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerAdminGetRequestAsync instead.")]
        public static async Task<ResellerAdminGetResponse> ResellerAdminGetRequest(this OcipClient client, ResellerAdminGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerAdminGetResponse;
        }

        /// <summary>
        /// Get a reseller administrators profile.
        /// The response is either a ResellerAdminGetResponse or an ErrorResponse.
        /// Replaced by ResellerAdminGetRequest22
        /// </summary>
        public static async Task<ResellerAdminGetResponse> ResellerAdminGetRequestAsync(this OcipClient client, ResellerAdminGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerAdminGetResponse;
        }
        /// <summary>
        /// Request the reseller level data associated with Call Policies.
        /// The response is either a ResellerCallPoliciesGetResponse
        /// or an ErrorResponse.
        /// 
        /// Replaced by: ResellerCallPoliciesGetRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerCallPoliciesGetRequestAsync instead.")]
        public static async Task<ResellerCallPoliciesGetResponse> ResellerCallPoliciesGetRequest(this OcipClient client, ResellerCallPoliciesGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerCallPoliciesGetResponse;
        }

        /// <summary>
        /// Request the reseller level data associated with Call Policies.
        /// The response is either a ResellerCallPoliciesGetResponse
        /// or an ErrorResponse.
        /// 
        /// Replaced by: ResellerCallPoliciesGetRequest22 in AS data mode.
        /// </summary>
        public static async Task<ResellerCallPoliciesGetResponse> ResellerCallPoliciesGetRequestAsync(this OcipClient client, ResellerCallPoliciesGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerCallPoliciesGetResponse;
        }
        /// <summary>
        /// Get the Integrated IMP service attributes for the reseller.
        /// The response is either ResellerIntegratedIMPGetResponse or ErrorResponse.
        /// 
        /// Replaced by: ResellerIntegratedIMPGetRequest22 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerIntegratedIMPGetRequestAsync instead.")]
        public static async Task<ResellerIntegratedIMPGetResponse> ResellerIntegratedIMPGetRequest(this OcipClient client, ResellerIntegratedIMPGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerIntegratedIMPGetResponse;
        }

        /// <summary>
        /// Get the Integrated IMP service attributes for the reseller.
        /// The response is either ResellerIntegratedIMPGetResponse or ErrorResponse.
        /// 
        /// Replaced by: ResellerIntegratedIMPGetRequest22 in AS data mode
        /// </summary>
        public static async Task<ResellerIntegratedIMPGetResponse> ResellerIntegratedIMPGetRequestAsync(this OcipClient client, ResellerIntegratedIMPGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerIntegratedIMPGetResponse;
        }
        /// <summary>
        /// Request the reseller level data associated with Meet-Me Conferencing functions.
        /// The response is either a ResellerMeetMeConferencingGetResponse or an
        /// ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ResellerMeetMeConferencingGetRequestAsync instead.")]
        public static async Task<ResellerMeetMeConferencingGetResponse> ResellerMeetMeConferencingGetRequest(this OcipClient client, ResellerMeetMeConferencingGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ResellerMeetMeConferencingGetResponse;
        }

        /// <summary>
        /// Request the reseller level data associated with Meet-Me Conferencing functions.
        /// The response is either a ResellerMeetMeConferencingGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<ResellerMeetMeConferencingGetResponse> ResellerMeetMeConferencingGetRequestAsync(this OcipClient client, ResellerMeetMeConferencingGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ResellerMeetMeConferencingGetResponse;
        }
        /// <summary>
        /// Request to add a service provider access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By: ServiceProviderAccessDeviceAddRequest22
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceAddRequest14Async instead.")]
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceAddRequest14(this OcipClient client, ServiceProviderAccessDeviceAddRequest14 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a service provider access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced By: ServiceProviderAccessDeviceAddRequest22
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceAddRequest14Async(this OcipClient client, ServiceProviderAccessDeviceAddRequest14 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a service provider access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useHotline
        /// hotlineContact
        /// serviceProviderExternalId
        /// deviceExternalId
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceAddRequest22Async instead.")]
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceAddRequest22(this OcipClient client, ServiceProviderAccessDeviceAddRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a service provider access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useHotline
        /// hotlineContact
        /// serviceProviderExternalId
        /// deviceExternalId
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceAddRequest22Async(this OcipClient client, ServiceProviderAccessDeviceAddRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the configuration of a specified service provider access device.
        /// The response is either ServiceProviderAccessDeviceGetResponse18sp1 or ErrorResponse.
        /// Replaced by: ServiceProviderAccessDeviceGetRequest22.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceGetRequest18sp1Async instead.")]
        public static async Task<ServiceProviderAccessDeviceGetResponse18sp1> ServiceProviderAccessDeviceGetRequest18sp1(this OcipClient client, ServiceProviderAccessDeviceGetRequest18sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAccessDeviceGetResponse18sp1;
        }

        /// <summary>
        /// Requests the configuration of a specified service provider access device.
        /// The response is either ServiceProviderAccessDeviceGetResponse18sp1 or ErrorResponse.
        /// Replaced by: ServiceProviderAccessDeviceGetRequest22.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetResponse18sp1> ServiceProviderAccessDeviceGetRequest18sp1Async(this OcipClient client, ServiceProviderAccessDeviceGetRequest18sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAccessDeviceGetResponse18sp1;
        }
        /// <summary>
        /// Requests the configuration of a specified service provider access device.
        /// The response is either ServiceProviderAccessDeviceGetResponse22 or ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderAccessDeviceGetRequest24
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceGetRequest22Async instead.")]
        public static async Task<ServiceProviderAccessDeviceGetResponse22> ServiceProviderAccessDeviceGetRequest22(this OcipClient client, ServiceProviderAccessDeviceGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAccessDeviceGetResponse22;
        }

        /// <summary>
        /// Requests the configuration of a specified service provider access device.
        /// The response is either ServiceProviderAccessDeviceGetResponse22 or ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderAccessDeviceGetRequest24
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetResponse22> ServiceProviderAccessDeviceGetRequest22Async(this OcipClient client, ServiceProviderAccessDeviceGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAccessDeviceGetResponse22;
        }
        /// <summary>
        /// Requests the configuration of a specified service provider access device.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// deviceExternalId
        /// 
        /// The response is either ServiceProviderAccessDeviceGetResponse22V2 or ErrorResponse.
        /// 
        /// Replaced By: ServiceProviderAccessDeviceGetRequest24
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceGetRequest22V2Async instead.")]
        public static async Task<ServiceProviderAccessDeviceGetResponse22V2> ServiceProviderAccessDeviceGetRequest22V2(this OcipClient client, ServiceProviderAccessDeviceGetRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAccessDeviceGetResponse22V2;
        }

        /// <summary>
        /// Requests the configuration of a specified service provider access device.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// deviceExternalId
        /// 
        /// The response is either ServiceProviderAccessDeviceGetResponse22V2 or ErrorResponse.
        /// 
        /// Replaced By: ServiceProviderAccessDeviceGetRequest24
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetResponse22V2> ServiceProviderAccessDeviceGetRequest22V2Async(this OcipClient client, ServiceProviderAccessDeviceGetRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAccessDeviceGetResponse22V2;
        }
        /// <summary>
        /// Requests the configuration of a specified service provider access device.
        /// The response is either ServiceProviderAccessDeviceGetResponse22V3 or ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// deviceExternalId
        /// 
        /// Replaced by: ServiceProviderAccessDeviceGetRequest24
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceGetRequest22V3Async instead.")]
        public static async Task<ServiceProviderAccessDeviceGetResponse22V3> ServiceProviderAccessDeviceGetRequest22V3(this OcipClient client, ServiceProviderAccessDeviceGetRequest22V3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAccessDeviceGetResponse22V3;
        }

        /// <summary>
        /// Requests the configuration of a specified service provider access device.
        /// The response is either ServiceProviderAccessDeviceGetResponse22V3 or ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// deviceExternalId
        /// 
        /// Replaced by: ServiceProviderAccessDeviceGetRequest24
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetResponse22V3> ServiceProviderAccessDeviceGetRequest22V3Async(this OcipClient client, ServiceProviderAccessDeviceGetRequest22V3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAccessDeviceGetResponse22V3;
        }
        /// <summary>
        /// Requests the list of users on a specified device.
        /// The response is either ServiceProviderAccessDeviceGetUserListResponse or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaAccessDeviceEndpointPrivateIdentity
        /// 
        /// Replaced by: ServiceProviderAccessDeviceGetUserListRequest21sp1 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceGetUserListRequestAsync instead.")]
        public static async Task<ServiceProviderAccessDeviceGetUserListResponse> ServiceProviderAccessDeviceGetUserListRequest(this OcipClient client, ServiceProviderAccessDeviceGetUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAccessDeviceGetUserListResponse;
        }

        /// <summary>
        /// Requests the list of users on a specified device.
        /// The response is either ServiceProviderAccessDeviceGetUserListResponse or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaAccessDeviceEndpointPrivateIdentity
        /// 
        /// Replaced by: ServiceProviderAccessDeviceGetUserListRequest21sp1 in AS data mode.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetUserListResponse> ServiceProviderAccessDeviceGetUserListRequestAsync(this OcipClient client, ServiceProviderAccessDeviceGetUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAccessDeviceGetUserListResponse;
        }
        /// <summary>
        /// Request to modify a specified service provider access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useHotline
        /// hotlineContact
        /// deviceExternalId
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAccessDeviceModifyRequest14Async instead.")]
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceModifyRequest14(this OcipClient client, ServiceProviderAccessDeviceModifyRequest14 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a specified service provider access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useHotline
        /// hotlineContact
        /// deviceExternalId
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceModifyRequest14Async(this OcipClient client, ServiceProviderAccessDeviceModifyRequest14 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a service provider or enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in Amplify data mode and ignored in AS and XS data mode:
        /// servicePolicy,
        /// callProcessingSliceId,
        /// provisioningSliceId,
        /// subscriberPartition.
        /// When the callProcessingSliceId or provisioningSliceId is not specified in the AmplifyDataMode,
        /// the default slice Id is assigned to the service provider.
        /// Only Provisioning admin and above can change the callProcessingSliceId,  provisioningSliceId, andsubscriberPartition.
        /// 
        /// The following elements are only used in Amplify and XS data mode and ignored in AS data mode:
        /// preferredDataCenter.
        /// Only Provisioning admin and above can change the preferredDataCenter.
        /// 
        /// The following data elements are only used in AS data mode:
        /// resellerId
        /// If reseller administrator sends the request, resellerId is ignored. The reseller administrator's reseller id is used.
        /// Replaced by: ServiceProviderConsolidatedAddRequest in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAddRequest13mp2Async instead.")]
        public static async Task<SuccessResponse> ServiceProviderAddRequest13mp2(this OcipClient client, ServiceProviderAddRequest13mp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a service provider or enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in Amplify data mode and ignored in AS and XS data mode:
        /// servicePolicy,
        /// callProcessingSliceId,
        /// provisioningSliceId,
        /// subscriberPartition.
        /// When the callProcessingSliceId or provisioningSliceId is not specified in the AmplifyDataMode,
        /// the default slice Id is assigned to the service provider.
        /// Only Provisioning admin and above can change the callProcessingSliceId,  provisioningSliceId, andsubscriberPartition.
        /// 
        /// The following elements are only used in Amplify and XS data mode and ignored in AS data mode:
        /// preferredDataCenter.
        /// Only Provisioning admin and above can change the preferredDataCenter.
        /// 
        /// The following data elements are only used in AS data mode:
        /// resellerId
        /// If reseller administrator sends the request, resellerId is ignored. The reseller administrator's reseller id is used.
        /// Replaced by: ServiceProviderConsolidatedAddRequest in AS data mode.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAddRequest13mp2Async(this OcipClient client, ServiceProviderAddRequest13mp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the service provider administrator's policy settings.
        /// The response is either ServiceProviderAdminGetPolicyResponse18 or ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderAdminGetPolicyRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAdminGetPolicyRequest18Async instead.")]
        public static async Task<ServiceProviderAdminGetPolicyResponse18> ServiceProviderAdminGetPolicyRequest18(this OcipClient client, ServiceProviderAdminGetPolicyRequest18 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAdminGetPolicyResponse18;
        }

        /// <summary>
        /// Requests the service provider administrator's policy settings.
        /// The response is either ServiceProviderAdminGetPolicyResponse18 or ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderAdminGetPolicyRequest20 in AS data mode
        /// </summary>
        public static async Task<ServiceProviderAdminGetPolicyResponse18> ServiceProviderAdminGetPolicyRequest18Async(this OcipClient client, ServiceProviderAdminGetPolicyRequest18 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAdminGetPolicyResponse18;
        }
        /// <summary>
        /// Get a service provider administrators profile.
        /// The response is either a ServiceProviderAdminGetResponse14 or an ErrorResponse.
        /// Replaced by ServiceProviderAdminGetRequest21sp1.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAdminGetRequest14Async instead.")]
        public static async Task<ServiceProviderAdminGetResponse14> ServiceProviderAdminGetRequest14(this OcipClient client, ServiceProviderAdminGetRequest14 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAdminGetResponse14;
        }

        /// <summary>
        /// Get a service provider administrators profile.
        /// The response is either a ServiceProviderAdminGetResponse14 or an ErrorResponse.
        /// Replaced by ServiceProviderAdminGetRequest21sp1.
        /// </summary>
        public static async Task<ServiceProviderAdminGetResponse14> ServiceProviderAdminGetRequest14Async(this OcipClient client, ServiceProviderAdminGetRequest14 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAdminGetResponse14;
        }
        /// <summary>
        /// Get a service provider administrators profile.
        /// The response is either a ServiceProviderAdminGetResponse21sp1 or an ErrorResponse.
        /// Replaced by: ServiceProviderAdminGetRequest22.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderAdminGetRequest21sp1Async instead.")]
        public static async Task<ServiceProviderAdminGetResponse21sp1> ServiceProviderAdminGetRequest21sp1(this OcipClient client, ServiceProviderAdminGetRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderAdminGetResponse21sp1;
        }

        /// <summary>
        /// Get a service provider administrators profile.
        /// The response is either a ServiceProviderAdminGetResponse21sp1 or an ErrorResponse.
        /// Replaced by: ServiceProviderAdminGetRequest22.
        /// </summary>
        public static async Task<ServiceProviderAdminGetResponse21sp1> ServiceProviderAdminGetRequest21sp1Async(this OcipClient client, ServiceProviderAdminGetRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderAdminGetResponse21sp1;
        }
        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse21sp2 or an ErrorResponse.
        /// Replaced by: ServiceProviderCallProcessingGetPolicyRequest22 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCallProcessingGetPolicyRequest21sp2Async instead.")]
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse21sp2> ServiceProviderCallProcessingGetPolicyRequest21sp2(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest21sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderCallProcessingGetPolicyResponse21sp2;
        }

        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse21sp2 or an ErrorResponse.
        /// Replaced by: ServiceProviderCallProcessingGetPolicyRequest22 in AS data mode
        /// </summary>
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse21sp2> ServiceProviderCallProcessingGetPolicyRequest21sp2Async(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest21sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderCallProcessingGetPolicyResponse21sp2;
        }
        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse22 or an ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderCallProcessingGetPolicyRequest22V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCallProcessingGetPolicyRequest22Async instead.")]
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse22> ServiceProviderCallProcessingGetPolicyRequest22(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderCallProcessingGetPolicyResponse22;
        }

        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse22 or an ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderCallProcessingGetPolicyRequest22V2 in AS data mode.
        /// </summary>
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse22> ServiceProviderCallProcessingGetPolicyRequest22Async(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderCallProcessingGetPolicyResponse22;
        }
        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse22V2 or an ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderCallProcessingGetPolicyRequest22V3 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCallProcessingGetPolicyRequest22V2Async instead.")]
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse22V2> ServiceProviderCallProcessingGetPolicyRequest22V2(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderCallProcessingGetPolicyResponse22V2;
        }

        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse22V2 or an ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderCallProcessingGetPolicyRequest22V3 in AS data mode.
        /// </summary>
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse22V2> ServiceProviderCallProcessingGetPolicyRequest22V2Async(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderCallProcessingGetPolicyResponse22V2;
        }
        /// <summary>
        /// Add a new Communication Barring Profile.
        /// The priorities for OriginatingRules, RedirectingRules, CallMeNowRules and IncomingRules are requantized to consecutive integers as part of the add.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// callMeNowDefaultAction, use value "Block" in XS data mode
        /// The following elements are only used in AS data mode and ignored in XS data mode
        /// callMeNowDefaultCallTimeout
        /// callMeNowRule
        /// 
        /// Replaced By : ServiceProviderCommunicationBarringProfileAddRequest19sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringProfileAddRequest17sp3Async instead.")]
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringProfileAddRequest17sp3(this OcipClient client, ServiceProviderCommunicationBarringProfileAddRequest17sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Communication Barring Profile.
        /// The priorities for OriginatingRules, RedirectingRules, CallMeNowRules and IncomingRules are requantized to consecutive integers as part of the add.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// callMeNowDefaultAction, use value "Block" in XS data mode
        /// The following elements are only used in AS data mode and ignored in XS data mode
        /// callMeNowDefaultCallTimeout
        /// callMeNowRule
        /// 
        /// Replaced By : ServiceProviderCommunicationBarringProfileAddRequest19sp1 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringProfileAddRequest17sp3Async(this OcipClient client, ServiceProviderCommunicationBarringProfileAddRequest17sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetResponse17sp3
        /// or an ErrorResponse.
        /// 
        /// Replaced By : ServiceProviderCommunicationBarringProfileGetRequest19sp1V2 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringProfileGetRequest17sp3Async instead.")]
        public static async Task<ServiceProviderCommunicationBarringProfileGetResponse17sp3> ServiceProviderCommunicationBarringProfileGetRequest17sp3(this OcipClient client, ServiceProviderCommunicationBarringProfileGetRequest17sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderCommunicationBarringProfileGetResponse17sp3;
        }

        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetResponse17sp3
        /// or an ErrorResponse.
        /// 
        /// Replaced By : ServiceProviderCommunicationBarringProfileGetRequest19sp1V2 in AS data mode
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringProfileGetResponse17sp3> ServiceProviderCommunicationBarringProfileGetRequest17sp3Async(this OcipClient client, ServiceProviderCommunicationBarringProfileGetRequest17sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderCommunicationBarringProfileGetResponse17sp3;
        }
        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetResponse19sp1
        /// or an ErrorResponse.
        /// 
        /// Replaced By : ServiceProviderCommunicationBarringProfileGetRequest19sp1V2 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderCommunicationBarringProfileGetRequest19sp1Async instead.")]
        public static async Task<ServiceProviderCommunicationBarringProfileGetResponse19sp1> ServiceProviderCommunicationBarringProfileGetRequest19sp1(this OcipClient client, ServiceProviderCommunicationBarringProfileGetRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderCommunicationBarringProfileGetResponse19sp1;
        }

        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetResponse19sp1
        /// or an ErrorResponse.
        /// 
        /// Replaced By : ServiceProviderCommunicationBarringProfileGetRequest19sp1V2 in AS data mode
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringProfileGetResponse19sp1> ServiceProviderCommunicationBarringProfileGetRequest19sp1Async(this OcipClient client, ServiceProviderCommunicationBarringProfileGetRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderCommunicationBarringProfileGetResponse19sp1;
        }
        /// <summary>
        /// Request the Service Provider level data associated with Dial Plan Policy.
        /// The response is either a ServiceProviderDialPlanPolicyGetResponse17
        /// or an ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderDialPlanPolicyGetRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDialPlanPolicyGetRequest17Async instead.")]
        public static async Task<ServiceProviderDialPlanPolicyGetResponse17> ServiceProviderDialPlanPolicyGetRequest17(this OcipClient client, ServiceProviderDialPlanPolicyGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderDialPlanPolicyGetResponse17;
        }

        /// <summary>
        /// Request the Service Provider level data associated with Dial Plan Policy.
        /// The response is either a ServiceProviderDialPlanPolicyGetResponse17
        /// or an ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderDialPlanPolicyGetRequest22 in AS data mode.
        /// </summary>
        public static async Task<ServiceProviderDialPlanPolicyGetResponse17> ServiceProviderDialPlanPolicyGetRequest17Async(this OcipClient client, ServiceProviderDialPlanPolicyGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderDialPlanPolicyGetResponse17;
        }
        /// <summary>
        /// Requests the list of all matching domains assigned to a service provider .
        /// The response is either ServiceProviderDomainGetAssignedListResponse or ErrorResponse.
        /// 
        /// Replaced by ServiceProviderDomainGetAssignedListRequest22.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderDomainGetAssignedListRequestAsync instead.")]
        public static async Task<ServiceProviderDomainGetAssignedListResponse> ServiceProviderDomainGetAssignedListRequest(this OcipClient client, ServiceProviderDomainGetAssignedListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderDomainGetAssignedListResponse;
        }

        /// <summary>
        /// Requests the list of all matching domains assigned to a service provider .
        /// The response is either ServiceProviderDomainGetAssignedListResponse or ErrorResponse.
        /// 
        /// Replaced by ServiceProviderDomainGetAssignedListRequest22.
        /// </summary>
        public static async Task<ServiceProviderDomainGetAssignedListResponse> ServiceProviderDomainGetAssignedListRequestAsync(this OcipClient client, ServiceProviderDomainGetAssignedListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderDomainGetAssignedListResponse;
        }
        /// <summary>
        /// Get the list of feature access codes for a service provider or enterprise.
        /// The response is either a ServiceProviderFeatureAccessCodeGetListResponse or an ErrorResponse.
        /// 
        /// Replaced By : ServiceProviderFeatureAccessCodeGetListRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderFeatureAccessCodeGetListRequestAsync instead.")]
        public static async Task<ServiceProviderFeatureAccessCodeGetListResponse> ServiceProviderFeatureAccessCodeGetListRequest(this OcipClient client, ServiceProviderFeatureAccessCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderFeatureAccessCodeGetListResponse;
        }

        /// <summary>
        /// Get the list of feature access codes for a service provider or enterprise.
        /// The response is either a ServiceProviderFeatureAccessCodeGetListResponse or an ErrorResponse.
        /// 
        /// Replaced By : ServiceProviderFeatureAccessCodeGetListRequest20 in AS data mode
        /// </summary>
        public static async Task<ServiceProviderFeatureAccessCodeGetListResponse> ServiceProviderFeatureAccessCodeGetListRequestAsync(this OcipClient client, ServiceProviderFeatureAccessCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderFeatureAccessCodeGetListResponse;
        }
        /// <summary>
        /// Modify a list of feature access codes for a service provider or enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By : ServiceProviderFeatureAccessCodeModifyListRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderFeatureAccessCodeModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderFeatureAccessCodeModifyListRequest(this OcipClient client, ServiceProviderFeatureAccessCodeModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify a list of feature access codes for a service provider or enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced By : ServiceProviderFeatureAccessCodeModifyListRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderFeatureAccessCodeModifyListRequestAsync(this OcipClient client, ServiceProviderFeatureAccessCodeModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the profile for a service provider or enterprise.
        /// The response is either a ServiceProviderGetResponse22V2 or an ErrorResponse.
        /// Replaced by ServiceProviderGetRequest22V3.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderGetRequest22V2Async instead.")]
        public static async Task<ServiceProviderGetResponse22V2> ServiceProviderGetRequest22V2(this OcipClient client, ServiceProviderGetRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderGetResponse22V2;
        }

        /// <summary>
        /// Get the profile for a service provider or enterprise.
        /// The response is either a ServiceProviderGetResponse22V2 or an ErrorResponse.
        /// Replaced by ServiceProviderGetRequest22V3.
        /// </summary>
        public static async Task<ServiceProviderGetResponse22V2> ServiceProviderGetRequest22V2Async(this OcipClient client, ServiceProviderGetRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderGetResponse22V2;
        }
        /// <summary>
        /// Get the profile for a service provider or enterprise.
        /// The response is either a ServiceProviderGetResponse22V3 or an ErrorResponse.
        /// Replaced by: ServiceProviderGetRequest22V4 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderGetRequest22V3Async instead.")]
        public static async Task<ServiceProviderGetResponse22V3> ServiceProviderGetRequest22V3(this OcipClient client, ServiceProviderGetRequest22V3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderGetResponse22V3;
        }

        /// <summary>
        /// Get the profile for a service provider or enterprise.
        /// The response is either a ServiceProviderGetResponse22V3 or an ErrorResponse.
        /// Replaced by: ServiceProviderGetRequest22V4 in AS data mode.
        /// </summary>
        public static async Task<ServiceProviderGetResponse22V3> ServiceProviderGetRequest22V3Async(this OcipClient client, ServiceProviderGetRequest22V3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderGetResponse22V3;
        }
        /// <summary>
        /// Request the maximum number of target users per paging group configured for a service provider.
        /// The response is either a ServiceProviderGroupPagingTargetsCapacityGetResponse
        /// or an ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderGroupPagingTargetsCapacityGetRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderGroupPagingTargetsCapacityGetRequestAsync instead.")]
        public static async Task<ServiceProviderGroupPagingTargetsCapacityGetResponse> ServiceProviderGroupPagingTargetsCapacityGetRequest(this OcipClient client, ServiceProviderGroupPagingTargetsCapacityGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderGroupPagingTargetsCapacityGetResponse;
        }

        /// <summary>
        /// Request the maximum number of target users per paging group configured for a service provider.
        /// The response is either a ServiceProviderGroupPagingTargetsCapacityGetResponse
        /// or an ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderGroupPagingTargetsCapacityGetRequest22 in AS data mode.
        /// </summary>
        public static async Task<ServiceProviderGroupPagingTargetsCapacityGetResponse> ServiceProviderGroupPagingTargetsCapacityGetRequestAsync(this OcipClient client, ServiceProviderGroupPagingTargetsCapacityGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderGroupPagingTargetsCapacityGetResponse;
        }
        /// <summary>
        /// Modify the maximum number of target users per paging group configured for a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderGroupPagingTargetsCapacityModifyRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderGroupPagingTargetsCapacityModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderGroupPagingTargetsCapacityModifyRequest(this OcipClient client, ServiceProviderGroupPagingTargetsCapacityModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the maximum number of target users per paging group configured for a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderGroupPagingTargetsCapacityModifyRequest22 in AS data mode.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderGroupPagingTargetsCapacityModifyRequestAsync(this OcipClient client, ServiceProviderGroupPagingTargetsCapacityModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the Integrated IMP service attributes for the service provider.
        /// The response is either ServiceProviderIntegratedIMPGetResponse or ErrorResponse.
        /// Replaced by: ServiceProviderIntegratedIMPGetRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderIntegratedIMPGetRequestAsync instead.")]
        public static async Task<ServiceProviderIntegratedIMPGetResponse> ServiceProviderIntegratedIMPGetRequest(this OcipClient client, ServiceProviderIntegratedIMPGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderIntegratedIMPGetResponse;
        }

        /// <summary>
        /// Get the Integrated IMP service attributes for the service provider.
        /// The response is either ServiceProviderIntegratedIMPGetResponse or ErrorResponse.
        /// Replaced by: ServiceProviderIntegratedIMPGetRequest21 in AS data mode
        /// </summary>
        public static async Task<ServiceProviderIntegratedIMPGetResponse> ServiceProviderIntegratedIMPGetRequestAsync(this OcipClient client, ServiceProviderIntegratedIMPGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderIntegratedIMPGetResponse;
        }
        /// <summary>
        /// Get the Integrated IMP service attributes for the service provider.
        /// The response is either ServiceProviderIntegratedIMPGetResponse21 or ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderIntegratedIMPGetRequest21sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderIntegratedIMPGetRequest21Async instead.")]
        public static async Task<ServiceProviderIntegratedIMPGetResponse21> ServiceProviderIntegratedIMPGetRequest21(this OcipClient client, ServiceProviderIntegratedIMPGetRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderIntegratedIMPGetResponse21;
        }

        /// <summary>
        /// Get the Integrated IMP service attributes for the service provider.
        /// The response is either ServiceProviderIntegratedIMPGetResponse21 or ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderIntegratedIMPGetRequest21sp1 in AS data mode
        /// </summary>
        public static async Task<ServiceProviderIntegratedIMPGetResponse21> ServiceProviderIntegratedIMPGetRequest21Async(this OcipClient client, ServiceProviderIntegratedIMPGetRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderIntegratedIMPGetResponse21;
        }
        /// <summary>
        /// Get the Integrated IMP service attributes for the service provider.
        /// The response is either ServiceProviderIntegratedIMPGetResponse21sp1 or ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderIntegratedIMPGetRequest22 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderIntegratedIMPGetRequest21sp1Async instead.")]
        public static async Task<ServiceProviderIntegratedIMPGetResponse21sp1> ServiceProviderIntegratedIMPGetRequest21sp1(this OcipClient client, ServiceProviderIntegratedIMPGetRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderIntegratedIMPGetResponse21sp1;
        }

        /// <summary>
        /// Get the Integrated IMP service attributes for the service provider.
        /// The response is either ServiceProviderIntegratedIMPGetResponse21sp1 or ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderIntegratedIMPGetRequest22 in AS data mode
        /// </summary>
        public static async Task<ServiceProviderIntegratedIMPGetResponse21sp1> ServiceProviderIntegratedIMPGetRequest21sp1Async(this OcipClient client, ServiceProviderIntegratedIMPGetRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderIntegratedIMPGetResponse21sp1;
        }
        /// <summary>
        /// Assign a list of Network Classes of Service to a service provider.
        /// The Element defaultNetworkClassOfService is required only
        /// for the first assignment,
        /// for subsequent assignments it is optional.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced By : ServiceProviderNetworkClassOfServiceAssignListRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderNetworkClassOfServiceAssignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceAssignListRequest(this OcipClient client, ServiceProviderNetworkClassOfServiceAssignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of Network Classes of Service to a service provider.
        /// The Element defaultNetworkClassOfService is required only
        /// for the first assignment,
        /// for subsequent assignments it is optional.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced By : ServiceProviderNetworkClassOfServiceAssignListRequest21 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceAssignListRequestAsync(this OcipClient client, ServiceProviderNetworkClassOfServiceAssignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Unassign a list of Network Classes of Service from a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced By : ServiceProviderNetworkClassOfServiceUnassignListRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderNetworkClassOfServiceUnassignListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceUnassignListRequest(this OcipClient client, ServiceProviderNetworkClassOfServiceUnassignListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of Network Classes of Service from a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced By : ServiceProviderNetworkClassOfServiceUnassignListRequest21 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceUnassignListRequestAsync(this OcipClient client, ServiceProviderNetworkClassOfServiceUnassignListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the service provider's password rules setting applicable to
        /// Administrators (Group and Department) and Users.
        /// The response is either ServiceProviderPasswordRulesGetResponse16 or ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderPasswordRulesGetRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderPasswordRulesGetRequest16Async instead.")]
        public static async Task<ServiceProviderPasswordRulesGetResponse16> ServiceProviderPasswordRulesGetRequest16(this OcipClient client, ServiceProviderPasswordRulesGetRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderPasswordRulesGetResponse16;
        }

        /// <summary>
        /// Requests the service provider's password rules setting applicable to
        /// Administrators (Group and Department) and Users.
        /// The response is either ServiceProviderPasswordRulesGetResponse16 or ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderPasswordRulesGetRequest22 in AS data mode.
        /// </summary>
        public static async Task<ServiceProviderPasswordRulesGetResponse16> ServiceProviderPasswordRulesGetRequest16Async(this OcipClient client, ServiceProviderPasswordRulesGetRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderPasswordRulesGetResponse16;
        }
        /// <summary>
        /// Add number prefixes to a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderRouteListEnterpriseTrunkNumberPrefixAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberPrefixAddListRequest(this OcipClient client, ServiceProviderRouteListEnterpriseTrunkNumberPrefixAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add number prefixes to a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberPrefixAddListRequestAsync(this OcipClient client, ServiceProviderRouteListEnterpriseTrunkNumberPrefixAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add number ranges to a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderRouteListEnterpriseTrunkNumberRangeAddListRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberRangeAddListRequest(this OcipClient client, ServiceProviderRouteListEnterpriseTrunkNumberRangeAddListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add number ranges to a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRouteListEnterpriseTrunkNumberRangeAddListRequestAsync(this OcipClient client, ServiceProviderRouteListEnterpriseTrunkNumberRangeAddListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Create a service pack migration task.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced By: ServiceProviderServicePackMigrationTaskAddRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackMigrationTaskAddRequestAsync instead.")]
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskAddRequest(this OcipClient client, ServiceProviderServicePackMigrationTaskAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Create a service pack migration task.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced By: ServiceProviderServicePackMigrationTaskAddRequest21 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskAddRequestAsync(this OcipClient client, ServiceProviderServicePackMigrationTaskAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests a list of all service pack migration task for a service provider.
        /// The response is either ServiceProviderServicePackMigrationTaskGetListResponse
        /// or ErrorResponse.
        /// 
        /// Replaced By: ServiceProviderServicePackMigrationTaskGetListRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackMigrationTaskGetListRequestAsync instead.")]
        public static async Task<ServiceProviderServicePackMigrationTaskGetListResponse> ServiceProviderServicePackMigrationTaskGetListRequest(this OcipClient client, ServiceProviderServicePackMigrationTaskGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderServicePackMigrationTaskGetListResponse;
        }

        /// <summary>
        /// Requests a list of all service pack migration task for a service provider.
        /// The response is either ServiceProviderServicePackMigrationTaskGetListResponse
        /// or ErrorResponse.
        /// 
        /// Replaced By: ServiceProviderServicePackMigrationTaskGetListRequest21 in AS data mode
        /// </summary>
        public static async Task<ServiceProviderServicePackMigrationTaskGetListResponse> ServiceProviderServicePackMigrationTaskGetListRequestAsync(this OcipClient client, ServiceProviderServicePackMigrationTaskGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderServicePackMigrationTaskGetListResponse;
        }
        /// <summary>
        /// Requests the details of a specified service pack migration task.
        /// The response is either ServiceProviderServicePackMigrationTaskGetResponse14sp4
        /// or ErrorResponse.
        /// 
        /// Replaced By: ServiceProviderServicePackMigrationTaskGetRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderServicePackMigrationTaskGetRequest14sp4Async instead.")]
        public static async Task<ServiceProviderServicePackMigrationTaskGetResponse14sp4> ServiceProviderServicePackMigrationTaskGetRequest14sp4(this OcipClient client, ServiceProviderServicePackMigrationTaskGetRequest14sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderServicePackMigrationTaskGetResponse14sp4;
        }

        /// <summary>
        /// Requests the details of a specified service pack migration task.
        /// The response is either ServiceProviderServicePackMigrationTaskGetResponse14sp4
        /// or ErrorResponse.
        /// 
        /// Replaced By: ServiceProviderServicePackMigrationTaskGetRequest21 in AS data mode
        /// </summary>
        public static async Task<ServiceProviderServicePackMigrationTaskGetResponse14sp4> ServiceProviderServicePackMigrationTaskGetRequest14sp4Async(this OcipClient client, ServiceProviderServicePackMigrationTaskGetRequest14sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderServicePackMigrationTaskGetResponse14sp4;
        }
        /// <summary>
        /// Request to add a system-level access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Repaced By: SystemAccessDeviceAddRequest22
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceAddRequest(this OcipClient client, SystemAccessDeviceAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a system-level access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// Repaced By: SystemAccessDeviceAddRequest22
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceAddRequestAsync(this OcipClient client, SystemAccessDeviceAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a system-level access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useHotline
        /// hotlineContact
        /// deviceExternalId
        /// 
        /// Replaced by: SystemAccessDeviceAddRequest22V2
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceAddRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceAddRequest22(this OcipClient client, SystemAccessDeviceAddRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a system-level access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useHotline
        /// hotlineContact
        /// deviceExternalId
        /// 
        /// Replaced by: SystemAccessDeviceAddRequest22V2
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceAddRequest22Async(this OcipClient client, SystemAccessDeviceAddRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a system-level access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useHotline
        /// hotlineContact
        /// isWebexTeamsDevice
        /// defaultPathHeader
        /// deviceExternalId
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceAddRequest22V2Async instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceAddRequest22V2(this OcipClient client, SystemAccessDeviceAddRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a system-level access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useHotline
        /// hotlineContact
        /// isWebexTeamsDevice
        /// defaultPathHeader
        /// deviceExternalId
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceAddRequest22V2Async(this OcipClient client, SystemAccessDeviceAddRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the configuration of a specified system access device.
        /// The response is either SystemAccessDeviceGetResponse18sp1 or ErrorResponse.
        /// 
        /// Replaced by: SystemAccessDeviceGetRequest22
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceGetRequest18sp1Async instead.")]
        public static async Task<SystemAccessDeviceGetResponse18sp1> SystemAccessDeviceGetRequest18sp1(this OcipClient client, SystemAccessDeviceGetRequest18sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceGetResponse18sp1;
        }

        /// <summary>
        /// Requests the configuration of a specified system access device.
        /// The response is either SystemAccessDeviceGetResponse18sp1 or ErrorResponse.
        /// 
        /// Replaced by: SystemAccessDeviceGetRequest22
        /// </summary>
        public static async Task<SystemAccessDeviceGetResponse18sp1> SystemAccessDeviceGetRequest18sp1Async(this OcipClient client, SystemAccessDeviceGetRequest18sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceGetResponse18sp1;
        }
        /// <summary>
        /// Requests the configuration of a specified system access device.
        /// The response is either SystemAccessDeviceGetResponse22 or ErrorResponse.
        /// 
        /// Replaced by: SystemAccessDeviceGetRequest24
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceGetRequest22Async instead.")]
        public static async Task<SystemAccessDeviceGetResponse22> SystemAccessDeviceGetRequest22(this OcipClient client, SystemAccessDeviceGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceGetResponse22;
        }

        /// <summary>
        /// Requests the configuration of a specified system access device.
        /// The response is either SystemAccessDeviceGetResponse22 or ErrorResponse.
        /// 
        /// Replaced by: SystemAccessDeviceGetRequest24
        /// </summary>
        public static async Task<SystemAccessDeviceGetResponse22> SystemAccessDeviceGetRequest22Async(this OcipClient client, SystemAccessDeviceGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceGetResponse22;
        }
        /// <summary>
        /// Requests the configuration of a specified system access device.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// deviceExternalId
        /// The response is either SystemAccessDeviceGetResponse22V2 or ErrorResponse.
        /// 
        /// Replaced By: SystemAccessDeviceGetRequest24
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceGetRequest22V2Async instead.")]
        public static async Task<SystemAccessDeviceGetResponse22V2> SystemAccessDeviceGetRequest22V2(this OcipClient client, SystemAccessDeviceGetRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceGetResponse22V2;
        }

        /// <summary>
        /// Requests the configuration of a specified system access device.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// deviceExternalId
        /// The response is either SystemAccessDeviceGetResponse22V2 or ErrorResponse.
        /// 
        /// Replaced By: SystemAccessDeviceGetRequest24
        /// </summary>
        public static async Task<SystemAccessDeviceGetResponse22V2> SystemAccessDeviceGetRequest22V2Async(this OcipClient client, SystemAccessDeviceGetRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceGetResponse22V2;
        }
        /// <summary>
        /// Requests the configuration of a specified system access device.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// deviceExternalId
        /// 
        /// The response is either SystemAccessDeviceGetResponse22V3 or ErrorResponse.
        /// 
        /// Replaced By: SystemAccessDeviceGetRequest24
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceGetRequest22V3Async instead.")]
        public static async Task<SystemAccessDeviceGetResponse22V3> SystemAccessDeviceGetRequest22V3(this OcipClient client, SystemAccessDeviceGetRequest22V3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceGetResponse22V3;
        }

        /// <summary>
        /// Requests the configuration of a specified system access device.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// deviceExternalId
        /// 
        /// The response is either SystemAccessDeviceGetResponse22V3 or ErrorResponse.
        /// 
        /// Replaced By: SystemAccessDeviceGetRequest24
        /// </summary>
        public static async Task<SystemAccessDeviceGetResponse22V3> SystemAccessDeviceGetRequest22V3Async(this OcipClient client, SystemAccessDeviceGetRequest22V3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceGetResponse22V3;
        }
        /// <summary>
        /// Requests the configuration of a specified system access device.
        /// The response is either SystemAccessDeviceGetResponse22V4 or ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// deviceExternalId
        /// 
        /// Replaced by: SystemAccessDeviceGetRequest24
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceGetRequest22V4Async instead.")]
        public static async Task<SystemAccessDeviceGetResponse22V4> SystemAccessDeviceGetRequest22V4(this OcipClient client, SystemAccessDeviceGetRequest22V4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceGetResponse22V4;
        }

        /// <summary>
        /// Requests the configuration of a specified system access device.
        /// The response is either SystemAccessDeviceGetResponse22V4 or ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// deviceExternalId
        /// 
        /// Replaced by: SystemAccessDeviceGetRequest24
        /// </summary>
        public static async Task<SystemAccessDeviceGetResponse22V4> SystemAccessDeviceGetRequest22V4Async(this OcipClient client, SystemAccessDeviceGetRequest22V4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceGetResponse22V4;
        }
        /// <summary>
        /// Requests the users associated with a specified system access device.
        /// The response is either SystemAccessDeviceGetUserListResponse or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaAccessDeviceEndpointPrivateIdentity
        /// 
        /// Replaced by: SystemAccessDeviceGetUserListRequest21sp1 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceGetUserListRequestAsync instead.")]
        public static async Task<SystemAccessDeviceGetUserListResponse> SystemAccessDeviceGetUserListRequest(this OcipClient client, SystemAccessDeviceGetUserListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemAccessDeviceGetUserListResponse;
        }

        /// <summary>
        /// Requests the users associated with a specified system access device.
        /// The response is either SystemAccessDeviceGetUserListResponse or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaAccessDeviceEndpointPrivateIdentity
        /// 
        /// Replaced by: SystemAccessDeviceGetUserListRequest21sp1 in AS data mode.
        /// </summary>
        public static async Task<SystemAccessDeviceGetUserListResponse> SystemAccessDeviceGetUserListRequestAsync(this OcipClient client, SystemAccessDeviceGetUserListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemAccessDeviceGetUserListResponse;
        }
        /// <summary>
        /// Request to modify a specified system access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useHotline
        /// hotlineContact
        /// isWebexTeamsDevice
        /// defaultPathHeader
        /// deviceExternalId
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemAccessDeviceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemAccessDeviceModifyRequest(this OcipClient client, SystemAccessDeviceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a specified system access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// useHotline
        /// hotlineContact
        /// isWebexTeamsDevice
        /// defaultPathHeader
        /// deviceExternalId
        /// </summary>
        public static async Task<SuccessResponse> SystemAccessDeviceModifyRequestAsync(this OcipClient client, SystemAccessDeviceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the list of Application Server Registration system parameters.
        /// The response is either SystemASRParametersGetResponse14sp7 or ErrorResponse.
        /// 
        /// Replaced by: SystemASRParametersGetRequest23 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemASRParametersGetRequest14sp7Async instead.")]
        public static async Task<SystemASRParametersGetResponse14sp7> SystemASRParametersGetRequest14sp7(this OcipClient client, SystemASRParametersGetRequest14sp7 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemASRParametersGetResponse14sp7;
        }

        /// <summary>
        /// Request to get the list of Application Server Registration system parameters.
        /// The response is either SystemASRParametersGetResponse14sp7 or ErrorResponse.
        /// 
        /// Replaced by: SystemASRParametersGetRequest23 in AS data mode.
        /// </summary>
        public static async Task<SystemASRParametersGetResponse14sp7> SystemASRParametersGetRequest14sp7Async(this OcipClient client, SystemASRParametersGetRequest14sp7 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemASRParametersGetResponse14sp7;
        }
        /// <summary>
        /// Request the system level data associated with the Busy Lamp
        /// Field service. The response is either a SystemBusyLampFieldGetResponse18 or an ErrorResponse.
        /// 
        /// Replaced by: SystemBusyLampFieldGetRequest23 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBusyLampFieldGetRequest18Async instead.")]
        public static async Task<SystemBusyLampFieldGetResponse18> SystemBusyLampFieldGetRequest18(this OcipClient client, SystemBusyLampFieldGetRequest18 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemBusyLampFieldGetResponse18;
        }

        /// <summary>
        /// Request the system level data associated with the Busy Lamp
        /// Field service. The response is either a SystemBusyLampFieldGetResponse18 or an ErrorResponse.
        /// 
        /// Replaced by: SystemBusyLampFieldGetRequest23 in AS data mode.
        /// </summary>
        public static async Task<SystemBusyLampFieldGetResponse18> SystemBusyLampFieldGetRequest18Async(this OcipClient client, SystemBusyLampFieldGetRequest18 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemBusyLampFieldGetResponse18;
        }
        /// <summary>
        /// Request the system level data associated with the Busy Lamp
        /// Field service. The response is either a SystemBusyLampFieldGetResponse22 or an ErrorResponse.
        /// Replaced by: SystemBusyLampFieldGetRequest23V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBusyLampFieldGetRequest22Async instead.")]
        public static async Task<SystemBusyLampFieldGetResponse22> SystemBusyLampFieldGetRequest22(this OcipClient client, SystemBusyLampFieldGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemBusyLampFieldGetResponse22;
        }

        /// <summary>
        /// Request the system level data associated with the Busy Lamp
        /// Field service. The response is either a SystemBusyLampFieldGetResponse22 or an ErrorResponse.
        /// Replaced by: SystemBusyLampFieldGetRequest23V2 in AS data mode.
        /// </summary>
        public static async Task<SystemBusyLampFieldGetResponse22> SystemBusyLampFieldGetRequest22Async(this OcipClient client, SystemBusyLampFieldGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemBusyLampFieldGetResponse22;
        }
        /// <summary>
        /// Request the system level data associated with the Busy Lamp
        /// Field service. The response is either a SystemBusyLampFieldGetResponse23 or an ErrorResponse.
        /// Replaced by: SystemBusyLampFieldGetRequest23V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemBusyLampFieldGetRequest23Async instead.")]
        public static async Task<SystemBusyLampFieldGetResponse23> SystemBusyLampFieldGetRequest23(this OcipClient client, SystemBusyLampFieldGetRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemBusyLampFieldGetResponse23;
        }

        /// <summary>
        /// Request the system level data associated with the Busy Lamp
        /// Field service. The response is either a SystemBusyLampFieldGetResponse23 or an ErrorResponse.
        /// Replaced by: SystemBusyLampFieldGetRequest23V2 in AS data mode.
        /// </summary>
        public static async Task<SystemBusyLampFieldGetResponse23> SystemBusyLampFieldGetRequest23Async(this OcipClient client, SystemBusyLampFieldGetRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemBusyLampFieldGetResponse23;
        }
        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse21sp2 or an ErrorResponse.
        /// Replaced by: SystemCallProcessingGetPolicyRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingGetPolicyRequest21sp2Async instead.")]
        public static async Task<SystemCallProcessingGetPolicyResponse21sp2> SystemCallProcessingGetPolicyRequest21sp2(this OcipClient client, SystemCallProcessingGetPolicyRequest21sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingGetPolicyResponse21sp2;
        }

        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse21sp2 or an ErrorResponse.
        /// Replaced by: SystemCallProcessingGetPolicyRequest22 in AS data mode.
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse21sp2> SystemCallProcessingGetPolicyRequest21sp2Async(this OcipClient client, SystemCallProcessingGetPolicyRequest21sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingGetPolicyResponse21sp2;
        }
        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse22 or an ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingGetPolicyRequest22V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingGetPolicyRequest22Async instead.")]
        public static async Task<SystemCallProcessingGetPolicyResponse22> SystemCallProcessingGetPolicyRequest22(this OcipClient client, SystemCallProcessingGetPolicyRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingGetPolicyResponse22;
        }

        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse22 or an ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingGetPolicyRequest22V2 in AS data mode.
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse22> SystemCallProcessingGetPolicyRequest22Async(this OcipClient client, SystemCallProcessingGetPolicyRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingGetPolicyResponse22;
        }
        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse22V2 or an ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingGetPolicyRequest23 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingGetPolicyRequest22V2Async instead.")]
        public static async Task<SystemCallProcessingGetPolicyResponse22V2> SystemCallProcessingGetPolicyRequest22V2(this OcipClient client, SystemCallProcessingGetPolicyRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingGetPolicyResponse22V2;
        }

        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse22V2 or an ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingGetPolicyRequest23 in AS data mode.
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse22V2> SystemCallProcessingGetPolicyRequest22V2Async(this OcipClient client, SystemCallProcessingGetPolicyRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingGetPolicyResponse22V2;
        }
        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse22V3 or an ErrorResponse.
        /// Replaced by: SystemCallProcessingGetPolicyResponse23V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingGetPolicyRequest22V3Async instead.")]
        public static async Task<SystemCallProcessingGetPolicyResponse22V3> SystemCallProcessingGetPolicyRequest22V3(this OcipClient client, SystemCallProcessingGetPolicyRequest22V3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingGetPolicyResponse22V3;
        }

        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse22V3 or an ErrorResponse.
        /// Replaced by: SystemCallProcessingGetPolicyResponse23V2 in AS data mode.
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse22V3> SystemCallProcessingGetPolicyRequest22V3Async(this OcipClient client, SystemCallProcessingGetPolicyRequest22V3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingGetPolicyResponse22V3;
        }
        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse23 or an ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingGetPolicyRequest23V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCallProcessingGetPolicyRequest23Async instead.")]
        public static async Task<SystemCallProcessingGetPolicyResponse23> SystemCallProcessingGetPolicyRequest23(this OcipClient client, SystemCallProcessingGetPolicyRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCallProcessingGetPolicyResponse23;
        }

        /// <summary>
        /// The response is either a SystemCallProcessingGetPolicyResponse23 or an ErrorResponse.
        /// 
        /// Replaced by: SystemCallProcessingGetPolicyRequest23V2 in AS data mode.
        /// </summary>
        public static async Task<SystemCallProcessingGetPolicyResponse23> SystemCallProcessingGetPolicyRequest23Async(this OcipClient client, SystemCallProcessingGetPolicyRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCallProcessingGetPolicyResponse23;
        }
        /// <summary>
        /// Request the system level data associated with Communication Barring.
        /// The response is either a SystemCommunicationBarringGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemCommunicationBarringGetRequest21sp1 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringGetRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringGetResponse> SystemCommunicationBarringGetRequest(this OcipClient client, SystemCommunicationBarringGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Communication Barring.
        /// The response is either a SystemCommunicationBarringGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemCommunicationBarringGetRequest21sp1 in AS data mode.
        /// </summary>
        public static async Task<SystemCommunicationBarringGetResponse> SystemCommunicationBarringGetRequestAsync(this OcipClient client, SystemCommunicationBarringGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringGetResponse;
        }
        /// <summary>
        /// Add a new Communication Barring Incoming Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemCommunicationBarringIncomingCriteriaAddRequest22
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringIncomingCriteriaAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringIncomingCriteriaAddRequest(this OcipClient client, SystemCommunicationBarringIncomingCriteriaAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Communication Barring Incoming Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemCommunicationBarringIncomingCriteriaAddRequest22
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringIncomingCriteriaAddRequestAsync(this OcipClient client, SystemCommunicationBarringIncomingCriteriaAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get an existing Communication Barring Incoming Criteria.
        /// The response is either a SystemCommunicationBarringIncomingCriteriaGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemCommunicationBarringIncomingCriteriaGetRequest22
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringIncomingCriteriaGetRequestAsync instead.")]
        public static async Task<SystemCommunicationBarringIncomingCriteriaGetResponse> SystemCommunicationBarringIncomingCriteriaGetRequest(this OcipClient client, SystemCommunicationBarringIncomingCriteriaGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringIncomingCriteriaGetResponse;
        }

        /// <summary>
        /// Get an existing Communication Barring Incoming Criteria.
        /// The response is either a SystemCommunicationBarringIncomingCriteriaGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemCommunicationBarringIncomingCriteriaGetRequest22
        /// </summary>
        public static async Task<SystemCommunicationBarringIncomingCriteriaGetResponse> SystemCommunicationBarringIncomingCriteriaGetRequestAsync(this OcipClient client, SystemCommunicationBarringIncomingCriteriaGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringIncomingCriteriaGetResponse;
        }
        /// <summary>
        /// Add a new Communication Barring Profile.
        /// The priorities for IncomingRules are requantized to consecutive integers as part of the add.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// callMeNowDefaultAction, use value "Block" in XS data mode
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// callMeNowDefaultCallTimeout
        /// callMeNowRule
        /// 
        /// Replaced by: SystemCommunicationBarringProfileAddRequest19sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringProfileAddRequest17sp3Async instead.")]
        public static async Task<SuccessResponse> SystemCommunicationBarringProfileAddRequest17sp3(this OcipClient client, SystemCommunicationBarringProfileAddRequest17sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Communication Barring Profile.
        /// The priorities for IncomingRules are requantized to consecutive integers as part of the add.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// callMeNowDefaultAction, use value "Block" in XS data mode
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// callMeNowDefaultCallTimeout
        /// callMeNowRule
        /// 
        /// Replaced by: SystemCommunicationBarringProfileAddRequest19sp1 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemCommunicationBarringProfileAddRequest17sp3Async(this OcipClient client, SystemCommunicationBarringProfileAddRequest17sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a SystemCommunicationBarringProfileGetResponse17sp3 or an ErrorResponse.
        /// 
        /// Replaced by: SystemCommunicationBarringProfileGetRequest19sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringProfileGetRequest17sp3Async instead.")]
        public static async Task<SystemCommunicationBarringProfileGetResponse17sp3> SystemCommunicationBarringProfileGetRequest17sp3(this OcipClient client, SystemCommunicationBarringProfileGetRequest17sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringProfileGetResponse17sp3;
        }

        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a SystemCommunicationBarringProfileGetResponse17sp3 or an ErrorResponse.
        /// 
        /// Replaced by: SystemCommunicationBarringProfileGetRequest19sp1 in AS data mode
        /// </summary>
        public static async Task<SystemCommunicationBarringProfileGetResponse17sp3> SystemCommunicationBarringProfileGetRequest17sp3Async(this OcipClient client, SystemCommunicationBarringProfileGetRequest17sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringProfileGetResponse17sp3;
        }
        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a SystemCommunicationBarringProfileGetResponse19sp1 or an ErrorResponse.
        /// 
        /// Replaced by: SystemCommunicationBarringProfileGetRequest19sp1V2 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemCommunicationBarringProfileGetRequest19sp1Async instead.")]
        public static async Task<SystemCommunicationBarringProfileGetResponse19sp1> SystemCommunicationBarringProfileGetRequest19sp1(this OcipClient client, SystemCommunicationBarringProfileGetRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemCommunicationBarringProfileGetResponse19sp1;
        }

        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a SystemCommunicationBarringProfileGetResponse19sp1 or an ErrorResponse.
        /// 
        /// Replaced by: SystemCommunicationBarringProfileGetRequest19sp1V2 in AS data mode
        /// </summary>
        public static async Task<SystemCommunicationBarringProfileGetResponse19sp1> SystemCommunicationBarringProfileGetRequest19sp1Async(this OcipClient client, SystemCommunicationBarringProfileGetRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemCommunicationBarringProfileGetResponse19sp1;
        }
        /// <summary>
        /// Request to get the File System parameters.
        /// The response is either SystemConfigurableFileSystemGetResponse or ErrorResponse.
        /// Replaced by: SystemConfigurableFileSystemGetRequest23
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemConfigurableFileSystemGetRequestAsync instead.")]
        public static async Task<SystemConfigurableFileSystemGetResponse> SystemConfigurableFileSystemGetRequest(this OcipClient client, SystemConfigurableFileSystemGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemConfigurableFileSystemGetResponse;
        }

        /// <summary>
        /// Request to get the File System parameters.
        /// The response is either SystemConfigurableFileSystemGetResponse or ErrorResponse.
        /// Replaced by: SystemConfigurableFileSystemGetRequest23
        /// </summary>
        public static async Task<SystemConfigurableFileSystemGetResponse> SystemConfigurableFileSystemGetRequestAsync(this OcipClient client, SystemConfigurableFileSystemGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemConfigurableFileSystemGetResponse;
        }
        /// <summary>
        /// Request to get the File System parameters.
        /// The response is either SystemConfigurableFileSystemGetResponse22 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemConfigurableFileSystemGetRequest22Async instead.")]
        public static async Task<SystemConfigurableFileSystemGetResponse22> SystemConfigurableFileSystemGetRequest22(this OcipClient client, SystemConfigurableFileSystemGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemConfigurableFileSystemGetResponse22;
        }

        /// <summary>
        /// Request to get the File System parameters.
        /// The response is either SystemConfigurableFileSystemGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<SystemConfigurableFileSystemGetResponse22> SystemConfigurableFileSystemGetRequest22Async(this OcipClient client, SystemConfigurableFileSystemGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemConfigurableFileSystemGetResponse22;
        }
        /// <summary>
        /// Request to get the File System parameters.
        /// change of behavior is that CLI System/MediaFileSystem/get will no longer show the password
        /// The response is either SystemConfigurableFileSystemGetResponse23 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemConfigurableFileSystemGetRequest23Async instead.")]
        public static async Task<SystemConfigurableFileSystemGetResponse23> SystemConfigurableFileSystemGetRequest23(this OcipClient client, SystemConfigurableFileSystemGetRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemConfigurableFileSystemGetResponse23;
        }

        /// <summary>
        /// Request to get the File System parameters.
        /// change of behavior is that CLI System/MediaFileSystem/get will no longer show the password
        /// The response is either SystemConfigurableFileSystemGetResponse23 or ErrorResponse.
        /// </summary>
        public static async Task<SystemConfigurableFileSystemGetResponse23> SystemConfigurableFileSystemGetRequest23Async(this OcipClient client, SystemConfigurableFileSystemGetRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemConfigurableFileSystemGetResponse23;
        }
        /// <summary>
        /// Request to get the list of custom configuration tag sets managed by the Device Management System.
        /// The response is either SystemDeviceManagementTagSetGetListResponse or ErrorResponse.
        /// 
        /// Replaced by SystemDeviceManagementTagSetGetListRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceManagementTagSetGetListRequestAsync instead.")]
        public static async Task<SystemDeviceManagementTagSetGetListResponse> SystemDeviceManagementTagSetGetListRequest(this OcipClient client, SystemDeviceManagementTagSetGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceManagementTagSetGetListResponse;
        }

        /// <summary>
        /// Request to get the list of custom configuration tag sets managed by the Device Management System.
        /// The response is either SystemDeviceManagementTagSetGetListResponse or ErrorResponse.
        /// 
        /// Replaced by SystemDeviceManagementTagSetGetListRequest22 in AS data mode.
        /// </summary>
        public static async Task<SystemDeviceManagementTagSetGetListResponse> SystemDeviceManagementTagSetGetListRequestAsync(this OcipClient client, SystemDeviceManagementTagSetGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceManagementTagSetGetListResponse;
        }
        /// <summary>
        /// Requests a list of non-obsolete Identity/device profile types defined in the system. It is possible
        /// to get either all conference device types or all non-conferernce types. This command is similar
        /// to the SystemSIPDeviceTypeGetListRequest and SystemMGCPDeviceTypeGetListRequest
        /// but gets both SIP and MGCP types.
        /// The response is either SystemDeviceTypeGetAvailableListResponse19 or ErrorResponse.
        /// Replaced by SystemDeviceTypeGetAvailableListRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceTypeGetAvailableListRequest19Async instead.")]
        public static async Task<SystemDeviceTypeGetAvailableListResponse19> SystemDeviceTypeGetAvailableListRequest19(this OcipClient client, SystemDeviceTypeGetAvailableListRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceTypeGetAvailableListResponse19;
        }

        /// <summary>
        /// Requests a list of non-obsolete Identity/device profile types defined in the system. It is possible
        /// to get either all conference device types or all non-conferernce types. This command is similar
        /// to the SystemSIPDeviceTypeGetListRequest and SystemMGCPDeviceTypeGetListRequest
        /// but gets both SIP and MGCP types.
        /// The response is either SystemDeviceTypeGetAvailableListResponse19 or ErrorResponse.
        /// Replaced by SystemDeviceTypeGetAvailableListRequest22 in AS data mode.
        /// </summary>
        public static async Task<SystemDeviceTypeGetAvailableListResponse19> SystemDeviceTypeGetAvailableListRequest19Async(this OcipClient client, SystemDeviceTypeGetAvailableListRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceTypeGetAvailableListResponse19;
        }
        /// <summary>
        /// Requests the information about the specified device type without regard to whether the
        /// type is SIP or MGCP.
        /// The response is either SystemDeviceTypeGetResponse22V2 or ErrorResponse.
        /// Note: The elements deviceTypeConfigurationOption and staticLineOrdering apply to SIP device types only. Therefore, only present in the response when the device type is SIP.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceTypeGetRequest22V2Async instead.")]
        public static async Task<SystemDeviceTypeGetResponse22V2> SystemDeviceTypeGetRequest22V2(this OcipClient client, SystemDeviceTypeGetRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceTypeGetResponse22V2;
        }

        /// <summary>
        /// Requests the information about the specified device type without regard to whether the
        /// type is SIP or MGCP.
        /// The response is either SystemDeviceTypeGetResponse22V2 or ErrorResponse.
        /// Note: The elements deviceTypeConfigurationOption and staticLineOrdering apply to SIP device types only. Therefore, only present in the response when the device type is SIP.
        /// </summary>
        public static async Task<SystemDeviceTypeGetResponse22V2> SystemDeviceTypeGetRequest22V2Async(this OcipClient client, SystemDeviceTypeGetRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceTypeGetResponse22V2;
        }
        /// <summary>
        /// Requests the information about the specified device type without regard to whether the
        /// type is SIP or MGCP.
        /// The response is either SystemDeviceTypeGetResponse22V3 or ErrorResponse.
        /// Note: The elements deviceTypeConfigurationOption and staticLineOrdering apply to SIP device types only. Therefore, only present in the response when the device type is SIP.
        /// 
        /// Replaced by: SystemDeviceTypeGetRequest22V4
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceTypeGetRequest22V3Async instead.")]
        public static async Task<SystemDeviceTypeGetResponse22V3> SystemDeviceTypeGetRequest22V3(this OcipClient client, SystemDeviceTypeGetRequest22V3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceTypeGetResponse22V3;
        }

        /// <summary>
        /// Requests the information about the specified device type without regard to whether the
        /// type is SIP or MGCP.
        /// The response is either SystemDeviceTypeGetResponse22V3 or ErrorResponse.
        /// Note: The elements deviceTypeConfigurationOption and staticLineOrdering apply to SIP device types only. Therefore, only present in the response when the device type is SIP.
        /// 
        /// Replaced by: SystemDeviceTypeGetRequest22V4
        /// </summary>
        public static async Task<SystemDeviceTypeGetResponse22V3> SystemDeviceTypeGetRequest22V3Async(this OcipClient client, SystemDeviceTypeGetRequest22V3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceTypeGetResponse22V3;
        }
        /// <summary>
        /// Requests the information about the specified device type without regard to whether the
        /// type is SIP or MGCP.
        /// The response is either SystemDeviceTypeGetResponse22V4 or ErrorResponse.
        /// 
        /// Note: The elements deviceTypeConfigurationOption and staticLineOrdering apply to SIP device types only. Therefore, only present in the response when the device type is SIP.
        /// 
        /// Replaced by: SystemDeviceTypeGetRequest22V5.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDeviceTypeGetRequest22V4Async instead.")]
        public static async Task<SystemDeviceTypeGetResponse22V4> SystemDeviceTypeGetRequest22V4(this OcipClient client, SystemDeviceTypeGetRequest22V4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDeviceTypeGetResponse22V4;
        }

        /// <summary>
        /// Requests the information about the specified device type without regard to whether the
        /// type is SIP or MGCP.
        /// The response is either SystemDeviceTypeGetResponse22V4 or ErrorResponse.
        /// 
        /// Note: The elements deviceTypeConfigurationOption and staticLineOrdering apply to SIP device types only. Therefore, only present in the response when the device type is SIP.
        /// 
        /// Replaced by: SystemDeviceTypeGetRequest22V5.
        /// </summary>
        public static async Task<SystemDeviceTypeGetResponse22V4> SystemDeviceTypeGetRequest22V4Async(this OcipClient client, SystemDeviceTypeGetRequest22V4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDeviceTypeGetResponse22V4;
        }
        /// <summary>
        /// Request the system level data associated with Dial Plan Policy.
        /// The response is either a SystemDialPlanPolicyGetResponse17 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemDialPlanPolicyGetRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialPlanPolicyGetRequest17Async instead.")]
        public static async Task<SystemDialPlanPolicyGetResponse17> SystemDialPlanPolicyGetRequest17(this OcipClient client, SystemDialPlanPolicyGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDialPlanPolicyGetResponse17;
        }

        /// <summary>
        /// Request the system level data associated with Dial Plan Policy.
        /// The response is either a SystemDialPlanPolicyGetResponse17 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemDialPlanPolicyGetRequest22 in AS data mode.
        /// </summary>
        public static async Task<SystemDialPlanPolicyGetResponse17> SystemDialPlanPolicyGetRequest17Async(this OcipClient client, SystemDialPlanPolicyGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDialPlanPolicyGetResponse17;
        }
        /// <summary>
        /// Request the system level data associated with Dial Plan Policy.
        /// The response is either a SystemDialPlanPolicyGetResponse22 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemDialPlanPolicyGetRequest22V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDialPlanPolicyGetRequest22Async instead.")]
        public static async Task<SystemDialPlanPolicyGetResponse22> SystemDialPlanPolicyGetRequest22(this OcipClient client, SystemDialPlanPolicyGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDialPlanPolicyGetResponse22;
        }

        /// <summary>
        /// Request the system level data associated with Dial Plan Policy.
        /// The response is either a SystemDialPlanPolicyGetResponse22 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: SystemDialPlanPolicyGetRequest22V2 in AS data mode.
        /// </summary>
        public static async Task<SystemDialPlanPolicyGetResponse22> SystemDialPlanPolicyGetRequest22Async(this OcipClient client, SystemDialPlanPolicyGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDialPlanPolicyGetResponse22;
        }
        /// <summary>
        /// Requests the list of all system-level domain names.
        /// The response is either SystemDomainGetListResponse or ErrorResponse.
        /// 
        /// Replaced by SystemDomainGetListRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemDomainGetListRequestAsync instead.")]
        public static async Task<SystemDomainGetListResponse> SystemDomainGetListRequest(this OcipClient client, SystemDomainGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemDomainGetListResponse;
        }

        /// <summary>
        /// Requests the list of all system-level domain names.
        /// The response is either SystemDomainGetListResponse or ErrorResponse.
        /// 
        /// Replaced by SystemDomainGetListRequest22 in AS data mode.
        /// </summary>
        public static async Task<SystemDomainGetListResponse> SystemDomainGetListRequestAsync(this OcipClient client, SystemDomainGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemDomainGetListResponse;
        }
        /// <summary>
        /// Request to get list of default Feature Access Codes defined on system level.
        /// The response is either SystemFeatureAccessCodeGetListResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemFeatureAccessCodeGetListRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFeatureAccessCodeGetListRequestAsync instead.")]
        public static async Task<SystemFeatureAccessCodeGetListResponse> SystemFeatureAccessCodeGetListRequest(this OcipClient client, SystemFeatureAccessCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemFeatureAccessCodeGetListResponse;
        }

        /// <summary>
        /// Request to get list of default Feature Access Codes defined on system level.
        /// The response is either SystemFeatureAccessCodeGetListResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemFeatureAccessCodeGetListRequest21 in AS data mode
        /// </summary>
        public static async Task<SystemFeatureAccessCodeGetListResponse> SystemFeatureAccessCodeGetListRequestAsync(this OcipClient client, SystemFeatureAccessCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemFeatureAccessCodeGetListResponse;
        }
        /// <summary>
        /// Modify default Feature Access Codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemFeatureAccessCodeModifyListRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemFeatureAccessCodeModifyListRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemFeatureAccessCodeModifyListRequest(this OcipClient client, SystemFeatureAccessCodeModifyListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify default Feature Access Codes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemFeatureAccessCodeModifyListRequest21 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemFeatureAccessCodeModifyListRequestAsync(this OcipClient client, SystemFeatureAccessCodeModifyListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with Hunt Group.
        /// The response is either a SystemHuntGroupGetResponse or an
        /// ErrorResponse.
        /// Replaced by: SystemHuntGroupGetRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemHuntGroupGetRequest17Async instead.")]
        public static async Task<SystemHuntGroupGetResponse> SystemHuntGroupGetRequest17(this OcipClient client, SystemHuntGroupGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemHuntGroupGetResponse;
        }

        /// <summary>
        /// Request the system level data associated with Hunt Group.
        /// The response is either a SystemHuntGroupGetResponse or an
        /// ErrorResponse.
        /// Replaced by: SystemHuntGroupGetRequest21 in AS data mode
        /// </summary>
        public static async Task<SystemHuntGroupGetResponse> SystemHuntGroupGetRequest17Async(this OcipClient client, SystemHuntGroupGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemHuntGroupGetResponse;
        }
        /// <summary>
        /// Modify the system level data associated with Hunt Group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by: SystemHuntGroupModifyRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemHuntGroupModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemHuntGroupModifyRequest(this OcipClient client, SystemHuntGroupModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Hunt Group.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by: SystemHuntGroupModifyRequest21 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemHuntGroupModifyRequestAsync(this OcipClient client, SystemHuntGroupModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the system Integrated IMP service attributes.
        /// The response is either SystemIntegratedIMPGetResponse19 or ErrorResponse.
        /// 
        /// Replaced by: SystemIntegratedIMPGetRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemIntegratedIMPGetRequest19Async instead.")]
        public static async Task<SystemIntegratedIMPGetResponse19> SystemIntegratedIMPGetRequest19(this OcipClient client, SystemIntegratedIMPGetRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemIntegratedIMPGetResponse19;
        }

        /// <summary>
        /// Get the system Integrated IMP service attributes.
        /// The response is either SystemIntegratedIMPGetResponse19 or ErrorResponse.
        /// 
        /// Replaced by: SystemIntegratedIMPGetRequest21 in AS data mode
        /// </summary>
        public static async Task<SystemIntegratedIMPGetResponse19> SystemIntegratedIMPGetRequest19Async(this OcipClient client, SystemIntegratedIMPGetRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemIntegratedIMPGetResponse19;
        }
        /// <summary>
        /// Request to get the list of system licenses in the system.
        /// The response is either a SystemLicensingGetSystemLicenseListResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemLicensingGetSystemLicenseListRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLicensingGetSystemLicenseListRequestAsync instead.")]
        public static async Task<SystemLicensingGetSystemLicenseListResponse> SystemLicensingGetSystemLicenseListRequest(this OcipClient client, SystemLicensingGetSystemLicenseListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemLicensingGetSystemLicenseListResponse;
        }

        /// <summary>
        /// Request to get the list of system licenses in the system.
        /// The response is either a SystemLicensingGetSystemLicenseListResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemLicensingGetSystemLicenseListRequest21 in AS data mode
        /// </summary>
        public static async Task<SystemLicensingGetSystemLicenseListResponse> SystemLicensingGetSystemLicenseListRequestAsync(this OcipClient client, SystemLicensingGetSystemLicenseListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemLicensingGetSystemLicenseListResponse;
        }
        /// <summary>
        /// Request to get the list of system licenses in the system.
        /// The response is either a SystemLicensingGetSystemLicenseListResponse21 or an ErrorResponse.
        /// 
        /// Replaced by: SystemLicensingGetSystemLicenseListRequest21sp1.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLicensingGetSystemLicenseListRequest19sp1Async instead.")]
        public static async Task<SystemLicensingGetSystemLicenseListResponse21> SystemLicensingGetSystemLicenseListRequest19sp1(this OcipClient client, SystemLicensingGetSystemLicenseListRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemLicensingGetSystemLicenseListResponse21;
        }

        /// <summary>
        /// Request to get the list of system licenses in the system.
        /// The response is either a SystemLicensingGetSystemLicenseListResponse21 or an ErrorResponse.
        /// 
        /// Replaced by: SystemLicensingGetSystemLicenseListRequest21sp1.
        /// </summary>
        public static async Task<SystemLicensingGetSystemLicenseListResponse21> SystemLicensingGetSystemLicenseListRequest19sp1Async(this OcipClient client, SystemLicensingGetSystemLicenseListRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemLicensingGetSystemLicenseListResponse21;
        }
        /// <summary>
        /// Request to get the list of system licenses in the system.
        /// The response is either a SystemLicensingGetSystemLicenseListResponse21 or an ErrorResponse.
        /// 
        /// Replaced by: SystemLicensingGetSystemLicenseListRequest21p1.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLicensingGetSystemLicenseListRequest21Async instead.")]
        public static async Task<SystemLicensingGetSystemLicenseListResponse21> SystemLicensingGetSystemLicenseListRequest21(this OcipClient client, SystemLicensingGetSystemLicenseListRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemLicensingGetSystemLicenseListResponse21;
        }

        /// <summary>
        /// Request to get the list of system licenses in the system.
        /// The response is either a SystemLicensingGetSystemLicenseListResponse21 or an ErrorResponse.
        /// 
        /// Replaced by: SystemLicensingGetSystemLicenseListRequest21p1.
        /// </summary>
        public static async Task<SystemLicensingGetSystemLicenseListResponse21> SystemLicensingGetSystemLicenseListRequest21Async(this OcipClient client, SystemLicensingGetSystemLicenseListRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemLicensingGetSystemLicenseListResponse21;
        }
        /// <summary>
        /// Request to get the list of system licenses in the system.
        /// The response is either a SystemLicensingGetSystemLicenseListResponse21sp1 or an ErrorResponse.
        /// 
        /// Replaced by: SystemLicensingGetSystemLicenseListRequest22.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLicensingGetSystemLicenseListRequest21sp1Async instead.")]
        public static async Task<SystemLicensingGetSystemLicenseListResponse21sp1> SystemLicensingGetSystemLicenseListRequest21sp1(this OcipClient client, SystemLicensingGetSystemLicenseListRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemLicensingGetSystemLicenseListResponse21sp1;
        }

        /// <summary>
        /// Request to get the list of system licenses in the system.
        /// The response is either a SystemLicensingGetSystemLicenseListResponse21sp1 or an ErrorResponse.
        /// 
        /// Replaced by: SystemLicensingGetSystemLicenseListRequest22.
        /// </summary>
        public static async Task<SystemLicensingGetSystemLicenseListResponse21sp1> SystemLicensingGetSystemLicenseListRequest21sp1Async(this OcipClient client, SystemLicensingGetSystemLicenseListRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemLicensingGetSystemLicenseListResponse21sp1;
        }
        /// <summary>
        /// Request to get the list of system licenses in the system.
        /// The response is either a SystemLicensingGetSystemLicenseListResponse22 or an ErrorResponse.
        /// 
        /// Replaced by: SystemLicensingGetSystemLicenseListRequest22V2.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemLicensingGetSystemLicenseListRequest22Async instead.")]
        public static async Task<SystemLicensingGetSystemLicenseListResponse22> SystemLicensingGetSystemLicenseListRequest22(this OcipClient client, SystemLicensingGetSystemLicenseListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemLicensingGetSystemLicenseListResponse22;
        }

        /// <summary>
        /// Request to get the list of system licenses in the system.
        /// The response is either a SystemLicensingGetSystemLicenseListResponse22 or an ErrorResponse.
        /// 
        /// Replaced by: SystemLicensingGetSystemLicenseListRequest22V2.
        /// </summary>
        public static async Task<SystemLicensingGetSystemLicenseListResponse22> SystemLicensingGetSystemLicenseListRequest22Async(this OcipClient client, SystemLicensingGetSystemLicenseListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemLicensingGetSystemLicenseListResponse22;
        }
        /// <summary>
        /// Get an existing Network Class of Service.
        /// The response is either a SystemNetworkClassOfServiceGetResponse17
        /// or an ErrorResponse.
        /// 
        /// Replaced by: SystemNetworkClassOfServiceGetRequest19sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkClassOfServiceGetRequest17Async instead.")]
        public static async Task<SystemNetworkClassOfServiceGetResponse17> SystemNetworkClassOfServiceGetRequest17(this OcipClient client, SystemNetworkClassOfServiceGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkClassOfServiceGetResponse17;
        }

        /// <summary>
        /// Get an existing Network Class of Service.
        /// The response is either a SystemNetworkClassOfServiceGetResponse17
        /// or an ErrorResponse.
        /// 
        /// Replaced by: SystemNetworkClassOfServiceGetRequest19sp1 in AS data mode
        /// </summary>
        public static async Task<SystemNetworkClassOfServiceGetResponse17> SystemNetworkClassOfServiceGetRequest17Async(this OcipClient client, SystemNetworkClassOfServiceGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkClassOfServiceGetResponse17;
        }
        /// <summary>
        /// Request to get the list of Network Server Sync system parameters.
        /// The response is either SystemNetworkServerSyncParametersGetResponse17sp4 or ErrorResponse.
        /// 
        /// Replaced by: SystemNetworkServerSyncParametersGetRequest24
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkServerSyncParametersGetRequest17sp4Async instead.")]
        public static async Task<SystemNetworkServerSyncParametersGetResponse17sp4> SystemNetworkServerSyncParametersGetRequest17sp4(this OcipClient client, SystemNetworkServerSyncParametersGetRequest17sp4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkServerSyncParametersGetResponse17sp4;
        }

        /// <summary>
        /// Request to get the list of Network Server Sync system parameters.
        /// The response is either SystemNetworkServerSyncParametersGetResponse17sp4 or ErrorResponse.
        /// 
        /// Replaced by: SystemNetworkServerSyncParametersGetRequest24
        /// </summary>
        public static async Task<SystemNetworkServerSyncParametersGetResponse17sp4> SystemNetworkServerSyncParametersGetRequest17sp4Async(this OcipClient client, SystemNetworkServerSyncParametersGetRequest17sp4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkServerSyncParametersGetResponse17sp4;
        }
        /// <summary>
        /// Request to get the list of Network Server Sync system parameters.
        /// The response is either SystemNetworkServerSyncParametersGetResponse22 or ErrorResponse.
        /// 
        /// Replaced by: SystemNetworkServerSyncParametersGetRequest24V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkServerSyncParametersGetRequest22Async instead.")]
        public static async Task<SystemNetworkServerSyncParametersGetResponse22> SystemNetworkServerSyncParametersGetRequest22(this OcipClient client, SystemNetworkServerSyncParametersGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkServerSyncParametersGetResponse22;
        }

        /// <summary>
        /// Request to get the list of Network Server Sync system parameters.
        /// The response is either SystemNetworkServerSyncParametersGetResponse22 or ErrorResponse.
        /// 
        /// Replaced by: SystemNetworkServerSyncParametersGetRequest24V2 in AS data mode.
        /// </summary>
        public static async Task<SystemNetworkServerSyncParametersGetResponse22> SystemNetworkServerSyncParametersGetRequest22Async(this OcipClient client, SystemNetworkServerSyncParametersGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkServerSyncParametersGetResponse22;
        }
        /// <summary>
        /// Request to get the list of Network Server Sync system parameters.
        /// The response is either SystemNetworkServerSyncParametersGetResponse24 or ErrorResponse.
        /// 
        /// Replaced by: SystemNetworkServerSyncParametersGetRequest24V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNetworkServerSyncParametersGetRequest24Async instead.")]
        public static async Task<SystemNetworkServerSyncParametersGetResponse24> SystemNetworkServerSyncParametersGetRequest24(this OcipClient client, SystemNetworkServerSyncParametersGetRequest24 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNetworkServerSyncParametersGetResponse24;
        }

        /// <summary>
        /// Request to get the list of Network Server Sync system parameters.
        /// The response is either SystemNetworkServerSyncParametersGetResponse24 or ErrorResponse.
        /// 
        /// Replaced by: SystemNetworkServerSyncParametersGetRequest24V2 in AS data mode.
        /// </summary>
        public static async Task<SystemNetworkServerSyncParametersGetResponse24> SystemNetworkServerSyncParametersGetRequest24Async(this OcipClient client, SystemNetworkServerSyncParametersGetRequest24 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNetworkServerSyncParametersGetResponse24;
        }
        /// <summary>
        /// Request to get the Number Activation state.
        /// The response is either SystemNumberActivationGetResponse18sp1 or ErrorResponse.
        /// Replaced by: SystemNumberActivationGetRequest21
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemNumberActivationGetRequest18sp1Async instead.")]
        public static async Task<SystemNumberActivationGetResponse18sp1> SystemNumberActivationGetRequest18sp1(this OcipClient client, SystemNumberActivationGetRequest18sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemNumberActivationGetResponse18sp1;
        }

        /// <summary>
        /// Request to get the Number Activation state.
        /// The response is either SystemNumberActivationGetResponse18sp1 or ErrorResponse.
        /// Replaced by: SystemNumberActivationGetRequest21
        /// </summary>
        public static async Task<SystemNumberActivationGetResponse18sp1> SystemNumberActivationGetRequest18sp1Async(this OcipClient client, SystemNumberActivationGetRequest18sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemNumberActivationGetResponse18sp1;
        }
        /// <summary>
        /// Add an application to the OCI call control application list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemOCICallControlApplicationAddRequest22
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemOCICallControlApplicationAddRequest17Async instead.")]
        public static async Task<SuccessResponse> SystemOCICallControlApplicationAddRequest17(this OcipClient client, SystemOCICallControlApplicationAddRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add an application to the OCI call control application list.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemOCICallControlApplicationAddRequest22
        /// </summary>
        public static async Task<SuccessResponse> SystemOCICallControlApplicationAddRequest17Async(this OcipClient client, SystemOCICallControlApplicationAddRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests the system's password rules setting applicable to
        /// System administrator, Provisioning Administrator,
        /// and/or Service Provider Administrator, Group Administrator, Department Administrator, user.
        /// The response is either SystemPasswordRulesGetResponse16 or ErrorResponse.
        /// 
        /// Replaced by: SystemPasswordRulesGetRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPasswordRulesGetRequest16Async instead.")]
        public static async Task<SystemPasswordRulesGetResponse16> SystemPasswordRulesGetRequest16(this OcipClient client, SystemPasswordRulesGetRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPasswordRulesGetResponse16;
        }

        /// <summary>
        /// Requests the system's password rules setting applicable to
        /// System administrator, Provisioning Administrator,
        /// and/or Service Provider Administrator, Group Administrator, Department Administrator, user.
        /// The response is either SystemPasswordRulesGetResponse16 or ErrorResponse.
        /// 
        /// Replaced by: SystemPasswordRulesGetRequest22 in AS data mode.
        /// </summary>
        public static async Task<SystemPasswordRulesGetResponse16> SystemPasswordRulesGetRequest16Async(this OcipClient client, SystemPasswordRulesGetRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPasswordRulesGetResponse16;
        }
        /// <summary>
        /// Requests the system's password rules setting applicable to
        /// System administrator, Provisioning Administrator,
        /// and/or Service Provider Administrator, Group Administrator, Department Administrator, user.
        /// The response is either SystemPasswordRulesGetResponse22 or ErrorResponse.
        /// 
        /// Replaced by: SystemPasswordRulesGetRequest23 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPasswordRulesGetRequest22Async instead.")]
        public static async Task<SystemPasswordRulesGetResponse22> SystemPasswordRulesGetRequest22(this OcipClient client, SystemPasswordRulesGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPasswordRulesGetResponse22;
        }

        /// <summary>
        /// Requests the system's password rules setting applicable to
        /// System administrator, Provisioning Administrator,
        /// and/or Service Provider Administrator, Group Administrator, Department Administrator, user.
        /// The response is either SystemPasswordRulesGetResponse22 or ErrorResponse.
        /// 
        /// Replaced by: SystemPasswordRulesGetRequest23 in AS data mode.
        /// </summary>
        public static async Task<SystemPasswordRulesGetResponse22> SystemPasswordRulesGetRequest22Async(this OcipClient client, SystemPasswordRulesGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPasswordRulesGetResponse22;
        }
        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse18 or ErrorResponse.
        /// 
        /// Replaced by: SystemPolicyGetDefaultRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPolicyGetDefaultRequest18Async instead.")]
        public static async Task<SystemPolicyGetDefaultResponse18> SystemPolicyGetDefaultRequest18(this OcipClient client, SystemPolicyGetDefaultRequest18 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPolicyGetDefaultResponse18;
        }

        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse18 or ErrorResponse.
        /// 
        /// Replaced by: SystemPolicyGetDefaultRequest20 in AS data mode
        /// </summary>
        public static async Task<SystemPolicyGetDefaultResponse18> SystemPolicyGetDefaultRequest18Async(this OcipClient client, SystemPolicyGetDefaultRequest18 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPolicyGetDefaultResponse18;
        }
        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse19sp1 or ErrorResponse.
        /// 
        /// Replaced by: SystemPolicyGetDefaultRequest20 in AS mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPolicyGetDefaultRequest19sp1Async instead.")]
        public static async Task<SystemPolicyGetDefaultResponse19sp1> SystemPolicyGetDefaultRequest19sp1(this OcipClient client, SystemPolicyGetDefaultRequest19sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPolicyGetDefaultResponse19sp1;
        }

        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse19sp1 or ErrorResponse.
        /// 
        /// Replaced by: SystemPolicyGetDefaultRequest20 in AS mode
        /// </summary>
        public static async Task<SystemPolicyGetDefaultResponse19sp1> SystemPolicyGetDefaultRequest19sp1Async(this OcipClient client, SystemPolicyGetDefaultRequest19sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPolicyGetDefaultResponse19sp1;
        }
        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse20 or ErrorResponse.
        /// 
        /// Replaced by: SystemPolicyGetDefaultRequest22 in AS mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPolicyGetDefaultRequest20Async instead.")]
        public static async Task<SystemPolicyGetDefaultResponse20> SystemPolicyGetDefaultRequest20(this OcipClient client, SystemPolicyGetDefaultRequest20 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemPolicyGetDefaultResponse20;
        }

        /// <summary>
        /// Requests the system's default policy settings.
        /// The response is either SystemPolicyGetDefaultResponse20 or ErrorResponse.
        /// 
        /// Replaced by: SystemPolicyGetDefaultRequest22 in AS mode
        /// </summary>
        public static async Task<SystemPolicyGetDefaultResponse20> SystemPolicyGetDefaultRequest20Async(this OcipClient client, SystemPolicyGetDefaultRequest20 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemPolicyGetDefaultResponse20;
        }
        /// <summary>
        /// Request to modify the system's default policy settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// GroupAdminDialableCallerIDAccess
        /// ServiceProviderAdminDialableCallerIDAccess
        /// GroupAdminCommunicationBarringUserProfileAccess (This element is only used for groups in an Enterprise)
        /// GroupAdminVerifyTranslationAndRoutingAccess
        /// ServiceProviderVerifyTranslationAndRoutingAccess
        /// groupUserAutoAttendantNameDialingAccess
        /// The following elements are only used in XS data mode:
        /// serviceProviderAdminCommunicationBarringAccess
        /// 
        /// Replaced by: SystemPolicyModifyDefaultRequest22 in AS mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemPolicyModifyDefaultRequest14Async instead.")]
        public static async Task<SuccessResponse> SystemPolicyModifyDefaultRequest14(this OcipClient client, SystemPolicyModifyDefaultRequest14 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the system's default policy settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// GroupAdminDialableCallerIDAccess
        /// ServiceProviderAdminDialableCallerIDAccess
        /// GroupAdminCommunicationBarringUserProfileAccess (This element is only used for groups in an Enterprise)
        /// GroupAdminVerifyTranslationAndRoutingAccess
        /// ServiceProviderVerifyTranslationAndRoutingAccess
        /// groupUserAutoAttendantNameDialingAccess
        /// The following elements are only used in XS data mode:
        /// serviceProviderAdminCommunicationBarringAccess
        /// 
        /// Replaced by: SystemPolicyModifyDefaultRequest22 in AS mode
        /// </summary>
        public static async Task<SuccessResponse> SystemPolicyModifyDefaultRequest14Async(this OcipClient client, SystemPolicyModifyDefaultRequest14 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get the system's provisioning validation attributes.
        /// The response is either a SystemProvisioningValidationGetResponse14sp2 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemProvisioningValidationGetRequest14sp2Async instead.")]
        public static async Task<SystemProvisioningValidationGetResponse14sp2> SystemProvisioningValidationGetRequest14sp2(this OcipClient client, SystemProvisioningValidationGetRequest14sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemProvisioningValidationGetResponse14sp2;
        }

        /// <summary>
        /// Request to get the system's provisioning validation attributes.
        /// The response is either a SystemProvisioningValidationGetResponse14sp2 or ErrorResponse.
        /// </summary>
        public static async Task<SystemProvisioningValidationGetResponse14sp2> SystemProvisioningValidationGetRequest14sp2Async(this OcipClient client, SystemProvisioningValidationGetRequest14sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemProvisioningValidationGetResponse14sp2;
        }
        /// <summary>
        /// Request the system level data associated with session audit.
        /// The response is either a SystemSessionAuditGetResponse17sp3 or
        /// an ErrorResponse.
        /// 
        /// Replaced by: SystemSessionAuditGetRequest23 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSessionAuditGetRequest17sp3Async instead.")]
        public static async Task<SystemSessionAuditGetResponse17sp3> SystemSessionAuditGetRequest17sp3(this OcipClient client, SystemSessionAuditGetRequest17sp3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSessionAuditGetResponse17sp3;
        }

        /// <summary>
        /// Request the system level data associated with session audit.
        /// The response is either a SystemSessionAuditGetResponse17sp3 or
        /// an ErrorResponse.
        /// 
        /// Replaced by: SystemSessionAuditGetRequest23 in AS data mode.
        /// </summary>
        public static async Task<SystemSessionAuditGetResponse17sp3> SystemSessionAuditGetRequest17sp3Async(this OcipClient client, SystemSessionAuditGetRequest17sp3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSessionAuditGetResponse17sp3;
        }
        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagement, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// resellerId
        /// 
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// 
        /// Replaced By: SystemSIPDeviceTypeAddRequest23
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeAddRequest22V4Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest22V4(this OcipClient client, SystemSIPDeviceTypeAddRequest22V4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagement, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// resellerId
        /// 
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// 
        /// Replaced By: SystemSIPDeviceTypeAddRequest23
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest22V4Async(this OcipClient client, SystemSIPDeviceTypeAddRequest22V4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagementRedirectLink, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// resellerId
        /// supportVisualDeviceManagementAPI, use value "false" in XS data mode
        /// deviceCategory
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// 
        /// Deprecated by: SystemSIPDeviceTypeAddRequest23V3 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeAddRequest22V6Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest22V6(this OcipClient client, SystemSIPDeviceTypeAddRequest22V6 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagementRedirectLink, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// resellerId
        /// supportVisualDeviceManagementAPI, use value "false" in XS data mode
        /// deviceCategory
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// 
        /// Deprecated by: SystemSIPDeviceTypeAddRequest23V3 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest22V6Async(this OcipClient client, SystemSIPDeviceTypeAddRequest22V6 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagementRedirectLink, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// resellerId
        /// supportVisualDeviceManagementAPI, use value "false" in XS data mode
        /// deviceCategory
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// 
        /// Replaced By: SystemSIPDeviceTypeAddRequest23V4
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeAddRequest22V7Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest22V7(this OcipClient client, SystemSIPDeviceTypeAddRequest22V7 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagementRedirectLink, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// resellerId
        /// supportVisualDeviceManagementAPI, use value "false" in XS data mode
        /// deviceCategory
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// 
        /// Replaced By: SystemSIPDeviceTypeAddRequest23V4
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest22V7Async(this OcipClient client, SystemSIPDeviceTypeAddRequest22V7 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagementRedirectLink, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// resellerId
        /// supportVisualDeviceManagementAPI, use value "false" in XS data mode
        /// deviceCategory
        /// verstatInPAIHeader, use value "false" in XS data mode
        /// verstatInFromHeader, use value "false" in XS data mode
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// Replaced by SystemSIPDeviceTypeAddRequest23V5.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeAddRequest22V8Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest22V8(this OcipClient client, SystemSIPDeviceTypeAddRequest22V8 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagementRedirectLink, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// resellerId
        /// supportVisualDeviceManagementAPI, use value "false" in XS data mode
        /// deviceCategory
        /// verstatInPAIHeader, use value "false" in XS data mode
        /// verstatInFromHeader, use value "false" in XS data mode
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// Replaced by SystemSIPDeviceTypeAddRequest23V5.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest22V8Async(this OcipClient client, SystemSIPDeviceTypeAddRequest22V8 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagementRedirectLink, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// resellerId
        /// supportVisualDeviceManagementAPI, use value "false" in XS data mode
        /// deviceCategory
        /// verstatInPAIHeader, use value "false" in XS data mode
        /// verstatInFromHeader, use value "false" in XS data mode
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// Replaced by SystemSIPDeviceTypeAddRequest23V6.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeAddRequest22V9Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest22V9(this OcipClient client, SystemSIPDeviceTypeAddRequest22V9 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagementRedirectLink, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// resellerId
        /// supportVisualDeviceManagementAPI, use value "false" in XS data mode
        /// deviceCategory
        /// verstatInPAIHeader, use value "false" in XS data mode
        /// verstatInFromHeader, use value "false" in XS data mode
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// Replaced by SystemSIPDeviceTypeAddRequest23V6.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest22V9Async(this OcipClient client, SystemSIPDeviceTypeAddRequest22V9 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagementRedirectLink, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// supportCallingPartyCategoryInOutboundFromHeader, use value "true" in XS data mode
        /// resellerId
        /// supportVisualDeviceManagementAPI, use value "false" in XS data mode
        /// deviceCategory
        /// 
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// 
        /// Replaced By: SystemSIPDeviceTypeAddRequest23V4
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeAddRequest23V3Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest23V3(this OcipClient client, SystemSIPDeviceTypeAddRequest23V3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagementRedirectLink, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// supportCallingPartyCategoryInOutboundFromHeader, use value "true" in XS data mode
        /// resellerId
        /// supportVisualDeviceManagementAPI, use value "false" in XS data mode
        /// deviceCategory
        /// 
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// 
        /// Replaced By: SystemSIPDeviceTypeAddRequest23V4
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest23V3Async(this OcipClient client, SystemSIPDeviceTypeAddRequest23V3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagementRedirectLink, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// supportCallingPartyCategoryInOutboundFromHeader, use value "true" in XS data mode
        /// resellerId
        /// supportVisualDeviceManagementAPI, use value "false" in XS data mode
        /// deviceCategory
        /// 
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// Replaced by SystemSIPDeviceTypeAddRequest23V5
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeAddRequest23V4Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest23V4(this OcipClient client, SystemSIPDeviceTypeAddRequest23V4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagementRedirectLink, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// supportCallingPartyCategoryInOutboundFromHeader, use value "true" in XS data mode
        /// resellerId
        /// supportVisualDeviceManagementAPI, use value "false" in XS data mode
        /// deviceCategory
        /// 
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// Replaced by SystemSIPDeviceTypeAddRequest23V5
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest23V4Async(this OcipClient client, SystemSIPDeviceTypeAddRequest23V4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagementRedirectLink, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// supportCallingPartyCategoryInOutboundFromHeader, use value "true" in XS data mode
        /// resellerId
        /// supportVisualDeviceManagementAPI, use value "false" in XS data mode
        /// deviceCategory
        /// verstatInPAIHeader
        /// verstatInFromHeader
        /// 
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// 
        /// Replaced by SystemSIPDeviceTypeAddRequest23V6
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeAddRequest23V5Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest23V5(this OcipClient client, SystemSIPDeviceTypeAddRequest23V5 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type.
        /// The response is either SuccessResponse or ErrorResponse. When the optional element resellerId is specified,
        /// the device type created is at reseller level. Device type name should be unique through out the system
        /// including all the reseller level device types.
        /// The following elements are only used in the XS data mode and ignored in the AS data mode:
        /// enhancedForICS, use value "false" in AS data mode
        /// supports3G4GContinuity, use value "false" in AS data mode
        /// publishesOwnPresence, use value "false" in AS data mode
        /// locationNetwork, use value "Fixed" in AS data mode
        /// allowTerminationBasedOnICSI, use value "false" in AS data mode
        /// roamingMode, use value "None" in AS data mode
        /// 
        /// The following elements are only used in AS data mode and ignored in the XS data mode:
        /// supportClientSessionInfo, use value "false" in XS data mode
        /// supportCallInfoConferenceSubscriptionURI, use value "false" in XS data mode
        /// supportRemotePartyInfo, use value "false" in XS data mode
        /// supportVisualDeviceManagementRedirectLink, use value "false" in XS data mode
        /// bypassMediaTreatment, use value "false" in XS data mode
        /// supportCauseParameter, use value "false" in XS data mode
        /// supportCallingPartyCategoryInOutboundFromHeader, use value "true" in XS data mode
        /// resellerId
        /// supportVisualDeviceManagementAPI, use value "false" in XS data mode
        /// deviceCategory
        /// verstatInPAIHeader
        /// verstatInFromHeader
        /// 
        /// The following values for element profile are only used in AS data mode and an error is returned in the XS data mode:
        /// SignalingAddressType=Non-intelligent Device Addressing
        /// SignalingAddressType=Intelligent Device Addressing
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// 
        /// Replaced by SystemSIPDeviceTypeAddRequest23V6
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest23V5Async(this OcipClient client, SystemSIPDeviceTypeAddRequest23V5 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// 
        /// Replaced by: SystemSIPDeviceTypeFileAddRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeFileAddRequest21sp1Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileAddRequest21sp1(this OcipClient client, SystemSIPDeviceTypeFileAddRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a sip device type file.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// 
        /// Replaced by: SystemSIPDeviceTypeFileAddRequest22 in AS data mode.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeFileAddRequest21sp1Async(this OcipClient client, SystemSIPDeviceTypeFileAddRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a sip device type file.
        /// The response is either SystemSIPDeviceTypeFileGetResponse21sp1 or ErrorResponse.
        /// 
        /// Replaced by: SystemSIPDeviceTypeFileGetRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeFileGetRequest21sp1Async instead.")]
        public static async Task<SystemSIPDeviceTypeFileGetResponse21sp1> SystemSIPDeviceTypeFileGetRequest21sp1(this OcipClient client, SystemSIPDeviceTypeFileGetRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeFileGetResponse21sp1;
        }

        /// <summary>
        /// Request to get a sip device type file.
        /// The response is either SystemSIPDeviceTypeFileGetResponse21sp1 or ErrorResponse.
        /// 
        /// Replaced by: SystemSIPDeviceTypeFileGetRequest22 in AS data mode.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeFileGetResponse21sp1> SystemSIPDeviceTypeFileGetRequest21sp1Async(this OcipClient client, SystemSIPDeviceTypeFileGetRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeFileGetResponse21sp1;
        }
        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse22V10 or ErrorResponse.
        /// 
        /// Replaced By: SystemSIPDeviceTypeGetRequest23V6
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeGetRequest22V10Async instead.")]
        public static async Task<SystemSIPDeviceTypeGetResponse22V10> SystemSIPDeviceTypeGetRequest22V10(this OcipClient client, SystemSIPDeviceTypeGetRequest22V10 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse22V10;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse22V10 or ErrorResponse.
        /// 
        /// Replaced By: SystemSIPDeviceTypeGetRequest23V6
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse22V10> SystemSIPDeviceTypeGetRequest22V10Async(this OcipClient client, SystemSIPDeviceTypeGetRequest22V10 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse22V10;
        }
        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse22V11 or ErrorResponse.
        /// Replaced by SystemSIPDeviceTypeGetRequest23V7
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeGetRequest22V11Async instead.")]
        public static async Task<SystemSIPDeviceTypeGetResponse22V11> SystemSIPDeviceTypeGetRequest22V11(this OcipClient client, SystemSIPDeviceTypeGetRequest22V11 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse22V11;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse22V11 or ErrorResponse.
        /// Replaced by SystemSIPDeviceTypeGetRequest23V7
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse22V11> SystemSIPDeviceTypeGetRequest22V11Async(this OcipClient client, SystemSIPDeviceTypeGetRequest22V11 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse22V11;
        }
        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse22V12 or ErrorResponse.
        /// Replaced by SystemSIPDeviceTypeGetRequest23V8
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeGetRequest22V12Async instead.")]
        public static async Task<SystemSIPDeviceTypeGetResponse22V12> SystemSIPDeviceTypeGetRequest22V12(this OcipClient client, SystemSIPDeviceTypeGetRequest22V12 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse22V12;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse22V12 or ErrorResponse.
        /// Replaced by SystemSIPDeviceTypeGetRequest23V8
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse22V12> SystemSIPDeviceTypeGetRequest22V12Async(this OcipClient client, SystemSIPDeviceTypeGetRequest22V12 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse22V12;
        }
        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse22V8 or ErrorResponse.
        /// 
        /// Replaced By: SystemSIPDeviceTypeGetRequest23V4
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeGetRequest22V9Async instead.")]
        public static async Task<SystemSIPDeviceTypeGetResponse22V8> SystemSIPDeviceTypeGetRequest22V9(this OcipClient client, SystemSIPDeviceTypeGetRequest22V9 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse22V8;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse22V8 or ErrorResponse.
        /// 
        /// Replaced By: SystemSIPDeviceTypeGetRequest23V4
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse22V8> SystemSIPDeviceTypeGetRequest22V9Async(this OcipClient client, SystemSIPDeviceTypeGetRequest22V9 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse22V8;
        }
        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse23V2 or ErrorResponse.
        /// 
        /// Replaced by: SystemSIPDeviceTypeGetRequest23V3 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeGetRequest23V2Async instead.")]
        public static async Task<SystemSIPDeviceTypeGetResponse23V2> SystemSIPDeviceTypeGetRequest23V2(this OcipClient client, SystemSIPDeviceTypeGetRequest23V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse23V2;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse23V2 or ErrorResponse.
        /// 
        /// Replaced by: SystemSIPDeviceTypeGetRequest23V3 in AS data mode.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse23V2> SystemSIPDeviceTypeGetRequest23V2Async(this OcipClient client, SystemSIPDeviceTypeGetRequest23V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse23V2;
        }
        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse23V3 or ErrorResponse.
        /// Replaced By: SystemSIPDeviceTypeGetRequest23V4.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeGetRequest23V3Async instead.")]
        public static async Task<SystemSIPDeviceTypeGetResponse23V3> SystemSIPDeviceTypeGetRequest23V3(this OcipClient client, SystemSIPDeviceTypeGetRequest23V3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse23V3;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse23V3 or ErrorResponse.
        /// Replaced By: SystemSIPDeviceTypeGetRequest23V4.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse23V3> SystemSIPDeviceTypeGetRequest23V3Async(this OcipClient client, SystemSIPDeviceTypeGetRequest23V3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse23V3;
        }
        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse23V4 or ErrorResponse.
        /// 
        /// Replaced by: SystemSIPDeviceTypeGetRequest23V5 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeGetRequest23V4Async instead.")]
        public static async Task<SystemSIPDeviceTypeGetResponse23V4> SystemSIPDeviceTypeGetRequest23V4(this OcipClient client, SystemSIPDeviceTypeGetRequest23V4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse23V4;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse23V4 or ErrorResponse.
        /// 
        /// Replaced by: SystemSIPDeviceTypeGetRequest23V5 in AS data mode.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse23V4> SystemSIPDeviceTypeGetRequest23V4Async(this OcipClient client, SystemSIPDeviceTypeGetRequest23V4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse23V4;
        }
        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse23V5 or ErrorResponse.
        /// Replaced by SystemSIPDeviceTypeGetRequest23V6
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeGetRequest23V5Async instead.")]
        public static async Task<SystemSIPDeviceTypeGetResponse23V5> SystemSIPDeviceTypeGetRequest23V5(this OcipClient client, SystemSIPDeviceTypeGetRequest23V5 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse23V5;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse23V5 or ErrorResponse.
        /// Replaced by SystemSIPDeviceTypeGetRequest23V6
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse23V5> SystemSIPDeviceTypeGetRequest23V5Async(this OcipClient client, SystemSIPDeviceTypeGetRequest23V5 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse23V5;
        }
        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse23V6 or ErrorResponse.
        /// Replaced by SystemSIPDeviceTypeGetRequest23V7
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeGetRequest23V6Async instead.")]
        public static async Task<SystemSIPDeviceTypeGetResponse23V6> SystemSIPDeviceTypeGetRequest23V6(this OcipClient client, SystemSIPDeviceTypeGetRequest23V6 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse23V6;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse23V6 or ErrorResponse.
        /// Replaced by SystemSIPDeviceTypeGetRequest23V7
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse23V6> SystemSIPDeviceTypeGetRequest23V6Async(this OcipClient client, SystemSIPDeviceTypeGetRequest23V6 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse23V6;
        }
        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse23V7 or ErrorResponse.
        /// 
        /// Replaced by SystemSIPDeviceTypeGetResquest23V8
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeGetRequest23V7Async instead.")]
        public static async Task<SystemSIPDeviceTypeGetResponse23V7> SystemSIPDeviceTypeGetRequest23V7(this OcipClient client, SystemSIPDeviceTypeGetRequest23V7 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse23V7;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse23V7 or ErrorResponse.
        /// 
        /// Replaced by SystemSIPDeviceTypeGetResquest23V8
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse23V7> SystemSIPDeviceTypeGetRequest23V7Async(this OcipClient client, SystemSIPDeviceTypeGetRequest23V7 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse23V7;
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
        /// supportClientSessionInfo
        /// supportCallInfoConferenceSubscriptionURI
        /// supportRemotePartyInfo
        /// supportVisualDeviceManagement
        /// bypassMediaTreatment
        /// supportCauseParameter
        /// supportCallingPartyCategoryInOutboundFromHeader
        /// The following elements are only used in XS data mode and ignored in AS mode:
        /// enhancedForICS
        /// supports3G4GContinuity
        /// publishesOwnPresence
        /// locationNetwork
        /// allowTerminationBasedOnICSI
        /// roamingMode
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// When macInCert is set to true, macInNonRequestURI will be reset to false.
        /// When macInNonRequestURI is set to true, macInCert will be reset to false.
        /// Replaced by: SystemSIPDeviceTypeModifyRequest22V3 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeModifyRequest22V2Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeModifyRequest22V2(this OcipClient client, SystemSIPDeviceTypeModifyRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
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
        /// supportClientSessionInfo
        /// supportCallInfoConferenceSubscriptionURI
        /// supportRemotePartyInfo
        /// supportVisualDeviceManagement
        /// bypassMediaTreatment
        /// supportCauseParameter
        /// supportCallingPartyCategoryInOutboundFromHeader
        /// The following elements are only used in XS data mode and ignored in AS mode:
        /// enhancedForICS
        /// supports3G4GContinuity
        /// publishesOwnPresence
        /// locationNetwork
        /// allowTerminationBasedOnICSI
        /// roamingMode
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// When macInCert is set to true, macInNonRequestURI will be reset to false.
        /// When macInNonRequestURI is set to true, macInCert will be reset to false.
        /// Replaced by: SystemSIPDeviceTypeModifyRequest22V3 in AS data mode.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeModifyRequest22V2Async(this OcipClient client, SystemSIPDeviceTypeModifyRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
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
        /// supportClientSessionInfo
        /// supportCallInfoConferenceSubscriptionURI
        /// supportRemotePartyInfo
        /// supportVisualDeviceManagementRedirectLink
        /// bypassMediaTreatment
        /// supportCauseParameter
        /// supportCallingPartyCategoryInOutboundFromHeader
        /// supportVisualDeviceManagementAPI
        /// deviceCategory
        /// 
        /// The following elements are only used in XS data mode and ignored in AS mode:
        /// enhancedForICS
        /// supports3G4GContinuity
        /// publishesOwnPresence
        /// locationNetwork
        /// allowTerminationBasedOnICSI
        /// roamingMode
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// When macInCert is set to true, macInNonRequestURI will be reset to false.
        /// When macInNonRequestURI is set to true, macInCert will be reset to false.
        /// Replaced By: SystemSIPDeviceTypeModifyRequest22V4
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeModifyRequest22V3Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeModifyRequest22V3(this OcipClient client, SystemSIPDeviceTypeModifyRequest22V3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
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
        /// supportClientSessionInfo
        /// supportCallInfoConferenceSubscriptionURI
        /// supportRemotePartyInfo
        /// supportVisualDeviceManagementRedirectLink
        /// bypassMediaTreatment
        /// supportCauseParameter
        /// supportCallingPartyCategoryInOutboundFromHeader
        /// supportVisualDeviceManagementAPI
        /// deviceCategory
        /// 
        /// The following elements are only used in XS data mode and ignored in AS mode:
        /// enhancedForICS
        /// supports3G4GContinuity
        /// publishesOwnPresence
        /// locationNetwork
        /// allowTerminationBasedOnICSI
        /// roamingMode
        /// The following logic applies to these elements:
        /// macInCert
        /// macInNonRequestURI
        /// The two elements are mutually exclusive.
        /// When both are set to true, the command fails.
        /// When macInCert is set to true, macInNonRequestURI will be reset to false.
        /// When macInNonRequestURI is set to true, macInCert will be reset to false.
        /// Replaced By: SystemSIPDeviceTypeModifyRequest22V4
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeModifyRequest22V3Async(this OcipClient client, SystemSIPDeviceTypeModifyRequest22V3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with SMPP external interface.
        /// The response is either a SystemSMPPGetResponse14sp5 or an ErrorResponse.
        /// 
        /// Replaced by: SystemSMPPGetRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMPPGetRequest14sp5Async instead.")]
        public static async Task<SystemSMPPGetResponse14sp5> SystemSMPPGetRequest14sp5(this OcipClient client, SystemSMPPGetRequest14sp5 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSMPPGetResponse14sp5;
        }

        /// <summary>
        /// Request the system level data associated with SMPP external interface.
        /// The response is either a SystemSMPPGetResponse14sp5 or an ErrorResponse.
        /// 
        /// Replaced by: SystemSMPPGetRequest21 in AS data mode
        /// </summary>
        public static async Task<SystemSMPPGetResponse14sp5> SystemSMPPGetRequest14sp5Async(this OcipClient client, SystemSMPPGetRequest14sp5 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSMPPGetResponse14sp5;
        }
        /// <summary>
        /// Request the system level data associated with SMPP external interface.
        /// The response is either a SystemSMPPGetResponse21 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSMPPGetRequest21Async instead.")]
        public static async Task<SystemSMPPGetResponse21> SystemSMPPGetRequest21(this OcipClient client, SystemSMPPGetRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSMPPGetResponse21;
        }

        /// <summary>
        /// Request the system level data associated with SMPP external interface.
        /// The response is either a SystemSMPPGetResponse21 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemSMPPGetResponse21> SystemSMPPGetRequest21Async(this OcipClient client, SystemSMPPGetRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSMPPGetResponse21;
        }
        /// <summary>
        /// Requests the list of time zone names.
        /// The response is either SystemTimeZoneGetListResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemTimeZoneGetListRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTimeZoneGetListRequestAsync instead.")]
        public static async Task<SystemTimeZoneGetListResponse> SystemTimeZoneGetListRequest(this OcipClient client, SystemTimeZoneGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTimeZoneGetListResponse;
        }

        /// <summary>
        /// Requests the list of time zone names.
        /// The response is either SystemTimeZoneGetListResponse or ErrorResponse.
        /// 
        /// Replaced by: SystemTimeZoneGetListRequest20 in AS data mode
        /// </summary>
        public static async Task<SystemTimeZoneGetListResponse> SystemTimeZoneGetListRequestAsync(this OcipClient client, SystemTimeZoneGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTimeZoneGetListResponse;
        }
        /// <summary>
        /// Add a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceAddRequest22 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceAddRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceAddRequest(this OcipClient client, SystemTreatmentMappingCallBlockingServiceAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceAddRequest22 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceAddRequestAsync(this OcipClient client, SystemTreatmentMappingCallBlockingServiceAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceAddRequest22V2 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceAddRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceAddRequest22(this OcipClient client, SystemTreatmentMappingCallBlockingServiceAddRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceAddRequest22V2 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceAddRequest22Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceAddRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceAddRequest23 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceAddRequest22V2Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceAddRequest22V2(this OcipClient client, SystemTreatmentMappingCallBlockingServiceAddRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceAddRequest23 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceAddRequest22V2Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceAddRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceAddRequest22V3Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceAddRequest22V3(this OcipClient client, SystemTreatmentMappingCallBlockingServiceAddRequest22V3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceAddRequest22V3Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceAddRequest22V3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceAddRequest23V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceAddRequest23Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceAddRequest23(this OcipClient client, SystemTreatmentMappingCallBlockingServiceAddRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceAddRequest23V2 in AS data mode.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceAddRequest23Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceAddRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Add a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceAddRequest23V2Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceAddRequest23V2(this OcipClient client, SystemTreatmentMappingCallBlockingServiceAddRequest23V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Add a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceAddRequest23V2Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceAddRequest23V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceDeleteRequest22 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceDeleteRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceDeleteRequest(this OcipClient client, SystemTreatmentMappingCallBlockingServiceDeleteRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceDeleteRequest22 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceDeleteRequestAsync(this OcipClient client, SystemTreatmentMappingCallBlockingServiceDeleteRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceDeleteRequest22V2 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceDeleteRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceDeleteRequest22(this OcipClient client, SystemTreatmentMappingCallBlockingServiceDeleteRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceDeleteRequest22V2 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceDeleteRequest22Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceDeleteRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceDeleteRequest23 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceDeleteRequest22V2Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceDeleteRequest22V2(this OcipClient client, SystemTreatmentMappingCallBlockingServiceDeleteRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceDeleteRequest23 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceDeleteRequest22V2Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceDeleteRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceDeleteRequest22V3Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceDeleteRequest22V3(this OcipClient client, SystemTreatmentMappingCallBlockingServiceDeleteRequest22V3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceDeleteRequest22V3Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceDeleteRequest22V3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceDeleteRequest23V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceDeleteRequest23Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceDeleteRequest23(this OcipClient client, SystemTreatmentMappingCallBlockingServiceDeleteRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceDeleteRequest23V2 in AS data mode.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceDeleteRequest23Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceDeleteRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Delete a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceDeleteRequest23V2Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceDeleteRequest23V2(this OcipClient client, SystemTreatmentMappingCallBlockingServiceDeleteRequest23V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceDeleteRequest23V2Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceDeleteRequest23V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Requests a table of all the existing Call Blocking Service Mappings in the system.
        /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceGetListRequest19sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceGetListRequestAsync instead.")]
        public static async Task<SystemTreatmentMappingCallBlockingServiceGetListResponse> SystemTreatmentMappingCallBlockingServiceGetListRequest(this OcipClient client, SystemTreatmentMappingCallBlockingServiceGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTreatmentMappingCallBlockingServiceGetListResponse;
        }

        /// <summary>
        /// Requests a table of all the existing Call Blocking Service Mappings in the system.
        /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceGetListRequest19sp1 in AS data mode
        /// </summary>
        public static async Task<SystemTreatmentMappingCallBlockingServiceGetListResponse> SystemTreatmentMappingCallBlockingServiceGetListRequestAsync(this OcipClient client, SystemTreatmentMappingCallBlockingServiceGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTreatmentMappingCallBlockingServiceGetListResponse;
        }
        /// <summary>
        /// Requests a table of all the existing Call Blocking Service Mappings in the system.
        /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse22 or an ErrorResponse.
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceGetListRequest23
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceGetListRequest22Async instead.")]
        public static async Task<SystemTreatmentMappingCallBlockingServiceGetListResponse22> SystemTreatmentMappingCallBlockingServiceGetListRequest22(this OcipClient client, SystemTreatmentMappingCallBlockingServiceGetListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTreatmentMappingCallBlockingServiceGetListResponse22;
        }

        /// <summary>
        /// Requests a table of all the existing Call Blocking Service Mappings in the system.
        /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse22 or an ErrorResponse.
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceGetListRequest23
        /// </summary>
        public static async Task<SystemTreatmentMappingCallBlockingServiceGetListResponse22> SystemTreatmentMappingCallBlockingServiceGetListRequest22Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceGetListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTreatmentMappingCallBlockingServiceGetListResponse22;
        }
        /// <summary>
        /// Requests a table of all the existing Call Blocking Service Mappings in the system.
        /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse22V2 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceGetListRequest22V2Async instead.")]
        public static async Task<SystemTreatmentMappingCallBlockingServiceGetListResponse22V2> SystemTreatmentMappingCallBlockingServiceGetListRequest22V2(this OcipClient client, SystemTreatmentMappingCallBlockingServiceGetListRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTreatmentMappingCallBlockingServiceGetListResponse22V2;
        }

        /// <summary>
        /// Requests a table of all the existing Call Blocking Service Mappings in the system.
        /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse22V2 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemTreatmentMappingCallBlockingServiceGetListResponse22V2> SystemTreatmentMappingCallBlockingServiceGetListRequest22V2Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceGetListRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTreatmentMappingCallBlockingServiceGetListResponse22V2;
        }
        /// <summary>
        /// Requests a table of all the existing Call Blocking Service Mappings in the system.
        /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse23 or an ErrorResponse.
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceGetListRequest23V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceGetListRequest23Async instead.")]
        public static async Task<SystemTreatmentMappingCallBlockingServiceGetListResponse23> SystemTreatmentMappingCallBlockingServiceGetListRequest23(this OcipClient client, SystemTreatmentMappingCallBlockingServiceGetListRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTreatmentMappingCallBlockingServiceGetListResponse23;
        }

        /// <summary>
        /// Requests a table of all the existing Call Blocking Service Mappings in the system.
        /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse23 or an ErrorResponse.
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceGetListRequest23V2 in AS data mode.
        /// </summary>
        public static async Task<SystemTreatmentMappingCallBlockingServiceGetListResponse23> SystemTreatmentMappingCallBlockingServiceGetListRequest23Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceGetListRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTreatmentMappingCallBlockingServiceGetListResponse23;
        }
        /// <summary>
        /// Requests a table of all the existing Call Blocking Service Mappings in the system.
        /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse23V2 or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceGetListRequest23V2Async instead.")]
        public static async Task<SystemTreatmentMappingCallBlockingServiceGetListResponse23V2> SystemTreatmentMappingCallBlockingServiceGetListRequest23V2(this OcipClient client, SystemTreatmentMappingCallBlockingServiceGetListRequest23V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemTreatmentMappingCallBlockingServiceGetListResponse23V2;
        }

        /// <summary>
        /// Requests a table of all the existing Call Blocking Service Mappings in the system.
        /// The response is either a SystemTreatmentMappingCallBlockingServiceGetListResponse23V2 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemTreatmentMappingCallBlockingServiceGetListResponse23V2> SystemTreatmentMappingCallBlockingServiceGetListRequest23V2Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceGetListRequest23V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemTreatmentMappingCallBlockingServiceGetListResponse23V2;
        }
        /// <summary>
        /// Modify the fields for a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceModifyRequest22 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceModifyRequest(this OcipClient client, SystemTreatmentMappingCallBlockingServiceModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceModifyRequest22 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceModifyRequestAsync(this OcipClient client, SystemTreatmentMappingCallBlockingServiceModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the fields for a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceModifyRequest22V2 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceModifyRequest22Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceModifyRequest22(this OcipClient client, SystemTreatmentMappingCallBlockingServiceModifyRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceModifyRequest22V2 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceModifyRequest22Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceModifyRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the fields for a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceModifyRequest23 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceModifyRequest22V2Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceModifyRequest22V2(this OcipClient client, SystemTreatmentMappingCallBlockingServiceModifyRequest22V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceModifyRequest23 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceModifyRequest22V2Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceModifyRequest22V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the fields for a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceModifyRequest22V3Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceModifyRequest22V3(this OcipClient client, SystemTreatmentMappingCallBlockingServiceModifyRequest22V3 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceModifyRequest22V3Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceModifyRequest22V3 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the fields for a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceModifyRequest23V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceModifyRequest23Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceModifyRequest23(this OcipClient client, SystemTreatmentMappingCallBlockingServiceModifyRequest23 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Replaced by: SystemTreatmentMappingCallBlockingServiceModifyRequest23V2 in AS data mode.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceModifyRequest23Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceModifyRequest23 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Modify the fields for a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemTreatmentMappingCallBlockingServiceModifyRequest23V2Async instead.")]
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceModifyRequest23V2(this OcipClient client, SystemTreatmentMappingCallBlockingServiceModifyRequest23V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the fields for a Call Blocking Service mapping.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemTreatmentMappingCallBlockingServiceModifyRequest23V2Async(this OcipClient client, SystemTreatmentMappingCallBlockingServiceModifyRequest23V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the system level data associated with Voice Messaging.
        /// The response is either a SystemVoiceMessagingGroupGetResponse16sp2 or an ErrorResponse.
        /// 
        /// Replaced by: SystemVoiceMessagingGroupGetRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVoiceMessagingGroupGetRequest16sp2Async instead.")]
        public static async Task<SystemVoiceMessagingGroupGetResponse16sp2> SystemVoiceMessagingGroupGetRequest16sp2(this OcipClient client, SystemVoiceMessagingGroupGetRequest16sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemVoiceMessagingGroupGetResponse16sp2;
        }

        /// <summary>
        /// Request the system level data associated with Voice Messaging.
        /// The response is either a SystemVoiceMessagingGroupGetResponse16sp2 or an ErrorResponse.
        /// 
        /// Replaced by: SystemVoiceMessagingGroupGetRequest20 in AS data mode
        /// </summary>
        public static async Task<SystemVoiceMessagingGroupGetResponse16sp2> SystemVoiceMessagingGroupGetRequest16sp2Async(this OcipClient client, SystemVoiceMessagingGroupGetRequest16sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemVoiceMessagingGroupGetResponse16sp2;
        }
        /// <summary>
        /// Request the system level data associated with Voice Messaging.
        /// The response is either a SystemVoiceMessagingGroupGetResponse21 or an ErrorResponse.
        /// 
        /// Replaced by: SystemVoiceMessagingGroupGetRequest22 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVoiceMessagingGroupGetRequest21Async instead.")]
        public static async Task<SystemVoiceMessagingGroupGetResponse21> SystemVoiceMessagingGroupGetRequest21(this OcipClient client, SystemVoiceMessagingGroupGetRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemVoiceMessagingGroupGetResponse21;
        }

        /// <summary>
        /// Request the system level data associated with Voice Messaging.
        /// The response is either a SystemVoiceMessagingGroupGetResponse21 or an ErrorResponse.
        /// 
        /// Replaced by: SystemVoiceMessagingGroupGetRequest22 in AS data mode
        /// </summary>
        public static async Task<SystemVoiceMessagingGroupGetResponse21> SystemVoiceMessagingGroupGetRequest21Async(this OcipClient client, SystemVoiceMessagingGroupGetRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemVoiceMessagingGroupGetResponse21;
        }
        /// <summary>
        /// The response is either a SystemVoiceMessagingGroupGetResponse22 or an ErrorResponse.
        /// 
        /// Replaced by: SystemVoiceMessagingGroupGetRequest22V2.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemVoiceMessagingGroupGetRequest22Async instead.")]
        public static async Task<SystemVoiceMessagingGroupGetResponse22> SystemVoiceMessagingGroupGetRequest22(this OcipClient client, SystemVoiceMessagingGroupGetRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemVoiceMessagingGroupGetResponse22;
        }

        /// <summary>
        /// The response is either a SystemVoiceMessagingGroupGetResponse22 or an ErrorResponse.
        /// 
        /// Replaced by: SystemVoiceMessagingGroupGetRequest22V2.
        /// </summary>
        public static async Task<SystemVoiceMessagingGroupGetResponse22> SystemVoiceMessagingGroupGetRequest22Async(this OcipClient client, SystemVoiceMessagingGroupGetRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemVoiceMessagingGroupGetResponse22;
        }
        /// <summary>
        /// Request to add a user.
        /// The domain is required in the userId.
        /// The password is not required if external authentication is enabled.
        /// The following elements are only used in AS data mode and will fail in XS data mode:
        /// trunkAddressing
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// nameDialingName
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// allowVideo
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements can only be used by a system administrator:.
        /// allowVideo
        /// alternateUserId
        /// The following elements can only be used by a provisioning administrator:.
        /// alternateUserId
        /// 
        /// Replaced by: UserAddRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAddRequest21Async instead.")]
        public static async Task<SuccessResponse> UserAddRequest21(this OcipClient client, UserAddRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a user.
        /// The domain is required in the userId.
        /// The password is not required if external authentication is enabled.
        /// The following elements are only used in AS data mode and will fail in XS data mode:
        /// trunkAddressing
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// nameDialingName
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// allowVideo
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements can only be used by a system administrator:.
        /// allowVideo
        /// alternateUserId
        /// The following elements can only be used by a provisioning administrator:.
        /// alternateUserId
        /// 
        /// Replaced by: UserAddRequest22 in AS data mode.
        /// </summary>
        public static async Task<SuccessResponse> UserAddRequest21Async(this OcipClient client, UserAddRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to add a user.
        /// The domain is required in the userId.
        /// The password is not required if external authentication is enabled.
        /// The following elements are only used in AS data mode and will fail in XS data mode:
        /// trunkAddressing
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// nameDialingName
        /// alternateUserId
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// allowVideo
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements can only be used by a system administrator:.
        /// allowVideo
        /// alternateUserId
        /// The following elements can only be used by a provisioning administrator:.
        /// alternateUserId
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by: UserAddRequest22V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAddRequest22Async instead.")]
        public static async Task<SuccessResponse> UserAddRequest22(this OcipClient client, UserAddRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a user.
        /// The domain is required in the userId.
        /// The password is not required if external authentication is enabled.
        /// The following elements are only used in AS data mode and will fail in XS data mode:
        /// trunkAddressing
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// nameDialingName
        /// alternateUserId
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// allowVideo
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements can only be used by a system administrator:.
        /// allowVideo
        /// alternateUserId
        /// The following elements can only be used by a provisioning administrator:.
        /// alternateUserId
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// Replaced by: UserAddRequest22V2 in AS data mode.
        /// </summary>
        public static async Task<SuccessResponse> UserAddRequest22Async(this OcipClient client, UserAddRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with Alternate Numbers.
        /// The response is either a UserAlternateNumbersGetResponse17 or an ErrorResponse.
        /// 
        /// Replaced by: UserAlternateNumbersGetRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserAlternateNumbersGetRequest17Async instead.")]
        public static async Task<UserAlternateNumbersGetResponse17> UserAlternateNumbersGetRequest17(this OcipClient client, UserAlternateNumbersGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserAlternateNumbersGetResponse17;
        }

        /// <summary>
        /// Request the user level data associated with Alternate Numbers.
        /// The response is either a UserAlternateNumbersGetResponse17 or an ErrorResponse.
        /// 
        /// Replaced by: UserAlternateNumbersGetRequest21 in AS data mode
        /// </summary>
        public static async Task<UserAlternateNumbersGetResponse17> UserAlternateNumbersGetRequest17Async(this OcipClient client, UserAlternateNumbersGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserAlternateNumbersGetResponse17;
        }
        /// <summary>
        /// Get a list of all the available BroadWorks Anywhere portal instances for a specific user
        /// The response is either UserBroadWorksAnywhereGetAvailablePortalListResponse or ErrorResponse.
        /// Replaced by UserBroadWorksAnywhereGetAvailablePortalListRequest21sp1
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksAnywhereGetAvailablePortalListRequestAsync instead.")]
        public static async Task<UserBroadWorksAnywhereGetAvailablePortalListResponse> UserBroadWorksAnywhereGetAvailablePortalListRequest(this OcipClient client, UserBroadWorksAnywhereGetAvailablePortalListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserBroadWorksAnywhereGetAvailablePortalListResponse;
        }

        /// <summary>
        /// Get a list of all the available BroadWorks Anywhere portal instances for a specific user
        /// The response is either UserBroadWorksAnywhereGetAvailablePortalListResponse or ErrorResponse.
        /// Replaced by UserBroadWorksAnywhereGetAvailablePortalListRequest21sp1
        /// </summary>
        public static async Task<UserBroadWorksAnywhereGetAvailablePortalListResponse> UserBroadWorksAnywhereGetAvailablePortalListRequestAsync(this OcipClient client, UserBroadWorksAnywhereGetAvailablePortalListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserBroadWorksAnywhereGetAvailablePortalListResponse;
        }
        /// <summary>
        /// Get a criteria for the user's BroadWorks Anywhere phone number.
        /// The response is either a UserBroadWorksAnywhereGetSelectiveCriteriaResponse16 or an ErrorResponse.
        /// Replaced by: UserBroadWorksAnywhereGetSelectiveCriteriaRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserBroadWorksAnywhereGetSelectiveCriteriaRequest16Async instead.")]
        public static async Task<UserBroadWorksAnywhereGetSelectiveCriteriaResponse16> UserBroadWorksAnywhereGetSelectiveCriteriaRequest16(this OcipClient client, UserBroadWorksAnywhereGetSelectiveCriteriaRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserBroadWorksAnywhereGetSelectiveCriteriaResponse16;
        }

        /// <summary>
        /// Get a criteria for the user's BroadWorks Anywhere phone number.
        /// The response is either a UserBroadWorksAnywhereGetSelectiveCriteriaResponse16 or an ErrorResponse.
        /// Replaced by: UserBroadWorksAnywhereGetSelectiveCriteriaRequest21 in AS data mode
        /// </summary>
        public static async Task<UserBroadWorksAnywhereGetSelectiveCriteriaResponse16> UserBroadWorksAnywhereGetSelectiveCriteriaRequest16Async(this OcipClient client, UserBroadWorksAnywhereGetSelectiveCriteriaRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserBroadWorksAnywhereGetSelectiveCriteriaResponse16;
        }
        /// <summary>
        /// Get the user's call center settings and the list of call centers the specified user belongs to.
        /// The response is either a UserCallCenterGetResponse19 or an ErrorResponse.
        /// 
        /// Replaced by UserCallCenterGetRequest23.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallCenterGetRequest19Async instead.")]
        public static async Task<UserCallCenterGetResponse19> UserCallCenterGetRequest19(this OcipClient client, UserCallCenterGetRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallCenterGetResponse19;
        }

        /// <summary>
        /// Get the user's call center settings and the list of call centers the specified user belongs to.
        /// The response is either a UserCallCenterGetResponse19 or an ErrorResponse.
        /// 
        /// Replaced by UserCallCenterGetRequest23.
        /// </summary>
        public static async Task<UserCallCenterGetResponse19> UserCallCenterGetRequest19Async(this OcipClient client, UserCallCenterGetRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallCenterGetResponse19;
        }
        /// <summary>
        /// Get a criteria for the user's call forwarding selective service.
        /// The response is either a UserCallForwardingSelectiveGetCriteriaResponse16 or an ErrorResponse.
        /// Replaced by: UserCallForwardingSelectiveGetCriteriaRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallForwardingSelectiveGetCriteriaRequest16Async instead.")]
        public static async Task<UserCallForwardingSelectiveGetCriteriaResponse16> UserCallForwardingSelectiveGetCriteriaRequest16(this OcipClient client, UserCallForwardingSelectiveGetCriteriaRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallForwardingSelectiveGetCriteriaResponse16;
        }

        /// <summary>
        /// Get a criteria for the user's call forwarding selective service.
        /// The response is either a UserCallForwardingSelectiveGetCriteriaResponse16 or an ErrorResponse.
        /// Replaced by: UserCallForwardingSelectiveGetCriteriaRequest21 in AS data mode
        /// </summary>
        public static async Task<UserCallForwardingSelectiveGetCriteriaResponse16> UserCallForwardingSelectiveGetCriteriaRequest16Async(this OcipClient client, UserCallForwardingSelectiveGetCriteriaRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallForwardingSelectiveGetCriteriaResponse16;
        }
        /// <summary>
        /// Get a criteria for the user's call notify service.
        /// The response is either a UserCallNotifyGetCriteriaResponse16 or an ErrorResponse.
        /// Replaced by: UserCallNotifyGetCriteriaRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallNotifyGetCriteriaRequest16Async instead.")]
        public static async Task<UserCallNotifyGetCriteriaResponse16> UserCallNotifyGetCriteriaRequest16(this OcipClient client, UserCallNotifyGetCriteriaRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallNotifyGetCriteriaResponse16;
        }

        /// <summary>
        /// Get a criteria for the user's call notify service.
        /// The response is either a UserCallNotifyGetCriteriaResponse16 or an ErrorResponse.
        /// Replaced by: UserCallNotifyGetCriteriaRequest21 in AS data mode
        /// </summary>
        public static async Task<UserCallNotifyGetCriteriaResponse16> UserCallNotifyGetCriteriaRequest16Async(this OcipClient client, UserCallNotifyGetCriteriaRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallNotifyGetCriteriaResponse16;
        }
        /// <summary>
        /// Request the user level data associated with Call Policies.
        /// The response is either a UserCallPoliciesGetResponse17
        /// or an ErrorResponse.
        /// 
        /// Replaced by: UserCallPoliciesGetRequest19sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallPoliciesGetRequest17Async instead.")]
        public static async Task<UserCallPoliciesGetResponse17> UserCallPoliciesGetRequest17(this OcipClient client, UserCallPoliciesGetRequest17 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallPoliciesGetResponse17;
        }

        /// <summary>
        /// Request the user level data associated with Call Policies.
        /// The response is either a UserCallPoliciesGetResponse17
        /// or an ErrorResponse.
        /// 
        /// Replaced by: UserCallPoliciesGetRequest19sp1 in AS data mode
        /// </summary>
        public static async Task<UserCallPoliciesGetResponse17> UserCallPoliciesGetRequest17Async(this OcipClient client, UserCallPoliciesGetRequest17 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallPoliciesGetResponse17;
        }
        /// <summary>
        /// Request the user level data associated with Call Processing Policy.
        /// The response is either a UserCallProcessingGetPolicyResponse21sp2 or an
        /// ErrorResponse.
        /// Replaced by: UserCallProcessingGetPolicyRequest22 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallProcessingGetPolicyRequest21sp2Async instead.")]
        public static async Task<UserCallProcessingGetPolicyResponse21sp2> UserCallProcessingGetPolicyRequest21sp2(this OcipClient client, UserCallProcessingGetPolicyRequest21sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallProcessingGetPolicyResponse21sp2;
        }

        /// <summary>
        /// Request the user level data associated with Call Processing Policy.
        /// The response is either a UserCallProcessingGetPolicyResponse21sp2 or an
        /// ErrorResponse.
        /// Replaced by: UserCallProcessingGetPolicyRequest22 in AS data mode
        /// </summary>
        public static async Task<UserCallProcessingGetPolicyResponse21sp2> UserCallProcessingGetPolicyRequest21sp2Async(this OcipClient client, UserCallProcessingGetPolicyRequest21sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallProcessingGetPolicyResponse21sp2;
        }
        /// <summary>
        /// Request the user level data associated with Call Processing Policy.
        /// The response is either a UserCallProcessingGetPolicyResponse22 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: UserCallProcessingGetPolicyRequest22V2 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserCallProcessingGetPolicyRequest22Async instead.")]
        public static async Task<UserCallProcessingGetPolicyResponse22> UserCallProcessingGetPolicyRequest22(this OcipClient client, UserCallProcessingGetPolicyRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserCallProcessingGetPolicyResponse22;
        }

        /// <summary>
        /// Request the user level data associated with Call Processing Policy.
        /// The response is either a UserCallProcessingGetPolicyResponse22 or an
        /// ErrorResponse.
        /// 
        /// Replaced by: UserCallProcessingGetPolicyRequest22V2 in AS data mode.
        /// </summary>
        public static async Task<UserCallProcessingGetPolicyResponse22> UserCallProcessingGetPolicyRequest22Async(this OcipClient client, UserCallProcessingGetPolicyRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserCallProcessingGetPolicyResponse22;
        }
        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// In AS and Amplify  Data Mode:
        /// The group user limit will be increased by one if needed.
        /// 
        /// The group will be added if it does not exist and if the command is executed by a Service
        /// Provider level administrator or above. If the group needs to be created, the
        /// groupProperties element must be set or the request will fail.
        /// The groupProperties element will be ignored if the group already exists.
        /// 
        /// If the domain has not been assigned to the group, it will be added to group if the
        /// command is executed by a Service provider level administrator or above.
        /// If the domain has not been assigned to the service provider, it will be added to the
        /// service provider if the command is executed by a Provisioning level administrator or
        /// above. The command will fail otherwise.
        /// 
        /// If the phoneNumber has not been assigned to the group and addPhoneNumberToGroup is set
        /// to true, it will be added to group if the command is executed by a service provider
        /// administrator or above and the number is already assigned to the service provider. The
        /// command will fail otherwise.
        /// 
        /// The password is not required if external authentication is enabled.
        /// Alternate user ids can be added by a group level administrator or above.
        /// 
        /// When sharedCallAppearanceAccessDeviceEndpoint element is included and the Shared Call
        /// Appearance is not included in the service/service pack of the request or in the
        /// "new user template", the request will fail.
        /// 
        /// The userService/servicePack will be authorized to the group if it has not been
        /// authorized to the group if the command is executed by a Service Provider level
        /// administrator or above. The command will fail otherwise.
        /// The authorizedQuantity will be set to unlimited if not present.
        /// 
        /// When thirdPartyVoiceMail elements are included and the Third Party Voice Mail Support
        /// service is not included in the service/service pack of the request or in the
        /// "new user template", the request will fail.
        /// 
        /// When sipAuthenticationData element is included and the Authentication service is not
        /// included in the service/service pack of the request or in the "new user template",
        /// the request will fail.
        /// 
        /// 
        /// In XS data mode:
        /// only the System level administrator has the authorization level to execute the command.
        /// The group will be added if it does not exist. If the group needs to be created, the
        /// groupProperties element must be set or the request will fail.
        /// The groupProperties element will be ignored if the group already exists.
        /// 
        /// If the phoneNumber has not been assigned to the group, it will be added to group and
        /// service provider if needed.
        /// 
        /// When sharedCallAppearanceAccessDeviceEndpoint element is included and the Shared
        /// Call Appearance is not included in the service/service pack of the request, the request
        /// will fail.
        /// 
        /// The following elements are ignored in XS data mode:
        /// addPhoneNumberToGroup
        /// nameDialingName
        /// alternateUserId
        /// passcode
        /// trunkAddressing
        /// thirdPartyVoiceMailServerSelection
        /// thirdPartyVoiceMailServerUserServer
        /// thirdPartyVoiceMailServerMailboxIdType
        /// thirdPartyVoiceMailMailboxURL
        /// sipAuthenticationData
        /// Replaced by: UserConsolidatedAddRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserConsolidatedAddRequestAsync instead.")]
        public static async Task<SuccessResponse> UserConsolidatedAddRequest(this OcipClient client, UserConsolidatedAddRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// In AS and Amplify  Data Mode:
        /// The group user limit will be increased by one if needed.
        /// 
        /// The group will be added if it does not exist and if the command is executed by a Service
        /// Provider level administrator or above. If the group needs to be created, the
        /// groupProperties element must be set or the request will fail.
        /// The groupProperties element will be ignored if the group already exists.
        /// 
        /// If the domain has not been assigned to the group, it will be added to group if the
        /// command is executed by a Service provider level administrator or above.
        /// If the domain has not been assigned to the service provider, it will be added to the
        /// service provider if the command is executed by a Provisioning level administrator or
        /// above. The command will fail otherwise.
        /// 
        /// If the phoneNumber has not been assigned to the group and addPhoneNumberToGroup is set
        /// to true, it will be added to group if the command is executed by a service provider
        /// administrator or above and the number is already assigned to the service provider. The
        /// command will fail otherwise.
        /// 
        /// The password is not required if external authentication is enabled.
        /// Alternate user ids can be added by a group level administrator or above.
        /// 
        /// When sharedCallAppearanceAccessDeviceEndpoint element is included and the Shared Call
        /// Appearance is not included in the service/service pack of the request or in the
        /// "new user template", the request will fail.
        /// 
        /// The userService/servicePack will be authorized to the group if it has not been
        /// authorized to the group if the command is executed by a Service Provider level
        /// administrator or above. The command will fail otherwise.
        /// The authorizedQuantity will be set to unlimited if not present.
        /// 
        /// When thirdPartyVoiceMail elements are included and the Third Party Voice Mail Support
        /// service is not included in the service/service pack of the request or in the
        /// "new user template", the request will fail.
        /// 
        /// When sipAuthenticationData element is included and the Authentication service is not
        /// included in the service/service pack of the request or in the "new user template",
        /// the request will fail.
        /// 
        /// 
        /// In XS data mode:
        /// only the System level administrator has the authorization level to execute the command.
        /// The group will be added if it does not exist. If the group needs to be created, the
        /// groupProperties element must be set or the request will fail.
        /// The groupProperties element will be ignored if the group already exists.
        /// 
        /// If the phoneNumber has not been assigned to the group, it will be added to group and
        /// service provider if needed.
        /// 
        /// When sharedCallAppearanceAccessDeviceEndpoint element is included and the Shared
        /// Call Appearance is not included in the service/service pack of the request, the request
        /// will fail.
        /// 
        /// The following elements are ignored in XS data mode:
        /// addPhoneNumberToGroup
        /// nameDialingName
        /// alternateUserId
        /// passcode
        /// trunkAddressing
        /// thirdPartyVoiceMailServerSelection
        /// thirdPartyVoiceMailServerUserServer
        /// thirdPartyVoiceMailServerMailboxIdType
        /// thirdPartyVoiceMailMailboxURL
        /// sipAuthenticationData
        /// Replaced by: UserConsolidatedAddRequest22 in AS data mode.
        /// </summary>
        public static async Task<SuccessResponse> UserConsolidatedAddRequestAsync(this OcipClient client, UserConsolidatedAddRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request user's call logs.
        /// If the callLogType is not specified, all types of calls logs (placed, received, missed) are returned.
        /// The filters "dateTimeRange", "numberFilter", "redirectedNumberFilter", "accountAuthorizationCodeFilter"
        /// "callAuthorizationCodeFilter" and "subscriberType" are ignored if call logs are stored in CDS. When
        /// "ReceivedOrMissed" is specified as "callLogType" and call logs are stored in CDS, all call logs including
        /// placed will be returned.
        /// It is possible to restrict the number of rows returned using responsePagingControl. If responsePagingControl
        /// is not specified, the value of Enhanced Call Logs system parameter maxNonPagedResponseSize will control
        /// the maximum number of call logs can be returned.
        /// The response is either a UserEnhancedCallLogsGetListResponse21sp1 or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// callAuthorizationCodeFilter
        /// 
        /// Replaced by: UserEnhancedCallLogsGetListRequest21Sp1V2 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserEnhancedCallLogsGetListRequest21sp1Async instead.")]
        public static async Task<UserEnhancedCallLogsGetListResponse21sp1> UserEnhancedCallLogsGetListRequest21sp1(this OcipClient client, UserEnhancedCallLogsGetListRequest21sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserEnhancedCallLogsGetListResponse21sp1;
        }

        /// <summary>
        /// Request user's call logs.
        /// If the callLogType is not specified, all types of calls logs (placed, received, missed) are returned.
        /// The filters "dateTimeRange", "numberFilter", "redirectedNumberFilter", "accountAuthorizationCodeFilter"
        /// "callAuthorizationCodeFilter" and "subscriberType" are ignored if call logs are stored in CDS. When
        /// "ReceivedOrMissed" is specified as "callLogType" and call logs are stored in CDS, all call logs including
        /// placed will be returned.
        /// It is possible to restrict the number of rows returned using responsePagingControl. If responsePagingControl
        /// is not specified, the value of Enhanced Call Logs system parameter maxNonPagedResponseSize will control
        /// the maximum number of call logs can be returned.
        /// The response is either a UserEnhancedCallLogsGetListResponse21sp1 or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// callAuthorizationCodeFilter
        /// 
        /// Replaced by: UserEnhancedCallLogsGetListRequest21Sp1V2 in AS data mode
        /// </summary>
        public static async Task<UserEnhancedCallLogsGetListResponse21sp1> UserEnhancedCallLogsGetListRequest21sp1Async(this OcipClient client, UserEnhancedCallLogsGetListRequest21sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserEnhancedCallLogsGetListResponse21sp1;
        }
        /// <summary>
        /// Request user's call logs.
        /// If the callLogType is not specified, all types of calls logs (placed, received, missed) are returned.
        /// The filters "dateTimeRange", "numberFilter", "redirectedNumberFilter", "accountAuthorizationCodeFilter"
        /// "callAuthorizationCodeFilter" and "subscriberType" are ignored if call logs are stored in CDS. When
        /// "ReceivedOrMissed" is specified as "callLogType" and call logs are stored in CDS, all call logs including
        /// placed will be returned.
        /// It is possible to restrict the number of rows returned using responsePagingControl. If responsePagingControl
        /// is not specified, the value of Enhanced Call Logs system parameter maxNonPagedResponseSize will control
        /// the maximum number of call logs can be returned.
        /// The response is either a UserEnhancedCallLogsGetListResponse21sp1V2 or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// callAuthorizationCodeFilter
        /// </summary>
        [Obsolete("This method is deprecated. Use UserEnhancedCallLogsGetListRequest21sp1V2Async instead.")]
        public static async Task<UserEnhancedCallLogsGetListResponse21sp1V2> UserEnhancedCallLogsGetListRequest21sp1V2(this OcipClient client, UserEnhancedCallLogsGetListRequest21sp1V2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserEnhancedCallLogsGetListResponse21sp1V2;
        }

        /// <summary>
        /// Request user's call logs.
        /// If the callLogType is not specified, all types of calls logs (placed, received, missed) are returned.
        /// The filters "dateTimeRange", "numberFilter", "redirectedNumberFilter", "accountAuthorizationCodeFilter"
        /// "callAuthorizationCodeFilter" and "subscriberType" are ignored if call logs are stored in CDS. When
        /// "ReceivedOrMissed" is specified as "callLogType" and call logs are stored in CDS, all call logs including
        /// placed will be returned.
        /// It is possible to restrict the number of rows returned using responsePagingControl. If responsePagingControl
        /// is not specified, the value of Enhanced Call Logs system parameter maxNonPagedResponseSize will control
        /// the maximum number of call logs can be returned.
        /// The response is either a UserEnhancedCallLogsGetListResponse21sp1V2 or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// callAuthorizationCodeFilter
        /// </summary>
        public static async Task<UserEnhancedCallLogsGetListResponse21sp1V2> UserEnhancedCallLogsGetListRequest21sp1V2Async(this OcipClient client, UserEnhancedCallLogsGetListRequest21sp1V2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserEnhancedCallLogsGetListResponse21sp1V2;
        }
        /// <summary>
        /// Request user's call logs.
        /// If the callLogType is not specified, all types of calls logs (placed, received, missed) are returned.
        /// The filters "dateTimeRange", "numberFilter", "redirectedNumberFilter", "accountAuthorizationCodeFilter"
        /// "callAuthorizationCodeFilter" and "subscriberType" are ignored if call logs are stored in CDS. When
        /// "ReceivedOrMissed" is specified as "callLogType" and call logs are stored in CDS, all call logs including
        /// placed will be returned.
        /// It is possible to restrict the number of rows returned using responsePagingControl. If responsePagingControl
        /// is not specified, the value of Enhanced Call Logs system parameter maxNonPagedResponseSize will control
        /// the maximum number of call logs can be returned.
        /// The response is either a UserEnhancedCallLogsGetListResponse22 or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// callAuthorizationCodeFilter
        /// </summary>
        [Obsolete("This method is deprecated. Use UserEnhancedCallLogsGetListRequest22Async instead.")]
        public static async Task<UserEnhancedCallLogsGetListResponse22> UserEnhancedCallLogsGetListRequest22(this OcipClient client, UserEnhancedCallLogsGetListRequest22 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserEnhancedCallLogsGetListResponse22;
        }

        /// <summary>
        /// Request user's call logs.
        /// If the callLogType is not specified, all types of calls logs (placed, received, missed) are returned.
        /// The filters "dateTimeRange", "numberFilter", "redirectedNumberFilter", "accountAuthorizationCodeFilter"
        /// "callAuthorizationCodeFilter" and "subscriberType" are ignored if call logs are stored in CDS. When
        /// "ReceivedOrMissed" is specified as "callLogType" and call logs are stored in CDS, all call logs including
        /// placed will be returned.
        /// It is possible to restrict the number of rows returned using responsePagingControl. If responsePagingControl
        /// is not specified, the value of Enhanced Call Logs system parameter maxNonPagedResponseSize will control
        /// the maximum number of call logs can be returned.
        /// The response is either a UserEnhancedCallLogsGetListResponse22 or an ErrorResponse.
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// callAuthorizationCodeFilter
        /// </summary>
        public static async Task<UserEnhancedCallLogsGetListResponse22> UserEnhancedCallLogsGetListRequest22Async(this OcipClient client, UserEnhancedCallLogsGetListRequest22 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserEnhancedCallLogsGetListResponse22;
        }
        /// <summary>
        /// Get the list of feature access codes for a user.
        /// The response is either a UserFeatureAccessCodeGetListResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserFeatureAccessCodeGetListRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserFeatureAccessCodeGetListRequestAsync instead.")]
        public static async Task<UserFeatureAccessCodeGetListResponse> UserFeatureAccessCodeGetListRequest(this OcipClient client, UserFeatureAccessCodeGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserFeatureAccessCodeGetListResponse;
        }

        /// <summary>
        /// Get the list of feature access codes for a user.
        /// The response is either a UserFeatureAccessCodeGetListResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserFeatureAccessCodeGetListRequest20 in AS data mode
        /// </summary>
        public static async Task<UserFeatureAccessCodeGetListResponse> UserFeatureAccessCodeGetListRequestAsync(this OcipClient client, UserFeatureAccessCodeGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserFeatureAccessCodeGetListResponse;
        }
        /// <summary>
        /// Request to get the user information.  The response is either UserGetResponse22V4 or ErrorResponse.
        /// 
        /// Replaced by: UserGetResponse22V5 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserGetRequest22V4Async instead.")]
        public static async Task<UserGetResponse22V4> UserGetRequest22V4(this OcipClient client, UserGetRequest22V4 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserGetResponse22V4;
        }

        /// <summary>
        /// Request to get the user information.  The response is either UserGetResponse22V4 or ErrorResponse.
        /// 
        /// Replaced by: UserGetResponse22V5 in AS data mode
        /// </summary>
        public static async Task<UserGetResponse22V4> UserGetRequest22V4Async(this OcipClient client, UserGetRequest22V4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserGetResponse22V4;
        }
        /// <summary>
        /// Request to get the user information.  The response is either UserGetResponse22V5 or ErrorResponse.
        /// 
        /// Replaced by: UserGetRequest22V6
        /// </summary>
        [Obsolete("This method is deprecated. Use UserGetRequest22V5Async instead.")]
        public static async Task<UserGetResponse22V5> UserGetRequest22V5(this OcipClient client, UserGetRequest22V5 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserGetResponse22V5;
        }

        /// <summary>
        /// Request to get the user information.  The response is either UserGetResponse22V5 or ErrorResponse.
        /// 
        /// Replaced by: UserGetRequest22V6
        /// </summary>
        public static async Task<UserGetResponse22V5> UserGetRequest22V5Async(this OcipClient client, UserGetRequest22V5 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserGetResponse22V5;
        }
        /// <summary>
        /// Request to get the user information.  The response is either UserGetResponse22V6 or ErrorResponse.
        /// 
        /// Replaced by: UserGetRequest22V7
        /// </summary>
        [Obsolete("This method is deprecated. Use UserGetRequest22V6Async instead.")]
        public static async Task<UserGetResponse22V6> UserGetRequest22V6(this OcipClient client, UserGetRequest22V6 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserGetResponse22V6;
        }

        /// <summary>
        /// Request to get the user information.  The response is either UserGetResponse22V6 or ErrorResponse.
        /// 
        /// Replaced by: UserGetRequest22V7
        /// </summary>
        public static async Task<UserGetResponse22V6> UserGetRequest22V6Async(this OcipClient client, UserGetRequest22V6 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserGetResponse22V6;
        }
        /// <summary>
        /// Request to get the user information.  The response is either UserGetResponse22V7 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserGetRequest22V7Async instead.")]
        public static async Task<UserGetResponse22V7> UserGetRequest22V7(this OcipClient client, UserGetRequest22V7 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserGetResponse22V7;
        }

        /// <summary>
        /// Request to get the user information.  The response is either UserGetResponse22V7 or ErrorResponse.
        /// </summary>
        public static async Task<UserGetResponse22V7> UserGetRequest22V7Async(this OcipClient client, UserGetRequest22V7 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserGetResponse22V7;
        }
        /// <summary>
        /// Modify the user level data associated with Hoteling Guest.
        /// There is no provisioning error will be given when setting hostUserId to not nil value while Hoteling Guest feature is not active.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by UserHotelingGuestModifyRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserHotelingGuestModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserHotelingGuestModifyRequest(this OcipClient client, UserHotelingGuestModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user level data associated with Hoteling Guest.
        /// There is no provisioning error will be given when setting hostUserId to not nil value while Hoteling Guest feature is not active.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by UserHotelingGuestModifyRequest21 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> UserHotelingGuestModifyRequestAsync(this OcipClient client, UserHotelingGuestModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the Integrated IMP specific service attribute for the user.
        /// The response is either UserIntegratedIMPGetResponse or ErrorResponse.
        /// 
        /// Replaced by: UserIntegratedIMPGetRequest21sp1
        /// </summary>
        [Obsolete("This method is deprecated. Use UserIntegratedIMPGetRequestAsync instead.")]
        public static async Task<UserIntegratedIMPGetResponse> UserIntegratedIMPGetRequest(this OcipClient client, UserIntegratedIMPGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserIntegratedIMPGetResponse;
        }

        /// <summary>
        /// Get the Integrated IMP specific service attribute for the user.
        /// The response is either UserIntegratedIMPGetResponse or ErrorResponse.
        /// 
        /// Replaced by: UserIntegratedIMPGetRequest21sp1
        /// </summary>
        public static async Task<UserIntegratedIMPGetResponse> UserIntegratedIMPGetRequestAsync(this OcipClient client, UserIntegratedIMPGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserIntegratedIMPGetResponse;
        }
        /// <summary>
        /// Get the user's intercept user service settings.
        /// The response is either a UserInterceptUserGetResponse16sp1 or an ErrorResponse.
        /// 
        /// Replaced by: UserInterceptUserGetRequest21sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserInterceptUserGetRequest16sp1Async instead.")]
        public static async Task<UserInterceptUserGetResponse16sp1> UserInterceptUserGetRequest16sp1(this OcipClient client, UserInterceptUserGetRequest16sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserInterceptUserGetResponse16sp1;
        }

        /// <summary>
        /// Get the user's intercept user service settings.
        /// The response is either a UserInterceptUserGetResponse16sp1 or an ErrorResponse.
        /// 
        /// Replaced by: UserInterceptUserGetRequest21sp1 in AS data mode
        /// </summary>
        public static async Task<UserInterceptUserGetResponse16sp1> UserInterceptUserGetRequest16sp1Async(this OcipClient client, UserInterceptUserGetRequest16sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserInterceptUserGetResponse16sp1;
        }
        /// <summary>
        /// Modify the user's intercept user service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserInterceptUserModifyResponse21sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserInterceptUserModifyRequest16Async instead.")]
        public static async Task<SuccessResponse> UserInterceptUserModifyRequest16(this OcipClient client, UserInterceptUserModifyRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's intercept user service settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserInterceptUserModifyResponse21sp1 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> UserInterceptUserModifyRequest16Async(this OcipClient client, UserInterceptUserModifyRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to modify a user.
        /// When oldPassword is specified, all password rule applies. If oldPassword in not specified,
        /// any password rule related to old password does not apply.
        /// The request will fail if officeZoneName or primaryZoneName is present but the Location-Based Calling Restrictions service is not assigned to the user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following data elements are only used in AS data mode:
        /// contact[2]-contact[5]
        /// nameDialingName
        /// alternateUserIdList
        /// The following elements are only used in AS data mode and will fail in XS data mode:
        /// trunkAddressing
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// allowVideo
        /// 
        /// The allowVideo element can only be used by a system administrator.
        /// The impId and impPassword are accepted when the Third-Party IMP service is assigned to the user;
        /// when Integrated IMP service is assigned to the user and active, only the impPassword is accepted;
        /// all other cases, the request fails if either field is changed.
        /// 
        /// Replaced by : UserAddRequest22 in AS mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserModifyRequest21Async instead.")]
        public static async Task<SuccessResponse> UserModifyRequest21(this OcipClient client, UserModifyRequest21 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify a user.
        /// When oldPassword is specified, all password rule applies. If oldPassword in not specified,
        /// any password rule related to old password does not apply.
        /// The request will fail if officeZoneName or primaryZoneName is present but the Location-Based Calling Restrictions service is not assigned to the user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following data elements are only used in AS data mode:
        /// contact[2]-contact[5]
        /// nameDialingName
        /// alternateUserIdList
        /// The following elements are only used in AS data mode and will fail in XS data mode:
        /// trunkAddressing
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// allowVideo
        /// 
        /// The allowVideo element can only be used by a system administrator.
        /// The impId and impPassword are accepted when the Third-Party IMP service is assigned to the user;
        /// when Integrated IMP service is assigned to the user and active, only the impPassword is accepted;
        /// all other cases, the request fails if either field is changed.
        /// 
        /// Replaced by : UserAddRequest22 in AS mode
        /// </summary>
        public static async Task<SuccessResponse> UserModifyRequest21Async(this OcipClient client, UserModifyRequest21 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request the user level data associated with Music On Hold User.
        /// The response is either a UserMusicOnHoldUserGetResponse16 or an ErrorResponse.
        /// 
        /// Replaced by: UserMusicOnHoldUserGetRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMusicOnHoldUserGetRequest16Async instead.")]
        public static async Task<UserMusicOnHoldUserGetResponse16> UserMusicOnHoldUserGetRequest16(this OcipClient client, UserMusicOnHoldUserGetRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserMusicOnHoldUserGetResponse16;
        }

        /// <summary>
        /// Request the user level data associated with Music On Hold User.
        /// The response is either a UserMusicOnHoldUserGetResponse16 or an ErrorResponse.
        /// 
        /// Replaced by: UserMusicOnHoldUserGetRequest20 in AS data mode
        /// </summary>
        public static async Task<UserMusicOnHoldUserGetResponse16> UserMusicOnHoldUserGetRequest16Async(this OcipClient client, UserMusicOnHoldUserGetRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserMusicOnHoldUserGetResponse16;
        }
        /// <summary>
        /// Modify data for Music On Hold User.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserMusicOnHoldUserModifyRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserMusicOnHoldUserModifyRequest16Async instead.")]
        public static async Task<SuccessResponse> UserMusicOnHoldUserModifyRequest16(this OcipClient client, UserMusicOnHoldUserModifyRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify data for Music On Hold User.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserMusicOnHoldUserModifyRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> UserMusicOnHoldUserModifyRequest16Async(this OcipClient client, UserMusicOnHoldUserModifyRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a criteria for the user's pre-alerting service.
        /// The response is either a UserPreAlertingAnnouncementGetCriteriaResponse or an ErrorResponse.
        /// Replaced by: UserPreAlertingAnnouncementGetCriteriaRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPreAlertingAnnouncementGetCriteriaRequestAsync instead.")]
        public static async Task<UserPreAlertingAnnouncementGetCriteriaResponse> UserPreAlertingAnnouncementGetCriteriaRequest(this OcipClient client, UserPreAlertingAnnouncementGetCriteriaRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPreAlertingAnnouncementGetCriteriaResponse;
        }

        /// <summary>
        /// Get a criteria for the user's pre-alerting service.
        /// The response is either a UserPreAlertingAnnouncementGetCriteriaResponse or an ErrorResponse.
        /// Replaced by: UserPreAlertingAnnouncementGetCriteriaRequest21 in AS data mode
        /// </summary>
        public static async Task<UserPreAlertingAnnouncementGetCriteriaResponse> UserPreAlertingAnnouncementGetCriteriaRequestAsync(this OcipClient client, UserPreAlertingAnnouncementGetCriteriaRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPreAlertingAnnouncementGetCriteriaResponse;
        }
        /// <summary>
        /// Get the user's pre-alerting service setting.
        /// The response is either a UserPreAlertingAnnouncementGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserPreAlertingAnnouncementGetRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPreAlertingAnnouncementGetRequestAsync instead.")]
        public static async Task<UserPreAlertingAnnouncementGetResponse> UserPreAlertingAnnouncementGetRequest(this OcipClient client, UserPreAlertingAnnouncementGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPreAlertingAnnouncementGetResponse;
        }

        /// <summary>
        /// Get the user's pre-alerting service setting.
        /// The response is either a UserPreAlertingAnnouncementGetResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserPreAlertingAnnouncementGetRequest20 in AS data mode
        /// </summary>
        public static async Task<UserPreAlertingAnnouncementGetResponse> UserPreAlertingAnnouncementGetRequestAsync(this OcipClient client, UserPreAlertingAnnouncementGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPreAlertingAnnouncementGetResponse;
        }
        /// <summary>
        /// Modify the user's pre-alerting service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserPreAlertingAnnouncementModifyRequest20 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPreAlertingAnnouncementModifyRequestAsync instead.")]
        public static async Task<SuccessResponse> UserPreAlertingAnnouncementModifyRequest(this OcipClient client, UserPreAlertingAnnouncementModifyRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's pre-alerting service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserPreAlertingAnnouncementModifyRequest20 in AS data mode
        /// </summary>
        public static async Task<SuccessResponse> UserPreAlertingAnnouncementModifyRequestAsync(this OcipClient client, UserPreAlertingAnnouncementModifyRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get a criteria for the user's priority alert service.
        /// The response is either a UserPriorityAlertGetCriteriaResponse16 or an ErrorResponse.
        /// Replaced by: UserPriorityAlertGetCriteriaRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPriorityAlertGetCriteriaRequest16Async instead.")]
        public static async Task<UserPriorityAlertGetCriteriaResponse16> UserPriorityAlertGetCriteriaRequest16(this OcipClient client, UserPriorityAlertGetCriteriaRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPriorityAlertGetCriteriaResponse16;
        }

        /// <summary>
        /// Get a criteria for the user's priority alert service.
        /// The response is either a UserPriorityAlertGetCriteriaResponse16 or an ErrorResponse.
        /// Replaced by: UserPriorityAlertGetCriteriaRequest21 in AS data mode
        /// </summary>
        public static async Task<UserPriorityAlertGetCriteriaResponse16> UserPriorityAlertGetCriteriaRequest16Async(this OcipClient client, UserPriorityAlertGetCriteriaRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPriorityAlertGetCriteriaResponse16;
        }
        /// <summary>
        /// Request a table containing all of the push notification registrations for a user by
        /// either registration id or user id.
        /// The response is either UserPushNotificationRegistrationGetListResponse or ErrorResponse.
        /// 
        /// Replaced by: UserPushNotificationRegistrationGetListRequest21sp1
        /// </summary>
        [Obsolete("This method is deprecated. Use UserPushNotificationRegistrationGetListRequestAsync instead.")]
        public static async Task<UserPushNotificationRegistrationGetListResponse> UserPushNotificationRegistrationGetListRequest(this OcipClient client, UserPushNotificationRegistrationGetListRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserPushNotificationRegistrationGetListResponse;
        }

        /// <summary>
        /// Request a table containing all of the push notification registrations for a user by
        /// either registration id or user id.
        /// The response is either UserPushNotificationRegistrationGetListResponse or ErrorResponse.
        /// 
        /// Replaced by: UserPushNotificationRegistrationGetListRequest21sp1
        /// </summary>
        public static async Task<UserPushNotificationRegistrationGetListResponse> UserPushNotificationRegistrationGetListRequestAsync(this OcipClient client, UserPushNotificationRegistrationGetListRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserPushNotificationRegistrationGetListResponse;
        }
        /// <summary>
        /// Get the route list setting and the list of number ranges assigned to a user.
        /// The response is either UserRouteListGetResponse or ErrorResponse.
        /// 
        /// Replaced by: UserRouteListGetRequest22
        /// </summary>
        [Obsolete("This method is deprecated. Use UserRouteListGetRequestAsync instead.")]
        public static async Task<UserRouteListGetResponse> UserRouteListGetRequest(this OcipClient client, UserRouteListGetRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserRouteListGetResponse;
        }

        /// <summary>
        /// Get the route list setting and the list of number ranges assigned to a user.
        /// The response is either UserRouteListGetResponse or ErrorResponse.
        /// 
        /// Replaced by: UserRouteListGetRequest22
        /// </summary>
        public static async Task<UserRouteListGetResponse> UserRouteListGetRequestAsync(this OcipClient client, UserRouteListGetRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserRouteListGetResponse;
        }
        /// <summary>
        /// Get a criteria for the user's selective call acceptance service.
        /// The response is either a UserSelectiveCallAcceptanceGetCriteriaResponse16 or an ErrorResponse.
        /// Replaced by: UserSelectiveCallAcceptanceGetCriteriaRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSelectiveCallAcceptanceGetCriteriaRequest16Async instead.")]
        public static async Task<UserSelectiveCallAcceptanceGetCriteriaResponse16> UserSelectiveCallAcceptanceGetCriteriaRequest16(this OcipClient client, UserSelectiveCallAcceptanceGetCriteriaRequest16 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserSelectiveCallAcceptanceGetCriteriaResponse16;
        }

        /// <summary>
        /// Get a criteria for the user's selective call acceptance service.
        /// The response is either a UserSelectiveCallAcceptanceGetCriteriaResponse16 or an ErrorResponse.
        /// Replaced by: UserSelectiveCallAcceptanceGetCriteriaRequest21 in AS data mode
        /// </summary>
        public static async Task<UserSelectiveCallAcceptanceGetCriteriaResponse16> UserSelectiveCallAcceptanceGetCriteriaRequest16Async(this OcipClient client, UserSelectiveCallAcceptanceGetCriteriaRequest16 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserSelectiveCallAcceptanceGetCriteriaResponse16;
        }
        /// <summary>
        /// Get a criteria for the user's selective call rejection service.
        /// The response is either a UserSelectiveCallRejectionGetCriteriaResponse16sp1 or an ErrorResponse.
        /// Replaced by: UserSelectiveCallRejectionGetCriteriaRequest21 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSelectiveCallRejectionGetCriteriaRequest16sp1Async instead.")]
        public static async Task<UserSelectiveCallRejectionGetCriteriaResponse16sp1> UserSelectiveCallRejectionGetCriteriaRequest16sp1(this OcipClient client, UserSelectiveCallRejectionGetCriteriaRequest16sp1 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserSelectiveCallRejectionGetCriteriaResponse16sp1;
        }

        /// <summary>
        /// Get a criteria for the user's selective call rejection service.
        /// The response is either a UserSelectiveCallRejectionGetCriteriaResponse16sp1 or an ErrorResponse.
        /// Replaced by: UserSelectiveCallRejectionGetCriteriaRequest21 in AS data mode
        /// </summary>
        public static async Task<UserSelectiveCallRejectionGetCriteriaResponse16sp1> UserSelectiveCallRejectionGetCriteriaRequest16sp1Async(this OcipClient client, UserSelectiveCallRejectionGetCriteriaRequest16sp1 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserSelectiveCallRejectionGetCriteriaResponse16sp1;
        }
        /// <summary>
        /// Associate an access device instance to the user's Shared Call Appearance.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserSharedCallAppearanceAddEndpointRequest21sp2.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSharedCallAppearanceAddEndpointRequest21sp2Async instead.")]
        public static async Task<SuccessResponse> UserSharedCallAppearanceAddEndpointRequest21sp2(this OcipClient client, UserSharedCallAppearanceAddEndpointRequest21sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SuccessResponse;
        }

        /// <summary>
        /// Associate an access device instance to the user's Shared Call Appearance.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserSharedCallAppearanceAddEndpointRequest21sp2.
        /// </summary>
        public static async Task<SuccessResponse> UserSharedCallAppearanceAddEndpointRequest21sp2Async(this OcipClient client, UserSharedCallAppearanceAddEndpointRequest21sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Get the user's Shared Call Appearance service setting.
        /// The response is either a UserSharedCallAppearanceGetResponse16sp2 or an ErrorResponse.
        /// Replaced by: UserSharedCallAppearanceGetRequest21sp1.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserSharedCallAppearanceGetRequest16sp2Async instead.")]
        public static async Task<UserSharedCallAppearanceGetResponse16sp2> UserSharedCallAppearanceGetRequest16sp2(this OcipClient client, UserSharedCallAppearanceGetRequest16sp2 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserSharedCallAppearanceGetResponse16sp2;
        }

        /// <summary>
        /// Get the user's Shared Call Appearance service setting.
        /// The response is either a UserSharedCallAppearanceGetResponse16sp2 or an ErrorResponse.
        /// Replaced by: UserSharedCallAppearanceGetRequest21sp1.
        /// </summary>
        public static async Task<UserSharedCallAppearanceGetResponse16sp2> UserSharedCallAppearanceGetRequest16sp2Async(this OcipClient client, UserSharedCallAppearanceGetRequest16sp2 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserSharedCallAppearanceGetResponse16sp2;
        }
        /// <summary>
        /// Returns the Sh non-transparent data stored against a Public User Identity (a SIP URI
        /// or TEL URI).
        /// The response is either a UserShInterfaceGetPublicIdDataResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserShInterfaceGetPublicIdDataRequest21sp1.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserShInterfaceGetPublicIdDataRequestAsync instead.")]
        public static async Task<UserShInterfaceGetPublicIdDataResponse> UserShInterfaceGetPublicIdDataRequest(this OcipClient client, UserShInterfaceGetPublicIdDataRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserShInterfaceGetPublicIdDataResponse;
        }

        /// <summary>
        /// Returns the Sh non-transparent data stored against a Public User Identity (a SIP URI
        /// or TEL URI).
        /// The response is either a UserShInterfaceGetPublicIdDataResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserShInterfaceGetPublicIdDataRequest21sp1.
        /// </summary>
        public static async Task<UserShInterfaceGetPublicIdDataResponse> UserShInterfaceGetPublicIdDataRequestAsync(this OcipClient client, UserShInterfaceGetPublicIdDataRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserShInterfaceGetPublicIdDataResponse;
        }
        /// <summary>
        /// Returns the Sh non-transparent data stored against a userId.
        /// The response is either a UserShInterfaceGetUserIdDataResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserShInterfaceGetUserIdDataRequest21sp1 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use UserShInterfaceGetUserIdDataRequestAsync instead.")]
        public static async Task<UserShInterfaceGetUserIdDataResponse> UserShInterfaceGetUserIdDataRequest(this OcipClient client, UserShInterfaceGetUserIdDataRequest request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserShInterfaceGetUserIdDataResponse;
        }

        /// <summary>
        /// Returns the Sh non-transparent data stored against a userId.
        /// The response is either a UserShInterfaceGetUserIdDataResponse or an ErrorResponse.
        /// 
        /// Replaced by: UserShInterfaceGetUserIdDataRequest21sp1 in AS data mode.
        /// </summary>
        public static async Task<UserShInterfaceGetUserIdDataResponse> UserShInterfaceGetUserIdDataRequestAsync(this OcipClient client, UserShInterfaceGetUserIdDataRequest request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserShInterfaceGetUserIdDataResponse;
        }
        /// <summary>
        /// Get the user's voice messaging greeting information.
        /// The response is either a UserVoiceMessagingUserGetGreetingResponse18 or an ErrorResponse.
        /// 
        /// Replaced by UserVoiceMessagingUserGetGreetingRequest18sp1 in AS data mode
        /// </summary>
        [Obsolete("This method is deprecated. Use UserVoiceMessagingUserGetGreetingRequest18Async instead.")]
        public static async Task<UserVoiceMessagingUserGetGreetingResponse18> UserVoiceMessagingUserGetGreetingRequest18(this OcipClient client, UserVoiceMessagingUserGetGreetingRequest18 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as UserVoiceMessagingUserGetGreetingResponse18;
        }

        /// <summary>
        /// Get the user's voice messaging greeting information.
        /// The response is either a UserVoiceMessagingUserGetGreetingResponse18 or an ErrorResponse.
        /// 
        /// Replaced by UserVoiceMessagingUserGetGreetingRequest18sp1 in AS data mode
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetGreetingResponse18> UserVoiceMessagingUserGetGreetingRequest18Async(this OcipClient client, UserVoiceMessagingUserGetGreetingRequest18 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as UserVoiceMessagingUserGetGreetingResponse18;
        }

    }
}
