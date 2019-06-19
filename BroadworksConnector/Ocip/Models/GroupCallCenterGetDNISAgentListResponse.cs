using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterGetDNISAgentListRequest.
    /// Contains a table with column headings: "User Id", "Last Name",
    /// "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Phone Number", "Extension", "Department", "Email Address".
    /// <see cref="GroupCallCenterGetDNISAgentListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:4315""}]")]
    public class GroupCallCenterGetDNISAgentListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _agentTable;

        [XmlElement(ElementName = "agentTable", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4315")]
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
