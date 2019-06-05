using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderNumberPortabilityQueryGetRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private bool _includeDigitPatterns;

    [XmlElement(ElementName = "includeDigitPatterns", IsNullable = false, Namespace = "")]
    public bool IncludeDigitPatterns {
        get => _includeDigitPatterns;
        set {
            IncludeDigitPatternsSpecified = true;
            _includeDigitPatterns = value;
        }
    }

    [XmlIgnore]
    public bool IncludeDigitPatternsSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceProviderNumberPortabilityQueryDigitPattern> _searchCriteriaServiceProviderNumberPortabilityQueryDigitPattern;

    [XmlElement(ElementName = "searchCriteriaServiceProviderNumberPortabilityQueryDigitPattern", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceProviderNumberPortabilityQueryDigitPattern> SearchCriteriaServiceProviderNumberPortabilityQueryDigitPattern {
        get => _searchCriteriaServiceProviderNumberPortabilityQueryDigitPattern;
        set {
            SearchCriteriaServiceProviderNumberPortabilityQueryDigitPatternSpecified = true;
            _searchCriteriaServiceProviderNumberPortabilityQueryDigitPattern = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaServiceProviderNumberPortabilityQueryDigitPatternSpecified { get; set; }
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
