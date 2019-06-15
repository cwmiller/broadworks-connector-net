using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The call type mapping entry.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CallTypeMappingEntry 
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
        
        private string _digitMap;

        [XmlElement(ElementName = "digitMap", IsNullable = false, Namespace = "")]
        public string DigitMap {
            get => _digitMap;
            set {
                DigitMapSpecified = true;
                _digitMap = value;
            }
        }

        [XmlIgnore]
        public bool DigitMapSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SystemCallType _callType;

        [XmlElement(ElementName = "callType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemCallType CallType {
            get => _callType;
            set {
                CallTypeSpecified = true;
                _callType = value;
            }
        }

        [XmlIgnore]
        public bool CallTypeSpecified { get; set; }
        
    }
}
