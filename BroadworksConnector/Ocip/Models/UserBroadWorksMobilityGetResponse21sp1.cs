using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksMobilityGetResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
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
    private BroadWorksConnector.Ocip.Models.BroadWorksMobilityPhoneToRing _profileIdentityDevicesToRing;

    [XmlElement(ElementName = "profileIdentityDevicesToRing", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.BroadWorksMobilityPhoneToRing ProfileIdentityDevicesToRing {
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
    private BroadWorksConnector.Ocip.Models.C.OCITable _profileIdentityMobileNumberAlertedTable;

    [XmlElement(ElementName = "profileIdentityMobileNumberAlertedTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ProfileIdentityMobileNumberAlertedTable {
        get => _profileIdentityMobileNumberAlertedTable;
        set {
            ProfileIdentityMobileNumberAlertedTableSpecified = true;
            _profileIdentityMobileNumberAlertedTable = value;
        }
    }

    [XmlIgnore]
    public bool ProfileIdentityMobileNumberAlertedTableSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.C.OCITable _mobileIdentityTable;

    [XmlElement(ElementName = "mobileIdentityTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable MobileIdentityTable {
        get => _mobileIdentityTable;
        set {
            MobileIdentityTableSpecified = true;
            _mobileIdentityTable = value;
        }
    }

    [XmlIgnore]
    public bool MobileIdentityTableSpecified { get; set; }
}
}
