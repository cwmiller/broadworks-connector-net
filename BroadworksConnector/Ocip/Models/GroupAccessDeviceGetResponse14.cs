using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAccessDeviceGetRequest14.
    /// Replaced By: GroupAccessDeviceGetResponse14sp3
        /// <see cref="GroupAccessDeviceGetRequest14"/>
        /// <see cref="GroupAccessDeviceGetResponse14sp3"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupAccessDeviceGetResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        public string DeviceType {
            get => _deviceType;
            set {
                DeviceTypeSpecified = true;
                _deviceType = value;
            }
        }

        [XmlIgnore]
        public bool DeviceTypeSpecified { get; set; }
        
        private string _protocol;

        [XmlElement(ElementName = "protocol", IsNullable = false, Namespace = "")]
        public string Protocol {
            get => _protocol;
            set {
                ProtocolSpecified = true;
                _protocol = value;
            }
        }

        [XmlIgnore]
        public bool ProtocolSpecified { get; set; }
        
        private string _netAddress;

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        public string NetAddress {
            get => _netAddress;
            set {
                NetAddressSpecified = true;
                _netAddress = value;
            }
        }

        [XmlIgnore]
        public bool NetAddressSpecified { get; set; }
        
        private int _port;

        [XmlElement(ElementName = "port", IsNullable = false, Namespace = "")]
        public int Port {
            get => _port;
            set {
                PortSpecified = true;
                _port = value;
            }
        }

        [XmlIgnore]
        public bool PortSpecified { get; set; }
        
        private string _outboundProxyServerNetAddress;

        [XmlElement(ElementName = "outboundProxyServerNetAddress", IsNullable = false, Namespace = "")]
        public string OutboundProxyServerNetAddress {
            get => _outboundProxyServerNetAddress;
            set {
                OutboundProxyServerNetAddressSpecified = true;
                _outboundProxyServerNetAddress = value;
            }
        }

        [XmlIgnore]
        public bool OutboundProxyServerNetAddressSpecified { get; set; }
        
        private string _stunServerNetAddress;

        [XmlElement(ElementName = "stunServerNetAddress", IsNullable = false, Namespace = "")]
        public string StunServerNetAddress {
            get => _stunServerNetAddress;
            set {
                StunServerNetAddressSpecified = true;
                _stunServerNetAddress = value;
            }
        }

        [XmlIgnore]
        public bool StunServerNetAddressSpecified { get; set; }
        
        private string _macAddress;

        [XmlElement(ElementName = "macAddress", IsNullable = false, Namespace = "")]
        public string MacAddress {
            get => _macAddress;
            set {
                MacAddressSpecified = true;
                _macAddress = value;
            }
        }

        [XmlIgnore]
        public bool MacAddressSpecified { get; set; }
        
        private string _serialNumber;

        [XmlElement(ElementName = "serialNumber", IsNullable = false, Namespace = "")]
        public string SerialNumber {
            get => _serialNumber;
            set {
                SerialNumberSpecified = true;
                _serialNumber = value;
            }
        }

        [XmlIgnore]
        public bool SerialNumberSpecified { get; set; }
        
        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        public string Description {
            get => _description;
            set {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.UnboundedPositiveInt _numberOfPorts;

        [XmlElement(ElementName = "numberOfPorts", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.UnboundedPositiveInt NumberOfPorts {
            get => _numberOfPorts;
            set {
                NumberOfPortsSpecified = true;
                _numberOfPorts = value;
            }
        }

        [XmlIgnore]
        public bool NumberOfPortsSpecified { get; set; }
        
        private int _numberOfAssignedPorts;

        [XmlElement(ElementName = "numberOfAssignedPorts", IsNullable = false, Namespace = "")]
        public int NumberOfAssignedPorts {
            get => _numberOfAssignedPorts;
            set {
                NumberOfAssignedPortsSpecified = true;
                _numberOfAssignedPorts = value;
            }
        }

        [XmlIgnore]
        public bool NumberOfAssignedPortsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.AccessDeviceStatus _status;

        [XmlElement(ElementName = "status", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceStatus Status {
            get => _status;
            set {
                StatusSpecified = true;
                _status = value;
            }
        }

        [XmlIgnore]
        public bool StatusSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode _configurationMode;

        [XmlElement(ElementName = "configurationMode", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode ConfigurationMode {
            get => _configurationMode;
            set {
                ConfigurationModeSpecified = true;
                _configurationMode = value;
            }
        }

        [XmlIgnore]
        public bool ConfigurationModeSpecified { get; set; }
        
        private string _configurationFileName;

        [XmlElement(ElementName = "configurationFileName", IsNullable = false, Namespace = "")]
        public string ConfigurationFileName {
            get => _configurationFileName;
            set {
                ConfigurationFileNameSpecified = true;
                _configurationFileName = value;
            }
        }

        [XmlIgnore]
        public bool ConfigurationFileNameSpecified { get; set; }
        
        private string _physicalLocation;

        [XmlElement(ElementName = "physicalLocation", IsNullable = false, Namespace = "")]
        public string PhysicalLocation {
            get => _physicalLocation;
            set {
                PhysicalLocationSpecified = true;
                _physicalLocation = value;
            }
        }

        [XmlIgnore]
        public bool PhysicalLocationSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.TransportProtocol _transportProtocol;

        [XmlElement(ElementName = "transportProtocol", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.TransportProtocol TransportProtocol {
            get => _transportProtocol;
            set {
                TransportProtocolSpecified = true;
                _transportProtocol = value;
            }
        }

        [XmlIgnore]
        public bool TransportProtocolSpecified { get; set; }
        
    }
}
