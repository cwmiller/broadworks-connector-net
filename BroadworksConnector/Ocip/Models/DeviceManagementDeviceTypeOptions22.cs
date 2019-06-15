using System;
using System.Xml.Serialization;
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
     
    public class DeviceManagementDeviceTypeOptions22 
    {

        
        private BroadWorksConnector.Ocip.Models.DeviceAccessProtocol16 _deviceAccessProtocol;

        [XmlElement(ElementName = "deviceAccessProtocol", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.DeviceAccessProtocol16 DeviceAccessProtocol {
            get => _deviceAccessProtocol;
            set {
                DeviceAccessProtocolSpecified = true;
                _deviceAccessProtocol = value;
            }
        }

        [XmlIgnore]
        public bool DeviceAccessProtocolSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.DeviceManagementTagMode _tagMode;

        [XmlElement(ElementName = "tagMode", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementTagMode TagMode {
            get => _tagMode;
            set {
                TagModeSpecified = true;
                _tagMode = value;
            }
        }

        [XmlIgnore]
        public bool TagModeSpecified { get; set; }
        
        private string _tagSet;

        [XmlElement(ElementName = "tagSet", IsNullable = false, Namespace = "")]
        public string TagSet {
            get => _tagSet;
            set {
                TagSetSpecified = true;
                _tagSet = value;
            }
        }

        [XmlIgnore]
        public bool TagSetSpecified { get; set; }
        
        private bool _allowDeviceProfileCustomTagSet;

        [XmlElement(ElementName = "allowDeviceProfileCustomTagSet", IsNullable = false, Namespace = "")]
        public bool AllowDeviceProfileCustomTagSet {
            get => _allowDeviceProfileCustomTagSet;
            set {
                AllowDeviceProfileCustomTagSetSpecified = true;
                _allowDeviceProfileCustomTagSet = value;
            }
        }

        [XmlIgnore]
        public bool AllowDeviceProfileCustomTagSetSpecified { get; set; }
        
        private bool _allowGroupCustomTagSet;

        [XmlElement(ElementName = "allowGroupCustomTagSet", IsNullable = false, Namespace = "")]
        public bool AllowGroupCustomTagSet {
            get => _allowGroupCustomTagSet;
            set {
                AllowGroupCustomTagSetSpecified = true;
                _allowGroupCustomTagSet = value;
            }
        }

        [XmlIgnore]
        public bool AllowGroupCustomTagSetSpecified { get; set; }
        
        private bool _allowSpCustomTagSet;

        [XmlElement(ElementName = "allowSpCustomTagSet", IsNullable = false, Namespace = "")]
        public bool AllowSpCustomTagSet {
            get => _allowSpCustomTagSet;
            set {
                AllowSpCustomTagSetSpecified = true;
                _allowSpCustomTagSet = value;
            }
        }

        [XmlIgnore]
        public bool AllowSpCustomTagSetSpecified { get; set; }
        
        private bool _sendEmailUponResetFailure;

        [XmlElement(ElementName = "sendEmailUponResetFailure", IsNullable = false, Namespace = "")]
        public bool SendEmailUponResetFailure {
            get => _sendEmailUponResetFailure;
            set {
                SendEmailUponResetFailureSpecified = true;
                _sendEmailUponResetFailure = value;
            }
        }

        [XmlIgnore]
        public bool SendEmailUponResetFailureSpecified { get; set; }
        
        private string _deviceAccessNetAddress;

        [XmlElement(ElementName = "deviceAccessNetAddress", IsNullable = false, Namespace = "")]
        public string DeviceAccessNetAddress {
            get => _deviceAccessNetAddress;
            set {
                DeviceAccessNetAddressSpecified = true;
                _deviceAccessNetAddress = value;
            }
        }

        [XmlIgnore]
        public bool DeviceAccessNetAddressSpecified { get; set; }
        
        private int _deviceAccessPort;

        [XmlElement(ElementName = "deviceAccessPort", IsNullable = false, Namespace = "")]
        public int DeviceAccessPort {
            get => _deviceAccessPort;
            set {
                DeviceAccessPortSpecified = true;
                _deviceAccessPort = value;
            }
        }

        [XmlIgnore]
        public bool DeviceAccessPortSpecified { get; set; }
        
        private string _deviceAccessContext;

        [XmlElement(ElementName = "deviceAccessContext", IsNullable = false, Namespace = "")]
        public string DeviceAccessContext {
            get => _deviceAccessContext;
            set {
                DeviceAccessContextSpecified = true;
                _deviceAccessContext = value;
            }
        }

        [XmlIgnore]
        public bool DeviceAccessContextSpecified { get; set; }
        
        private string _deviceAccessURI;

        [XmlElement(ElementName = "deviceAccessURI", IsNullable = false, Namespace = "")]
        public string DeviceAccessURI {
            get => _deviceAccessURI;
            set {
                DeviceAccessURISpecified = true;
                _deviceAccessURI = value;
            }
        }

        [XmlIgnore]
        public bool DeviceAccessURISpecified { get; set; }
        
        private string _defaultDeviceLanguage;

        [XmlElement(ElementName = "defaultDeviceLanguage", IsNullable = false, Namespace = "")]
        public string DefaultDeviceLanguage {
            get => _defaultDeviceLanguage;
            set {
                DefaultDeviceLanguageSpecified = true;
                _defaultDeviceLanguage = value;
            }
        }

        [XmlIgnore]
        public bool DefaultDeviceLanguageSpecified { get; set; }
        
        private string _defaultDeviceEncoding;

        [XmlElement(ElementName = "defaultDeviceEncoding", IsNullable = false, Namespace = "")]
        public string DefaultDeviceEncoding {
            get => _defaultDeviceEncoding;
            set {
                DefaultDeviceEncodingSpecified = true;
                _defaultDeviceEncoding = value;
            }
        }

        [XmlIgnore]
        public bool DefaultDeviceEncodingSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.DeviceManagementUserNamePassword16 _accessDeviceCredentials;

        [XmlElement(ElementName = "accessDeviceCredentials", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementUserNamePassword16 AccessDeviceCredentials {
            get => _accessDeviceCredentials;
            set {
                AccessDeviceCredentialsSpecified = true;
                _accessDeviceCredentials = value;
            }
        }

        [XmlIgnore]
        public bool AccessDeviceCredentialsSpecified { get; set; }
        
        private bool _useHttpDigestAuthentication;

        [XmlElement(ElementName = "useHttpDigestAuthentication", IsNullable = false, Namespace = "")]
        public bool UseHttpDigestAuthentication {
            get => _useHttpDigestAuthentication;
            set {
                UseHttpDigestAuthenticationSpecified = true;
                _useHttpDigestAuthentication = value;
            }
        }

        [XmlIgnore]
        public bool UseHttpDigestAuthenticationSpecified { get; set; }
        
        private bool _macBasedFileAuthentication;

        [XmlElement(ElementName = "macBasedFileAuthentication", IsNullable = false, Namespace = "")]
        public bool MacBasedFileAuthentication {
            get => _macBasedFileAuthentication;
            set {
                MacBasedFileAuthenticationSpecified = true;
                _macBasedFileAuthentication = value;
            }
        }

        [XmlIgnore]
        public bool MacBasedFileAuthenticationSpecified { get; set; }
        
        private bool _userNamePasswordFileAuthentication;

        [XmlElement(ElementName = "userNamePasswordFileAuthentication", IsNullable = false, Namespace = "")]
        public bool UserNamePasswordFileAuthentication {
            get => _userNamePasswordFileAuthentication;
            set {
                UserNamePasswordFileAuthenticationSpecified = true;
                _userNamePasswordFileAuthentication = value;
            }
        }

        [XmlIgnore]
        public bool UserNamePasswordFileAuthenticationSpecified { get; set; }
        
        private bool _macInNonRequestURI;

        [XmlElement(ElementName = "macInNonRequestURI", IsNullable = false, Namespace = "")]
        public bool MacInNonRequestURI {
            get => _macInNonRequestURI;
            set {
                MacInNonRequestURISpecified = true;
                _macInNonRequestURI = value;
            }
        }

        [XmlIgnore]
        public bool MacInNonRequestURISpecified { get; set; }
        
        private bool _macInCert;

        [XmlElement(ElementName = "macInCert", IsNullable = false, Namespace = "")]
        public bool MacInCert {
            get => _macInCert;
            set {
                MacInCertSpecified = true;
                _macInCert = value;
            }
        }

        [XmlIgnore]
        public bool MacInCertSpecified { get; set; }
        
        private string _macFormatInNonRequestURI;

        [XmlElement(ElementName = "macFormatInNonRequestURI", IsNullable = false, Namespace = "")]
        public string MacFormatInNonRequestURI {
            get => _macFormatInNonRequestURI;
            set {
                MacFormatInNonRequestURISpecified = true;
                _macFormatInNonRequestURI = value;
            }
        }

        [XmlIgnore]
        public bool MacFormatInNonRequestURISpecified { get; set; }
        
    }
}
