using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies a list of users to be supervised by a supervisor on a call center.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallCenterModifySupervisedAgentListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _supervisorUserId;

        [XmlElement(ElementName = "supervisorUserId", IsNullable = false, Namespace = "")]
        public string SupervisorUserId {
            get => _supervisorUserId;
            set {
                SupervisorUserIdSpecified = true;
                _supervisorUserId = value;
            }
        }

        [XmlIgnore]
        public bool SupervisorUserIdSpecified { get; set; }
        
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
        
    }
}
