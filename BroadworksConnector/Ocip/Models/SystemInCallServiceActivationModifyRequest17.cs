using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the system's DTMF based in-call service activation trigger  attributes.The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemInCallServiceActivationModifyRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _defaultFlashActivationDigits;

        [XmlElement(ElementName = "defaultFlashActivationDigits", IsNullable = false, Namespace = "")]
        public string DefaultFlashActivationDigits {
            get => _defaultFlashActivationDigits;
            set {
                DefaultFlashActivationDigitsSpecified = true;
                _defaultFlashActivationDigits = value;
            }
        }

        [XmlIgnore]
        public bool DefaultFlashActivationDigitsSpecified { get; set; }
        
        private string _defaultCallTransferActivationDigits;

        [XmlElement(ElementName = "defaultCallTransferActivationDigits", IsNullable = false, Namespace = "")]
        public string DefaultCallTransferActivationDigits {
            get => _defaultCallTransferActivationDigits;
            set {
                DefaultCallTransferActivationDigitsSpecified = true;
                _defaultCallTransferActivationDigits = value;
            }
        }

        [XmlIgnore]
        public bool DefaultCallTransferActivationDigitsSpecified { get; set; }
        
    }
}
