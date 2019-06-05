using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ScheduleGlobalKey 
{
    private BroadworksConnector.Ocip.Models.ScheduleKey _scheduleKey;

    [XmlElement(ElementName = "scheduleKey", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ScheduleKey ScheduleKey {
        get => _scheduleKey;
        set {
            ScheduleKeySpecified = true;
            _scheduleKey = value;
        }
    }

    [XmlIgnore]
    public bool ScheduleKeySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ScheduleLevel _scheduleLevel;

    [XmlElement(ElementName = "scheduleLevel", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ScheduleLevel ScheduleLevel {
        get => _scheduleLevel;
        set {
            ScheduleLevelSpecified = true;
            _scheduleLevel = value;
        }
    }

    [XmlIgnore]
    public bool ScheduleLevelSpecified { get; set; }
}
}
