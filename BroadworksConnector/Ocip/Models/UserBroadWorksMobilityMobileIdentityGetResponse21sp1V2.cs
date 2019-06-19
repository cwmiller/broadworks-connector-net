using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a UserBroadWorksMobilityMobileIdentityGetRequest21sp1V2.
    /// 
    /// Columns for the mobileNumberAlertedTable are as follows: "Mobile Number", "Country Code", "National Prefix"
    /// <see cref="UserBroadWorksMobilityMobileIdentityGetRequest21sp1V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:1573""}]")]
    public class UserBroadWorksMobilityMobileIdentityGetResponse21sp1V2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }

        private bool _isPrimary;

        [XmlElement(ElementName = "isPrimary", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool IsPrimary
        {
            get => _isPrimary;
            set
            {
                IsPrimarySpecified = true;
                _isPrimary = value;
            }
        }

        [XmlIgnore]
        public bool IsPrimarySpecified { get; set; }

        private bool _enableAlerting;

        [XmlElement(ElementName = "enableAlerting", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool EnableAlerting
        {
            get => _enableAlerting;
            set
            {
                EnableAlertingSpecified = true;
                _enableAlerting = value;
            }
        }

        [XmlIgnore]
        public bool EnableAlertingSpecified { get; set; }

        private bool _alertAgentCalls;

        [XmlElement(ElementName = "alertAgentCalls", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool AlertAgentCalls
        {
            get => _alertAgentCalls;
            set
            {
                AlertAgentCallsSpecified = true;
                _alertAgentCalls = value;
            }
        }

        [XmlIgnore]
        public bool AlertAgentCallsSpecified { get; set; }

        private bool _alertClickToDialCalls;

        [XmlElement(ElementName = "alertClickToDialCalls", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool AlertClickToDialCalls
        {
            get => _alertClickToDialCalls;
            set
            {
                AlertClickToDialCallsSpecified = true;
                _alertClickToDialCalls = value;
            }
        }

        [XmlIgnore]
        public bool AlertClickToDialCallsSpecified { get; set; }

        private bool _alertGroupPagingCalls;

        [XmlElement(ElementName = "alertGroupPagingCalls", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool AlertGroupPagingCalls
        {
            get => _alertGroupPagingCalls;
            set
            {
                AlertGroupPagingCallsSpecified = true;
                _alertGroupPagingCalls = value;
            }
        }

        [XmlIgnore]
        public bool AlertGroupPagingCallsSpecified { get; set; }

        private bool _useMobilityCallingLineID;

        [XmlElement(ElementName = "useMobilityCallingLineID", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool UseMobilityCallingLineID
        {
            get => _useMobilityCallingLineID;
            set
            {
                UseMobilityCallingLineIDSpecified = true;
                _useMobilityCallingLineID = value;
            }
        }

        [XmlIgnore]
        public bool UseMobilityCallingLineIDSpecified { get; set; }

        private bool _enableDiversionInhibitor;

        [XmlElement(ElementName = "enableDiversionInhibitor", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool EnableDiversionInhibitor
        {
            get => _enableDiversionInhibitor;
            set
            {
                EnableDiversionInhibitorSpecified = true;
                _enableDiversionInhibitor = value;
            }
        }

        [XmlIgnore]
        public bool EnableDiversionInhibitorSpecified { get; set; }

        private bool _requireAnswerConfirmation;

        [XmlElement(ElementName = "requireAnswerConfirmation", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool RequireAnswerConfirmation
        {
            get => _requireAnswerConfirmation;
            set
            {
                RequireAnswerConfirmationSpecified = true;
                _requireAnswerConfirmation = value;
            }
        }

        [XmlIgnore]
        public bool RequireAnswerConfirmationSpecified { get; set; }

        private bool _broadworksCallControl;

        [XmlElement(ElementName = "broadworksCallControl", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool BroadworksCallControl
        {
            get => _broadworksCallControl;
            set
            {
                BroadworksCallControlSpecified = true;
                _broadworksCallControl = value;
            }
        }

        [XmlIgnore]
        public bool BroadworksCallControlSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.BroadWorksMobilityUserSettingLevel _useSettingLevel;

        [XmlElement(ElementName = "useSettingLevel", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public BroadWorksConnector.Ocip.Models.BroadWorksMobilityUserSettingLevel UseSettingLevel
        {
            get => _useSettingLevel;
            set
            {
                UseSettingLevelSpecified = true;
                _useSettingLevel = value;
            }
        }

        [XmlIgnore]
        public bool UseSettingLevelSpecified { get; set; }

        private bool _denyCallOriginations;

        [XmlElement(ElementName = "denyCallOriginations", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool DenyCallOriginations
        {
            get => _denyCallOriginations;
            set
            {
                DenyCallOriginationsSpecified = true;
                _denyCallOriginations = value;
            }
        }

        [XmlIgnore]
        public bool DenyCallOriginationsSpecified { get; set; }

        private bool _denyCallTerminations;

        [XmlElement(ElementName = "denyCallTerminations", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool DenyCallTerminations
        {
            get => _denyCallTerminations;
            set
            {
                DenyCallTerminationsSpecified = true;
                _denyCallTerminations = value;
            }
        }

        [XmlIgnore]
        public bool DenyCallTerminationsSpecified { get; set; }

        private bool _effectiveEnableLocationServices;

        [XmlElement(ElementName = "effectiveEnableLocationServices", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool EffectiveEnableLocationServices
        {
            get => _effectiveEnableLocationServices;
            set
            {
                EffectiveEnableLocationServicesSpecified = true;
                _effectiveEnableLocationServices = value;
            }
        }

        [XmlIgnore]
        public bool EffectiveEnableLocationServicesSpecified { get; set; }

        private bool _effectiveEnableMSRNLookup;

        [XmlElement(ElementName = "effectiveEnableMSRNLookup", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool EffectiveEnableMSRNLookup
        {
            get => _effectiveEnableMSRNLookup;
            set
            {
                EffectiveEnableMSRNLookupSpecified = true;
                _effectiveEnableMSRNLookup = value;
            }
        }

        [XmlIgnore]
        public bool EffectiveEnableMSRNLookupSpecified { get; set; }

        private bool _effectiveEnableMobileStateChecking;

        [XmlElement(ElementName = "effectiveEnableMobileStateChecking", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool EffectiveEnableMobileStateChecking
        {
            get => _effectiveEnableMobileStateChecking;
            set
            {
                EffectiveEnableMobileStateCheckingSpecified = true;
                _effectiveEnableMobileStateChecking = value;
            }
        }

        [XmlIgnore]
        public bool EffectiveEnableMobileStateCheckingSpecified { get; set; }

        private bool _effectiveEnableAnnouncementSuppression;

        [XmlElement(ElementName = "effectiveEnableAnnouncementSuppression", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool EffectiveEnableAnnouncementSuppression
        {
            get => _effectiveEnableAnnouncementSuppression;
            set
            {
                EffectiveEnableAnnouncementSuppressionSpecified = true;
                _effectiveEnableAnnouncementSuppression = value;
            }
        }

        [XmlIgnore]
        public bool EffectiveEnableAnnouncementSuppressionSpecified { get; set; }

        private bool _effectiveDenyCallOriginations;

        [XmlElement(ElementName = "effectiveDenyCallOriginations", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool EffectiveDenyCallOriginations
        {
            get => _effectiveDenyCallOriginations;
            set
            {
                EffectiveDenyCallOriginationsSpecified = true;
                _effectiveDenyCallOriginations = value;
            }
        }

        [XmlIgnore]
        public bool EffectiveDenyCallOriginationsSpecified { get; set; }

        private bool _effectiveDenyCallTerminations;

        [XmlElement(ElementName = "effectiveDenyCallTerminations", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool EffectiveDenyCallTerminations
        {
            get => _effectiveDenyCallTerminations;
            set
            {
                EffectiveDenyCallTerminationsSpecified = true;
                _effectiveDenyCallTerminations = value;
            }
        }

        [XmlIgnore]
        public bool EffectiveDenyCallTerminationsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.BroadWorksMobilityPhoneToRing _devicesToRing;

        [XmlElement(ElementName = "devicesToRing", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public BroadWorksConnector.Ocip.Models.BroadWorksMobilityPhoneToRing DevicesToRing
        {
            get => _devicesToRing;
            set
            {
                DevicesToRingSpecified = true;
                _devicesToRing = value;
            }
        }

        [XmlIgnore]
        public bool DevicesToRingSpecified { get; set; }

        private bool _includeSharedCallAppearance;

        [XmlElement(ElementName = "includeSharedCallAppearance", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool IncludeSharedCallAppearance
        {
            get => _includeSharedCallAppearance;
            set
            {
                IncludeSharedCallAppearanceSpecified = true;
                _includeSharedCallAppearance = value;
            }
        }

        [XmlIgnore]
        public bool IncludeSharedCallAppearanceSpecified { get; set; }

        private bool _includeBroadworksAnywhere;

        [XmlElement(ElementName = "includeBroadworksAnywhere", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool IncludeBroadworksAnywhere
        {
            get => _includeBroadworksAnywhere;
            set
            {
                IncludeBroadworksAnywhereSpecified = true;
                _includeBroadworksAnywhere = value;
            }
        }

        [XmlIgnore]
        public bool IncludeBroadworksAnywhereSpecified { get; set; }

        private bool _includeExecutiveAssistant;

        [XmlElement(ElementName = "includeExecutiveAssistant", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool IncludeExecutiveAssistant
        {
            get => _includeExecutiveAssistant;
            set
            {
                IncludeExecutiveAssistantSpecified = true;
                _includeExecutiveAssistant = value;
            }
        }

        [XmlIgnore]
        public bool IncludeExecutiveAssistantSpecified { get; set; }

        private bool _enableCallAnchoring;

        [XmlElement(ElementName = "enableCallAnchoring", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool EnableCallAnchoring
        {
            get => _enableCallAnchoring;
            set
            {
                EnableCallAnchoringSpecified = true;
                _enableCallAnchoring = value;
            }
        }

        [XmlIgnore]
        public bool EnableCallAnchoringSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ScheduleGlobalKey _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public BroadWorksConnector.Ocip.Models.ScheduleGlobalKey TimeSchedule
        {
            get => _timeSchedule;
            set
            {
                TimeScheduleSpecified = true;
                _timeSchedule = value;
            }
        }

        [XmlIgnore]
        public bool TimeScheduleSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ScheduleGlobalKey _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public BroadWorksConnector.Ocip.Models.ScheduleGlobalKey HolidaySchedule
        {
            get => _holidaySchedule;
            set
            {
                HolidayScheduleSpecified = true;
                _holidaySchedule = value;
            }
        }

        [XmlIgnore]
        public bool HolidayScheduleSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead AccessDeviceEndpoint
        {
            get => _accessDeviceEndpoint;
            set
            {
                AccessDeviceEndpointSpecified = true;
                _accessDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        public bool AccessDeviceEndpointSpecified { get; set; }

        private string _outboundAlternateNumber;

        [XmlElement(ElementName = "outboundAlternateNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        [MinLength(1)]
        [MaxLength(161)]
        public string OutboundAlternateNumber
        {
            get => _outboundAlternateNumber;
            set
            {
                OutboundAlternateNumberSpecified = true;
                _outboundAlternateNumber = value;
            }
        }

        [XmlIgnore]
        public bool OutboundAlternateNumberSpecified { get; set; }

        private bool _enableDirectRouting;

        [XmlElement(ElementName = "enableDirectRouting", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool EnableDirectRouting
        {
            get => _enableDirectRouting;
            set
            {
                EnableDirectRoutingSpecified = true;
                _enableDirectRouting = value;
            }
        }

        [XmlIgnore]
        public bool EnableDirectRoutingSpecified { get; set; }

        private bool _markCDRAsEnterpriseGroupCalls;

        [XmlElement(ElementName = "markCDRAsEnterpriseGroupCalls", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public bool MarkCDRAsEnterpriseGroupCalls
        {
            get => _markCDRAsEnterpriseGroupCalls;
            set
            {
                MarkCDRAsEnterpriseGroupCallsSpecified = true;
                _markCDRAsEnterpriseGroupCalls = value;
            }
        }

        [XmlIgnore]
        public bool MarkCDRAsEnterpriseGroupCallsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _mobileNumberAlertedTable;

        [XmlElement(ElementName = "mobileNumberAlertedTable", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1573")]
        public BroadWorksConnector.Ocip.Models.C.OCITable MobileNumberAlertedTable
        {
            get => _mobileNumberAlertedTable;
            set
            {
                MobileNumberAlertedTableSpecified = true;
                _mobileNumberAlertedTable = value;
            }
        }

        [XmlIgnore]
        public bool MobileNumberAlertedTableSpecified { get; set; }

    }
}
