using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceProviderExtensions
    {

        /// <summary>
        /// Request to add a service provider access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceAddRequest14(this OcipClient client, ServiceProviderAccessDeviceAddRequest14 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a static configuration tag for a service provider access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceCustomTagAddRequest(this OcipClient client, ServiceProviderAccessDeviceCustomTagAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete static configuration tags for a service provider access device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceCustomTagDeleteListRequest(this OcipClient client, ServiceProviderAccessDeviceCustomTagDeleteListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the list of custom configuration tags managed by the Device Management System, on a per-device profile basis.
        /// The response is either ServiceProviderAccessDeviceCustomTagGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceCustomTagGetListResponse> ServiceProviderAccessDeviceCustomTagGetListRequest(this OcipClient client, ServiceProviderAccessDeviceCustomTagGetListRequest request)
        {
            return await client.Call(request) as ServiceProviderAccessDeviceCustomTagGetListResponse;
        }

        /// <summary>
        /// Request to modify a static configuration tag for a service provider access device.
        /// 
        /// The tagValueToEncrypt element can only be used by a system administrator.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// tagValueToEncrypt
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceCustomTagModifyRequest(this OcipClient client, ServiceProviderAccessDeviceCustomTagModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a specified service provider access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceDeleteRequest(this OcipClient client, ServiceProviderAccessDeviceDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the list of device files managed by the Device Management System, on a per-device profile basis.
        /// The response is either ServiceProviderAccessDeviceFileGetListResponse14sp8 or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceFileGetListResponse14sp8> ServiceProviderAccessDeviceFileGetListRequest14sp8(this OcipClient client, ServiceProviderAccessDeviceFileGetListRequest14sp8 request)
        {
            return await client.Call(request) as ServiceProviderAccessDeviceFileGetListResponse14sp8;
        }

        /// <summary>
        /// Request to get a service provider device profile file.
        /// The response is either ServiceProviderAccessDeviceFileGetResponse20 or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceFileGetResponse20> ServiceProviderAccessDeviceFileGetRequest20(this OcipClient client, ServiceProviderAccessDeviceFileGetRequest20 request)
        {
            return await client.Call(request) as ServiceProviderAccessDeviceFileGetResponse20;
        }

        /// <summary>
        /// Request to modify a specified service provider/enterprise access device file.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceFileModifyRequest14sp8(this OcipClient client, ServiceProviderAccessDeviceFileModifyRequest14sp8 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests the list of configurable device types of devices that have already been
        /// added to the service provider.
        /// The response is either ServiceProviderAccessDeviceGetEnhancedConfigurationTypeListResponse
        /// or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetEnhancedConfigurationTypeListResponse> ServiceProviderAccessDeviceGetEnhancedConfigurationTypeListRequest(this OcipClient client, ServiceProviderAccessDeviceGetEnhancedConfigurationTypeListRequest request)
        {
            return await client.Call(request) as ServiceProviderAccessDeviceGetEnhancedConfigurationTypeListResponse;
        }

        /// <summary>
        /// Requests the details of a specified configurable device type for a service provider.
        /// The response is either ServiceProviderAccessDeviceGetEnhancedConfigurationTypeResponse
        /// or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetEnhancedConfigurationTypeResponse> ServiceProviderAccessDeviceGetEnhancedConfigurationTypeRequest(this OcipClient client, ServiceProviderAccessDeviceGetEnhancedConfigurationTypeRequest request)
        {
            return await client.Call(request) as ServiceProviderAccessDeviceGetEnhancedConfigurationTypeResponse;
        }

        /// <summary>
        /// Requests the list of access devices in a service provider.
        /// The response is either ServiceProviderAccessDeviceGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetListResponse> ServiceProviderAccessDeviceGetListRequest(this OcipClient client, ServiceProviderAccessDeviceGetListRequest request)
        {
            return await client.Call(request) as ServiceProviderAccessDeviceGetListResponse;
        }

        /// <summary>
        /// Requests the configuration of a specified service provider access device.
        /// The response is either ServiceProviderAccessDeviceGetResponse18sp1 or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetResponse18sp1> ServiceProviderAccessDeviceGetRequest18sp1(this OcipClient client, ServiceProviderAccessDeviceGetRequest18sp1 request)
        {
            return await client.Call(request) as ServiceProviderAccessDeviceGetResponse18sp1;
        }

        /// <summary>
        /// Requests the list of users on a specified device.
        /// The response is either ServiceProviderAccessDeviceGetUserListResponse21sp1 or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaAccessDeviceEndpointPrivateIdentity
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceGetUserListResponse21sp1> ServiceProviderAccessDeviceGetUserListRequest21sp1(this OcipClient client, ServiceProviderAccessDeviceGetUserListRequest21sp1 request)
        {
            return await client.Call(request) as ServiceProviderAccessDeviceGetUserListResponse21sp1;
        }

        /// <summary>
        /// Request to modify a specified service provider access device.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceModifyRequest14(this OcipClient client, ServiceProviderAccessDeviceModifyRequest14 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify attributes for line/ports assigned on the service provider device profile.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// privateIdentity
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceModifyUserRequest(this OcipClient client, ServiceProviderAccessDeviceModifyUserRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Reset a specific service provider SIP device that supports the reset operation.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceResetRequest(this OcipClient client, ServiceProviderAccessDeviceResetRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the custom configuration tag set defined at the access device.
        /// The response is either ServiceProviderAccessDeviceTagSetGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAccessDeviceTagSetGetResponse> ServiceProviderAccessDeviceTagSetGetRequest(this OcipClient client, ServiceProviderAccessDeviceTagSetGetRequest request)
        {
            return await client.Call(request) as ServiceProviderAccessDeviceTagSetGetResponse;
        }

        /// <summary>
        /// Request to modify a static configuration tag set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAccessDeviceTagSetModifyRequest(this OcipClient client, ServiceProviderAccessDeviceTagSetModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
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
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAddRequest13mp2(this OcipClient client, ServiceProviderAddRequest13mp2 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a service provider administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAdminAddRequest14(this OcipClient client, ServiceProviderAdminAddRequest14 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a service provider administrator.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAdminDeleteRequest(this OcipClient client, ServiceProviderAdminDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a list of service provider administrators.
        /// The response is either a ServiceProviderAdminGetListResponse14 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAdminGetListResponse14> ServiceProviderAdminGetListRequest14(this OcipClient client, ServiceProviderAdminGetListRequest14 request)
        {
            return await client.Call(request) as ServiceProviderAdminGetListResponse14;
        }

        /// <summary>
        /// Get a list of service provider administrators.
        /// The response is either a ServiceProviderAdminGetPagedSortedListResponse or an ErrorResponse.
        /// If no sortOrder is included, the response is sorted by Administrator ID ascending by default.
        /// If the responsePagingControl element is not provided, the paging startIndex will be
        /// set to 1 by default, and the responsePageSize will be set to the maximum
        /// responsePageSize by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is
        /// included. Then the search criteria are logically ORed together.
        /// </summary>
        public static async Task<ServiceProviderAdminGetPagedSortedListResponse> ServiceProviderAdminGetPagedSortedListRequest(this OcipClient client, ServiceProviderAdminGetPagedSortedListRequest request)
        {
            return await client.Call(request) as ServiceProviderAdminGetPagedSortedListResponse;
        }

        /// <summary>
        /// Requests the service provider administrator's policy settings.
        /// The response is either ServiceProviderAdminGetPolicyResponse20 or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAdminGetPolicyResponse20> ServiceProviderAdminGetPolicyRequest20(this OcipClient client, ServiceProviderAdminGetPolicyRequest20 request)
        {
            return await client.Call(request) as ServiceProviderAdminGetPolicyResponse20;
        }

        /// <summary>
        /// Get a service provider administrators profile.
        /// The response is either a ServiceProviderAdminGetResponse21sp1 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAdminGetResponse21sp1> ServiceProviderAdminGetRequest21sp1(this OcipClient client, ServiceProviderAdminGetRequest21sp1 request)
        {
            return await client.Call(request) as ServiceProviderAdminGetResponse21sp1;
        }

        /// <summary>
        /// Requests the effective password rules setting for a service provider administrator
        /// The response is either ServiceProviderAdministratorPasswordRulesGetResponse or
        /// ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAdministratorPasswordRulesGetResponse> ServiceProviderAdministratorPasswordRulesGetRequest(this OcipClient client, ServiceProviderAdministratorPasswordRulesGetRequest request)
        {
            return await client.Call(request) as ServiceProviderAdministratorPasswordRulesGetResponse;
        }

        /// <summary>
        /// Request to modify the service provider administrator's policy settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// The networkPolicyAccess is only modified for the enterprise administrator.
        /// The following elements are only used in AS data mode:
        /// dialableCallerIDAccess
        /// verifyTranslationAndroutingAccess
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAdminModifyPolicyRequest14(this OcipClient client, ServiceProviderAdminModifyPolicyRequest14 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify a service provider administrator.
        /// Since old password is not specified here, any password rule related to old password
        /// does not apply.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAdminModifyRequest(this OcipClient client, ServiceProviderAdminModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a service provider or enterprise's answer confirmation settings.
        /// The response is either a ServiceProviderAnswerConfirmationGetResponse16 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderAnswerConfirmationGetResponse16> ServiceProviderAnswerConfirmationGetRequest16(this OcipClient client, ServiceProviderAnswerConfirmationGetRequest16 request)
        {
            return await client.Call(request) as ServiceProviderAnswerConfirmationGetResponse16;
        }

        /// <summary>
        /// Modify a service provider or enterprise's answer confirmation settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderAnswerConfirmationModifyRequest16(this OcipClient client, ServiceProviderAnswerConfirmationModifyRequest16 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the Application Server set for a service provider or enterprise.
        /// The response is either a ServiceProviderApplicationServerSetGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderApplicationServerSetGetResponse> ServiceProviderApplicationServerSetGetRequest(this OcipClient client, ServiceProviderApplicationServerSetGetRequest request)
        {
            return await client.Call(request) as ServiceProviderApplicationServerSetGetResponse;
        }

        /// <summary>
        /// Modify the Application Server set assigned to the service provider or enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderApplicationServerSetModifyRequest(this OcipClient client, ServiceProviderApplicationServerSetModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the service provider level data associated with Call Processing
        /// Policy. The response is either a ServiceProviderCallProcessingGetPolicyResponse22V2 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCallProcessingGetPolicyResponse22V2> ServiceProviderCallProcessingGetPolicyRequest22V2(this OcipClient client, ServiceProviderCallProcessingGetPolicyRequest22V2 request)
        {
            return await client.Call(request) as ServiceProviderCallProcessingGetPolicyResponse22V2;
        }

        /// <summary>
        /// Modify the service provider level data associated with Call Processing
        /// Policy. The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// useServiceProviderDCLIDSetting
        /// enableDialableCallerID
        /// allowConfigurableCLIDForRedirectingIdentity
        /// enterpriseCallsCLIDPolicy
        /// groupCallsCLIDPolicy
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// enablePhoneListLookup
        /// useMaxConcurrentTerminatingAlertingRequests
        /// maxConcurrentTerminatingAlertingRequests
        /// includeRedirectionsInMaximumNumberOfConcurrentCalls
        /// useUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable
        /// useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable
        /// allowMobileDNForRedirectingIdentity
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// routeOverrideDomain
        /// routeOverridePrefix
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCallProcessingModifyPolicyRequest15(this OcipClient client, ServiceProviderCallProcessingModifyPolicyRequest15 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of Communication Barring Criteria to a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringCriteriaAssignListRequest(this OcipClient client, ServiceProviderCommunicationBarringCriteriaAssignListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a list of Communication Barring Criteria assigned to a service provider.
        /// The response is either a ServiceProviderCommunicationBarringCriteriaGetAssignedListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringCriteriaGetAssignedListResponse> ServiceProviderCommunicationBarringCriteriaGetAssignedListRequest(this OcipClient client, ServiceProviderCommunicationBarringCriteriaGetAssignedListRequest request)
        {
            return await client.Call(request) as ServiceProviderCommunicationBarringCriteriaGetAssignedListResponse;
        }

        /// <summary>
        /// Unassign a list of Communication Barring Criteria from a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringCriteriaUnassignListRequest(this OcipClient client, ServiceProviderCommunicationBarringCriteriaUnassignListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Communication Barring Digit Pattern Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringDigitPatternCriteriaAddRequest(this OcipClient client, ServiceProviderCommunicationBarringDigitPatternCriteriaAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete an existing Communication Barring Digit Pattern Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringDigitPatternCriteriaDeleteRequest(this OcipClient client, ServiceProviderCommunicationBarringDigitPatternCriteriaDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the list of all Digit Pattern Criteria defined for the service provider.
        /// The response is either a ServiceProviderCommunicationBarringDigitPatternCriteriaGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringDigitPatternCriteriaGetListResponse> ServiceProviderCommunicationBarringDigitPatternCriteriaGetListRequest(this OcipClient client, ServiceProviderCommunicationBarringDigitPatternCriteriaGetListRequest request)
        {
            return await client.Call(request) as ServiceProviderCommunicationBarringDigitPatternCriteriaGetListResponse;
        }

        /// <summary>
        /// Get an existing Digit Pattern Criteria.
        /// The response is either a ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListResponse> ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListRequest(this OcipClient client, ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListRequest request)
        {
            return await client.Call(request) as ServiceProviderCommunicationBarringDigitPatternCriteriaGetPatternListResponse;
        }

        /// <summary>
        /// Get an existing Digit Pattern Criteria.
        /// The response is either a ServiceProviderCommunicationBarringDigitPatternCriteriaGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringDigitPatternCriteriaGetResponse> ServiceProviderCommunicationBarringDigitPatternCriteriaGetRequest(this OcipClient client, ServiceProviderCommunicationBarringDigitPatternCriteriaGetRequest request)
        {
            return await client.Call(request) as ServiceProviderCommunicationBarringDigitPatternCriteriaGetResponse;
        }

        /// <summary>
        /// Modify an existing Communication Barring Digit Pattern Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringDigitPatternCriteriaModifyRequest(this OcipClient client, ServiceProviderCommunicationBarringDigitPatternCriteriaModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of Communication Barring Incoming Criteria to a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringIncomingCriteriaAssignListRequest(this OcipClient client, ServiceProviderCommunicationBarringIncomingCriteriaAssignListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a list of Communication Barring Incoming Criteria assigned to a service provider.
        /// The response is either a ServiceProviderCommunicationBarringIncomingCriteriaGetAssignedListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringIncomingCriteriaGetAssignedListResponse> ServiceProviderCommunicationBarringIncomingCriteriaGetAssignedListRequest(this OcipClient client, ServiceProviderCommunicationBarringIncomingCriteriaGetAssignedListRequest request)
        {
            return await client.Call(request) as ServiceProviderCommunicationBarringIncomingCriteriaGetAssignedListResponse;
        }

        /// <summary>
        /// Unassign a list of Communication Barring Incoming Criteria from a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringIncomingCriteriaUnassignListRequest(this OcipClient client, ServiceProviderCommunicationBarringIncomingCriteriaUnassignListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Communication Barring Profile.
        /// The priorities for OriginatingRules, RedirectingRules, CallMeNowRules and IncomingRules are requantized to consecutive integers as part of the add.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// callMeNowDefaultAction, use value "Block" in XS data mode
        /// callMeNowDefaultCallTimeout
        /// callMeNowRule
        /// applyToAttendedCallTransfers, use value "false" in XS data mode
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringProfileAddRequest19sp1(this OcipClient client, ServiceProviderCommunicationBarringProfileAddRequest19sp1 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Deletes an existing Communication Barring Profile.  Optionally, a new default profile can be chosen if the current default profile is being deleted.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringProfileDeleteRequest(this OcipClient client, ServiceProviderCommunicationBarringProfileDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a list of groups within a service provider that have a given
        /// Communication Barring Profile assigned.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetAssignedGroupListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringProfileGetAssignedGroupListResponse> ServiceProviderCommunicationBarringProfileGetAssignedGroupListRequest(this OcipClient client, ServiceProviderCommunicationBarringProfileGetAssignedGroupListRequest request)
        {
            return await client.Call(request) as ServiceProviderCommunicationBarringProfileGetAssignedGroupListResponse;
        }

        /// <summary>
        /// Get a list of Communication Barring profiles within a service provider that have a given Communication Barring Criteria assigned.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringProfileGetCriteriaUsageListResponse> ServiceProviderCommunicationBarringProfileGetCriteriaUsageListRequest(this OcipClient client, ServiceProviderCommunicationBarringProfileGetCriteriaUsageListRequest request)
        {
            return await client.Call(request) as ServiceProviderCommunicationBarringProfileGetCriteriaUsageListResponse;
        }

        /// <summary>
        /// Get the list of Profiles that use a specific Digit Pattern Criteria.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetDigitPatternCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringProfileGetDigitPatternCriteriaUsageListResponse> ServiceProviderCommunicationBarringProfileGetDigitPatternCriteriaUsageListRequest(this OcipClient client, ServiceProviderCommunicationBarringProfileGetDigitPatternCriteriaUsageListRequest request)
        {
            return await client.Call(request) as ServiceProviderCommunicationBarringProfileGetDigitPatternCriteriaUsageListResponse;
        }

        /// <summary>
        /// Get a list of Communication Barring profiles within a service provider that have a given Communication Barring Incoming Criteria assigned.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetIncomingCriteriaUsageListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringProfileGetIncomingCriteriaUsageListResponse> ServiceProviderCommunicationBarringProfileGetIncomingCriteriaUsageListRequest(this OcipClient client, ServiceProviderCommunicationBarringProfileGetIncomingCriteriaUsageListRequest request)
        {
            return await client.Call(request) as ServiceProviderCommunicationBarringProfileGetIncomingCriteriaUsageListResponse;
        }

        /// <summary>
        /// Get the list of all Communication Barring Profiles.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringProfileGetListResponse> ServiceProviderCommunicationBarringProfileGetListRequest(this OcipClient client, ServiceProviderCommunicationBarringProfileGetListRequest request)
        {
            return await client.Call(request) as ServiceProviderCommunicationBarringProfileGetListResponse;
        }

        /// <summary>
        /// Get an existing Communication Barring Profile.
        /// The response is either a ServiceProviderCommunicationBarringProfileGetResponse19sp1V2
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderCommunicationBarringProfileGetResponse19sp1V2> ServiceProviderCommunicationBarringProfileGetRequest19sp1V2(this OcipClient client, ServiceProviderCommunicationBarringProfileGetRequest19sp1V2 request)
        {
            return await client.Call(request) as ServiceProviderCommunicationBarringProfileGetResponse19sp1V2;
        }

        /// <summary>
        /// Modifies the default Communication Barring Profile of a Service Provider.  If a default has been previously selected, this command will swap the default profile with the profile provided.  Selecting a nil profile will cause the service provider to not have a default Communicaton Barring Profile.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringProfileModifyDefaultRequest(this OcipClient client, ServiceProviderCommunicationBarringProfileModifyDefaultRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify an existing Communication Barring Profile.
        /// The priorities for OriginatingRules, RedirectingRules, CallMeNowRules and IncomingRules are requantized to consecutive integers as part of the modify.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in AS data mode:
        /// callMeNowDefaultAction
        /// callMeNowDefaultCallTimeout
        /// callMeNowRule
        /// applyToAttendedCallTransfers
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCommunicationBarringProfileModifyRequest(this OcipClient client, ServiceProviderCommunicationBarringProfileModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Rebuild the service provider default config file for the specified device type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCPEConfigRebuildConfigFileRequest(this OcipClient client, ServiceProviderCPEConfigRebuildConfigFileRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Rebuild the config file for a specified device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCPEConfigRebuildDeviceConfigFileRequest(this OcipClient client, ServiceProviderCPEConfigRebuildDeviceConfigFileRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Reorder the lines of a Service Provider device. You can not add or delete line ports, only
        /// re-ordering the list is allowed. The ordered list of line ports can be obtained
        /// with the ServiceProviderAccessDeviceGetRequest command.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCPEConfigReorderDeviceLinePortsRequest(this OcipClient client, ServiceProviderCPEConfigReorderDeviceLinePortsRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Reset a specific service provider or enterprise device.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCPEConfigResetDeviceRequest(this OcipClient client, ServiceProviderCPEConfigResetDeviceRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Reset all the devices of the specified device type in a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCPEConfigResetDeviceTypeRequest(this OcipClient client, ServiceProviderCPEConfigResetDeviceTypeRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to set a new service provider default configuration file for a device type.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// When the element configFile is set to nil, the configuration file defined
        /// at the parent level is used.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderCPEConfigSetConfigFileRequest(this OcipClient client, ServiceProviderCPEConfigSetConfigFileRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a service provider or enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDeleteRequest(this OcipClient client, ServiceProviderDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request device management's events for a specific queue.
        /// It is possible to restrict the number of rows returned using
        /// responseSizeLimit.
        /// If eventQueueType is not specified, the events from all the
        /// event queues are returned.
        /// The response is either a ServiceProviderDeviceManagementEventGetListResponse22 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDeviceManagementEventGetListResponse22> ServiceProviderDeviceManagementEventGetListRequest22(this OcipClient client, ServiceProviderDeviceManagementEventGetListRequest22 request)
        {
            return await client.Call(request) as ServiceProviderDeviceManagementEventGetListResponse22;
        }

        /// <summary>
        /// Request the number of access device of a particular device type and service provider.
        /// If countOnlyResetSupportedDevice is true, count only access devices if the device type supports reset.
        /// By default unmanaged device types are not allowed and devices are counted only if their device type supports Device Management.
        /// An error is returned if deviceType is specified but does not support device management.
        /// When allowUnmanagedDeviceType is true, unmanaged device type will be counted and a successful response is returned.
        /// The response is either ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderResponse> ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderRequest(this OcipClient client, ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderRequest request)
        {
            return await client.Call(request) as ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderResponse;
        }

        /// <summary>
        /// Cancel pending and in progress events.  A list of individual events can
        /// be canceled.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDeviceManagementInProgressAndPendingEventCancelRequest(this OcipClient client, ServiceProviderDeviceManagementInProgressAndPendingEventCancelRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the service provider level device profile authentication password rule settings.
        /// The response is either a ServiceProviderDeviceProfileAuthenticationPasswordRulesGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDeviceProfileAuthenticationPasswordRulesGetResponse> ServiceProviderDeviceProfileAuthenticationPasswordRulesGetRequest(this OcipClient client, ServiceProviderDeviceProfileAuthenticationPasswordRulesGetRequest request)
        {
            return await client.Call(request) as ServiceProviderDeviceProfileAuthenticationPasswordRulesGetResponse;
        }

        /// <summary>
        /// Request to modify the service provider level device profile authentication password rule settings. The useServiceProviderSettings element can only be modified by a system administrator or a provisioning administrator.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDeviceProfileAuthenticationPasswordRulesModifyRequest(this OcipClient client, ServiceProviderDeviceProfileAuthenticationPasswordRulesModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a static configuration tag for an access device type used in a service provider.
        /// 
        /// The following elements are only used in XS data mode:
        /// isTagValueEncrypted, use value "false" in AS data mode
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// tagValueToEncrypt
        /// 
        /// The tagValueToEncrypt element can only be used by a system administrator.
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDeviceTypeCustomTagAddRequest(this OcipClient client, ServiceProviderDeviceTypeCustomTagAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete static configuration tags for an access device type used in a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDeviceTypeCustomTagDeleteListRequest(this OcipClient client, ServiceProviderDeviceTypeCustomTagDeleteListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the list of custom configuration tags managed by the Device Management System, on a per-device type basis for a service provider.
        /// The response is either ServiceProviderDeviceTypeCustomTagGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDeviceTypeCustomTagGetListResponse> ServiceProviderDeviceTypeCustomTagGetListRequest(this OcipClient client, ServiceProviderDeviceTypeCustomTagGetListRequest request)
        {
            return await client.Call(request) as ServiceProviderDeviceTypeCustomTagGetListResponse;
        }

        /// <summary>
        /// Request to modify a static configuration tag for an access device type used in a service provider.
        /// 
        /// The tagValueToEncrypt element can only be used by a system administrator.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// tagValueToEncrypt
        /// 
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDeviceTypeCustomTagModifyRequest(this OcipClient client, ServiceProviderDeviceTypeCustomTagModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the list of device type files managed by the Device Management System, on a per-service provider basis.
        /// The response is either ServiceProviderDeviceTypeFileGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDeviceTypeFileGetListResponse> ServiceProviderDeviceTypeFileGetListRequest(this OcipClient client, ServiceProviderDeviceTypeFileGetListRequest request)
        {
            return await client.Call(request) as ServiceProviderDeviceTypeFileGetListResponse;
        }

        /// <summary>
        /// Request to get a service provider device type file.
        /// The response is either ServiceProviderDeviceTypeFileGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDeviceTypeFileGetResponse> ServiceProviderDeviceTypeFileGetRequest(this OcipClient client, ServiceProviderDeviceTypeFileGetRequest request)
        {
            return await client.Call(request) as ServiceProviderDeviceTypeFileGetResponse;
        }

        /// <summary>
        /// Request to modify a specified device type file for a service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDeviceTypeFileModifyRequest(this OcipClient client, ServiceProviderDeviceTypeFileModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the custom configuration tag set defined for the service provider and device type.
        /// The response is either ServiceProviderDeviceTypeTagSetGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDeviceTypeTagSetGetResponse> ServiceProviderDeviceTypeTagSetGetRequest(this OcipClient client, ServiceProviderDeviceTypeTagSetGetRequest request)
        {
            return await client.Call(request) as ServiceProviderDeviceTypeTagSetGetResponse;
        }

        /// <summary>
        /// Request to modify a static configuration tag set.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDeviceTypeTagSetModifyRequest(this OcipClient client, ServiceProviderDeviceTypeTagSetModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a new Dialable Caller ID Criteria. Criteria are added at the bottom of the list with the lowest priority. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDialableCallerIDCriteriaAddRequest(this OcipClient client, ServiceProviderDialableCallerIDCriteriaAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a Dialable Caller ID Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDialableCallerIDCriteriaDeleteRequest(this OcipClient client, ServiceProviderDialableCallerIDCriteriaDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get an existing Dialable Caller ID Criteria.
        /// The response is either a ServiceProviderDialableCallerIDCriteriaGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDialableCallerIDCriteriaGetResponse> ServiceProviderDialableCallerIDCriteriaGetRequest(this OcipClient client, ServiceProviderDialableCallerIDCriteriaGetRequest request)
        {
            return await client.Call(request) as ServiceProviderDialableCallerIDCriteriaGetResponse;
        }

        /// <summary>
        /// Modify a Dialable Caller ID Criteria.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDialableCallerIDCriteriaModifyRequest(this OcipClient client, ServiceProviderDialableCallerIDCriteriaModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the service provider?s Dialable Caller ID settings and criteria list.
        /// The response is either a ServiceProviderDialableCallerIDGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDialableCallerIDGetResponse> ServiceProviderDialableCallerIDGetRequest(this OcipClient client, ServiceProviderDialableCallerIDGetRequest request)
        {
            return await client.Call(request) as ServiceProviderDialableCallerIDGetResponse;
        }

        /// <summary>
        /// Modify the service provider?s Dialable Caller ID settings and criteria list.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDialableCallerIDModifyRequest(this OcipClient client, ServiceProviderDialableCallerIDModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a Service Provider level Dial Plan Access Code and its all attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDialPlanPolicyAddAccessCodeRequest(this OcipClient client, ServiceProviderDialPlanPolicyAddAccessCodeRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a Service Provider level Dial Plan Access Code and its all attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDialPlanPolicyDeleteAccessCodeRequest(this OcipClient client, ServiceProviderDialPlanPolicyDeleteAccessCodeRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the Service Provider level data associated with Dial Plan Policy.
        /// The response is either a ServiceProviderDialPlanPolicyGetAccessCodeListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDialPlanPolicyGetAccessCodeListResponse> ServiceProviderDialPlanPolicyGetAccessCodeListRequest(this OcipClient client, ServiceProviderDialPlanPolicyGetAccessCodeListRequest request)
        {
            return await client.Call(request) as ServiceProviderDialPlanPolicyGetAccessCodeListResponse;
        }

        /// <summary>
        /// Request access code data associated with Service Provider level Dial Plan Policy access codes.
        /// The response is either a ServiceProviderDialPlanPolicyGetAccessCodeResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDialPlanPolicyGetAccessCodeResponse> ServiceProviderDialPlanPolicyGetAccessCodeRequest(this OcipClient client, ServiceProviderDialPlanPolicyGetAccessCodeRequest request)
        {
            return await client.Call(request) as ServiceProviderDialPlanPolicyGetAccessCodeResponse;
        }

        /// <summary>
        /// Request the Service Provider level data associated with Dial Plan Policy.
        /// The response is either a ServiceProviderDialPlanPolicyGetResponse17
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDialPlanPolicyGetResponse17> ServiceProviderDialPlanPolicyGetRequest17(this OcipClient client, ServiceProviderDialPlanPolicyGetRequest17 request)
        {
            return await client.Call(request) as ServiceProviderDialPlanPolicyGetResponse17;
        }

        /// <summary>
        /// Request to modify a Service Provider level Dial Plan Access Code and its attribues.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDialPlanPolicyModifyAccessCodeRequest(this OcipClient client, ServiceProviderDialPlanPolicyModifyAccessCodeRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the Service Provider level data associated with Dial Plan Policy.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDialPlanPolicyModifyRequest(this OcipClient client, ServiceProviderDialPlanPolicyModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the service provider's digit collection attributes.
        /// The response is either a ServiceProviderDigitCollectionGetResponse13mp4 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDigitCollectionGetResponse13mp4> ServiceProviderDigitCollectionGetRequest13mp4(this OcipClient client, ServiceProviderDigitCollectionGetRequest13mp4 request)
        {
            return await client.Call(request) as ServiceProviderDigitCollectionGetResponse13mp4;
        }

        /// <summary>
        /// Modifies the service provider's digit collection attributes.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDigitCollectionModifyRequest(this OcipClient client, ServiceProviderDigitCollectionModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Adds DNs to a service provider. It is possible to add either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDnAddListRequest(this OcipClient client, ServiceProviderDnAddListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Deletes DNs from a service provider. It is possible to delete either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDnDeleteListRequest(this OcipClient client, ServiceProviderDnDeleteListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request a list of available DNs not yet assigned to any group.
        /// Dns assigned to the IMRN pool are not listed in the response.
        /// The response is either ServiceProviderDnGetAvailableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDnGetAvailableListResponse> ServiceProviderDnGetAvailableListRequest(this OcipClient client, ServiceProviderDnGetAvailableListRequest request)
        {
            return await client.Call(request) as ServiceProviderDnGetAvailableListResponse;
        }

        /// <summary>
        /// Request a summary table of all DNs in a service provider.
        /// Dns assigned to the IMRN pool are not listed in the response.
        /// The search can be done using multiple criteria. Only results matching all the search criteria are included in the results.
        /// The response is either ServiceProviderDnGetSummaryListResponse or ErrorResponse.
        /// 
        /// The following elements are only used in XS data mode and ignored in AS data mode:
        /// searchCriteriaDn, searchCriteriaGroupId
        /// </summary>
        public static async Task<ServiceProviderDnGetSummaryListResponse> ServiceProviderDnGetSummaryListRequest(this OcipClient client, ServiceProviderDnGetSummaryListRequest request)
        {
            return await client.Call(request) as ServiceProviderDnGetSummaryListResponse;
        }

        /// <summary>
        /// Assign a list of domains to a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDomainAssignListRequest(this OcipClient client, ServiceProviderDomainAssignListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests a list of groups within a service provider that have a given domain assigned.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a ServiceProviderDomainGetAssignedGroupListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDomainGetAssignedGroupListResponse> ServiceProviderDomainGetAssignedGroupListRequest(this OcipClient client, ServiceProviderDomainGetAssignedGroupListRequest request)
        {
            return await client.Call(request) as ServiceProviderDomainGetAssignedGroupListResponse;
        }

        /// <summary>
        /// Requests the list of all domains assigned to a service provider.
        /// The response is either ServiceProviderDomainGetAssignedListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderDomainGetAssignedListResponse> ServiceProviderDomainGetAssignedListRequest(this OcipClient client, ServiceProviderDomainGetAssignedListRequest request)
        {
            return await client.Call(request) as ServiceProviderDomainGetAssignedListResponse;
        }

        /// <summary>
        /// Requests the list of all matching domains assigned to a service provider .
        /// The response is either ServiceProviderDomainGetAssignedListResponse22 or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode and will be ignored in XS data mode:
        /// responseSizeLimit
        /// searchCriteriaDomainName
        /// </summary>
        public static async Task<ServiceProviderDomainGetAssignedListResponse22> ServiceProviderDomainGetAssignedListRequest22(this OcipClient client, ServiceProviderDomainGetAssignedListRequest22 request)
        {
            return await client.Call(request) as ServiceProviderDomainGetAssignedListResponse22;
        }

        /// <summary>
        /// Unassign a list of domains from a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderDomainUnassignListRequest(this OcipClient client, ServiceProviderDomainUnassignListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the service provider level data associated with Emergency Call Notification.
        /// The response is either a ServiceProviderEmergencyCallNotificationGetResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderEmergencyCallNotificationGetResponse> ServiceProviderEmergencyCallNotificationGetRequest(this OcipClient client, ServiceProviderEmergencyCallNotificationGetRequest request)
        {
            return await client.Call(request) as ServiceProviderEmergencyCallNotificationGetResponse;
        }

        /// <summary>
        /// Modify the service provider or enterprise level data associated with Emergency
        /// Call Notification.  The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderEmergencyCallNotificationModifyRequest(this OcipClient client, ServiceProviderEmergencyCallNotificationModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to search endpoints in the service provider/enterprise.
        /// The response is either ServiceProviderEndpointGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderEndpointGetListResponse> ServiceProviderEndpointGetListRequest(this OcipClient client, ServiceProviderEndpointGetListRequest request)
        {
            return await client.Call(request) as ServiceProviderEndpointGetListResponse;
        }

        /// <summary>
        /// Get the list of feature access codes for a service provider or enterprise.
        /// The response is either a ServiceProviderFeatureAccessCodeGetListResponse21
        /// or an ErrorResponse.
        /// 
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// </summary>
        public static async Task<ServiceProviderFeatureAccessCodeGetListResponse21> ServiceProviderFeatureAccessCodeGetListRequest21(this OcipClient client, ServiceProviderFeatureAccessCodeGetListRequest21 request)
        {
            return await client.Call(request) as ServiceProviderFeatureAccessCodeGetListResponse21;
        }

        /// <summary>
        /// Modify a list of feature access codes for a service provider or enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// In release 20 the "Call Recording" FAC name is changed to
        /// "Call Recording - Start".
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderFeatureAccessCodeModifyListRequest21(this OcipClient client, ServiceProviderFeatureAccessCodeModifyListRequest21 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a new service provider file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderFileRepositoryDeviceUserAddRequest(this OcipClient client, ServiceProviderFileRepositoryDeviceUserAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a service provider file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderFileRepositoryDeviceUserDeleteRequest(this OcipClient client, ServiceProviderFileRepositoryDeviceUserDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the list of service provider users for a file repository in the system.
        /// The response is either a ServiceProviderFileRepositoryDeviceUserGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderFileRepositoryDeviceUserGetListResponse> ServiceProviderFileRepositoryDeviceUserGetListRequest(this OcipClient client, ServiceProviderFileRepositoryDeviceUserGetListRequest request)
        {
            return await client.Call(request) as ServiceProviderFileRepositoryDeviceUserGetListResponse;
        }

        /// <summary>
        /// Modify a service provider file repository user.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderFileRepositoryDeviceUserModifyRequest(this OcipClient client, ServiceProviderFileRepositoryDeviceUserModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the default profile for a service provider or enterprise.
        /// The response is either a ServiceProviderGetDefaultResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderGetDefaultResponse> ServiceProviderGetDefaultRequest(this OcipClient client, ServiceProviderGetDefaultRequest request)
        {
            return await client.Call(request) as ServiceProviderGetDefaultResponse;
        }

        /// <summary>
        /// Request a list of service providers and/or enterprises in the system.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. Service providers/enterprise
        /// within the administrator's reseller meeting the search criteria are returned.
        /// The response is either a ServiceProviderGetListResponse or an ErrorResponse.
        /// 
        /// The following data elements are only used in AS data mode:
        /// searchCriteriaResellerId
        /// </summary>
        public static async Task<ServiceProviderGetListResponse> ServiceProviderGetListRequest(this OcipClient client, ServiceProviderGetListRequest request)
        {
            return await client.Call(request) as ServiceProviderGetListResponse;
        }

        /// <summary>
        /// Request a list of service providers and/or enterprises in the system.
        /// The response is either a ServiceProviderGetPagedSortedListResponse or an ErrorResponse.
        /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. Service providers/enterprise
        /// within the administrator's reseller meeting the search criteria are returned.
        /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1 by
        /// default, and the responsePageSize will be set to the maximum responsePageSize by default.
        /// If no sortOrder is included, the response is sorted by Service Provider Id ascending by default.
        /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is
        /// included. Then the search criteria are logically ORed together.
        /// </summary>
        public static async Task<ServiceProviderGetPagedSortedListResponse> ServiceProviderGetPagedSortedListRequest(this OcipClient client, ServiceProviderGetPagedSortedListRequest request)
        {
            return await client.Call(request) as ServiceProviderGetPagedSortedListResponse;
        }

        /// <summary>
        /// Get the profile for a service provider or enterprise.
        /// The response is either a ServiceProviderGetResponse22V2 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderGetResponse22V2> ServiceProviderGetRequest22V2(this OcipClient client, ServiceProviderGetRequest22V2 request)
        {
            return await client.Call(request) as ServiceProviderGetResponse22V2;
        }

        /// <summary>
        /// Request to get the Alternate Carrier Selection parameters.
        /// The response is either a ServiceProviderHPBXAlternateCarrierSelectionGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderHPBXAlternateCarrierSelectionGetResponse> ServiceProviderHPBXAlternateCarrierSelectionGetRequest(this OcipClient client, ServiceProviderHPBXAlternateCarrierSelectionGetRequest request)
        {
            return await client.Call(request) as ServiceProviderHPBXAlternateCarrierSelectionGetResponse;
        }

        /// <summary>
        /// Request to modify the Alternate Carrier Selection parameters.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderHPBXAlternateCarrierSelectionModifyRequest(this OcipClient client, ServiceProviderHPBXAlternateCarrierSelectionModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of service provider DNs to the IMRN pool. It is possible to assign either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderIMRNAssignListRequest(this OcipClient client, ServiceProviderIMRNAssignListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Returns a list of dns or dn ranges in a service provider IMRN pool.
        /// The response is either ServiceProviderIMRNGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderIMRNGetListResponse> ServiceProviderIMRNGetListRequest(this OcipClient client, ServiceProviderIMRNGetListRequest request)
        {
            return await client.Call(request) as ServiceProviderIMRNGetListResponse;
        }

        /// <summary>
        /// Unassign a list of service provider DNs from the service provider IMRN pool. The DNs then become available for
        /// assignment to groups. It is possible to delete either: a single DN,
        /// or a list of DNs, or a range of DNs, or any combination thereof.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderIMRNUnassignListRequest(this OcipClient client, ServiceProviderIMRNUnassignListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a language for a service provder.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderLanguageAddRequest(this OcipClient client, ServiceProviderLanguageAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a language from a service provider supported languages.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderLanguageDeleteRequest(this OcipClient client, ServiceProviderLanguageDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the list of languages that a user or admin in a service provider is allowed to use.
        /// The list will either be the system or service provider languages list, depending on the useServiceProviderLanguages flag.
        /// The response is either a ServiceProviderLanguageGetAvailableListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderLanguageGetAvailableListResponse> ServiceProviderLanguageGetAvailableListRequest(this OcipClient client, ServiceProviderLanguageGetAvailableListRequest request)
        {
            return await client.Call(request) as ServiceProviderLanguageGetAvailableListResponse;
        }

        /// <summary>
        /// Request the defined languages for a service provider.
        /// The response is either a ServiceProviderLanguageGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderLanguageGetListResponse> ServiceProviderLanguageGetListRequest(this OcipClient client, ServiceProviderLanguageGetListRequest request)
        {
            return await client.Call(request) as ServiceProviderLanguageGetListResponse;
        }

        /// <summary>
        /// Request to modify a language properties for a service provider/enterprise.
        /// If the becomeDefaultLanguage element is present, the language in this request
        /// Becomes the default language for the service provider/enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderLanguageModifyRequest(this OcipClient client, ServiceProviderLanguageModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the profile for a service provider or enterprise.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The following elements are only used in Amplify data mode and ignored
        /// in AS and XS data mode:
        /// servicePolicy,
        /// callProcessingSliceId,
        /// provisioningSliceId,
        /// subscriberPartition.
        /// When the callProcessingSliceId or provisioningSliceId is set to nillable,
        /// it will be assigned to the default Slice.
        /// Only Provisioning admin and above can change the callProcessingSliceId,
        /// provisioningSliceId, and subscriberPartition.
        /// 
        /// The following elements are only used in Amplify and XS data mode and ignored in AS data mode:
        /// preferredDataCenter.
        /// Only Provisioning admin and above can change the preferredDataCenter.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderModifyRequest(this OcipClient client, ServiceProviderModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of Network Classes of Service to a service provider.
        /// A default Network Class of Service must be specified unless
        /// there is already one assigned to the service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceAssignListRequest21(this OcipClient client, ServiceProviderNetworkClassOfServiceAssignListRequest21 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of Network Classes of Service to all groups with in a
        /// service provider. If it is the first assigned Network Class of Service in
        /// the group, it will be set as the default one.
        /// The Network Classes of Service must be currently
        /// assigned to the service provider. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceAssignListToAllGroupsRequest(this OcipClient client, ServiceProviderNetworkClassOfServiceAssignListToAllGroupsRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Assign a Network Classes of Service to all users with in a
        /// service provider. This will also assign the Network Class of Service
        /// to all the groups in the service provider if it is not assigned yet.
        /// If it is the first assigned Network Class of Service in the group,
        /// it will be set as the default one.
        /// However, the Network Classes of Service must be currently assigned to
        /// the service provider. The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceAssignToAllUsersRequest(this OcipClient client, ServiceProviderNetworkClassOfServiceAssignToAllUsersRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a list of groups within a service provider that have a given
        /// Network Class of Service assigned.
        /// The response is either a ServiceProviderNetworkClassOfServiceGetAssignedGroupListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderNetworkClassOfServiceGetAssignedGroupListResponse> ServiceProviderNetworkClassOfServiceGetAssignedGroupListRequest(this OcipClient client, ServiceProviderNetworkClassOfServiceGetAssignedGroupListRequest request)
        {
            return await client.Call(request) as ServiceProviderNetworkClassOfServiceGetAssignedGroupListResponse;
        }

        /// <summary>
        /// Get a list of Network Classes of Service assigned to a service provider.
        /// The response is either a ServiceProviderNetworkClassOfServiceGetAssignedListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderNetworkClassOfServiceGetAssignedListResponse> ServiceProviderNetworkClassOfServiceGetAssignedListRequest(this OcipClient client, ServiceProviderNetworkClassOfServiceGetAssignedListRequest request)
        {
            return await client.Call(request) as ServiceProviderNetworkClassOfServiceGetAssignedListResponse;
        }

        /// <summary>
        /// Modifies the default Network Classes of Service of a Service Provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceModifyDefaultRequest(this OcipClient client, ServiceProviderNetworkClassOfServiceModifyDefaultRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Unassign a list of Network Classes of Service from a service provider.
        /// If the default Network Class of Service is being unassigned, a new one must be specified unless there are no more
        /// Network Classes of Service assigned to the service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderNetworkClassOfServiceUnassignListRequest21(this OcipClient client, ServiceProviderNetworkClassOfServiceUnassignListRequest21 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a list of the Service Provider Number Portability Query Digit Patterns.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderNumberPortabilityQueryAddListRequest(this OcipClient client, ServiceProviderNumberPortabilityQueryAddListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the Service Provider Number Portability Query Digit Pattern Trigger List information.
        /// The response is either a ServiceProviderNumberPortabilityQueryGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderNumberPortabilityQueryGetResponse> ServiceProviderNumberPortabilityQueryGetRequest(this OcipClient client, ServiceProviderNumberPortabilityQueryGetRequest request)
        {
            return await client.Call(request) as ServiceProviderNumberPortabilityQueryGetResponse;
        }

        /// <summary>
        /// Modify the Service Provider Number Portability Query information.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderNumberPortabilityQueryModifyRequest(this OcipClient client, ServiceProviderNumberPortabilityQueryModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of Office Zones to a service provider.
        /// The Element defaultOfficeZone is required only for the first assignment, for subsequent assignments it is optional.
        /// Office Zones can only be assigned if the Location-Based Calling Restrictions has been authorized to the service provider otherwise the request will fail.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderOfficeZoneAssignListRequest(this OcipClient client, ServiceProviderOfficeZoneAssignListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get a list of groups within a service provider that have a given Office Zone assigned.
        /// The response is either a ServiceProviderOfficeZoneGetAssignedGroupListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderOfficeZoneGetAssignedGroupListResponse> ServiceProviderOfficeZoneGetAssignedGroupListRequest(this OcipClient client, ServiceProviderOfficeZoneGetAssignedGroupListRequest request)
        {
            return await client.Call(request) as ServiceProviderOfficeZoneGetAssignedGroupListResponse;
        }

        /// <summary>
        /// Get a list of Office Zones assigned to a service provider.
        /// The response is either a ServiceProviderOfficeZoneGetAssignedListResponse
        /// or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderOfficeZoneGetAssignedListResponse> ServiceProviderOfficeZoneGetAssignedListRequest(this OcipClient client, ServiceProviderOfficeZoneGetAssignedListRequest request)
        {
            return await client.Call(request) as ServiceProviderOfficeZoneGetAssignedListResponse;
        }

        /// <summary>
        /// Unassign a list of OfficeZones from a service provider.  Note: a new default must be provided if unassigning the current default.
        /// Office Zones can only be unassigned if the Location-Based Calling Restrictions has been authorized to the service provider otherwise the request will fail.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderOfficeZoneUnassignListRequest(this OcipClient client, ServiceProviderOfficeZoneUnassignListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests the service provider's password rules setting applicable to
        /// Administrators (Group and Department) and Users.
        /// The response is either ServiceProviderPasswordRulesGetResponse22 or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderPasswordRulesGetResponse22> ServiceProviderPasswordRulesGetRequest22(this OcipClient client, ServiceProviderPasswordRulesGetRequest22 request)
        {
            return await client.Call(request) as ServiceProviderPasswordRulesGetResponse22;
        }

        /// <summary>
        /// Request to modify the service provider's password rules settings
        /// setting applicable to Administrators (Group and Department) and Users.
        /// 
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// forcePasswordChangeAfterReset
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderPasswordRulesModifyRequest14sp3(this OcipClient client, ServiceProviderPasswordRulesModifyRequest14sp3 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests the service provider's passcode rules setting.
        /// The response is either ServiceProviderPortalPasscodeRulesGetResponse19 or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderPortalPasscodeRulesGetResponse19> ServiceProviderPortalPasscodeRulesGetRequest19(this OcipClient client, ServiceProviderPortalPasscodeRulesGetRequest19 request)
        {
            return await client.Call(request) as ServiceProviderPortalPasscodeRulesGetResponse19;
        }

        /// <summary>
        /// Request to modify the service provider's passcode rules setting.
        /// The response is either SuccessResponse or ErrorResponse.
        /// 
        /// The following elements are only used in AS data mode:
        /// numberOfRepeatedDigits
        /// disallowRepeatedPatterns
        /// disallowContiguousSequences
        /// numberOfAscendingDigits
        /// numberOfDescendingDigits
        /// numberOfPreviousPasscodes
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderPortalPasscodeRulesModifyRequest(this OcipClient client, ServiceProviderPortalPasscodeRulesModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Assign a list of route point external systems to a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRoutePointExternalSystemAssignListRequest(this OcipClient client, ServiceProviderRoutePointExternalSystemAssignListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests a list of groups within a service provider that have a given external system assigned.
        /// It is possible to search by various criteria to restrict the number of rows returned.
        /// Multiple search criteria are logically ANDed together.
        /// The response is either a ServiceProviderRoutePointExternalSystemGetAssignedGroupListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderRoutePointExternalSystemGetAssignedGroupListResponse> ServiceProviderRoutePointExternalSystemGetAssignedGroupListRequest(this OcipClient client, ServiceProviderRoutePointExternalSystemGetAssignedGroupListRequest request)
        {
            return await client.Call(request) as ServiceProviderRoutePointExternalSystemGetAssignedGroupListResponse;
        }

        /// <summary>
        /// Requests the list of all Route Point External Systems assigned to a service provider.
        /// The response is either ServiceProviderRoutePointExternalSystemGetAssignedListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderRoutePointExternalSystemGetAssignedListResponse> ServiceProviderRoutePointExternalSystemGetAssignedListRequest(this OcipClient client, ServiceProviderRoutePointExternalSystemGetAssignedListRequest request)
        {
            return await client.Call(request) as ServiceProviderRoutePointExternalSystemGetAssignedListResponse;
        }

        /// <summary>
        /// Unassign a list of route point external systems from a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRoutePointExternalSystemUnassignListRequest(this OcipClient client, ServiceProviderRoutePointExternalSystemUnassignListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the routing profile for the service provider/enterprise.
        /// The response is either a ServiceProviderRoutingProfileGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderRoutingProfileGetResponse> ServiceProviderRoutingProfileGetRequest(this OcipClient client, ServiceProviderRoutingProfileGetRequest request)
        {
            return await client.Call(request) as ServiceProviderRoutingProfileGetResponse;
        }

        /// <summary>
        /// Requests to modify the routing profile for a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderRoutingProfileModifyRequest(this OcipClient client, ServiceProviderRoutingProfileModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add an event to service provider schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
        /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderScheduleAddEventRequest(this OcipClient client, ServiceProviderScheduleAddEventRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add a service provider schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderScheduleAddRequest(this OcipClient client, ServiceProviderScheduleAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of events from a service provider schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderScheduleDeleteEventListRequest(this OcipClient client, ServiceProviderScheduleDeleteEventListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete a list of service provider schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderScheduleDeleteListRequest(this OcipClient client, ServiceProviderScheduleDeleteListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the list of events of a service provider schedule.
        /// The response is either a ServiceProviderScheduleGetEventDetailListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderScheduleGetEventDetailListResponse> ServiceProviderScheduleGetEventDetailListRequest(this OcipClient client, ServiceProviderScheduleGetEventDetailListRequest request)
        {
            return await client.Call(request) as ServiceProviderScheduleGetEventDetailListResponse;
        }

        /// <summary>
        /// Get the list of events of a service provider schedule.
        /// The response is either a ServiceProviderScheduleGetEventListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderScheduleGetEventListResponse> ServiceProviderScheduleGetEventListRequest(this OcipClient client, ServiceProviderScheduleGetEventListRequest request)
        {
            return await client.Call(request) as ServiceProviderScheduleGetEventListResponse;
        }

        /// <summary>
        /// Get an event from a service provider schedule.
        /// The response is either a ServiceProviderScheduleGetEventResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderScheduleGetEventResponse> ServiceProviderScheduleGetEventRequest(this OcipClient client, ServiceProviderScheduleGetEventRequest request)
        {
            return await client.Call(request) as ServiceProviderScheduleGetEventResponse;
        }

        /// <summary>
        /// Get the list of a service provider schedules. The list can be filtered by schedule type.
        /// The response is either a ServiceProviderScheduleGetListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderScheduleGetListResponse> ServiceProviderScheduleGetListRequest(this OcipClient client, ServiceProviderScheduleGetListRequest request)
        {
            return await client.Call(request) as ServiceProviderScheduleGetListResponse;
        }

        /// <summary>
        /// Modify an event of a service provider schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
        /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderScheduleModifyEventRequest(this OcipClient client, ServiceProviderScheduleModifyEventRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify a service provider schedule.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderScheduleModifyRequest(this OcipClient client, ServiceProviderScheduleModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests the service provider's service authorization status.
        /// The response is either ServiceProviderServiceGetAuthorizationListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderServiceGetAuthorizationListResponse> ServiceProviderServiceGetAuthorizationListRequest(this OcipClient client, ServiceProviderServiceGetAuthorizationListRequest request)
        {
            return await client.Call(request) as ServiceProviderServiceGetAuthorizationListResponse;
        }

        /// <summary>
        /// Requests the service provider's service authorization information for a specific service or service pack.
        /// The response is either ServiceProviderServiceGetAuthorizationResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderServiceGetAuthorizationResponse> ServiceProviderServiceGetAuthorizationRequest(this OcipClient client, ServiceProviderServiceGetAuthorizationRequest request)
        {
            return await client.Call(request) as ServiceProviderServiceGetAuthorizationResponse;
        }

        /// <summary>
        /// Requests the list of all user services assignable to users in the specified service provider.
        /// The response is either ServiceProviderServiceGetUserAssignableListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderServiceGetUserAssignableListResponse> ServiceProviderServiceGetUserAssignableListRequest(this OcipClient client, ServiceProviderServiceGetUserAssignableListRequest request)
        {
            return await client.Call(request) as ServiceProviderServiceGetUserAssignableListResponse;
        }

        /// <summary>
        /// Requests to change the service provider's service authorization status.
        /// The boolean flags are used to authorize or unauthorize services.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServiceModifyAuthorizationListRequest(this OcipClient client, ServiceProviderServiceModifyAuthorizationListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add a service pack to a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackAddRequest(this OcipClient client, ServiceProviderServicePackAddRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to add services to a service pack if the pack has not been authorized to a group.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackAddServiceListRequest(this OcipClient client, ServiceProviderServicePackAddServiceListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to delete a service pack from a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackDeleteRequest(this OcipClient client, ServiceProviderServicePackDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get a service pack details.
        /// The response is either ServiceProviderServicePackGetDetailListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderServicePackGetDetailListResponse> ServiceProviderServicePackGetDetailListRequest(this OcipClient client, ServiceProviderServicePackGetDetailListRequest request)
        {
            return await client.Call(request) as ServiceProviderServicePackGetDetailListResponse;
        }

        /// <summary>
        /// Request to get a list of defined service packs for a service provider.
        /// The response is either ServiceProviderServicePackGetListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderServicePackGetListResponse> ServiceProviderServicePackGetListRequest(this OcipClient client, ServiceProviderServicePackGetListRequest request)
        {
            return await client.Call(request) as ServiceProviderServicePackGetListResponse;
        }

        /// <summary>
        /// Request to get the list of service packs containing a specified service.
        /// The response is either ServiceProviderServicePackGetServiceUsageListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderServicePackGetServiceUsageListResponse> ServiceProviderServicePackGetServiceUsageListRequest(this OcipClient client, ServiceProviderServicePackGetServiceUsageListRequest request)
        {
            return await client.Call(request) as ServiceProviderServicePackGetServiceUsageListResponse;
        }

        /// <summary>
        /// Request to get the service pack utilization for a service provider.
        /// For each service pack, a table of groups utilizing the pack is returned.
        /// The response is either ServiceProviderServicePackGetUtilizationListResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderServicePackGetUtilizationListResponse> ServiceProviderServicePackGetUtilizationListRequest(this OcipClient client, ServiceProviderServicePackGetUtilizationListRequest request)
        {
            return await client.Call(request) as ServiceProviderServicePackGetUtilizationListResponse;
        }

        /// <summary>
        /// Create a service pack migration task.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskAddRequest21(this OcipClient client, ServiceProviderServicePackMigrationTaskAddRequest21 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Makes a copy of one or more existing service pack migration tasks. A copied task
        /// can be edited with other commands and scheduled for future execution. The
        /// name of the new task is chosen automatically. The name will
        /// be "Copy (number) of taskName".
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskCopyRequest(this OcipClient client, ServiceProviderServicePackMigrationTaskCopyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Deletes a service pack migration task. It is not possible to delete a task while it is
        /// currently executing.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskDeleteRequest(this OcipClient client, ServiceProviderServicePackMigrationTaskDeleteRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests a list of groups to migrate.
        /// The response is either ServiceProviderServicePackMigrationTaskGetAvailableGroupListResponse
        /// or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderServicePackMigrationTaskGetAvailableGroupListResponse> ServiceProviderServicePackMigrationTaskGetAvailableGroupListRequest(this OcipClient client, ServiceProviderServicePackMigrationTaskGetAvailableGroupListRequest request)
        {
            return await client.Call(request) as ServiceProviderServicePackMigrationTaskGetAvailableGroupListResponse;
        }

        /// <summary>
        /// Requests a list of all service pack migration tasks for a service provider.
        /// The response is either ServiceProviderServicePackMigrationTaskGetListResponse21
        /// or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderServicePackMigrationTaskGetListResponse21> ServiceProviderServicePackMigrationTaskGetListRequest21(this OcipClient client, ServiceProviderServicePackMigrationTaskGetListRequest21 request)
        {
            return await client.Call(request) as ServiceProviderServicePackMigrationTaskGetListResponse21;
        }

        /// <summary>
        /// Requests the details of a specified service pack migration task.
        /// The response is either ServiceProviderServicePackMigrationTaskGetResponse21
        /// or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderServicePackMigrationTaskGetResponse21> ServiceProviderServicePackMigrationTaskGetRequest21(this OcipClient client, ServiceProviderServicePackMigrationTaskGetRequest21 request)
        {
            return await client.Call(request) as ServiceProviderServicePackMigrationTaskGetResponse21;
        }

        /// <summary>
        /// Replace the list of services and packs to be assigned to users during the service pack migration.
        /// Modification is only allowed prior to task execution.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskModifyAssignmentListRequest(this OcipClient client, ServiceProviderServicePackMigrationTaskModifyAssignmentListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Replace the list of groups to be migrated for a specified service pack migration task.
        /// Modification is only allowed prior to task execution.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskModifyGroupListRequest(this OcipClient client, ServiceProviderServicePackMigrationTaskModifyGroupListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Replace the list of services and packs to be removed from users during the service pack migration.
        /// Modification is only allowed prior to task execution.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskModifyRemovalListRequest(this OcipClient client, ServiceProviderServicePackMigrationTaskModifyRemovalListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the properties of a specified service pack migration task.
        /// Modification is only allowed prior to task execution.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskModifyRequest(this OcipClient client, ServiceProviderServicePackMigrationTaskModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Replace the list of services and packs used to select which users will be migrated.
        /// Modification is only allowed prior to task execution.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskModifyUserSelectionRequest(this OcipClient client, ServiceProviderServicePackMigrationTaskModifyUserSelectionRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Terminates a service pack migration task that is currently executing.
        /// Modification is only allowed prior to task execution.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackMigrationTaskTerminateRequest(this OcipClient client, ServiceProviderServicePackMigrationTaskTerminateRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests to modify a service pack for a service provider.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderServicePackModifyRequest(this OcipClient client, ServiceProviderServicePackModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Lookup if the given number is defined in the specified service in the service provider.
        /// The response is ServiceProviderServicePhoneNumberLookupResponse.
        /// </summary>
        public static async Task<ServiceProviderServicePhoneNumberLookupResponse> ServiceProviderServicePhoneNumberLookupRequest(this OcipClient client, ServiceProviderServicePhoneNumberLookupRequest request)
        {
            return await client.Call(request) as ServiceProviderServicePhoneNumberLookupResponse;
        }

        /// <summary>
        /// Get the session admission control capacity for the service provider.
        /// The response is either a ServiceProviderSessionAdmissionControlGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderSessionAdmissionControlGetResponse> ServiceProviderSessionAdmissionControlGetRequest(this OcipClient client, ServiceProviderSessionAdmissionControlGetRequest request)
        {
            return await client.Call(request) as ServiceProviderSessionAdmissionControlGetResponse;
        }

        /// <summary>
        /// Request to modify session admission control capacity for the service provider.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderSessionAdmissionControlModifyRequest(this OcipClient client, ServiceProviderSessionAdmissionControlModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the Service Provider Session Admission White List information.
        /// The response is either a ServiceProviderSessionAdmissionControlWhiteListGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderSessionAdmissionControlWhiteListGetResponse> ServiceProviderSessionAdmissionControlWhiteListGetRequest(this OcipClient client, ServiceProviderSessionAdmissionControlWhiteListGetRequest request)
        {
            return await client.Call(request) as ServiceProviderSessionAdmissionControlWhiteListGetResponse;
        }

        /// <summary>
        /// Modify the Service Provider Session Admission Control White List information.
        /// The number of digit pattern entries is limited to 100.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderSessionAdmissionControlWhiteListModifyRequest(this OcipClient client, ServiceProviderSessionAdmissionControlWhiteListModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to get the service provider level SIP authentication password rule settings.
        /// The response is either a ServiceProviderSIPAuthenticationPasswordRulesGetResponse or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderSIPAuthenticationPasswordRulesGetResponse> ServiceProviderSIPAuthenticationPasswordRulesGetRequest(this OcipClient client, ServiceProviderSIPAuthenticationPasswordRulesGetRequest request)
        {
            return await client.Call(request) as ServiceProviderSIPAuthenticationPasswordRulesGetResponse;
        }

        /// <summary>
        /// Request to modify the service provider level SIP authentication password rule settings. The useServiceProviderSettings element can only be modified by a system administrator or a provisioning administrator.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderSIPAuthenticationPasswordRulesModifyRequest(this OcipClient client, ServiceProviderSIPAuthenticationPasswordRulesModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
