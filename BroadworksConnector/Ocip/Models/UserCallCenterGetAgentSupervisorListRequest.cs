using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of supervisors for an agent on a given call center.
    /// The response is either a UserCallCenterGetAgentSupervisorListResponse
    /// or an ErrorResponse.
        /// <see cref="UserCallCenterGetAgentSupervisorListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallCenterGetAgentSupervisorListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
    }
}
