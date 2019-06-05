using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactSkillLevel : BroadworksConnector.Ocip.Models.SearchCriteria
{
    private int _skillLevel;

    [XmlElement(ElementName = "skillLevel", IsNullable = false, Namespace = "")]
    public int SkillLevel {
        get => _skillLevel;
        set {
            SkillLevelSpecified = true;
            _skillLevel = value;
        }
    }

    [XmlIgnore]
    public bool SkillLevelSpecified { get; set; }
}
}
