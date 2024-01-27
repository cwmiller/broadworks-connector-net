using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Uniquely identifies Holiday and Time Schedules within a level(System, Service Provider, Group or User level).
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4600""}]")]
    public class ScheduleKey
    {

        protected string _scheduleName;

        [XmlElement(ElementName = "scheduleName", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4600")]
        [MinLength(1)]
        [MaxLength(40)]
        public string ScheduleName
        {
            get => _scheduleName;
            set
            {
                ScheduleNameSpecified = true;
                _scheduleName = value;
            }
        }

        [XmlIgnore]
        protected bool ScheduleNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ScheduleType _scheduleType;

        [XmlElement(ElementName = "scheduleType", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4600")]
        public BroadWorksConnector.Ocip.Models.ScheduleType ScheduleType
        {
            get => _scheduleType;
            set
            {
                ScheduleTypeSpecified = true;
                _scheduleType = value;
            }
        }

        [XmlIgnore]
        protected bool ScheduleTypeSpecified { get; set; }

    }
}
