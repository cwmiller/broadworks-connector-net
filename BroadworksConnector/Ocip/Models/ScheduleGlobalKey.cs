using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Uniquely identifies Holiday and Time Schedules throughout all System, Service Provider, Group and User level.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4588""}]")]
    public class ScheduleGlobalKey
    {

        protected BroadWorksConnector.Ocip.Models.ScheduleKey _scheduleKey;

        [XmlElement(ElementName = "scheduleKey", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4588")]
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

        protected BroadWorksConnector.Ocip.Models.ScheduleLevel _scheduleLevel;

        [XmlElement(ElementName = "scheduleLevel", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4588")]
        public BroadWorksConnector.Ocip.Models.ScheduleLevel ScheduleLevel
        {
            get => _scheduleLevel;
            set
            {
                ScheduleLevelSpecified = true;
                _scheduleLevel = value;
            }
        }

        [XmlIgnore]
        protected bool ScheduleLevelSpecified { get; set; }

    }
}
