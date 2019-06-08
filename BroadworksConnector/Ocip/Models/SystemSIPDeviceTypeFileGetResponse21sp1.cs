using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeviceTypeFileGetResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _remoteFileFormat;

    [XmlElement(ElementName = "remoteFileFormat", IsNullable = false, Namespace = "")]
    public string RemoteFileFormat {
        get => _remoteFileFormat;
        set {
            RemoteFileFormatSpecified = true;
            _remoteFileFormat = value;
        }
    }

    [XmlIgnore]
    public bool RemoteFileFormatSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.DeviceManagementFileCategory _fileCategory;

    [XmlElement(ElementName = "fileCategory", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DeviceManagementFileCategory FileCategory {
        get => _fileCategory;
        set {
            FileCategorySpecified = true;
            _fileCategory = value;
        }
    }

    [XmlIgnore]
    public bool FileCategorySpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.DeviceManagementFileCustomization _fileCustomization;

    [XmlElement(ElementName = "fileCustomization", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DeviceManagementFileCustomization FileCustomization {
        get => _fileCustomization;
        set {
            FileCustomizationSpecified = true;
            _fileCustomization = value;
        }
    }

    [XmlIgnore]
    public bool FileCustomizationSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.DeviceTypeFileEnhancedConfigurationMode _fileSource;

    [XmlElement(ElementName = "fileSource", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DeviceTypeFileEnhancedConfigurationMode FileSource {
        get => _fileSource;
        set {
            FileSourceSpecified = true;
            _fileSource = value;
        }
    }

    [XmlIgnore]
    public bool FileSourceSpecified { get; set; }
    private string _configurationFileName;

    [XmlElement(ElementName = "configurationFileName", IsNullable = false, Namespace = "")]
    public string ConfigurationFileName {
        get => _configurationFileName;
        set {
            ConfigurationFileNameSpecified = true;
            _configurationFileName = value;
        }
    }

    [XmlIgnore]
    public bool ConfigurationFileNameSpecified { get; set; }
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
    private string _accessUrl;

    [XmlElement(ElementName = "accessUrl", IsNullable = false, Namespace = "")]
    public string AccessUrl {
        get => _accessUrl;
        set {
            AccessUrlSpecified = true;
            _accessUrl = value;
        }
    }

    [XmlIgnore]
    public bool AccessUrlSpecified { get; set; }
    private string _repositoryUrl;

    [XmlElement(ElementName = "repositoryUrl", IsNullable = false, Namespace = "")]
    public string RepositoryUrl {
        get => _repositoryUrl;
        set {
            RepositoryUrlSpecified = true;
            _repositoryUrl = value;
        }
    }

    [XmlIgnore]
    public bool RepositoryUrlSpecified { get; set; }
    private string _templateUrl;

    [XmlElement(ElementName = "templateUrl", IsNullable = false, Namespace = "")]
    public string TemplateUrl {
        get => _templateUrl;
        set {
            TemplateUrlSpecified = true;
            _templateUrl = value;
        }
    }

    [XmlIgnore]
    public bool TemplateUrlSpecified { get; set; }
    private bool _allowHttp;

    [XmlElement(ElementName = "allowHttp", IsNullable = false, Namespace = "")]
    public bool AllowHttp {
        get => _allowHttp;
        set {
            AllowHttpSpecified = true;
            _allowHttp = value;
        }
    }

    [XmlIgnore]
    public bool AllowHttpSpecified { get; set; }
    private bool _allowHttps;

    [XmlElement(ElementName = "allowHttps", IsNullable = false, Namespace = "")]
    public bool AllowHttps {
        get => _allowHttps;
        set {
            AllowHttpsSpecified = true;
            _allowHttps = value;
        }
    }

    [XmlIgnore]
    public bool AllowHttpsSpecified { get; set; }
    private bool _allowTftp;

    [XmlElement(ElementName = "allowTftp", IsNullable = false, Namespace = "")]
    public bool AllowTftp {
        get => _allowTftp;
        set {
            AllowTftpSpecified = true;
            _allowTftp = value;
        }
    }

    [XmlIgnore]
    public bool AllowTftpSpecified { get; set; }
    private bool _enableCaching;

    [XmlElement(ElementName = "enableCaching", IsNullable = false, Namespace = "")]
    public bool EnableCaching {
        get => _enableCaching;
        set {
            EnableCachingSpecified = true;
            _enableCaching = value;
        }
    }

    [XmlIgnore]
    public bool EnableCachingSpecified { get; set; }
    private bool _allowUploadFromDevice;

    [XmlElement(ElementName = "allowUploadFromDevice", IsNullable = false, Namespace = "")]
    public bool AllowUploadFromDevice {
        get => _allowUploadFromDevice;
        set {
            AllowUploadFromDeviceSpecified = true;
            _allowUploadFromDevice = value;
        }
    }

    [XmlIgnore]
    public bool AllowUploadFromDeviceSpecified { get; set; }
    private bool _defaultExtendedFileCaptureMode;

    [XmlElement(ElementName = "defaultExtendedFileCaptureMode", IsNullable = false, Namespace = "")]
    public bool DefaultExtendedFileCaptureMode {
        get => _defaultExtendedFileCaptureMode;
        set {
            DefaultExtendedFileCaptureModeSpecified = true;
            _defaultExtendedFileCaptureMode = value;
        }
    }

    [XmlIgnore]
    public bool DefaultExtendedFileCaptureModeSpecified { get; set; }
}
}
