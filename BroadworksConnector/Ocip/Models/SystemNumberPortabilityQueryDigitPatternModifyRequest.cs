using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a System Number Portability Status Digit Pattern mapping.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13140""}]")]
    public class SystemNumberPortabilityQueryDigitPatternModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _digitPattern;

        [XmlElement(ElementName = "digitPattern", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13140")]
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
        protected bool DigitPatternSpecified { get; set; }

        private string _newDigitPattern;

        [XmlElement(ElementName = "newDigitPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13140")]
        [MinLength(1)]
        [MaxLength(160)]
        public string NewDigitPattern
        {
            get => _newDigitPattern;
            set
            {
                NewDigitPatternSpecified = true;
                _newDigitPattern = value;
            }
        }

        [XmlIgnore]
        protected bool NewDigitPatternSpecified { get; set; }

        private string _status;

        [XmlElement(ElementName = "status", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13140")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Status
        {
            get => _status;
            set
            {
                StatusSpecified = true;
                _status = value;
            }
        }

        [XmlIgnore]
        protected bool StatusSpecified { get; set; }

    }
}
