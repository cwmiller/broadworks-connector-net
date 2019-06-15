using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a System Number Portability Query Status Digit Pattern mapping.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNumberPortabilityQueryDigitPatternAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _digitPattern;

        [XmlElement(ElementName = "digitPattern", IsNullable = false, Namespace = "")]
        public string DigitPattern {
            get => _digitPattern;
            set {
                DigitPatternSpecified = true;
                _digitPattern = value;
            }
        }

        [XmlIgnore]
        public bool DigitPatternSpecified { get; set; }
        
        private string _status;

        [XmlElement(ElementName = "status", IsNullable = false, Namespace = "")]
        public string Status {
            get => _status;
            set {
                StatusSpecified = true;
                _status = value;
            }
        }

        [XmlIgnore]
        public bool StatusSpecified { get; set; }
        
    }
}
