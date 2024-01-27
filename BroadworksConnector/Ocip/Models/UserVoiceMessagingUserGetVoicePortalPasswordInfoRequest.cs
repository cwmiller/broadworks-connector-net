using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the user's voice portal password information.
    /// The response is either a UserVoiceMessagingUserGetVoicePortalPasswordInfoResponse or an ErrorResponse.
    /// Replaced By: UserPortalPasscodeGetInfoRequest
    /// <see cref="UserVoiceMessagingUserGetVoicePortalPasswordInfoResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserPortalPasscodeGetInfoRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:48017""}]")]
    public class UserVoiceMessagingUserGetVoicePortalPasswordInfoRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserVoiceMessagingUserGetVoicePortalPasswordInfoResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:48017")]
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
