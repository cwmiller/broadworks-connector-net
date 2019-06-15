using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the system's DTMF based in-call service activation trigger attributes.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Replaced by: SystemInCallServiceActivationModifyRequest17
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemInCallServiceActivationModifyRequest17"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemInCallServiceActivationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _defaultActivationDigits;

        [XmlElement(ElementName = "defaultActivationDigits", IsNullable = false, Namespace = "")]
        public string DefaultActivationDigits {
            get => _defaultActivationDigits;
            set {
                DefaultActivationDigitsSpecified = true;
                _defaultActivationDigits = value;
            }
        }

        [XmlIgnore]
        public bool DefaultActivationDigitsSpecified { get; set; }
        
    }
}
