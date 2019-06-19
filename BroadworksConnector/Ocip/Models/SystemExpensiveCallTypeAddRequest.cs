using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add an alternate call indicator to the list of expensive alternate call indicators.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:8816""}]")]
    public class SystemExpensiveCallTypeAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _alternateCallIndicator;

        [XmlElement(ElementName = "alternateCallIndicator", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8816")]
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
        public bool AlternateCallIndicatorSpecified { get; set; }

        private string _treatmentAudioFile;

        [XmlElement(ElementName = "treatmentAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8816")]
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
        public bool TreatmentAudioFileSpecified { get; set; }

    }
}
