using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingModifyConferenceDelegateListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "conferenceKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceKey ConferenceKey { get; set; }
    [XmlElement(ElementName = "conferenceDelegateUserList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList ConferenceDelegateUserList { get; set; }
 }
}
