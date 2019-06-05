using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderGetDefaultResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _isEnterprise;

    [XmlElement(ElementName = "isEnterprise", IsNullable = false, Namespace = "")]
    public bool IsEnterprise {
        get => _isEnterprise;
        set {
            IsEnterpriseSpecified = true;
            _isEnterprise = value;
        }
    }

    [XmlIgnore]
    public bool IsEnterpriseSpecified { get; set; }
    private string _defaultDomain;

    [XmlElement(ElementName = "defaultDomain", IsNullable = false, Namespace = "")]
    public string DefaultDomain {
        get => _defaultDomain;
        set {
            DefaultDomainSpecified = true;
            _defaultDomain = value;
        }
    }

    [XmlIgnore]
    public bool DefaultDomainSpecified { get; set; }
}
}
