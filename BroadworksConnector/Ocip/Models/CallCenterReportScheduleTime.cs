using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CallCenterReportScheduleTime
    {
        private string _timeZone;

        [XmlElement(ElementName = "timeZone", IsNullable = false, Namespace = "")]
        public string TimeZone
        {
            get => _timeZone;
            set
            {
                TimeZoneSpecified = true;
                _timeZone = value;
            }
        }

        [XmlIgnore]
        public bool TimeZoneSpecified { get; set; }
        private string _scheduleDate;

        [XmlElement(ElementName = "scheduleDate", IsNullable = false, Namespace = "")]
        public string ScheduleDate
        {
            get => _scheduleDate;
            set
            {
                ScheduleDateSpecified = true;
                _scheduleDate = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleDateSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.HourMinute _scheduleTime;

        [XmlElement(ElementName = "scheduleTime", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.HourMinute ScheduleTime
        {
            get => _scheduleTime;
            set
            {
                ScheduleTimeSpecified = true;
                _scheduleTime = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleTimeSpecified { get; set; }
    }
}
