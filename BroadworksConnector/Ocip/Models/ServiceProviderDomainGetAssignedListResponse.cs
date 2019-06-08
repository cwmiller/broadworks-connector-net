using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDomainGetAssignedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _serviceProviderDefaultDomain;

    [XmlElement(ElementName = "serviceProviderDefaultDomain", IsNullable = false, Namespace = "")]
    public string ServiceProviderDefaultDomain {
        get => _serviceProviderDefaultDomain;
        set {
            ServiceProviderDefaultDomainSpecified = true;
            _serviceProviderDefaultDomain = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderDefaultDomainSpecified { get; set; }
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
