using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SimultaneousRingReplacementNumberList 
{
    [XmlElement(ElementName = "simultaneousRingNumber", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SimultaneousRingNumber> SimultaneousRingNumber { get; set; }
 }
}
