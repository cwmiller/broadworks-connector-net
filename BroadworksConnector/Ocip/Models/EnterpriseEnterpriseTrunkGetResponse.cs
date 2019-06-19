using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:33113"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:33117""}]}]")]
    public class EnterpriseEnterpriseTrunkGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _maximumRerouteAttempts;

        [XmlElement(ElementName = "maximumRerouteAttempts", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33113")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33113")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33113")]
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

        private BroadWorksConnector.Ocip.Models.EnterpriseEnterpriseTrunkGetResponseOrderedRouting _orderedRouting;

        [XmlElement(ElementName = "orderedRouting", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33117")]
        public BroadWorksConnector.Ocip.Models.EnterpriseEnterpriseTrunkGetResponseOrderedRouting OrderedRouting
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

        private BroadWorksConnector.Ocip.Models.EnterpriseEnterpriseTrunkGetResponsePriorityWeightedRouting _priorityWeightedRouting;

        [XmlElement(ElementName = "priorityWeightedRouting", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33117")]
        public BroadWorksConnector.Ocip.Models.EnterpriseEnterpriseTrunkGetResponsePriorityWeightedRouting PriorityWeightedRouting
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

    }
}
