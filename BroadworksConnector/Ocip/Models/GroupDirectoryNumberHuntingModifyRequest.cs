using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Replaces a list of users as agents for a directory number hunting group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7c509136e6ce6be616e313c3b28a0449:120""}]")]
    public class GroupDirectoryNumberHuntingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"7c509136e6ce6be616e313c3b28a0449:120")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementUserIdList _agentUserIdList;

        [XmlElement(ElementName = "agentUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7c509136e6ce6be616e313c3b28a0449:120")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList AgentUserIdList
        {
            get => _agentUserIdList;
            set
            {
                AgentUserIdListSpecified = true;
                _agentUserIdList = value;
            }
        }

        [XmlIgnore]
        protected bool AgentUserIdListSpecified { get; set; }

        protected bool _useTerminateCallToAgentFirst;

        [XmlElement(ElementName = "useTerminateCallToAgentFirst", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7c509136e6ce6be616e313c3b28a0449:120")]
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
        [Optional]
        [Group(@"7c509136e6ce6be616e313c3b28a0449:120")]
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
