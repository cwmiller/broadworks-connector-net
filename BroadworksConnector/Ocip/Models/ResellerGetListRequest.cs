using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private int _responseSizeLimit;

    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
    public int ResponseSizeLimit {
        get => _responseSizeLimit;
        set {
            ResponseSizeLimitSpecified = true;
            _responseSizeLimit = value;
        }
    }

    [XmlIgnore]
    public bool ResponseSizeLimitSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerId> _searchCriteriaResellerId;

    [XmlElement(ElementName = "searchCriteriaResellerId", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerId> SearchCriteriaResellerId {
        get => _searchCriteriaResellerId;
        set {
            SearchCriteriaResellerIdSpecified = true;
            _searchCriteriaResellerId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaResellerIdSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerName> _searchCriteriaResellerName;

    [XmlElement(ElementName = "searchCriteriaResellerName", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerName> SearchCriteriaResellerName {
        get => _searchCriteriaResellerName;
        set {
            SearchCriteriaResellerNameSpecified = true;
            _searchCriteriaResellerName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaResellerNameSpecified { get; set; }
}
}
