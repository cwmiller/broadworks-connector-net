using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterModifySupervisedAgentListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ReplacementUserIdList _agentUserIdList;

    [XmlElement(ElementName = "agentUserIdList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList AgentUserIdList {
        get => _agentUserIdList;
        set {
            AgentUserIdListSpecified = true;
            _agentUserIdList = value;
        }
    }

    [XmlIgnore]
    public bool AgentUserIdListSpecified { get; set; }
}
}
