using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAddRequest13mp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _servicePolicy;

    [XmlElement(ElementName = "servicePolicy", IsNullable = false, Namespace = "")]
    public string ServicePolicy {
        get => _servicePolicy;
        set {
            ServicePolicySpecified = true;
            _servicePolicy = value;
        }
    }

    [XmlIgnore]
    public bool ServicePolicySpecified { get; set; }
    private string _callProcessingSliceId;

    [XmlElement(ElementName = "callProcessingSliceId", IsNullable = false, Namespace = "")]
    public string CallProcessingSliceId {
        get => _callProcessingSliceId;
        set {
            CallProcessingSliceIdSpecified = true;
            _callProcessingSliceId = value;
        }
    }

    [XmlIgnore]
    public bool CallProcessingSliceIdSpecified { get; set; }
    private string _provisioningSliceId;

    [XmlElement(ElementName = "provisioningSliceId", IsNullable = false, Namespace = "")]
    public string ProvisioningSliceId {
        get => _provisioningSliceId;
        set {
            ProvisioningSliceIdSpecified = true;
            _provisioningSliceId = value;
        }
    }

    [XmlIgnore]
    public bool ProvisioningSliceIdSpecified { get; set; }
    private string _subscriberPartition;

    [XmlElement(ElementName = "subscriberPartition", IsNullable = false, Namespace = "")]
    public string SubscriberPartition {
        get => _subscriberPartition;
        set {
            SubscriberPartitionSpecified = true;
            _subscriberPartition = value;
        }
    }

    [XmlIgnore]
    public bool SubscriberPartitionSpecified { get; set; }
    private string _preferredDataCenter;

    [XmlElement(ElementName = "preferredDataCenter", IsNullable = false, Namespace = "")]
    public string PreferredDataCenter {
        get => _preferredDataCenter;
        set {
            PreferredDataCenterSpecified = true;
            _preferredDataCenter = value;
        }
    }

    [XmlIgnore]
    public bool PreferredDataCenterSpecified { get; set; }
    private string _resellerId;

    [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
    public string ResellerId {
        get => _resellerId;
        set {
            ResellerIdSpecified = true;
            _resellerId = value;
        }
    }

    [XmlIgnore]
    public bool ResellerIdSpecified { get; set; }
}
}