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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3667""}]")]
    public class RecurrenceRecurYearlyByWeek
    {

        protected int _recurInterval;

        [XmlElement(ElementName = "recurInterval", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3667")]
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

        protected BroadWorksConnector.Ocip.Models.DayOfWeek _dayOfWeek;

        [XmlElement(ElementName = "dayOfWeek", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3667")]
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

        protected BroadWorksConnector.Ocip.Models.DayOfWeekInMonth _dayOfWeekInMonth;

        [XmlElement(ElementName = "dayOfWeekInMonth", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3667")]
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

        protected BroadWorksConnector.Ocip.Models.Month _month;

        [XmlElement(ElementName = "month", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3667")]
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
