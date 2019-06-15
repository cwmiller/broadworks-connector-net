using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSessionAuditGetRequest.
    /// Replaced By: SystemSessionAuditGetResponse14sp3
        /// <see cref="SystemSessionAuditGetRequest"/>
        /// <see cref="SystemSessionAuditGetResponse14sp3"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSessionAuditGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        public bool IsActive {
            get => _isActive;
            set {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }
        
        private int _intervalSeconds;

        [XmlElement(ElementName = "intervalSeconds", IsNullable = false, Namespace = "")]
        public int IntervalSeconds {
            get => _intervalSeconds;
            set {
                IntervalSecondsSpecified = true;
                _intervalSeconds = value;
            }
        }

        [XmlIgnore]
        public bool IntervalSecondsSpecified { get; set; }
        
        private int _timeoutPeriodSeconds;

        [XmlElement(ElementName = "timeoutPeriodSeconds", IsNullable = false, Namespace = "")]
        public int TimeoutPeriodSeconds {
            get => _timeoutPeriodSeconds;
            set {
                TimeoutPeriodSecondsSpecified = true;
                _timeoutPeriodSeconds = value;
            }
        }

        [XmlIgnore]
        public bool TimeoutPeriodSecondsSpecified { get; set; }
        
    }
}
