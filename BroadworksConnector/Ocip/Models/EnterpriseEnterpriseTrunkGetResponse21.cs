using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseEnterpriseTrunkGetResponse21 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "maximumRerouteAttempts", IsNullable = false)]
    public int MaximumRerouteAttempts { get; set; }
    [XmlElement(ElementName = "routeExhaustionAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseTrunkRouteExhaustionAction RouteExhaustionAction { get; set; }
    [XmlElement(ElementName = "routeExhaustionForwardAddress", IsNullable = false)]
    public string RouteExhaustionForwardAddress { get; set; }
    [XmlElement(ElementName = "orderedRouting", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseEnterpriseTrunkGetResponse21OrderedRouting OrderedRouting { get; set; }
    [XmlElement(ElementName = "priorityWeightedRouting", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseEnterpriseTrunkGetResponse21PriorityWeightedRouting PriorityWeightedRouting { get; set; }
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
