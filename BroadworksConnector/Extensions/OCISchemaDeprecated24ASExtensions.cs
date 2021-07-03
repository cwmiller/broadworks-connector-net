using System;
using System.Threading;
using System.Threading.Tasks;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;

namespace BroadWorksConnector
{
    public static class OCISchemaDeprecated24ASExtensions
    {

        /// <summary>
        /// Requests the service provider's passcode rules setting.
        /// The response is either ServiceProviderPortalPasscodeRulesGetResponse19 or ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderPortalPasscodeRulesGetRequest22 in AS data mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use ServiceProviderPortalPasscodeRulesGetRequest19Async instead.")]
        public static async Task<ServiceProviderPortalPasscodeRulesGetResponse19> ServiceProviderPortalPasscodeRulesGetRequest19(this OcipClient client, ServiceProviderPortalPasscodeRulesGetRequest19 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as ServiceProviderPortalPasscodeRulesGetResponse19;
        }

        /// <summary>
        /// Requests the service provider's passcode rules setting.
        /// The response is either ServiceProviderPortalPasscodeRulesGetResponse19 or ErrorResponse.
        /// 
        /// Replaced by: ServiceProviderPortalPasscodeRulesGetRequest22 in AS data mode.
        /// </summary>
        public static async Task<ServiceProviderPortalPasscodeRulesGetResponse19> ServiceProviderPortalPasscodeRulesGetRequest19Async(this OcipClient client, ServiceProviderPortalPasscodeRulesGetRequest19 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as ServiceProviderPortalPasscodeRulesGetResponse19;
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
        /// Replaced by: SystemSIPDeviceTypeAddRequest23V7 in AS mode.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeAddRequest23V6Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest23V6(this OcipClient client, SystemSIPDeviceTypeAddRequest23V6 request)
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
        /// Replaced by: SystemSIPDeviceTypeAddRequest23V7 in AS mode.
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeAddRequest23V6Async(this OcipClient client, SystemSIPDeviceTypeAddRequest23V6 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }
        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse23V8 or ErrorResponse.
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeGetRequest23V8Async instead.")]
        public static async Task<SystemSIPDeviceTypeGetResponse23V8> SystemSIPDeviceTypeGetRequest23V8(this OcipClient client, SystemSIPDeviceTypeGetRequest23V8 request)
        {
            return await client.CallAsync(request).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse23V8;
        }

        /// <summary>
        /// Request to get a sip device type.
        /// See Also: SystemDeviceTypeGetRequest
        /// The response is either SystemSIPDeviceTypeGetResponse23V8 or ErrorResponse.
        /// </summary>
        public static async Task<SystemSIPDeviceTypeGetResponse23V8> SystemSIPDeviceTypeGetRequest23V8Async(this OcipClient client, SystemSIPDeviceTypeGetRequest23V8 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SystemSIPDeviceTypeGetResponse23V8;
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
        /// verstatInPAIHeader
        /// verstatInFromHeader
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
        /// 
        /// Replaced by: SystemSIPDeviceTypeModifyRequest22V5
        /// </summary>
        [Obsolete("This method is deprecated. Use SystemSIPDeviceTypeModifyRequest22V4Async instead.")]
        public static async Task<SuccessResponse> SystemSIPDeviceTypeModifyRequest22V4(this OcipClient client, SystemSIPDeviceTypeModifyRequest22V4 request)
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
        /// verstatInPAIHeader
        /// verstatInFromHeader
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
        /// 
        /// Replaced by: SystemSIPDeviceTypeModifyRequest22V5
        /// </summary>
        public static async Task<SuccessResponse> SystemSIPDeviceTypeModifyRequest22V4Async(this OcipClient client, SystemSIPDeviceTypeModifyRequest22V4 request, CancellationToken cancellationToken = default)
        {
            return await client.CallAsync(request, cancellationToken).ConfigureAwait(false) as SuccessResponse;
        }

    }
}
