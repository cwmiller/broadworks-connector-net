using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a sip device type.
    /// The response is either SuccessResponse or ErrorResponse.
    /// Replaced By : SystemSIPDeviceTypeAddRequest16
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSIPDeviceTypeAddRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:30228""}]")]
    public class SystemSIPDeviceTypeAddRequest15 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
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

        protected BroadWorksConnector.Ocip.Models.UnboundedPositiveInt _numberOfPorts;

        [XmlElement(ElementName = "numberOfPorts", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
        public BroadWorksConnector.Ocip.Models.UnboundedPositiveInt NumberOfPorts
        {
            get => _numberOfPorts;
            set
            {
                NumberOfPortsSpecified = true;
                _numberOfPorts = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfPortsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SignalingAddressType _profile;

        [XmlElement(ElementName = "profile", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
        public BroadWorksConnector.Ocip.Models.SignalingAddressType Profile
        {
            get => _profile;
            set
            {
                ProfileSpecified = true;
                _profile = value;
            }
        }

        [XmlIgnore]
        protected bool ProfileSpecified { get; set; }

        protected bool _registrationCapable;

        [XmlElement(ElementName = "registrationCapable", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
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

        protected bool _isConferenceDevice;

        [XmlElement(ElementName = "isConferenceDevice", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
        public bool IsConferenceDevice
        {
            get => _isConferenceDevice;
            set
            {
                IsConferenceDeviceSpecified = true;
                _isConferenceDevice = value;
            }
        }

        [XmlIgnore]
        protected bool IsConferenceDeviceSpecified { get; set; }

        protected bool _isMobilityManagerDevice;

        [XmlElement(ElementName = "isMobilityManagerDevice", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
        public bool IsMobilityManagerDevice
        {
            get => _isMobilityManagerDevice;
            set
            {
                IsMobilityManagerDeviceSpecified = true;
                _isMobilityManagerDevice = value;
            }
        }

        [XmlIgnore]
        protected bool IsMobilityManagerDeviceSpecified { get; set; }

        protected bool _isMusicOnHoldDevice;

        [XmlElement(ElementName = "isMusicOnHoldDevice", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
        public bool IsMusicOnHoldDevice
        {
            get => _isMusicOnHoldDevice;
            set
            {
                IsMusicOnHoldDeviceSpecified = true;
                _isMusicOnHoldDevice = value;
            }
        }

        [XmlIgnore]
        protected bool IsMusicOnHoldDeviceSpecified { get; set; }

        protected bool _rFC3264Hold;

        [XmlElement(ElementName = "RFC3264Hold", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
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

        [XmlElement(ElementName = "webBasedConfigURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
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

        protected bool _useBusinessTrunkingContact;

        [XmlElement(ElementName = "useBusinessTrunkingContact", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
        public bool UseBusinessTrunkingContact
        {
            get => _useBusinessTrunkingContact;
            set
            {
                UseBusinessTrunkingContactSpecified = true;
                _useBusinessTrunkingContact = value;
            }
        }

        [XmlIgnore]
        protected bool UseBusinessTrunkingContactSpecified { get; set; }

        protected bool _staticRegistrationCapable;

        [XmlElement(ElementName = "staticRegistrationCapable", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
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

        protected BroadWorksConnector.Ocip.Models.CPEDeviceOptions14sp6 _cpeDeviceOptions;

        [XmlElement(ElementName = "cpeDeviceOptions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
        public BroadWorksConnector.Ocip.Models.CPEDeviceOptions14sp6 CpeDeviceOptions
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
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
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

        protected bool _tdmOverlay;

        [XmlElement(ElementName = "tdmOverlay", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
        public bool TdmOverlay
        {
            get => _tdmOverlay;
            set
            {
                TdmOverlaySpecified = true;
                _tdmOverlay = value;
            }
        }

        [XmlIgnore]
        protected bool TdmOverlaySpecified { get; set; }

        protected bool _requiresBroadWorksCallWaitingTone;

        [XmlElement(ElementName = "requiresBroadWorksCallWaitingTone", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:30228")]
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

    }
}
