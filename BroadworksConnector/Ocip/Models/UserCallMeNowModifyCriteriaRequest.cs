using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallMeNowModifyCriteriaRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "criteriaName", IsNullable = false)]
    public string CriteriaName { get; set; }
    [XmlElement(ElementName = "newCriteriaName", IsNullable = false)]
    public string NewCriteriaName { get; set; }
    [XmlElement(ElementName = "timeSchedule", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.TimeSchedule TimeSchedule { get; set; }
    [XmlElement(ElementName = "holidaySchedule", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.HolidaySchedule HolidaySchedule { get; set; }
    [XmlElement(ElementName = "rejectCall", IsNullable = false)]
    public bool RejectCall { get; set; }
    [XmlElement(ElementName = "toDnCriteria", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallMeNowToDnCriteriaModify ToDnCriteria { get; set; }
 }
}
