using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCommunicationBarringIncomingCriteriaModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "newName", IsNullable = false)]
    public string NewName { get; set; }
    [XmlElement(ElementName = "description", IsNullable = true)]
    public string Description { get; set; }
    [XmlElement(ElementName = "timeSchedule", IsNullable = true)]
    public string TimeSchedule { get; set; }
    [XmlElement(ElementName = "holidaySchedule", IsNullable = true)]
    public string HolidaySchedule { get; set; }
    [XmlElement(ElementName = "matchNumberPortabilityStatus", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementNumberPortabilityStatusList MatchNumberPortabilityStatus { get; set; }
 }
}
