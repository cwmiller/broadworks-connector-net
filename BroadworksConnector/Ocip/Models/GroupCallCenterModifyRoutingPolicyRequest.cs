using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterModifyRoutingPolicyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "routingPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterRoutingPolicy RoutingPolicy { get; set; }
    [XmlElement(ElementName = "routingPriorityOrder", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CallCenterRoutingPriorityOrder> RoutingPriorityOrder { get; set; }
 }
}
