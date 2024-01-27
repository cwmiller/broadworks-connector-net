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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:440""}]")]
    public class EnterpriseEnterpriseTrunkModifyRequestOrderedRouting
    {

        protected BroadWorksConnector.Ocip.Models.ReplacementEnterpriseEnterpriseTrunkTrunkGroupKeyList _trunkGroupList;

        [XmlElement(ElementName = "trunkGroupList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:440")]
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

        protected BroadWorksConnector.Ocip.Models.EnterpriseTrunkOrderingAlgorithm _orderingAlgorithm;

        [XmlElement(ElementName = "orderingAlgorithm", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:440")]
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
