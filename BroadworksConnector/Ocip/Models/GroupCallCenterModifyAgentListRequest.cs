using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterModifyAgentListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
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
    private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _agentUserIdList;

    [XmlElement(ElementName = "agentUserIdList", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementUserIdList AgentUserIdList {
        get => _agentUserIdList;
        set {
            AgentUserIdListSpecified = true;
            _agentUserIdList = value;
        }
    }

    [XmlIgnore]
    public bool AgentUserIdListSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.CallCenterReplacementSkilledAgents> _skilledAgentUserIdList;

    [XmlElement(ElementName = "skilledAgentUserIdList", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.CallCenterReplacementSkilledAgents> SkilledAgentUserIdList {
        get => _skilledAgentUserIdList;
        set {
            SkilledAgentUserIdListSpecified = true;
            _skilledAgentUserIdList = value;
        }
    }

    [XmlIgnore]
    public bool SkilledAgentUserIdListSpecified { get; set; }
}
}
