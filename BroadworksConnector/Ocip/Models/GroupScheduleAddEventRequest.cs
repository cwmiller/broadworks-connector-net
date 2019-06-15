using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add an event to group schedule.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
    /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupScheduleAddEventRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId {
            get => _groupId;
            set {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
        
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
        
        private string _startDate;

        [XmlElement(ElementName = "startDate", IsNullable = false, Namespace = "")]
        public string StartDate {
            get => _startDate;
            set {
                StartDateSpecified = true;
                _startDate = value;
            }
        }

        [XmlIgnore]
        public bool StartDateSpecified { get; set; }
        
        private bool _allDayEvent;

        [XmlElement(ElementName = "allDayEvent", IsNullable = false, Namespace = "")]
        public bool AllDayEvent {
            get => _allDayEvent;
            set {
                AllDayEventSpecified = true;
                _allDayEvent = value;
            }
        }

        [XmlIgnore]
        public bool AllDayEventSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.HourMinute _startTime;

        [XmlElement(ElementName = "startTime", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.HourMinute StartTime {
            get => _startTime;
            set {
                StartTimeSpecified = true;
                _startTime = value;
            }
        }

        [XmlIgnore]
        public bool StartTimeSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.HourMinute _endTime;

        [XmlElement(ElementName = "endTime", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.HourMinute EndTime {
            get => _endTime;
            set {
                EndTimeSpecified = true;
                _endTime = value;
            }
        }

        [XmlIgnore]
        public bool EndTimeSpecified { get; set; }
        
        private string _endDate;

        [XmlElement(ElementName = "endDate", IsNullable = false, Namespace = "")]
        public string EndDate {
            get => _endDate;
            set {
                EndDateSpecified = true;
                _endDate = value;
            }
        }

        [XmlIgnore]
        public bool EndDateSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.Recurrence _recurrence;

        [XmlElement(ElementName = "recurrence", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.Recurrence Recurrence {
            get => _recurrence;
            set {
                RecurrenceSpecified = true;
                _recurrence = value;
            }
        }

        [XmlIgnore]
        public bool RecurrenceSpecified { get; set; }
        
    }
}
