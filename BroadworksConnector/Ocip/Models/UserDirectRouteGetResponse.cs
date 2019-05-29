using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserDirectRouteGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "outgoingDTGPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DirectRouteOutgoingDTGPolicy OutgoingDTGPolicy { get; set; }
    [XmlElement(ElementName = "outgoingTrunkIdentityPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DirectRouteOutgoingTrunkIdentityPolicy OutgoingTrunkIdentityPolicy { get; set; }
    [XmlElement(ElementName = "directRouteIdentityList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DirectRouteIdentifiers DirectRouteIdentityList { get; set; }
 }
}
