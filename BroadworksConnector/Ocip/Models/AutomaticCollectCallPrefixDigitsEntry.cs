using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The Automatic Collect Call prefix digits entry.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0d5db1a19a0aeda6f13d1f1c609efa0a:214""}]")]
    public class AutomaticCollectCallPrefixDigitsEntry
    {

        protected string _countryCode;

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        [Group(@"0d5db1a19a0aeda6f13d1f1c609efa0a:214")]
        [MaxLength(3)]
        [RegularExpression(@"[0-9]|[1-9][0-9]{1,2}")]
        public string CountryCode
        {
            get => _countryCode;
            set
            {
                CountryCodeSpecified = true;
                _countryCode = value;
            }
        }

        [XmlIgnore]
        protected bool CountryCodeSpecified { get; set; }

        protected string _prefixDigits;

        [XmlElement(ElementName = "prefixDigits", IsNullable = false, Namespace = "")]
        [Group(@"0d5db1a19a0aeda6f13d1f1c609efa0a:214")]
        [MinLength(1)]
        [MaxLength(30)]
        public string PrefixDigits
        {
            get => _prefixDigits;
            set
            {
                PrefixDigitsSpecified = true;
                _prefixDigits = value;
            }
        }

        [XmlIgnore]
        protected bool PrefixDigitsSpecified { get; set; }

    }
}
