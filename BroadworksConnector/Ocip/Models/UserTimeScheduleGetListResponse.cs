using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserTimeScheduleGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "timeScheduleTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable TimeScheduleTable { get; set; }
 }
}
