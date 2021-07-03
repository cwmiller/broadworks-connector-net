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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:829""}]")]
    public class GroupEnterpriseTrunkGetResponse22OrderedRouting
    {

        private List<BroadWorksConnector.Ocip.Models.EnterpriseTrunkTrunkGroupKey> _trunkGroup = new List<BroadWorksConnector.Ocip.Models.EnterpriseTrunkTrunkGroupKey>();

        [XmlElement(ElementName = "trunkGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:829")]
        public List<BroadWorksConnector.Ocip.Models.EnterpriseTrunkTrunkGroupKey> TrunkGroup
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

        private BroadWorksConnector.Ocip.Models.EnterpriseTrunkOrderingAlgorithm _orderingAlgorithm;

        [XmlElement(ElementName = "orderingAlgorithm", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:829")]
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
