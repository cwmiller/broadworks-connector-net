using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the EnterpriseCallCenterCurrentAndPastAgentGetListRequest.
    /// Contains a table with column headings: "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Phone Number", "Extension", "Department", "Email Address".
        /// <see cref="EnterpriseCallCenterCurrentAndPastAgentGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseCallCenterCurrentAndPastAgentGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
