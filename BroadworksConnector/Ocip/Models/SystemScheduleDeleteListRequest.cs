using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemScheduleDeleteListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "scheduleKey", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ScheduleKey> ScheduleKey { get; set; }
 }
}
