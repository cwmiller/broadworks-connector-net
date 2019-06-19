using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserSimultaneousRingPersonalGetPhoneNumberRequest.
    /// <see cref="UserSimultaneousRingPersonalGetPhoneNumberRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:17661""}]")]
    public class UserSimultaneousRingPersonalGetPhoneNumberResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _answerConfirmationRequired;

        [XmlElement(ElementName = "answerConfirmationRequired", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17661")]
        public bool AnswerConfirmationRequired
        {
            get => _answerConfirmationRequired;
            set
            {
                AnswerConfirmationRequiredSpecified = true;
                _answerConfirmationRequired = value;
            }
        }

        [XmlIgnore]
        public bool AnswerConfirmationRequiredSpecified { get; set; }

    }
}
