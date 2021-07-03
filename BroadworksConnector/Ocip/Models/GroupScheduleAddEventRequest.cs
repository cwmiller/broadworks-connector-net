using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:7321"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:7327"",""children"":[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:7329""}]}]}]")]
    public class GroupScheduleAddEventRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7321")]
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

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7321")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ScheduleKey _scheduleKey;

        [XmlElement(ElementName = "scheduleKey", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7321")]
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

        private string _eventName;

        [XmlElement(ElementName = "eventName", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7321")]
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

        private string _startDate;

        [XmlElement(ElementName = "startDate", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7321")]
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

        private bool _allDayEvent;

        [XmlElement(ElementName = "allDayEvent", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7327")]
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

        private BroadWorksConnector.Ocip.Models.HourMinute _startTime;

        [XmlElement(ElementName = "startTime", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7329")]
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

        private BroadWorksConnector.Ocip.Models.HourMinute _endTime;

        [XmlElement(ElementName = "endTime", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7329")]
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

        private string _endDate;

        [XmlElement(ElementName = "endDate", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7321")]
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

        private BroadWorksConnector.Ocip.Models.Recurrence _recurrence;

        [XmlElement(ElementName = "recurrence", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7321")]
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
