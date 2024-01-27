using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Represents a specific time with hour and minute granularity
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:3410""}]")]
    public class HourMinute
    {

        protected int _hour;

        [XmlElement(ElementName = "hour", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3410")]
        [MinInclusive(0)]
        [MaxInclusive(23)]
        public int Hour
        {
            get => _hour;
            set
            {
                HourSpecified = true;
                _hour = value;
            }
        }

        [XmlIgnore]
        protected bool HourSpecified { get; set; }

        protected int _minute;

        [XmlElement(ElementName = "minute", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3410")]
        [MinInclusive(0)]
        [MaxInclusive(59)]
        public int Minute
        {
            get => _minute;
            set
            {
                MinuteSpecified = true;
                _minute = value;
            }
        }

        [XmlIgnore]
        protected bool MinuteSpecified { get; set; }

    }
}
