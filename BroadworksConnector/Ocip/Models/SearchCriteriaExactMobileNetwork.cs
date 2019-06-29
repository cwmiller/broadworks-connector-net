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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:1015""}]")]
    public class SearchCriteriaExactMobileNetwork : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        private string _mobileNetworkName;

        [XmlElement(ElementName = "mobileNetworkName", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:1015")]
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
