using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Fax Messaging.
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// statusDurationHours
    /// statusAuditIntervalHours
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemFaxMessagingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private int _statusDurationHours;

        [XmlElement(ElementName = "statusDurationHours", IsNullable = false, Namespace = "")]
        public int StatusDurationHours {
            get => _statusDurationHours;
            set {
                StatusDurationHoursSpecified = true;
                _statusDurationHours = value;
            }
        }

        [XmlIgnore]
        public bool StatusDurationHoursSpecified { get; set; }
        
        private int _statusAuditIntervalHours;

        [XmlElement(ElementName = "statusAuditIntervalHours", IsNullable = false, Namespace = "")]
        public int StatusAuditIntervalHours {
            get => _statusAuditIntervalHours;
            set {
                StatusAuditIntervalHoursSpecified = true;
                _statusAuditIntervalHours = value;
            }
        }

        [XmlIgnore]
        public bool StatusAuditIntervalHoursSpecified { get; set; }
        
        private int _maximumConcurrentFaxesPerUser;

        [XmlElement(ElementName = "maximumConcurrentFaxesPerUser", IsNullable = false, Namespace = "")]
        public int MaximumConcurrentFaxesPerUser {
            get => _maximumConcurrentFaxesPerUser;
            set {
                MaximumConcurrentFaxesPerUserSpecified = true;
                _maximumConcurrentFaxesPerUser = value;
            }
        }

        [XmlIgnore]
        public bool MaximumConcurrentFaxesPerUserSpecified { get; set; }
        
    }
}
