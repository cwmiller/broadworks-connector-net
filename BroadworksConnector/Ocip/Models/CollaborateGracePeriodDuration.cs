using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CollaborateGracePeriodDuration 
{
    private int _hours;

    [XmlElement(ElementName = "hours", IsNullable = false, Namespace = "")]
    public int Hours {
        get => _hours;
        set {
            HoursSpecified = true;
            _hours = value;
        }
    }

    [XmlIgnore]
    public bool HoursSpecified { get; set; }
    private int _minutes;

    [XmlElement(ElementName = "minutes", IsNullable = false, Namespace = "")]
    public int Minutes {
        get => _minutes;
        set {
            MinutesSpecified = true;
            _minutes = value;
        }
    }

    [XmlIgnore]
    public bool MinutesSpecified { get; set; }
}
}
