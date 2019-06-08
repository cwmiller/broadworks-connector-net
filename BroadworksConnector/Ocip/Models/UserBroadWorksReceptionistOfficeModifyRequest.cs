using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksReceptionistOfficeModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _monitoredUserIdList;

    [XmlElement(ElementName = "monitoredUserIdList", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementUserIdList MonitoredUserIdList {
        get => _monitoredUserIdList;
        set {
            MonitoredUserIdListSpecified = true;
            _monitoredUserIdList = value;
        }
    }

    [XmlIgnore]
    public bool MonitoredUserIdListSpecified { get; set; }
}
}
