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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:1658""}]")]
    public class UserDevicePoliciesModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1658")]
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

        protected BroadWorksConnector.Ocip.Models.UserDevicePolicyLineMode _lineMode;

        [XmlElement(ElementName = "lineMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1658")]
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
        protected bool LineModeSpecified { get; set; }

        protected bool _enableDeviceFeatureSynchronization;

        [XmlElement(ElementName = "enableDeviceFeatureSynchronization", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1658")]
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
        protected bool EnableDeviceFeatureSynchronizationSpecified { get; set; }

        protected bool _enableDnd;

        [XmlElement(ElementName = "enableDnd", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1658")]
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
        protected bool EnableDndSpecified { get; set; }

        protected bool _enableCallForwardingAlways;

        [XmlElement(ElementName = "enableCallForwardingAlways", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1658")]
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
        protected bool EnableCallForwardingAlwaysSpecified { get; set; }

        protected bool _enableCallForwardingBusy;

        [XmlElement(ElementName = "enableCallForwardingBusy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1658")]
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
        protected bool EnableCallForwardingBusySpecified { get; set; }

        protected bool _enableCallForwardingNoAnswer;

        [XmlElement(ElementName = "enableCallForwardingNoAnswer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1658")]
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
        protected bool EnableCallForwardingNoAnswerSpecified { get; set; }

        protected bool _enableAcd;

        [XmlElement(ElementName = "enableAcd", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1658")]
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
        protected bool EnableAcdSpecified { get; set; }

        protected bool _enableExecutive;

        [XmlElement(ElementName = "enableExecutive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1658")]
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
        protected bool EnableExecutiveSpecified { get; set; }

        protected bool _enableExecutiveAssistant;

        [XmlElement(ElementName = "enableExecutiveAssistant", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1658")]
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
        protected bool EnableExecutiveAssistantSpecified { get; set; }

        protected bool _enableSecurityClassification;

        [XmlElement(ElementName = "enableSecurityClassification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1658")]
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
        protected bool EnableSecurityClassificationSpecified { get; set; }

        protected bool _enableCallRecording;

        [XmlElement(ElementName = "enableCallRecording", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1658")]
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
        protected bool EnableCallRecordingSpecified { get; set; }

        protected bool _enableCallDecline;

        [XmlElement(ElementName = "enableCallDecline", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:1658")]
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
        protected bool EnableCallDeclineSpecified { get; set; }

    }
}
