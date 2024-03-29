using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request for an agent to login or logout of one or more Call Centers.
    /// Contains a list specifing the desired login status of one or more call centers.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Replaced By: UserCallCenterModifyRequest17sp4
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserCallCenterModifyRequest17sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:41252""}]")]
    public class UserCallCenterModifyAvailabilityListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:41252")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.CallCenterAgentAvailability> _callCenterAvailability = new List<BroadWorksConnector.Ocip.Models.CallCenterAgentAvailability>();

        [XmlElement(ElementName = "callCenterAvailability", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:41252")]
        public List<BroadWorksConnector.Ocip.Models.CallCenterAgentAvailability> CallCenterAvailability
        {
            get => _callCenterAvailability;
            set
            {
                CallCenterAvailabilitySpecified = true;
                _callCenterAvailability = value;
            }
        }

        [XmlIgnore]
        protected bool CallCenterAvailabilitySpecified { get; set; }

    }
}
