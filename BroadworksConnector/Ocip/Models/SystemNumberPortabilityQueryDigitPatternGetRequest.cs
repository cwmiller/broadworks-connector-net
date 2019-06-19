using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:11982""}]")]
    public class SystemNumberPortabilityQueryDigitPatternGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _digitPattern;

        [XmlElement(ElementName = "digitPattern", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11982")]
        [MinLength(1)]
        [MaxLength(160)]
        public string DigitPattern
        {
            get => _digitPattern;
            set
            {
                DigitPatternSpecified = true;
                _digitPattern = value;
            }
        }

        [XmlIgnore]
        public bool DigitPatternSpecified { get; set; }

    }
}
