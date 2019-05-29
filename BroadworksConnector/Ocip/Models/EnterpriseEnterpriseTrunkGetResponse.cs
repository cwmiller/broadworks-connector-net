using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseEnterpriseTrunkGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "maximumRerouteAttempts", IsNullable = false)]
    public int MaximumRerouteAttempts { get; set; }
    [XmlElement(ElementName = "routeExhaustionAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseTrunkRouteExhaustionAction RouteExhaustionAction { get; set; }
    [XmlElement(ElementName = "routeExhaustionForwardAddress", IsNullable = false)]
    public string RouteExhaustionForwardAddress { get; set; }
    [XmlElement(ElementName = "orderedRouting", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseEnterpriseTrunkGetResponseOrderedRouting OrderedRouting { get; set; }
    [XmlElement(ElementName = "priorityWeightedRouting", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseEnterpriseTrunkGetResponsePriorityWeightedRouting PriorityWeightedRouting { get; set; }
 }
}
