using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Device Management System device type options during a modify request.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:48978""}]")]
    public class DeviceManagementDeviceTypeModifyOptions16
    {

        protected BroadWorksConnector.Ocip.Models.DeviceAccessProtocol16? _deviceAccessProtocol;

        [XmlElement(ElementName = "deviceAccessProtocol", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48978")]
        public BroadWorksConnector.Ocip.Models.DeviceAccessProtocol16? DeviceAccessProtocol
        {
            get => _deviceAccessProtocol;
            set
            {
                DeviceAccessProtocolSpecified = (value != null);
                _deviceAccessProtocol = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceAccessProtocolSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DeviceManagementTagMode? _tagMode;

        [XmlElement(ElementName = "tagMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48978")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementTagMode? TagMode
        {
            get => _tagMode;
            set
            {
                TagModeSpecified = (value != null);
                _tagMode = value;
            }
        }

        [XmlIgnore]
        protected bool TagModeSpecified { get; set; }

        protected string _tagSet;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "tagSet", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48978")]
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

        protected bool? _allowDeviceProfileCustomTagSet;

        [XmlElement(ElementName = "allowDeviceProfileCustomTagSet", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48978")]
        public bool? AllowDeviceProfileCustomTagSet
        {
            get => _allowDeviceProfileCustomTagSet;
            set
            {
                AllowDeviceProfileCustomTagSetSpecified = (value != null);
                _allowDeviceProfileCustomTagSet = value;
            }
        }

        [XmlIgnore]
        protected bool AllowDeviceProfileCustomTagSetSpecified { get; set; }

        protected bool? _allowGroupCustomTagSet;

        [XmlElement(ElementName = "allowGroupCustomTagSet", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48978")]
        public bool? AllowGroupCustomTagSet
        {
            get => _allowGroupCustomTagSet;
            set
            {
                AllowGroupCustomTagSetSpecified = (value != null);
                _allowGroupCustomTagSet = value;
            }
        }

        [XmlIgnore]
        protected bool AllowGroupCustomTagSetSpecified { get; set; }

        protected bool? _allowSpCustomTagSet;

        [XmlElement(ElementName = "allowSpCustomTagSet", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48978")]
        public bool? AllowSpCustomTagSet
        {
            get => _allowSpCustomTagSet;
            set
            {
                AllowSpCustomTagSetSpecified = (value != null);
                _allowSpCustomTagSet = value;
            }
        }

        [XmlIgnore]
        protected bool AllowSpCustomTagSetSpecified { get; set; }

        protected bool? _sendEmailUponResetFailure;

        [XmlElement(ElementName = "sendEmailUponResetFailure", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48978")]
        public bool? SendEmailUponResetFailure
        {
            get => _sendEmailUponResetFailure;
            set
            {
                SendEmailUponResetFailureSpecified = (value != null);
                _sendEmailUponResetFailure = value;
            }
        }

        [XmlIgnore]
        protected bool SendEmailUponResetFailureSpecified { get; set; }

        protected string _deviceAccessNetAddress;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "deviceAccessNetAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48978")]
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

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "deviceAccessPort", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48978")]
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

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "deviceAccessContext", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48978")]
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

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "defaultDeviceLanguage", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48978")]
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

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "defaultDeviceEncoding", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48978")]
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

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "accessDeviceCredentials", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48978")]
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

        protected bool? _useHttpDigestAuthentication;

        [XmlElement(ElementName = "useHttpDigestAuthentication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48978")]
        public bool? UseHttpDigestAuthentication
        {
            get => _useHttpDigestAuthentication;
            set
            {
                UseHttpDigestAuthenticationSpecified = (value != null);
                _useHttpDigestAuthentication = value;
            }
        }

        [XmlIgnore]
        protected bool UseHttpDigestAuthenticationSpecified { get; set; }

        protected bool? _macBasedFileAuthentication;

        [XmlElement(ElementName = "macBasedFileAuthentication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48978")]
        public bool? MacBasedFileAuthentication
        {
            get => _macBasedFileAuthentication;
            set
            {
                MacBasedFileAuthenticationSpecified = (value != null);
                _macBasedFileAuthentication = value;
            }
        }

        [XmlIgnore]
        protected bool MacBasedFileAuthenticationSpecified { get; set; }

        protected bool? _userNamePasswordFileAuthentication;

        [XmlElement(ElementName = "userNamePasswordFileAuthentication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48978")]
        public bool? UserNamePasswordFileAuthentication
        {
            get => _userNamePasswordFileAuthentication;
            set
            {
                UserNamePasswordFileAuthenticationSpecified = (value != null);
                _userNamePasswordFileAuthentication = value;
            }
        }

        [XmlIgnore]
        protected bool UserNamePasswordFileAuthenticationSpecified { get; set; }

        protected bool? _macInNonRequestURI;

        [XmlElement(ElementName = "macInNonRequestURI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48978")]
        public bool? MacInNonRequestURI
        {
            get => _macInNonRequestURI;
            set
            {
                MacInNonRequestURISpecified = (value != null);
                _macInNonRequestURI = value;
            }
        }

        [XmlIgnore]
        protected bool MacInNonRequestURISpecified { get; set; }

        protected bool? _macInCert;

        [XmlElement(ElementName = "macInCert", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48978")]
        public bool? MacInCert
        {
            get => _macInCert;
            set
            {
                MacInCertSpecified = (value != null);
                _macInCert = value;
            }
        }

        [XmlIgnore]
        protected bool MacInCertSpecified { get; set; }

        protected string _macFormatInNonRequestURI;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "macFormatInNonRequestURI", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:48978")]
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
