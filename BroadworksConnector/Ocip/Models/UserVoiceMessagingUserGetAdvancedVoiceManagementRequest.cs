using System;
using System.Xml.Serialization;
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
     
    public class UserVoiceMessagingUserGetAdvancedVoiceManagementRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
