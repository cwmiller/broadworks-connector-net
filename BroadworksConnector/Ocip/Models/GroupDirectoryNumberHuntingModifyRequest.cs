using System;
using System.Xml.Serialization;
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
     
    public class GroupDirectoryNumberHuntingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public string ServiceUserId {
            get => _serviceUserId;
            set {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _agentUserIdList;

        [XmlElement(ElementName = "agentUserIdList", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList AgentUserIdList {
            get => _agentUserIdList;
            set {
                AgentUserIdListSpecified = true;
                _agentUserIdList = value;
            }
        }

        [XmlIgnore]
        public bool AgentUserIdListSpecified { get; set; }
        
        private bool _useTerminateCallToAgentFirst;

        [XmlElement(ElementName = "useTerminateCallToAgentFirst", IsNullable = false, Namespace = "")]
        public bool UseTerminateCallToAgentFirst {
            get => _useTerminateCallToAgentFirst;
            set {
                UseTerminateCallToAgentFirstSpecified = true;
                _useTerminateCallToAgentFirst = value;
            }
        }

        [XmlIgnore]
        public bool UseTerminateCallToAgentFirstSpecified { get; set; }
        
        private bool _useOriginalAgentServicesForBusyAndNoAnswerCalls;

        [XmlElement(ElementName = "useOriginalAgentServicesForBusyAndNoAnswerCalls", IsNullable = false, Namespace = "")]
        public bool UseOriginalAgentServicesForBusyAndNoAnswerCalls {
            get => _useOriginalAgentServicesForBusyAndNoAnswerCalls;
            set {
                UseOriginalAgentServicesForBusyAndNoAnswerCallsSpecified = true;
                _useOriginalAgentServicesForBusyAndNoAnswerCalls = value;
            }
        }

        [XmlIgnore]
        public bool UseOriginalAgentServicesForBusyAndNoAnswerCallsSpecified { get; set; }
        
    }
}
