using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify an existing call indicator in the list of expensive alternate call indicators.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:9910"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:9912""}]}]")]
    public class SystemExpensiveCallTypeModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _alternateCallIndicator;

        [XmlElement(ElementName = "alternateCallIndicator", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9910")]
        [MinLength(1)]
        [MaxLength(64)]
        public string AlternateCallIndicator
        {
            get => _alternateCallIndicator;
            set
            {
                AlternateCallIndicatorSpecified = true;
                _alternateCallIndicator = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateCallIndicatorSpecified { get; set; }

        private string _treatmentAudioFile;

        [XmlElement(ElementName = "treatmentAudioFile", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9912")]
        [MinLength(1)]
        [MaxLength(256)]
        public string TreatmentAudioFile
        {
            get => _treatmentAudioFile;
            set
            {
                TreatmentAudioFileSpecified = true;
                _treatmentAudioFile = value;
            }
        }

        [XmlIgnore]
        protected bool TreatmentAudioFileSpecified { get; set; }

    }
}
