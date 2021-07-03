using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupEnterpriseTrunkGetRequest22.
    /// <see cref="GroupEnterpriseTrunkGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:821"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:825""}]}]")]
    public class GroupEnterpriseTrunkGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _maximumRerouteAttempts;

        [XmlElement(ElementName = "maximumRerouteAttempts", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:821")]
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
        protected bool MaximumRerouteAttemptsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.EnterpriseTrunkRouteExhaustionAction _routeExhaustionAction;

        [XmlElement(ElementName = "routeExhaustionAction", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:821")]
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
        protected bool RouteExhaustionActionSpecified { get; set; }

        private string _routeExhaustionForwardAddress;

        [XmlElement(ElementName = "routeExhaustionForwardAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:821")]
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
        protected bool RouteExhaustionForwardAddressSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkGetResponse22OrderedRouting _orderedRouting;

        [XmlElement(ElementName = "orderedRouting", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:825")]
        public BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkGetResponse22OrderedRouting OrderedRouting
        {
            get => _orderedRouting;
            set
            {
                OrderedRoutingSpecified = true;
                _orderedRouting = value;
            }
        }

        [XmlIgnore]
        protected bool OrderedRoutingSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkGetResponse22PriorityWeightedRouting _priorityWeightedRouting;

        [XmlElement(ElementName = "priorityWeightedRouting", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:825")]
        public BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkGetResponse22PriorityWeightedRouting PriorityWeightedRouting
        {
            get => _priorityWeightedRouting;
            set
            {
                PriorityWeightedRoutingSpecified = true;
                _priorityWeightedRouting = value;
            }
        }

        [XmlIgnore]
        protected bool PriorityWeightedRoutingSpecified { get; set; }

        private bool _enableCapacityManagement;

        [XmlElement(ElementName = "enableCapacityManagement", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:821")]
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
        protected bool EnableCapacityManagementSpecified { get; set; }

        private int _maxActiveCalls;

        [XmlElement(ElementName = "maxActiveCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:821")]
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
        protected bool MaxActiveCallsSpecified { get; set; }

        private int _capacityExceededTrapInitialCalls;

        [XmlElement(ElementName = "capacityExceededTrapInitialCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:821")]
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
        protected bool CapacityExceededTrapInitialCallsSpecified { get; set; }

        private int _capacityExceededTrapOffsetCalls;

        [XmlElement(ElementName = "capacityExceededTrapOffsetCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:821")]
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
        protected bool CapacityExceededTrapOffsetCallsSpecified { get; set; }

        private int _maximumActiveIncomingCallsAllowed;

        [XmlElement(ElementName = "maximumActiveIncomingCallsAllowed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:821")]
        [MinInclusive(0)]
        public int MaximumActiveIncomingCallsAllowed
        {
            get => _maximumActiveIncomingCallsAllowed;
            set
            {
                MaximumActiveIncomingCallsAllowedSpecified = true;
                _maximumActiveIncomingCallsAllowed = value;
            }
        }

        [XmlIgnore]
        protected bool MaximumActiveIncomingCallsAllowedSpecified { get; set; }

        private int _maximumActiveOutgoingCallsAllowed;

        [XmlElement(ElementName = "maximumActiveOutgoingCallsAllowed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:821")]
        [MinInclusive(0)]
        public int MaximumActiveOutgoingCallsAllowed
        {
            get => _maximumActiveOutgoingCallsAllowed;
            set
            {
                MaximumActiveOutgoingCallsAllowedSpecified = true;
                _maximumActiveOutgoingCallsAllowed = value;
            }
        }

        [XmlIgnore]
        protected bool MaximumActiveOutgoingCallsAllowedSpecified { get; set; }

        private int _minimumActiveCallsReserved;

        [XmlElement(ElementName = "minimumActiveCallsReserved", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:821")]
        [MinInclusive(0)]
        public int MinimumActiveCallsReserved
        {
            get => _minimumActiveCallsReserved;
            set
            {
                MinimumActiveCallsReservedSpecified = true;
                _minimumActiveCallsReserved = value;
            }
        }

        [XmlIgnore]
        protected bool MinimumActiveCallsReservedSpecified { get; set; }

    }
}
