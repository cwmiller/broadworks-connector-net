using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:33237""}]")]
    public class GroupEnterpriseTrunkGetResponsePriorityWeightedRouting
    {

        private List<BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkPriorityWeightedTrunkGroup> _priorityWeightedTrunkGroup = new List<BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkPriorityWeightedTrunkGroup>();

        [XmlElement(ElementName = "priorityWeightedTrunkGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33237")]
        public List<BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkPriorityWeightedTrunkGroup> PriorityWeightedTrunkGroup
        {
            get => _priorityWeightedTrunkGroup;
            set
            {
                PriorityWeightedTrunkGroupSpecified = true;
                _priorityWeightedTrunkGroup = value;
            }
        }

        [XmlIgnore]
        protected bool PriorityWeightedTrunkGroupSpecified { get; set; }

        private int _maximumRerouteAttemptsWithinPriority;

        [XmlElement(ElementName = "maximumRerouteAttemptsWithinPriority", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:33237")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int MaximumRerouteAttemptsWithinPriority
        {
            get => _maximumRerouteAttemptsWithinPriority;
            set
            {
                MaximumRerouteAttemptsWithinPrioritySpecified = true;
                _maximumRerouteAttemptsWithinPriority = value;
            }
        }

        [XmlIgnore]
        protected bool MaximumRerouteAttemptsWithinPrioritySpecified { get; set; }

    }
}
