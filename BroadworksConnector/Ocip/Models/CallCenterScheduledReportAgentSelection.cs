using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterScheduledReportAgentSelection 
{
    private bool _allAgent;

    [XmlElement(ElementName = "allAgent", IsNullable = false, Namespace = "")]
    public bool AllAgent {
        get => _allAgent;
        set {
            AllAgentSpecified = true;
            _allAgent = value;
        }
    }

    [XmlIgnore]
    public bool AllAgentSpecified { get; set; }
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
