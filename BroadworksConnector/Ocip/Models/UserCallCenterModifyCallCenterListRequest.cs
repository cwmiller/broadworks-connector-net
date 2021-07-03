using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the call center list for an agent.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:7224""}]")]
    public class UserCallCenterModifyCallCenterListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _agentUserId;

        [XmlElement(ElementName = "agentUserId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7224")]
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

        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _serviceUserIdList;

        [XmlElement(ElementName = "serviceUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7224")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList ServiceUserIdList
        {
            get => _serviceUserIdList;
            set
            {
                ServiceUserIdListSpecified = true;
                _serviceUserIdList = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdListSpecified { get; set; }

    }
}
