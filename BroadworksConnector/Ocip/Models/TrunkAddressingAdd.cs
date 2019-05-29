using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class TrunkAddressingAdd 
{
    [XmlElement(ElementName = "trunkGroupDeviceEndpoint", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupDeviceEndpointAdd TrunkGroupDeviceEndpoint { get; set; }
    [XmlElement(ElementName = "enterpriseTrunkName", IsNullable = false)]
    public string EnterpriseTrunkName { get; set; }
    [XmlElement(ElementName = "alternateTrunkIdentity", IsNullable = false)]
    public string AlternateTrunkIdentity { get; set; }
 }
}
