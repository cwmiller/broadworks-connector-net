using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSIPDeviceTypeFileGetRequest21sp1.
    /// Take note:
    /// 
    /// 1. accessUrl may have undefined content.
    /// When it is the case, undefined content is put between [].
    /// It may also be set to "Error Access FQDN Not Provisioned" when the access FQDN is not set,
    /// or "Error Access Context Name Not Provisioned" when the context name is not set.
    /// 
    /// 2. repositoryUrl may be set to "DEVICE_CONFIGURATION_FILE_REPOSITORY_MISSING", if there is no file repository defined.
    /// <see cref="SystemSIPDeviceTypeFileGetRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:15977""}]")]
    public class SystemSIPDeviceTypeFileGetResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _remoteFileFormat;

        [XmlElement(ElementName = "remoteFileFormat", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15977")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15977")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15977")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15977")]
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

        private string _configurationFileName;

        [XmlElement(ElementName = "configurationFileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15977")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ConfigurationFileName
        {
            get => _configurationFileName;
            set
            {
                ConfigurationFileNameSpecified = true;
                _configurationFileName = value;
            }
        }

        [XmlIgnore]
        public bool ConfigurationFileNameSpecified { get; set; }

        private bool _useHttpDigestAuthentication;

        [XmlElement(ElementName = "useHttpDigestAuthentication", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15977")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15977")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15977")]
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

        private bool _macInCert;

        [XmlElement(ElementName = "macInCert", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15977")]
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
        public bool MacInCertSpecified { get; set; }

        private bool _macInNonRequestURI;

        [XmlElement(ElementName = "macInNonRequestURI", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15977")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15977")]
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

        private string _accessUrl;

        [XmlElement(ElementName = "accessUrl", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15977")]
        [MinLength(1)]
        [MaxLength(256)]
        public string AccessUrl
        {
            get => _accessUrl;
            set
            {
                AccessUrlSpecified = true;
                _accessUrl = value;
            }
        }

        [XmlIgnore]
        public bool AccessUrlSpecified { get; set; }

        private string _repositoryUrl;

        [XmlElement(ElementName = "repositoryUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15977")]
        [MinLength(1)]
        [MaxLength(256)]
        public string RepositoryUrl
        {
            get => _repositoryUrl;
            set
            {
                RepositoryUrlSpecified = true;
                _repositoryUrl = value;
            }
        }

        [XmlIgnore]
        public bool RepositoryUrlSpecified { get; set; }

        private string _templateUrl;

        [XmlElement(ElementName = "templateUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15977")]
        [MinLength(1)]
        [MaxLength(256)]
        public string TemplateUrl
        {
            get => _templateUrl;
            set
            {
                TemplateUrlSpecified = true;
                _templateUrl = value;
            }
        }

        [XmlIgnore]
        public bool TemplateUrlSpecified { get; set; }

        private bool _allowHttp;

        [XmlElement(ElementName = "allowHttp", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15977")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15977")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15977")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15977")]
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

        private bool _allowUploadFromDevice;

        [XmlElement(ElementName = "allowUploadFromDevice", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15977")]
        public bool AllowUploadFromDevice
        {
            get => _allowUploadFromDevice;
            set
            {
                AllowUploadFromDeviceSpecified = true;
                _allowUploadFromDevice = value;
            }
        }

        [XmlIgnore]
        public bool AllowUploadFromDeviceSpecified { get; set; }

        private bool _defaultExtendedFileCaptureMode;

        [XmlElement(ElementName = "defaultExtendedFileCaptureMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15977")]
        public bool DefaultExtendedFileCaptureMode
        {
            get => _defaultExtendedFileCaptureMode;
            set
            {
                DefaultExtendedFileCaptureModeSpecified = true;
                _defaultExtendedFileCaptureMode = value;
            }
        }

        [XmlIgnore]
        public bool DefaultExtendedFileCaptureModeSpecified { get; set; }

    }
}
