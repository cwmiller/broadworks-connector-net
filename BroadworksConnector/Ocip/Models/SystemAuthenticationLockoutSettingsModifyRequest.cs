using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAuthenticationLockoutSettingsModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private int _counterResetIntervalDays;

    [XmlElement(ElementName = "counterResetIntervalDays", IsNullable = false, Namespace = "")]
    public int CounterResetIntervalDays {
        get => _counterResetIntervalDays;
        set {
            CounterResetIntervalDaysSpecified = true;
            _counterResetIntervalDays = value;
        }
    }

    [XmlIgnore]
    public bool CounterResetIntervalDaysSpecified { get; set; }
    private int _counterResetHour;

    [XmlElement(ElementName = "counterResetHour", IsNullable = false, Namespace = "")]
    public int CounterResetHour {
        get => _counterResetHour;
        set {
            CounterResetHourSpecified = true;
            _counterResetHour = value;
        }
    }

    [XmlIgnore]
    public bool CounterResetHourSpecified { get; set; }
    private int _counterResetMinute;

    [XmlElement(ElementName = "counterResetMinute", IsNullable = false, Namespace = "")]
    public int CounterResetMinute {
        get => _counterResetMinute;
        set {
            CounterResetMinuteSpecified = true;
            _counterResetMinute = value;
        }
    }

    [XmlIgnore]
    public bool CounterResetMinuteSpecified { get; set; }
    private bool _emergencySIPBypassAllowed;

    [XmlElement(ElementName = "emergencySIPBypassAllowed", IsNullable = false, Namespace = "")]
    public bool EmergencySIPBypassAllowed {
        get => _emergencySIPBypassAllowed;
        set {
            EmergencySIPBypassAllowedSpecified = true;
            _emergencySIPBypassAllowed = value;
        }
    }

    [XmlIgnore]
    public bool EmergencySIPBypassAllowedSpecified { get; set; }
}
}
