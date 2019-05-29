using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemZoneCallingRestrictionsZoneModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "zoneName", IsNullable = false)]
    public string ZoneName { get; set; }
    [XmlElement(ElementName = "physicalLocation", IsNullable = true)]
    public string PhysicalLocation { get; set; }
 }
}
