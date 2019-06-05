using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class Recurrence 
{
    private BroadworksConnector.Ocip.Models.RecurrenceRecurDaily _recurDaily;

    [XmlElement(ElementName = "recurDaily", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.RecurrenceRecurDaily RecurDaily {
        get => _recurDaily;
        set {
            RecurDailySpecified = true;
            _recurDaily = value;
        }
    }

    [XmlIgnore]
    public bool RecurDailySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.RecurrenceRecurWeekly _recurWeekly;

    [XmlElement(ElementName = "recurWeekly", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.RecurrenceRecurWeekly RecurWeekly {
        get => _recurWeekly;
        set {
            RecurWeeklySpecified = true;
            _recurWeekly = value;
        }
    }

    [XmlIgnore]
    public bool RecurWeeklySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.RecurrenceRecurMonthlyByDay _recurMonthlyByDay;

    [XmlElement(ElementName = "recurMonthlyByDay", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.RecurrenceRecurMonthlyByDay RecurMonthlyByDay {
        get => _recurMonthlyByDay;
        set {
            RecurMonthlyByDaySpecified = true;
            _recurMonthlyByDay = value;
        }
    }

    [XmlIgnore]
    public bool RecurMonthlyByDaySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.RecurrenceRecurMonthlyByWeek _recurMonthlyByWeek;

    [XmlElement(ElementName = "recurMonthlyByWeek", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.RecurrenceRecurMonthlyByWeek RecurMonthlyByWeek {
        get => _recurMonthlyByWeek;
        set {
            RecurMonthlyByWeekSpecified = true;
            _recurMonthlyByWeek = value;
        }
    }

    [XmlIgnore]
    public bool RecurMonthlyByWeekSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.RecurrenceRecurYearlyByDay _recurYearlyByDay;

    [XmlElement(ElementName = "recurYearlyByDay", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.RecurrenceRecurYearlyByDay RecurYearlyByDay {
        get => _recurYearlyByDay;
        set {
            RecurYearlyByDaySpecified = true;
            _recurYearlyByDay = value;
        }
    }

    [XmlIgnore]
    public bool RecurYearlyByDaySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.RecurrenceRecurYearlyByWeek _recurYearlyByWeek;

    [XmlElement(ElementName = "recurYearlyByWeek", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.RecurrenceRecurYearlyByWeek RecurYearlyByWeek {
        get => _recurYearlyByWeek;
        set {
            RecurYearlyByWeekSpecified = true;
            _recurYearlyByWeek = value;
        }
    }

    [XmlIgnore]
    public bool RecurYearlyByWeekSpecified { get; set; }
    private bool _recurForEver;

    [XmlElement(ElementName = "recurForEver", IsNullable = false, Namespace = "")]
    public bool RecurForEver {
        get => _recurForEver;
        set {
            RecurForEverSpecified = true;
            _recurForEver = value;
        }
    }

    [XmlIgnore]
    public bool RecurForEverSpecified { get; set; }
    private string _recurEndDate;

    [XmlElement(ElementName = "recurEndDate", IsNullable = false, Namespace = "")]
    public string RecurEndDate {
        get => _recurEndDate;
        set {
            RecurEndDateSpecified = true;
            _recurEndDate = value;
        }
    }

    [XmlIgnore]
    public bool RecurEndDateSpecified { get; set; }
    private int _recurEndOccurrence;

    [XmlElement(ElementName = "recurEndOccurrence", IsNullable = false, Namespace = "")]
    public int RecurEndOccurrence {
        get => _recurEndOccurrence;
        set {
            RecurEndOccurrenceSpecified = true;
            _recurEndOccurrence = value;
        }
    }

    [XmlIgnore]
    public bool RecurEndOccurrenceSpecified { get; set; }
}
}
