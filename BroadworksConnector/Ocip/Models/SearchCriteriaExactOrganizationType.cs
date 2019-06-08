using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactOrganizationType : BroadWorksConnector.Ocip.Models.SearchCriteria
{
    private BroadWorksConnector.Ocip.Models.OrganizationType _organizationType;

    [XmlElement(ElementName = "organizationType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.OrganizationType OrganizationType {
        get => _organizationType;
        set {
            OrganizationTypeSpecified = true;
            _organizationType = value;
        }
    }

    [XmlIgnore]
    public bool OrganizationTypeSpecified { get; set; }
}
}
