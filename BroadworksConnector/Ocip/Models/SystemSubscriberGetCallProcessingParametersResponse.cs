using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemSubscriberGetCallProcessingParametersRequest.
    /// Replaced By: SystemSubscriberGetCallProcessingParametersResponse14sp3
        /// <see cref="SystemSubscriberGetCallProcessingParametersRequest"/>
        /// <see cref="SystemSubscriberGetCallProcessingParametersResponse14sp3"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSubscriberGetCallProcessingParametersResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.SystemUserCallingLineIdSelection _userCallingLineIdSelection;

        [XmlElement(ElementName = "userCallingLineIdSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SystemUserCallingLineIdSelection UserCallingLineIdSelection {
            get => _userCallingLineIdSelection;
            set {
                UserCallingLineIdSelectionSpecified = true;
                _userCallingLineIdSelection = value;
            }
        }

        [XmlIgnore]
        public bool UserCallingLineIdSelectionSpecified { get; set; }
        
        private bool _isExtendedCallingLineIdActive;

        [XmlElement(ElementName = "isExtendedCallingLineIdActive", IsNullable = false, Namespace = "")]
        public bool IsExtendedCallingLineIdActive {
            get => _isExtendedCallingLineIdActive;
            set {
                IsExtendedCallingLineIdActiveSpecified = true;
                _isExtendedCallingLineIdActive = value;
            }
        }

        [XmlIgnore]
        public bool IsExtendedCallingLineIdActiveSpecified { get; set; }
        
        private bool _isRingTimeOutActive;

        [XmlElement(ElementName = "isRingTimeOutActive", IsNullable = false, Namespace = "")]
        public bool IsRingTimeOutActive {
            get => _isRingTimeOutActive;
            set {
                IsRingTimeOutActiveSpecified = true;
                _isRingTimeOutActive = value;
            }
        }

        [XmlIgnore]
        public bool IsRingTimeOutActiveSpecified { get; set; }
        
        private int _ringTimeoutSeconds;

        [XmlElement(ElementName = "ringTimeoutSeconds", IsNullable = false, Namespace = "")]
        public int RingTimeoutSeconds {
            get => _ringTimeoutSeconds;
            set {
                RingTimeoutSecondsSpecified = true;
                _ringTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        public bool RingTimeoutSecondsSpecified { get; set; }
        
    }
}
