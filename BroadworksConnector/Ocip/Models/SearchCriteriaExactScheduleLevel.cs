using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactScheduleLevel : BroadworksConnector.Ocip.Models.SearchCriteria
{
    private BroadworksConnector.Ocip.Models.ScheduleLevel _level;

    [XmlElement(ElementName = "level", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ScheduleLevel Level {
        get => _level;
        set {
            LevelSpecified = true;
            _level = value;
        }
    }

    [XmlIgnore]
    public bool LevelSpecified { get; set; }
}
}
