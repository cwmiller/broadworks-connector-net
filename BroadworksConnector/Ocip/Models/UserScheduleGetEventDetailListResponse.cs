using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserScheduleGetEventDetailListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "scheduleEvents", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ScheduleEvents> ScheduleEvents { get; set; }
 }
}
