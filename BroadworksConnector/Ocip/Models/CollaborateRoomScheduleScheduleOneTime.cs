using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CollaborateRoomScheduleScheduleOneTime 
{
    private string _startTime;

    [XmlElement(ElementName = "startTime", IsNullable = false, Namespace = "")]
    public string StartTime {
        get => _startTime;
        set {
            StartTimeSpecified = true;
            _startTime = value;
        }
    }

    [XmlIgnore]
    public bool StartTimeSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CollaborateRoomScheduleDuration _duration;

    [XmlElement(ElementName = "duration", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CollaborateRoomScheduleDuration Duration {
        get => _duration;
        set {
            DurationSpecified = true;
            _duration = value;
        }
    }

    [XmlIgnore]
    public bool DurationSpecified { get; set; }
}
}
