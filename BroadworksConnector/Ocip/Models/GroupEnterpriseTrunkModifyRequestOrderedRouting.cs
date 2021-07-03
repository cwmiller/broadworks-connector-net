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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:926""}]")]
    public class GroupEnterpriseTrunkModifyRequestOrderedRouting
    {

        private BroadWorksConnector.Ocip.Models.ReplacementGroupEnterpriseTrunkTrunkGroupList _trunkGroupList;

        [XmlElement(ElementName = "trunkGroupList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:926")]
        public BroadWorksConnector.Ocip.Models.ReplacementGroupEnterpriseTrunkTrunkGroupList TrunkGroupList
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

        private BroadWorksConnector.Ocip.Models.EnterpriseTrunkOrderingAlgorithm _orderingAlgorithm;

        [XmlElement(ElementName = "orderingAlgorithm", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:926")]
        public BroadWorksConnector.Ocip.Models.EnterpriseTrunkOrderingAlgorithm OrderingAlgorithm
        {
            get => _orderingAlgorithm;
            set
            {
                OrderingAlgorithmSpecified = true;
                _orderingAlgorithm = value;
            }
        }

        [XmlIgnore]
        protected bool OrderingAlgorithmSpecified { get; set; }

    }
}
