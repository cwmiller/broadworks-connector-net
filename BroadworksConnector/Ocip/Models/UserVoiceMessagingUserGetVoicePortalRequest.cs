using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the user's voice messaging voice portal settings.
    /// The response is either a UserVoiceMessagingUserGetVoicePortalResponse or an ErrorResponse.
    /// Replaced By: UserVoiceMessagingUserGetVoicePortalRequest16
        /// <see cref="UserVoiceMessagingUserGetVoicePortalResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserVoiceMessagingUserGetVoicePortalRequest16"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserVoiceMessagingUserGetVoicePortalRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
    }
}
