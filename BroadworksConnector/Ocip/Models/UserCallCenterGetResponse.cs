using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCallCenterGetRequest.
    /// Contains the user's ACD state
    /// Indicates whether the agent is current available (logged in) to each call center in the list.
    /// Contains a table with column headings: "Service User Id", "Phone Number", "Extension", "Available",
    /// "Logoff Allowed".
        /// <see cref="UserCallCenterGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallCenterGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.AgentACDState _agentACDState;

        [XmlElement(ElementName = "agentACDState", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AgentACDState AgentACDState {
            get => _agentACDState;
            set {
                AgentACDStateSpecified = true;
                _agentACDState = value;
            }
        }

        [XmlIgnore]
        public bool AgentACDStateSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _userTable;

        [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserTable {
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
