using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserSimultaneousRingFamilyGetPhoneNumberRequest.
        /// <see cref="UserSimultaneousRingFamilyGetPhoneNumberRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserSimultaneousRingFamilyGetPhoneNumberResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _answerConfirmationRequired;

        [XmlElement(ElementName = "answerConfirmationRequired", IsNullable = false, Namespace = "")]
        public bool AnswerConfirmationRequired {
            get => _answerConfirmationRequired;
            set {
                AnswerConfirmationRequiredSpecified = true;
                _answerConfirmationRequired = value;
            }
        }

        [XmlIgnore]
        public bool AnswerConfirmationRequiredSpecified { get; set; }
        
    }
}
