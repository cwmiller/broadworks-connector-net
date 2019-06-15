using System;
using System.Xml.Serialization;
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
     
    public class SystemExpensiveCallTypeModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _alternateCallIndicator;

        [XmlElement(ElementName = "alternateCallIndicator", IsNullable = false, Namespace = "")]
        public string AlternateCallIndicator {
            get => _alternateCallIndicator;
            set {
                AlternateCallIndicatorSpecified = true;
                _alternateCallIndicator = value;
            }
        }

        [XmlIgnore]
        public bool AlternateCallIndicatorSpecified { get; set; }
        
        private string _treatmentAudioFile;

        [XmlElement(ElementName = "treatmentAudioFile", IsNullable = true, Namespace = "")]
        public string TreatmentAudioFile {
            get => _treatmentAudioFile;
            set {
                TreatmentAudioFileSpecified = true;
                _treatmentAudioFile = value;
            }
        }

        [XmlIgnore]
        public bool TreatmentAudioFileSpecified { get; set; }
        
    }
}
