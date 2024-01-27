using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of unlicensed users who are preventing the Call Center from upgrading to another type.
    /// The response is either GroupCallCenterGetUnlicensedAgentListResponse or ErrorResponse.
    /// <see cref="GroupCallCenterGetUnlicensedAgentListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:4868""}]")]
    public class GroupCallCenterGetUnlicensedAgentListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupCallCenterGetUnlicensedAgentListResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4868")]
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

        protected BroadWorksConnector.Ocip.Models.CallCenterType _callCenterType;

        [XmlElement(ElementName = "callCenterType", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:4868")]
        public BroadWorksConnector.Ocip.Models.CallCenterType CallCenterType
        {
            get => _callCenterType;
            set
            {
                CallCenterTypeSpecified = true;
                _callCenterType = value;
            }
        }

        [XmlIgnore]
        protected bool CallCenterTypeSpecified { get; set; }

    }
}
