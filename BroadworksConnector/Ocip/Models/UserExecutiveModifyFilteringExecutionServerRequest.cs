using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the filtering setting for an executive user.
    /// Both executive and the executive assistant can run this command.
    /// requestingUserId is either executive or executive assistant.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0b10bca40a55275de6ba2076c583b7fd:89""}]")]
    public class UserExecutiveModifyFilteringExecutionServerRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"0b10bca40a55275de6ba2076c583b7fd:89")]
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

        protected string _requestingUserId;

        [XmlElement(ElementName = "requestingUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0b10bca40a55275de6ba2076c583b7fd:89")]
        [MinLength(1)]
        [MaxLength(161)]
        public string RequestingUserId
        {
            get => _requestingUserId;
            set
            {
                RequestingUserIdSpecified = true;
                _requestingUserId = value;
            }
        }

        [XmlIgnore]
        protected bool RequestingUserIdSpecified { get; set; }

        protected bool _enableFiltering;

        [XmlElement(ElementName = "enableFiltering", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0b10bca40a55275de6ba2076c583b7fd:89")]
        public bool EnableFiltering
        {
            get => _enableFiltering;
            set
            {
                EnableFilteringSpecified = true;
                _enableFiltering = value;
            }
        }

        [XmlIgnore]
        protected bool EnableFilteringSpecified { get; set; }

    }
}
