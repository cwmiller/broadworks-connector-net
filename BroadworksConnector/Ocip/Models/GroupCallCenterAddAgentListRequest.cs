using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:1939"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:1941""}]}]")]
    public class GroupCallCenterAddAgentListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1939")]
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
        public bool ServiceUserIdSpecified { get; set; }

        private List<string> _agentUserId = new List<string>();

        [XmlElement(ElementName = "agentUserId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1941")]
        [MinLength(1)]
        [MaxLength(161)]
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

        private List<BroadWorksConnector.Ocip.Models.CallCenterSkillAgentList> _agentSkillList = new List<BroadWorksConnector.Ocip.Models.CallCenterSkillAgentList>();

        [XmlElement(ElementName = "agentSkillList", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1941")]
        public List<BroadWorksConnector.Ocip.Models.CallCenterSkillAgentList> AgentSkillList
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
