using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of enterprise trunk priority weighted trunk groups in a group that replaces a previously configured list.
    /// By convention, an element of this type may be set nill to clear the list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:1932""}]")]
    public class ReplacementGroupEnterpriseTrunkPriorityWeightedTrunkGroupList
    {

        private List<BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkPriorityWeightedTrunkGroup> _trunkGroup = new List<BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkPriorityWeightedTrunkGroup>();

        [XmlElement(ElementName = "trunkGroup", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1932")]
        public List<BroadWorksConnector.Ocip.Models.GroupEnterpriseTrunkPriorityWeightedTrunkGroup> TrunkGroup
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

    }
}
