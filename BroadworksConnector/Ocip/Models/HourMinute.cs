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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2459""}]")]
    public class HourMinute
    {

        private int _hour;

        [XmlElement(ElementName = "hour", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2459")]
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

        private int _minute;

        [XmlElement(ElementName = "minute", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2459")]
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
