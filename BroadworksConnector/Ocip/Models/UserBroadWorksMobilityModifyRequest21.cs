using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksMobilityModifyRequest21 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
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
    private bool _useMobileIdentityCallAnchoring;

    [XmlElement(ElementName = "useMobileIdentityCallAnchoring", IsNullable = false, Namespace = "")]
    public bool UseMobileIdentityCallAnchoring {
        get => _useMobileIdentityCallAnchoring;
        set {
            UseMobileIdentityCallAnchoringSpecified = true;
            _useMobileIdentityCallAnchoring = value;
        }
    }

    [XmlIgnore]
    public bool UseMobileIdentityCallAnchoringSpecified { get; set; }
    private bool _preventCallsToOwnMobiles;

    [XmlElement(ElementName = "preventCallsToOwnMobiles", IsNullable = false, Namespace = "")]
    public bool PreventCallsToOwnMobiles {
        get => _preventCallsToOwnMobiles;
        set {
            PreventCallsToOwnMobilesSpecified = true;
            _preventCallsToOwnMobiles = value;
        }
    }

    [XmlIgnore]
    public bool PreventCallsToOwnMobilesSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.BroadWorksMobilityUserMobileIdentityModifyEntry> _mobileIdentity;

    [XmlElement(ElementName = "mobileIdentity", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.BroadWorksMobilityUserMobileIdentityModifyEntry> MobileIdentity {
        get => _mobileIdentity;
        set {
            MobileIdentitySpecified = true;
            _mobileIdentity = value;
        }
    }

    [XmlIgnore]
    public bool MobileIdentitySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.BroadWorksMobilityPhoneToRing _profileIdentityDevicesToRing;

    [XmlElement(ElementName = "profileIdentityDevicesToRing", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.BroadWorksMobilityPhoneToRing ProfileIdentityDevicesToRing {
        get => _profileIdentityDevicesToRing;
        set {
            ProfileIdentityDevicesToRingSpecified = true;
            _profileIdentityDevicesToRing = value;
        }
    }

    [XmlIgnore]
    public bool ProfileIdentityDevicesToRingSpecified { get; set; }
    private bool _profileIdentityIncludeSharedCallAppearance;

    [XmlElement(ElementName = "profileIdentityIncludeSharedCallAppearance", IsNullable = false, Namespace = "")]
    public bool ProfileIdentityIncludeSharedCallAppearance {
        get => _profileIdentityIncludeSharedCallAppearance;
        set {
            ProfileIdentityIncludeSharedCallAppearanceSpecified = true;
            _profileIdentityIncludeSharedCallAppearance = value;
        }
    }

    [XmlIgnore]
    public bool ProfileIdentityIncludeSharedCallAppearanceSpecified { get; set; }
    private bool _profileIdentityIncludeBroadworksAnywhere;

    [XmlElement(ElementName = "profileIdentityIncludeBroadworksAnywhere", IsNullable = false, Namespace = "")]
    public bool ProfileIdentityIncludeBroadworksAnywhere {
        get => _profileIdentityIncludeBroadworksAnywhere;
        set {
            ProfileIdentityIncludeBroadworksAnywhereSpecified = true;
            _profileIdentityIncludeBroadworksAnywhere = value;
        }
    }

    [XmlIgnore]
    public bool ProfileIdentityIncludeBroadworksAnywhereSpecified { get; set; }
    private bool _profileIdentityIncludeExecutiveAssistant;

    [XmlElement(ElementName = "profileIdentityIncludeExecutiveAssistant", IsNullable = false, Namespace = "")]
    public bool ProfileIdentityIncludeExecutiveAssistant {
        get => _profileIdentityIncludeExecutiveAssistant;
        set {
            ProfileIdentityIncludeExecutiveAssistantSpecified = true;
            _profileIdentityIncludeExecutiveAssistant = value;
        }
    }

    [XmlIgnore]
    public bool ProfileIdentityIncludeExecutiveAssistantSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.BroadWorksMobilityAlertingMobileNumberReplacementList _profileIdentityMobilityNumbersAlerted;

    [XmlElement(ElementName = "profileIdentityMobilityNumbersAlerted", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.BroadWorksMobilityAlertingMobileNumberReplacementList ProfileIdentityMobilityNumbersAlerted {
        get => _profileIdentityMobilityNumbersAlerted;
        set {
            ProfileIdentityMobilityNumbersAlertedSpecified = true;
            _profileIdentityMobilityNumbersAlerted = value;
        }
    }

    [XmlIgnore]
    public bool ProfileIdentityMobilityNumbersAlertedSpecified { get; set; }
}
}
