using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ScheduleGlobalKey 
{
    [XmlElement(ElementName = "scheduleKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ScheduleKey ScheduleKey { get; set; }
    [XmlElement(ElementName = "scheduleLevel", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ScheduleLevel ScheduleLevel { get; set; }
 }
}
