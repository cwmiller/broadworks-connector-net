using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderCPEConfigSetConfigFileRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _deviceType;

    [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
    public string DeviceType {
        get => _deviceType;
        set {
            DeviceTypeSpecified = true;
            _deviceType = value;
        }
    }

    [XmlIgnore]
    public bool DeviceTypeSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.FileResource _configFile;

    [XmlElement(ElementName = "configFile", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.FileResource ConfigFile {
        get => _configFile;
        set {
            ConfigFileSpecified = true;
            _configFile = value;
        }
    }

    [XmlIgnore]
    public bool ConfigFileSpecified { get; set; }
}
}
