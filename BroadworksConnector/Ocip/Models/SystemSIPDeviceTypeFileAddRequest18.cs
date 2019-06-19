using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a sip device type file.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:26584""}]")]
    public class SystemSIPDeviceTypeFileAddRequest18 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26584")]
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
        public bool DeviceTypeSpecified { get; set; }

        private string _fileFormat;

        [XmlElement(ElementName = "fileFormat", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26584")]
        [MinLength(1)]
        [MaxLength(128)]
        public string FileFormat
        {
            get => _fileFormat;
            set
            {
                FileFormatSpecified = true;
                _fileFormat = value;
            }
        }

        [XmlIgnore]
        public bool FileFormatSpecified { get; set; }

        private string _remoteFileFormat;

        [XmlElement(ElementName = "remoteFileFormat", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26584")]
        [MinLength(1)]
        [MaxLength(128)]
        public string RemoteFileFormat
        {
            get => _remoteFileFormat;
            set
            {
                RemoteFileFormatSpecified = true;
                _remoteFileFormat = value;
            }
        }

        [XmlIgnore]
        public bool RemoteFileFormatSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DeviceManagementFileCategory _fileCategory;

        [XmlElement(ElementName = "fileCategory", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26584")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementFileCategory FileCategory
        {
            get => _fileCategory;
            set
            {
                FileCategorySpecified = true;
                _fileCategory = value;
            }
        }

        [XmlIgnore]
        public bool FileCategorySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DeviceManagementFileCustomization _fileCustomization;

        [XmlElement(ElementName = "fileCustomization", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26584")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementFileCustomization FileCustomization
        {
            get => _fileCustomization;
            set
            {
                FileCustomizationSpecified = true;
                _fileCustomization = value;
            }
        }

        [XmlIgnore]
        public bool FileCustomizationSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DeviceTypeFileEnhancedConfigurationMode _fileSource;

        [XmlElement(ElementName = "fileSource", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26584")]
        public BroadWorksConnector.Ocip.Models.DeviceTypeFileEnhancedConfigurationMode FileSource
        {
            get => _fileSource;
            set
            {
                FileSourceSpecified = true;
                _fileSource = value;
            }
        }

        [XmlIgnore]
        public bool FileSourceSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.FileResource _uploadFile;

        [XmlElement(ElementName = "uploadFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26584")]
        public BroadWorksConnector.Ocip.Models.FileResource UploadFile
        {
            get => _uploadFile;
            set
            {
                UploadFileSpecified = true;
                _uploadFile = value;
            }
        }

        [XmlIgnore]
        public bool UploadFileSpecified { get; set; }

        private bool _useHttpDigestAuthentication;

        [XmlElement(ElementName = "useHttpDigestAuthentication", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26584")]
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
        public bool UseHttpDigestAuthenticationSpecified { get; set; }

        private bool _macBasedFileAuthentication;

        [XmlElement(ElementName = "macBasedFileAuthentication", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26584")]
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
        public bool MacBasedFileAuthenticationSpecified { get; set; }

        private bool _userNamePasswordFileAuthentication;

        [XmlElement(ElementName = "userNamePasswordFileAuthentication", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26584")]
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
        public bool UserNamePasswordFileAuthenticationSpecified { get; set; }

        private bool _macInNonRequestURI;

        [XmlElement(ElementName = "macInNonRequestURI", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26584")]
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
        public bool MacInNonRequestURISpecified { get; set; }

        private string _macFormatInNonRequestURI;

        [XmlElement(ElementName = "macFormatInNonRequestURI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26584")]
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
        public bool MacFormatInNonRequestURISpecified { get; set; }

        private bool _allowHttp;

        [XmlElement(ElementName = "allowHttp", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26584")]
        public bool AllowHttp
        {
            get => _allowHttp;
            set
            {
                AllowHttpSpecified = true;
                _allowHttp = value;
            }
        }

        [XmlIgnore]
        public bool AllowHttpSpecified { get; set; }

        private bool _allowHttps;

        [XmlElement(ElementName = "allowHttps", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26584")]
        public bool AllowHttps
        {
            get => _allowHttps;
            set
            {
                AllowHttpsSpecified = true;
                _allowHttps = value;
            }
        }

        [XmlIgnore]
        public bool AllowHttpsSpecified { get; set; }

        private bool _allowTftp;

        [XmlElement(ElementName = "allowTftp", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26584")]
        public bool AllowTftp
        {
            get => _allowTftp;
            set
            {
                AllowTftpSpecified = true;
                _allowTftp = value;
            }
        }

        [XmlIgnore]
        public bool AllowTftpSpecified { get; set; }

        private bool _enableCaching;

        [XmlElement(ElementName = "enableCaching", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26584")]
        public bool EnableCaching
        {
            get => _enableCaching;
            set
            {
                EnableCachingSpecified = true;
                _enableCaching = value;
            }
        }

        [XmlIgnore]
        public bool EnableCachingSpecified { get; set; }

    }
}
