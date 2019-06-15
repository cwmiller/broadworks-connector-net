using System;
using System.Xml.Serialization;
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
     
    public class GroupCallCenterModifyAgentListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private List<BroadWorksConnector.Ocip.Models.CallCenterReplacementSkilledAgents> _skilledAgentUserIdList;

        [XmlElement(ElementName = "skilledAgentUserIdList", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CallCenterReplacementSkilledAgents> SkilledAgentUserIdList {
            get => _skilledAgentUserIdList;
            set {
                SkilledAgentUserIdListSpecified = true;
                _skilledAgentUserIdList = value;
            }
        }

        [XmlIgnore]
        public bool SkilledAgentUserIdListSpecified { get; set; }
        
    }
}
