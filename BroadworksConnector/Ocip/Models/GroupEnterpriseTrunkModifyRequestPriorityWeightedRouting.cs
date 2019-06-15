using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupEnterpriseTrunkModifyRequestPriorityWeightedRouting 
    {

        
        private int _maximumRerouteAttemptsWithinPriority;

        [XmlElement(ElementName = "maximumRerouteAttemptsWithinPriority", IsNullable = false, Namespace = "")]
        public int MaximumRerouteAttemptsWithinPriority {
            get => _maximumRerouteAttemptsWithinPriority;
            set {
                MaximumRerouteAttemptsWithinPrioritySpecified = true;
                _maximumRerouteAttemptsWithinPriority = value;
            }
        }

        [XmlIgnore]
        public bool MaximumRerouteAttemptsWithinPrioritySpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ReplacementGroupEnterpriseTrunkPriorityWeightedTrunkGroupList _priorityWeightedTrunkGroupList;

        [XmlElement(ElementName = "priorityWeightedTrunkGroupList", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ReplacementGroupEnterpriseTrunkPriorityWeightedTrunkGroupList PriorityWeightedTrunkGroupList {
            get => _priorityWeightedTrunkGroupList;
            set {
                PriorityWeightedTrunkGroupListSpecified = true;
                _priorityWeightedTrunkGroupList = value;
            }
        }

        [XmlIgnore]
        public bool PriorityWeightedTrunkGroupListSpecified { get; set; }
        
    }
}
