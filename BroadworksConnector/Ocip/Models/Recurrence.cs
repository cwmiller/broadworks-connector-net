using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Defines recurrence.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4099"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4100""},{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4165""}]}]")]
    public class Recurrence
    {

        protected BroadWorksConnector.Ocip.Models.RecurrenceRecurDaily _recurDaily;

        [XmlElement(ElementName = "recurDaily", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4100")]
        public BroadWorksConnector.Ocip.Models.RecurrenceRecurDaily RecurDaily
        {
            get => _recurDaily;
            set
            {
                RecurDailySpecified = true;
                _recurDaily = value;
            }
        }

        [XmlIgnore]
        protected bool RecurDailySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.RecurrenceRecurWeekly _recurWeekly;

        [XmlElement(ElementName = "recurWeekly", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4100")]
        public BroadWorksConnector.Ocip.Models.RecurrenceRecurWeekly RecurWeekly
        {
            get => _recurWeekly;
            set
            {
                RecurWeeklySpecified = true;
                _recurWeekly = value;
            }
        }

        [XmlIgnore]
        protected bool RecurWeeklySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.RecurrenceRecurMonthlyByDay _recurMonthlyByDay;

        [XmlElement(ElementName = "recurMonthlyByDay", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4100")]
        public BroadWorksConnector.Ocip.Models.RecurrenceRecurMonthlyByDay RecurMonthlyByDay
        {
            get => _recurMonthlyByDay;
            set
            {
                RecurMonthlyByDaySpecified = true;
                _recurMonthlyByDay = value;
            }
        }

        [XmlIgnore]
        protected bool RecurMonthlyByDaySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.RecurrenceRecurMonthlyByWeek _recurMonthlyByWeek;

        [XmlElement(ElementName = "recurMonthlyByWeek", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4100")]
        public BroadWorksConnector.Ocip.Models.RecurrenceRecurMonthlyByWeek RecurMonthlyByWeek
        {
            get => _recurMonthlyByWeek;
            set
            {
                RecurMonthlyByWeekSpecified = true;
                _recurMonthlyByWeek = value;
            }
        }

        [XmlIgnore]
        protected bool RecurMonthlyByWeekSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.RecurrenceRecurYearlyByDay _recurYearlyByDay;

        [XmlElement(ElementName = "recurYearlyByDay", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4100")]
        public BroadWorksConnector.Ocip.Models.RecurrenceRecurYearlyByDay RecurYearlyByDay
        {
            get => _recurYearlyByDay;
            set
            {
                RecurYearlyByDaySpecified = true;
                _recurYearlyByDay = value;
            }
        }

        [XmlIgnore]
        protected bool RecurYearlyByDaySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.RecurrenceRecurYearlyByWeek _recurYearlyByWeek;

        [XmlElement(ElementName = "recurYearlyByWeek", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4100")]
        public BroadWorksConnector.Ocip.Models.RecurrenceRecurYearlyByWeek RecurYearlyByWeek
        {
            get => _recurYearlyByWeek;
            set
            {
                RecurYearlyByWeekSpecified = true;
                _recurYearlyByWeek = value;
            }
        }

        [XmlIgnore]
        protected bool RecurYearlyByWeekSpecified { get; set; }

        protected bool _recurForEver;

        [XmlElement(ElementName = "recurForEver", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4165")]
        public bool RecurForEver
        {
            get => _recurForEver;
            set
            {
                RecurForEverSpecified = true;
                _recurForEver = value;
            }
        }

        [XmlIgnore]
        protected bool RecurForEverSpecified { get; set; }

        protected string _recurEndDate;

        [XmlElement(ElementName = "recurEndDate", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4165")]
        public string RecurEndDate
        {
            get => _recurEndDate;
            set
            {
                RecurEndDateSpecified = true;
                _recurEndDate = value;
            }
        }

        [XmlIgnore]
        protected bool RecurEndDateSpecified { get; set; }

        protected int _recurEndOccurrence;

        [XmlElement(ElementName = "recurEndOccurrence", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4165")]
        [MinInclusive(1)]
        [MaxInclusive(999)]
        public int RecurEndOccurrence
        {
            get => _recurEndOccurrence;
            set
            {
                RecurEndOccurrenceSpecified = true;
                _recurEndOccurrence = value;
            }
        }

        [XmlIgnore]
        protected bool RecurEndOccurrenceSpecified { get; set; }

    }
}
