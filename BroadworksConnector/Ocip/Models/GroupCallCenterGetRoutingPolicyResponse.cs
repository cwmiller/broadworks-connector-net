using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterGetRoutingPolicyResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "routingPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterRoutingPolicy RoutingPolicy { get; set; }
    [XmlElement(ElementName = "callCenterTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable CallCenterTable { get; set; }
 }
}
