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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:7210""}]")]
    public class UserCallCenterModifyCallCenterListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _agentUserId;

        [XmlElement(ElementName = "agentUserId", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7210")]
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

        protected BroadWorksConnector.Ocip.Models.ReplacementUserIdList _serviceUserIdList;

        [XmlElement(ElementName = "serviceUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7210")]
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
