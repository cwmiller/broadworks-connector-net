using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterAgentDailyStatistics13mp8 
{
    private int _numberOfCallsReceived;

    [XmlElement(ElementName = "numberOfCallsReceived", IsNullable = false, Namespace = "")]
    public int NumberOfCallsReceived {
        get => _numberOfCallsReceived;
        set {
            NumberOfCallsReceivedSpecified = true;
            _numberOfCallsReceived = value;
        }
    }

    [XmlIgnore]
    public bool NumberOfCallsReceivedSpecified { get; set; }
    private int _numberOfCallsNotAnswered;

    [XmlElement(ElementName = "numberOfCallsNotAnswered", IsNullable = false, Namespace = "")]
    public int NumberOfCallsNotAnswered {
        get => _numberOfCallsNotAnswered;
        set {
            NumberOfCallsNotAnsweredSpecified = true;
            _numberOfCallsNotAnswered = value;
        }
    }

    [XmlIgnore]
    public bool NumberOfCallsNotAnsweredSpecified { get; set; }
    private int _averageTimePerCallSeconds;

    [XmlElement(ElementName = "averageTimePerCallSeconds", IsNullable = false, Namespace = "")]
    public int AverageTimePerCallSeconds {
        get => _averageTimePerCallSeconds;
        set {
            AverageTimePerCallSecondsSpecified = true;
            _averageTimePerCallSeconds = value;
        }
    }

    [XmlIgnore]
    public bool AverageTimePerCallSecondsSpecified { get; set; }
    private int _timeInCallsSeconds;

    [XmlElement(ElementName = "timeInCallsSeconds", IsNullable = false, Namespace = "")]
    public int TimeInCallsSeconds {
        get => _timeInCallsSeconds;
        set {
            TimeInCallsSecondsSpecified = true;
            _timeInCallsSeconds = value;
        }
    }

    [XmlIgnore]
    public bool TimeInCallsSecondsSpecified { get; set; }
    private int _timeLoggedOffSeconds;

    [XmlElement(ElementName = "timeLoggedOffSeconds", IsNullable = false, Namespace = "")]
    public int TimeLoggedOffSeconds {
        get => _timeLoggedOffSeconds;
        set {
            TimeLoggedOffSecondsSpecified = true;
            _timeLoggedOffSeconds = value;
        }
    }

    [XmlIgnore]
    public bool TimeLoggedOffSecondsSpecified { get; set; }
    private int _timeLoggedOnAndIdleSeconds;

    [XmlElement(ElementName = "timeLoggedOnAndIdleSeconds", IsNullable = false, Namespace = "")]
    public int TimeLoggedOnAndIdleSeconds {
        get => _timeLoggedOnAndIdleSeconds;
        set {
            TimeLoggedOnAndIdleSecondsSpecified = true;
            _timeLoggedOnAndIdleSeconds = value;
        }
    }

    [XmlIgnore]
    public bool TimeLoggedOnAndIdleSecondsSpecified { get; set; }
}
}
