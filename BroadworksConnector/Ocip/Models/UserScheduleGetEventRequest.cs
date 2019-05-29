using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserScheduleGetEventRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "scheduleKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ScheduleKey ScheduleKey { get; set; }
    [XmlElement(ElementName = "eventName", IsNullable = false)]
    public string EventName { get; set; }
 }
}
