using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterReportSchedule 
{
    [XmlElement(ElementName = "scheduleTime", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportScheduleTime ScheduleTime { get; set; }
    [XmlElement(ElementName = "recurrence", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportScheduleRecurrence Recurrence { get; set; }
 }
}
