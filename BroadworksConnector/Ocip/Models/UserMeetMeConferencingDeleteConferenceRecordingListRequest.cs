using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingDeleteConferenceRecordingListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "recordingKey", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceRecordingKey> RecordingKey { get; set; }
 }
}
