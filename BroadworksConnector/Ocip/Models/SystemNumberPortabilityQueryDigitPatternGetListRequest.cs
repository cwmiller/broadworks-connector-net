using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberPortabilityQueryDigitPatternGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaNumberPortabilityQueryDigitPattern> _searchCriteriaNumberPortabilityQueryDigitPattern;

    [XmlElement(ElementName = "searchCriteriaNumberPortabilityQueryDigitPattern", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaNumberPortabilityQueryDigitPattern> SearchCriteriaNumberPortabilityQueryDigitPattern {
        get => _searchCriteriaNumberPortabilityQueryDigitPattern;
        set {
            SearchCriteriaNumberPortabilityQueryDigitPatternSpecified = true;
            _searchCriteriaNumberPortabilityQueryDigitPattern = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaNumberPortabilityQueryDigitPatternSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaNumberPortabilityStatus> _searchCriteriaNumberPortabilityStatus;

    [XmlElement(ElementName = "searchCriteriaNumberPortabilityStatus", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaNumberPortabilityStatus> SearchCriteriaNumberPortabilityStatus {
        get => _searchCriteriaNumberPortabilityStatus;
        set {
            SearchCriteriaNumberPortabilityStatusSpecified = true;
            _searchCriteriaNumberPortabilityStatus = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaNumberPortabilityStatusSpecified { get; set; }
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
}
}
