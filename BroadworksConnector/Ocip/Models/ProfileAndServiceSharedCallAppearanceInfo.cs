using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This is the configuration parameters for shared call appearance service
    /// The endpointTable contains columns:
    /// "Device Level", "Device Name", "Device Type", "Line/Port", "SIP Contact", "Port Number". "Private Identity" .
    /// 
    /// The "Device Level" column contains one of the AccessDeviceLevel enumerated constants.
    /// Port numbers are only used by devices with static line ordering.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:4524""}]")]
    public class ProfileAndServiceSharedCallAppearanceInfo
    {

        protected bool _alertAllAppearancesForClickToDialCalls;

        [XmlElement(ElementName = "alertAllAppearancesForClickToDialCalls", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4524")]
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
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4524")]
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

        protected int _maxAppearances;

        [XmlElement(ElementName = "maxAppearances", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4524")]
        public int MaxAppearances
        {
            get => _maxAppearances;
            set
            {
                MaxAppearancesSpecified = true;
                _maxAppearances = value;
            }
        }

        [XmlIgnore]
        protected bool MaxAppearancesSpecified { get; set; }

        protected bool _allowSCACallRetrieve;

        [XmlElement(ElementName = "allowSCACallRetrieve", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4524")]
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

        protected bool _enableMultipleCallArrangement;

        [XmlElement(ElementName = "enableMultipleCallArrangement", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4524")]
        public bool EnableMultipleCallArrangement
        {
            get => _enableMultipleCallArrangement;
            set
            {
                EnableMultipleCallArrangementSpecified = true;
                _enableMultipleCallArrangement = value;
            }
        }

        [XmlIgnore]
        protected bool EnableMultipleCallArrangementSpecified { get; set; }

        protected bool _multipleCallArrangementIsActive;

        [XmlElement(ElementName = "multipleCallArrangementIsActive", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4524")]
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

        protected BroadWorksConnector.Ocip.Models.C.OCITable _endpointTable;

        [XmlElement(ElementName = "endpointTable", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4524")]
        public BroadWorksConnector.Ocip.Models.C.OCITable EndpointTable
        {
            get => _endpointTable;
            set
            {
                EndpointTableSpecified = true;
                _endpointTable = value;
            }
        }

        [XmlIgnore]
        protected bool EndpointTableSpecified { get; set; }

        protected bool _allowBridgingBetweenLocations;

        [XmlElement(ElementName = "allowBridgingBetweenLocations", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4524")]
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
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4524")]
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
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4524")]
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
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4524")]
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

        protected bool _allowSimultaneousPrimaryAndAlternate;

        [XmlElement(ElementName = "allowSimultaneousPrimaryAndAlternate", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4524")]
        public bool AllowSimultaneousPrimaryAndAlternate
        {
            get => _allowSimultaneousPrimaryAndAlternate;
            set
            {
                AllowSimultaneousPrimaryAndAlternateSpecified = true;
                _allowSimultaneousPrimaryAndAlternate = value;
            }
        }

        [XmlIgnore]
        protected bool AllowSimultaneousPrimaryAndAlternateSpecified { get; set; }

        protected bool _restrictCallRetrieveOfPrimary;

        [XmlElement(ElementName = "restrictCallRetrieveOfPrimary", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4524")]
        public bool RestrictCallRetrieveOfPrimary
        {
            get => _restrictCallRetrieveOfPrimary;
            set
            {
                RestrictCallRetrieveOfPrimarySpecified = true;
                _restrictCallRetrieveOfPrimary = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictCallRetrieveOfPrimarySpecified { get; set; }

        protected bool _restrictCallBridgingOfPrimary;

        [XmlElement(ElementName = "restrictCallBridgingOfPrimary", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4524")]
        public bool RestrictCallBridgingOfPrimary
        {
            get => _restrictCallBridgingOfPrimary;
            set
            {
                RestrictCallBridgingOfPrimarySpecified = true;
                _restrictCallBridgingOfPrimary = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictCallBridgingOfPrimarySpecified { get; set; }

    }
}
