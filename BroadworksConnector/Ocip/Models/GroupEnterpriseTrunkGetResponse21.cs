using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupEnterpriseTrunkGetRequest21.
    /// <see cref="GroupEnterpriseTrunkGetRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:716"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:720""}]}]")]
    public class GroupEnterpriseTrunkGetResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _maximumRerouteAttempts;

        [XmlElement(ElementName = "maximumRerouteAttempts", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:716")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int MaximumRerouteAttempts
        {
            get => _maximumRerouteAttempts;
            set
            {
                MaximumRerouteAttemptsSpecified = true;
                _maximumRerouteAttempts = value;
            }
        }

        [XmlIgnore]
        public bool MaximumRerouteAttemptsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.EnterpriseTrunkRouteExhaustionAction _routeExhaustionAction;

        [XmlElement(ElementName = "routeExhaustionAction", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:716")]
        public BroadWorksConnector.Ocip.Models.EnterpriseTrunkRouteExhaustionAction RouteExhaustionAction
        {
            get => _routeExhaustionAction;
            set
            {
                RouteExhaustionActionSpecified = true;
                _routeExhaustionAction = value;
            }
        }

        [XmlIgnore]
        public bool RouteExhaustionActionSpecified { get; set; }

        private string _routeExhaustionForwardAddress;

        [XmlElement(ElementName = "routeExhaustionForwardAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:716")]
        [MinLength(1)]
        [MaxLength(161)]
        public string RouteExhaustionForwardAddress
        {
            get => _routeExhaustionForwardAddress;
            set
            {
                RouteExhaustionForwardAddressSpecified = true;
                _routeExhaustionForwardAddress = value;
            }
        }

        [XmlIgnore]
        public bool RouteExhaustionForwardAddressSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkGetResponse21OrderedRouting _orderedRouting;

        [XmlElement(ElementName = "orderedRouting", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:720")]
        public BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkGetResponse21OrderedRouting OrderedRouting
        {
            get => _orderedRouting;
            set
            {
                OrderedRoutingSpecified = true;
                _orderedRouting = value;
            }
        }

        [XmlIgnore]
        public bool OrderedRoutingSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkGetResponse21PriorityWeightedRouting _priorityWeightedRouting;

        [XmlElement(ElementName = "priorityWeightedRouting", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:720")]
        public BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkGetResponse21PriorityWeightedRouting PriorityWeightedRouting
        {
            get => _priorityWeightedRouting;
            set
            {
                PriorityWeightedRoutingSpecified = true;
                _priorityWeightedRouting = value;
            }
        }

        [XmlIgnore]
        public bool PriorityWeightedRoutingSpecified { get; set; }

        private bool _enableCapacityManagement;

        [XmlElement(ElementName = "enableCapacityManagement", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:716")]
        public bool EnableCapacityManagement
        {
            get => _enableCapacityManagement;
            set
            {
                EnableCapacityManagementSpecified = true;
                _enableCapacityManagement = value;
            }
        }

        [XmlIgnore]
        public bool EnableCapacityManagementSpecified { get; set; }

        private int _maxActiveCalls;

        [XmlElement(ElementName = "maxActiveCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:716")]
        [MinInclusive(1)]
        public int MaxActiveCalls
        {
            get => _maxActiveCalls;
            set
            {
                MaxActiveCallsSpecified = true;
                _maxActiveCalls = value;
            }
        }

        [XmlIgnore]
        public bool MaxActiveCallsSpecified { get; set; }

        private int _capacityExceededTrapInitialCalls;

        [XmlElement(ElementName = "capacityExceededTrapInitialCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:716")]
        [MinInclusive(0)]
        public int CapacityExceededTrapInitialCalls
        {
            get => _capacityExceededTrapInitialCalls;
            set
            {
                CapacityExceededTrapInitialCallsSpecified = true;
                _capacityExceededTrapInitialCalls = value;
            }
        }

        [XmlIgnore]
        public bool CapacityExceededTrapInitialCallsSpecified { get; set; }

        private int _capacityExceededTrapOffsetCalls;

        [XmlElement(ElementName = "capacityExceededTrapOffsetCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:716")]
        [MinInclusive(0)]
        public int CapacityExceededTrapOffsetCalls
        {
            get => _capacityExceededTrapOffsetCalls;
            set
            {
                CapacityExceededTrapOffsetCallsSpecified = true;
                _capacityExceededTrapOffsetCalls = value;
            }
        }

        [XmlIgnore]
        public bool CapacityExceededTrapOffsetCallsSpecified { get; set; }

    }
}
