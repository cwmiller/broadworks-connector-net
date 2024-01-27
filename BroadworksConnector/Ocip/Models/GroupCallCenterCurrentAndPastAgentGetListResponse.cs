using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterCurrentAndPastAgentGetListRequest.
    /// Contains a table with column headings: "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Phone Number", "Extension", "Department", "Email Address".
    /// <see cref="GroupCallCenterCurrentAndPastAgentGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:3065""}]")]
    public class GroupCallCenterCurrentAndPastAgentGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _agentUserTable;

        [XmlElement(ElementName = "agentUserTable", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:3065")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AgentUserTable
        {
            get => _agentUserTable;
            set
            {
                AgentUserTableSpecified = true;
                _agentUserTable = value;
            }
        }

        [XmlIgnore]
        protected bool AgentUserTableSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _deletedAgentUserTable;

        [XmlElement(ElementName = "deletedAgentUserTable", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:3065")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DeletedAgentUserTable
        {
            get => _deletedAgentUserTable;
            set
            {
                DeletedAgentUserTableSpecified = true;
                _deletedAgentUserTable = value;
            }
        }

        [XmlIgnore]
        protected bool DeletedAgentUserTableSpecified { get; set; }

    }
}
