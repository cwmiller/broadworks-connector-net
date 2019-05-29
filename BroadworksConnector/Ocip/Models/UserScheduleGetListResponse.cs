using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserScheduleGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "scheduleName", IsNullable = false)]
    public List<string> ScheduleName { get; set; }
    [XmlElement(ElementName = "scheduleType", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ScheduleType> ScheduleType { get; set; }
    [XmlElement(ElementName = "scheduleLevel", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ScheduleLevel> ScheduleLevel { get; set; }
 }
}
