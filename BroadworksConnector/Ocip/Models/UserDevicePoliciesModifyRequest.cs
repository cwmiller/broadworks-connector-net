using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserDevicePoliciesModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.UserDevicePolicyLineMode _lineMode;

    [XmlElement(ElementName = "lineMode", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.UserDevicePolicyLineMode LineMode {
        get => _lineMode;
        set {
            LineModeSpecified = true;
            _lineMode = value;
        }
    }

    [XmlIgnore]
    public bool LineModeSpecified { get; set; }
    private bool _enableDeviceFeatureSynchronization;

    [XmlElement(ElementName = "enableDeviceFeatureSynchronization", IsNullable = false, Namespace = "")]
    public bool EnableDeviceFeatureSynchronization {
        get => _enableDeviceFeatureSynchronization;
        set {
            EnableDeviceFeatureSynchronizationSpecified = true;
            _enableDeviceFeatureSynchronization = value;
        }
    }

    [XmlIgnore]
    public bool EnableDeviceFeatureSynchronizationSpecified { get; set; }
    private bool _enableDnd;

    [XmlElement(ElementName = "enableDnd", IsNullable = false, Namespace = "")]
    public bool EnableDnd {
        get => _enableDnd;
        set {
            EnableDndSpecified = true;
            _enableDnd = value;
        }
    }

    [XmlIgnore]
    public bool EnableDndSpecified { get; set; }
    private bool _enableCallForwardingAlways;

    [XmlElement(ElementName = "enableCallForwardingAlways", IsNullable = false, Namespace = "")]
    public bool EnableCallForwardingAlways {
        get => _enableCallForwardingAlways;
        set {
            EnableCallForwardingAlwaysSpecified = true;
            _enableCallForwardingAlways = value;
        }
    }

    [XmlIgnore]
    public bool EnableCallForwardingAlwaysSpecified { get; set; }
    private bool _enableCallForwardingBusy;

    [XmlElement(ElementName = "enableCallForwardingBusy", IsNullable = false, Namespace = "")]
    public bool EnableCallForwardingBusy {
        get => _enableCallForwardingBusy;
        set {
            EnableCallForwardingBusySpecified = true;
            _enableCallForwardingBusy = value;
        }
    }

    [XmlIgnore]
    public bool EnableCallForwardingBusySpecified { get; set; }
    private bool _enableCallForwardingNoAnswer;

    [XmlElement(ElementName = "enableCallForwardingNoAnswer", IsNullable = false, Namespace = "")]
    public bool EnableCallForwardingNoAnswer {
        get => _enableCallForwardingNoAnswer;
        set {
            EnableCallForwardingNoAnswerSpecified = true;
            _enableCallForwardingNoAnswer = value;
        }
    }

    [XmlIgnore]
    public bool EnableCallForwardingNoAnswerSpecified { get; set; }
    private bool _enableAcd;

    [XmlElement(ElementName = "enableAcd", IsNullable = false, Namespace = "")]
    public bool EnableAcd {
        get => _enableAcd;
        set {
            EnableAcdSpecified = true;
            _enableAcd = value;
        }
    }

    [XmlIgnore]
    public bool EnableAcdSpecified { get; set; }
    private bool _enableExecutive;

    [XmlElement(ElementName = "enableExecutive", IsNullable = false, Namespace = "")]
    public bool EnableExecutive {
        get => _enableExecutive;
        set {
            EnableExecutiveSpecified = true;
            _enableExecutive = value;
        }
    }

    [XmlIgnore]
    public bool EnableExecutiveSpecified { get; set; }
    private bool _enableExecutiveAssistant;

    [XmlElement(ElementName = "enableExecutiveAssistant", IsNullable = false, Namespace = "")]
    public bool EnableExecutiveAssistant {
        get => _enableExecutiveAssistant;
        set {
            EnableExecutiveAssistantSpecified = true;
            _enableExecutiveAssistant = value;
        }
    }

    [XmlIgnore]
    public bool EnableExecutiveAssistantSpecified { get; set; }
    private bool _enableSecurityClassification;

    [XmlElement(ElementName = "enableSecurityClassification", IsNullable = false, Namespace = "")]
    public bool EnableSecurityClassification {
        get => _enableSecurityClassification;
        set {
            EnableSecurityClassificationSpecified = true;
            _enableSecurityClassification = value;
        }
    }

    [XmlIgnore]
    public bool EnableSecurityClassificationSpecified { get; set; }
    private bool _enableCallRecording;

    [XmlElement(ElementName = "enableCallRecording", IsNullable = false, Namespace = "")]
    public bool EnableCallRecording {
        get => _enableCallRecording;
        set {
            EnableCallRecordingSpecified = true;
            _enableCallRecording = value;
        }
    }

    [XmlIgnore]
    public bool EnableCallRecordingSpecified { get; set; }
    private bool _enableCallDecline;

    [XmlElement(ElementName = "enableCallDecline", IsNullable = false, Namespace = "")]
    public bool EnableCallDecline {
        get => _enableCallDecline;
        set {
            EnableCallDeclineSpecified = true;
            _enableCallDecline = value;
        }
    }

    [XmlIgnore]
    public bool EnableCallDeclineSpecified { get; set; }
}
}
