using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A scheduled time for call center enhanced reporting scheduled report.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:7529""}]")]
    public class CallCenterReportScheduleTime
    {

        protected string _timeZone;

        [XmlElement(ElementName = "timeZone", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7529")]
        [MinLength(1)]
        [MaxLength(127)]
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
        protected bool TimeZoneSpecified { get; set; }

        protected string _scheduleDate;

        [XmlElement(ElementName = "scheduleDate", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7529")]
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
        protected bool ScheduleDateSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.HourMinute _scheduleTime;

        [XmlElement(ElementName = "scheduleTime", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7529")]
        public BroadWorksConnector.Ocip.Models.HourMinute ScheduleTime
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

    }
}
