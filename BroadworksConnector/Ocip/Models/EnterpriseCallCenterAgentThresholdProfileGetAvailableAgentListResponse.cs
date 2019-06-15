using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentListRequest.
    /// Contains a table with column headings: "User Id", "Last Name",
    /// "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Phone Number", "Extension", "Department", "Email Address", "Agent Threshold Profile";
        /// <see cref="EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseCallCenterAgentThresholdProfileGetAvailableAgentListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
