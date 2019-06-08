using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisor : BroadWorksConnector.Ocip.Models.SearchCriteria
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
