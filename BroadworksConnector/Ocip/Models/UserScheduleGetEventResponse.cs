using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserScheduleGetEventRequest.
    /// The response contains the event of the user schedule.
    /// <see cref="UserScheduleGetEventRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3651"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3653"",""children"":[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3655""}]}]}]")]
    public class UserScheduleGetEventResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _startDate;

        [XmlElement(ElementName = "startDate", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3651")]
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
        public bool StartDateSpecified { get; set; }

        private bool _allDayEvent;

        [XmlElement(ElementName = "allDayEvent", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3653")]
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
        public bool AllDayEventSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.HourMinute _startTime;

        [XmlElement(ElementName = "startTime", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3655")]
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
        public bool StartTimeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.HourMinute _endTime;

        [XmlElement(ElementName = "endTime", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3655")]
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
        public bool EndTimeSpecified { get; set; }

        private string _endDate;

        [XmlElement(ElementName = "endDate", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3651")]
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
        public bool EndDateSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.Recurrence _recurrence;

        [XmlElement(ElementName = "recurrence", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3651")]
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
        public bool RecurrenceSpecified { get; set; }

    }
}
