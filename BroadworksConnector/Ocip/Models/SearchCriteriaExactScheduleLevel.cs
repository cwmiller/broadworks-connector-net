using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactScheduleLevel : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "level", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ScheduleLevel Level { get; set; }
 }
}
