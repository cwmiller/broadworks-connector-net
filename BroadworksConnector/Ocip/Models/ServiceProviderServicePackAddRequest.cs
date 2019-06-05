using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServicePackAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _servicePackName;

    [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
    public string ServicePackName {
        get => _servicePackName;
        set {
            ServicePackNameSpecified = true;
            _servicePackName = value;
        }
    }

    [XmlIgnore]
    public bool ServicePackNameSpecified { get; set; }
    private string _servicePackDescription;

    [XmlElement(ElementName = "servicePackDescription", IsNullable = false, Namespace = "")]
    public string ServicePackDescription {
        get => _servicePackDescription;
        set {
            ServicePackDescriptionSpecified = true;
            _servicePackDescription = value;
        }
    }

    [XmlIgnore]
    public bool ServicePackDescriptionSpecified { get; set; }
    private bool _isAvailableForUse;

    [XmlElement(ElementName = "isAvailableForUse", IsNullable = false, Namespace = "")]
    public bool IsAvailableForUse {
        get => _isAvailableForUse;
        set {
            IsAvailableForUseSpecified = true;
            _isAvailableForUse = value;
        }
    }

    [XmlIgnore]
    public bool IsAvailableForUseSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.UnboundedPositiveInt _servicePackQuantity;

    [XmlElement(ElementName = "servicePackQuantity", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.UnboundedPositiveInt ServicePackQuantity {
        get => _servicePackQuantity;
        set {
            ServicePackQuantitySpecified = true;
            _servicePackQuantity = value;
        }
    }

    [XmlIgnore]
    public bool ServicePackQuantitySpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.UserService> _serviceName;

    [XmlElement(ElementName = "serviceName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.UserService> ServiceName {
        get => _serviceName;
        set {
            ServiceNameSpecified = true;
            _serviceName = value;
        }
    }

    [XmlIgnore]
    public bool ServiceNameSpecified { get; set; }
}
}
