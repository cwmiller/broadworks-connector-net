using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Device Management System device type options during a modify request.
    /// 
    /// The following data elements are only used in AS data mode and ignored in XS data mode:
    /// enableDeviceActivation
    /// deviceModel
    /// autoLinkingDeviceType
    /// autoCreateDevicesLevel
    /// isActivationCodeThroughMessagingServer
    /// bearerFileAuthentication
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:2300""}]")]
    public class DeviceManagementDeviceTypeModifyOptions22V3
    {

        protected BroadWorksConnector.Ocip.Models.DeviceAccessProtocol22 _deviceAccessProtocol;

        [XmlElement(ElementName = "deviceAccessProtocol", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        public BroadWorksConnector.Ocip.Models.DeviceAccessProtocol22 DeviceAccessProtocol
        {
            get => _deviceAccessProtocol;
            set
            {
                DeviceAccessProtocolSpecified = true;
                _deviceAccessProtocol = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceAccessProtocolSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DeviceManagementTagMode _tagMode;

        [XmlElement(ElementName = "tagMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementTagMode TagMode
        {
            get => _tagMode;
            set
            {
                TagModeSpecified = true;
                _tagMode = value;
            }
        }

        [XmlIgnore]
        protected bool TagModeSpecified { get; set; }

        protected string _tagSet;

        [XmlElement(ElementName = "tagSet", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        [MinLength(1)]
        [MaxLength(30)]
        public string TagSet
        {
            get => _tagSet;
            set
            {
                TagSetSpecified = true;
                _tagSet = value;
            }
        }

        [XmlIgnore]
        protected bool TagSetSpecified { get; set; }

        protected bool _allowDeviceProfileCustomTagSet;

        [XmlElement(ElementName = "allowDeviceProfileCustomTagSet", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        public bool AllowDeviceProfileCustomTagSet
        {
            get => _allowDeviceProfileCustomTagSet;
            set
            {
                AllowDeviceProfileCustomTagSetSpecified = true;
                _allowDeviceProfileCustomTagSet = value;
            }
        }

        [XmlIgnore]
        protected bool AllowDeviceProfileCustomTagSetSpecified { get; set; }

        protected bool _allowGroupCustomTagSet;

        [XmlElement(ElementName = "allowGroupCustomTagSet", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        public bool AllowGroupCustomTagSet
        {
            get => _allowGroupCustomTagSet;
            set
            {
                AllowGroupCustomTagSetSpecified = true;
                _allowGroupCustomTagSet = value;
            }
        }

        [XmlIgnore]
        protected bool AllowGroupCustomTagSetSpecified { get; set; }

        protected bool _allowSpCustomTagSet;

        [XmlElement(ElementName = "allowSpCustomTagSet", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        public bool AllowSpCustomTagSet
        {
            get => _allowSpCustomTagSet;
            set
            {
                AllowSpCustomTagSetSpecified = true;
                _allowSpCustomTagSet = value;
            }
        }

        [XmlIgnore]
        protected bool AllowSpCustomTagSetSpecified { get; set; }

        protected bool _sendEmailUponResetFailure;

        [XmlElement(ElementName = "sendEmailUponResetFailure", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        public bool SendEmailUponResetFailure
        {
            get => _sendEmailUponResetFailure;
            set
            {
                SendEmailUponResetFailureSpecified = true;
                _sendEmailUponResetFailure = value;
            }
        }

        [XmlIgnore]
        protected bool SendEmailUponResetFailureSpecified { get; set; }

        protected string _deviceAccessNetAddress;

        [XmlElement(ElementName = "deviceAccessNetAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DeviceAccessNetAddress
        {
            get => _deviceAccessNetAddress;
            set
            {
                DeviceAccessNetAddressSpecified = true;
                _deviceAccessNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceAccessNetAddressSpecified { get; set; }

        protected int? _deviceAccessPort;

        [XmlElement(ElementName = "deviceAccessPort", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int? DeviceAccessPort
        {
            get => _deviceAccessPort;
            set
            {
                DeviceAccessPortSpecified = true;
                _deviceAccessPort = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceAccessPortSpecified { get; set; }

        protected string _deviceAccessContext;

        [XmlElement(ElementName = "deviceAccessContext", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DeviceAccessContext
        {
            get => _deviceAccessContext;
            set
            {
                DeviceAccessContextSpecified = true;
                _deviceAccessContext = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceAccessContextSpecified { get; set; }

        protected string _defaultDeviceLanguage;

        [XmlElement(ElementName = "defaultDeviceLanguage", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DefaultDeviceLanguage
        {
            get => _defaultDeviceLanguage;
            set
            {
                DefaultDeviceLanguageSpecified = true;
                _defaultDeviceLanguage = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultDeviceLanguageSpecified { get; set; }

        protected string _defaultDeviceEncoding;

        [XmlElement(ElementName = "defaultDeviceEncoding", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DefaultDeviceEncoding
        {
            get => _defaultDeviceEncoding;
            set
            {
                DefaultDeviceEncodingSpecified = true;
                _defaultDeviceEncoding = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultDeviceEncodingSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DeviceManagementUserNamePassword16 _accessDeviceCredentials;

        [XmlElement(ElementName = "accessDeviceCredentials", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementUserNamePassword16 AccessDeviceCredentials
        {
            get => _accessDeviceCredentials;
            set
            {
                AccessDeviceCredentialsSpecified = true;
                _accessDeviceCredentials = value;
            }
        }

        [XmlIgnore]
        protected bool AccessDeviceCredentialsSpecified { get; set; }

        protected bool _useHttpDigestAuthentication;

        [XmlElement(ElementName = "useHttpDigestAuthentication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        public bool UseHttpDigestAuthentication
        {
            get => _useHttpDigestAuthentication;
            set
            {
                UseHttpDigestAuthenticationSpecified = true;
                _useHttpDigestAuthentication = value;
            }
        }

        [XmlIgnore]
        protected bool UseHttpDigestAuthenticationSpecified { get; set; }

        protected bool _macBasedFileAuthentication;

        [XmlElement(ElementName = "macBasedFileAuthentication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        public bool MacBasedFileAuthentication
        {
            get => _macBasedFileAuthentication;
            set
            {
                MacBasedFileAuthenticationSpecified = true;
                _macBasedFileAuthentication = value;
            }
        }

        [XmlIgnore]
        protected bool MacBasedFileAuthenticationSpecified { get; set; }

        protected bool _userNamePasswordFileAuthentication;

        [XmlElement(ElementName = "userNamePasswordFileAuthentication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        public bool UserNamePasswordFileAuthentication
        {
            get => _userNamePasswordFileAuthentication;
            set
            {
                UserNamePasswordFileAuthenticationSpecified = true;
                _userNamePasswordFileAuthentication = value;
            }
        }

        [XmlIgnore]
        protected bool UserNamePasswordFileAuthenticationSpecified { get; set; }

        protected bool _macInNonRequestURI;

        [XmlElement(ElementName = "macInNonRequestURI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        public bool MacInNonRequestURI
        {
            get => _macInNonRequestURI;
            set
            {
                MacInNonRequestURISpecified = true;
                _macInNonRequestURI = value;
            }
        }

        [XmlIgnore]
        protected bool MacInNonRequestURISpecified { get; set; }

        protected bool _macInCert;

        [XmlElement(ElementName = "macInCert", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        public bool MacInCert
        {
            get => _macInCert;
            set
            {
                MacInCertSpecified = true;
                _macInCert = value;
            }
        }

        [XmlIgnore]
        protected bool MacInCertSpecified { get; set; }

        protected string _macFormatInNonRequestURI;

        [XmlElement(ElementName = "macFormatInNonRequestURI", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        [MinLength(1)]
        [MaxLength(256)]
        public string MacFormatInNonRequestURI
        {
            get => _macFormatInNonRequestURI;
            set
            {
                MacFormatInNonRequestURISpecified = true;
                _macFormatInNonRequestURI = value;
            }
        }

        [XmlIgnore]
        protected bool MacFormatInNonRequestURISpecified { get; set; }

        protected bool _enableDeviceActivation;

        [XmlElement(ElementName = "enableDeviceActivation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        public bool EnableDeviceActivation
        {
            get => _enableDeviceActivation;
            set
            {
                EnableDeviceActivationSpecified = true;
                _enableDeviceActivation = value;
            }
        }

        [XmlIgnore]
        protected bool EnableDeviceActivationSpecified { get; set; }

        protected string _deviceModel;

        [XmlElement(ElementName = "deviceModel", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DeviceModel
        {
            get => _deviceModel;
            set
            {
                DeviceModelSpecified = true;
                _deviceModel = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceModelSpecified { get; set; }

        protected string _autoLinkingDeviceType;

        [XmlElement(ElementName = "autoLinkingDeviceType", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        [MinLength(1)]
        [MaxLength(40)]
        public string AutoLinkingDeviceType
        {
            get => _autoLinkingDeviceType;
            set
            {
                AutoLinkingDeviceTypeSpecified = true;
                _autoLinkingDeviceType = value;
            }
        }

        [XmlIgnore]
        protected bool AutoLinkingDeviceTypeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AutoCreateDevicesLevel _autoCreateDevicesLevel;

        [XmlElement(ElementName = "autoCreateDevicesLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        public BroadWorksConnector.Ocip.Models.AutoCreateDevicesLevel AutoCreateDevicesLevel
        {
            get => _autoCreateDevicesLevel;
            set
            {
                AutoCreateDevicesLevelSpecified = true;
                _autoCreateDevicesLevel = value;
            }
        }

        [XmlIgnore]
        protected bool AutoCreateDevicesLevelSpecified { get; set; }

        protected bool _isActivationCodeThroughMessagingServer;

        [XmlElement(ElementName = "isActivationCodeThroughMessagingServer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        public bool IsActivationCodeThroughMessagingServer
        {
            get => _isActivationCodeThroughMessagingServer;
            set
            {
                IsActivationCodeThroughMessagingServerSpecified = true;
                _isActivationCodeThroughMessagingServer = value;
            }
        }

        [XmlIgnore]
        protected bool IsActivationCodeThroughMessagingServerSpecified { get; set; }

        protected bool _bearerFileAuthentication;

        [XmlElement(ElementName = "bearerFileAuthentication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2300")]
        public bool BearerFileAuthentication
        {
            get => _bearerFileAuthentication;
            set
            {
                BearerFileAuthenticationSpecified = true;
                _bearerFileAuthentication = value;
            }
        }

        [XmlIgnore]
        protected bool BearerFileAuthenticationSpecified { get; set; }

    }
}
