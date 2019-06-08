using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDirectoryNumberHuntingGetResponse17sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
    private bool _useTerminateCallToAgentFirst;

    [XmlElement(ElementName = "useTerminateCallToAgentFirst", IsNullable = false, Namespace = "")]
    public bool UseTerminateCallToAgentFirst {
        get => _useTerminateCallToAgentFirst;
        set {
            UseTerminateCallToAgentFirstSpecified = true;
            _useTerminateCallToAgentFirst = value;
        }
    }

    [XmlIgnore]
    public bool UseTerminateCallToAgentFirstSpecified { get; set; }
    private bool _useOriginalAgentServicesForBusyAndNoAnswerCalls;

    [XmlElement(ElementName = "useOriginalAgentServicesForBusyAndNoAnswerCalls", IsNullable = false, Namespace = "")]
    public bool UseOriginalAgentServicesForBusyAndNoAnswerCalls {
        get => _useOriginalAgentServicesForBusyAndNoAnswerCalls;
        set {
            UseOriginalAgentServicesForBusyAndNoAnswerCallsSpecified = true;
            _useOriginalAgentServicesForBusyAndNoAnswerCalls = value;
        }
    }

    [XmlIgnore]
    public bool UseOriginalAgentServicesForBusyAndNoAnswerCallsSpecified { get; set; }
}
}
