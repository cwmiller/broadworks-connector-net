using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Device Management System device type options.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:49172""}]")]
    public class DeviceManagementDeviceTypeOptionsRead16
    {

        protected BroadWorksConnector.Ocip.Models.DeviceAccessProtocol16 _deviceAccessProtocol;

        [XmlElement(ElementName = "deviceAccessProtocol", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:49172")]
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

        protected BroadWorksConnector.Ocip.Models.DeviceManagementTagMode _tagMode;

        [XmlElement(ElementName = "tagMode", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:49172")]
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

        [XmlElement(ElementName = "tagSet", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:49172")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:49172")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:49172")]
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

        protected bool _sendEmailUponResetFailure;

        [XmlElement(ElementName = "sendEmailUponResetFailure", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:49172")]
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

        [XmlElement(ElementName = "deviceAccessNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:49172")]
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

        protected int _deviceAccessPort;

        [XmlElement(ElementName = "deviceAccessPort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:49172")]
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

        protected string _deviceAccessContext;

        [XmlElement(ElementName = "deviceAccessContext", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:49172")]
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

        protected string _deviceAccessURI;

        [XmlElement(ElementName = "deviceAccessURI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:49172")]
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

        protected string _defaultDeviceLanguage;

        [XmlElement(ElementName = "defaultDeviceLanguage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:49172")]
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

        [XmlElement(ElementName = "defaultDeviceEncoding", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:49172")]
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

        protected string _accessDeviceCredentials;

        [XmlElement(ElementName = "accessDeviceCredentials", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:49172")]
        [MinLength(1)]
        [MaxLength(161)]
        public string AccessDeviceCredentials
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
        [Group(@"d8f04177e438f303b41c211e518706bf:49172")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:49172")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:49172")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:49172")]
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

        protected string _macFormatInNonRequestURI;

        [XmlElement(ElementName = "macFormatInNonRequestURI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:49172")]
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
