using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupScheduleGetEventDetailListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "scheduleEventsList", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ScheduleEvents> ScheduleEventsList { get; set; }
 }
}
