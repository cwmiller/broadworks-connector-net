using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactUserRouteListAssignment : BroadworksConnector.Ocip.Models.SearchCriteria
{
    private bool _assigned;

    [XmlElement(ElementName = "assigned", IsNullable = false, Namespace = "")]
    public bool Assigned {
        get => _assigned;
        set {
            AssignedSpecified = true;
            _assigned = value;
        }
    }

    [XmlIgnore]
    public bool AssignedSpecified { get; set; }
}
}
