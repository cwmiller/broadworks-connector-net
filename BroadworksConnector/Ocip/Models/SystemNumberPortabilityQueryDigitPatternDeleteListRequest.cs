using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to delete a list of System Number Portability Status Digit Pattern mappings.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNumberPortabilityQueryDigitPatternDeleteListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private List<string> _digitPattern;

        [XmlElement(ElementName = "digitPattern", IsNullable = false, Namespace = "")]
        public List<string> DigitPattern {
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
