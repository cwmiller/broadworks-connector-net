using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The Automatic Collect Call prefix digits entry.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class AutomaticCollectCallPrefixDigitsEntry 
    {

        
        private string _countryCode;

        [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
        public string CountryCode {
            get => _countryCode;
            set {
                CountryCodeSpecified = true;
                _countryCode = value;
            }
        }

        [XmlIgnore]
        public bool CountryCodeSpecified { get; set; }
        
        private string _prefixDigits;

        [XmlElement(ElementName = "prefixDigits", IsNullable = false, Namespace = "")]
        public string PrefixDigits {
            get => _prefixDigits;
            set {
                PrefixDigitsSpecified = true;
                _prefixDigits = value;
            }
        }

        [XmlIgnore]
        public bool PrefixDigitsSpecified { get; set; }
        
    }
}
