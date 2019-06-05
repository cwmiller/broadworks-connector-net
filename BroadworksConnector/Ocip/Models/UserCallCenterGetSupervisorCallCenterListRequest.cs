using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterGetSupervisorCallCenterListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _supervisorUserId;

    [XmlElement(ElementName = "supervisorUserId", IsNullable = false, Namespace = "")]
    public string SupervisorUserId {
        get => _supervisorUserId;
        set {
            SupervisorUserIdSpecified = true;
            _supervisorUserId = value;
        }
    }

    [XmlIgnore]
    public bool SupervisorUserIdSpecified { get; set; }
}
}
