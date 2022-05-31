using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupDirectoryNumberHuntingGetRequest.
    /// Contains a table with column headings: "User Id", "Last Name",
    /// "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Phone Number", "Extension", "Department", "Email Address".
    /// <see cref="GroupDirectoryNumberHuntingGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7c509136e6ce6be616e313c3b28a0449:102""}]")]
    public class GroupDirectoryNumberHuntingGetResponse17sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _agentUserTable;

        [XmlElement(ElementName = "agentUserTable", IsNullable = false, Namespace = "")]
        [Group(@"7c509136e6ce6be616e313c3b28a0449:102")]
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

        protected bool _useTerminateCallToAgentFirst;

        [XmlElement(ElementName = "useTerminateCallToAgentFirst", IsNullable = false, Namespace = "")]
        [Group(@"7c509136e6ce6be616e313c3b28a0449:102")]
        public bool UseTerminateCallToAgentFirst
        {
            get => _useTerminateCallToAgentFirst;
            set
            {
                UseTerminateCallToAgentFirstSpecified = true;
                _useTerminateCallToAgentFirst = value;
            }
        }

        [XmlIgnore]
        protected bool UseTerminateCallToAgentFirstSpecified { get; set; }

        protected bool _useOriginalAgentServicesForBusyAndNoAnswerCalls;

        [XmlElement(ElementName = "useOriginalAgentServicesForBusyAndNoAnswerCalls", IsNullable = false, Namespace = "")]
        [Group(@"7c509136e6ce6be616e313c3b28a0449:102")]
        public bool UseOriginalAgentServicesForBusyAndNoAnswerCalls
        {
            get => _useOriginalAgentServicesForBusyAndNoAnswerCalls;
            set
            {
                UseOriginalAgentServicesForBusyAndNoAnswerCallsSpecified = true;
                _useOriginalAgentServicesForBusyAndNoAnswerCalls = value;
            }
        }

        [XmlIgnore]
        protected bool UseOriginalAgentServicesForBusyAndNoAnswerCallsSpecified { get; set; }

    }
}
