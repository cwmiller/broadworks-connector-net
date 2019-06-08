using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityGetIMRNListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaIMRN> _searchCriteriaIMRN;

    [XmlElement(ElementName = "searchCriteriaIMRN", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaIMRN> SearchCriteriaIMRN {
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
