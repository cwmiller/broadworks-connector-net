using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserExecutiveModifyFilteringRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private bool _enableFiltering;

    [XmlElement(ElementName = "enableFiltering", IsNullable = false, Namespace = "")]
    public bool EnableFiltering {
        get => _enableFiltering;
        set {
            EnableFilteringSpecified = true;
            _enableFiltering = value;
        }
    }

    [XmlIgnore]
    public bool EnableFilteringSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ExecutiveCallFilteringMode _filteringMode;

    [XmlElement(ElementName = "filteringMode", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ExecutiveCallFilteringMode FilteringMode {
        get => _filteringMode;
        set {
            FilteringModeSpecified = true;
            _filteringMode = value;
        }
    }

    [XmlIgnore]
    public bool FilteringModeSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ExecutiveCallFilteringSimpleFilterType _simpleFilterType;

    [XmlElement(ElementName = "simpleFilterType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ExecutiveCallFilteringSimpleFilterType SimpleFilterType {
        get => _simpleFilterType;
        set {
            SimpleFilterTypeSpecified = true;
            _simpleFilterType = value;
        }
    }

    [XmlIgnore]
    public bool SimpleFilterTypeSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.CriteriaActivation> _criteriaActivation;

    [XmlElement(ElementName = "criteriaActivation", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.CriteriaActivation> CriteriaActivation {
        get => _criteriaActivation;
        set {
            CriteriaActivationSpecified = true;
            _criteriaActivation = value;
        }
    }

    [XmlIgnore]
    public bool CriteriaActivationSpecified { get; set; }
}
}
