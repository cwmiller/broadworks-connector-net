using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCPEConfigSetConfigFileRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
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
    private string _configFile;

    [XmlElement(ElementName = "configFile", IsNullable = false, Namespace = "")]
    public string ConfigFile {
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
