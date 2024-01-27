using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify an event of a service provider schedule.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// The startDate element is adjusted to the first occurrence of the recurrent schedule that comes at or after the startDate.
    /// The endDate element is set to the sum of the adjusted starDate element value and the event duration.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:5939"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:5945"",""optional"":true,""children"":[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:5947""}]}]}]")]
    public class ServiceProviderScheduleModifyEventRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5939")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ScheduleKey _scheduleKey;

        [XmlElement(ElementName = "scheduleKey", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5939")]
        public BroadWorksConnector.Ocip.Models.ScheduleKey ScheduleKey
        {
            get => _scheduleKey;
            set
            {
                ScheduleKeySpecified = true;
                _scheduleKey = value;
            }
        }

        [XmlIgnore]
        protected bool ScheduleKeySpecified { get; set; }

        protected string _eventName;

        [XmlElement(ElementName = "eventName", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5939")]
        [MinLength(1)]
        [MaxLength(40)]
        public string EventName
        {
            get => _eventName;
            set
            {
                EventNameSpecified = true;
                _eventName = value;
            }
        }

        [XmlIgnore]
        protected bool EventNameSpecified { get; set; }

        protected string _newEventName;

        [XmlElement(ElementName = "newEventName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5939")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NewEventName
        {
            get => _newEventName;
            set
            {
                NewEventNameSpecified = true;
                _newEventName = value;
            }
        }

        [XmlIgnore]
        protected bool NewEventNameSpecified { get; set; }

        protected string _startDate;

        [XmlElement(ElementName = "startDate", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5939")]
        public string StartDate
        {
            get => _startDate;
            set
            {
                StartDateSpecified = true;
                _startDate = value;
            }
        }

        [XmlIgnore]
        protected bool StartDateSpecified { get; set; }

        protected bool _allDayEvent;

        [XmlElement(ElementName = "allDayEvent", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5945")]
        public bool AllDayEvent
        {
            get => _allDayEvent;
            set
            {
                AllDayEventSpecified = true;
                _allDayEvent = value;
            }
        }

        [XmlIgnore]
        protected bool AllDayEventSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.HourMinute _startTime;

        [XmlElement(ElementName = "startTime", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5947")]
        public BroadWorksConnector.Ocip.Models.HourMinute StartTime
        {
            get => _startTime;
            set
            {
                StartTimeSpecified = true;
                _startTime = value;
            }
        }

        [XmlIgnore]
        protected bool StartTimeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.HourMinute _endTime;

        [XmlElement(ElementName = "endTime", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5947")]
        public BroadWorksConnector.Ocip.Models.HourMinute EndTime
        {
            get => _endTime;
            set
            {
                EndTimeSpecified = true;
                _endTime = value;
            }
        }

        [XmlIgnore]
        protected bool EndTimeSpecified { get; set; }

        protected string _endDate;

        [XmlElement(ElementName = "endDate", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5939")]
        public string EndDate
        {
            get => _endDate;
            set
            {
                EndDateSpecified = true;
                _endDate = value;
            }
        }

        [XmlIgnore]
        protected bool EndDateSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Recurrence _recurrence;

        [XmlElement(ElementName = "recurrence", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:5939")]
        public BroadWorksConnector.Ocip.Models.Recurrence Recurrence
        {
            get => _recurrence;
            set
            {
                RecurrenceSpecified = true;
                _recurrence = value;
            }
        }

        [XmlIgnore]
        protected bool RecurrenceSpecified { get; set; }

    }
}
