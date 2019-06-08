using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksReceptionistEnterpriseDeleteUserListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private List<string> _monitoredUserId;

    [XmlElement(ElementName = "monitoredUserId", IsNullable = false, Namespace = "")]
    public List<string> MonitoredUserId {
        get => _monitoredUserId;
        set {
            MonitoredUserIdSpecified = true;
            _monitoredUserId = value;
        }
    }

    [XmlIgnore]
    public bool MonitoredUserIdSpecified { get; set; }
}
}
