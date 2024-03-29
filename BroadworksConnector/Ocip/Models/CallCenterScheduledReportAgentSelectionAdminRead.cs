using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Either all agents or 2 list of agents: one for current and one for past (deleted) agents.
    /// This is used when an admin reads a Scheduled Report.
    /// Each agent table has the following column headings:
    /// "User Id", "Last Name", "First Name", "Hiragana Last Name" and "Hiragana First Name".
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:7580"",""children"":[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:7582""}]}]")]
    public class CallCenterScheduledReportAgentSelectionAdminRead
    {

        protected bool _allAgent;

        [XmlElement(ElementName = "allAgent", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7580")]
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

        protected BroadWorksConnector.Ocip.Models.C.OCITable _currentAgentTable;

        [XmlElement(ElementName = "currentAgentTable", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7582")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CurrentAgentTable
        {
            get => _currentAgentTable;
            set
            {
                CurrentAgentTableSpecified = true;
                _currentAgentTable = value;
            }
        }

        [XmlIgnore]
        protected bool CurrentAgentTableSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _pastAgentTable;

        [XmlElement(ElementName = "pastAgentTable", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7582")]
        public BroadWorksConnector.Ocip.Models.C.OCITable PastAgentTable
        {
            get => _pastAgentTable;
            set
            {
                PastAgentTableSpecified = true;
                _pastAgentTable = value;
            }
        }

        [XmlIgnore]
        protected bool PastAgentTableSpecified { get; set; }

    }
}
