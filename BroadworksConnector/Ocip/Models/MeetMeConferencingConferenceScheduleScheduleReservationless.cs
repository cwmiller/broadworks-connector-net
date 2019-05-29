using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MeetMeConferencingConferenceScheduleScheduleReservationless 
{
    [XmlElement(ElementName = "startTime", IsNullable = false)]
    public string StartTime { get; set; }
    [XmlElement(ElementName = "endTime", IsNullable = true)]
    public string EndTime { get; set; }
 }
}
