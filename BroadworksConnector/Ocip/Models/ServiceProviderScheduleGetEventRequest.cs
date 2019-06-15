using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get an event from a service provider schedule.
    /// The response is either a ServiceProviderScheduleGetEventResponse or an ErrorResponse.
        /// <see cref="ServiceProviderScheduleGetEventResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderScheduleGetEventRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ScheduleKey _scheduleKey;

        [XmlElement(ElementName = "scheduleKey", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ScheduleKey ScheduleKey {
            get => _scheduleKey;
            set {
                ScheduleKeySpecified = true;
                _scheduleKey = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleKeySpecified { get; set; }
        
        private string _eventName;

        [XmlElement(ElementName = "eventName", IsNullable = false, Namespace = "")]
        public string EventName {
            get => _eventName;
            set {
                EventNameSpecified = true;
                _eventName = value;
            }
        }

        [XmlIgnore]
        public bool EventNameSpecified { get; set; }
        
    }
}
