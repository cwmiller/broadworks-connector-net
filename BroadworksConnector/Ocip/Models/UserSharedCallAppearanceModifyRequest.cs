using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's Shared Call Appearance service setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following elements are only used in XS data mode and ignored in AS data mode:
    /// useUserPrimaryWithAlternateCallsSetting
    /// allowSimultaneousPrimaryAndAlternate
    /// restrictCallRetrieveOfPrimary
    /// restrictCallBridgingOfPrimary
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4e9808afa6161bba01df39d17a849c79:211""}]")]
    public class UserSharedCallAppearanceModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"4e9808afa6161bba01df39d17a849c79:211")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        protected bool _alertAllAppearancesForClickToDialCalls;

        [XmlElement(ElementName = "alertAllAppearancesForClickToDialCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4e9808afa6161bba01df39d17a849c79:211")]
        public bool AlertAllAppearancesForClickToDialCalls
        {
            get => _alertAllAppearancesForClickToDialCalls;
            set
            {
                AlertAllAppearancesForClickToDialCallsSpecified = true;
                _alertAllAppearancesForClickToDialCalls = value;
            }
        }

        [XmlIgnore]
        protected bool AlertAllAppearancesForClickToDialCallsSpecified { get; set; }

        protected bool _alertAllAppearancesForGroupPagingCalls;

        [XmlElement(ElementName = "alertAllAppearancesForGroupPagingCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4e9808afa6161bba01df39d17a849c79:211")]
        public bool AlertAllAppearancesForGroupPagingCalls
        {
            get => _alertAllAppearancesForGroupPagingCalls;
            set
            {
                AlertAllAppearancesForGroupPagingCallsSpecified = true;
                _alertAllAppearancesForGroupPagingCalls = value;
            }
        }

        [XmlIgnore]
        protected bool AlertAllAppearancesForGroupPagingCallsSpecified { get; set; }

        protected bool _allowSCACallRetrieve;

        [XmlElement(ElementName = "allowSCACallRetrieve", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4e9808afa6161bba01df39d17a849c79:211")]
        public bool AllowSCACallRetrieve
        {
            get => _allowSCACallRetrieve;
            set
            {
                AllowSCACallRetrieveSpecified = true;
                _allowSCACallRetrieve = value;
            }
        }

        [XmlIgnore]
        protected bool AllowSCACallRetrieveSpecified { get; set; }

        protected bool _multipleCallArrangementIsActive;

        [XmlElement(ElementName = "multipleCallArrangementIsActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4e9808afa6161bba01df39d17a849c79:211")]
        public bool MultipleCallArrangementIsActive
        {
            get => _multipleCallArrangementIsActive;
            set
            {
                MultipleCallArrangementIsActiveSpecified = true;
                _multipleCallArrangementIsActive = value;
            }
        }

        [XmlIgnore]
        protected bool MultipleCallArrangementIsActiveSpecified { get; set; }

        protected bool _allowBridgingBetweenLocations;

        [XmlElement(ElementName = "allowBridgingBetweenLocations", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4e9808afa6161bba01df39d17a849c79:211")]
        public bool AllowBridgingBetweenLocations
        {
            get => _allowBridgingBetweenLocations;
            set
            {
                AllowBridgingBetweenLocationsSpecified = true;
                _allowBridgingBetweenLocations = value;
            }
        }

        [XmlIgnore]
        protected bool AllowBridgingBetweenLocationsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SharedCallAppearanceBridgeWarningTone _bridgeWarningTone;

        [XmlElement(ElementName = "bridgeWarningTone", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4e9808afa6161bba01df39d17a849c79:211")]
        public BroadWorksConnector.Ocip.Models.SharedCallAppearanceBridgeWarningTone BridgeWarningTone
        {
            get => _bridgeWarningTone;
            set
            {
                BridgeWarningToneSpecified = true;
                _bridgeWarningTone = value;
            }
        }

        [XmlIgnore]
        protected bool BridgeWarningToneSpecified { get; set; }

        protected bool _enableCallParkNotification;

        [XmlElement(ElementName = "enableCallParkNotification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4e9808afa6161bba01df39d17a849c79:211")]
        public bool EnableCallParkNotification
        {
            get => _enableCallParkNotification;
            set
            {
                EnableCallParkNotificationSpecified = true;
                _enableCallParkNotification = value;
            }
        }

        [XmlIgnore]
        protected bool EnableCallParkNotificationSpecified { get; set; }

        protected bool _useUserPrimaryWithAlternateCallsSetting;

        [XmlElement(ElementName = "useUserPrimaryWithAlternateCallsSetting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4e9808afa6161bba01df39d17a849c79:211")]
        public bool UseUserPrimaryWithAlternateCallsSetting
        {
            get => _useUserPrimaryWithAlternateCallsSetting;
            set
            {
                UseUserPrimaryWithAlternateCallsSettingSpecified = true;
                _useUserPrimaryWithAlternateCallsSetting = value;
            }
        }

        [XmlIgnore]
        protected bool UseUserPrimaryWithAlternateCallsSettingSpecified { get; set; }

        protected bool _allowSimultaneousPrimaryAndAlternateCalls;

        [XmlElement(ElementName = "allowSimultaneousPrimaryAndAlternateCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4e9808afa6161bba01df39d17a849c79:211")]
        public bool AllowSimultaneousPrimaryAndAlternateCalls
        {
            get => _allowSimultaneousPrimaryAndAlternateCalls;
            set
            {
                AllowSimultaneousPrimaryAndAlternateCallsSpecified = true;
                _allowSimultaneousPrimaryAndAlternateCalls = value;
            }
        }

        [XmlIgnore]
        protected bool AllowSimultaneousPrimaryAndAlternateCallsSpecified { get; set; }

        protected bool _restrictCallRetrieveOfPrimaryCall;

        [XmlElement(ElementName = "restrictCallRetrieveOfPrimaryCall", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4e9808afa6161bba01df39d17a849c79:211")]
        public bool RestrictCallRetrieveOfPrimaryCall
        {
            get => _restrictCallRetrieveOfPrimaryCall;
            set
            {
                RestrictCallRetrieveOfPrimaryCallSpecified = true;
                _restrictCallRetrieveOfPrimaryCall = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictCallRetrieveOfPrimaryCallSpecified { get; set; }

        protected bool _restrictCallBridgingOfPrimaryCall;

        [XmlElement(ElementName = "restrictCallBridgingOfPrimaryCall", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4e9808afa6161bba01df39d17a849c79:211")]
        public bool RestrictCallBridgingOfPrimaryCall
        {
            get => _restrictCallBridgingOfPrimaryCall;
            set
            {
                RestrictCallBridgingOfPrimaryCallSpecified = true;
                _restrictCallBridgingOfPrimaryCall = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictCallBridgingOfPrimaryCallSpecified { get; set; }

    }
}
