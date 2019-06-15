using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemSubscriberGetCallProcessingParametersRequest14sp7.
        /// <see cref="SystemSubscriberGetCallProcessingParametersRequest14sp7"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSubscriberGetCallProcessingParametersResponse14sp7 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
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
        
        private bool _allowEmergencyRemoteOfficeOriginations;

        [XmlElement(ElementName = "allowEmergencyRemoteOfficeOriginations", IsNullable = false, Namespace = "")]
        public bool AllowEmergencyRemoteOfficeOriginations {
            get => _allowEmergencyRemoteOfficeOriginations;
            set {
                AllowEmergencyRemoteOfficeOriginationsSpecified = true;
                _allowEmergencyRemoteOfficeOriginations = value;
            }
        }

        [XmlIgnore]
        public bool AllowEmergencyRemoteOfficeOriginationsSpecified { get; set; }
        
    }
}
