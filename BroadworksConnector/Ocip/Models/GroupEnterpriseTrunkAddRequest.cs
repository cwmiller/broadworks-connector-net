using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEnterpriseTrunkAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _enterpriseTrunkName;

    [XmlElement(ElementName = "enterpriseTrunkName", IsNullable = false, Namespace = "")]
    public string EnterpriseTrunkName {
        get => _enterpriseTrunkName;
        set {
            EnterpriseTrunkNameSpecified = true;
            _enterpriseTrunkName = value;
        }
    }

    [XmlIgnore]
    public bool EnterpriseTrunkNameSpecified { get; set; }
    private int _maximumRerouteAttempts;

    [XmlElement(ElementName = "maximumRerouteAttempts", IsNullable = false, Namespace = "")]
    public int MaximumRerouteAttempts {
        get => _maximumRerouteAttempts;
        set {
            MaximumRerouteAttemptsSpecified = true;
            _maximumRerouteAttempts = value;
        }
    }

    [XmlIgnore]
    public bool MaximumRerouteAttemptsSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.EnterpriseTrunkRouteExhaustionAction _routeExhaustionAction;

    [XmlElement(ElementName = "routeExhaustionAction", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.EnterpriseTrunkRouteExhaustionAction RouteExhaustionAction {
        get => _routeExhaustionAction;
        set {
            RouteExhaustionActionSpecified = true;
            _routeExhaustionAction = value;
        }
    }

    [XmlIgnore]
    public bool RouteExhaustionActionSpecified { get; set; }
    private string _routeExhaustionForwardAddress;

    [XmlElement(ElementName = "routeExhaustionForwardAddress", IsNullable = false, Namespace = "")]
    public string RouteExhaustionForwardAddress {
        get => _routeExhaustionForwardAddress;
        set {
            RouteExhaustionForwardAddressSpecified = true;
            _routeExhaustionForwardAddress = value;
        }
    }

    [XmlIgnore]
    public bool RouteExhaustionForwardAddressSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupEnterpriseTrunkAddRequestOrderedRouting _orderedRouting;

    [XmlElement(ElementName = "orderedRouting", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupEnterpriseTrunkAddRequestOrderedRouting OrderedRouting {
        get => _orderedRouting;
        set {
            OrderedRoutingSpecified = true;
            _orderedRouting = value;
        }
    }

    [XmlIgnore]
    public bool OrderedRoutingSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GroupEnterpriseTrunkAddRequestPriorityWeightedRouting _priorityWeightedRouting;

    [XmlElement(ElementName = "priorityWeightedRouting", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupEnterpriseTrunkAddRequestPriorityWeightedRouting PriorityWeightedRouting {
        get => _priorityWeightedRouting;
        set {
            PriorityWeightedRoutingSpecified = true;
            _priorityWeightedRouting = value;
        }
    }

    [XmlIgnore]
    public bool PriorityWeightedRoutingSpecified { get; set; }
}
}
