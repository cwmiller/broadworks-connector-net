using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceTypeGetAvailableListResponse22TypeInfo 
{
    private BroadworksConnector.Ocip.Models.SignalingAddressType _profile;

    [XmlElement(ElementName = "profile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SignalingAddressType Profile {
        get => _profile;
        set {
            ProfileSpecified = true;
            _profile = value;
        }
    }

    [XmlIgnore]
    public bool ProfileSpecified { get; set; }
    private bool _staticRegistrationCapable;

    [XmlElement(ElementName = "staticRegistrationCapable", IsNullable = false, Namespace = "")]
    public bool StaticRegistrationCapable {
        get => _staticRegistrationCapable;
        set {
            StaticRegistrationCapableSpecified = true;
            _staticRegistrationCapable = value;
        }
    }

    [XmlIgnore]
    public bool StaticRegistrationCapableSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationType14 _configType;

    [XmlElement(ElementName = "configType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationType14 ConfigType {
        get => _configType;
        set {
            ConfigTypeSpecified = true;
            _configType = value;
        }
    }

    [XmlIgnore]
    public bool ConfigTypeSpecified { get; set; }
    private List<string> _protocolChoice;

    [XmlElement(ElementName = "protocolChoice", IsNullable = false, Namespace = "")]
    public List<string> ProtocolChoice {
        get => _protocolChoice;
        set {
            ProtocolChoiceSpecified = true;
            _protocolChoice = value;
        }
    }

    [XmlIgnore]
    public bool ProtocolChoiceSpecified { get; set; }
    private bool _isIpAddressOptional;

    [XmlElement(ElementName = "isIpAddressOptional", IsNullable = false, Namespace = "")]
    public bool IsIpAddressOptional {
        get => _isIpAddressOptional;
        set {
            IsIpAddressOptionalSpecified = true;
            _isIpAddressOptional = value;
        }
    }

    [XmlIgnore]
    public bool IsIpAddressOptionalSpecified { get; set; }
    private bool _useDomain;

    [XmlElement(ElementName = "useDomain", IsNullable = false, Namespace = "")]
    public bool UseDomain {
        get => _useDomain;
        set {
            UseDomainSpecified = true;
            _useDomain = value;
        }
    }

    [XmlIgnore]
    public bool UseDomainSpecified { get; set; }
    private bool _isMobilityManagerDevice;

    [XmlElement(ElementName = "isMobilityManagerDevice", IsNullable = false, Namespace = "")]
    public bool IsMobilityManagerDevice {
        get => _isMobilityManagerDevice;
        set {
            IsMobilityManagerDeviceSpecified = true;
            _isMobilityManagerDevice = value;
        }
    }

    [XmlIgnore]
    public bool IsMobilityManagerDeviceSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.DeviceTypeConfigurationOptionType _deviceConfigurationOption;

    [XmlElement(ElementName = "deviceConfigurationOption", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.DeviceTypeConfigurationOptionType DeviceConfigurationOption {
        get => _deviceConfigurationOption;
        set {
            DeviceConfigurationOptionSpecified = true;
            _deviceConfigurationOption = value;
        }
    }

    [XmlIgnore]
    public bool DeviceConfigurationOptionSpecified { get; set; }
    private bool _staticLineOrdering;

    [XmlElement(ElementName = "staticLineOrdering", IsNullable = false, Namespace = "")]
    public bool StaticLineOrdering {
        get => _staticLineOrdering;
        set {
            StaticLineOrderingSpecified = true;
            _staticLineOrdering = value;
        }
    }

    [XmlIgnore]
    public bool StaticLineOrderingSpecified { get; set; }
    private int _numberOfPorts;

    [XmlElement(ElementName = "numberOfPorts", IsNullable = false, Namespace = "")]
    public int NumberOfPorts {
        get => _numberOfPorts;
        set {
            NumberOfPortsSpecified = true;
            _numberOfPorts = value;
        }
    }

    [XmlIgnore]
    public bool NumberOfPortsSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.DeviceTypeLevel _deviceTypeLevel;

    [XmlElement(ElementName = "deviceTypeLevel", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.DeviceTypeLevel DeviceTypeLevel {
        get => _deviceTypeLevel;
        set {
            DeviceTypeLevelSpecified = true;
            _deviceTypeLevel = value;
        }
    }

    [XmlIgnore]
    public bool DeviceTypeLevelSpecified { get; set; }
}
}
