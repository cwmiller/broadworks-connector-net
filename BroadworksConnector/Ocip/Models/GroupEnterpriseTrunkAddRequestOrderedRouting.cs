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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:9606""}]")]
    public class GroupEnterpriseTrunkAddRequestOrderedRouting
    {

        protected List<string> _trunkGroup = new List<string>();

        [XmlElement(ElementName = "trunkGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:9606")]
        [MinLength(1)]
        [MaxLength(30)]
        public List<string> TrunkGroup
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

        protected BroadWorksConnector.Ocip.Models.EnterpriseTrunkOrderingAlgorithm _orderingAlgorithm;

        [XmlElement(ElementName = "orderingAlgorithm", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:9606")]
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
