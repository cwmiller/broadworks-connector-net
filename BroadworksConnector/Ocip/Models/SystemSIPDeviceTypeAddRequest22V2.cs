using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
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
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="macInNonRequest"/>
        /// <see cref="SystemSIPDeviceTypeAddRequest22V3"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSIPDeviceTypeAddRequest22V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        public string DeviceType {
            get => _deviceType;
            set {
                DeviceTypeSpecified = true;
                _deviceType = value;
            }
        }

        [XmlIgnore]
        public bool DeviceTypeSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.UnboundedPositiveInt _numberOfPorts;

        [XmlElement(ElementName = "numberOfPorts", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.UnboundedPositiveInt NumberOfPorts {
            get => _numberOfPorts;
            set {
                NumberOfPortsSpecified = true;
                _numberOfPorts = value;
            }
        }

        [XmlIgnore]
        public bool NumberOfPortsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SignalingAddressType _profile;

        [XmlElement(ElementName = "profile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SignalingAddressType Profile {
            get => _profile;
            set {
                ProfileSpecified = true;
                _profile = value;
            }
        }

        [XmlIgnore]
        public bool ProfileSpecified { get; set; }
        
        private bool _registrationCapable;

        [XmlElement(ElementName = "registrationCapable", IsNullable = false, Namespace = "")]
        public bool RegistrationCapable {
            get => _registrationCapable;
            set {
                RegistrationCapableSpecified = true;
                _registrationCapable = value;
            }
        }

        [XmlIgnore]
        public bool RegistrationCapableSpecified { get; set; }
        
        private bool _isConferenceDevice;

        [XmlElement(ElementName = "isConferenceDevice", IsNullable = false, Namespace = "")]
        public bool IsConferenceDevice {
            get => _isConferenceDevice;
            set {
                IsConferenceDeviceSpecified = true;
                _isConferenceDevice = value;
            }
        }

        [XmlIgnore]
        public bool IsConferenceDeviceSpecified { get; set; }
        
        private bool _isMobilityManagerDevice;

        [XmlElement(ElementName = "isMobilityManagerDevice", IsNullable = false, Namespace = "")]
        public bool IsMobilityManagerDevice {
            get => _isMobilityManagerDevice;
            set {
                IsMobilityManagerDeviceSpecified = true;
                _isMobilityManagerDevice = value;
            }
        }

        [XmlIgnore]
        public bool IsMobilityManagerDeviceSpecified { get; set; }
        
        private bool _isMusicOnHoldDevice;

        [XmlElement(ElementName = "isMusicOnHoldDevice", IsNullable = false, Namespace = "")]
        public bool IsMusicOnHoldDevice {
            get => _isMusicOnHoldDevice;
            set {
                IsMusicOnHoldDeviceSpecified = true;
                _isMusicOnHoldDevice = value;
            }
        }

        [XmlIgnore]
        public bool IsMusicOnHoldDeviceSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.HoldNormalizationMode _holdNormalization;

        [XmlElement(ElementName = "holdNormalization", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.HoldNormalizationMode HoldNormalization {
            get => _holdNormalization;
            set {
                HoldNormalizationSpecified = true;
                _holdNormalization = value;
            }
        }

        [XmlIgnore]
        public bool HoldNormalizationSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.HoldAnnouncementMethodMode _holdAnnouncementMethod;

        [XmlElement(ElementName = "holdAnnouncementMethod", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.HoldAnnouncementMethodMode HoldAnnouncementMethod {
            get => _holdAnnouncementMethod;
            set {
                HoldAnnouncementMethodSpecified = true;
                _holdAnnouncementMethod = value;
            }
        }

        [XmlIgnore]
        public bool HoldAnnouncementMethodSpecified { get; set; }
        
        private bool _isTrusted;

        [XmlElement(ElementName = "isTrusted", IsNullable = false, Namespace = "")]
        public bool IsTrusted {
            get => _isTrusted;
            set {
                IsTrustedSpecified = true;
                _isTrusted = value;
            }
        }

        [XmlIgnore]
        public bool IsTrustedSpecified { get; set; }
        
        private bool _e164Capable;

        [XmlElement(ElementName = "E164Capable", IsNullable = false, Namespace = "")]
        public bool E164Capable {
            get => _e164Capable;
            set {
                E164CapableSpecified = true;
                _e164Capable = value;
            }
        }

        [XmlIgnore]
        public bool E164CapableSpecified { get; set; }
        
        private bool _routeAdvance;

        [XmlElement(ElementName = "routeAdvance", IsNullable = false, Namespace = "")]
        public bool RouteAdvance {
            get => _routeAdvance;
            set {
                RouteAdvanceSpecified = true;
                _routeAdvance = value;
            }
        }

        [XmlIgnore]
        public bool RouteAdvanceSpecified { get; set; }
        
        private bool _forwardingOverride;

        [XmlElement(ElementName = "forwardingOverride", IsNullable = false, Namespace = "")]
        public bool ForwardingOverride {
            get => _forwardingOverride;
            set {
                ForwardingOverrideSpecified = true;
                _forwardingOverride = value;
            }
        }

        [XmlIgnore]
        public bool ForwardingOverrideSpecified { get; set; }
        
        private bool _wirelessIntegration;

        [XmlElement(ElementName = "wirelessIntegration", IsNullable = false, Namespace = "")]
        public bool WirelessIntegration {
            get => _wirelessIntegration;
            set {
                WirelessIntegrationSpecified = true;
                _wirelessIntegration = value;
            }
        }

        [XmlIgnore]
        public bool WirelessIntegrationSpecified { get; set; }
        
        private string _webBasedConfigURL;

        [XmlElement(ElementName = "webBasedConfigURL", IsNullable = false, Namespace = "")]
        public string WebBasedConfigURL {
            get => _webBasedConfigURL;
            set {
                WebBasedConfigURLSpecified = true;
                _webBasedConfigURL = value;
            }
        }

        [XmlIgnore]
        public bool WebBasedConfigURLSpecified { get; set; }
        
        private bool _isVideoCapable;

        [XmlElement(ElementName = "isVideoCapable", IsNullable = false, Namespace = "")]
        public bool IsVideoCapable {
            get => _isVideoCapable;
            set {
                IsVideoCapableSpecified = true;
                _isVideoCapable = value;
            }
        }

        [XmlIgnore]
        public bool IsVideoCapableSpecified { get; set; }
        
        private bool _pBXIntegration;

        [XmlElement(ElementName = "PBXIntegration", IsNullable = false, Namespace = "")]
        public bool PBXIntegration {
            get => _pBXIntegration;
            set {
                PBXIntegrationSpecified = true;
                _pBXIntegration = value;
            }
        }

        [XmlIgnore]
        public bool PBXIntegrationSpecified { get; set; }
        
        private bool _staticRegistrationCapable;

        [XmlElement(ElementName = "staticRegistrationCapable", IsNullable = false, Namespace = "")]
        public bool StaticRegistrationCapable {
            get => _staticRegistrationCapable;
            set {
                StaticRegistrationCapableSpecified = true;
                _staticRegistrationCapable = value;
            }
        }

        [XmlIgnore]
        public bool StaticRegistrationCapableSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CPEDeviceOptions21sp1 _cpeDeviceOptions;

        [XmlElement(ElementName = "cpeDeviceOptions", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CPEDeviceOptions21sp1 CpeDeviceOptions {
            get => _cpeDeviceOptions;
            set {
                CpeDeviceOptionsSpecified = true;
                _cpeDeviceOptions = value;
            }
        }

        [XmlIgnore]
        public bool CpeDeviceOptionsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.EarlyMediaSupportType _earlyMediaSupport;

        [XmlElement(ElementName = "earlyMediaSupport", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.EarlyMediaSupportType EarlyMediaSupport {
            get => _earlyMediaSupport;
            set {
                EarlyMediaSupportSpecified = true;
                _earlyMediaSupport = value;
            }
        }

        [XmlIgnore]
        public bool EarlyMediaSupportSpecified { get; set; }
        
        private bool _authenticateRefer;

        [XmlElement(ElementName = "authenticateRefer", IsNullable = false, Namespace = "")]
        public bool AuthenticateRefer {
            get => _authenticateRefer;
            set {
                AuthenticateReferSpecified = true;
                _authenticateRefer = value;
            }
        }

        [XmlIgnore]
        public bool AuthenticateReferSpecified { get; set; }
        
        private bool _autoConfigSoftClient;

        [XmlElement(ElementName = "autoConfigSoftClient", IsNullable = false, Namespace = "")]
        public bool AutoConfigSoftClient {
            get => _autoConfigSoftClient;
            set {
                AutoConfigSoftClientSpecified = true;
                _autoConfigSoftClient = value;
            }
        }

        [XmlIgnore]
        public bool AutoConfigSoftClientSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.AuthenticationMode22 _authenticationMode;

        [XmlElement(ElementName = "authenticationMode", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AuthenticationMode22 AuthenticationMode {
            get => _authenticationMode;
            set {
                AuthenticationModeSpecified = true;
                _authenticationMode = value;
            }
        }

        [XmlIgnore]
        public bool AuthenticationModeSpecified { get; set; }
        
        private bool _requiresBroadWorksDigitCollection;

        [XmlElement(ElementName = "requiresBroadWorksDigitCollection", IsNullable = false, Namespace = "")]
        public bool RequiresBroadWorksDigitCollection {
            get => _requiresBroadWorksDigitCollection;
            set {
                RequiresBroadWorksDigitCollectionSpecified = true;
                _requiresBroadWorksDigitCollection = value;
            }
        }

        [XmlIgnore]
        public bool RequiresBroadWorksDigitCollectionSpecified { get; set; }
        
        private bool _requiresBroadWorksCallWaitingTone;

        [XmlElement(ElementName = "requiresBroadWorksCallWaitingTone", IsNullable = false, Namespace = "")]
        public bool RequiresBroadWorksCallWaitingTone {
            get => _requiresBroadWorksCallWaitingTone;
            set {
                RequiresBroadWorksCallWaitingToneSpecified = true;
                _requiresBroadWorksCallWaitingTone = value;
            }
        }

        [XmlIgnore]
        public bool RequiresBroadWorksCallWaitingToneSpecified { get; set; }
        
        private bool _requiresMWISubscription;

        [XmlElement(ElementName = "requiresMWISubscription", IsNullable = false, Namespace = "")]
        public bool RequiresMWISubscription {
            get => _requiresMWISubscription;
            set {
                RequiresMWISubscriptionSpecified = true;
                _requiresMWISubscription = value;
            }
        }

        [XmlIgnore]
        public bool RequiresMWISubscriptionSpecified { get; set; }
        
        private bool _useHistoryInfoHeaderOnAccessSide;

        [XmlElement(ElementName = "useHistoryInfoHeaderOnAccessSide", IsNullable = false, Namespace = "")]
        public bool UseHistoryInfoHeaderOnAccessSide {
            get => _useHistoryInfoHeaderOnAccessSide;
            set {
                UseHistoryInfoHeaderOnAccessSideSpecified = true;
                _useHistoryInfoHeaderOnAccessSide = value;
            }
        }

        [XmlIgnore]
        public bool UseHistoryInfoHeaderOnAccessSideSpecified { get; set; }
        
        private bool _adviceOfChargeCapable;

        [XmlElement(ElementName = "adviceOfChargeCapable", IsNullable = false, Namespace = "")]
        public bool AdviceOfChargeCapable {
            get => _adviceOfChargeCapable;
            set {
                AdviceOfChargeCapableSpecified = true;
                _adviceOfChargeCapable = value;
            }
        }

        [XmlIgnore]
        public bool AdviceOfChargeCapableSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.AccessDeviceResetEvent _resetEvent;

        [XmlElement(ElementName = "resetEvent", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceResetEvent ResetEvent {
            get => _resetEvent;
            set {
                ResetEventSpecified = true;
                _resetEvent = value;
            }
        }

        [XmlIgnore]
        public bool ResetEventSpecified { get; set; }
        
        private bool _supportCallCenterMIMEType;

        [XmlElement(ElementName = "supportCallCenterMIMEType", IsNullable = false, Namespace = "")]
        public bool SupportCallCenterMIMEType {
            get => _supportCallCenterMIMEType;
            set {
                SupportCallCenterMIMETypeSpecified = true;
                _supportCallCenterMIMEType = value;
            }
        }

        [XmlIgnore]
        public bool SupportCallCenterMIMETypeSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.TrunkMode _trunkMode;

        [XmlElement(ElementName = "trunkMode", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.TrunkMode TrunkMode {
            get => _trunkMode;
            set {
                TrunkModeSpecified = true;
                _trunkMode = value;
            }
        }

        [XmlIgnore]
        public bool TrunkModeSpecified { get; set; }
        
        private bool _addPCalledPartyId;

        [XmlElement(ElementName = "addPCalledPartyId", IsNullable = false, Namespace = "")]
        public bool AddPCalledPartyId {
            get => _addPCalledPartyId;
            set {
                AddPCalledPartyIdSpecified = true;
                _addPCalledPartyId = value;
            }
        }

        [XmlIgnore]
        public bool AddPCalledPartyIdSpecified { get; set; }
        
        private bool _supportIdentityInUpdateAndReInvite;

        [XmlElement(ElementName = "supportIdentityInUpdateAndReInvite", IsNullable = false, Namespace = "")]
        public bool SupportIdentityInUpdateAndReInvite {
            get => _supportIdentityInUpdateAndReInvite;
            set {
                SupportIdentityInUpdateAndReInviteSpecified = true;
                _supportIdentityInUpdateAndReInvite = value;
            }
        }

        [XmlIgnore]
        public bool SupportIdentityInUpdateAndReInviteSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.UnscreenedPresentationIdentityPolicy _unscreenedPresentationIdentityPolicy;

        [XmlElement(ElementName = "unscreenedPresentationIdentityPolicy", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.UnscreenedPresentationIdentityPolicy UnscreenedPresentationIdentityPolicy {
            get => _unscreenedPresentationIdentityPolicy;
            set {
                UnscreenedPresentationIdentityPolicySpecified = true;
                _unscreenedPresentationIdentityPolicy = value;
            }
        }

        [XmlIgnore]
        public bool UnscreenedPresentationIdentityPolicySpecified { get; set; }
        
        private bool _enhancedForICS;

        [XmlElement(ElementName = "enhancedForICS", IsNullable = false, Namespace = "")]
        public bool EnhancedForICS {
            get => _enhancedForICS;
            set {
                EnhancedForICSSpecified = true;
                _enhancedForICS = value;
            }
        }

        [XmlIgnore]
        public bool EnhancedForICSSpecified { get; set; }
        
        private bool _supportEmergencyDisconnectControl;

        [XmlElement(ElementName = "supportEmergencyDisconnectControl", IsNullable = false, Namespace = "")]
        public bool SupportEmergencyDisconnectControl {
            get => _supportEmergencyDisconnectControl;
            set {
                SupportEmergencyDisconnectControlSpecified = true;
                _supportEmergencyDisconnectControl = value;
            }
        }

        [XmlIgnore]
        public bool SupportEmergencyDisconnectControlSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.DeviceTypeConfigurationOptionType _deviceTypeConfigurationOption;

        [XmlElement(ElementName = "deviceTypeConfigurationOption", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.DeviceTypeConfigurationOptionType DeviceTypeConfigurationOption {
            get => _deviceTypeConfigurationOption;
            set {
                DeviceTypeConfigurationOptionSpecified = true;
                _deviceTypeConfigurationOption = value;
            }
        }

        [XmlIgnore]
        public bool DeviceTypeConfigurationOptionSpecified { get; set; }
        
        private bool _supportRFC3398;

        [XmlElement(ElementName = "supportRFC3398", IsNullable = false, Namespace = "")]
        public bool SupportRFC3398 {
            get => _supportRFC3398;
            set {
                SupportRFC3398Specified = true;
                _supportRFC3398 = value;
            }
        }

        [XmlIgnore]
        public bool SupportRFC3398Specified { get; set; }
        
        private bool _staticLineOrdering;

        [XmlElement(ElementName = "staticLineOrdering", IsNullable = false, Namespace = "")]
        public bool StaticLineOrdering {
            get => _staticLineOrdering;
            set {
                StaticLineOrderingSpecified = true;
                _staticLineOrdering = value;
            }
        }

        [XmlIgnore]
        public bool StaticLineOrderingSpecified { get; set; }
        
        private bool _supportClientSessionInfo;

        [XmlElement(ElementName = "supportClientSessionInfo", IsNullable = false, Namespace = "")]
        public bool SupportClientSessionInfo {
            get => _supportClientSessionInfo;
            set {
                SupportClientSessionInfoSpecified = true;
                _supportClientSessionInfo = value;
            }
        }

        [XmlIgnore]
        public bool SupportClientSessionInfoSpecified { get; set; }
        
        private bool _supportCallInfoConferenceSubscriptionURI;

        [XmlElement(ElementName = "supportCallInfoConferenceSubscriptionURI", IsNullable = false, Namespace = "")]
        public bool SupportCallInfoConferenceSubscriptionURI {
            get => _supportCallInfoConferenceSubscriptionURI;
            set {
                SupportCallInfoConferenceSubscriptionURISpecified = true;
                _supportCallInfoConferenceSubscriptionURI = value;
            }
        }

        [XmlIgnore]
        public bool SupportCallInfoConferenceSubscriptionURISpecified { get; set; }
        
        private bool _supportRemotePartyInfo;

        [XmlElement(ElementName = "supportRemotePartyInfo", IsNullable = false, Namespace = "")]
        public bool SupportRemotePartyInfo {
            get => _supportRemotePartyInfo;
            set {
                SupportRemotePartyInfoSpecified = true;
                _supportRemotePartyInfo = value;
            }
        }

        [XmlIgnore]
        public bool SupportRemotePartyInfoSpecified { get; set; }
        
        private bool _supportVisualDeviceManagement;

        [XmlElement(ElementName = "supportVisualDeviceManagement", IsNullable = false, Namespace = "")]
        public bool SupportVisualDeviceManagement {
            get => _supportVisualDeviceManagement;
            set {
                SupportVisualDeviceManagementSpecified = true;
                _supportVisualDeviceManagement = value;
            }
        }

        [XmlIgnore]
        public bool SupportVisualDeviceManagementSpecified { get; set; }
        
        private bool _bypassMediaTreatment;

        [XmlElement(ElementName = "bypassMediaTreatment", IsNullable = false, Namespace = "")]
        public bool BypassMediaTreatment {
            get => _bypassMediaTreatment;
            set {
                BypassMediaTreatmentSpecified = true;
                _bypassMediaTreatment = value;
            }
        }

        [XmlIgnore]
        public bool BypassMediaTreatmentSpecified { get; set; }
        
        private bool _supports3G4GContinuity;

        [XmlElement(ElementName = "supports3G4GContinuity", IsNullable = false, Namespace = "")]
        public bool Supports3G4GContinuity {
            get => _supports3G4GContinuity;
            set {
                Supports3G4GContinuitySpecified = true;
                _supports3G4GContinuity = value;
            }
        }

        [XmlIgnore]
        public bool Supports3G4GContinuitySpecified { get; set; }
        
        private bool _publishesOwnPresence;

        [XmlElement(ElementName = "publishesOwnPresence", IsNullable = false, Namespace = "")]
        public bool PublishesOwnPresence {
            get => _publishesOwnPresence;
            set {
                PublishesOwnPresenceSpecified = true;
                _publishesOwnPresence = value;
            }
        }

        [XmlIgnore]
        public bool PublishesOwnPresenceSpecified { get; set; }
        
        private bool _supportCauseParameter;

        [XmlElement(ElementName = "supportCauseParameter", IsNullable = false, Namespace = "")]
        public bool SupportCauseParameter {
            get => _supportCauseParameter;
            set {
                SupportCauseParameterSpecified = true;
                _supportCauseParameter = value;
            }
        }

        [XmlIgnore]
        public bool SupportCauseParameterSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.LocationNetworkType _locationNetwork;

        [XmlElement(ElementName = "locationNetwork", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.LocationNetworkType LocationNetwork {
            get => _locationNetwork;
            set {
                LocationNetworkSpecified = true;
                _locationNetwork = value;
            }
        }

        [XmlIgnore]
        public bool LocationNetworkSpecified { get; set; }
        
        private bool _allowTerminationBasedOnICSI;

        [XmlElement(ElementName = "allowTerminationBasedOnICSI", IsNullable = false, Namespace = "")]
        public bool AllowTerminationBasedOnICSI {
            get => _allowTerminationBasedOnICSI;
            set {
                AllowTerminationBasedOnICSISpecified = true;
                _allowTerminationBasedOnICSI = value;
            }
        }

        [XmlIgnore]
        public bool AllowTerminationBasedOnICSISpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.RoamingMode _roamingMode;

        [XmlElement(ElementName = "roamingMode", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.RoamingMode RoamingMode {
            get => _roamingMode;
            set {
                RoamingModeSpecified = true;
                _roamingMode = value;
            }
        }

        [XmlIgnore]
        public bool RoamingModeSpecified { get; set; }
        
        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        public string ResellerId {
            get => _resellerId;
            set {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        public bool ResellerIdSpecified { get; set; }
        
    }
}
