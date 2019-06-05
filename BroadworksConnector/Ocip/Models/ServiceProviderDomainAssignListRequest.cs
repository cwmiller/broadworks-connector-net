using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDomainAssignListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<string> _domain;

    [XmlElement(ElementName = "domain", IsNullable = false, Namespace = "")]
    public List<string> Domain {
        get => _domain;
        set {
            DomainSpecified = true;
            _domain = value;
        }
    }

    [XmlIgnore]
    public bool DomainSpecified { get; set; }
}
}
