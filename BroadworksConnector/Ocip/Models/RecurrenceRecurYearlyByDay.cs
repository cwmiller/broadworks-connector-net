using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class RecurrenceRecurYearlyByDay 
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
    private int _dayOfMonth;

    [XmlElement(ElementName = "dayOfMonth", IsNullable = false, Namespace = "")]
    public int DayOfMonth {
        get => _dayOfMonth;
        set {
            DayOfMonthSpecified = true;
            _dayOfMonth = value;
        }
    }

    [XmlIgnore]
    public bool DayOfMonthSpecified { get; set; }
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
