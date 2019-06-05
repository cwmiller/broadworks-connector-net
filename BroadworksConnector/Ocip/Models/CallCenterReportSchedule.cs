using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CallCenterReportSchedule
    {
        private BroadworksConnector.Ocip.Models.CallCenterReportScheduleTime _scheduleTime;

        [XmlElement(ElementName = "scheduleTime", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportScheduleTime ScheduleTime
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
        private BroadworksConnector.Ocip.Models.CallCenterReportScheduleRecurrence _recurrence;

        [XmlElement(ElementName = "recurrence", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportScheduleRecurrence Recurrence
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
