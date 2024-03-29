using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the user's voice messaging voice management service settings.
    /// The response is either a UserVoiceMessagingUserGetVoiceManagementResponse13mp8 or an ErrorResponse.
    /// Replaced by: UserVoiceMessagingUserGetVoiceManagementRequest17
    /// <see cref="UserVoiceMessagingUserGetVoiceManagementResponse13mp8"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserVoiceMessagingUserGetVoiceManagementRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:47972""}]")]
    public class UserVoiceMessagingUserGetVoiceManagementRequest13mp8 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserVoiceMessagingUserGetVoiceManagementResponse13mp8>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:47972")]
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
