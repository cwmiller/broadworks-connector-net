using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseTrunkPriorityWeightedTrunkGroup
    {
        private BroadworksConnector.Ocip.Models.EnterpriseTrunkTrunkGroupKey _trunkGroup;

        [XmlElement(ElementName = "trunkGroup", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.EnterpriseTrunkTrunkGroupKey TrunkGroup
        {
            get => _trunkGroup;
            set
            {
                TrunkGroupSpecified = true;
                _trunkGroup = value;
            }
        }

        [XmlIgnore]
        public bool TrunkGroupSpecified { get; set; }
        private int _priority;

        [XmlElement(ElementName = "priority", IsNullable = false, Namespace = "")]
        public int Priority
        {
            get => _priority;
            set
            {
                PrioritySpecified = true;
                _priority = value;
            }
        }

        [XmlIgnore]
        public bool PrioritySpecified { get; set; }
        private int _weight;

        [XmlElement(ElementName = "weight", IsNullable = false, Namespace = "")]
        public int Weight
        {
            get => _weight;
            set
            {
                WeightSpecified = true;
                _weight = value;
            }
        }

        [XmlIgnore]
        public bool WeightSpecified { get; set; }
    }
}
