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
     
    public class EnterpriseEnterpriseTrunkGetResponse21PriorityWeightedRouting 
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
        
        private List<BroadWorksConnector.Ocip.Models.EnterpriseEnterpriseTrunkPriorityWeightedTrunkGroup> _priorityWeightedTrunkGroup;

        [XmlElement(ElementName = "priorityWeightedTrunkGroup", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.EnterpriseEnterpriseTrunkPriorityWeightedTrunkGroup> PriorityWeightedTrunkGroup {
            get => _priorityWeightedTrunkGroup;
            set {
                PriorityWeightedTrunkGroupSpecified = true;
                _priorityWeightedTrunkGroup = value;
            }
        }

        [XmlIgnore]
        public bool PriorityWeightedTrunkGroupSpecified { get; set; }
        
    }
}
