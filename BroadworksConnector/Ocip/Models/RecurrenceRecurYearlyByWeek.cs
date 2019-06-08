using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class RecurrenceRecurYearlyByWeek 
{
    private int _recurInterval;

    [XmlElement(ElementName = "recurInterval", IsNullable = false, Namespace = "")]
    public int RecurInterval {
        get => _recurInterval;
        set {
            RecurIntervalSpecified = true;
            _recurInterval = value;
        }
    }

    [XmlIgnore]
    public bool RecurIntervalSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.DayOfWeek _dayOfWeek;

    [XmlElement(ElementName = "dayOfWeek", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DayOfWeek DayOfWeek {
        get => _dayOfWeek;
        set {
            DayOfWeekSpecified = true;
            _dayOfWeek = value;
        }
    }

    [XmlIgnore]
    public bool DayOfWeekSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.DayOfWeekInMonth _dayOfWeekInMonth;

    [XmlElement(ElementName = "dayOfWeekInMonth", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DayOfWeekInMonth DayOfWeekInMonth {
        get => _dayOfWeekInMonth;
        set {
            DayOfWeekInMonthSpecified = true;
            _dayOfWeekInMonth = value;
        }
    }

    [XmlIgnore]
    public bool DayOfWeekInMonthSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.Month _month;

    [XmlElement(ElementName = "month", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.Month Month {
        get => _month;
        set {
            MonthSpecified = true;
            _month = value;
        }
    }

    [XmlIgnore]
    public bool MonthSpecified { get; set; }
}
}
