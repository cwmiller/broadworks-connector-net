using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccessDeviceAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _deviceName;

    [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
    public string DeviceName {
        get => _deviceName;
        set {
            DeviceNameSpecified = true;
            _deviceName = value;
        }
    }

    [XmlIgnore]
    public bool DeviceNameSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.TransportProtocol _transportProtocol;

    [XmlElement(ElementName = "transportProtocol", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.TransportProtocol TransportProtocol {
        get => _transportProtocol;
        set {
            TransportProtocolSpecified = true;
            _transportProtocol = value;
        }
    }

    [XmlIgnore]
    public bool TransportProtocolSpecified { get; set; }
    private string _mobilityManagerProvisioningURL;

    [XmlElement(ElementName = "mobilityManagerProvisioningURL", IsNullable = false, Namespace = "")]
    public string MobilityManagerProvisioningURL {
        get => _mobilityManagerProvisioningURL;
        set {
            MobilityManagerProvisioningURLSpecified = true;
            _mobilityManagerProvisioningURL = value;
        }
    }

    [XmlIgnore]
    public bool MobilityManagerProvisioningURLSpecified { get; set; }
    private string _mobilityManagerProvisioningUserName;

    [XmlElement(ElementName = "mobilityManagerProvisioningUserName", IsNullable = false, Namespace = "")]
    public string MobilityManagerProvisioningUserName {
        get => _mobilityManagerProvisioningUserName;
        set {
            MobilityManagerProvisioningUserNameSpecified = true;
            _mobilityManagerProvisioningUserName = value;
        }
    }

    [XmlIgnore]
    public bool MobilityManagerProvisioningUserNameSpecified { get; set; }
    private string _mobilityManagerProvisioningPassword;

    [XmlElement(ElementName = "mobilityManagerProvisioningPassword", IsNullable = false, Namespace = "")]
    public string MobilityManagerProvisioningPassword {
        get => _mobilityManagerProvisioningPassword;
        set {
            MobilityManagerProvisioningPasswordSpecified = true;
            _mobilityManagerProvisioningPassword = value;
        }
    }

    [XmlIgnore]
    public bool MobilityManagerProvisioningPasswordSpecified { get; set; }
    private int _mobilityManagerDefaultOriginatingServiceKey;

    [XmlElement(ElementName = "mobilityManagerDefaultOriginatingServiceKey", IsNullable = false, Namespace = "")]
    public int MobilityManagerDefaultOriginatingServiceKey {
        get => _mobilityManagerDefaultOriginatingServiceKey;
        set {
            MobilityManagerDefaultOriginatingServiceKeySpecified = true;
            _mobilityManagerDefaultOriginatingServiceKey = value;
        }
    }

    [XmlIgnore]
    public bool MobilityManagerDefaultOriginatingServiceKeySpecified { get; set; }
    private int _mobilityManagerDefaultTerminatingServiceKey;

    [XmlElement(ElementName = "mobilityManagerDefaultTerminatingServiceKey", IsNullable = false, Namespace = "")]
    public int MobilityManagerDefaultTerminatingServiceKey {
        get => _mobilityManagerDefaultTerminatingServiceKey;
        set {
            MobilityManagerDefaultTerminatingServiceKeySpecified = true;
            _mobilityManagerDefaultTerminatingServiceKey = value;
        }
    }

    [XmlIgnore]
    public bool MobilityManagerDefaultTerminatingServiceKeySpecified { get; set; }
    private bool _useCustomUserNamePassword;

    [XmlElement(ElementName = "useCustomUserNamePassword", IsNullable = false, Namespace = "")]
    public bool UseCustomUserNamePassword {
        get => _useCustomUserNamePassword;
        set {
            UseCustomUserNamePasswordSpecified = true;
            _useCustomUserNamePassword = value;
        }
    }

    [XmlIgnore]
    public bool UseCustomUserNamePasswordSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.DeviceManagementUserNamePassword16 _accessDeviceCredentials;

    [XmlElement(ElementName = "accessDeviceCredentials", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.DeviceManagementUserNamePassword16 AccessDeviceCredentials {
        get => _accessDeviceCredentials;
        set {
            AccessDeviceCredentialsSpecified = true;
            _accessDeviceCredentials = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceCredentialsSpecified { get; set; }
}
}
