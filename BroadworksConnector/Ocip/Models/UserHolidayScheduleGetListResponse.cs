using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserHolidayScheduleGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "holidayScheduleTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable HolidayScheduleTable { get; set; }
 }
}
