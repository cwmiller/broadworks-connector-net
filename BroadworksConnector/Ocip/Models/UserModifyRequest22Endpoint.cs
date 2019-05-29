using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserModifyRequest22Endpoint 
{
    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceMultipleIdentityAndContactEndpointModify22 AccessDeviceEndpoint { get; set; }
    [XmlElement(ElementName = "trunkAddressing", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkAddressingMultipleContactModify22 TrunkAddressing { get; set; }
 }
}
