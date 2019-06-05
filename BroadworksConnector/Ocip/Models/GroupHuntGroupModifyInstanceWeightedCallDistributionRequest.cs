using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupHuntGroupModifyInstanceWeightedCallDistributionRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadworksConnector.Ocip.Models.HuntAgentWeight> _agentWeight;

    [XmlElement(ElementName = "agentWeight", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.HuntAgentWeight> AgentWeight {
        get => _agentWeight;
        set {
            AgentWeightSpecified = true;
            _agentWeight = value;
        }
    }

    [XmlIgnore]
    public bool AgentWeightSpecified { get; set; }
}
}
