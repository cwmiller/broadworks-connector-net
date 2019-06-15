using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseEnterpriseTrunkGetRequest21.
        /// <see cref="EnterpriseEnterpriseTrunkGetRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseEnterpriseTrunkGetResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
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
        
        private BroadWorksConnector.Ocip.Models.EnterpriseEnterpriseTrunkGetResponse21OrderedRouting _orderedRouting;

        [XmlElement(ElementName = "orderedRouting", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.EnterpriseEnterpriseTrunkGetResponse21OrderedRouting OrderedRouting {
            get => _orderedRouting;
            set {
                OrderedRoutingSpecified = true;
                _orderedRouting = value;
            }
        }

        [XmlIgnore]
        public bool OrderedRoutingSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.EnterpriseEnterpriseTrunkGetResponse21PriorityWeightedRouting _priorityWeightedRouting;

        [XmlElement(ElementName = "priorityWeightedRouting", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.EnterpriseEnterpriseTrunkGetResponse21PriorityWeightedRouting PriorityWeightedRouting {
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
        
        private int _maxActiveCalls;

        [XmlElement(ElementName = "maxActiveCalls", IsNullable = false, Namespace = "")]
        public int MaxActiveCalls {
            get => _maxActiveCalls;
            set {
                MaxActiveCallsSpecified = true;
                _maxActiveCalls = value;
            }
        }

        [XmlIgnore]
        public bool MaxActiveCallsSpecified { get; set; }
        
        private int _capacityExceededTrapInitialCalls;

        [XmlElement(ElementName = "capacityExceededTrapInitialCalls", IsNullable = false, Namespace = "")]
        public int CapacityExceededTrapInitialCalls {
            get => _capacityExceededTrapInitialCalls;
            set {
                CapacityExceededTrapInitialCallsSpecified = true;
                _capacityExceededTrapInitialCalls = value;
            }
        }

        [XmlIgnore]
        public bool CapacityExceededTrapInitialCallsSpecified { get; set; }
        
        private int _capacityExceededTrapOffsetCalls;

        [XmlElement(ElementName = "capacityExceededTrapOffsetCalls", IsNullable = false, Namespace = "")]
        public int CapacityExceededTrapOffsetCalls {
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
