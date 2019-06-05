using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemScheduleDeleteEventListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<string> _eventName;

    [XmlElement(ElementName = "eventName", IsNullable = false, Namespace = "")]
    public List<string> EventName {
        get => _eventName;
        set {
            EventNameSpecified = true;
            _eventName = value;
        }
    }

    [XmlIgnore]
    public bool EventNameSpecified { get; set; }
}
}
