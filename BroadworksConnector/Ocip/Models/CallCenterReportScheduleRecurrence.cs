using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterReportScheduleRecurrence 
{
    [XmlElement(ElementName = "timeZone", IsNullable = false)]
    public string TimeZone { get; set; }
    [XmlElement(ElementName = "startDate", IsNullable = false)]
    public string StartDate { get; set; }
    [XmlElement(ElementName = "scheduleTime", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.HourMinute ScheduleTime { get; set; }
    [XmlElement(ElementName = "recurrence", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.Recurrence Recurrence { get; set; }
 }
}
