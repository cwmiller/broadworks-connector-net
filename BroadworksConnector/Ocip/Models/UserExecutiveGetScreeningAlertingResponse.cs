using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserExecutiveGetScreeningAlertingRequest.
    /// Contains the screening and alerting settings for an executive.
        /// <see cref="UserExecutiveGetScreeningAlertingRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserExecutiveGetScreeningAlertingResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _enableScreening;

        [XmlElement(ElementName = "enableScreening", IsNullable = false, Namespace = "")]
        public bool EnableScreening {
            get => _enableScreening;
            set {
                EnableScreeningSpecified = true;
                _enableScreening = value;
            }
        }

        [XmlIgnore]
        public bool EnableScreeningSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ExecutiveScreeningAlertType _screeningAlertType;

        [XmlElement(ElementName = "screeningAlertType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ExecutiveScreeningAlertType ScreeningAlertType {
            get => _screeningAlertType;
            set {
                ScreeningAlertTypeSpecified = true;
                _screeningAlertType = value;
            }
        }

        [XmlIgnore]
        public bool ScreeningAlertTypeSpecified { get; set; }
        
        private bool _alertBroadWorksMobilityLocation;

        [XmlElement(ElementName = "alertBroadWorksMobilityLocation", IsNullable = false, Namespace = "")]
        public bool AlertBroadWorksMobilityLocation {
            get => _alertBroadWorksMobilityLocation;
            set {
                AlertBroadWorksMobilityLocationSpecified = true;
                _alertBroadWorksMobilityLocation = value;
            }
        }

        [XmlIgnore]
        public bool AlertBroadWorksMobilityLocationSpecified { get; set; }
        
        private bool _alertBroadWorksAnywhereLocations;

        [XmlElement(ElementName = "alertBroadWorksAnywhereLocations", IsNullable = false, Namespace = "")]
        public bool AlertBroadWorksAnywhereLocations {
            get => _alertBroadWorksAnywhereLocations;
            set {
                AlertBroadWorksAnywhereLocationsSpecified = true;
                _alertBroadWorksAnywhereLocations = value;
            }
        }

        [XmlIgnore]
        public bool AlertBroadWorksAnywhereLocationsSpecified { get; set; }
        
        private bool _alertSharedCallAppearanceLocations;

        [XmlElement(ElementName = "alertSharedCallAppearanceLocations", IsNullable = false, Namespace = "")]
        public bool AlertSharedCallAppearanceLocations {
            get => _alertSharedCallAppearanceLocations;
            set {
                AlertSharedCallAppearanceLocationsSpecified = true;
                _alertSharedCallAppearanceLocations = value;
            }
        }

        [XmlIgnore]
        public bool AlertSharedCallAppearanceLocationsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ExecutiveAlertingMode _alertingMode;

        [XmlElement(ElementName = "alertingMode", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ExecutiveAlertingMode AlertingMode {
            get => _alertingMode;
            set {
                AlertingModeSpecified = true;
                _alertingMode = value;
            }
        }

        [XmlIgnore]
        public bool AlertingModeSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ExecutiveAlertingCallingLineIdNameMode _alertingCallingLineIdNameMode;

        [XmlElement(ElementName = "alertingCallingLineIdNameMode", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ExecutiveAlertingCallingLineIdNameMode AlertingCallingLineIdNameMode {
            get => _alertingCallingLineIdNameMode;
            set {
                AlertingCallingLineIdNameModeSpecified = true;
                _alertingCallingLineIdNameMode = value;
            }
        }

        [XmlIgnore]
        public bool AlertingCallingLineIdNameModeSpecified { get; set; }
        
        private string _alertingCustomCallingLineIdName;

        [XmlElement(ElementName = "alertingCustomCallingLineIdName", IsNullable = false, Namespace = "")]
        public string AlertingCustomCallingLineIdName {
            get => _alertingCustomCallingLineIdName;
            set {
                AlertingCustomCallingLineIdNameSpecified = true;
                _alertingCustomCallingLineIdName = value;
            }
        }

        [XmlIgnore]
        public bool AlertingCustomCallingLineIdNameSpecified { get; set; }
        
        private string _unicodeAlertingCustomCallingLineIdName;

        [XmlElement(ElementName = "unicodeAlertingCustomCallingLineIdName", IsNullable = false, Namespace = "")]
        public string UnicodeAlertingCustomCallingLineIdName {
            get => _unicodeAlertingCustomCallingLineIdName;
            set {
                UnicodeAlertingCustomCallingLineIdNameSpecified = true;
                _unicodeAlertingCustomCallingLineIdName = value;
            }
        }

        [XmlIgnore]
        public bool UnicodeAlertingCustomCallingLineIdNameSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ExecutiveAlertingCallingLineIdPhoneNumberMode _alertingCallingLineIdPhoneNumberMode;

        [XmlElement(ElementName = "alertingCallingLineIdPhoneNumberMode", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ExecutiveAlertingCallingLineIdPhoneNumberMode AlertingCallingLineIdPhoneNumberMode {
            get => _alertingCallingLineIdPhoneNumberMode;
            set {
                AlertingCallingLineIdPhoneNumberModeSpecified = true;
                _alertingCallingLineIdPhoneNumberMode = value;
            }
        }

        [XmlIgnore]
        public bool AlertingCallingLineIdPhoneNumberModeSpecified { get; set; }
        
        private string _alertingCustomCallingLineIdPhoneNumber;

        [XmlElement(ElementName = "alertingCustomCallingLineIdPhoneNumber", IsNullable = false, Namespace = "")]
        public string AlertingCustomCallingLineIdPhoneNumber {
            get => _alertingCustomCallingLineIdPhoneNumber;
            set {
                AlertingCustomCallingLineIdPhoneNumberSpecified = true;
                _alertingCustomCallingLineIdPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool AlertingCustomCallingLineIdPhoneNumberSpecified { get; set; }
        
        private int _callPushRecallNumberOfRings;

        [XmlElement(ElementName = "callPushRecallNumberOfRings", IsNullable = false, Namespace = "")]
        public int CallPushRecallNumberOfRings {
            get => _callPushRecallNumberOfRings;
            set {
                CallPushRecallNumberOfRingsSpecified = true;
                _callPushRecallNumberOfRings = value;
            }
        }

        [XmlIgnore]
        public bool CallPushRecallNumberOfRingsSpecified { get; set; }
        
        private int _nextAssistantNumberOfRings;

        [XmlElement(ElementName = "nextAssistantNumberOfRings", IsNullable = false, Namespace = "")]
        public int NextAssistantNumberOfRings {
            get => _nextAssistantNumberOfRings;
            set {
                NextAssistantNumberOfRingsSpecified = true;
                _nextAssistantNumberOfRings = value;
            }
        }

        [XmlIgnore]
        public bool NextAssistantNumberOfRingsSpecified { get; set; }
        
        private bool _enableRollover;

        [XmlElement(ElementName = "enableRollover", IsNullable = false, Namespace = "")]
        public bool EnableRollover {
            get => _enableRollover;
            set {
                EnableRolloverSpecified = true;
                _enableRollover = value;
            }
        }

        [XmlIgnore]
        public bool EnableRolloverSpecified { get; set; }
        
        private int _rolloverWaitTimeSeconds;

        [XmlElement(ElementName = "rolloverWaitTimeSeconds", IsNullable = false, Namespace = "")]
        public int RolloverWaitTimeSeconds {
            get => _rolloverWaitTimeSeconds;
            set {
                RolloverWaitTimeSecondsSpecified = true;
                _rolloverWaitTimeSeconds = value;
            }
        }

        [XmlIgnore]
        public bool RolloverWaitTimeSecondsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ExecutiveRolloverActionType _rolloverAction;

        [XmlElement(ElementName = "rolloverAction", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ExecutiveRolloverActionType RolloverAction {
            get => _rolloverAction;
            set {
                RolloverActionSpecified = true;
                _rolloverAction = value;
            }
        }

        [XmlIgnore]
        public bool RolloverActionSpecified { get; set; }
        
        private string _rolloverForwardToPhoneNumber;

        [XmlElement(ElementName = "rolloverForwardToPhoneNumber", IsNullable = false, Namespace = "")]
        public string RolloverForwardToPhoneNumber {
            get => _rolloverForwardToPhoneNumber;
            set {
                RolloverForwardToPhoneNumberSpecified = true;
                _rolloverForwardToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool RolloverForwardToPhoneNumberSpecified { get; set; }
        
    }
}
