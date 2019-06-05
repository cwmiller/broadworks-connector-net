using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemIntegratedIMPModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceDomain;

    [XmlElement(ElementName = "serviceDomain", IsNullable = true, Namespace = "")]
    public string ServiceDomain {
        get => _serviceDomain;
        set {
            ServiceDomainSpecified = true;
            _serviceDomain = value;
        }
    }

    [XmlIgnore]
    public bool ServiceDomainSpecified { get; set; }
    private int? _servicePort;

    [XmlElement(ElementName = "servicePort", IsNullable = true, Namespace = "")]
    public int? ServicePort {
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
    private string _boshURL;

    [XmlElement(ElementName = "boshURL", IsNullable = true, Namespace = "")]
    public string BoshURL {
        get => _boshURL;
        set {
            BoshURLSpecified = true;
            _boshURL = value;
        }
    }

    [XmlIgnore]
    public bool BoshURLSpecified { get; set; }
    private bool _allowImpPasswordRetrieval;

    [XmlElement(ElementName = "allowImpPasswordRetrieval", IsNullable = false, Namespace = "")]
    public bool AllowImpPasswordRetrieval {
        get => _allowImpPasswordRetrieval;
        set {
            AllowImpPasswordRetrievalSpecified = true;
            _allowImpPasswordRetrieval = value;
        }
    }

    [XmlIgnore]
    public bool AllowImpPasswordRetrievalSpecified { get; set; }
}
}
