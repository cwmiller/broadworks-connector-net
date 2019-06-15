using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the user's voice messaging greeting information.
    /// The response is either a UserVoiceMessagingUserGetGreetingResponse18sp1 or an ErrorResponse.
    /// 
    /// Replaced by: UserVoiceMessagingUserGetGreetingRequest20 in AS data mode
        /// <see cref="UserVoiceMessagingUserGetGreetingResponse18sp1"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="UserVoiceMessagingUserGetGreetingRequest20"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserVoiceMessagingUserGetGreetingRequest18sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
