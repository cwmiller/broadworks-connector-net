using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4136""}]")]
    public class RecurrenceRecurMonthlyByWeek
    {

        protected int _recurInterval;

        [XmlElement(ElementName = "recurInterval", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4136")]
        [MinInclusive(1)]
        [MaxInclusive(99)]
        public int RecurInterval
        {
            get => _recurInterval;
            set
            {
                RecurIntervalSpecified = true;
                _recurInterval = value;
            }
        }

        [XmlIgnore]
        protected bool RecurIntervalSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DayOfWeekInMonth _dayOfWeekInMonth;

        [XmlElement(ElementName = "dayOfWeekInMonth", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4136")]
        public BroadWorksConnector.Ocip.Models.DayOfWeekInMonth DayOfWeekInMonth
        {
            get => _dayOfWeekInMonth;
            set
            {
                DayOfWeekInMonthSpecified = true;
                _dayOfWeekInMonth = value;
            }
        }

        [XmlIgnore]
        protected bool DayOfWeekInMonthSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DayOfWeek _dayOfWeek;

        [XmlElement(ElementName = "dayOfWeek", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4136")]
        public BroadWorksConnector.Ocip.Models.DayOfWeek DayOfWeek
        {
            get => _dayOfWeek;
            set
            {
                DayOfWeekSpecified = true;
                _dayOfWeek = value;
            }
        }

        [XmlIgnore]
        protected bool DayOfWeekSpecified { get; set; }

    }
}
