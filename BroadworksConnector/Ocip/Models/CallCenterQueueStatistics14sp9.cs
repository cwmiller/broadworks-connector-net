using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterQueueStatistics14sp9 
{
    private int _numberOfBusyOverflows;

    [XmlElement(ElementName = "numberOfBusyOverflows", IsNullable = false, Namespace = "")]
    public int NumberOfBusyOverflows {
        get => _numberOfBusyOverflows;
        set {
            NumberOfBusyOverflowsSpecified = true;
            _numberOfBusyOverflows = value;
        }
    }

    [XmlIgnore]
    public bool NumberOfBusyOverflowsSpecified { get; set; }
    private int _numberOfCallsAnswered;

    [XmlElement(ElementName = "numberOfCallsAnswered", IsNullable = false, Namespace = "")]
    public int NumberOfCallsAnswered {
        get => _numberOfCallsAnswered;
        set {
            NumberOfCallsAnsweredSpecified = true;
            _numberOfCallsAnswered = value;
        }
    }

    [XmlIgnore]
    public bool NumberOfCallsAnsweredSpecified { get; set; }
    private int _numberOfCallsAbandoned;

    [XmlElement(ElementName = "numberOfCallsAbandoned", IsNullable = false, Namespace = "")]
    public int NumberOfCallsAbandoned {
        get => _numberOfCallsAbandoned;
        set {
            NumberOfCallsAbandonedSpecified = true;
            _numberOfCallsAbandoned = value;
        }
    }

    [XmlIgnore]
    public bool NumberOfCallsAbandonedSpecified { get; set; }
    private int _numberOfCallsTransferred;

    [XmlElement(ElementName = "numberOfCallsTransferred", IsNullable = false, Namespace = "")]
    public int NumberOfCallsTransferred {
        get => _numberOfCallsTransferred;
        set {
            NumberOfCallsTransferredSpecified = true;
            _numberOfCallsTransferred = value;
        }
    }

    [XmlIgnore]
    public bool NumberOfCallsTransferredSpecified { get; set; }
    private int _numberOfCallsTimedout;

    [XmlElement(ElementName = "numberOfCallsTimedout", IsNullable = false, Namespace = "")]
    public int NumberOfCallsTimedout {
        get => _numberOfCallsTimedout;
        set {
            NumberOfCallsTimedoutSpecified = true;
            _numberOfCallsTimedout = value;
        }
    }

    [XmlIgnore]
    public bool NumberOfCallsTimedoutSpecified { get; set; }
    private string _averageNumberOfAgentsTalking;

    [XmlElement(ElementName = "averageNumberOfAgentsTalking", IsNullable = false, Namespace = "")]
    public string AverageNumberOfAgentsTalking {
        get => _averageNumberOfAgentsTalking;
        set {
            AverageNumberOfAgentsTalkingSpecified = true;
            _averageNumberOfAgentsTalking = value;
        }
    }

    [XmlIgnore]
    public bool AverageNumberOfAgentsTalkingSpecified { get; set; }
    private string _averageNumberOfAgentsStaffed;

    [XmlElement(ElementName = "averageNumberOfAgentsStaffed", IsNullable = false, Namespace = "")]
    public string AverageNumberOfAgentsStaffed {
        get => _averageNumberOfAgentsStaffed;
        set {
            AverageNumberOfAgentsStaffedSpecified = true;
            _averageNumberOfAgentsStaffed = value;
        }
    }

    [XmlIgnore]
    public bool AverageNumberOfAgentsStaffedSpecified { get; set; }
    private int _averageWaitSeconds;

    [XmlElement(ElementName = "averageWaitSeconds", IsNullable = false, Namespace = "")]
    public int AverageWaitSeconds {
        get => _averageWaitSeconds;
        set {
            AverageWaitSecondsSpecified = true;
            _averageWaitSeconds = value;
        }
    }

    [XmlIgnore]
    public bool AverageWaitSecondsSpecified { get; set; }
    private int _averageAbandonmentSeconds;

    [XmlElement(ElementName = "averageAbandonmentSeconds", IsNullable = false, Namespace = "")]
    public int AverageAbandonmentSeconds {
        get => _averageAbandonmentSeconds;
        set {
            AverageAbandonmentSecondsSpecified = true;
            _averageAbandonmentSeconds = value;
        }
    }

    [XmlIgnore]
    public bool AverageAbandonmentSecondsSpecified { get; set; }
}
}
