using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add an enterprise trunk in a group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:564"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:571""}]}]")]
    public class GroupEnterpriseTrunkAddRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:564")]
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

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:564")]
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

        protected string _enterpriseTrunkName;

        [XmlElement(ElementName = "enterpriseTrunkName", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:564")]
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

        protected int _maximumRerouteAttempts;

        [XmlElement(ElementName = "maximumRerouteAttempts", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:564")]
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

        protected BroadWorksConnector.Ocip.Models.EnterpriseTrunkRouteExhaustionAction _routeExhaustionAction;

        [XmlElement(ElementName = "routeExhaustionAction", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:564")]
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

        protected string _routeExhaustionForwardAddress;

        [XmlElement(ElementName = "routeExhaustionForwardAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:564")]
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

        protected BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkAddRequest21OrderedRouting _orderedRouting;

        [XmlElement(ElementName = "orderedRouting", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:571")]
        public BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkAddRequest21OrderedRouting OrderedRouting
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

        protected BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkAddRequest21PriorityWeightedRouting _priorityWeightedRouting;

        [XmlElement(ElementName = "priorityWeightedRouting", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:571")]
        public BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkAddRequest21PriorityWeightedRouting PriorityWeightedRouting
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

        protected bool _enableCapacityManagement;

        [XmlElement(ElementName = "enableCapacityManagement", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:564")]
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

        protected int _maxActiveCalls;

        [XmlElement(ElementName = "maxActiveCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:564")]
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

        protected int _capacityExceededTrapInitialCalls;

        [XmlElement(ElementName = "capacityExceededTrapInitialCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:564")]
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

        protected int _capacityExceededTrapOffsetCalls;

        [XmlElement(ElementName = "capacityExceededTrapOffsetCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:564")]
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

        protected int _maximumActiveIncomingCallsAllowed;

        [XmlElement(ElementName = "maximumActiveIncomingCallsAllowed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:564")]
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

        protected int _maximumActiveOutgoingCallsAllowed;

        [XmlElement(ElementName = "maximumActiveOutgoingCallsAllowed", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:564")]
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

        protected int _minimumActiveCallsReserved;

        [XmlElement(ElementName = "minimumActiveCallsReserved", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:564")]
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
