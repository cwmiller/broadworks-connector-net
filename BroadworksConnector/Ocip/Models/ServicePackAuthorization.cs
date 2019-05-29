using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServicePackAuthorization 
{
    [XmlElement(ElementName = "servicePackName", IsNullable = false)]
    public string ServicePackName { get; set; }
    [XmlElement(ElementName = "authorizedQuantity", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnboundedPositiveInt AuthorizedQuantity { get; set; }
    [XmlElement(ElementName = "unauthorized", IsNullable = false)]
    public bool Unauthorized { get; set; }
 }
}
