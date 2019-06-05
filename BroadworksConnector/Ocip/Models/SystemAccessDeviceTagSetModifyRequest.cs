using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccessDeviceTagSetModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _deviceName;

    [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
    public string DeviceName {
        get => _deviceName;
        set {
            DeviceNameSpecified = true;
            _deviceName = value;
        }
    }

    [XmlIgnore]
    public bool DeviceNameSpecified { get; set; }
    private string _tagSetName;

    [XmlElement(ElementName = "tagSetName", IsNullable = true, Namespace = "")]
    public string TagSetName {
        get => _tagSetName;
        set {
            TagSetNameSpecified = true;
            _tagSetName = value;
        }
    }

    [XmlIgnore]
    public bool TagSetNameSpecified { get; set; }
}
}
