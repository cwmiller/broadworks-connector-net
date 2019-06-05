using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class RecurrenceRecurMonthlyByDay 
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
}
}
