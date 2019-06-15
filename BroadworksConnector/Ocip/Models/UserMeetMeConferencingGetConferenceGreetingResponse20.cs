using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserMeetMeConferencingGetConferenceGreetingRequest20.
    /// Contains the information of a conference custom greeting.
        /// <see cref="UserMeetMeConferencingGetConferenceGreetingRequest20"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserMeetMeConferencingGetConferenceGreetingResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
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
        
        private BroadWorksConnector.Ocip.Models.AnnouncementFileKey _entranceGreetingFile;

        [XmlElement(ElementName = "entranceGreetingFile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileKey EntranceGreetingFile {
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
