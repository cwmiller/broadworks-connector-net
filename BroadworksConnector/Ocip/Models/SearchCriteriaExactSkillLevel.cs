using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactSkillLevel : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "skillLevel", IsNullable = false)]
    public int SkillLevel { get; set; }
 }
}
