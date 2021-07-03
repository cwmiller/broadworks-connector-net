using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Retrives all Holiday or Time Event details for a given schedulel Level.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:4078"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:4081"",""children"":[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:4083""}]}]}]")]
    public class ScheduleEvents
    {

        private string _eventname;

        [XmlElement(ElementName = "eventname", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4078")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Eventname
        {
            get => _eventname;
            set
            {
                EventnameSpecified = true;
                _eventname = value;
            }
        }

        [XmlIgnore]
        protected bool EventnameSpecified { get; set; }

        private string _startDate;

        [XmlElement(ElementName = "startDate", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4078")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4081")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4083")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4083")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4078")]
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
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4078")]
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
