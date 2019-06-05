using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDialableCallerIDCriteriaAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _name;

    [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
    public string Name {
        get => _name;
        set {
            NameSpecified = true;
            _name = value;
        }
    }

    [XmlIgnore]
    public bool NameSpecified { get; set; }
    private string _description;

    [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
    public string Description {
        get => _description;
        set {
            DescriptionSpecified = true;
            _description = value;
        }
    }

    [XmlIgnore]
    public bool DescriptionSpecified { get; set; }
    private string _prefixDigits;

    [XmlElement(ElementName = "prefixDigits", IsNullable = false, Namespace = "")]
    public string PrefixDigits {
        get => _prefixDigits;
        set {
            PrefixDigitsSpecified = true;
            _prefixDigits = value;
        }
    }

    [XmlIgnore]
    public bool PrefixDigitsSpecified { get; set; }
    private List<string> _matchCallType;

    [XmlElement(ElementName = "matchCallType", IsNullable = false, Namespace = "")]
    public List<string> MatchCallType {
        get => _matchCallType;
        set {
            MatchCallTypeSpecified = true;
            _matchCallType = value;
        }
    }

    [XmlIgnore]
    public bool MatchCallTypeSpecified { get; set; }
    private List<string> _matchAlternateCallIndicator;

    [XmlElement(ElementName = "matchAlternateCallIndicator", IsNullable = false, Namespace = "")]
    public List<string> MatchAlternateCallIndicator {
        get => _matchAlternateCallIndicator;
        set {
            MatchAlternateCallIndicatorSpecified = true;
            _matchAlternateCallIndicator = value;
        }
    }

    [XmlIgnore]
    public bool MatchAlternateCallIndicatorSpecified { get; set; }
    private bool _matchLocalCategory;

    [XmlElement(ElementName = "matchLocalCategory", IsNullable = false, Namespace = "")]
    public bool MatchLocalCategory {
        get => _matchLocalCategory;
        set {
            MatchLocalCategorySpecified = true;
            _matchLocalCategory = value;
        }
    }

    [XmlIgnore]
    public bool MatchLocalCategorySpecified { get; set; }
    private bool _matchNationalCategory;

    [XmlElement(ElementName = "matchNationalCategory", IsNullable = false, Namespace = "")]
    public bool MatchNationalCategory {
        get => _matchNationalCategory;
        set {
            MatchNationalCategorySpecified = true;
            _matchNationalCategory = value;
        }
    }

    [XmlIgnore]
    public bool MatchNationalCategorySpecified { get; set; }
    private bool _matchInterlataCategory;

    [XmlElement(ElementName = "matchInterlataCategory", IsNullable = false, Namespace = "")]
    public bool MatchInterlataCategory {
        get => _matchInterlataCategory;
        set {
            MatchInterlataCategorySpecified = true;
            _matchInterlataCategory = value;
        }
    }

    [XmlIgnore]
    public bool MatchInterlataCategorySpecified { get; set; }
    private bool _matchIntralataCategory;

    [XmlElement(ElementName = "matchIntralataCategory", IsNullable = false, Namespace = "")]
    public bool MatchIntralataCategory {
        get => _matchIntralataCategory;
        set {
            MatchIntralataCategorySpecified = true;
            _matchIntralataCategory = value;
        }
    }

    [XmlIgnore]
    public bool MatchIntralataCategorySpecified { get; set; }
    private bool _matchInternationalCategory;

    [XmlElement(ElementName = "matchInternationalCategory", IsNullable = false, Namespace = "")]
    public bool MatchInternationalCategory {
        get => _matchInternationalCategory;
        set {
            MatchInternationalCategorySpecified = true;
            _matchInternationalCategory = value;
        }
    }

    [XmlIgnore]
    public bool MatchInternationalCategorySpecified { get; set; }
    private bool _matchPrivateCategory;

    [XmlElement(ElementName = "matchPrivateCategory", IsNullable = false, Namespace = "")]
    public bool MatchPrivateCategory {
        get => _matchPrivateCategory;
        set {
            MatchPrivateCategorySpecified = true;
            _matchPrivateCategory = value;
        }
    }

    [XmlIgnore]
    public bool MatchPrivateCategorySpecified { get; set; }
    private bool _matchEmergencyCategory;

    [XmlElement(ElementName = "matchEmergencyCategory", IsNullable = false, Namespace = "")]
    public bool MatchEmergencyCategory {
        get => _matchEmergencyCategory;
        set {
            MatchEmergencyCategorySpecified = true;
            _matchEmergencyCategory = value;
        }
    }

    [XmlIgnore]
    public bool MatchEmergencyCategorySpecified { get; set; }
    private bool _matchOtherCategory;

    [XmlElement(ElementName = "matchOtherCategory", IsNullable = false, Namespace = "")]
    public bool MatchOtherCategory {
        get => _matchOtherCategory;
        set {
            MatchOtherCategorySpecified = true;
            _matchOtherCategory = value;
        }
    }

    [XmlIgnore]
    public bool MatchOtherCategorySpecified { get; set; }
}
}
