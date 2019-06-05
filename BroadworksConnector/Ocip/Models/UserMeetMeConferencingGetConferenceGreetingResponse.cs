using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingGetConferenceGreetingResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    private string _entranceGreetingAudioFile;

    [XmlElement(ElementName = "entranceGreetingAudioFile", IsNullable = false, Namespace = "")]
    public string EntranceGreetingAudioFile {
        get => _entranceGreetingAudioFile;
        set {
            EntranceGreetingAudioFileSpecified = true;
            _entranceGreetingAudioFile = value;
        }
    }

    [XmlIgnore]
    public bool EntranceGreetingAudioFileSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MediaFileType _entranceGreetingMediaType;

    [XmlElement(ElementName = "entranceGreetingMediaType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MediaFileType EntranceGreetingMediaType {
        get => _entranceGreetingMediaType;
        set {
            EntranceGreetingMediaTypeSpecified = true;
            _entranceGreetingMediaType = value;
        }
    }

    [XmlIgnore]
    public bool EntranceGreetingMediaTypeSpecified { get; set; }
}
}
