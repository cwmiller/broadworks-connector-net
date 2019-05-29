using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementZoneList 
{
    [XmlElement(ElementName = "zoneName", IsNullable = false)]
    public List<string> ZoneName { get; set; }
 }
}
