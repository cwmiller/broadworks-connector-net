using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add agent(s) to a call center.
    /// The response is either SuccessResponse or ErrorResponse.
    /// If the skill level is not present for skill based premium call centers, the users will be set to skill level 1.
    /// 
    /// The following element is only used in AS data mode and ignored in XS data mode:
    /// agentSkillList
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallCenterAddAgentListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private List<string> _agentUserId;

        [XmlElement(ElementName = "agentUserId", IsNullable = false, Namespace = "")]
        public List<string> AgentUserId {
            get => _agentUserId;
            set {
                AgentUserIdSpecified = true;
                _agentUserId = value;
            }
        }

        [XmlIgnore]
        public bool AgentUserIdSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.CallCenterSkillAgentList> _agentSkillList;

        [XmlElement(ElementName = "agentSkillList", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CallCenterSkillAgentList> AgentSkillList {
            get => _agentSkillList;
            set {
                AgentSkillListSpecified = true;
                _agentSkillList = value;
            }
        }

        [XmlIgnore]
        public bool AgentSkillListSpecified { get; set; }
        
    }
}
