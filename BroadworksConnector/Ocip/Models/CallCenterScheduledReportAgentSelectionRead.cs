using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Either all agents or list of agents.
    /// The agent table has the following column headings:
    /// "User Id", "Last Name", "First Name", "Hiragana Last Name" and "Hiragana First Name".
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:7578""}]")]
    public class CallCenterScheduledReportAgentSelectionRead
    {

        private bool _allAgent;

        [XmlElement(ElementName = "allAgent", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7578")]
        public bool AllAgent
        {
            get => _allAgent;
            set
            {
                AllAgentSpecified = true;
                _allAgent = value;
            }
        }

        [XmlIgnore]
        public bool AllAgentSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _agentTable;

        [XmlElement(ElementName = "agentTable", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7578")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AgentTable
        {
            get => _agentTable;
            set
            {
                AgentTableSpecified = true;
                _agentTable = value;
            }
        }

        [XmlIgnore]
        public bool AgentTableSpecified { get; set; }

    }
}
