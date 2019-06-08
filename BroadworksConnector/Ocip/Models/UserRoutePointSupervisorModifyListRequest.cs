using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserRoutePointSupervisorModifyListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _supervisorUserIdList;

    [XmlElement(ElementName = "supervisorUserIdList", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementUserIdList SupervisorUserIdList {
        get => _supervisorUserIdList;
        set {
            SupervisorUserIdListSpecified = true;
            _supervisorUserIdList = value;
        }
    }

    [XmlIgnore]
    public bool SupervisorUserIdListSpecified { get; set; }
}
}
