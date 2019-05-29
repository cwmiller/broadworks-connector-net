using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class TrunkAddressingModify 
{
    [XmlElement(ElementName = "trunkGroupDeviceEndpoint", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.TrunkGroupDeviceEndpointModify TrunkGroupDeviceEndpoint { get; set; }
    [XmlElement(ElementName = "enterpriseTrunkName", IsNullable = true)]
    public string EnterpriseTrunkName { get; set; }
    [XmlElement(ElementName = "alternateTrunkIdentity", IsNullable = true)]
    public string AlternateTrunkIdentity { get; set; }
 }
}
