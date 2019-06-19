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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2995"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2996""},{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3061""}]}]")]
    public class Recurrence
    {

        private BroadWorksConnector.Ocip.Models.RecurrenceRecurDaily _recurDaily;

        [XmlElement(ElementName = "recurDaily", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2996")]
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
        public bool RecurDailySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.RecurrenceRecurWeekly _recurWeekly;

        [XmlElement(ElementName = "recurWeekly", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2996")]
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
        public bool RecurWeeklySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.RecurrenceRecurMonthlyByDay _recurMonthlyByDay;

        [XmlElement(ElementName = "recurMonthlyByDay", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2996")]
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
        public bool RecurMonthlyByDaySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.RecurrenceRecurMonthlyByWeek _recurMonthlyByWeek;

        [XmlElement(ElementName = "recurMonthlyByWeek", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2996")]
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
        public bool RecurMonthlyByWeekSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.RecurrenceRecurYearlyByDay _recurYearlyByDay;

        [XmlElement(ElementName = "recurYearlyByDay", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2996")]
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
        public bool RecurYearlyByDaySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.RecurrenceRecurYearlyByWeek _recurYearlyByWeek;

        [XmlElement(ElementName = "recurYearlyByWeek", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2996")]
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
        public bool RecurYearlyByWeekSpecified { get; set; }

        private bool _recurForEver;

        [XmlElement(ElementName = "recurForEver", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3061")]
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
        public bool RecurForEverSpecified { get; set; }

        private string _recurEndDate;

        [XmlElement(ElementName = "recurEndDate", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3061")]
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
        public bool RecurEndDateSpecified { get; set; }

        private int _recurEndOccurrence;

        [XmlElement(ElementName = "recurEndOccurrence", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3061")]
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
        public bool RecurEndOccurrenceSpecified { get; set; }

    }
}
