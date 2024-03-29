using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Access device end point used in the context of modify. .
    /// The endpoint is identified by its linePort (public Identity) and possibly a private Identity.
    /// Only Static Registration capable devices may have more than one contact defined.
    /// Only the first contact in contactList is used in XS data mode.
    /// Port numbers are only used by devices with static line ordering.
    /// 
    /// In the case an access device referenced by accessDevice does not exist, the device will be added.
    /// When the device needs to be added, if the linePort is not specified, the request will fail
    /// 
    /// If the deviceType is included in the request a new device will be created using the type unless a
    /// device with the same name already exists.
    /// 
    /// The device attributes protocol, netAddress, port, outboundProxyServerNetAddress,
    /// stunServerNetAddress, macAddress, serialNumber, description, physicalLocation, transportProtocol,
    /// useCustomUserNamePassword and accessDeviceCredentials will be ignored if the access device already
    /// exists.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// useHotline
    /// hotlineContact
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:1681""}]")]
    public class ConsolidatedAccessDeviceMultipleIdentityEndpointAndContactModify
    {

        protected BroadWorksConnector.Ocip.Models.AccessDevice _accessDevice;

        [XmlElement(ElementName = "accessDevice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1681")]
        public BroadWorksConnector.Ocip.Models.AccessDevice AccessDevice
        {
            get => _accessDevice;
            set
            {
                AccessDeviceSpecified = true;
                _accessDevice = value;
            }
        }

        [XmlIgnore]
        protected bool AccessDeviceSpecified { get; set; }

        protected string _linePort;

        [XmlElement(ElementName = "linePort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1681")]
        [MinLength(1)]
        [MaxLength(161)]
        public string LinePort
        {
            get => _linePort;
            set
            {
                LinePortSpecified = true;
                _linePort = value;
            }
        }

        [XmlIgnore]
        protected bool LinePortSpecified { get; set; }

        protected string _privateIdentity;

        [XmlElement(ElementName = "privateIdentity", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1681")]
        [MinLength(1)]
        [MaxLength(161)]
        public string PrivateIdentity
        {
            get => _privateIdentity;
            set
            {
                PrivateIdentitySpecified = true;
                _privateIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool PrivateIdentitySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementContactList _contactList;

        [XmlElement(ElementName = "contactList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1681")]
        public BroadWorksConnector.Ocip.Models.ReplacementContactList ContactList
        {
            get => _contactList;
            set
            {
                ContactListSpecified = true;
                _contactList = value;
            }
        }

        [XmlIgnore]
        protected bool ContactListSpecified { get; set; }

        protected int _portNumber;

        [XmlElement(ElementName = "portNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1681")]
        [MinInclusive(1)]
        [MaxInclusive(1024)]
        public int PortNumber
        {
            get => _portNumber;
            set
            {
                PortNumberSpecified = true;
                _portNumber = value;
            }
        }

        [XmlIgnore]
        protected bool PortNumberSpecified { get; set; }

        protected string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1681")]
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
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1681")]
        [MinLength(1)]
        [MaxLength(20)]
        public string Protocol
        {
            get => _protocol;
            set
            {
                ProtocolSpecified = true;
                _protocol = value;
            }
        }

        [XmlIgnore]
        protected bool ProtocolSpecified { get; set; }

        protected string _netAddress;

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1681")]
        [MinLength(1)]
        [MaxLength(80)]
        public string NetAddress
        {
            get => _netAddress;
            set
            {
                NetAddressSpecified = true;
                _netAddress = value;
            }
        }

        [XmlIgnore]
        protected bool NetAddressSpecified { get; set; }

        protected int _port;

        [XmlElement(ElementName = "port", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1681")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int Port
        {
            get => _port;
            set
            {
                PortSpecified = true;
                _port = value;
            }
        }

        [XmlIgnore]
        protected bool PortSpecified { get; set; }

        protected string _outboundProxyServerNetAddress;

        [XmlElement(ElementName = "outboundProxyServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1681")]
        [MinLength(1)]
        [MaxLength(80)]
        public string OutboundProxyServerNetAddress
        {
            get => _outboundProxyServerNetAddress;
            set
            {
                OutboundProxyServerNetAddressSpecified = true;
                _outboundProxyServerNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool OutboundProxyServerNetAddressSpecified { get; set; }

        protected string _stunServerNetAddress;

        [XmlElement(ElementName = "stunServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1681")]
        [MinLength(1)]
        [MaxLength(80)]
        public string StunServerNetAddress
        {
            get => _stunServerNetAddress;
            set
            {
                StunServerNetAddressSpecified = true;
                _stunServerNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool StunServerNetAddressSpecified { get; set; }

        protected string _macAddress;

        [XmlElement(ElementName = "macAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1681")]
        [MinLength(1)]
        [MaxLength(12)]
        public string MacAddress
        {
            get => _macAddress;
            set
            {
                MacAddressSpecified = true;
                _macAddress = value;
            }
        }

        [XmlIgnore]
        protected bool MacAddressSpecified { get; set; }

        protected string _serialNumber;

        [XmlElement(ElementName = "serialNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1681")]
        [MinLength(1)]
        [MaxLength(80)]
        public string SerialNumber
        {
            get => _serialNumber;
            set
            {
                SerialNumberSpecified = true;
                _serialNumber = value;
            }
        }

        [XmlIgnore]
        protected bool SerialNumberSpecified { get; set; }

        protected string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1681")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        protected bool DescriptionSpecified { get; set; }

        protected string _physicalLocation;

        [XmlElement(ElementName = "physicalLocation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1681")]
        [MinLength(1)]
        [MaxLength(1024)]
        public string PhysicalLocation
        {
            get => _physicalLocation;
            set
            {
                PhysicalLocationSpecified = true;
                _physicalLocation = value;
            }
        }

        [XmlIgnore]
        protected bool PhysicalLocationSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedTransportProtocol _transportProtocol;

        [XmlElement(ElementName = "transportProtocol", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1681")]
        public BroadWorksConnector.Ocip.Models.ExtendedTransportProtocol TransportProtocol
        {
            get => _transportProtocol;
            set
            {
                TransportProtocolSpecified = true;
                _transportProtocol = value;
            }
        }

        [XmlIgnore]
        protected bool TransportProtocolSpecified { get; set; }

        protected bool _useCustomUserNamePassword;

        [XmlElement(ElementName = "useCustomUserNamePassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1681")]
        public bool UseCustomUserNamePassword
        {
            get => _useCustomUserNamePassword;
            set
            {
                UseCustomUserNamePasswordSpecified = true;
                _useCustomUserNamePassword = value;
            }
        }

        [XmlIgnore]
        protected bool UseCustomUserNamePasswordSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DeviceManagementUserNamePassword16 _accessDeviceCredentials;

        [XmlElement(ElementName = "accessDeviceCredentials", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1681")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementUserNamePassword16 AccessDeviceCredentials
        {
            get => _accessDeviceCredentials;
            set
            {
                AccessDeviceCredentialsSpecified = true;
                _accessDeviceCredentials = value;
            }
        }

        [XmlIgnore]
        protected bool AccessDeviceCredentialsSpecified { get; set; }

        protected bool _useHotline;

        [XmlElement(ElementName = "useHotline", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1681")]
        public bool UseHotline
        {
            get => _useHotline;
            set
            {
                UseHotlineSpecified = true;
                _useHotline = value;
            }
        }

        [XmlIgnore]
        protected bool UseHotlineSpecified { get; set; }

        protected string _hotlineContact;

        [XmlElement(ElementName = "hotlineContact", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1681")]
        [MinLength(1)]
        [MaxLength(161)]
        public string HotlineContact
        {
            get => _hotlineContact;
            set
            {
                HotlineContactSpecified = true;
                _hotlineContact = value;
            }
        }

        [XmlIgnore]
        protected bool HotlineContactSpecified { get; set; }

    }
}
