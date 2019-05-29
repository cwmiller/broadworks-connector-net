using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CombinedGroupServiceAuthorization 
{
    [XmlElement(ElementName = "serviceName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupService ServiceName { get; set; }
    [XmlElement(ElementName = "authorizedQuantity", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnboundedPositiveInt AuthorizedQuantity { get; set; }
 }
}
