using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemScheduleAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "scheduleName", IsNullable = false)]
    public string ScheduleName { get; set; }
    [XmlElement(ElementName = "scheduleType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ScheduleType ScheduleType { get; set; }
 }
}
