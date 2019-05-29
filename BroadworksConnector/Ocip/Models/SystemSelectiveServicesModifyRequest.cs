using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSelectiveServicesModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "scheduleCombination", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ScheduleCombinationType ScheduleCombination { get; set; }
    [XmlElement(ElementName = "screenPrivateNumber", IsNullable = false)]
    public bool ScreenPrivateNumber { get; set; }
    [XmlElement(ElementName = "emptyHolidayScheduleIsOutOfSchedule", IsNullable = false)]
    public bool EmptyHolidayScheduleIsOutOfSchedule { get; set; }
 }
}
