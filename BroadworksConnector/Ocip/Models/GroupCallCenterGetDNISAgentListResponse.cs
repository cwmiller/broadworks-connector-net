using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterGetDNISAgentListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _agentTable;

    [XmlElement(ElementName = "agentTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable AgentTable {
        get => _agentTable;
        set {
            AgentTableSpecified = true;
            _agentTable = value;
        }
    }

    [XmlIgnore]
    public bool AgentTableSpecified { get; set; }
}
}
