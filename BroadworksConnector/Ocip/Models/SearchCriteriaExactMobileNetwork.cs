using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular BroadWorks Mobility Mobile Network.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:1138""}]")]
    public class SearchCriteriaExactMobileNetwork : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected string _mobileNetworkName;

        [XmlElement(ElementName = "mobileNetworkName", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:1138")]
        [MinLength(1)]
        [MaxLength(80)]
        public string MobileNetworkName
        {
            get => _mobileNetworkName;
            set
            {
                MobileNetworkNameSpecified = true;
                _mobileNetworkName = value;
            }
        }

        [XmlIgnore]
        protected bool MobileNetworkNameSpecified { get; set; }

    }
}
