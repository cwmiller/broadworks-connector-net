using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingModifyConferenceGreetingRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _entranceGreetingFile;

    [XmlElement(ElementName = "entranceGreetingFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource EntranceGreetingFile {
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
