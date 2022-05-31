using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCallCenterGetRequest.
    /// Contains the user's ACD state
    /// Indicates whether the agent is current available (logged in) to each call center in the list.
    /// Contains a table with column headings: "Service User Id", "Phone Number", "Extension", "Available", "Logoff Allowed".
    /// <see cref="UserCallCenterGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:40437""}]")]
    public class UserCallCenterGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.AgentACDState _agentACDState;

        [XmlElement(ElementName = "agentACDState", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40437")]
        public BroadWorksConnector.Ocip.Models.AgentACDState AgentACDState
        {
            get => _agentACDState;
            set
            {
                AgentACDStateSpecified = true;
                _agentACDState = value;
            }
        }

        [XmlIgnore]
        protected bool AgentACDStateSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _userTable;

        [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40437")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserTable
        {
            get => _userTable;
            set
            {
                UserTableSpecified = true;
                _userTable = value;
            }
        }

        [XmlIgnore]
        protected bool UserTableSpecified { get; set; }

    }
}
