using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingAddConferenceRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "bridgeId", IsNullable = false)]
    public string BridgeId { get; set; }
    [XmlElement(ElementName = "title", IsNullable = false)]
    public string Title { get; set; }
    [XmlElement(ElementName = "estimatedParticipants", IsNullable = false)]
    public int EstimatedParticipants { get; set; }
    [XmlElement(ElementName = "restrictParticipants", IsNullable = false)]
    public bool RestrictParticipants { get; set; }
    [XmlElement(ElementName = "maxParticipants", IsNullable = false)]
    public int MaxParticipants { get; set; }
    [XmlElement(ElementName = "accountCode", IsNullable = false)]
    public string AccountCode { get; set; }
    [XmlElement(ElementName = "muteAllAttendeesOnEntry", IsNullable = false)]
    public bool MuteAllAttendeesOnEntry { get; set; }
    [XmlElement(ElementName = "endConferenceOnModeratorExit", IsNullable = false)]
    public bool EndConferenceOnModeratorExit { get; set; }
    [XmlElement(ElementName = "moderatorRequired", IsNullable = false)]
    public bool ModeratorRequired { get; set; }
    [XmlElement(ElementName = "attendeeNotification", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceAttendeeNotification AttendeeNotification { get; set; }
    [XmlElement(ElementName = "conferenceSchedule", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceSchedule ConferenceSchedule { get; set; }
 }
}
