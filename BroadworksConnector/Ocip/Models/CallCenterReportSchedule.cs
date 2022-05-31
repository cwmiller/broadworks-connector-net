using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A schedule for call center enhanced reporting scheduled report. It can either be a fixed time schedule
    /// or recurring schedule
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:7517""}]")]
    public class CallCenterReportSchedule
    {

        protected BroadWorksConnector.Ocip.Models.CallCenterReportScheduleTime _scheduleTime;

        [XmlElement(ElementName = "scheduleTime", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7517")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportScheduleTime ScheduleTime
        {
            get => _scheduleTime;
            set
            {
                ScheduleTimeSpecified = true;
                _scheduleTime = value;
            }
        }

        [XmlIgnore]
        protected bool ScheduleTimeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterReportScheduleRecurrence _recurrence;

        [XmlElement(ElementName = "recurrence", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7517")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportScheduleRecurrence Recurrence
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
