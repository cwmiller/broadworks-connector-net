using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCombinedUserServiceAssignmentList 
{
    [XmlElement(ElementName = "serviceName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CombinedUserServiceAssignment> ServiceName { get; set; }
 }
}
