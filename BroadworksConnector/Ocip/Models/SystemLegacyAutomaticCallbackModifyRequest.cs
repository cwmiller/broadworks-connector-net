using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemLegacyAutomaticCallbackModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
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
    private int _t2Minutes;

    [XmlElement(ElementName = "t2Minutes", IsNullable = false, Namespace = "")]
    public int T2Minutes {
        get => _t2Minutes;
        set {
            T2MinutesSpecified = true;
            _t2Minutes = value;
        }
    }

    [XmlIgnore]
    public bool T2MinutesSpecified { get; set; }
    private int _t4Seconds;

    [XmlElement(ElementName = "t4Seconds", IsNullable = false, Namespace = "")]
    public int T4Seconds {
        get => _t4Seconds;
        set {
            T4SecondsSpecified = true;
            _t4Seconds = value;
        }
    }

    [XmlIgnore]
    public bool T4SecondsSpecified { get; set; }
    private int _t5Seconds;

    [XmlElement(ElementName = "t5Seconds", IsNullable = false, Namespace = "")]
    public int T5Seconds {
        get => _t5Seconds;
        set {
            T5SecondsSpecified = true;
            _t5Seconds = value;
        }
    }

    [XmlIgnore]
    public bool T5SecondsSpecified { get; set; }
    private int _t6Minutes;

    [XmlElement(ElementName = "t6Minutes", IsNullable = false, Namespace = "")]
    public int T6Minutes {
        get => _t6Minutes;
        set {
            T6MinutesSpecified = true;
            _t6Minutes = value;
        }
    }

    [XmlIgnore]
    public bool T6MinutesSpecified { get; set; }
    private int _t7Minutes;

    [XmlElement(ElementName = "t7Minutes", IsNullable = false, Namespace = "")]
    public int T7Minutes {
        get => _t7Minutes;
        set {
            T7MinutesSpecified = true;
            _t7Minutes = value;
        }
    }

    [XmlIgnore]
    public bool T7MinutesSpecified { get; set; }
    private int _t8Seconds;

    [XmlElement(ElementName = "t8Seconds", IsNullable = false, Namespace = "")]
    public int T8Seconds {
        get => _t8Seconds;
        set {
            T8SecondsSpecified = true;
            _t8Seconds = value;
        }
    }

    [XmlIgnore]
    public bool T8SecondsSpecified { get; set; }
    private int _tRingSeconds;

    [XmlElement(ElementName = "tRingSeconds", IsNullable = false, Namespace = "")]
    public int TRingSeconds {
        get => _tRingSeconds;
        set {
            TRingSecondsSpecified = true;
            _tRingSeconds = value;
        }
    }

    [XmlIgnore]
    public bool TRingSecondsSpecified { get; set; }
    private int _t10OMinutes;

    [XmlElement(ElementName = "t10OMinutes", IsNullable = false, Namespace = "")]
    public int T10OMinutes {
        get => _t10OMinutes;
        set {
            T10OMinutesSpecified = true;
            _t10OMinutes = value;
        }
    }

    [XmlIgnore]
    public bool T10OMinutesSpecified { get; set; }
    private int _t10TMinutes;

    [XmlElement(ElementName = "t10TMinutes", IsNullable = false, Namespace = "")]
    public int T10TMinutes {
        get => _t10TMinutes;
        set {
            T10TMinutesSpecified = true;
            _t10TMinutes = value;
        }
    }

    [XmlIgnore]
    public bool T10TMinutesSpecified { get; set; }
}
}
