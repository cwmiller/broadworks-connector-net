using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServiceCodeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceCode> _searchCriteriaServiceCode;

    [XmlElement(ElementName = "searchCriteriaServiceCode", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceCode> SearchCriteriaServiceCode {
        get => _searchCriteriaServiceCode;
        set {
            SearchCriteriaServiceCodeSpecified = true;
            _searchCriteriaServiceCode = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaServiceCodeSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceCodeDescription> _searchCriteriaServiceCodeDescription;

    [XmlElement(ElementName = "searchCriteriaServiceCodeDescription", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceCodeDescription> SearchCriteriaServiceCodeDescription {
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
