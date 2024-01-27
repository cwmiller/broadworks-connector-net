using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the user's voice messaging advanced voice management service setting.
    /// The response is either a UserVoiceMessagingUserGetAdvancedVoiceManagementResponse or an ErrorResponse.
    /// Replaced By: UserVoiceMessagingUserGetAdvancedVoiceManagementRequest14sp3
    /// <see cref="UserVoiceMessagingUserGetAdvancedVoiceManagementResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserVoiceMessagingUserGetAdvancedVoiceManagementRequest14sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:47834""}]")]
    public class UserVoiceMessagingUserGetAdvancedVoiceManagementRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserVoiceMessagingUserGetAdvancedVoiceManagementResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:47834")]
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
