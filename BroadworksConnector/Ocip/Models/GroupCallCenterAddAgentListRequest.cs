using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCenterAddAgentListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
    {
        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
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
        public bool ServiceUserIdSpecified { get; set; }
        private List<string> _agentUserId;

        [XmlElement(ElementName = "agentUserId", IsNullable = false, Namespace = "")]
        public List<string> AgentUserId
        {
            get => _agentUserId;
            set
            {
                AgentUserIdSpecified = true;
                _agentUserId = value;
            }
        }

        [XmlIgnore]
        public bool AgentUserIdSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.CallCenterSkillAgentList> _agentSkillList;

        [XmlElement(ElementName = "agentSkillList", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.CallCenterSkillAgentList> AgentSkillList
        {
            get => _agentSkillList;
            set
            {
                AgentSkillListSpecified = true;
                _agentSkillList = value;
            }
        }

        [XmlIgnore]
        public bool AgentSkillListSpecified { get; set; }
    }
}
