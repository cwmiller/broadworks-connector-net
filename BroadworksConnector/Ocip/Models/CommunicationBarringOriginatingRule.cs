using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Communication Barring Originating Rule
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CommunicationBarringOriginatingRule 
    {

        
        private string _criteria;

        [XmlElement(ElementName = "criteria", IsNullable = false, Namespace = "")]
        public string Criteria {
            get => _criteria;
            set {
                CriteriaSpecified = true;
                _criteria = value;
            }
        }

        [XmlIgnore]
        public bool CriteriaSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingAction _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingAction Action {
            get => _action;
            set {
                ActionSpecified = true;
                _action = value;
            }
        }

        [XmlIgnore]
        public bool ActionSpecified { get; set; }
        
        private string _treatmentId;

        [XmlElement(ElementName = "treatmentId", IsNullable = true, Namespace = "")]
        public string TreatmentId {
            get => _treatmentId;
            set {
                TreatmentIdSpecified = true;
                _treatmentId = value;
            }
        }

        [XmlIgnore]
        public bool TreatmentIdSpecified { get; set; }
        
        private string _transferNumber;

        [XmlElement(ElementName = "transferNumber", IsNullable = true, Namespace = "")]
        public string TransferNumber {
            get => _transferNumber;
            set {
                TransferNumberSpecified = true;
                _transferNumber = value;
            }
        }

        [XmlIgnore]
        public bool TransferNumberSpecified { get; set; }
        
        private int? _callTimeoutSeconds;

        [XmlElement(ElementName = "callTimeoutSeconds", IsNullable = true, Namespace = "")]
        public int? CallTimeoutSeconds {
            get => _callTimeoutSeconds;
            set {
                CallTimeoutSecondsSpecified = true;
                _callTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        public bool CallTimeoutSecondsSpecified { get; set; }
        
    }
}
