using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This request signs-out a call center agent. Administrator, supervisor and agent itself can sign-out an agent.
    /// An empty OCI table in OCI-P response indicates success and the agent has been signed out. This sign-out
    /// command will fail if the agent is the last signed-in agent of any standard or premium call center to
    /// which she is currently joined. If the sign-out fails, the OCI-P response will contain a list of
    /// Call Centers for which the agent is the last signed-in agent.
    /// If this special logic is not needed, UserCallCenterModifyRequest19 can still be used to change
    /// the agents ACD state without checking if the agent is the last signed-in agent.
    /// The response is either a UserCallCenterAgentSignOutResponse or ErrorResponse.
    /// <see cref="UserCallCenterModifyRequest19"/>
    /// <see cref="UserCallCenterAgentSignOutResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:6676""}]")]
    public class UserCallCenterAgentSignOutRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _agentUserId;

        [XmlElement(ElementName = "agentUserId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6676")]
        [MinLength(1)]
        [MaxLength(161)]
        public string AgentUserId
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

    }
}
