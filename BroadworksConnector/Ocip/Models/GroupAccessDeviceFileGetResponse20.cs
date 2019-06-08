using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAccessDeviceFileGetResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode _fileSource;

    [XmlElement(ElementName = "fileSource", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode FileSource {
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
    private bool _extendedCaptureEnabled;

    [XmlElement(ElementName = "extendedCaptureEnabled", IsNullable = false, Namespace = "")]
    public bool ExtendedCaptureEnabled {
        get => _extendedCaptureEnabled;
        set {
            ExtendedCaptureEnabledSpecified = true;
            _extendedCaptureEnabled = value;
        }
    }

    [XmlIgnore]
    public bool ExtendedCaptureEnabledSpecified { get; set; }
    private string _extendedCaptureURL;

    [XmlElement(ElementName = "extendedCaptureURL", IsNullable = false, Namespace = "")]
    public string ExtendedCaptureURL {
        get => _extendedCaptureURL;
        set {
            ExtendedCaptureURLSpecified = true;
            _extendedCaptureURL = value;
        }
    }

    [XmlIgnore]
    public bool ExtendedCaptureURLSpecified { get; set; }
}
}