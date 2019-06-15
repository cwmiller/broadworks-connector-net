using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseEnterpriseTrunkGetRequest.
    /// Replaced by: EnterpriseEnterpriseTrunkGetResponse21.
        /// <see cref="EnterpriseEnterpriseTrunkGetRequest"/>
        /// <see cref="EnterpriseEnterpriseTrunkGetResponse21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseEnterpriseTrunkGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
        
        private BroadWorksConnector.Ocip.Models.EnterpriseEnterpriseTrunkGetResponseOrderedRouting _orderedRouting;

        [XmlElement(ElementName = "orderedRouting", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.EnterpriseEnterpriseTrunkGetResponseOrderedRouting OrderedRouting {
            get => _orderedRouting;
            set {
                OrderedRoutingSpecified = true;
                _orderedRouting = value;
            }
        }

        [XmlIgnore]
        public bool OrderedRoutingSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.EnterpriseEnterpriseTrunkGetResponsePriorityWeightedRouting _priorityWeightedRouting;

        [XmlElement(ElementName = "priorityWeightedRouting", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.EnterpriseEnterpriseTrunkGetResponsePriorityWeightedRouting PriorityWeightedRouting {
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
