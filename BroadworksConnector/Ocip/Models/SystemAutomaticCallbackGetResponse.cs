using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAutomaticCallbackGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
    private int _waitBetweenRetryOriginatorMinutes;

    [XmlElement(ElementName = "waitBetweenRetryOriginatorMinutes", IsNullable = false, Namespace = "")]
    public int WaitBetweenRetryOriginatorMinutes {
        get => _waitBetweenRetryOriginatorMinutes;
        set {
            WaitBetweenRetryOriginatorMinutesSpecified = true;
            _waitBetweenRetryOriginatorMinutes = value;
        }
    }

    [XmlIgnore]
    public bool WaitBetweenRetryOriginatorMinutesSpecified { get; set; }
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
    private int _maxRetryOriginatorMinutes;

    [XmlElement(ElementName = "maxRetryOriginatorMinutes", IsNullable = false, Namespace = "")]
    public int MaxRetryOriginatorMinutes {
        get => _maxRetryOriginatorMinutes;
        set {
            MaxRetryOriginatorMinutesSpecified = true;
            _maxRetryOriginatorMinutes = value;
        }
    }

    [XmlIgnore]
    public bool MaxRetryOriginatorMinutesSpecified { get; set; }
}
}
