using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a UserBroadWorksMobilityMobileIdentityGetRequest21sp1.
    /// 
    /// Replaced by: UserBroadWorksMobilityMobileIdentityGetResponse21sp1V2.
    /// <see cref="UserBroadWorksMobilityMobileIdentityGetRequest21sp1"/>
    /// <see cref="UserBroadWorksMobilityMobileIdentityGetResponse21sp1V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:40166""}]")]
    public class UserBroadWorksMobilityMobileIdentityGetResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool DescriptionSpecified { get; set; }

        private bool _isPrimary;

        [XmlElement(ElementName = "isPrimary", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool IsPrimarySpecified { get; set; }

        private bool _enableAlerting;

        [XmlElement(ElementName = "enableAlerting", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool EnableAlertingSpecified { get; set; }

        private bool _alertAgentCalls;

        [XmlElement(ElementName = "alertAgentCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool AlertAgentCallsSpecified { get; set; }

        private bool _alertClickToDialCalls;

        [XmlElement(ElementName = "alertClickToDialCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool AlertClickToDialCallsSpecified { get; set; }

        private bool _alertGroupPagingCalls;

        [XmlElement(ElementName = "alertGroupPagingCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool AlertGroupPagingCallsSpecified { get; set; }

        private bool _useMobilityCallingLineID;

        [XmlElement(ElementName = "useMobilityCallingLineID", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool UseMobilityCallingLineIDSpecified { get; set; }

        private bool _enableDiversionInhibitor;

        [XmlElement(ElementName = "enableDiversionInhibitor", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool EnableDiversionInhibitorSpecified { get; set; }

        private bool _requireAnswerConfirmation;

        [XmlElement(ElementName = "requireAnswerConfirmation", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool RequireAnswerConfirmationSpecified { get; set; }

        private bool _broadworksCallControl;

        [XmlElement(ElementName = "broadworksCallControl", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool BroadworksCallControlSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.BroadWorksMobilityUserSettingLevel _useSettingLevel;

        [XmlElement(ElementName = "useSettingLevel", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool UseSettingLevelSpecified { get; set; }

        private bool _denyCallOriginations;

        [XmlElement(ElementName = "denyCallOriginations", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool DenyCallOriginationsSpecified { get; set; }

        private bool _denyCallTerminations;

        [XmlElement(ElementName = "denyCallTerminations", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool DenyCallTerminationsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.BroadWorksMobilityPhoneToRing _devicesToRing;

        [XmlElement(ElementName = "devicesToRing", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool DevicesToRingSpecified { get; set; }

        private bool _includeSharedCallAppearance;

        [XmlElement(ElementName = "includeSharedCallAppearance", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool IncludeSharedCallAppearanceSpecified { get; set; }

        private bool _includeBroadworksAnywhere;

        [XmlElement(ElementName = "includeBroadworksAnywhere", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool IncludeBroadworksAnywhereSpecified { get; set; }

        private bool _includeExecutiveAssistant;

        [XmlElement(ElementName = "includeExecutiveAssistant", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool IncludeExecutiveAssistantSpecified { get; set; }

        private List<string> _mobileNumberAlerted = new List<string>();

        [XmlElement(ElementName = "mobileNumberAlerted", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
        [MinLength(1)]
        [MaxLength(23)]
        public List<string> MobileNumberAlerted
        {
            get => _mobileNumberAlerted;
            set
            {
                MobileNumberAlertedSpecified = true;
                _mobileNumberAlerted = value;
            }
        }

        [XmlIgnore]
        protected bool MobileNumberAlertedSpecified { get; set; }

        private bool _enableCallAnchoring;

        [XmlElement(ElementName = "enableCallAnchoring", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool EnableCallAnchoringSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ScheduleGlobalKey _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool TimeScheduleSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ScheduleGlobalKey _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool HolidayScheduleSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool AccessDeviceEndpointSpecified { get; set; }

        private string _outboundAlternateNumber;

        [XmlElement(ElementName = "outboundAlternateNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool OutboundAlternateNumberSpecified { get; set; }

        private bool _enableDirectRouting;

        [XmlElement(ElementName = "enableDirectRouting", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool EnableDirectRoutingSpecified { get; set; }

        private bool _markCDRAsEnterpriseGroupCalls;

        [XmlElement(ElementName = "markCDRAsEnterpriseGroupCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40166")]
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
        protected bool MarkCDRAsEnterpriseGroupCallsSpecified { get; set; }

    }
}
