using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserDevicePoliciesGetRequest21. enableDeviceFeatureSynchronization and
    /// enableCallDecline are ignored by the application server in Multiple User Shared mode.
    /// The following element is only used in AS data mode:
    /// lineMode, value “Single User Private and Shared” is returned in XS data mode
    /// The following elements are only used in AS data mode:
    /// enableDeviceFeatureSynchronization, value “false” is returned in XS data mode
    /// enableDnd, value “false” is returned in XS data mode
    /// enableCallForwardingAlways, value “false” is returned in XS data mode
    /// enableCallForwardingBusy, value “false” is returned in XS data mode
    /// enableCallForwardingNoAnswer, value “false” is returned in XS data mode
    /// enableAcd, value “false” is returned in XS data mode
    /// enableExecutive, value “false” is returned in XS data mode
    /// enableExecutiveAssistant, value “false” is returned in XS data mode
    /// enableSecurityClassification, value “false” is returned in XS data mode
    /// enableCallRecording, value “false” is returned in XS data mode
    /// <see cref="UserDevicePoliciesGetRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:1615""}]")]
    public class UserDevicePoliciesGetResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.UserDevicePolicyLineMode _lineMode;

        [XmlElement(ElementName = "lineMode", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1615")]
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
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1615")]
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
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1615")]
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
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1615")]
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
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1615")]
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
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1615")]
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
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1615")]
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
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1615")]
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
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1615")]
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
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1615")]
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
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1615")]
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
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:1615")]
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
