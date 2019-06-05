using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServiceCodeGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceCode> _searchCriteriaServiceCode;

    [XmlElement(ElementName = "searchCriteriaServiceCode", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceCode> SearchCriteriaServiceCode {
        get => _searchCriteriaServiceCode;
        set {
            SearchCriteriaServiceCodeSpecified = true;
            _searchCriteriaServiceCode = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaServiceCodeSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceCodeDescription> _searchCriteriaServiceCodeDescription;

    [XmlElement(ElementName = "searchCriteriaServiceCodeDescription", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceCodeDescription> SearchCriteriaServiceCodeDescription {
        get => _searchCriteriaServiceCodeDescription;
        set {
            SearchCriteriaServiceCodeDescriptionSpecified = true;
            _searchCriteriaServiceCodeDescription = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaServiceCodeDescriptionSpecified { get; set; }
}
}
