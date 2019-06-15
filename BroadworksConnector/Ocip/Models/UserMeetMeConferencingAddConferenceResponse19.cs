using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserMeetMeConferencingAddConferenceRequest19.
    /// Contains the information of a conference.
        /// <see cref="UserMeetMeConferencingAddConferenceRequest19"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserMeetMeConferencingAddConferenceResponse19 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _conferenceId;

        [XmlElement(ElementName = "conferenceId", IsNullable = false, Namespace = "")]
        public string ConferenceId {
            get => _conferenceId;
            set {
                ConferenceIdSpecified = true;
                _conferenceId = value;
            }
        }

        [XmlIgnore]
        public bool ConferenceIdSpecified { get; set; }
        
        private string _moderatorPin;

        [XmlElement(ElementName = "moderatorPin", IsNullable = false, Namespace = "")]
        public string ModeratorPin {
            get => _moderatorPin;
            set {
                ModeratorPinSpecified = true;
                _moderatorPin = value;
            }
        }

        [XmlIgnore]
        public bool ModeratorPinSpecified { get; set; }
        
        private string _securityPin;

        [XmlElement(ElementName = "securityPin", IsNullable = false, Namespace = "")]
        public string SecurityPin {
            get => _securityPin;
            set {
                SecurityPinSpecified = true;
                _securityPin = value;
            }
        }

        [XmlIgnore]
        public bool SecurityPinSpecified { get; set; }
        
    }
}
