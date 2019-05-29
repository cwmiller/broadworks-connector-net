using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ConsolidatedUserServiceAssignment 
{
    [XmlElement(ElementName = "userServiceName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserService UserServiceName { get; set; }
    [XmlElement(ElementName = "authorizedQuantity", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnboundedPositiveInt AuthorizedQuantity { get; set; }
 }
}
