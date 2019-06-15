using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify an existing custom greeting audio file.
    /// The response is either SuccessResponse or ErrorResponse.
    /// Engineering Note: This command can only be executed from the Execution Server
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserMeetMeConferencingModifyConferenceGreetingExecutionServerRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private bool _playEntranceGreeting;

        [XmlElement(ElementName = "playEntranceGreeting", IsNullable = false, Namespace = "")]
        public bool PlayEntranceGreeting {
            get => _playEntranceGreeting;
            set {
                PlayEntranceGreetingSpecified = true;
                _playEntranceGreeting = value;
            }
        }

        [XmlIgnore]
        public bool PlayEntranceGreetingSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.LabeledFileNameResource _entranceGreetingFile;

        [XmlElement(ElementName = "entranceGreetingFile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.LabeledFileNameResource EntranceGreetingFile {
            get => _entranceGreetingFile;
            set {
                EntranceGreetingFileSpecified = true;
                _entranceGreetingFile = value;
            }
        }

        [XmlIgnore]
        public bool EntranceGreetingFileSpecified { get; set; }
        
    }
}
