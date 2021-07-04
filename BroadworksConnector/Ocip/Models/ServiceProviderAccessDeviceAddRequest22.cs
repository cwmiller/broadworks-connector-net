using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a service provider access device.
    /// The response is either SuccessResponse or ErrorResponse.
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// useHotline
    /// hotlineContact
    /// serviceProviderExternalId
    /// deviceExternalId
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:4615"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:4616"",""children"":[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:4617""},{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:4621""}]}]}]")]
    public class ServiceProviderAccessDeviceAddRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4617")]
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

        private string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4617")]
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

        private string _serviceProviderExternalId;

        [XmlElement(ElementName = "serviceProviderExternalId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4621")]
        [MaxLength(36)]
        public string ServiceProviderExternalId
        {
            get => _serviceProviderExternalId;
            set
            {
                ServiceProviderExternalIdSpecified = true;
                _serviceProviderExternalId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderExternalIdSpecified { get; set; }

        private string _deviceExternalId;

        [XmlElement(ElementName = "deviceExternalId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4621")]
        [MaxLength(36)]
        public string DeviceExternalId
        {
            get => _deviceExternalId;
            set
            {
                DeviceExternalIdSpecified = true;
                _deviceExternalId = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceExternalIdSpecified { get; set; }

        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4615")]
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

        private string _protocol;

        [XmlElement(ElementName = "protocol", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4615")]
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

        private string _netAddress;

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4615")]
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

        private int _port;

        [XmlElement(ElementName = "port", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4615")]
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

        private string _outboundProxyServerNetAddress;

        [XmlElement(ElementName = "outboundProxyServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4615")]
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

        private string _stunServerNetAddress;

        [XmlElement(ElementName = "stunServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4615")]
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

        private string _macAddress;

        [XmlElement(ElementName = "macAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4615")]
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

        private string _serialNumber;

        [XmlElement(ElementName = "serialNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4615")]
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

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4615")]
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

        private string _physicalLocation;

        [XmlElement(ElementName = "physicalLocation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4615")]
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

        private BroadWorksConnector.Ocip.Models.ExtendedTransportProtocol _transportProtocol;

        [XmlElement(ElementName = "transportProtocol", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4615")]
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

        private string _mobilityManagerProvisioningURL;

        [XmlElement(ElementName = "mobilityManagerProvisioningURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4615")]
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

        private string _mobilityManagerProvisioningUserName;

        [XmlElement(ElementName = "mobilityManagerProvisioningUserName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4615")]
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

        private string _mobilityManagerProvisioningPassword;

        [XmlElement(ElementName = "mobilityManagerProvisioningPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4615")]
        [MinLength(1)]
        [MaxLength(15)]
        public string MobilityManagerProvisioningPassword
        {
            get => _mobilityManagerProvisioningPassword;
            set
            {
                MobilityManagerProvisioningPasswordSpecified = true;
                _mobilityManagerProvisioningPassword = value;
            }
        }

        [XmlIgnore]
        protected bool MobilityManagerProvisioningPasswordSpecified { get; set; }

        private int _mobilityManagerDefaultOriginatingServiceKey;

        [XmlElement(ElementName = "mobilityManagerDefaultOriginatingServiceKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4615")]
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

        private int _mobilityManagerDefaultTerminatingServiceKey;

        [XmlElement(ElementName = "mobilityManagerDefaultTerminatingServiceKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4615")]
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

        private bool _useCustomUserNamePassword;

        [XmlElement(ElementName = "useCustomUserNamePassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4615")]
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

        private BroadWorksConnector.Ocip.Models.DeviceManagementUserNamePassword16 _accessDeviceCredentials;

        [XmlElement(ElementName = "accessDeviceCredentials", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4615")]
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

        private bool _useHotline;

        [XmlElement(ElementName = "useHotline", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4615")]
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

        private string _hotlineContact;

        [XmlElement(ElementName = "hotlineContact", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4615")]
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
