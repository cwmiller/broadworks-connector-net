using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEnterpriseTrunkModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _newEnterpriseTrunkName;

    [XmlElement(ElementName = "newEnterpriseTrunkName", IsNullable = false, Namespace = "")]
    public string NewEnterpriseTrunkName {
        get => _newEnterpriseTrunkName;
        set {
            NewEnterpriseTrunkNameSpecified = true;
            _newEnterpriseTrunkName = value;
        }
    }

    [XmlIgnore]
    public bool NewEnterpriseTrunkNameSpecified { get; set; }
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
    private BroadWorksConnector.Ocip.Models.EnterpriseTrunkRouteExhaustionAction _routeExhaustionAction;

    [XmlElement(ElementName = "routeExhaustionAction", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.EnterpriseTrunkRouteExhaustionAction RouteExhaustionAction {
        get => _routeExhaustionAction;
        set {
            RouteExhaustionActionSpecified = true;
            _routeExhaustionAction = value;
        }
    }

    [XmlIgnore]
    public bool RouteExhaustionActionSpecified { get; set; }
    private string _routeExhaustionForwardAddress;

    [XmlElement(ElementName = "routeExhaustionForwardAddress", IsNullable = true, Namespace = "")]
    public string RouteExhaustionForwardAddress {
        get => _routeExhaustionForwardAddress;
        set {
            RouteExhaustionForwardAddressSpecified = true;
            _routeExhaustionForwardAddress = value;
        }
    }

    [XmlIgnore]
    public bool RouteExhaustionForwardAddressSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkModifyRequestOrderedRouting _orderedRouting;

    [XmlElement(ElementName = "orderedRouting", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkModifyRequestOrderedRouting OrderedRouting {
        get => _orderedRouting;
        set {
            OrderedRoutingSpecified = true;
            _orderedRouting = value;
        }
    }

    [XmlIgnore]
    public bool OrderedRoutingSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkModifyRequestPriorityWeightedRouting _priorityWeightedRouting;

    [XmlElement(ElementName = "priorityWeightedRouting", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkModifyRequestPriorityWeightedRouting PriorityWeightedRouting {
        get => _priorityWeightedRouting;
        set {
            PriorityWeightedRoutingSpecified = true;
            _priorityWeightedRouting = value;
        }
    }

    [XmlIgnore]
    public bool PriorityWeightedRoutingSpecified { get; set; }
    private bool _enableCapacityManagement;

    [XmlElement(ElementName = "enableCapacityManagement", IsNullable = false, Namespace = "")]
    public bool EnableCapacityManagement {
        get => _enableCapacityManagement;
        set {
            EnableCapacityManagementSpecified = true;
            _enableCapacityManagement = value;
        }
    }

    [XmlIgnore]
    public bool EnableCapacityManagementSpecified { get; set; }
    private int? _maxActiveCalls;

    [XmlElement(ElementName = "maxActiveCalls", IsNullable = true, Namespace = "")]
    public int? MaxActiveCalls {
        get => _maxActiveCalls;
        set {
            MaxActiveCallsSpecified = true;
            _maxActiveCalls = value;
        }
    }

    [XmlIgnore]
    public bool MaxActiveCallsSpecified { get; set; }
    private int? _capacityExceededTrapInitialCalls;

    [XmlElement(ElementName = "capacityExceededTrapInitialCalls", IsNullable = true, Namespace = "")]
    public int? CapacityExceededTrapInitialCalls {
        get => _capacityExceededTrapInitialCalls;
        set {
            CapacityExceededTrapInitialCallsSpecified = true;
            _capacityExceededTrapInitialCalls = value;
        }
    }

    [XmlIgnore]
    public bool CapacityExceededTrapInitialCallsSpecified { get; set; }
    private int? _capacityExceededTrapOffsetCalls;

    [XmlElement(ElementName = "capacityExceededTrapOffsetCalls", IsNullable = true, Namespace = "")]
    public int? CapacityExceededTrapOffsetCalls {
        get => _capacityExceededTrapOffsetCalls;
        set {
            CapacityExceededTrapOffsetCallsSpecified = true;
            _capacityExceededTrapOffsetCalls = value;
        }
    }

    [XmlIgnore]
    public bool CapacityExceededTrapOffsetCallsSpecified { get; set; }
}
}
