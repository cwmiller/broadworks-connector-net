using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactOrganizationType : BroadworksConnector.Ocip.Models.SearchCriteria
{
    private BroadworksConnector.Ocip.Models.OrganizationType _organizationType;

    [XmlElement(ElementName = "organizationType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.OrganizationType OrganizationType {
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
