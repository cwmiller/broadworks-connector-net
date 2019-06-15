using System;
using System.Xml.Serialization;
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
     
    public class UserVoiceMessagingUserGetVoicePortalPasswordInfoRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
