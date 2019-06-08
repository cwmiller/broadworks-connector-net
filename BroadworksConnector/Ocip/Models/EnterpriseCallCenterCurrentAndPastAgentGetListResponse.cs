using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseCallCenterCurrentAndPastAgentGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _agentUserTable;

    [XmlElement(ElementName = "agentUserTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable AgentUserTable {
        get => _agentUserTable;
        set {
            AgentUserTableSpecified = true;
            _agentUserTable = value;
        }
    }

    [XmlIgnore]
    public bool AgentUserTableSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.C.OCITable _deletedAgentUserTable;

    [XmlElement(ElementName = "deletedAgentUserTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable DeletedAgentUserTable {
        get => _deletedAgentUserTable;
        set {
            DeletedAgentUserTableSpecified = true;
            _deletedAgentUserTable = value;
        }
    }

    [XmlIgnore]
    public bool DeletedAgentUserTableSpecified { get; set; }
}
}
