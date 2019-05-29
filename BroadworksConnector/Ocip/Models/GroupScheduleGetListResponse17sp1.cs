using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupScheduleGetListResponse17sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "scheduleGlobalKey", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ScheduleGlobalKey> ScheduleGlobalKey { get; set; }
 }
}
