using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserScheduleModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _newScheduleName;

    [XmlElement(ElementName = "newScheduleName", IsNullable = false, Namespace = "")]
    public string NewScheduleName {
        get => _newScheduleName;
        set {
            NewScheduleNameSpecified = true;
            _newScheduleName = value;
        }
    }

    [XmlIgnore]
    public bool NewScheduleNameSpecified { get; set; }
}
}
