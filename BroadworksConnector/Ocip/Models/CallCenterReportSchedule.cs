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

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:7503""}]")]
    public class CallCenterReportSchedule
    {

        protected BroadWorksConnector.Ocip.Models.CallCenterReportScheduleTime _scheduleTime;

        [XmlElement(ElementName = "scheduleTime", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7503")]
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
        [Group(@"4d65d3449061c568639c8cc1e2492285:7503")]
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
