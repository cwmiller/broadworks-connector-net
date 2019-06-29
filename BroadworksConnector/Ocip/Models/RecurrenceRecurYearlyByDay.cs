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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3042""}]")]
    public class RecurrenceRecurYearlyByDay
    {

        private int _recurInterval;

        [XmlElement(ElementName = "recurInterval", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3042")]
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

        private int _dayOfMonth;

        [XmlElement(ElementName = "dayOfMonth", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3042")]
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

        private BroadWorksConnector.Ocip.Models.Month _month;

        [XmlElement(ElementName = "month", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3042")]
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
