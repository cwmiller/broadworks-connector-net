using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of device endpoints of a user that can be configured
    /// as Preferred Answer Endpoint for Auto-Answer and Forced Answer.
    /// If onlyDisplayPreferredAnswerEndpoint is specified, only the
    /// Preferred Answer Endpoint of user is returned in the response.
    /// 
    /// The response is either UserPreferredAnswerEndpointGetListResponse or ErrorResponse.
    /// <see cref="UserPreferredAnswerEndpointGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:3458""}]")]
    public class UserPreferredAnswerEndpointGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserPreferredAnswerEndpointGetListResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3458")]
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

        protected bool? _onlyDisplayPreferredAnswerEndpoint;

        [XmlElement(ElementName = "onlyDisplayPreferredAnswerEndpoint", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3458")]
        public bool? OnlyDisplayPreferredAnswerEndpoint
        {
            get => _onlyDisplayPreferredAnswerEndpoint;
            set
            {
                OnlyDisplayPreferredAnswerEndpointSpecified = (value != null);
                _onlyDisplayPreferredAnswerEndpoint = value;
            }
        }

        [XmlIgnore]
        protected bool OnlyDisplayPreferredAnswerEndpointSpecified { get; set; }

    }
}
