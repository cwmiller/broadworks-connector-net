using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingAddConferenceResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
}
}
