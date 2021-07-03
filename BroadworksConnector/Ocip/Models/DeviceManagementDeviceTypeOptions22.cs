using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Device Management System device type options.
    /// 
    /// Note: For the elements listed below, when device configuration is set to deviceManagement, those elements apply to the creation of the Polycom Phone Services directory file only.
    /// For all other files, they are not used. Those elements are instead configured on a per-file basis at the Device Type File level.
    /// When device configuration is set to legacy, those elements apply to all configuration files.
    /// 
    /// useHttpDigestAuthentication
    /// macBasedFileAuthentication
    /// userNamePasswordFileAuthentication
    /// macInNonRequestURI
    /// macInCert
    /// macFormatInNonRequestURI
    /// <see cref="macInNonRequest"/>
    /// <see cref="macFormatInNonRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:48228""}]")]
    public class DeviceManagementDeviceTypeOptions22
    {

        private BroadWorksConnector.Ocip.Models.DeviceAccessProtocol16 _deviceAccessProtocol;

        [XmlElement(ElementName = "deviceAccessProtocol", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48228")]
        public BroadWorksConnector.Ocip.Models.DeviceAccessProtocol16 DeviceAccessProtocol
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

        private BroadWorksConnector.Ocip.Models.DeviceManagementTagMode _tagMode;

        [XmlElement(ElementName = "tagMode", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48228")]
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

        private string _tagSet;

        [XmlElement(ElementName = "tagSet", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48228")]
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

        private bool _allowDeviceProfileCustomTagSet;

        [XmlElement(ElementName = "allowDeviceProfileCustomTagSet", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48228")]
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

        private bool _allowGroupCustomTagSet;

        [XmlElement(ElementName = "allowGroupCustomTagSet", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48228")]
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

        private bool _allowSpCustomTagSet;

        [XmlElement(ElementName = "allowSpCustomTagSet", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48228")]
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

        private bool _sendEmailUponResetFailure;

        [XmlElement(ElementName = "sendEmailUponResetFailure", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48228")]
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

        private string _deviceAccessNetAddress;

        [XmlElement(ElementName = "deviceAccessNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48228")]
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

        private int _deviceAccessPort;

        [XmlElement(ElementName = "deviceAccessPort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48228")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int DeviceAccessPort
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

        private string _deviceAccessContext;

        [XmlElement(ElementName = "deviceAccessContext", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48228")]
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

        private string _deviceAccessURI;

        [XmlElement(ElementName = "deviceAccessURI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48228")]
        [MinLength(1)]
        [MaxLength(256)]
        public string DeviceAccessURI
        {
            get => _deviceAccessURI;
            set
            {
                DeviceAccessURISpecified = true;
                _deviceAccessURI = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceAccessURISpecified { get; set; }

        private string _defaultDeviceLanguage;

        [XmlElement(ElementName = "defaultDeviceLanguage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48228")]
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

        private string _defaultDeviceEncoding;

        [XmlElement(ElementName = "defaultDeviceEncoding", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48228")]
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

        private BroadWorksConnector.Ocip.Models.DeviceManagementUserNamePassword16 _accessDeviceCredentials;

        [XmlElement(ElementName = "accessDeviceCredentials", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48228")]
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

        private bool _useHttpDigestAuthentication;

        [XmlElement(ElementName = "useHttpDigestAuthentication", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48228")]
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

        private bool _macBasedFileAuthentication;

        [XmlElement(ElementName = "macBasedFileAuthentication", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48228")]
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

        private bool _userNamePasswordFileAuthentication;

        [XmlElement(ElementName = "userNamePasswordFileAuthentication", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48228")]
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

        private bool _macInNonRequestURI;

        [XmlElement(ElementName = "macInNonRequestURI", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48228")]
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

        private bool _macInCert;

        [XmlElement(ElementName = "macInCert", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48228")]
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

        private string _macFormatInNonRequestURI;

        [XmlElement(ElementName = "macFormatInNonRequestURI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48228")]
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

    }
}
