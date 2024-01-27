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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:934""}]")]
    public class GroupEnterpriseTrunkModifyRequestPriorityWeightedRouting
    {

        protected int _maximumRerouteAttemptsWithinPriority;

        [XmlElement(ElementName = "maximumRerouteAttemptsWithinPriority", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:934")]
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

        protected BroadWorksConnector.Ocip.Models.ReplacementGroupEnterpriseTrunkPriorityWeightedTrunkGroupList _priorityWeightedTrunkGroupList;

        [XmlElement(ElementName = "priorityWeightedTrunkGroupList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:934")]
        public BroadWorksConnector.Ocip.Models.ReplacementGroupEnterpriseTrunkPriorityWeightedTrunkGroupList PriorityWeightedTrunkGroupList
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
