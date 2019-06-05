using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGETSGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _enabled;

    [XmlElement(ElementName = "enabled", IsNullable = false, Namespace = "")]
    public bool Enabled {
        get => _enabled;
        set {
            EnabledSpecified = true;
            _enabled = value;
        }
    }

    [XmlIgnore]
    public bool EnabledSpecified { get; set; }
    private bool _enableRequireResourcePriority;

    [XmlElement(ElementName = "enableRequireResourcePriority", IsNullable = false, Namespace = "")]
    public bool EnableRequireResourcePriority {
        get => _enableRequireResourcePriority;
        set {
            EnableRequireResourcePrioritySpecified = true;
            _enableRequireResourcePriority = value;
        }
    }

    [XmlIgnore]
    public bool EnableRequireResourcePrioritySpecified { get; set; }
    private bool _sendAccessResourcePriority;

    [XmlElement(ElementName = "sendAccessResourcePriority", IsNullable = false, Namespace = "")]
    public bool SendAccessResourcePriority {
        get => _sendAccessResourcePriority;
        set {
            SendAccessResourcePrioritySpecified = true;
            _sendAccessResourcePriority = value;
        }
    }

    [XmlIgnore]
    public bool SendAccessResourcePrioritySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.GETSCallIdentifierMode _callIdentifierMode;

    [XmlElement(ElementName = "callIdentifierMode", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GETSCallIdentifierMode CallIdentifierMode {
        get => _callIdentifierMode;
        set {
            CallIdentifierModeSpecified = true;
            _callIdentifierMode = value;
        }
    }

    [XmlIgnore]
    public bool CallIdentifierModeSpecified { get; set; }
    private int _defaultPriorityAVP;

    [XmlElement(ElementName = "defaultPriorityAVP", IsNullable = false, Namespace = "")]
    public int DefaultPriorityAVP {
        get => _defaultPriorityAVP;
        set {
            DefaultPriorityAVPSpecified = true;
            _defaultPriorityAVP = value;
        }
    }

    [XmlIgnore]
    public bool DefaultPriorityAVPSpecified { get; set; }
    private int _signalingDSCP;

    [XmlElement(ElementName = "signalingDSCP", IsNullable = false, Namespace = "")]
    public int SignalingDSCP {
        get => _signalingDSCP;
        set {
            SignalingDSCPSpecified = true;
            _signalingDSCP = value;
        }
    }

    [XmlIgnore]
    public bool SignalingDSCPSpecified { get; set; }
    private string _defaultRValue;

    [XmlElement(ElementName = "defaultRValue", IsNullable = false, Namespace = "")]
    public string DefaultRValue {
        get => _defaultRValue;
        set {
            DefaultRValueSpecified = true;
            _defaultRValue = value;
        }
    }

    [XmlIgnore]
    public bool DefaultRValueSpecified { get; set; }
    private bool _bypassRoRelease;

    [XmlElement(ElementName = "bypassRoRelease", IsNullable = false, Namespace = "")]
    public bool BypassRoRelease {
        get => _bypassRoRelease;
        set {
            BypassRoReleaseSpecified = true;
            _bypassRoRelease = value;
        }
    }

    [XmlIgnore]
    public bool BypassRoReleaseSpecified { get; set; }
}
}
