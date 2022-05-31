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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:450""}]")]
    public class EnterpriseEnterpriseTrunkModifyRequestPriorityWeightedRouting
    {

        protected int _maximumRerouteAttemptsWithinPriority;

        [XmlElement(ElementName = "maximumRerouteAttemptsWithinPriority", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:450")]
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

        protected BroadWorksConnector.Ocip.Models.ReplacementEnterpriseEnterpriseTrunkPriorityWeightedTrunkGroupList _priorityWeightedTrunkGroupList;

        [XmlElement(ElementName = "priorityWeightedTrunkGroupList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:450")]
        public BroadWorksConnector.Ocip.Models.ReplacementEnterpriseEnterpriseTrunkPriorityWeightedTrunkGroupList PriorityWeightedTrunkGroupList
        {
            get => _priorityWeightedTrunkGroupList;
            set
            {
                PriorityWeightedTrunkGroupListSpecified = true;
                _priorityWeightedTrunkGroupList = value;
            }
        }

        [XmlIgnore]
        protected bool PriorityWeightedTrunkGroupListSpecified { get; set; }

    }
}
