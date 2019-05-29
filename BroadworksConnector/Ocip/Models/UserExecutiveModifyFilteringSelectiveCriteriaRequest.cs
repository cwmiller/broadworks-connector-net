using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserExecutiveModifyFilteringSelectiveCriteriaRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    [XmlElement(ElementName = "filter", IsNullable = false)]
    public bool Filter { get; set; }
    [XmlElement(ElementName = "fromDnCriteria", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExecutiveCallFilteringCriteriaFromDnModify FromDnCriteria { get; set; }
    [XmlElement(ElementName = "callToNumberList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementCallToNumberList CallToNumberList { get; set; }
 }
}
