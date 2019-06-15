using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the Call Recording attributes for a user.
    /// The response is either a UserCallRecordingGetResponse20 or an ErrorResponse.
    /// 
    /// The following parameters are not returned for service instance:
    /// - pauseResumeNotification
    /// - enableCallRecordingAnnouncement
    /// - enableRecordCallRepeatWarningTone
    /// - recordCallRepeatWarningToneTimerSeconds
        /// <see cref="UserCallRecordingGetResponse20"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallRecordingGetRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
