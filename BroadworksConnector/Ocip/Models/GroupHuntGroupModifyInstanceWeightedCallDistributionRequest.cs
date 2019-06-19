using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the weighted call distribution of a Hunt Group instance.
    /// The response is either SuccessResponse or ErrorResponse.
    /// NOTE: Prior to release 14, any agents who were not in the list kept their
    /// existing weight setting. In release 14, any agents who are not in the list
    /// will have their weight set to 0.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""bc829065f9d696d3ca7084121d57f8c0:563""}]")]
    public class GroupHuntGroupModifyInstanceWeightedCallDistributionRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:563")]
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

        private List<BroadWorksConnector.Ocip.Models.HuntAgentWeight> _agentWeight = new List<BroadWorksConnector.Ocip.Models.HuntAgentWeight>();

        [XmlElement(ElementName = "agentWeight", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"bc829065f9d696d3ca7084121d57f8c0:563")]
        public List<BroadWorksConnector.Ocip.Models.HuntAgentWeight> AgentWeight
        {
            get => _agentWeight;
            set
            {
                AgentWeightSpecified = true;
                _agentWeight = value;
            }
        }

        [XmlIgnore]
        public bool AgentWeightSpecified { get; set; }

    }
}
