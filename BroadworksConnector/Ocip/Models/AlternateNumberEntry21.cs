using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Alternate Number Entry.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class AlternateNumberEntry21 
    {

        
        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = true, Namespace = "")]
        public string PhoneNumber {
            get => _phoneNumber;
            set {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberSpecified { get; set; }
        
        private string _extension;

        [XmlElement(ElementName = "extension", IsNullable = true, Namespace = "")]
        public string Extension {
            get => _extension;
            set {
                ExtensionSpecified = true;
                _extension = value;
            }
        }

        [XmlIgnore]
        public bool ExtensionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.RingPattern? _ringPattern;

        [XmlElement(ElementName = "ringPattern", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.RingPattern? RingPattern {
            get => _ringPattern;
            set {
                RingPatternSpecified = true;
                _ringPattern = value;
            }
        }

        [XmlIgnore]
        public bool RingPatternSpecified { get; set; }
        
        private string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        public string Description {
            get => _description;
            set {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }
        
    }
}
