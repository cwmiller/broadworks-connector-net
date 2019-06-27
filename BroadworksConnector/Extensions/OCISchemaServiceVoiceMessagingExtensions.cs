using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaServiceVoiceMessagingExtensions
    {

        /// <summary>
        /// Request to modify the group's voice messaging settings and voice portal branding settings.
        /// If UnassignPhoneNumbersLevel is set to 'Group', the user's primary phone number, fax number and any alternate numbers, will be un-assigned from the group if the command is executed by a service provider administrator or above.
        /// When set to 'Service Provider', they will be un-assigned from the group and service provider if the command is executed by a provisioning administrator or above.
        /// When omitted, the number(s) will be left assigned to the group.
        /// An ErrorResponse will be returned if any number cannot be unassigned because of insufficient privilege.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupVoiceMessagingGroupConsolidatedModifyVoicePortalRequest(this OcipClient client, GroupVoiceMessagingGroupConsolidatedModifyVoicePortalRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests the group's Voice Messaging settings.
        /// The response is either GroupVoiceMessagingGroupGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<GroupVoiceMessagingGroupGetResponse> GroupVoiceMessagingGroupGetRequest(this OcipClient client, GroupVoiceMessagingGroupGetRequest request)
        {
            return await client.Call(request) as GroupVoiceMessagingGroupGetResponse;
        }

        /// <summary>
        /// Get the group's voice portal branding settings.
        /// The response is either a GroupVoiceMessagingGroupGetVoicePortalBrandingResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<GroupVoiceMessagingGroupGetVoicePortalBrandingResponse20> GroupVoiceMessagingGroupGetVoicePortalBrandingRequest20(this OcipClient client, GroupVoiceMessagingGroupGetVoicePortalBrandingRequest20 request)
        {
            return await client.Call(request) as GroupVoiceMessagingGroupGetVoicePortalBrandingResponse20;
        }

        /// <summary>
        /// Request to get the group voice portal information for a voice messaging group.
        /// The response is either GroupVoiceMessagingGroupGetVoicePortalResponse21sp1 or ErrorResponse.
        /// </summary>
        public static async Task<GroupVoiceMessagingGroupGetVoicePortalResponse21sp1> GroupVoiceMessagingGroupGetVoicePortalRequest21sp1(this OcipClient client, GroupVoiceMessagingGroupGetVoicePortalRequest21sp1 request)
        {
            return await client.Call(request) as GroupVoiceMessagingGroupGetVoicePortalResponse21sp1;
        }

        /// <summary>
        /// Request to modify the group's voice messaging settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupVoiceMessagingGroupModifyRequest(this OcipClient client, GroupVoiceMessagingGroupModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the group's voice portal branding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest20(this OcipClient client, GroupVoiceMessagingGroupModifyVoicePortalBrandingRequest20 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the group voice portal information for a voice messaging group.
        /// The following elements are only used in AS data mode:
        /// networkClassOfService
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// expressMode
        /// 
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> GroupVoiceMessagingGroupModifyVoicePortalRequest(this OcipClient client, GroupVoiceMessagingGroupModifyVoicePortalRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the reseller level data associated with Voice Messaging.
        /// The response is either a ResellerVoiceMessagingGroupGetResponse or an
        /// ErrorResponse.
        /// </summary>
        public static async Task<ResellerVoiceMessagingGroupGetResponse> ResellerVoiceMessagingGroupGetRequest(this OcipClient client, ResellerVoiceMessagingGroupGetRequest request)
        {
            return await client.Call(request) as ResellerVoiceMessagingGroupGetResponse;
        }

        /// <summary>
        /// Modify the reseller level data associated with Voice Messaging.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ResellerVoiceMessagingGroupModifyRequest(this OcipClient client, ResellerVoiceMessagingGroupModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests the service provider's or enterprise's voice messaging settings.
        /// The response is either ServiceProviderVoiceMessagingGroupGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderVoiceMessagingGroupGetResponse> ServiceProviderVoiceMessagingGroupGetRequest(this OcipClient client, ServiceProviderVoiceMessagingGroupGetRequest request)
        {
            return await client.Call(request) as ServiceProviderVoiceMessagingGroupGetResponse;
        }

        /// <summary>
        /// Get the service provider's voice portal branding settings.
        /// The response is either a ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingResponse16 or an ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingResponse16> ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingRequest16(this OcipClient client, ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingRequest16 request)
        {
            return await client.Call(request) as ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingResponse16;
        }

        /// <summary>
        /// Requests the service provider's or enterprise's voice portal settings.
        /// The response is either ServiceProviderVoiceMessagingGroupGetVoicePortalResponse or ErrorResponse.
        /// </summary>
        public static async Task<ServiceProviderVoiceMessagingGroupGetVoicePortalResponse> ServiceProviderVoiceMessagingGroupGetVoicePortalRequest(this OcipClient client, ServiceProviderVoiceMessagingGroupGetVoicePortalRequest request)
        {
            return await client.Call(request) as ServiceProviderVoiceMessagingGroupGetVoicePortalResponse;
        }

        /// <summary>
        /// Request to modify a service provider's or enterprise's voice messaging settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderVoiceMessagingGroupModifyRequest(this OcipClient client, ServiceProviderVoiceMessagingGroupModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the service provider's voice portal branding settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderVoiceMessagingGroupModifyVoicePortalBrandingRequest16(this OcipClient client, ServiceProviderVoiceMessagingGroupModifyVoicePortalBrandingRequest16 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to change the service provider's or enterprise's voice portal settings.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> ServiceProviderVoiceMessagingGroupModifyVoicePortalRequest(this OcipClient client, ServiceProviderVoiceMessagingGroupModifyVoicePortalRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Requests system voice mail message summary update parameter settings.
        /// The response is either SystemVoiceMessageSummaryUpdateGetResponse or ErrorResponse.
        /// </summary>
        public static async Task<SystemVoiceMessageSummaryUpdateGetResponse> SystemVoiceMessageSummaryUpdateGetRequest(this OcipClient client, SystemVoiceMessageSummaryUpdateGetRequest request)
        {
            return await client.Call(request) as SystemVoiceMessageSummaryUpdateGetResponse;
        }

        /// <summary>
        /// Modify the system level data associated with Voice Messaging.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemVoiceMessageSummaryUpdateModifyRequest(this OcipClient client, SystemVoiceMessageSummaryUpdateModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request the system level data associated with Voice Messaging.
        /// The response is either a SystemVoiceMessagingGroupGetResponse22V2 or an ErrorResponse.
        /// </summary>
        public static async Task<SystemVoiceMessagingGroupGetResponse22V2> SystemVoiceMessagingGroupGetRequest22V2(this OcipClient client, SystemVoiceMessagingGroupGetRequest22V2 request)
        {
            return await client.Call(request) as SystemVoiceMessagingGroupGetResponse22V2;
        }

        /// <summary>
        /// Requests the system voice portal Menus setting.
        /// The response is either SystemVoiceMessagingGroupGetVoicePortalMenusResponse21 or ErrorResponse.
        /// </summary>
        public static async Task<SystemVoiceMessagingGroupGetVoicePortalMenusResponse21> SystemVoiceMessagingGroupGetVoicePortalMenusRequest21(this OcipClient client, SystemVoiceMessagingGroupGetVoicePortalMenusRequest21 request)
        {
            return await client.Call(request) as SystemVoiceMessagingGroupGetVoicePortalMenusResponse21;
        }

        /// <summary>
        /// Modify the system level data associated with Voice Messaging.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// 
        /// The following elements are only used in AS/Amplify data mode:
        /// realDeleteForImap
        /// useDnInMailBody
        /// useShortSubjectLine
        /// maxMessageLengthMinutes
        /// maxMailboxLengthMinutes
        /// doesMessageAge
        /// holdPeriodDays
        /// mailServerNetAddress
        /// mailServerProtocol
        /// defaultDeliveryFromAddress
        /// defaultNotificationFromAddress
        /// useOutgoingMWIOnSMDI
        /// mwiDelayInSeconds
        /// voicePortalScope
        /// enterpriseVoicePortalLicensed
        /// networkWideMessaging
        /// useExternalRouting
        /// defaultExternalRoutingAddress
        /// vmOnlySystem, element is ignored in Amplify data mode.
        /// clientInitiatedMailServerSessionTimeoutMinutes
        /// recordingAudioFileFormat
        /// allowVoicePortalAccessFromVMDepositMenu
        /// The following elements are only used in AS data mode and ignored in XS data mode:
        /// storageSelection
        /// vmBucketName
        /// </summary>
        public static async Task<SuccessResponse> SystemVoiceMessagingGroupModifyRequest16(this OcipClient client, SystemVoiceMessagingGroupModifyRequest16 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Request to modify the system voice portal menus setting.
        /// The response is either SuccessResponse or ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19(this OcipClient client, SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Add one or more voice mail aliases to a users voice message.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserAddAliasListRequest(this OcipClient client, UserVoiceMessagingUserAddAliasListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Delete one or more voice mail aliases from a users voice message.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserDeleteAliasListRequest(this OcipClient client, UserVoiceMessagingUserDeleteAliasListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Get the user's voice messaging advanced voice management service setting.
        /// The response is either a UserVoiceMessagingUserGetAdvancedVoiceManagementResponse14sp3 or an ErrorResponse.
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetAdvancedVoiceManagementResponse14sp3> UserVoiceMessagingUserGetAdvancedVoiceManagementRequest14sp3(this OcipClient client, UserVoiceMessagingUserGetAdvancedVoiceManagementRequest14sp3 request)
        {
            return await client.Call(request) as UserVoiceMessagingUserGetAdvancedVoiceManagementResponse14sp3;
        }

        /// <summary>
        /// Get the voice mail aliases for a users voice message.
        /// The response is either a UserVoiceMessagingUserGetAliasListResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetAliasListResponse> UserVoiceMessagingUserGetAliasListRequest(this OcipClient client, UserVoiceMessagingUserGetAliasListRequest request)
        {
            return await client.Call(request) as UserVoiceMessagingUserGetAliasListResponse;
        }

        /// <summary>
        /// Get a voice mail distribution list for a users voice message.
        /// The response is either UserVoiceMessagingUserGetDistributionListResponse or ErrorResponse.
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetDistributionListResponse> UserVoiceMessagingUserGetDistributionListRequest(this OcipClient client, UserVoiceMessagingUserGetDistributionListRequest request)
        {
            return await client.Call(request) as UserVoiceMessagingUserGetDistributionListResponse;
        }

        /// <summary>
        /// Get the user's voice messaging greeting information.
        /// The response is either a UserVoiceMessagingUserGetGreetingResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetGreetingResponse20> UserVoiceMessagingUserGetGreetingRequest20(this OcipClient client, UserVoiceMessagingUserGetGreetingRequest20 request)
        {
            return await client.Call(request) as UserVoiceMessagingUserGetGreetingResponse20;
        }

        /// <summary>
        /// Get the user's voice messaging outgoing SMDI message waiting indicator service setting.
        /// The response is either a UserVoiceMessagingUserGetOutgoingSMDIMWIResponse or an ErrorResponse.
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetOutgoingSMDIMWIResponse> UserVoiceMessagingUserGetOutgoingSMDIMWIRequest(this OcipClient client, UserVoiceMessagingUserGetOutgoingSMDIMWIRequest request)
        {
            return await client.Call(request) as UserVoiceMessagingUserGetOutgoingSMDIMWIResponse;
        }

        /// <summary>
        /// Get the user's voice messaging voice management service settings.
        /// The response is either a UserVoiceMessagingUserGetVoiceManagementResponse17 or an ErrorResponse.
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetVoiceManagementResponse17> UserVoiceMessagingUserGetVoiceManagementRequest17(this OcipClient client, UserVoiceMessagingUserGetVoiceManagementRequest17 request)
        {
            return await client.Call(request) as UserVoiceMessagingUserGetVoiceManagementResponse17;
        }

        /// <summary>
        /// Get the user's voice messaging voice portal settings.
        /// The response is either a UserVoiceMessagingUserGetVoicePortalResponse20 or an ErrorResponse.
        /// </summary>
        public static async Task<UserVoiceMessagingUserGetVoicePortalResponse20> UserVoiceMessagingUserGetVoicePortalRequest20(this OcipClient client, UserVoiceMessagingUserGetVoicePortalRequest20 request)
        {
            return await client.Call(request) as UserVoiceMessagingUserGetVoicePortalResponse20;
        }

        /// <summary>
        /// Modify the user's voice messaging advanced voice management service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyAdvancedVoiceManagementRequest(this OcipClient client, UserVoiceMessagingUserModifyAdvancedVoiceManagementRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify a voice mail distribution list for a users voice message.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyDistributionListRequest(this OcipClient client, UserVoiceMessagingUserModifyDistributionListRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's voice messaging greeting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// The following elements are only used in AS data mode:
        /// disableMessageDeposit
        /// disableMessageDepositAction
        /// greetingOnlyForwardDestination
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyGreetingRequest20(this OcipClient client, UserVoiceMessagingUserModifyGreetingRequest20 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's voice messaging outgoing message waiting indicator service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyOutgoingSMDIMWIRequest(this OcipClient client, UserVoiceMessagingUserModifyOutgoingSMDIMWIRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's voice messaging advanced voice management service setting.
        /// Modify a voice mail distribution list for a users voice message.
        /// Modify the user's voice messaging greeting.
        /// Modify the user's voice messaging outgoing message waiting indicator service setting.
        /// Modify the user's voice messaging voice portal settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyRequest(this OcipClient client, UserVoiceMessagingUserModifyRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's voice messaging advanced voice management service setting.
        /// Modify a voice mail distribution list for a users voice message.
        /// Modify the user's voice messaging greeting.
        /// Modify the user's voice messaging outgoing message waiting indicator service setting.
        /// Modify the user's voice messaging voice portal settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyRequest23(this OcipClient client, UserVoiceMessagingUserModifyRequest23 request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's voice messaging voice management service setting.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyVoiceManagementRequest(this OcipClient client, UserVoiceMessagingUserModifyVoiceManagementRequest request)
        {
            return await client.Call(request) as SuccessResponse;
        }

        /// <summary>
        /// Modify the user's voice messaging voice portal settings.
        /// The response is either a SuccessResponse or an ErrorResponse.
        /// Engineering Note: This command is used internally by Call Processing.
        /// </summary>
        public static async Task<SuccessResponse> UserVoiceMessagingUserModifyVoicePortalRequest20(this OcipClient client, UserVoiceMessagingUserModifyVoicePortalRequest20 request)
        {
            return await client.Call(request) as SuccessResponse;
        }


    }
}
