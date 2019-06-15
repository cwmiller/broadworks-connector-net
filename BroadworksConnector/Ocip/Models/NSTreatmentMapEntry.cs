using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The NS treatment map entry.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class NSTreatmentMapEntry 
    {

        
        private string _nsTreatment;

        [XmlElement(ElementName = "nsTreatment", IsNullable = false, Namespace = "")]
        public string NsTreatment {
            get => _nsTreatment;
            set {
                NsTreatmentSpecified = true;
                _nsTreatment = value;
            }
        }

        [XmlIgnore]
        public bool NsTreatmentSpecified { get; set; }
        
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
