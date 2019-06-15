using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemFAXMessagingGetRequest.
    /// 
    /// The following elements are only used in AS data mode:
    /// statusDurationHours
    /// statusAuditIntervalHours
        /// <see cref="SystemFAXMessagingGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemFaxMessagingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
