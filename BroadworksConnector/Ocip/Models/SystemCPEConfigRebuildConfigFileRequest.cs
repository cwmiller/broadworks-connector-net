using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCPEConfigRebuildConfigFileRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.CPEDeviceConfigRebuildType _rebuildType;

    [XmlElement(ElementName = "rebuildType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CPEDeviceConfigRebuildType RebuildType {
        get => _rebuildType;
        set {
            RebuildTypeSpecified = true;
            _rebuildType = value;
        }
    }

    [XmlIgnore]
    public bool RebuildTypeSpecified { get; set; }
    private bool _force;

    [XmlElement(ElementName = "force", IsNullable = false, Namespace = "")]
    public bool Force {
        get => _force;
        set {
            ForceSpecified = true;
            _force = value;
        }
    }

    [XmlIgnore]
    public bool ForceSpecified { get; set; }
}
}
