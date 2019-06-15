using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the information of a conference custom greeting.
    /// The response is either UserMeetMeConferencingGetConferenceGreetingResponse or ErrorResponse.
        /// <see cref="UserMeetMeConferencingGetConferenceGreetingResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserMeetMeConferencingGetConferenceGreetingRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceKey _conferenceKey;

        [XmlElement(ElementName = "conferenceKey", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceKey ConferenceKey {
            get => _conferenceKey;
            set {
                ConferenceKeySpecified = true;
                _conferenceKey = value;
            }
        }

        [XmlIgnore]
        public bool ConferenceKeySpecified { get; set; }
        
    }
}
