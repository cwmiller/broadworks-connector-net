using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemZoneLocationBasedPhysicalLocationAddListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "zoneName", IsNullable = false)]
    public string ZoneName { get; set; }
    [XmlElement(ElementName = "physicalLocation", IsNullable = false)]
    public List<string> PhysicalLocation { get; set; }
 }
}
