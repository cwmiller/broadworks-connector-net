using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAccessDeviceGetEnhancedConfigurationTypeResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _supportsEnhancedConfiguration;

    [XmlElement(ElementName = "supportsEnhancedConfiguration", IsNullable = false, Namespace = "")]
    public bool SupportsEnhancedConfiguration {
        get => _supportsEnhancedConfiguration;
        set {
            SupportsEnhancedConfigurationSpecified = true;
            _supportsEnhancedConfiguration = value;
        }
    }

    [XmlIgnore]
    public bool SupportsEnhancedConfigurationSpecified { get; set; }
    private bool _supportsReset;

    [XmlElement(ElementName = "supportsReset", IsNullable = false, Namespace = "")]
    public bool SupportsReset {
        get => _supportsReset;
        set {
            SupportsResetSpecified = true;
            _supportsReset = value;
        }
    }

    [XmlIgnore]
    public bool SupportsResetSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationType14 _configurationType;

    [XmlElement(ElementName = "configurationType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationType14 ConfigurationType {
        get => _configurationType;
        set {
            ConfigurationTypeSpecified = true;
            _configurationType = value;
        }
    }

    [XmlIgnore]
    public bool ConfigurationTypeSpecified { get; set; }
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
}
}
