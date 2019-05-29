using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class TimeInterval 
{
    [XmlElement(ElementName = "startDayOfWeek", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DayOfWeek StartDayOfWeek { get; set; }
    [XmlElement(ElementName = "startHour", IsNullable = false)]
    public int StartHour { get; set; }
    [XmlElement(ElementName = "startMinute", IsNullable = false)]
    public int StartMinute { get; set; }
    [XmlElement(ElementName = "endDayOfWeek", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DayOfWeek EndDayOfWeek { get; set; }
    [XmlElement(ElementName = "endHour", IsNullable = false)]
    public int EndHour { get; set; }
    [XmlElement(ElementName = "endMinute", IsNullable = false)]
    public int EndMinute { get; set; }
 }
}
