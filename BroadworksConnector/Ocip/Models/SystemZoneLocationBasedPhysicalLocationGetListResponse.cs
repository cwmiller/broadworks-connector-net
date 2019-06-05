using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemZoneLocationBasedPhysicalLocationGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _physicalLocation;

    [XmlElement(ElementName = "physicalLocation", IsNullable = false, Namespace = "")]
    public List<string> PhysicalLocation {
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
