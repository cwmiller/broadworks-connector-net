using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MaliciousCallTraceTimePeriod 
{
    private string _startDateTime;

    [XmlElement(ElementName = "startDateTime", IsNullable = false, Namespace = "")]
    public string StartDateTime {
        get => _startDateTime;
        set {
            StartDateTimeSpecified = true;
            _startDateTime = value;
        }
    }

    [XmlIgnore]
    public bool StartDateTimeSpecified { get; set; }
    private string _stopDateTime;

    [XmlElement(ElementName = "stopDateTime", IsNullable = false, Namespace = "")]
    public string StopDateTime {
        get => _stopDateTime;
        set {
            StopDateTimeSpecified = true;
            _stopDateTime = value;
        }
    }

    [XmlIgnore]
    public bool StopDateTimeSpecified { get; set; }
}
}
