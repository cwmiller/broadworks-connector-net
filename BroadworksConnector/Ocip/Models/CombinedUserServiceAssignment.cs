using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CombinedUserServiceAssignment 
{
    [XmlElement(ElementName = "userService", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserService UserService { get; set; }
    [XmlElement(ElementName = "authorizedQuantity", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnboundedPositiveInt AuthorizedQuantity { get; set; }
 }
}
