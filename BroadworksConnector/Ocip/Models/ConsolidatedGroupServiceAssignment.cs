using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ConsolidatedGroupServiceAssignment 
{
    [XmlElement(ElementName = "groupServiceName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupService GroupServiceName { get; set; }
    [XmlElement(ElementName = "authorizedQuantity", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnboundedPositiveInt AuthorizedQuantity { get; set; }
 }
}
