using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSequentialRingAddCriteriaRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "criteriaName", IsNullable = false)]
    public string CriteriaName { get; set; }
    [XmlElement(ElementName = "timeSchedule", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeSchedule TimeSchedule { get; set; }
    [XmlElement(ElementName = "fromDnCriteria", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CriteriaFromDn FromDnCriteria { get; set; }
 }
}
