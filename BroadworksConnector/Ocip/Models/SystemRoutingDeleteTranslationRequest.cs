using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to delete a digit routing table entry from the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:15292""}]")]
    public class SystemRoutingDeleteTranslationRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _digits;

        [XmlElement(ElementName = "digits", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:15292")]
        [MinLength(1)]
        [MaxLength(6)]
        public string Digits
        {
            get => _digits;
            set
            {
                DigitsSpecified = true;
                _digits = value;
            }
        }

        [XmlIgnore]
        protected bool DigitsSpecified { get; set; }

    }
}
