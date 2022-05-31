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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:1954"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:1956""}]}]")]
    public class GroupCallCenterAddAgentListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1954")]
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

        protected List<string> _agentUserId = new List<string>();

        [XmlElement(ElementName = "agentUserId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1956")]
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
        protected bool AgentUserIdSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.CallCenterSkillAgentList> _agentSkillList = new List<BroadWorksConnector.Ocip.Models.CallCenterSkillAgentList>();

        [XmlElement(ElementName = "agentSkillList", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:1956")]
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
        protected bool AgentSkillListSpecified { get; set; }

    }
}
