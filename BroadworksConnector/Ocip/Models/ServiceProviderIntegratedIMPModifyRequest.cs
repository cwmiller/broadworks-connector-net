using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderIntegratedIMPModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private bool _useSystemMessagingServer;

    [XmlElement(ElementName = "useSystemMessagingServer", IsNullable = false, Namespace = "")]
    public bool UseSystemMessagingServer {
        get => _useSystemMessagingServer;
        set {
            UseSystemMessagingServerSpecified = true;
            _useSystemMessagingServer = value;
        }
    }

    [XmlIgnore]
    public bool UseSystemMessagingServerSpecified { get; set; }
    private string _provisioningUrl;

    [XmlElement(ElementName = "provisioningUrl", IsNullable = true, Namespace = "")]
    public string ProvisioningUrl {
        get => _provisioningUrl;
        set {
            ProvisioningUrlSpecified = true;
            _provisioningUrl = value;
        }
    }

    [XmlIgnore]
    public bool ProvisioningUrlSpecified { get; set; }
    private string _provisioningUserId;

    [XmlElement(ElementName = "provisioningUserId", IsNullable = true, Namespace = "")]
    public string ProvisioningUserId {
        get => _provisioningUserId;
        set {
            ProvisioningUserIdSpecified = true;
            _provisioningUserId = value;
        }
    }

    [XmlIgnore]
    public bool ProvisioningUserIdSpecified { get; set; }
    private string _provisioningPassword;

    [XmlElement(ElementName = "provisioningPassword", IsNullable = true, Namespace = "")]
    public string ProvisioningPassword {
        get => _provisioningPassword;
        set {
            ProvisioningPasswordSpecified = true;
            _provisioningPassword = value;
        }
    }

    [XmlIgnore]
    public bool ProvisioningPasswordSpecified { get; set; }
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
    private BroadWorksConnector.Ocip.Models.IntegratedIMPUserIDType _defaultImpIdType;

    [XmlElement(ElementName = "defaultImpIdType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.IntegratedIMPUserIDType DefaultImpIdType {
        get => _defaultImpIdType;
        set {
            DefaultImpIdTypeSpecified = true;
            _defaultImpIdType = value;
        }
    }

    [XmlIgnore]
    public bool DefaultImpIdTypeSpecified { get; set; }
    private bool _useResellerIMPIdSetting;

    [XmlElement(ElementName = "useResellerIMPIdSetting", IsNullable = false, Namespace = "")]
    public bool UseResellerIMPIdSetting {
        get => _useResellerIMPIdSetting;
        set {
            UseResellerIMPIdSettingSpecified = true;
            _useResellerIMPIdSetting = value;
        }
    }

    [XmlIgnore]
    public bool UseResellerIMPIdSettingSpecified { get; set; }
}
}
