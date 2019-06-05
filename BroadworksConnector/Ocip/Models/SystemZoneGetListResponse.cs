using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemZoneGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _zoneName;

    [XmlElement(ElementName = "zoneName", IsNullable = false, Namespace = "")]
    public List<string> ZoneName {
        get => _zoneName;
        set {
            ZoneNameSpecified = true;
            _zoneName = value;
        }
    }

    [XmlIgnore]
    public bool ZoneNameSpecified { get; set; }
}
}
