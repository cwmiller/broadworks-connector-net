using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class TrunkAddressingMultipleContactModify22 
{
    [XmlElement(ElementName = "trunkGroupDeviceEndpoint", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.TrunkGroupDeviceMultipleContactEndpointModify22 TrunkGroupDeviceEndpoint { get; set; }
    [XmlElement(ElementName = "enterpriseTrunkName", IsNullable = true)]
    public string EnterpriseTrunkName { get; set; }
    [XmlElement(ElementName = "alternateTrunkIdentity", IsNullable = true)]
    public string AlternateTrunkIdentity { get; set; }
    [XmlElement(ElementName = "alternateTrunkIdentityDomain", IsNullable = true)]
    public string AlternateTrunkIdentityDomain { get; set; }
    [XmlElement(ElementName = "physicalLocation", IsNullable = true)]
    public string PhysicalLocation { get; set; }
 }
}
