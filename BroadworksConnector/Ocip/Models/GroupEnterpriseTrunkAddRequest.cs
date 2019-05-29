using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEnterpriseTrunkAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "enterpriseTrunkName", IsNullable = false)]
    public string EnterpriseTrunkName { get; set; }
    [XmlElement(ElementName = "maximumRerouteAttempts", IsNullable = false)]
    public int MaximumRerouteAttempts { get; set; }
    [XmlElement(ElementName = "routeExhaustionAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseTrunkRouteExhaustionAction RouteExhaustionAction { get; set; }
    [XmlElement(ElementName = "routeExhaustionForwardAddress", IsNullable = false)]
    public string RouteExhaustionForwardAddress { get; set; }
    [XmlElement(ElementName = "orderedRouting", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupEnterpriseTrunkAddRequestOrderedRouting OrderedRouting { get; set; }
    [XmlElement(ElementName = "priorityWeightedRouting", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupEnterpriseTrunkAddRequestPriorityWeightedRouting PriorityWeightedRouting { get; set; }
 }
}
