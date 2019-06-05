using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSharedCallAppearanceModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private bool _alertAllAppearancesForClickToDialCalls;

    [XmlElement(ElementName = "alertAllAppearancesForClickToDialCalls", IsNullable = false, Namespace = "")]
    public bool AlertAllAppearancesForClickToDialCalls {
        get => _alertAllAppearancesForClickToDialCalls;
        set {
            AlertAllAppearancesForClickToDialCallsSpecified = true;
            _alertAllAppearancesForClickToDialCalls = value;
        }
    }

    [XmlIgnore]
    public bool AlertAllAppearancesForClickToDialCallsSpecified { get; set; }
    private bool _alertAllAppearancesForGroupPagingCalls;

    [XmlElement(ElementName = "alertAllAppearancesForGroupPagingCalls", IsNullable = false, Namespace = "")]
    public bool AlertAllAppearancesForGroupPagingCalls {
        get => _alertAllAppearancesForGroupPagingCalls;
        set {
            AlertAllAppearancesForGroupPagingCallsSpecified = true;
            _alertAllAppearancesForGroupPagingCalls = value;
        }
    }

    [XmlIgnore]
    public bool AlertAllAppearancesForGroupPagingCallsSpecified { get; set; }
    private bool _allowSCACallRetrieve;

    [XmlElement(ElementName = "allowSCACallRetrieve", IsNullable = false, Namespace = "")]
    public bool AllowSCACallRetrieve {
        get => _allowSCACallRetrieve;
        set {
            AllowSCACallRetrieveSpecified = true;
            _allowSCACallRetrieve = value;
        }
    }

    [XmlIgnore]
    public bool AllowSCACallRetrieveSpecified { get; set; }
    private bool _multipleCallArrangementIsActive;

    [XmlElement(ElementName = "multipleCallArrangementIsActive", IsNullable = false, Namespace = "")]
    public bool MultipleCallArrangementIsActive {
        get => _multipleCallArrangementIsActive;
        set {
            MultipleCallArrangementIsActiveSpecified = true;
            _multipleCallArrangementIsActive = value;
        }
    }

    [XmlIgnore]
    public bool MultipleCallArrangementIsActiveSpecified { get; set; }
    private bool _allowBridgingBetweenLocations;

    [XmlElement(ElementName = "allowBridgingBetweenLocations", IsNullable = false, Namespace = "")]
    public bool AllowBridgingBetweenLocations {
        get => _allowBridgingBetweenLocations;
        set {
            AllowBridgingBetweenLocationsSpecified = true;
            _allowBridgingBetweenLocations = value;
        }
    }

    [XmlIgnore]
    public bool AllowBridgingBetweenLocationsSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SharedCallAppearanceBridgeWarningTone _bridgeWarningTone;

    [XmlElement(ElementName = "bridgeWarningTone", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SharedCallAppearanceBridgeWarningTone BridgeWarningTone {
        get => _bridgeWarningTone;
        set {
            BridgeWarningToneSpecified = true;
            _bridgeWarningTone = value;
        }
    }

    [XmlIgnore]
    public bool BridgeWarningToneSpecified { get; set; }
    private bool _enableCallParkNotification;

    [XmlElement(ElementName = "enableCallParkNotification", IsNullable = false, Namespace = "")]
    public bool EnableCallParkNotification {
        get => _enableCallParkNotification;
        set {
            EnableCallParkNotificationSpecified = true;
            _enableCallParkNotification = value;
        }
    }

    [XmlIgnore]
    public bool EnableCallParkNotificationSpecified { get; set; }
    private bool _useUserPrimaryWithAlternateCallsSetting;

    [XmlElement(ElementName = "useUserPrimaryWithAlternateCallsSetting", IsNullable = false, Namespace = "")]
    public bool UseUserPrimaryWithAlternateCallsSetting {
        get => _useUserPrimaryWithAlternateCallsSetting;
        set {
            UseUserPrimaryWithAlternateCallsSettingSpecified = true;
            _useUserPrimaryWithAlternateCallsSetting = value;
        }
    }

    [XmlIgnore]
    public bool UseUserPrimaryWithAlternateCallsSettingSpecified { get; set; }
    private bool _allowSimultaneousPrimaryAndAlternateCalls;

    [XmlElement(ElementName = "allowSimultaneousPrimaryAndAlternateCalls", IsNullable = false, Namespace = "")]
    public bool AllowSimultaneousPrimaryAndAlternateCalls {
        get => _allowSimultaneousPrimaryAndAlternateCalls;
        set {
            AllowSimultaneousPrimaryAndAlternateCallsSpecified = true;
            _allowSimultaneousPrimaryAndAlternateCalls = value;
        }
    }

    [XmlIgnore]
    public bool AllowSimultaneousPrimaryAndAlternateCallsSpecified { get; set; }
    private bool _restrictCallRetrieveOfPrimaryCall;

    [XmlElement(ElementName = "restrictCallRetrieveOfPrimaryCall", IsNullable = false, Namespace = "")]
    public bool RestrictCallRetrieveOfPrimaryCall {
        get => _restrictCallRetrieveOfPrimaryCall;
        set {
            RestrictCallRetrieveOfPrimaryCallSpecified = true;
            _restrictCallRetrieveOfPrimaryCall = value;
        }
    }

    [XmlIgnore]
    public bool RestrictCallRetrieveOfPrimaryCallSpecified { get; set; }
    private bool _restrictCallBridgingOfPrimaryCall;

    [XmlElement(ElementName = "restrictCallBridgingOfPrimaryCall", IsNullable = false, Namespace = "")]
    public bool RestrictCallBridgingOfPrimaryCall {
        get => _restrictCallBridgingOfPrimaryCall;
        set {
            RestrictCallBridgingOfPrimaryCallSpecified = true;
            _restrictCallBridgingOfPrimaryCall = value;
        }
    }

    [XmlIgnore]
    public bool RestrictCallBridgingOfPrimaryCallSpecified { get; set; }
}
}
