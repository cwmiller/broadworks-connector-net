using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderAccessDeviceGetRequest14sp3.
    /// Replaced By: ServiceProviderAccessDeviceGetRequest14sp6
    /// <see cref="ServiceProviderAccessDeviceGetRequest14sp3"/>
    /// <see cref="ServiceProviderAccessDeviceGetRequest14sp6"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:17377""}]")]
    public class ServiceProviderAccessDeviceGetResponse14sp3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:17377")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:17377")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:17377")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:17377")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:17377")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:17377")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:17377")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:17377")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:17377")]
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

        protected BroadWorksConnector.Ocip.Models.UnboundedPositiveInt _numberOfPorts;

        [XmlElement(ElementName = "numberOfPorts", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:17377")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:17377")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:17377")]
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

        protected string _physicalLocation;

        [XmlElement(ElementName = "physicalLocation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:17377")]
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

        protected BroadWorksConnector.Ocip.Models.TransportProtocol _transportProtocol;

        [XmlElement(ElementName = "transportProtocol", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:17377")]
        public BroadWorksConnector.Ocip.Models.TransportProtocol TransportProtocol
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

        protected string _mobilityManagerProvisioningURL;

        [XmlElement(ElementName = "mobilityManagerProvisioningURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:17377")]
        [MinLength(1)]
        [MaxLength(256)]
        public string MobilityManagerProvisioningURL
        {
            get => _mobilityManagerProvisioningURL;
            set
            {
                MobilityManagerProvisioningURLSpecified = true;
                _mobilityManagerProvisioningURL = value;
            }
        }

        [XmlIgnore]
        protected bool MobilityManagerProvisioningURLSpecified { get; set; }

        protected string _mobilityManagerProvisioningUserName;

        [XmlElement(ElementName = "mobilityManagerProvisioningUserName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:17377")]
        [MinLength(1)]
        [MaxLength(15)]
        public string MobilityManagerProvisioningUserName
        {
            get => _mobilityManagerProvisioningUserName;
            set
            {
                MobilityManagerProvisioningUserNameSpecified = true;
                _mobilityManagerProvisioningUserName = value;
            }
        }

        [XmlIgnore]
        protected bool MobilityManagerProvisioningUserNameSpecified { get; set; }

        protected int _mobilityManagerDefaultOriginatingServiceKey;

        [XmlElement(ElementName = "mobilityManagerDefaultOriginatingServiceKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:17377")]
        [MinInclusive(0)]
        [MaxInclusive(999)]
        public int MobilityManagerDefaultOriginatingServiceKey
        {
            get => _mobilityManagerDefaultOriginatingServiceKey;
            set
            {
                MobilityManagerDefaultOriginatingServiceKeySpecified = true;
                _mobilityManagerDefaultOriginatingServiceKey = value;
            }
        }

        [XmlIgnore]
        protected bool MobilityManagerDefaultOriginatingServiceKeySpecified { get; set; }

        protected int _mobilityManagerDefaultTerminatingServiceKey;

        [XmlElement(ElementName = "mobilityManagerDefaultTerminatingServiceKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:17377")]
        [MinInclusive(0)]
        [MaxInclusive(999)]
        public int MobilityManagerDefaultTerminatingServiceKey
        {
            get => _mobilityManagerDefaultTerminatingServiceKey;
            set
            {
                MobilityManagerDefaultTerminatingServiceKeySpecified = true;
                _mobilityManagerDefaultTerminatingServiceKey = value;
            }
        }

        [XmlIgnore]
        protected bool MobilityManagerDefaultTerminatingServiceKeySpecified { get; set; }

    }
}
