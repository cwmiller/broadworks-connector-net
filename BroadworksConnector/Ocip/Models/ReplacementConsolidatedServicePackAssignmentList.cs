using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementConsolidatedServicePackAssignmentList 
{
    [XmlElement(ElementName = "servicePack", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ConsolidatedServicePackAssignment> ServicePack { get; set; }
 }
}
