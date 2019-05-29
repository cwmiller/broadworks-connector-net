using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserScheduleGetEventResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
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
    [XmlElement(ElementName = "recurrence", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.Recurrence Recurrence { get; set; }
 }
}
