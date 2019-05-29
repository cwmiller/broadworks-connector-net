using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemScheduleModifyEventRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "scheduleKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ScheduleKey ScheduleKey { get; set; }
    [XmlElement(ElementName = "eventName", IsNullable = false)]
    public string EventName { get; set; }
    [XmlElement(ElementName = "newEventName", IsNullable = false)]
    public string NewEventName { get; set; }
    [XmlElement(ElementName = "startDate", IsNullable = false)]
    public string StartDate { get; set; }
    [XmlElement(ElementName = "allDayEvent", IsNullable = false)]
    public bool AllDayEvent { get; set; }
    [XmlElement(ElementName = "startTime", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.HourMinute StartTime { get; set; }
    [XmlElement(ElementName = "endTime", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.HourMinute EndTime { get; set; }
    [XmlElement(ElementName = "endDate", IsNullable = false)]
    public string EndDate { get; set; }
    [XmlElement(ElementName = "recurrence", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.Recurrence Recurrence { get; set; }
 }
}
