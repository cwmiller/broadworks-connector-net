using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserConsolidatedModifyRequestEndpoint 
{
    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ConsolidatedAccessDeviceMultipleIdentityEndpointAndContactModify AccessDeviceEndpoint { get; set; }
    [XmlElement(ElementName = "trunkAddressing", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkAddressingMultipleContactModify TrunkAddressing { get; set; }
 }
}
