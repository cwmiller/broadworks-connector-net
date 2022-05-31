using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk group details (order and weight) for each trunk group
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:1949""}]")]
    public class GroupEnterpriseTrunkPriorityWeightedTrunkGroup
    {

        protected string _trunkGroup;

        [XmlElement(ElementName = "trunkGroup", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1949")]
        [MinLength(1)]
        [MaxLength(30)]
        public string TrunkGroup
        {
            get => _trunkGroup;
            set
            {
                TrunkGroupSpecified = true;
                _trunkGroup = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupSpecified { get; set; }

        protected int _priority;

        [XmlElement(ElementName = "priority", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1949")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
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
        protected bool PrioritySpecified { get; set; }

        protected int _weight;

        [XmlElement(ElementName = "weight", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1949")]
        [MinInclusive(1)]
        [MaxInclusive(65536)]
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
        protected bool WeightSpecified { get; set; }

    }
}
