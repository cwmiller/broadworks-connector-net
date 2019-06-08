using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterScheduledReportAgentSelectionAdminRead 
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
    private BroadWorksConnector.Ocip.Models.C.OCITable _currentAgentTable;

    [XmlElement(ElementName = "currentAgentTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable CurrentAgentTable {
        get => _currentAgentTable;
        set {
            CurrentAgentTableSpecified = true;
            _currentAgentTable = value;
        }
    }

    [XmlIgnore]
    public bool CurrentAgentTableSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.C.OCITable _pastAgentTable;

    [XmlElement(ElementName = "pastAgentTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable PastAgentTable {
        get => _pastAgentTable;
        set {
            PastAgentTableSpecified = true;
            _pastAgentTable = value;
        }
    }

    [XmlIgnore]
    public bool PastAgentTableSpecified { get; set; }
}
}
