using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingDeleteConferenceRecordingListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceRecordingKey> _recordingKey;

    [XmlElement(ElementName = "recordingKey", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceRecordingKey> RecordingKey {
        get => _recordingKey;
        set {
            RecordingKeySpecified = true;
            _recordingKey = value;
        }
    }

    [XmlIgnore]
    public bool RecordingKeySpecified { get; set; }
}
}
