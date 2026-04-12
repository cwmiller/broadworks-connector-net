using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAccessDeviceGetRequest22V5.
    /// The following elements are only returned in AS data mode:
    /// serviceProviderId
    /// groupId
    /// The following elements are only used in AS data mode and not returned in XS data mode:
    /// deviceName
    /// deviceExternalId
    /// deviceCode
    /// deviceIPEI
    /// deviceIndex
    /// useDeviceCode
    /// authBearerSubject
    /// 
    /// Replaced by GroupAccessDeviceGetResponse24V3.
    /// <see cref="GroupAccessDeviceGetRequest22V5"/>
    /// <see cref="GroupAccessDeviceGetResponse24V3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:1064""}]")]
    public class GroupAccessDeviceGetResponse22V5 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DeviceType
        {
            get => _deviceType;
            set
            {
                DeviceTypeSpecified = true;
                _deviceType = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceTypeSpecified { get; set; }

        protected string _protocol;

        [XmlElement(ElementName = "protocol", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        [MinLength(1)]
        [MaxLength(20)]
        public string Protocol
        {
            get => _protocol;
            set
            {
                ProtocolSpecified = (value != null);
                _protocol = value;
            }
        }

        [XmlIgnore]
        protected bool ProtocolSpecified { get; set; }

        protected string _netAddress;

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        [MinLength(1)]
        [MaxLength(80)]
        public string NetAddress
        {
            get => _netAddress;
            set
            {
                NetAddressSpecified = (value != null);
                _netAddress = value;
            }
        }

        [XmlIgnore]
        protected bool NetAddressSpecified { get; set; }

        protected int? _port;

        [XmlElement(ElementName = "port", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int? Port
        {
            get => _port;
            set
            {
                PortSpecified = (value != null);
                _port = value;
            }
        }

        [XmlIgnore]
        protected bool PortSpecified { get; set; }

        protected string _outboundProxyServerNetAddress;

        [XmlElement(ElementName = "outboundProxyServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        [MinLength(1)]
        [MaxLength(80)]
        public string OutboundProxyServerNetAddress
        {
            get => _outboundProxyServerNetAddress;
            set
            {
                OutboundProxyServerNetAddressSpecified = (value != null);
                _outboundProxyServerNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool OutboundProxyServerNetAddressSpecified { get; set; }

        protected string _stunServerNetAddress;

        [XmlElement(ElementName = "stunServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        [MinLength(1)]
        [MaxLength(80)]
        public string StunServerNetAddress
        {
            get => _stunServerNetAddress;
            set
            {
                StunServerNetAddressSpecified = (value != null);
                _stunServerNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool StunServerNetAddressSpecified { get; set; }

        protected string _macAddress;

        [XmlElement(ElementName = "macAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        [MinLength(1)]
        [MaxLength(12)]
        public string MacAddress
        {
            get => _macAddress;
            set
            {
                MacAddressSpecified = (value != null);
                _macAddress = value;
            }
        }

        [XmlIgnore]
        protected bool MacAddressSpecified { get; set; }

        protected string _serialNumber;

        [XmlElement(ElementName = "serialNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        [MinLength(1)]
        [MaxLength(80)]
        public string SerialNumber
        {
            get => _serialNumber;
            set
            {
                SerialNumberSpecified = (value != null);
                _serialNumber = value;
            }
        }

        [XmlIgnore]
        protected bool SerialNumberSpecified { get; set; }

        protected string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = (value != null);
                _description = value;
            }
        }

        [XmlIgnore]
        protected bool DescriptionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.UnboundedPositiveInt _numberOfPorts;

        [XmlElement(ElementName = "numberOfPorts", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        public BroadWorksConnector.Ocip.Models.UnboundedPositiveInt NumberOfPorts
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

        protected int _numberOfAssignedPorts;

        [XmlElement(ElementName = "numberOfAssignedPorts", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        public int NumberOfAssignedPorts
        {
            get => _numberOfAssignedPorts;
            set
            {
                NumberOfAssignedPortsSpecified = true;
                _numberOfAssignedPorts = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfAssignedPortsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AccessDeviceStatus _status;

        [XmlElement(ElementName = "status", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceStatus Status
        {
            get => _status;
            set
            {
                StatusSpecified = true;
                _status = value;
            }
        }

        [XmlIgnore]
        protected bool StatusSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode? _configurationMode;

        [XmlElement(ElementName = "configurationMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode? ConfigurationMode
        {
            get => _configurationMode;
            set
            {
                ConfigurationModeSpecified = (value != null);
                _configurationMode = value;
            }
        }

        [XmlIgnore]
        protected bool ConfigurationModeSpecified { get; set; }

        protected string _configurationFileName;

        [XmlElement(ElementName = "configurationFileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ConfigurationFileName
        {
            get => _configurationFileName;
            set
            {
                ConfigurationFileNameSpecified = (value != null);
                _configurationFileName = value;
            }
        }

        [XmlIgnore]
        protected bool ConfigurationFileNameSpecified { get; set; }

        protected string _physicalLocation;

        [XmlElement(ElementName = "physicalLocation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        [MinLength(1)]
        [MaxLength(1024)]
        public string PhysicalLocation
        {
            get => _physicalLocation;
            set
            {
                PhysicalLocationSpecified = (value != null);
                _physicalLocation = value;
            }
        }

        [XmlIgnore]
        protected bool PhysicalLocationSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedTransportProtocol? _transportProtocol;

        [XmlElement(ElementName = "transportProtocol", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        public BroadWorksConnector.Ocip.Models.ExtendedTransportProtocol? TransportProtocol
        {
            get => _transportProtocol;
            set
            {
                TransportProtocolSpecified = (value != null);
                _transportProtocol = value;
            }
        }

        [XmlIgnore]
        protected bool TransportProtocolSpecified { get; set; }

        protected bool? _useCustomUserNamePassword;

        [XmlElement(ElementName = "useCustomUserNamePassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        public bool? UseCustomUserNamePassword
        {
            get => _useCustomUserNamePassword;
            set
            {
                UseCustomUserNamePasswordSpecified = (value != null);
                _useCustomUserNamePassword = value;
            }
        }

        [XmlIgnore]
        protected bool UseCustomUserNamePasswordSpecified { get; set; }

        protected string _userName;

        [XmlElement(ElementName = "userName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserName
        {
            get => _userName;
            set
            {
                UserNameSpecified = (value != null);
                _userName = value;
            }
        }

        [XmlIgnore]
        protected bool UserNameSpecified { get; set; }

        protected string _version;

        [XmlElement(ElementName = "version", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        [MinLength(1)]
        [MaxLength(1024)]
        public string Version
        {
            get => _version;
            set
            {
                VersionSpecified = (value != null);
                _version = value;
            }
        }

        [XmlIgnore]
        protected bool VersionSpecified { get; set; }

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        protected string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DeviceName
        {
            get => _deviceName;
            set
            {
                DeviceNameSpecified = true;
                _deviceName = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceNameSpecified { get; set; }

        protected string _deviceExternalId;

        [XmlElement(ElementName = "deviceExternalId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        [MaxLength(36)]
        public string DeviceExternalId
        {
            get => _deviceExternalId;
            set
            {
                DeviceExternalIdSpecified = (value != null);
                _deviceExternalId = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceExternalIdSpecified { get; set; }

        protected string _deviceCode;

        [XmlElement(ElementName = "deviceCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        [Length(4)]
        [RegularExpression(@"[0-9][0-9][0-9][0-9]")]
        public string DeviceCode
        {
            get => _deviceCode;
            set
            {
                DeviceCodeSpecified = (value != null);
                _deviceCode = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceCodeSpecified { get; set; }

        protected string _deviceIPEI;

        [XmlElement(ElementName = "deviceIPEI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DeviceIPEI
        {
            get => _deviceIPEI;
            set
            {
                DeviceIPEISpecified = (value != null);
                _deviceIPEI = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceIPEISpecified { get; set; }

        protected int? _deviceIndex;

        [XmlElement(ElementName = "deviceIndex", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        public int? DeviceIndex
        {
            get => _deviceIndex;
            set
            {
                DeviceIndexSpecified = (value != null);
                _deviceIndex = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceIndexSpecified { get; set; }

        protected bool? _useDeviceCode;

        [XmlElement(ElementName = "useDeviceCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        public bool? UseDeviceCode
        {
            get => _useDeviceCode;
            set
            {
                UseDeviceCodeSpecified = (value != null);
                _useDeviceCode = value;
            }
        }

        [XmlIgnore]
        protected bool UseDeviceCodeSpecified { get; set; }

        protected string _authBearerSubject;

        [XmlElement(ElementName = "authBearerSubject", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:1064")]
        public string AuthBearerSubject
        {
            get => _authBearerSubject;
            set
            {
                AuthBearerSubjectSpecified = (value != null);
                _authBearerSubject = value;
            }
        }

        [XmlIgnore]
        protected bool AuthBearerSubjectSpecified { get; set; }

    }
}
