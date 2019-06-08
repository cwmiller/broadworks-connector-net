using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class AgentStatistics 
{
    private int _numberOfCallsHandled;

    [XmlElement(ElementName = "numberOfCallsHandled", IsNullable = false, Namespace = "")]
    public int NumberOfCallsHandled {
        get => _numberOfCallsHandled;
        set {
            NumberOfCallsHandledSpecified = true;
            _numberOfCallsHandled = value;
        }
    }

    [XmlIgnore]
    public bool NumberOfCallsHandledSpecified { get; set; }
    private int _numberOfCallsUnanswered;

    [XmlElement(ElementName = "numberOfCallsUnanswered", IsNullable = false, Namespace = "")]
    public int NumberOfCallsUnanswered {
        get => _numberOfCallsUnanswered;
        set {
            NumberOfCallsUnansweredSpecified = true;
            _numberOfCallsUnanswered = value;
        }
    }

    [XmlIgnore]
    public bool NumberOfCallsUnansweredSpecified { get; set; }
    private int _averageCallSeconds;

    [XmlElement(ElementName = "averageCallSeconds", IsNullable = false, Namespace = "")]
    public int AverageCallSeconds {
        get => _averageCallSeconds;
        set {
            AverageCallSecondsSpecified = true;
            _averageCallSeconds = value;
        }
    }

    [XmlIgnore]
    public bool AverageCallSecondsSpecified { get; set; }
    private int _totalTalkSeconds;

    [XmlElement(ElementName = "totalTalkSeconds", IsNullable = false, Namespace = "")]
    public int TotalTalkSeconds {
        get => _totalTalkSeconds;
        set {
            TotalTalkSecondsSpecified = true;
            _totalTalkSeconds = value;
        }
    }

    [XmlIgnore]
    public bool TotalTalkSecondsSpecified { get; set; }
    private int _totalStaffedSeconds;

    [XmlElement(ElementName = "totalStaffedSeconds", IsNullable = false, Namespace = "")]
    public int TotalStaffedSeconds {
        get => _totalStaffedSeconds;
        set {
            TotalStaffedSecondsSpecified = true;
            _totalStaffedSeconds = value;
        }
    }

    [XmlIgnore]
    public bool TotalStaffedSecondsSpecified { get; set; }
}
}
