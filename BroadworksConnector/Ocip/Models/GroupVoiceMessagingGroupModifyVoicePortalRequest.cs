using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupVoiceMessagingGroupModifyVoicePortalRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _groupId;

    [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
    public string GroupId {
        get => _groupId;
        set {
            GroupIdSpecified = true;
            _groupId = value;
        }
    }

    [XmlIgnore]
    public bool GroupIdSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile _serviceInstanceProfile;

    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile {
        get => _serviceInstanceProfile;
        set {
            ServiceInstanceProfileSpecified = true;
            _serviceInstanceProfile = value;
        }
    }

    [XmlIgnore]
    public bool ServiceInstanceProfileSpecified { get; set; }
    private bool _isActive;

    [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
    public bool IsActive {
        get => _isActive;
        set {
            IsActiveSpecified = true;
            _isActive = value;
        }
    }

    [XmlIgnore]
    public bool IsActiveSpecified { get; set; }
    private bool _enableExtendedScope;

    [XmlElement(ElementName = "enableExtendedScope", IsNullable = false, Namespace = "")]
    public bool EnableExtendedScope {
        get => _enableExtendedScope;
        set {
            EnableExtendedScopeSpecified = true;
            _enableExtendedScope = value;
        }
    }

    [XmlIgnore]
    public bool EnableExtendedScopeSpecified { get; set; }
    private bool _allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin;

    [XmlElement(ElementName = "allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin", IsNullable = false, Namespace = "")]
    public bool AllowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin {
        get => _allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin;
        set {
            AllowIdentificationByPhoneNumberOrVoiceMailAliasesOnLoginSpecified = true;
            _allowIdentificationByPhoneNumberOrVoiceMailAliasesOnLogin = value;
        }
    }

    [XmlIgnore]
    public bool AllowIdentificationByPhoneNumberOrVoiceMailAliasesOnLoginSpecified { get; set; }
    private bool _useVoicePortalWizard;

    [XmlElement(ElementName = "useVoicePortalWizard", IsNullable = false, Namespace = "")]
    public bool UseVoicePortalWizard {
        get => _useVoicePortalWizard;
        set {
            UseVoicePortalWizardSpecified = true;
            _useVoicePortalWizard = value;
        }
    }

    [XmlIgnore]
    public bool UseVoicePortalWizardSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.VoicePortalExternalRoutingScope _voicePortalExternalRoutingScope;

    [XmlElement(ElementName = "voicePortalExternalRoutingScope", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.VoicePortalExternalRoutingScope VoicePortalExternalRoutingScope {
        get => _voicePortalExternalRoutingScope;
        set {
            VoicePortalExternalRoutingScopeSpecified = true;
            _voicePortalExternalRoutingScope = value;
        }
    }

    [XmlIgnore]
    public bool VoicePortalExternalRoutingScopeSpecified { get; set; }
    private bool _useExternalRouting;

    [XmlElement(ElementName = "useExternalRouting", IsNullable = false, Namespace = "")]
    public bool UseExternalRouting {
        get => _useExternalRouting;
        set {
            UseExternalRoutingSpecified = true;
            _useExternalRouting = value;
        }
    }

    [XmlIgnore]
    public bool UseExternalRoutingSpecified { get; set; }
    private string _externalRoutingAddress;

    [XmlElement(ElementName = "externalRoutingAddress", IsNullable = true, Namespace = "")]
    public string ExternalRoutingAddress {
        get => _externalRoutingAddress;
        set {
            ExternalRoutingAddressSpecified = true;
            _externalRoutingAddress = value;
        }
    }

    [XmlIgnore]
    public bool ExternalRoutingAddressSpecified { get; set; }
    private string _homeZoneName;

    [XmlElement(ElementName = "homeZoneName", IsNullable = true, Namespace = "")]
    public string HomeZoneName {
        get => _homeZoneName;
        set {
            HomeZoneNameSpecified = true;
            _homeZoneName = value;
        }
    }

    [XmlIgnore]
    public bool HomeZoneNameSpecified { get; set; }
    private string _networkClassOfService;

    [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
    public string NetworkClassOfService {
        get => _networkClassOfService;
        set {
            NetworkClassOfServiceSpecified = true;
            _networkClassOfService = value;
        }
    }

    [XmlIgnore]
    public bool NetworkClassOfServiceSpecified { get; set; }
    private bool _expressMode;

    [XmlElement(ElementName = "expressMode", IsNullable = false, Namespace = "")]
    public bool ExpressMode {
        get => _expressMode;
        set {
            ExpressModeSpecified = true;
            _expressMode = value;
        }
    }

    [XmlIgnore]
    public bool ExpressModeSpecified { get; set; }
}
}
