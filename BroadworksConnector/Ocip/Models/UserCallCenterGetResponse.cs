using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.AgentACDState _agentACDState;

    [XmlElement(ElementName = "agentACDState", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AgentACDState AgentACDState {
        get => _agentACDState;
        set {
            AgentACDStateSpecified = true;
            _agentACDState = value;
        }
    }

    [XmlIgnore]
    public bool AgentACDStateSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _userTable;

    [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable UserTable {
        get => _userTable;
        set {
            UserTableSpecified = true;
            _userTable = value;
        }
    }

    [XmlIgnore]
    public bool UserTableSpecified { get; set; }
}
}
