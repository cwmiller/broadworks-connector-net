using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBwDiameterRoutingPeerDeleteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "instance", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.BwDiameterPeerInstance Instance { get; set; }
    [XmlElement(ElementName = "realm", IsNullable = false)]
    public string Realm { get; set; }
    [XmlElement(ElementName = "applicationId", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.BwDiameterApplicationId ApplicationId { get; set; }
    [XmlElement(ElementName = "identity", IsNullable = false)]
    public string Identity { get; set; }
 }
}
