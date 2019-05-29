using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBwDiameterRoutingRealmModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "instance", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.BwDiameterPeerInstance Instance { get; set; }
    [XmlElement(ElementName = "realm", IsNullable = false)]
    public string Realm { get; set; }
    [XmlElement(ElementName = "applicationId", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.BwDiameterApplicationId ApplicationId { get; set; }
    [XmlElement(ElementName = "default", IsNullable = false)]
    public bool Default { get; set; }
 }
}
