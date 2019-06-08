using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderIntegratedIMPGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _useSystemServiceDomain;

    [XmlElement(ElementName = "useSystemServiceDomain", IsNullable = false, Namespace = "")]
    public bool UseSystemServiceDomain {
        get => _useSystemServiceDomain;
        set {
            UseSystemServiceDomainSpecified = true;
            _useSystemServiceDomain = value;
        }
    }

    [XmlIgnore]
    public bool UseSystemServiceDomainSpecified { get; set; }
    private string _serviceDomain;

    [XmlElement(ElementName = "serviceDomain", IsNullable = false, Namespace = "")]
    public string ServiceDomain {
        get => _serviceDomain;
        set {
            ServiceDomainSpecified = true;
            _serviceDomain = value;
        }
    }

    [XmlIgnore]
    public bool ServiceDomainSpecified { get; set; }
}
}
