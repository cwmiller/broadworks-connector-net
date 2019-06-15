using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get all the attributes of a configurable treatment.
    /// The response is either a SystemConfigurableTreatmentGetResponse or an ErrorResponse.
    /// Replaced By: SystemConfigurableTreatmentGetRequest16
        /// <see cref="SystemConfigurableTreatmentGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemConfigurableTreatmentGetRequest16"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemConfigurableTreatmentGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _treatmentId;

        [XmlElement(ElementName = "treatmentId", IsNullable = false, Namespace = "")]
        public string TreatmentId {
            get => _treatmentId;
            set {
                TreatmentIdSpecified = true;
                _treatmentId = value;
            }
        }

        [XmlIgnore]
        public bool TreatmentIdSpecified { get; set; }
        
    }
}
