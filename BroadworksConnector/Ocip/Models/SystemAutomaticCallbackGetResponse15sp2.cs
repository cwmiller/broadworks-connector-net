using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAutomaticCallbackGetResponse15sp2 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private int _monitorMinutes;

    [XmlElement(ElementName = "monitorMinutes", IsNullable = false, Namespace = "")]
    public int MonitorMinutes {
        get => _monitorMinutes;
        set {
            MonitorMinutesSpecified = true;
            _monitorMinutes = value;
        }
    }

    [XmlIgnore]
    public bool MonitorMinutesSpecified { get; set; }
    private int _maxMonitorsPerOriginator;

    [XmlElement(ElementName = "maxMonitorsPerOriginator", IsNullable = false, Namespace = "")]
    public int MaxMonitorsPerOriginator {
        get => _maxMonitorsPerOriginator;
        set {
            MaxMonitorsPerOriginatorSpecified = true;
            _maxMonitorsPerOriginator = value;
        }
    }

    [XmlIgnore]
    public bool MaxMonitorsPerOriginatorSpecified { get; set; }
    private int _maxCallbackRings;

    [XmlElement(ElementName = "maxCallbackRings", IsNullable = false, Namespace = "")]
    public int MaxCallbackRings {
        get => _maxCallbackRings;
        set {
            MaxCallbackRingsSpecified = true;
            _maxCallbackRings = value;
        }
    }

    [XmlIgnore]
    public bool MaxCallbackRingsSpecified { get; set; }
    private int _maxMonitorsPerTerminator;

    [XmlElement(ElementName = "maxMonitorsPerTerminator", IsNullable = false, Namespace = "")]
    public int MaxMonitorsPerTerminator {
        get => _maxMonitorsPerTerminator;
        set {
            MaxMonitorsPerTerminatorSpecified = true;
            _maxMonitorsPerTerminator = value;
        }
    }

    [XmlIgnore]
    public bool MaxMonitorsPerTerminatorSpecified { get; set; }
    private int _terminatorIdleGuardSeconds;

    [XmlElement(ElementName = "terminatorIdleGuardSeconds", IsNullable = false, Namespace = "")]
    public int TerminatorIdleGuardSeconds {
        get => _terminatorIdleGuardSeconds;
        set {
            TerminatorIdleGuardSecondsSpecified = true;
            _terminatorIdleGuardSeconds = value;
        }
    }

    [XmlIgnore]
    public bool TerminatorIdleGuardSecondsSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.AutomaticCallbackMethod _callbackMethod;

    [XmlElement(ElementName = "callbackMethod", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AutomaticCallbackMethod CallbackMethod {
        get => _callbackMethod;
        set {
            CallbackMethodSpecified = true;
            _callbackMethod = value;
        }
    }

    [XmlIgnore]
    public bool CallbackMethodSpecified { get; set; }
    private int _pollingIntervalSeconds;

    [XmlElement(ElementName = "pollingIntervalSeconds", IsNullable = false, Namespace = "")]
    public int PollingIntervalSeconds {
        get => _pollingIntervalSeconds;
        set {
            PollingIntervalSecondsSpecified = true;
            _pollingIntervalSeconds = value;
        }
    }

    [XmlIgnore]
    public bool PollingIntervalSecondsSpecified { get; set; }
}
}
