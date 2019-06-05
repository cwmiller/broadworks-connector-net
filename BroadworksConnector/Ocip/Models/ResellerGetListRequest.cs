using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaResellerId> _searchCriteriaResellerId;

    [XmlElement(ElementName = "searchCriteriaResellerId", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaResellerId> SearchCriteriaResellerId {
        get => _searchCriteriaResellerId;
        set {
            SearchCriteriaResellerIdSpecified = true;
            _searchCriteriaResellerId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaResellerIdSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaResellerName> _searchCriteriaResellerName;

    [XmlElement(ElementName = "searchCriteriaResellerName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaResellerName> SearchCriteriaResellerName {
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
