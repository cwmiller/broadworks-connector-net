using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for digit pattern.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:501""}]")]
    public class SearchCriteriaDigitPattern : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        private BroadWorksConnector.Ocip.Models.SearchMode _mode;

        [XmlElement(ElementName = "mode", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:501")]
        public BroadWorksConnector.Ocip.Models.SearchMode Mode
        {
            get => _mode;
            set
            {
                ModeSpecified = true;
                _mode = value;
            }
        }

        [XmlIgnore]
        public bool ModeSpecified { get; set; }

        private string _value;

        [XmlElement(ElementName = "value", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:501")]
        [MinLength(1)]
        [MaxLength(160)]
        public string Value
        {
            get => _value;
            set
            {
                ValueSpecified = true;
                _value = value;
            }
        }

        [XmlIgnore]
        public bool ValueSpecified { get; set; }

        private bool _isCaseInsensitive;

        [XmlElement(ElementName = "isCaseInsensitive", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:501")]
        public bool IsCaseInsensitive
        {
            get => _isCaseInsensitive;
            set
            {
                IsCaseInsensitiveSpecified = true;
                _isCaseInsensitive = value;
            }
        }

        [XmlIgnore]
        public bool IsCaseInsensitiveSpecified { get; set; }

    }
}
