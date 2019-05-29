using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MeetMeConferencingConferenceRecordingKey 
{
    [XmlElement(ElementName = "bridgeId", IsNullable = false)]
    public string BridgeId { get; set; }
    [XmlElement(ElementName = "conferenceId", IsNullable = false)]
    public string ConferenceId { get; set; }
    [XmlElement(ElementName = "startTime", IsNullable = false)]
    public string StartTime { get; set; }
 }
}
