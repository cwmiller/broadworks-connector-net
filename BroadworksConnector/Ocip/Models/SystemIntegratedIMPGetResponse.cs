using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemIntegratedIMPGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
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
    private int _servicePort;

    [XmlElement(ElementName = "servicePort", IsNullable = false, Namespace = "")]
    public int ServicePort {
        get => _servicePort;
        set {
            ServicePortSpecified = true;
            _servicePort = value;
        }
    }

    [XmlIgnore]
    public bool ServicePortSpecified { get; set; }
    private bool _addServiceProviderInIMPUserId;

    [XmlElement(ElementName = "addServiceProviderInIMPUserId", IsNullable = false, Namespace = "")]
    public bool AddServiceProviderInIMPUserId {
        get => _addServiceProviderInIMPUserId;
        set {
            AddServiceProviderInIMPUserIdSpecified = true;
            _addServiceProviderInIMPUserId = value;
        }
    }

    [XmlIgnore]
    public bool AddServiceProviderInIMPUserIdSpecified { get; set; }
}
}
