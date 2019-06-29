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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:429""}]")]
    public class EnterpriseEnterpriseTrunkModifyRequestOrderedRouting
    {

        private BroadWorksConnector.Ocip.Models.ReplacementEnterpriseEnterpriseTrunkTrunkGroupKeyList _trunkGroupList;

        [XmlElement(ElementName = "trunkGroupList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:429")]
        public BroadWorksConnector.Ocip.Models.ReplacementEnterpriseEnterpriseTrunkTrunkGroupKeyList TrunkGroupList
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
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:429")]
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
