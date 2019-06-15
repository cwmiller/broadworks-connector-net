using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This is the configuration parameters for Call Transfer service
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ProfileAndServiceCallTransferInfo 
    {

        
        private bool _isRecallActive;

        [XmlElement(ElementName = "isRecallActive", IsNullable = false, Namespace = "")]
        public bool IsRecallActive {
            get => _isRecallActive;
            set {
                IsRecallActiveSpecified = true;
                _isRecallActive = value;
            }
        }

        [XmlIgnore]
        public bool IsRecallActiveSpecified { get; set; }
        
        private int _recallNumberOfRings;

        [XmlElement(ElementName = "recallNumberOfRings", IsNullable = false, Namespace = "")]
        public int RecallNumberOfRings {
            get => _recallNumberOfRings;
            set {
                RecallNumberOfRingsSpecified = true;
                _recallNumberOfRings = value;
            }
        }

        [XmlIgnore]
        public bool RecallNumberOfRingsSpecified { get; set; }
        
        private bool _useDiversionInhibitorForBlindTransfer;

        [XmlElement(ElementName = "useDiversionInhibitorForBlindTransfer", IsNullable = false, Namespace = "")]
        public bool UseDiversionInhibitorForBlindTransfer {
            get => _useDiversionInhibitorForBlindTransfer;
            set {
                UseDiversionInhibitorForBlindTransferSpecified = true;
                _useDiversionInhibitorForBlindTransfer = value;
            }
        }

        [XmlIgnore]
        public bool UseDiversionInhibitorForBlindTransferSpecified { get; set; }
        
        private bool _useDiversionInhibitorForConsultativeCalls;

        [XmlElement(ElementName = "useDiversionInhibitorForConsultativeCalls", IsNullable = false, Namespace = "")]
        public bool UseDiversionInhibitorForConsultativeCalls {
            get => _useDiversionInhibitorForConsultativeCalls;
            set {
                UseDiversionInhibitorForConsultativeCallsSpecified = true;
                _useDiversionInhibitorForConsultativeCalls = value;
            }
        }

        [XmlIgnore]
        public bool UseDiversionInhibitorForConsultativeCallsSpecified { get; set; }
        
        private bool _enableBusyCampOn;

        [XmlElement(ElementName = "enableBusyCampOn", IsNullable = false, Namespace = "")]
        public bool EnableBusyCampOn {
            get => _enableBusyCampOn;
            set {
                EnableBusyCampOnSpecified = true;
                _enableBusyCampOn = value;
            }
        }

        [XmlIgnore]
        public bool EnableBusyCampOnSpecified { get; set; }
        
        private int _busyCampOnSeconds;

        [XmlElement(ElementName = "busyCampOnSeconds", IsNullable = false, Namespace = "")]
        public int BusyCampOnSeconds {
            get => _busyCampOnSeconds;
            set {
                BusyCampOnSecondsSpecified = true;
                _busyCampOnSeconds = value;
            }
        }

        [XmlIgnore]
        public bool BusyCampOnSecondsSpecified { get; set; }
        
    }
}
