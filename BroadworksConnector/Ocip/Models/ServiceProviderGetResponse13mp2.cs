using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderGetResponse13mp2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
    private bool _useCustomRoutingProfile;

    [XmlElement(ElementName = "useCustomRoutingProfile", IsNullable = false, Namespace = "")]
    public bool UseCustomRoutingProfile {
        get => _useCustomRoutingProfile;
        set {
            UseCustomRoutingProfileSpecified = true;
            _useCustomRoutingProfile = value;
        }
    }

    [XmlIgnore]
    public bool UseCustomRoutingProfileSpecified { get; set; }
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
    private string _serviceProviderName;

    [XmlElement(ElementName = "serviceProviderName", IsNullable = false, Namespace = "")]
    public string ServiceProviderName {
        get => _serviceProviderName;
        set {
            ServiceProviderNameSpecified = true;
            _serviceProviderName = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderNameSpecified { get; set; }
    private string _supportEmail;

    [XmlElement(ElementName = "supportEmail", IsNullable = false, Namespace = "")]
    public string SupportEmail {
        get => _supportEmail;
        set {
            SupportEmailSpecified = true;
            _supportEmail = value;
        }
    }

    [XmlIgnore]
    public bool SupportEmailSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.Contact _contact;

    [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.Contact Contact {
        get => _contact;
        set {
            ContactSpecified = true;
            _contact = value;
        }
    }

    [XmlIgnore]
    public bool ContactSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.StreetAddress _address;

    [XmlElement(ElementName = "address", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.StreetAddress Address {
        get => _address;
        set {
            AddressSpecified = true;
            _address = value;
        }
    }

    [XmlIgnore]
    public bool AddressSpecified { get; set; }
}
}
