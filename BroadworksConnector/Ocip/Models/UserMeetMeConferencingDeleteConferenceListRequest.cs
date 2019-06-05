using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingDeleteConferenceListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceKey> _conferenceKey;

    [XmlElement(ElementName = "conferenceKey", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceKey> ConferenceKey {
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
