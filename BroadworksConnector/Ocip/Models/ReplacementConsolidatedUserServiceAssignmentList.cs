using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementConsolidatedUserServiceAssignmentList 
{
    [XmlElement(ElementName = "userServiceServiceName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ConsolidatedUserServiceAssignment> UserServiceServiceName { get; set; }
 }
}
