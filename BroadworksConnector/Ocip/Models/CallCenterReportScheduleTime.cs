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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:7510""}]")]
    public class CallCenterReportScheduleTime
    {

        private string _timeZone;

        [XmlElement(ElementName = "timeZone", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7510")]
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
        public bool TimeZoneSpecified { get; set; }

        private string _scheduleDate;

        [XmlElement(ElementName = "scheduleDate", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7510")]
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

        private BroadWorksConnector.Ocip.Models.HourMinute _scheduleTime;

        [XmlElement(ElementName = "scheduleTime", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7510")]
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
        public bool ScheduleTimeSpecified { get; set; }

    }
}
