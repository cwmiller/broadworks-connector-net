using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemZoneCallingZonePhysicalLocationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _zoneName;

    [XmlElement(ElementName = "zoneName", IsNullable = false, Namespace = "")]
    public string ZoneName {
        get => _zoneName;
        set {
            ZoneNameSpecified = true;
            _zoneName = value;
        }
    }

    [XmlIgnore]
    public bool ZoneNameSpecified { get; set; }
    private string _physicalLocation;

    [XmlElement(ElementName = "physicalLocation", IsNullable = true, Namespace = "")]
    public string PhysicalLocation {
        get => _physicalLocation;
        set {
            PhysicalLocationSpecified = true;
            _physicalLocation = value;
        }
    }

    [XmlIgnore]
    public bool PhysicalLocationSpecified { get; set; }
}
}
