using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a system number portability status information.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNumberPortabilityQueryStatusAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _status;

        [XmlElement(ElementName = "status", IsNullable = false, Namespace = "")]
        public string Status {
            get => _status;
            set {
                StatusSpecified = true;
                _status = value;
            }
        }

        [XmlIgnore]
        public bool StatusSpecified { get; set; }
        
        private string _treatmentFileName;

        [XmlElement(ElementName = "treatmentFileName", IsNullable = false, Namespace = "")]
        public string TreatmentFileName {
            get => _treatmentFileName;
            set {
                TreatmentFileNameSpecified = true;
                _treatmentFileName = value;
            }
        }

        [XmlIgnore]
        public bool TreatmentFileNameSpecified { get; set; }
        
    }
}
