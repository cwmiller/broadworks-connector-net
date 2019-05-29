using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingModifyConferenceGreetingRequest20 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "conferenceKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceKey ConferenceKey { get; set; }
    [XmlElement(ElementName = "playEntranceGreeting", IsNullable = false)]
    public bool PlayEntranceGreeting { get; set; }
    [XmlElement(ElementName = "entranceGreetingFile", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileKey EntranceGreetingFile { get; set; }
 }
}
