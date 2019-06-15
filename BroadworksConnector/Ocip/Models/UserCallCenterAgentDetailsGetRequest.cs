using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the detail information of a Call Center Agent. Administrator, supervisor and agent
    /// itself can send this command.
    /// The response is either UserCallCenterAgentDetailsGetResponse or ErrorResponse.
        /// <see cref="UserCallCenterAgentDetailsGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallCenterAgentDetailsGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _agentUserId;

        [XmlElement(ElementName = "agentUserId", IsNullable = false, Namespace = "")]
        public string AgentUserId {
            get => _agentUserId;
            set {
                AgentUserIdSpecified = true;
                _agentUserId = value;
            }
        }

        [XmlIgnore]
        public bool AgentUserIdSpecified { get; set; }
        
    }
}
