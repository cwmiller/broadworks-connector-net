using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the screening and alerting setting of an executive.
    /// Both executive and the executive assistant can run this command.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9a6dbade05624033cf7fe782b7c9a9a7:418""}]")]
    public class UserExecutiveModifyScreeningAlertingRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:418")]
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

        private bool _enableScreening;

        [XmlElement(ElementName = "enableScreening", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:418")]
        public bool EnableScreening
        {
            get => _enableScreening;
            set
            {
                EnableScreeningSpecified = true;
                _enableScreening = value;
            }
        }

        [XmlIgnore]
        protected bool EnableScreeningSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExecutiveScreeningAlertType _screeningAlertType;

        [XmlElement(ElementName = "screeningAlertType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:418")]
        public BroadWorksConnector.Ocip.Models.ExecutiveScreeningAlertType ScreeningAlertType
        {
            get => _screeningAlertType;
            set
            {
                ScreeningAlertTypeSpecified = true;
                _screeningAlertType = value;
            }
        }

        [XmlIgnore]
        protected bool ScreeningAlertTypeSpecified { get; set; }

        private bool _alertBroadWorksMobilityLocation;

        [XmlElement(ElementName = "alertBroadWorksMobilityLocation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:418")]
        public bool AlertBroadWorksMobilityLocation
        {
            get => _alertBroadWorksMobilityLocation;
            set
            {
                AlertBroadWorksMobilityLocationSpecified = true;
                _alertBroadWorksMobilityLocation = value;
            }
        }

        [XmlIgnore]
        protected bool AlertBroadWorksMobilityLocationSpecified { get; set; }

        private bool _alertBroadWorksAnywhereLocations;

        [XmlElement(ElementName = "alertBroadWorksAnywhereLocations", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:418")]
        public bool AlertBroadWorksAnywhereLocations
        {
            get => _alertBroadWorksAnywhereLocations;
            set
            {
                AlertBroadWorksAnywhereLocationsSpecified = true;
                _alertBroadWorksAnywhereLocations = value;
            }
        }

        [XmlIgnore]
        protected bool AlertBroadWorksAnywhereLocationsSpecified { get; set; }

        private bool _alertSharedCallAppearanceLocations;

        [XmlElement(ElementName = "alertSharedCallAppearanceLocations", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:418")]
        public bool AlertSharedCallAppearanceLocations
        {
            get => _alertSharedCallAppearanceLocations;
            set
            {
                AlertSharedCallAppearanceLocationsSpecified = true;
                _alertSharedCallAppearanceLocations = value;
            }
        }

        [XmlIgnore]
        protected bool AlertSharedCallAppearanceLocationsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExecutiveAlertingMode _alertingMode;

        [XmlElement(ElementName = "alertingMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:418")]
        public BroadWorksConnector.Ocip.Models.ExecutiveAlertingMode AlertingMode
        {
            get => _alertingMode;
            set
            {
                AlertingModeSpecified = true;
                _alertingMode = value;
            }
        }

        [XmlIgnore]
        protected bool AlertingModeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExecutiveAlertingCallingLineIdNameMode _alertingCallingLineIdNameMode;

        [XmlElement(ElementName = "alertingCallingLineIdNameMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:418")]
        public BroadWorksConnector.Ocip.Models.ExecutiveAlertingCallingLineIdNameMode AlertingCallingLineIdNameMode
        {
            get => _alertingCallingLineIdNameMode;
            set
            {
                AlertingCallingLineIdNameModeSpecified = true;
                _alertingCallingLineIdNameMode = value;
            }
        }

        [XmlIgnore]
        protected bool AlertingCallingLineIdNameModeSpecified { get; set; }

        private string _alertingCustomCallingLineIdName;

        [XmlElement(ElementName = "alertingCustomCallingLineIdName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:418")]
        [MinLength(1)]
        [MaxLength(80)]
        public string AlertingCustomCallingLineIdName
        {
            get => _alertingCustomCallingLineIdName;
            set
            {
                AlertingCustomCallingLineIdNameSpecified = true;
                _alertingCustomCallingLineIdName = value;
            }
        }

        [XmlIgnore]
        protected bool AlertingCustomCallingLineIdNameSpecified { get; set; }

        private string _unicodeAlertingCustomCallingLineIdName;

        [XmlElement(ElementName = "unicodeAlertingCustomCallingLineIdName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:418")]
        [MinLength(1)]
        [MaxLength(80)]
        public string UnicodeAlertingCustomCallingLineIdName
        {
            get => _unicodeAlertingCustomCallingLineIdName;
            set
            {
                UnicodeAlertingCustomCallingLineIdNameSpecified = true;
                _unicodeAlertingCustomCallingLineIdName = value;
            }
        }

        [XmlIgnore]
        protected bool UnicodeAlertingCustomCallingLineIdNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExecutiveAlertingCallingLineIdPhoneNumberMode _alertingCallingLineIdPhoneNumberMode;

        [XmlElement(ElementName = "alertingCallingLineIdPhoneNumberMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:418")]
        public BroadWorksConnector.Ocip.Models.ExecutiveAlertingCallingLineIdPhoneNumberMode AlertingCallingLineIdPhoneNumberMode
        {
            get => _alertingCallingLineIdPhoneNumberMode;
            set
            {
                AlertingCallingLineIdPhoneNumberModeSpecified = true;
                _alertingCallingLineIdPhoneNumberMode = value;
            }
        }

        [XmlIgnore]
        protected bool AlertingCallingLineIdPhoneNumberModeSpecified { get; set; }

        private string _alertingCustomCallingLineIdPhoneNumber;

        [XmlElement(ElementName = "alertingCustomCallingLineIdPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:418")]
        [MinLength(1)]
        [MaxLength(23)]
        public string AlertingCustomCallingLineIdPhoneNumber
        {
            get => _alertingCustomCallingLineIdPhoneNumber;
            set
            {
                AlertingCustomCallingLineIdPhoneNumberSpecified = true;
                _alertingCustomCallingLineIdPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool AlertingCustomCallingLineIdPhoneNumberSpecified { get; set; }

        private int _callPushRecallNumberOfRings;

        [XmlElement(ElementName = "callPushRecallNumberOfRings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:418")]
        [MinInclusive(2)]
        [MaxInclusive(20)]
        public int CallPushRecallNumberOfRings
        {
            get => _callPushRecallNumberOfRings;
            set
            {
                CallPushRecallNumberOfRingsSpecified = true;
                _callPushRecallNumberOfRings = value;
            }
        }

        [XmlIgnore]
        protected bool CallPushRecallNumberOfRingsSpecified { get; set; }

        private int _nextAssistantNumberOfRings;

        [XmlElement(ElementName = "nextAssistantNumberOfRings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:418")]
        [MinInclusive(1)]
        [MaxInclusive(20)]
        public int NextAssistantNumberOfRings
        {
            get => _nextAssistantNumberOfRings;
            set
            {
                NextAssistantNumberOfRingsSpecified = true;
                _nextAssistantNumberOfRings = value;
            }
        }

        [XmlIgnore]
        protected bool NextAssistantNumberOfRingsSpecified { get; set; }

        private bool _enableRollover;

        [XmlElement(ElementName = "enableRollover", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:418")]
        public bool EnableRollover
        {
            get => _enableRollover;
            set
            {
                EnableRolloverSpecified = true;
                _enableRollover = value;
            }
        }

        [XmlIgnore]
        protected bool EnableRolloverSpecified { get; set; }

        private int? _rolloverWaitTimeSeconds;

        [XmlElement(ElementName = "rolloverWaitTimeSeconds", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:418")]
        [MinInclusive(0)]
        [MaxInclusive(7200)]
        public int? RolloverWaitTimeSeconds
        {
            get => _rolloverWaitTimeSeconds;
            set
            {
                RolloverWaitTimeSecondsSpecified = true;
                _rolloverWaitTimeSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool RolloverWaitTimeSecondsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ExecutiveRolloverActionType _rolloverAction;

        [XmlElement(ElementName = "rolloverAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:418")]
        public BroadWorksConnector.Ocip.Models.ExecutiveRolloverActionType RolloverAction
        {
            get => _rolloverAction;
            set
            {
                RolloverActionSpecified = true;
                _rolloverAction = value;
            }
        }

        [XmlIgnore]
        protected bool RolloverActionSpecified { get; set; }

        private string _rolloverForwardToPhoneNumber;

        [XmlElement(ElementName = "rolloverForwardToPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"9a6dbade05624033cf7fe782b7c9a9a7:418")]
        [MinLength(1)]
        [MaxLength(161)]
        public string RolloverForwardToPhoneNumber
        {
            get => _rolloverForwardToPhoneNumber;
            set
            {
                RolloverForwardToPhoneNumberSpecified = true;
                _rolloverForwardToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool RolloverForwardToPhoneNumberSpecified { get; set; }

    }
}
