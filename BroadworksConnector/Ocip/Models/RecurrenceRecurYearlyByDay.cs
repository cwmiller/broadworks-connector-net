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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4146""}]")]
    public class RecurrenceRecurYearlyByDay
    {

        protected int _recurInterval;

        [XmlElement(ElementName = "recurInterval", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4146")]
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

        protected int _dayOfMonth;

        [XmlElement(ElementName = "dayOfMonth", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4146")]
        [MinInclusive(1)]
        [MaxInclusive(31)]
        public int DayOfMonth
        {
            get => _dayOfMonth;
            set
            {
                DayOfMonthSpecified = true;
                _dayOfMonth = value;
            }
        }

        [XmlIgnore]
        protected bool DayOfMonthSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.Month _month;

        [XmlElement(ElementName = "month", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4146")]
        public BroadWorksConnector.Ocip.Models.Month Month
        {
            get => _month;
            set
            {
                MonthSpecified = true;
                _month = value;
            }
        }

        [XmlIgnore]
        protected bool MonthSpecified { get; set; }

    }
}
