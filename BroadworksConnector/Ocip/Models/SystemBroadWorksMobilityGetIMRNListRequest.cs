using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityGetIMRNListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaIMRN> _searchCriteriaIMRN;

    [XmlElement(ElementName = "searchCriteriaIMRN", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaIMRN> SearchCriteriaIMRN {
        get => _searchCriteriaIMRN;
        set {
            SearchCriteriaIMRNSpecified = true;
            _searchCriteriaIMRN = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaIMRNSpecified { get; set; }
}
}
