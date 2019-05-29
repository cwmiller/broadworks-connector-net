using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserExecutiveGetFilteringSelectiveCriteriaResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "timeSchedule", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeSchedule TimeSchedule { get; set; }
    [XmlElement(ElementName = "holidaySchedule", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.HolidaySchedule HolidaySchedule { get; set; }
    [XmlElement(ElementName = "filter", IsNullable = false)]
    public bool Filter { get; set; }
    [XmlElement(ElementName = "fromDnCriteria", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExecutiveCallFilteringCriteriaFromDn FromDnCriteria { get; set; }
 }
}
