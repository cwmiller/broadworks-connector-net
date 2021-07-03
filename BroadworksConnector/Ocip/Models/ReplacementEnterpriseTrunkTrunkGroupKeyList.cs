using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of Enterprise Trunk Krunk Group Keys that replaces a previously configured list.
    /// By convention, an element of this type may be set nill to clear the list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:1987""}]")]
    public class ReplacementEnterpriseTrunkTrunkGroupKeyList
    {

        private List<BroadWorksConnector.Ocip.Models.EnterpriseTrunkTrunkGroupKey> _trunkGroupList = new List<BroadWorksConnector.Ocip.Models.EnterpriseTrunkTrunkGroupKey>();

        [XmlElement(ElementName = "trunkGroupList", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1987")]
        public List<BroadWorksConnector.Ocip.Models.EnterpriseTrunkTrunkGroupKey> TrunkGroupList
        {
            get => _trunkGroupList;
            set
            {
                TrunkGroupListSpecified = true;
                _trunkGroupList = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupListSpecified { get; set; }

    }
}
