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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:7685""}]")]
    public class SystemDeviceTypeGetAvailableListResponse22TypeInfo
    {

        private BroadWorksConnector.Ocip.Models.SignalingAddressType _profile;

        [XmlElement(ElementName = "profile", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7685")]
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
        public bool ProfileSpecified { get; set; }

        private bool _staticRegistrationCapable;

        [XmlElement(ElementName = "staticRegistrationCapable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7685")]
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
        public bool StaticRegistrationCapableSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationType14 _configType;

        [XmlElement(ElementName = "configType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7685")]
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
        public bool ConfigTypeSpecified { get; set; }

        private List<string> _protocolChoice = new List<string>();

        [XmlElement(ElementName = "protocolChoice", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7685")]
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
        public bool ProtocolChoiceSpecified { get; set; }

        private bool _isIpAddressOptional;

        [XmlElement(ElementName = "isIpAddressOptional", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7685")]
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
        public bool IsIpAddressOptionalSpecified { get; set; }

        private bool _useDomain;

        [XmlElement(ElementName = "useDomain", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7685")]
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
        public bool UseDomainSpecified { get; set; }

        private bool _isMobilityManagerDevice;

        [XmlElement(ElementName = "isMobilityManagerDevice", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7685")]
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
        public bool IsMobilityManagerDeviceSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DeviceTypeConfigurationOptionType _deviceConfigurationOption;

        [XmlElement(ElementName = "deviceConfigurationOption", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7685")]
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
        public bool DeviceConfigurationOptionSpecified { get; set; }

        private bool _staticLineOrdering;

        [XmlElement(ElementName = "staticLineOrdering", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7685")]
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
        public bool StaticLineOrderingSpecified { get; set; }

        private int _numberOfPorts;

        [XmlElement(ElementName = "numberOfPorts", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7685")]
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
        public bool NumberOfPortsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DeviceTypeLevel _deviceTypeLevel;

        [XmlElement(ElementName = "deviceTypeLevel", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7685")]
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
        public bool DeviceTypeLevelSpecified { get; set; }

    }
}
