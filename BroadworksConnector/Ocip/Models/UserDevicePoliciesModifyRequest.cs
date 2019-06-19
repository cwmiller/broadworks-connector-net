using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user level data associated with Device Policy. enableDeviceFeatureSynchronization and enableCallDecline can be
    /// configured by the admin regardless of lineMode, but is ignored by the application server in Multiple User Shared mode.
    /// 
    /// enableCallDecline can be modified by the user when the admin has set the mode to ‘Single User Private and Shared Lines mode’.
    /// This is the only element that the user can modify. In XS data mode,  the lineMode is ignored and enabledCallDecline is the only element that can be configured.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// lineMode
    /// enableDeviceFeatureSynchronization
    /// enableDnd
    /// enableCallForwardingAlways
    /// enableCallForwardingBusy
    /// enableCallForwardingNoAnswer
    /// enableAcd
    /// enableExecutive
    /// enableExecutiveAssistant
    /// enableSecurityClassification
    /// enableCallRecording
    /// 
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:1552""}]")]
    public class UserDevicePoliciesModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1552")]
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
        public bool UserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.UserDevicePolicyLineMode _lineMode;

        [XmlElement(ElementName = "lineMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1552")]
        public BroadWorksConnector.Ocip.Models.UserDevicePolicyLineMode LineMode
        {
            get => _lineMode;
            set
            {
                LineModeSpecified = true;
                _lineMode = value;
            }
        }

        [XmlIgnore]
        public bool LineModeSpecified { get; set; }

        private bool _enableDeviceFeatureSynchronization;

        [XmlElement(ElementName = "enableDeviceFeatureSynchronization", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1552")]
        public bool EnableDeviceFeatureSynchronization
        {
            get => _enableDeviceFeatureSynchronization;
            set
            {
                EnableDeviceFeatureSynchronizationSpecified = true;
                _enableDeviceFeatureSynchronization = value;
            }
        }

        [XmlIgnore]
        public bool EnableDeviceFeatureSynchronizationSpecified { get; set; }

        private bool _enableDnd;

        [XmlElement(ElementName = "enableDnd", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1552")]
        public bool EnableDnd
        {
            get => _enableDnd;
            set
            {
                EnableDndSpecified = true;
                _enableDnd = value;
            }
        }

        [XmlIgnore]
        public bool EnableDndSpecified { get; set; }

        private bool _enableCallForwardingAlways;

        [XmlElement(ElementName = "enableCallForwardingAlways", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1552")]
        public bool EnableCallForwardingAlways
        {
            get => _enableCallForwardingAlways;
            set
            {
                EnableCallForwardingAlwaysSpecified = true;
                _enableCallForwardingAlways = value;
            }
        }

        [XmlIgnore]
        public bool EnableCallForwardingAlwaysSpecified { get; set; }

        private bool _enableCallForwardingBusy;

        [XmlElement(ElementName = "enableCallForwardingBusy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1552")]
        public bool EnableCallForwardingBusy
        {
            get => _enableCallForwardingBusy;
            set
            {
                EnableCallForwardingBusySpecified = true;
                _enableCallForwardingBusy = value;
            }
        }

        [XmlIgnore]
        public bool EnableCallForwardingBusySpecified { get; set; }

        private bool _enableCallForwardingNoAnswer;

        [XmlElement(ElementName = "enableCallForwardingNoAnswer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1552")]
        public bool EnableCallForwardingNoAnswer
        {
            get => _enableCallForwardingNoAnswer;
            set
            {
                EnableCallForwardingNoAnswerSpecified = true;
                _enableCallForwardingNoAnswer = value;
            }
        }

        [XmlIgnore]
        public bool EnableCallForwardingNoAnswerSpecified { get; set; }

        private bool _enableAcd;

        [XmlElement(ElementName = "enableAcd", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1552")]
        public bool EnableAcd
        {
            get => _enableAcd;
            set
            {
                EnableAcdSpecified = true;
                _enableAcd = value;
            }
        }

        [XmlIgnore]
        public bool EnableAcdSpecified { get; set; }

        private bool _enableExecutive;

        [XmlElement(ElementName = "enableExecutive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1552")]
        public bool EnableExecutive
        {
            get => _enableExecutive;
            set
            {
                EnableExecutiveSpecified = true;
                _enableExecutive = value;
            }
        }

        [XmlIgnore]
        public bool EnableExecutiveSpecified { get; set; }

        private bool _enableExecutiveAssistant;

        [XmlElement(ElementName = "enableExecutiveAssistant", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1552")]
        public bool EnableExecutiveAssistant
        {
            get => _enableExecutiveAssistant;
            set
            {
                EnableExecutiveAssistantSpecified = true;
                _enableExecutiveAssistant = value;
            }
        }

        [XmlIgnore]
        public bool EnableExecutiveAssistantSpecified { get; set; }

        private bool _enableSecurityClassification;

        [XmlElement(ElementName = "enableSecurityClassification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1552")]
        public bool EnableSecurityClassification
        {
            get => _enableSecurityClassification;
            set
            {
                EnableSecurityClassificationSpecified = true;
                _enableSecurityClassification = value;
            }
        }

        [XmlIgnore]
        public bool EnableSecurityClassificationSpecified { get; set; }

        private bool _enableCallRecording;

        [XmlElement(ElementName = "enableCallRecording", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1552")]
        public bool EnableCallRecording
        {
            get => _enableCallRecording;
            set
            {
                EnableCallRecordingSpecified = true;
                _enableCallRecording = value;
            }
        }

        [XmlIgnore]
        public bool EnableCallRecordingSpecified { get; set; }

        private bool _enableCallDecline;

        [XmlElement(ElementName = "enableCallDecline", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1552")]
        public bool EnableCallDecline
        {
            get => _enableCallDecline;
            set
            {
                EnableCallDeclineSpecified = true;
                _enableCallDecline = value;
            }
        }

        [XmlIgnore]
        public bool EnableCallDeclineSpecified { get; set; }

    }
}
