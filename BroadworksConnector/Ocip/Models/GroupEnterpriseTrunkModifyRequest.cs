using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify an enterprise trunk in a group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:914"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:922"",""optional"":true}]}]")]
    public class GroupEnterpriseTrunkModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:914")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:914")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private string _enterpriseTrunkName;

        [XmlElement(ElementName = "enterpriseTrunkName", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:914")]
        [MinLength(1)]
        [MaxLength(30)]
        public string EnterpriseTrunkName
        {
            get => _enterpriseTrunkName;
            set
            {
                EnterpriseTrunkNameSpecified = true;
                _enterpriseTrunkName = value;
            }
        }

        [XmlIgnore]
        protected bool EnterpriseTrunkNameSpecified { get; set; }

        private string _newEnterpriseTrunkName;

        [XmlElement(ElementName = "newEnterpriseTrunkName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:914")]
        [MinLength(1)]
        [MaxLength(30)]
        public string NewEnterpriseTrunkName
        {
            get => _newEnterpriseTrunkName;
            set
            {
                NewEnterpriseTrunkNameSpecified = true;
                _newEnterpriseTrunkName = value;
            }
        }

        [XmlIgnore]
        protected bool NewEnterpriseTrunkNameSpecified { get; set; }

        private int _maximumRerouteAttempts;

        [XmlElement(ElementName = "maximumRerouteAttempts", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:914")]
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
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:914")]
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

        [XmlElement(ElementName = "routeExhaustionForwardAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:914")]
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

        private BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkModifyRequestOrderedRouting _orderedRouting;

        [XmlElement(ElementName = "orderedRouting", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:922")]
        public BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkModifyRequestOrderedRouting OrderedRouting
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

        private BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkModifyRequestPriorityWeightedRouting _priorityWeightedRouting;

        [XmlElement(ElementName = "priorityWeightedRouting", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:922")]
        public BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkModifyRequestPriorityWeightedRouting PriorityWeightedRouting
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
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:914")]
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

        private int? _maxActiveCalls;

        [XmlElement(ElementName = "maxActiveCalls", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:914")]
        [MinInclusive(1)]
        public int? MaxActiveCalls
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

        private int? _capacityExceededTrapInitialCalls;

        [XmlElement(ElementName = "capacityExceededTrapInitialCalls", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:914")]
        [MinInclusive(0)]
        public int? CapacityExceededTrapInitialCalls
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

        private int? _capacityExceededTrapOffsetCalls;

        [XmlElement(ElementName = "capacityExceededTrapOffsetCalls", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:914")]
        [MinInclusive(0)]
        public int? CapacityExceededTrapOffsetCalls
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

        private int? _maximumActiveIncomingCallsAllowed;

        [XmlElement(ElementName = "maximumActiveIncomingCallsAllowed", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:914")]
        [MinInclusive(0)]
        public int? MaximumActiveIncomingCallsAllowed
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

        private int? _maximumActiveOutgoingCallsAllowed;

        [XmlElement(ElementName = "maximumActiveOutgoingCallsAllowed", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:914")]
        [MinInclusive(0)]
        public int? MaximumActiveOutgoingCallsAllowed
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

        private int? _minimumActiveCallsReserved;

        [XmlElement(ElementName = "minimumActiveCallsReserved", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:914")]
        [MinInclusive(0)]
        public int? MinimumActiveCallsReserved
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
