using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CollaborateRoomScheduleScheduleOneTime 
{
    [XmlElement(ElementName = "startTime", IsNullable = false)]
    public string StartTime { get; set; }
    [XmlElement(ElementName = "duration", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CollaborateRoomScheduleDuration Duration { get; set; }
 }
}
