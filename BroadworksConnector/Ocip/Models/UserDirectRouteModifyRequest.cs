using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserDirectRouteModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "outgoingDTGPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DirectRouteOutgoingDTGPolicy OutgoingDTGPolicy { get; set; }
    [XmlElement(ElementName = "outgoingTrunkIdentityPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DirectRouteOutgoingTrunkIdentityPolicy OutgoingTrunkIdentityPolicy { get; set; }
    [XmlElement(ElementName = "directRouteIdentityList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.DirectRouteReplacementIdentityList DirectRouteIdentityList { get; set; }
 }
}
