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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:9963""}]")]
    public class SystemExpensiveCallTypeAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _alternateCallIndicator;

        [XmlElement(ElementName = "alternateCallIndicator", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:9963")]
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

        protected string _treatmentAudioFile;

        [XmlElement(ElementName = "treatmentAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:9963")]
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
