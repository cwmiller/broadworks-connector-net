using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDialPlanPolicyModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private bool _requiresAccessCodeForPublicCalls;

    [XmlElement(ElementName = "requiresAccessCodeForPublicCalls", IsNullable = false, Namespace = "")]
    public bool RequiresAccessCodeForPublicCalls {
        get => _requiresAccessCodeForPublicCalls;
        set {
            RequiresAccessCodeForPublicCallsSpecified = true;
            _requiresAccessCodeForPublicCalls = value;
        }
    }

    [XmlIgnore]
    public bool RequiresAccessCodeForPublicCallsSpecified { get; set; }
    private bool _allowE164PublicCalls;

    [XmlElement(ElementName = "allowE164PublicCalls", IsNullable = false, Namespace = "")]
    public bool AllowE164PublicCalls {
        get => _allowE164PublicCalls;
        set {
            AllowE164PublicCallsSpecified = true;
            _allowE164PublicCalls = value;
        }
    }

    [XmlIgnore]
    public bool AllowE164PublicCallsSpecified { get; set; }
    private bool _preferE164NumberFormatForCallbackServices;

    [XmlElement(ElementName = "preferE164NumberFormatForCallbackServices", IsNullable = false, Namespace = "")]
    public bool PreferE164NumberFormatForCallbackServices {
        get => _preferE164NumberFormatForCallbackServices;
        set {
            PreferE164NumberFormatForCallbackServicesSpecified = true;
            _preferE164NumberFormatForCallbackServices = value;
        }
    }

    [XmlIgnore]
    public bool PreferE164NumberFormatForCallbackServicesSpecified { get; set; }
    private string _publicDigitMap;

    [XmlElement(ElementName = "publicDigitMap", IsNullable = true, Namespace = "")]
    public string PublicDigitMap {
        get => _publicDigitMap;
        set {
            PublicDigitMapSpecified = true;
            _publicDigitMap = value;
        }
    }

    [XmlIgnore]
    public bool PublicDigitMapSpecified { get; set; }
    private string _privateDigitMap;

    [XmlElement(ElementName = "privateDigitMap", IsNullable = true, Namespace = "")]
    public string PrivateDigitMap {
        get => _privateDigitMap;
        set {
            PrivateDigitMapSpecified = true;
            _privateDigitMap = value;
        }
    }

    [XmlIgnore]
    public bool PrivateDigitMapSpecified { get; set; }
}
}
