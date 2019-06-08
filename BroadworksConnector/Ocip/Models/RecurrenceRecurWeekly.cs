using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class RecurrenceRecurWeekly 
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
    private bool _sunday;

    [XmlElement(ElementName = "sunday", IsNullable = false, Namespace = "")]
    public bool Sunday {
        get => _sunday;
        set {
            SundaySpecified = true;
            _sunday = value;
        }
    }

    [XmlIgnore]
    public bool SundaySpecified { get; set; }
    private bool _monday;

    [XmlElement(ElementName = "monday", IsNullable = false, Namespace = "")]
    public bool Monday {
        get => _monday;
        set {
            MondaySpecified = true;
            _monday = value;
        }
    }

    [XmlIgnore]
    public bool MondaySpecified { get; set; }
    private bool _tuesday;

    [XmlElement(ElementName = "tuesday", IsNullable = false, Namespace = "")]
    public bool Tuesday {
        get => _tuesday;
        set {
            TuesdaySpecified = true;
            _tuesday = value;
        }
    }

    [XmlIgnore]
    public bool TuesdaySpecified { get; set; }
    private bool _wednesday;

    [XmlElement(ElementName = "wednesday", IsNullable = false, Namespace = "")]
    public bool Wednesday {
        get => _wednesday;
        set {
            WednesdaySpecified = true;
            _wednesday = value;
        }
    }

    [XmlIgnore]
    public bool WednesdaySpecified { get; set; }
    private bool _thursday;

    [XmlElement(ElementName = "thursday", IsNullable = false, Namespace = "")]
    public bool Thursday {
        get => _thursday;
        set {
            ThursdaySpecified = true;
            _thursday = value;
        }
    }

    [XmlIgnore]
    public bool ThursdaySpecified { get; set; }
    private bool _friday;

    [XmlElement(ElementName = "friday", IsNullable = false, Namespace = "")]
    public bool Friday {
        get => _friday;
        set {
            FridaySpecified = true;
            _friday = value;
        }
    }

    [XmlIgnore]
    public bool FridaySpecified { get; set; }
    private bool _saturday;

    [XmlElement(ElementName = "saturday", IsNullable = false, Namespace = "")]
    public bool Saturday {
        get => _saturday;
        set {
            SaturdaySpecified = true;
            _saturday = value;
        }
    }

    [XmlIgnore]
    public bool SaturdaySpecified { get; set; }
}
}
