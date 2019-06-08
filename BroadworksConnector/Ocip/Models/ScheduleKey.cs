using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ScheduleKey 
{
    private string _scheduleName;

    [XmlElement(ElementName = "scheduleName", IsNullable = false, Namespace = "")]
    public string ScheduleName {
        get => _scheduleName;
        set {
            ScheduleNameSpecified = true;
            _scheduleName = value;
        }
    }

    [XmlIgnore]
    public bool ScheduleNameSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ScheduleType _scheduleType;

    [XmlElement(ElementName = "scheduleType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ScheduleType ScheduleType {
        get => _scheduleType;
        set {
            ScheduleTypeSpecified = true;
            _scheduleType = value;
        }
    }

    [XmlIgnore]
    public bool ScheduleTypeSpecified { get; set; }
}
}
