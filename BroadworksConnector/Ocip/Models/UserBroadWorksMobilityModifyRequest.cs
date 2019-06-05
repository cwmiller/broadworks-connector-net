using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksMobilityModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.BroadWorksMobilityPhoneToRing _phonesToRing;

    [XmlElement(ElementName = "phonesToRing", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.BroadWorksMobilityPhoneToRing PhonesToRing {
        get => _phonesToRing;
        set {
            PhonesToRingSpecified = true;
            _phonesToRing = value;
        }
    }

    [XmlIgnore]
    public bool PhonesToRingSpecified { get; set; }
    private string _mobilePhoneNumber;

    [XmlElement(ElementName = "mobilePhoneNumber", IsNullable = true, Namespace = "")]
    public string MobilePhoneNumber {
        get => _mobilePhoneNumber;
        set {
            MobilePhoneNumberSpecified = true;
            _mobilePhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool MobilePhoneNumberSpecified { get; set; }
    private bool _alertClickToDialCalls;

    [XmlElement(ElementName = "alertClickToDialCalls", IsNullable = false, Namespace = "")]
    public bool AlertClickToDialCalls {
        get => _alertClickToDialCalls;
        set {
            AlertClickToDialCallsSpecified = true;
            _alertClickToDialCalls = value;
        }
    }

    [XmlIgnore]
    public bool AlertClickToDialCallsSpecified { get; set; }
    private bool _alertGroupPagingCalls;

    [XmlElement(ElementName = "alertGroupPagingCalls", IsNullable = false, Namespace = "")]
    public bool AlertGroupPagingCalls {
        get => _alertGroupPagingCalls;
        set {
            AlertGroupPagingCallsSpecified = true;
            _alertGroupPagingCalls = value;
        }
    }

    [XmlIgnore]
    public bool AlertGroupPagingCallsSpecified { get; set; }
    private bool _enableDiversionInhibitor;

    [XmlElement(ElementName = "enableDiversionInhibitor", IsNullable = false, Namespace = "")]
    public bool EnableDiversionInhibitor {
        get => _enableDiversionInhibitor;
        set {
            EnableDiversionInhibitorSpecified = true;
            _enableDiversionInhibitor = value;
        }
    }

    [XmlIgnore]
    public bool EnableDiversionInhibitorSpecified { get; set; }
    private bool _requireAnswerConfirmation;

    [XmlElement(ElementName = "requireAnswerConfirmation", IsNullable = false, Namespace = "")]
    public bool RequireAnswerConfirmation {
        get => _requireAnswerConfirmation;
        set {
            RequireAnswerConfirmationSpecified = true;
            _requireAnswerConfirmation = value;
        }
    }

    [XmlIgnore]
    public bool RequireAnswerConfirmationSpecified { get; set; }
    private bool _broadworksCallControl;

    [XmlElement(ElementName = "broadworksCallControl", IsNullable = false, Namespace = "")]
    public bool BroadworksCallControl {
        get => _broadworksCallControl;
        set {
            BroadworksCallControlSpecified = true;
            _broadworksCallControl = value;
        }
    }

    [XmlIgnore]
    public bool BroadworksCallControlSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.BroadWorksMobilityUserSettingLevel _useSettingLevel;

    [XmlElement(ElementName = "useSettingLevel", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.BroadWorksMobilityUserSettingLevel UseSettingLevel {
        get => _useSettingLevel;
        set {
            UseSettingLevelSpecified = true;
            _useSettingLevel = value;
        }
    }

    [XmlIgnore]
    public bool UseSettingLevelSpecified { get; set; }
    private bool _denyCallOriginations;

    [XmlElement(ElementName = "denyCallOriginations", IsNullable = false, Namespace = "")]
    public bool DenyCallOriginations {
        get => _denyCallOriginations;
        set {
            DenyCallOriginationsSpecified = true;
            _denyCallOriginations = value;
        }
    }

    [XmlIgnore]
    public bool DenyCallOriginationsSpecified { get; set; }
    private bool _denyCallTerminations;

    [XmlElement(ElementName = "denyCallTerminations", IsNullable = false, Namespace = "")]
    public bool DenyCallTerminations {
        get => _denyCallTerminations;
        set {
            DenyCallTerminationsSpecified = true;
            _denyCallTerminations = value;
        }
    }

    [XmlIgnore]
    public bool DenyCallTerminationsSpecified { get; set; }
}
}
