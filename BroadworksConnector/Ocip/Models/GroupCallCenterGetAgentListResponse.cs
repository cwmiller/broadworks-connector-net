using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterGetAgentListRequest.
    /// Contains a table with column headings: "User Id", "Last Name",
    /// "First Name", "Hiragana Last Name", "Hiragana First Name", "Weight",
    /// "Phone Number", "Extension", "Department", "Email Address", "Skill Level".
    /// 
    /// The following column is only returned in AS data mode:
    /// "Skill Level"
    /// <see cref="GroupCallCenterGetAgentListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:3986""}]")]
    public class GroupCallCenterGetAgentListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _agentTable;

        [XmlElement(ElementName = "agentTable", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:3986")]
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
