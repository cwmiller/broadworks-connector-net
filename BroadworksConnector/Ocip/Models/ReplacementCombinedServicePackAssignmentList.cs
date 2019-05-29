using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCombinedServicePackAssignmentList 
{
    [XmlElement(ElementName = "servicePack", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CombinedServicePackAssignment> ServicePack { get; set; }
 }
}
