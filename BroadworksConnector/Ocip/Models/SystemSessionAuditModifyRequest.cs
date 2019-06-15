using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with session sudit.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Replaced By: SystemSessionAuditModifyRequest14sp3
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemSessionAuditModifyRequest14sp3"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSessionAuditModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
