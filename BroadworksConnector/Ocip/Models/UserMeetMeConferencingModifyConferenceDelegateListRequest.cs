using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the existing conference delegates list.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserMeetMeConferencingModifyConferenceDelegateListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _conferenceDelegateUserList;

        [XmlElement(ElementName = "conferenceDelegateUserList", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList ConferenceDelegateUserList {
            get => _conferenceDelegateUserList;
            set {
                ConferenceDelegateUserListSpecified = true;
                _conferenceDelegateUserList = value;
            }
        }

        [XmlIgnore]
        public bool ConferenceDelegateUserListSpecified { get; set; }
        
    }
}
