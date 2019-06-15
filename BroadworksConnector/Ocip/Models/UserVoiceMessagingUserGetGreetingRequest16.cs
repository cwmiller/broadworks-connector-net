using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the user's voice messaging greeting information.
    /// The response is either a UserVoiceMessagingUserGetGreetingResponse16 or an ErrorResponse.
    /// 
    /// Replaced by: UserVoiceMessagingUserGetGreetingRequest18
        /// <see cref="UserVoiceMessagingUserGetGreetingResponse16"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserVoiceMessagingUserGetGreetingRequest18"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserVoiceMessagingUserGetGreetingRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
