using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisor : BroadworksConnector.Ocip.Models.SearchCriteria
{
    private bool _createdBySupervisor;

    [XmlElement(ElementName = "createdBySupervisor", IsNullable = false, Namespace = "")]
    public bool CreatedBySupervisor {
        get => _createdBySupervisor;
        set {
            CreatedBySupervisorSpecified = true;
            _createdBySupervisor = value;
        }
    }

    [XmlIgnore]
    public bool CreatedBySupervisorSpecified { get; set; }
}
}
