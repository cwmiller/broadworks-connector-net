using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterModifyCallCenterListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _agentUserId;

    [XmlElement(ElementName = "agentUserId", IsNullable = false, Namespace = "")]
    public string AgentUserId {
        get => _agentUserId;
        set {
            AgentUserIdSpecified = true;
            _agentUserId = value;
        }
    }

    [XmlIgnore]
    public bool AgentUserIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ReplacementUserIdList _serviceUserIdList;

    [XmlElement(ElementName = "serviceUserIdList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList ServiceUserIdList {
        get => _serviceUserIdList;
        set {
            ServiceUserIdListSpecified = true;
            _serviceUserIdList = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdListSpecified { get; set; }
}
}
