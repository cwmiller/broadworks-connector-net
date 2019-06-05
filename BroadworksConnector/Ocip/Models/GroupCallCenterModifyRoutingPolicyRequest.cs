using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterModifyRoutingPolicyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _groupId;

    [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
    public string GroupId {
        get => _groupId;
        set {
            GroupIdSpecified = true;
            _groupId = value;
        }
    }

    [XmlIgnore]
    public bool GroupIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterRoutingPolicy _routingPolicy;

    [XmlElement(ElementName = "routingPolicy", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterRoutingPolicy RoutingPolicy {
        get => _routingPolicy;
        set {
            RoutingPolicySpecified = true;
            _routingPolicy = value;
        }
    }

    [XmlIgnore]
    public bool RoutingPolicySpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.CallCenterRoutingPriorityOrder> _routingPriorityOrder;

    [XmlElement(ElementName = "routingPriorityOrder", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CallCenterRoutingPriorityOrder> RoutingPriorityOrder {
        get => _routingPriorityOrder;
        set {
            RoutingPriorityOrderSpecified = true;
            _routingPriorityOrder = value;
        }
    }

    [XmlIgnore]
    public bool RoutingPriorityOrderSpecified { get; set; }
}
}
