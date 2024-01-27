using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:9972""}]")]
    public class SystemDeviceTypeGetAvailableListResponse22TypeInfo
    {

        protected BroadWorksConnector.Ocip.Models.SignalingAddressType _profile;

        [XmlElement(ElementName = "profile", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9972")]
        public BroadWorksConnector.Ocip.Models.SignalingAddressType Profile
        {
            get => _profile;
            set
            {
                ProfileSpecified = true;
                _profile = value;
            }
        }

        [XmlIgnore]
        protected bool ProfileSpecified { get; set; }

        protected bool _staticRegistrationCapable;

        [XmlElement(ElementName = "staticRegistrationCapable", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9972")]
        public bool StaticRegistrationCapable
        {
            get => _staticRegistrationCapable;
            set
            {
                StaticRegistrationCapableSpecified = true;
                _staticRegistrationCapable = value;
            }
        }

        [XmlIgnore]
        protected bool StaticRegistrationCapableSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationType14 _configType;

        [XmlElement(ElementName = "configType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9972")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationType14 ConfigType
        {
            get => _configType;
            set
            {
                ConfigTypeSpecified = true;
                _configType = value;
            }
        }

        [XmlIgnore]
        protected bool ConfigTypeSpecified { get; set; }

        protected List<string> _protocolChoice = new List<string>();

        [XmlElement(ElementName = "protocolChoice", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9972")]
        [MinLength(1)]
        [MaxLength(20)]
        public List<string> ProtocolChoice
        {
            get => _protocolChoice;
            set
            {
                ProtocolChoiceSpecified = true;
                _protocolChoice = value;
            }
        }

        [XmlIgnore]
        protected bool ProtocolChoiceSpecified { get; set; }

        protected bool _isIpAddressOptional;

        [XmlElement(ElementName = "isIpAddressOptional", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9972")]
        public bool IsIpAddressOptional
        {
            get => _isIpAddressOptional;
            set
            {
                IsIpAddressOptionalSpecified = true;
                _isIpAddressOptional = value;
            }
        }

        [XmlIgnore]
        protected bool IsIpAddressOptionalSpecified { get; set; }

        protected bool _useDomain;

        [XmlElement(ElementName = "useDomain", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9972")]
        public bool UseDomain
        {
            get => _useDomain;
            set
            {
                UseDomainSpecified = true;
                _useDomain = value;
            }
        }

        [XmlIgnore]
        protected bool UseDomainSpecified { get; set; }

        protected bool _isMobilityManagerDevice;

        [XmlElement(ElementName = "isMobilityManagerDevice", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9972")]
        public bool IsMobilityManagerDevice
        {
            get => _isMobilityManagerDevice;
            set
            {
                IsMobilityManagerDeviceSpecified = true;
                _isMobilityManagerDevice = value;
            }
        }

        [XmlIgnore]
        protected bool IsMobilityManagerDeviceSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DeviceTypeConfigurationOptionType _deviceConfigurationOption;

        [XmlElement(ElementName = "deviceConfigurationOption", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9972")]
        public BroadWorksConnector.Ocip.Models.DeviceTypeConfigurationOptionType DeviceConfigurationOption
        {
            get => _deviceConfigurationOption;
            set
            {
                DeviceConfigurationOptionSpecified = true;
                _deviceConfigurationOption = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceConfigurationOptionSpecified { get; set; }

        protected bool _staticLineOrdering;

        [XmlElement(ElementName = "staticLineOrdering", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9972")]
        public bool StaticLineOrdering
        {
            get => _staticLineOrdering;
            set
            {
                StaticLineOrderingSpecified = true;
                _staticLineOrdering = value;
            }
        }

        [XmlIgnore]
        protected bool StaticLineOrderingSpecified { get; set; }

        protected int _numberOfPorts;

        [XmlElement(ElementName = "numberOfPorts", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9972")]
        [MinInclusive(1)]
        [MaxInclusive(1024)]
        public int NumberOfPorts
        {
            get => _numberOfPorts;
            set
            {
                NumberOfPortsSpecified = true;
                _numberOfPorts = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfPortsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DeviceTypeLevel _deviceTypeLevel;

        [XmlElement(ElementName = "deviceTypeLevel", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9972")]
        public BroadWorksConnector.Ocip.Models.DeviceTypeLevel DeviceTypeLevel
        {
            get => _deviceTypeLevel;
            set
            {
                DeviceTypeLevelSpecified = true;
                _deviceTypeLevel = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceTypeLevelSpecified { get; set; }

    }
}
