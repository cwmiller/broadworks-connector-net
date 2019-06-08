using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeviceTypeFileGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _fileFormat;

    [XmlElement(ElementName = "fileFormat", IsNullable = false, Namespace = "")]
    public string FileFormat {
        get => _fileFormat;
        set {
            FileFormatSpecified = true;
            _fileFormat = value;
        }
    }

    [XmlIgnore]
    public bool FileFormatSpecified { get; set; }
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
    private bool _allowFileCustomization;

    [XmlElement(ElementName = "allowFileCustomization", IsNullable = false, Namespace = "")]
    public bool AllowFileCustomization {
        get => _allowFileCustomization;
        set {
            AllowFileCustomizationSpecified = true;
            _allowFileCustomization = value;
        }
    }

    [XmlIgnore]
    public bool AllowFileCustomizationSpecified { get; set; }
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
}
}
