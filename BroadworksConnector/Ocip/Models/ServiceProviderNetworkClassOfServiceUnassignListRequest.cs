using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderNetworkClassOfServiceUnassignListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private List<string> _networkClassOfService;

    [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
    public List<string> NetworkClassOfService {
        get => _networkClassOfService;
        set {
            NetworkClassOfServiceSpecified = true;
            _networkClassOfService = value;
        }
    }

    [XmlIgnore]
    public bool NetworkClassOfServiceSpecified { get; set; }
    private string _defaultNetworkClassOfService;

    [XmlElement(ElementName = "defaultNetworkClassOfService", IsNullable = false, Namespace = "")]
    public string DefaultNetworkClassOfService {
        get => _defaultNetworkClassOfService;
        set {
            DefaultNetworkClassOfServiceSpecified = true;
            _defaultNetworkClassOfService = value;
        }
    }

    [XmlIgnore]
    public bool DefaultNetworkClassOfServiceSpecified { get; set; }
}
}
