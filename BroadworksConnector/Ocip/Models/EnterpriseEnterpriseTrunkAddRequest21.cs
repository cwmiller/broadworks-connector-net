using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseEnterpriseTrunkAddRequest21 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "enterpriseTrunkName", IsNullable = false)]
    public string EnterpriseTrunkName { get; set; }
    [XmlElement(ElementName = "maximumRerouteAttempts", IsNullable = false)]
    public int MaximumRerouteAttempts { get; set; }
    [XmlElement(ElementName = "routeExhaustionAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseTrunkRouteExhaustionAction RouteExhaustionAction { get; set; }
    [XmlElement(ElementName = "routeExhaustionForwardAddress", IsNullable = false)]
    public string RouteExhaustionForwardAddress { get; set; }
    [XmlElement(ElementName = "orderedRouting", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseEnterpriseTrunkAddRequest21OrderedRouting OrderedRouting { get; set; }
    [XmlElement(ElementName = "priorityWeightedRouting", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseEnterpriseTrunkAddRequest21PriorityWeightedRouting PriorityWeightedRouting { get; set; }
    [XmlElement(ElementName = "enableCapacityManagement", IsNullable = false)]
    public bool EnableCapacityManagement { get; set; }
    [XmlElement(ElementName = "maxActiveCalls", IsNullable = false)]
    public int MaxActiveCalls { get; set; }
    [XmlElement(ElementName = "capacityExceededTrapInitialCalls", IsNullable = false)]
    public int CapacityExceededTrapInitialCalls { get; set; }
    [XmlElement(ElementName = "capacityExceededTrapOffsetCalls", IsNullable = false)]
    public int CapacityExceededTrapOffsetCalls { get; set; }
 }
}
