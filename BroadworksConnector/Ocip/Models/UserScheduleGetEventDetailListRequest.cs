using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserScheduleGetEventDetailListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ScheduleGlobalKey _scheduleGlobalKey;

    [XmlElement(ElementName = "scheduleGlobalKey", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ScheduleGlobalKey ScheduleGlobalKey {
        get => _scheduleGlobalKey;
        set {
            ScheduleGlobalKeySpecified = true;
            _scheduleGlobalKey = value;
        }
    }

    [XmlIgnore]
    public bool ScheduleGlobalKeySpecified { get; set; }
}
}
