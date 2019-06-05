using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterDeleteSupervisedAgentListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<string> _agentUserId;

    [XmlElement(ElementName = "agentUserId", IsNullable = false, Namespace = "")]
    public List<string> AgentUserId {
        get => _agentUserId;
        set {
            AgentUserIdSpecified = true;
            _agentUserId = value;
        }
    }

    [XmlIgnore]
    public bool AgentUserIdSpecified { get; set; }
}
}
