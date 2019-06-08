using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserTimeScheduleDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _timeScheduleName;

    [XmlElement(ElementName = "timeScheduleName", IsNullable = false, Namespace = "")]
    public string TimeScheduleName {
        get => _timeScheduleName;
        set {
            TimeScheduleNameSpecified = true;
            _timeScheduleName = value;
        }
    }

    [XmlIgnore]
    public bool TimeScheduleNameSpecified { get; set; }
}
}
