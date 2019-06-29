using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the settings for one of the user's BroadWorks Mobility mobile Identities.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// If deleteExistingDevices is set to true, when the devices for the endpoint are changed, devices with no more endpoint will be deleted if the command is executed with the correct privilege.
    /// 
    /// The request fails when enableAlerting or timeSchedule or holidaySchedule are included in the request when the use mobile identity call anchoring controls for the user  is disabled.
    /// 
    /// The description, enableAlerting, alertAgentCalls, alertClickToDialCalls, alertGroupPagingCalls, useMobilityCallingLineID, enableDiversionInhibitor, requireAnswerConfirmation, broadworksCallControl, devicesToRing, includeSharedCallAppearance, includeBroadworksAnywhere, includeExecutiveAssistance, mobileNumberAlerted, enableCallAnchoring, timeSchedule and holidaySchedule  parameters require an authorization level of User for modification when the BroadWorks Mobility service is on.
    /// The isPrimary, useSettingLevel, denyCallOrigination, denyCallTerminations, accessDeviceEndpoint, outboundAlternateNumber, enableDirectRouting, markCDRAsEnterpriseGroupCalls and networkTranslationIndex parameters require an authorization level of Group for modification.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:1488"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:1513"",""optional"":true}]}]")]
    public class UserBroadWorksMobilityMobileIdentityConsolidatedModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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

        private string _mobileNumber;

        [XmlElement(ElementName = "mobileNumber", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
        [MinLength(1)]
        [MaxLength(23)]
        public string MobileNumber
        {
            get => _mobileNumber;
            set
            {
                MobileNumberSpecified = true;
                _mobileNumber = value;
            }
        }

        [XmlIgnore]
        protected bool MobileNumberSpecified { get; set; }

        private bool _deleteExistingDevices;

        [XmlElement(ElementName = "deleteExistingDevices", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
        public bool DeleteExistingDevices
        {
            get => _deleteExistingDevices;
            set
            {
                DeleteExistingDevicesSpecified = true;
                _deleteExistingDevices = value;
            }
        }

        [XmlIgnore]
        protected bool DeleteExistingDevicesSpecified { get; set; }

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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

        private BroadWorksConnector.Ocip.Models.BroadWorksMobilityAlertingMobileNumberReplacementList _mobileNumbersAlerted;

        [XmlElement(ElementName = "mobileNumbersAlerted", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
        public BroadWorksConnector.Ocip.Models.BroadWorksMobilityAlertingMobileNumberReplacementList MobileNumbersAlerted
        {
            get => _mobileNumbersAlerted;
            set
            {
                MobileNumbersAlertedSpecified = true;
                _mobileNumbersAlerted = value;
            }
        }

        [XmlIgnore]
        protected bool MobileNumbersAlertedSpecified { get; set; }

        private bool _enableCallAnchoring;

        [XmlElement(ElementName = "enableCallAnchoring", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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

        [XmlElement(ElementName = "timeSchedule", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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

        [XmlElement(ElementName = "holidaySchedule", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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

        private BroadWorksConnector.Ocip.Models.ConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpoint _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = true, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1513")]
        public BroadWorksConnector.Ocip.Models.ConsolidatedSharedCallAppearanceAccessDeviceMultipleIdentityEndpoint AccessDeviceEndpoint
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

        [XmlElement(ElementName = "outboundAlternateNumber", IsNullable = true, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1513")]
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
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
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

        private bool _useMobilityConnectedIdentity;

        [XmlElement(ElementName = "useMobilityConnectedIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
        public bool UseMobilityConnectedIdentity
        {
            get => _useMobilityConnectedIdentity;
            set
            {
                UseMobilityConnectedIdentitySpecified = true;
                _useMobilityConnectedIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool UseMobilityConnectedIdentitySpecified { get; set; }

        private string _networkTranslationIndex;

        [XmlElement(ElementName = "networkTranslationIndex", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1488")]
        [MinLength(1)]
        [MaxLength(128)]
        public string NetworkTranslationIndex
        {
            get => _networkTranslationIndex;
            set
            {
                NetworkTranslationIndexSpecified = true;
                _networkTranslationIndex = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkTranslationIndexSpecified { get; set; }

    }
}
