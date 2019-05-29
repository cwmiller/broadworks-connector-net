using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterReportScheduleTime 
{
    [XmlElement(ElementName = "timeZone", IsNullable = false)]
    public string TimeZone { get; set; }
    [XmlElement(ElementName = "scheduleDate", IsNullable = false)]
    public string ScheduleDate { get; set; }
    [XmlElement(ElementName = "scheduleTime", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.HourMinute ScheduleTime { get; set; }
 }
}
