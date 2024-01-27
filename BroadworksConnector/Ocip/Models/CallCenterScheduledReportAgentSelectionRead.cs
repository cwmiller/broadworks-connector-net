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

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:7597""}]")]
    public class CallCenterScheduledReportAgentSelectionRead
    {

        protected bool _allAgent;

        [XmlElement(ElementName = "allAgent", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7597")]
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
        protected bool AllAgentSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _agentTable;

        [XmlElement(ElementName = "agentTable", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7597")]
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
        protected bool AgentTableSpecified { get; set; }

    }
}
