using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a configurable treatment.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemConfigurableTreatmentAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private BroadWorksConnector.Ocip.Models.ChargeIndicator _chargeIndicator;

        [XmlElement(ElementName = "chargeIndicator", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ChargeIndicator ChargeIndicator {
            get => _chargeIndicator;
            set {
                ChargeIndicatorSpecified = true;
                _chargeIndicator = value;
            }
        }

        [XmlIgnore]
        public bool ChargeIndicatorSpecified { get; set; }
        
        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        public string Description {
            get => _description;
            set {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }
        
        private int _accessSIPStatusCode;

        [XmlElement(ElementName = "accessSIPStatusCode", IsNullable = false, Namespace = "")]
        public int AccessSIPStatusCode {
            get => _accessSIPStatusCode;
            set {
                AccessSIPStatusCodeSpecified = true;
                _accessSIPStatusCode = value;
            }
        }

        [XmlIgnore]
        public bool AccessSIPStatusCodeSpecified { get; set; }
        
        private string _accessSIPStatusMessage;

        [XmlElement(ElementName = "accessSIPStatusMessage", IsNullable = false, Namespace = "")]
        public string AccessSIPStatusMessage {
            get => _accessSIPStatusMessage;
            set {
                AccessSIPStatusMessageSpecified = true;
                _accessSIPStatusMessage = value;
            }
        }

        [XmlIgnore]
        public bool AccessSIPStatusMessageSpecified { get; set; }
        
        private int _networkSIPStatusCode;

        [XmlElement(ElementName = "networkSIPStatusCode", IsNullable = false, Namespace = "")]
        public int NetworkSIPStatusCode {
            get => _networkSIPStatusCode;
            set {
                NetworkSIPStatusCodeSpecified = true;
                _networkSIPStatusCode = value;
            }
        }

        [XmlIgnore]
        public bool NetworkSIPStatusCodeSpecified { get; set; }
        
        private string _networkSIPStatusMessage;

        [XmlElement(ElementName = "networkSIPStatusMessage", IsNullable = false, Namespace = "")]
        public string NetworkSIPStatusMessage {
            get => _networkSIPStatusMessage;
            set {
                NetworkSIPStatusMessageSpecified = true;
                _networkSIPStatusMessage = value;
            }
        }

        [XmlIgnore]
        public bool NetworkSIPStatusMessageSpecified { get; set; }
        
        private int _q850CauseValue;

        [XmlElement(ElementName = "q850CauseValue", IsNullable = false, Namespace = "")]
        public int Q850CauseValue {
            get => _q850CauseValue;
            set {
                Q850CauseValueSpecified = true;
                _q850CauseValue = value;
            }
        }

        [XmlIgnore]
        public bool Q850CauseValueSpecified { get; set; }
        
        private string _q850Text;

        [XmlElement(ElementName = "q850Text", IsNullable = false, Namespace = "")]
        public string Q850Text {
            get => _q850Text;
            set {
                Q850TextSpecified = true;
                _q850Text = value;
            }
        }

        [XmlIgnore]
        public bool Q850TextSpecified { get; set; }
        
        private string _accessTreatmentAudioFile;

        [XmlElement(ElementName = "accessTreatmentAudioFile", IsNullable = false, Namespace = "")]
        public string AccessTreatmentAudioFile {
            get => _accessTreatmentAudioFile;
            set {
                AccessTreatmentAudioFileSpecified = true;
                _accessTreatmentAudioFile = value;
            }
        }

        [XmlIgnore]
        public bool AccessTreatmentAudioFileSpecified { get; set; }
        
        private string _accessTreatmentVideoFile;

        [XmlElement(ElementName = "accessTreatmentVideoFile", IsNullable = false, Namespace = "")]
        public string AccessTreatmentVideoFile {
            get => _accessTreatmentVideoFile;
            set {
                AccessTreatmentVideoFileSpecified = true;
                _accessTreatmentVideoFile = value;
            }
        }

        [XmlIgnore]
        public bool AccessTreatmentVideoFileSpecified { get; set; }
        
        private string _networkTreatmentAudioFile;

        [XmlElement(ElementName = "networkTreatmentAudioFile", IsNullable = false, Namespace = "")]
        public string NetworkTreatmentAudioFile {
            get => _networkTreatmentAudioFile;
            set {
                NetworkTreatmentAudioFileSpecified = true;
                _networkTreatmentAudioFile = value;
            }
        }

        [XmlIgnore]
        public bool NetworkTreatmentAudioFileSpecified { get; set; }
        
        private string _networkTreatmentVideoFile;

        [XmlElement(ElementName = "networkTreatmentVideoFile", IsNullable = false, Namespace = "")]
        public string NetworkTreatmentVideoFile {
            get => _networkTreatmentVideoFile;
            set {
                NetworkTreatmentVideoFileSpecified = true;
                _networkTreatmentVideoFile = value;
            }
        }

        [XmlIgnore]
        public bool NetworkTreatmentVideoFileSpecified { get; set; }
        
        private string _cdrTerminationCause;

        [XmlElement(ElementName = "cdrTerminationCause", IsNullable = false, Namespace = "")]
        public string CdrTerminationCause {
            get => _cdrTerminationCause;
            set {
                CdrTerminationCauseSpecified = true;
                _cdrTerminationCause = value;
            }
        }

        [XmlIgnore]
        public bool CdrTerminationCauseSpecified { get; set; }
        
        private bool _routeAdvance;

        [XmlElement(ElementName = "routeAdvance", IsNullable = false, Namespace = "")]
        public bool RouteAdvance {
            get => _routeAdvance;
            set {
                RouteAdvanceSpecified = true;
                _routeAdvance = value;
            }
        }

        [XmlIgnore]
        public bool RouteAdvanceSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.InternalReleaseCause16 _internalReleaseCause;

        [XmlElement(ElementName = "internalReleaseCause", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.InternalReleaseCause16 InternalReleaseCause {
            get => _internalReleaseCause;
            set {
                InternalReleaseCauseSpecified = true;
                _internalReleaseCause = value;
            }
        }

        [XmlIgnore]
        public bool InternalReleaseCauseSpecified { get; set; }
        
        private bool _accessSendReasonHeader;

        [XmlElement(ElementName = "accessSendReasonHeader", IsNullable = false, Namespace = "")]
        public bool AccessSendReasonHeader {
            get => _accessSendReasonHeader;
            set {
                AccessSendReasonHeaderSpecified = true;
                _accessSendReasonHeader = value;
            }
        }

        [XmlIgnore]
        public bool AccessSendReasonHeaderSpecified { get; set; }
        
        private bool _networkSendReasonHeader;

        [XmlElement(ElementName = "networkSendReasonHeader", IsNullable = false, Namespace = "")]
        public bool NetworkSendReasonHeader {
            get => _networkSendReasonHeader;
            set {
                NetworkSendReasonHeaderSpecified = true;
                _networkSendReasonHeader = value;
            }
        }

        [XmlIgnore]
        public bool NetworkSendReasonHeaderSpecified { get; set; }
        
    }
}
