using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDialableCallerIDModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private bool _useServiceProviderCriteria;

    [XmlElement(ElementName = "useServiceProviderCriteria", IsNullable = false, Namespace = "")]
    public bool UseServiceProviderCriteria {
        get => _useServiceProviderCriteria;
        set {
            UseServiceProviderCriteriaSpecified = true;
            _useServiceProviderCriteria = value;
        }
    }

    [XmlIgnore]
    public bool UseServiceProviderCriteriaSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.NsScreeningFailurePolicy _nsScreeningFailurePolicy;

    [XmlElement(ElementName = "nsScreeningFailurePolicy", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.NsScreeningFailurePolicy NsScreeningFailurePolicy {
        get => _nsScreeningFailurePolicy;
        set {
            NsScreeningFailurePolicySpecified = true;
            _nsScreeningFailurePolicy = value;
        }
    }

    [XmlIgnore]
    public bool NsScreeningFailurePolicySpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.DialableCallerIDCriteriaPriorityOrder> _criteriaPriorityOrder;

    [XmlElement(ElementName = "criteriaPriorityOrder", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.DialableCallerIDCriteriaPriorityOrder> CriteriaPriorityOrder {
        get => _criteriaPriorityOrder;
        set {
            CriteriaPriorityOrderSpecified = true;
            _criteriaPriorityOrder = value;
        }
    }

    [XmlIgnore]
    public bool CriteriaPriorityOrderSpecified { get; set; }
}
}
