using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSIPDeviceTypeFileGetRequest22V2.
    /// Take note:
    /// 
    /// 1. accessUrl may have undefined content.
    /// When it is the case, undefined content is put between [].
    /// It may also be set to "Error Access FQDN Not Provisioned" when the access FQDN is not set,
    /// or "Error Access Context Name Not Provisioned" when the context name is not set.
    /// 
    /// 2. repositoryUrl may be set to "DEVICE_CONFIGURATION_FILE_REPOSITORY_MISSING", if there is no file repository defined.
    /// <see cref="SystemSIPDeviceTypeFileGetRequest22V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:17258""}]")]
    public class SystemSIPDeviceTypeFileGetResponse22V2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _remoteFileFormat;

        [XmlElement(ElementName = "remoteFileFormat", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17258")]
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
        protected bool RemoteFileFormatSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DeviceManagementFileCategory22 _fileCategory;

        [XmlElement(ElementName = "fileCategory", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17258")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementFileCategory22 FileCategory
        {
            get => _fileCategory;
            set
            {
                FileCategorySpecified = true;
                _fileCategory = value;
            }
        }

        [XmlIgnore]
        protected bool FileCategorySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DeviceManagementFileCustomization _fileCustomization;

        [XmlElement(ElementName = "fileCustomization", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17258")]
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
        protected bool FileCustomizationSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DeviceTypeFileEnhancedConfigurationMode _fileSource;

        [XmlElement(ElementName = "fileSource", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17258")]
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
        protected bool FileSourceSpecified { get; set; }

        protected string _configurationFileName;

        [XmlElement(ElementName = "configurationFileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17258")]
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
        protected bool ConfigurationFileNameSpecified { get; set; }

        protected bool _useHttpDigestAuthentication;

        [XmlElement(ElementName = "useHttpDigestAuthentication", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17258")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:17258")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:17258")]
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

        protected bool _bearerFileAuthentication;

        [XmlElement(ElementName = "bearerFileAuthentication", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17258")]
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

        protected bool _macInCert;

        [XmlElement(ElementName = "macInCert", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17258")]
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

        protected bool _macInNonRequestURI;

        [XmlElement(ElementName = "macInNonRequestURI", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17258")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:17258")]
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

        protected string _accessUrl;

        [XmlElement(ElementName = "accessUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17258")]
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
        protected bool AccessUrlSpecified { get; set; }

        protected string _repositoryUrl;

        [XmlElement(ElementName = "repositoryUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17258")]
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
        protected bool RepositoryUrlSpecified { get; set; }

        protected string _templateUrl;

        [XmlElement(ElementName = "templateUrl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17258")]
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
        protected bool TemplateUrlSpecified { get; set; }

        protected bool _allowHttp;

        [XmlElement(ElementName = "allowHttp", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17258")]
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
        protected bool AllowHttpSpecified { get; set; }

        protected bool _allowHttps;

        [XmlElement(ElementName = "allowHttps", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17258")]
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
        protected bool AllowHttpsSpecified { get; set; }

        protected bool _allowTftp;

        [XmlElement(ElementName = "allowTftp", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17258")]
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
        protected bool AllowTftpSpecified { get; set; }

        protected bool _enableCaching;

        [XmlElement(ElementName = "enableCaching", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17258")]
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
        protected bool EnableCachingSpecified { get; set; }

        protected bool _allowUploadFromDevice;

        [XmlElement(ElementName = "allowUploadFromDevice", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17258")]
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
        protected bool AllowUploadFromDeviceSpecified { get; set; }

        protected bool _defaultExtendedFileCaptureMode;

        [XmlElement(ElementName = "defaultExtendedFileCaptureMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17258")]
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
        protected bool DefaultExtendedFileCaptureModeSpecified { get; set; }

    }
}
