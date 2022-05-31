using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserDevicePoliciesGetRequest201. enableDeviceFeatureSynchronization is ignored by the application server in Multiple User Shared mode.
    /// <see cref="UserDevicePoliciesGetRequest201"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:42294""}]")]
    public class UserDevicePoliciesGetResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.UserDevicePolicyLineMode _lineMode;

        [XmlElement(ElementName = "lineMode", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42294")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42294")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42294")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42294")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42294")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42294")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42294")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42294")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42294")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42294")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:42294")]
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

    }
}
