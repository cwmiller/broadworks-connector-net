using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a System Number Portability Status Digit Pattern mapping.
    /// The response is either a SystemNumberPortabilityQueryDigitPatternGetResponse or an ErrorResponse.
        /// <see cref="SystemNumberPortabilityQueryDigitPatternGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNumberPortabilityQueryDigitPatternGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
    }
}
