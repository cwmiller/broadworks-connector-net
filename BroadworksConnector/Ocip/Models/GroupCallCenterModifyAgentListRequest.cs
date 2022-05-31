using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the agent list for a call center.
    /// The response is either SuccessResponse or ErrorResponse.
    /// If the agentUserIdList is used for Skill Based Premium call centers,
    /// the agents will be set to skill level 1.
    /// 
    /// The following element is only used in AS data mode and ignored in XS data mode:
    /// skilledAgentUserIdList
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:4995"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:4997""}]}]")]
    public class GroupCallCenterModifyAgentListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4995")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4997")]
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

        protected List<BroadWorksConnector.Ocip.Models.CallCenterReplacementSkilledAgents> _skilledAgentUserIdList = new List<BroadWorksConnector.Ocip.Models.CallCenterReplacementSkilledAgents>();

        [XmlElement(ElementName = "skilledAgentUserIdList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4997")]
        public List<BroadWorksConnector.Ocip.Models.CallCenterReplacementSkilledAgents> SkilledAgentUserIdList
        {
            get => _skilledAgentUserIdList;
            set
            {
                SkilledAgentUserIdListSpecified = true;
                _skilledAgentUserIdList = value;
            }
        }

        [XmlIgnore]
        protected bool SkilledAgentUserIdListSpecified { get; set; }

    }
}
