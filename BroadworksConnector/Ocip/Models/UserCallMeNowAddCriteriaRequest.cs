using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallMeNowAddCriteriaRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "criteriaName", IsNullable = false)]
    public string CriteriaName { get; set; }
    [XmlElement(ElementName = "timeSchedule", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeSchedule TimeSchedule { get; set; }
    [XmlElement(ElementName = "holidaySchedule", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.HolidaySchedule HolidaySchedule { get; set; }
    [XmlElement(ElementName = "rejectCall", IsNullable = false)]
    public bool RejectCall { get; set; }
    [XmlElement(ElementName = "toDnCriteria", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallMeNowToDnCriteria ToDnCriteria { get; set; }
 }
}
