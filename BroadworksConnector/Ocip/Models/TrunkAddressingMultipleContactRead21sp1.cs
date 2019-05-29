using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class TrunkAddressingMultipleContactRead21sp1 
{
    [XmlElement(ElementName = "trunkGroupDeviceEndpoint", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupDeviceMultipleContactEndpointRead TrunkGroupDeviceEndpoint { get; set; }
    [XmlElement(ElementName = "enterpriseTrunkName", IsNullable = false)]
    public string EnterpriseTrunkName { get; set; }
    [XmlElement(ElementName = "alternateTrunkIdentity", IsNullable = false)]
    public string AlternateTrunkIdentity { get; set; }
    [XmlElement(ElementName = "alternateTrunkIdentityDomain", IsNullable = false)]
    public string AlternateTrunkIdentityDomain { get; set; }
    [XmlElement(ElementName = "physicalLocation", IsNullable = false)]
    public string PhysicalLocation { get; set; }
 }
}
