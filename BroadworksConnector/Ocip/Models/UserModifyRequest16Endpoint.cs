using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserModifyRequest16Endpoint 
{
    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointModify AccessDeviceEndpoint { get; set; }
    [XmlElement(ElementName = "trunkAddressing", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkAddressingModify TrunkAddressing { get; set; }
 }
}
