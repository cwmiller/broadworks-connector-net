using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
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
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSIPDeviceTypeModifyRequest19"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:34540""}]")]
    public class SystemSIPDeviceTypeModifyRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DeviceType
        {
            get => _deviceType;
            set
            {
                DeviceTypeSpecified = true;
                _deviceType = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceTypeSpecified { get; set; }

        protected bool _isObsolete;

        [XmlElement(ElementName = "isObsolete", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool IsObsolete
        {
            get => _isObsolete;
            set
            {
                IsObsoleteSpecified = true;
                _isObsolete = value;
            }
        }

        [XmlIgnore]
        protected bool IsObsoleteSpecified { get; set; }

        protected bool _registrationCapable;

        [XmlElement(ElementName = "registrationCapable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool RegistrationCapable
        {
            get => _registrationCapable;
            set
            {
                RegistrationCapableSpecified = true;
                _registrationCapable = value;
            }
        }

        [XmlIgnore]
        protected bool RegistrationCapableSpecified { get; set; }

        protected bool _rFC3264Hold;

        [XmlElement(ElementName = "RFC3264Hold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool RFC3264Hold
        {
            get => _rFC3264Hold;
            set
            {
                RFC3264HoldSpecified = true;
                _rFC3264Hold = value;
            }
        }

        [XmlIgnore]
        protected bool RFC3264HoldSpecified { get; set; }

        protected bool _isTrusted;

        [XmlElement(ElementName = "isTrusted", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool IsTrusted
        {
            get => _isTrusted;
            set
            {
                IsTrustedSpecified = true;
                _isTrusted = value;
            }
        }

        [XmlIgnore]
        protected bool IsTrustedSpecified { get; set; }

        protected bool _e164Capable;

        [XmlElement(ElementName = "E164Capable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool E164Capable
        {
            get => _e164Capable;
            set
            {
                E164CapableSpecified = true;
                _e164Capable = value;
            }
        }

        [XmlIgnore]
        protected bool E164CapableSpecified { get; set; }

        protected bool _routeAdvance;

        [XmlElement(ElementName = "routeAdvance", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool RouteAdvance
        {
            get => _routeAdvance;
            set
            {
                RouteAdvanceSpecified = true;
                _routeAdvance = value;
            }
        }

        [XmlIgnore]
        protected bool RouteAdvanceSpecified { get; set; }

        protected bool _forwardingOverride;

        [XmlElement(ElementName = "forwardingOverride", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool ForwardingOverride
        {
            get => _forwardingOverride;
            set
            {
                ForwardingOverrideSpecified = true;
                _forwardingOverride = value;
            }
        }

        [XmlIgnore]
        protected bool ForwardingOverrideSpecified { get; set; }

        protected bool _wirelessIntegration;

        [XmlElement(ElementName = "wirelessIntegration", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool WirelessIntegration
        {
            get => _wirelessIntegration;
            set
            {
                WirelessIntegrationSpecified = true;
                _wirelessIntegration = value;
            }
        }

        [XmlIgnore]
        protected bool WirelessIntegrationSpecified { get; set; }

        protected string _webBasedConfigURL;

        [XmlElement(ElementName = "webBasedConfigURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        [MinLength(1)]
        [MaxLength(80)]
        public string WebBasedConfigURL
        {
            get => _webBasedConfigURL;
            set
            {
                WebBasedConfigURLSpecified = true;
                _webBasedConfigURL = value;
            }
        }

        [XmlIgnore]
        protected bool WebBasedConfigURLSpecified { get; set; }

        protected bool _isVideoCapable;

        [XmlElement(ElementName = "isVideoCapable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool IsVideoCapable
        {
            get => _isVideoCapable;
            set
            {
                IsVideoCapableSpecified = true;
                _isVideoCapable = value;
            }
        }

        [XmlIgnore]
        protected bool IsVideoCapableSpecified { get; set; }

        protected bool _pBXIntegration;

        [XmlElement(ElementName = "PBXIntegration", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool PBXIntegration
        {
            get => _pBXIntegration;
            set
            {
                PBXIntegrationSpecified = true;
                _pBXIntegration = value;
            }
        }

        [XmlIgnore]
        protected bool PBXIntegrationSpecified { get; set; }

        protected bool _staticRegistrationCapable;

        [XmlElement(ElementName = "staticRegistrationCapable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool StaticRegistrationCapable
        {
            get => _staticRegistrationCapable;
            set
            {
                StaticRegistrationCapableSpecified = true;
                _staticRegistrationCapable = value;
            }
        }

        [XmlIgnore]
        protected bool StaticRegistrationCapableSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CPEDeviceModifyOptions16sp1 _cpeDeviceOptions;

        [XmlElement(ElementName = "cpeDeviceOptions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public BroadWorksConnector.Ocip.Models.CPEDeviceModifyOptions16sp1 CpeDeviceOptions
        {
            get => _cpeDeviceOptions;
            set
            {
                CpeDeviceOptionsSpecified = true;
                _cpeDeviceOptions = value;
            }
        }

        [XmlIgnore]
        protected bool CpeDeviceOptionsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EarlyMediaSupportType _earlyMediaSupport;

        [XmlElement(ElementName = "earlyMediaSupport", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public BroadWorksConnector.Ocip.Models.EarlyMediaSupportType EarlyMediaSupport
        {
            get => _earlyMediaSupport;
            set
            {
                EarlyMediaSupportSpecified = true;
                _earlyMediaSupport = value;
            }
        }

        [XmlIgnore]
        protected bool EarlyMediaSupportSpecified { get; set; }

        protected bool _authenticateRefer;

        [XmlElement(ElementName = "authenticateRefer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool AuthenticateRefer
        {
            get => _authenticateRefer;
            set
            {
                AuthenticateReferSpecified = true;
                _authenticateRefer = value;
            }
        }

        [XmlIgnore]
        protected bool AuthenticateReferSpecified { get; set; }

        protected bool _autoConfigSoftClient;

        [XmlElement(ElementName = "autoConfigSoftClient", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool AutoConfigSoftClient
        {
            get => _autoConfigSoftClient;
            set
            {
                AutoConfigSoftClientSpecified = true;
                _autoConfigSoftClient = value;
            }
        }

        [XmlIgnore]
        protected bool AutoConfigSoftClientSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AuthenticationMode _authenticationMode;

        [XmlElement(ElementName = "authenticationMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public BroadWorksConnector.Ocip.Models.AuthenticationMode AuthenticationMode
        {
            get => _authenticationMode;
            set
            {
                AuthenticationModeSpecified = true;
                _authenticationMode = value;
            }
        }

        [XmlIgnore]
        protected bool AuthenticationModeSpecified { get; set; }

        protected bool _requiresBroadWorksDigitCollection;

        [XmlElement(ElementName = "requiresBroadWorksDigitCollection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool RequiresBroadWorksDigitCollection
        {
            get => _requiresBroadWorksDigitCollection;
            set
            {
                RequiresBroadWorksDigitCollectionSpecified = true;
                _requiresBroadWorksDigitCollection = value;
            }
        }

        [XmlIgnore]
        protected bool RequiresBroadWorksDigitCollectionSpecified { get; set; }

        protected bool _requiresBroadWorksCallWaitingTone;

        [XmlElement(ElementName = "requiresBroadWorksCallWaitingTone", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool RequiresBroadWorksCallWaitingTone
        {
            get => _requiresBroadWorksCallWaitingTone;
            set
            {
                RequiresBroadWorksCallWaitingToneSpecified = true;
                _requiresBroadWorksCallWaitingTone = value;
            }
        }

        [XmlIgnore]
        protected bool RequiresBroadWorksCallWaitingToneSpecified { get; set; }

        protected bool _requiresMWISubscription;

        [XmlElement(ElementName = "requiresMWISubscription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool RequiresMWISubscription
        {
            get => _requiresMWISubscription;
            set
            {
                RequiresMWISubscriptionSpecified = true;
                _requiresMWISubscription = value;
            }
        }

        [XmlIgnore]
        protected bool RequiresMWISubscriptionSpecified { get; set; }

        protected bool _useHistoryInfoHeaderOnAccessSide;

        [XmlElement(ElementName = "useHistoryInfoHeaderOnAccessSide", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool UseHistoryInfoHeaderOnAccessSide
        {
            get => _useHistoryInfoHeaderOnAccessSide;
            set
            {
                UseHistoryInfoHeaderOnAccessSideSpecified = true;
                _useHistoryInfoHeaderOnAccessSide = value;
            }
        }

        [XmlIgnore]
        protected bool UseHistoryInfoHeaderOnAccessSideSpecified { get; set; }

        protected bool _adviceOfChargeCapable;

        [XmlElement(ElementName = "adviceOfChargeCapable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool AdviceOfChargeCapable
        {
            get => _adviceOfChargeCapable;
            set
            {
                AdviceOfChargeCapableSpecified = true;
                _adviceOfChargeCapable = value;
            }
        }

        [XmlIgnore]
        protected bool AdviceOfChargeCapableSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AccessDeviceResetEvent? _resetEvent;

        [XmlElement(ElementName = "resetEvent", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceResetEvent? ResetEvent
        {
            get => _resetEvent;
            set
            {
                ResetEventSpecified = true;
                _resetEvent = value;
            }
        }

        [XmlIgnore]
        protected bool ResetEventSpecified { get; set; }

        protected bool _supportCallCenterMIMEType;

        [XmlElement(ElementName = "supportCallCenterMIMEType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool SupportCallCenterMIMEType
        {
            get => _supportCallCenterMIMEType;
            set
            {
                SupportCallCenterMIMETypeSpecified = true;
                _supportCallCenterMIMEType = value;
            }
        }

        [XmlIgnore]
        protected bool SupportCallCenterMIMETypeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.TrunkMode _trunkMode;

        [XmlElement(ElementName = "trunkMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public BroadWorksConnector.Ocip.Models.TrunkMode TrunkMode
        {
            get => _trunkMode;
            set
            {
                TrunkModeSpecified = true;
                _trunkMode = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkModeSpecified { get; set; }

        protected bool _addPCalledPartyId;

        [XmlElement(ElementName = "addPCalledPartyId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool AddPCalledPartyId
        {
            get => _addPCalledPartyId;
            set
            {
                AddPCalledPartyIdSpecified = true;
                _addPCalledPartyId = value;
            }
        }

        [XmlIgnore]
        protected bool AddPCalledPartyIdSpecified { get; set; }

        protected bool _supportIdentityInUpdateAndReInvite;

        [XmlElement(ElementName = "supportIdentityInUpdateAndReInvite", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool SupportIdentityInUpdateAndReInvite
        {
            get => _supportIdentityInUpdateAndReInvite;
            set
            {
                SupportIdentityInUpdateAndReInviteSpecified = true;
                _supportIdentityInUpdateAndReInvite = value;
            }
        }

        [XmlIgnore]
        protected bool SupportIdentityInUpdateAndReInviteSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.UnscreenedPresentationIdentityPolicy _unscreenedPresentationIdentityPolicy;

        [XmlElement(ElementName = "unscreenedPresentationIdentityPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public BroadWorksConnector.Ocip.Models.UnscreenedPresentationIdentityPolicy UnscreenedPresentationIdentityPolicy
        {
            get => _unscreenedPresentationIdentityPolicy;
            set
            {
                UnscreenedPresentationIdentityPolicySpecified = true;
                _unscreenedPresentationIdentityPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool UnscreenedPresentationIdentityPolicySpecified { get; set; }

        protected bool _enable3G4GContinuity;

        [XmlElement(ElementName = "enable3G4GContinuity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool Enable3G4GContinuity
        {
            get => _enable3G4GContinuity;
            set
            {
                Enable3G4GContinuitySpecified = true;
                _enable3G4GContinuity = value;
            }
        }

        [XmlIgnore]
        protected bool Enable3G4GContinuitySpecified { get; set; }

        protected bool _supportEmergencyDisconnectControl;

        [XmlElement(ElementName = "supportEmergencyDisconnectControl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34540")]
        public bool SupportEmergencyDisconnectControl
        {
            get => _supportEmergencyDisconnectControl;
            set
            {
                SupportEmergencyDisconnectControlSpecified = true;
                _supportEmergencyDisconnectControl = value;
            }
        }

        [XmlIgnore]
        protected bool SupportEmergencyDisconnectControlSpecified { get; set; }

    }
}
