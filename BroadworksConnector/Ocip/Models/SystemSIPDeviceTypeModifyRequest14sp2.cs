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
    /// Replaced By : SystemSIPDeviceTypeModifyRequest15
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSIPDeviceTypeModifyRequest15"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:34355""}]")]
    public class SystemSIPDeviceTypeModifyRequest14sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34355")]
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

        private bool _isObsolete;

        [XmlElement(ElementName = "isObsolete", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34355")]
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

        private bool _registrationCapable;

        [XmlElement(ElementName = "registrationCapable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34355")]
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

        private bool _rFC3264Hold;

        [XmlElement(ElementName = "RFC3264Hold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34355")]
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

        private bool _isTrusted;

        [XmlElement(ElementName = "isTrusted", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34355")]
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

        private bool _e164Capable;

        [XmlElement(ElementName = "E164Capable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34355")]
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

        private bool _routeAdvance;

        [XmlElement(ElementName = "routeAdvance", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34355")]
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

        private bool _forwardingOverride;

        [XmlElement(ElementName = "forwardingOverride", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34355")]
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

        private bool _wirelessIntegration;

        [XmlElement(ElementName = "wirelessIntegration", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34355")]
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

        private string _webBasedConfigURL;

        [XmlElement(ElementName = "webBasedConfigURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34355")]
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

        private bool _isVideoCapable;

        [XmlElement(ElementName = "isVideoCapable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34355")]
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

        private bool _pBXIntegration;

        [XmlElement(ElementName = "PBXIntegration", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34355")]
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

        private bool _useBusinessTrunkingContact;

        [XmlElement(ElementName = "useBusinessTrunkingContact", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34355")]
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

        private bool _staticRegistrationCapable;

        [XmlElement(ElementName = "staticRegistrationCapable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34355")]
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

        private BroadWorksConnector.Ocip.Models.CPEDeviceModifyOptions _cpeDeviceOptions;

        [XmlElement(ElementName = "cpeDeviceOptions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34355")]
        public BroadWorksConnector.Ocip.Models.CPEDeviceModifyOptions CpeDeviceOptions
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

        private BroadWorksConnector.Ocip.Models.EarlyMediaSupportType _earlyMediaSupport;

        [XmlElement(ElementName = "earlyMediaSupport", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34355")]
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

        private bool _authenticateRefer;

        [XmlElement(ElementName = "authenticateRefer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34355")]
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

        private bool _autoConfigSoftClient;

        [XmlElement(ElementName = "autoConfigSoftClient", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34355")]
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

        private BroadWorksConnector.Ocip.Models.AuthenticationMode _authenticationMode;

        [XmlElement(ElementName = "authenticationMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34355")]
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

        private bool _tdmOverlay;

        [XmlElement(ElementName = "tdmOverlay", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34355")]
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

        private bool _supportsBroadWorksINFOForCallWaiting;

        [XmlElement(ElementName = "supportsBroadWorksINFOForCallWaiting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34355")]
        public bool SupportsBroadWorksINFOForCallWaiting
        {
            get => _supportsBroadWorksINFOForCallWaiting;
            set
            {
                SupportsBroadWorksINFOForCallWaitingSpecified = true;
                _supportsBroadWorksINFOForCallWaiting = value;
            }
        }

        [XmlIgnore]
        protected bool SupportsBroadWorksINFOForCallWaitingSpecified { get; set; }

    }
}
