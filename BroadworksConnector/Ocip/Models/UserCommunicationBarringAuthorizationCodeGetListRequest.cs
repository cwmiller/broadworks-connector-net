using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of Communication Barring Authorization Code for a user.
    /// The response is either a UserCommunicationBarringAuthorizationCodeGetListResponse
    /// or an ErorResponse.
    /// <see cref="UserCommunicationBarringAuthorizationCodeGetListResponse"/>
    /// <see cref="ErorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:1182""}]")]
    public class UserCommunicationBarringAuthorizationCodeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserCommunicationBarringAuthorizationCodeGetListResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1182")]
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

    }
}
