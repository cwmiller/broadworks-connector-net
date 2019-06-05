using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServicePackGetServiceUsageListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.UserService _serviceName;

    [XmlElement(ElementName = "serviceName", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.UserService ServiceName {
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
