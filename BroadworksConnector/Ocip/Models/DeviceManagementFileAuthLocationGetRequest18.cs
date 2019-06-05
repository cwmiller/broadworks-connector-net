using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class DeviceManagementFileAuthLocationGetRequest18 : BroadworksConnector.Ocip.Models.C.OCIRequest
    {
        private BroadworksConnector.Ocip.Models.DeviceAccessProtocol16 _deviceAccessProtocol;

        [XmlElement(ElementName = "deviceAccessProtocol", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.DeviceAccessProtocol16 DeviceAccessProtocol
        {
            get => _deviceAccessProtocol;
            set
            {
                DeviceAccessProtocolSpecified = true;
                _deviceAccessProtocol = value;
            }
        }

        [XmlIgnore]
        public bool DeviceAccessProtocolSpecified { get; set; }
        private string _deviceAccessMethod;

        [XmlElement(ElementName = "deviceAccessMethod", IsNullable = false, Namespace = "")]
        public string DeviceAccessMethod
        {
            get => _deviceAccessMethod;
            set
            {
                DeviceAccessMethodSpecified = true;
                _deviceAccessMethod = value;
            }
        }

        [XmlIgnore]
        public bool DeviceAccessMethodSpecified { get; set; }
        private string _deviceAccessURI;

        [XmlElement(ElementName = "deviceAccessURI", IsNullable = false, Namespace = "")]
        public string DeviceAccessURI
        {
            get => _deviceAccessURI;
            set
            {
                DeviceAccessURISpecified = true;
                _deviceAccessURI = value;
            }
        }

        [XmlIgnore]
        public bool DeviceAccessURISpecified { get; set; }
        private string _accessDeviceUserName;

        [XmlElement(ElementName = "accessDeviceUserName", IsNullable = false, Namespace = "")]
        public string AccessDeviceUserName
        {
            get => _accessDeviceUserName;
            set
            {
                AccessDeviceUserNameSpecified = true;
                _accessDeviceUserName = value;
            }
        }

        [XmlIgnore]
        public bool AccessDeviceUserNameSpecified { get; set; }
        private string _accessDeviceUserPassword;

        [XmlElement(ElementName = "accessDeviceUserPassword", IsNullable = false, Namespace = "")]
        public string AccessDeviceUserPassword
        {
            get => _accessDeviceUserPassword;
            set
            {
                AccessDeviceUserPasswordSpecified = true;
                _accessDeviceUserPassword = value;
            }
        }

        [XmlIgnore]
        public bool AccessDeviceUserPasswordSpecified { get; set; }
        private string _signedPassword;

        [XmlElement(ElementName = "signedPassword", IsNullable = false, Namespace = "")]
        public string SignedPassword
        {
            get => _signedPassword;
            set
            {
                SignedPasswordSpecified = true;
                _signedPassword = value;
            }
        }

        [XmlIgnore]
        public bool SignedPasswordSpecified { get; set; }
        private string _macAddress;

        [XmlElement(ElementName = "macAddress", IsNullable = false, Namespace = "")]
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
        public bool MacAddressSpecified { get; set; }
        private string _realmName;

        [XmlElement(ElementName = "realmName", IsNullable = false, Namespace = "")]
        public string RealmName
        {
            get => _realmName;
            set
            {
                RealmNameSpecified = true;
                _realmName = value;
            }
        }

        [XmlIgnore]
        public bool RealmNameSpecified { get; set; }
        private string _digestHa1Complement;

        [XmlElement(ElementName = "digestHa1Complement", IsNullable = false, Namespace = "")]
        public string DigestHa1Complement
        {
            get => _digestHa1Complement;
            set
            {
                DigestHa1ComplementSpecified = true;
                _digestHa1Complement = value;
            }
        }

        [XmlIgnore]
        public bool DigestHa1ComplementSpecified { get; set; }
        private string _digestResponse;

        [XmlElement(ElementName = "digestResponse", IsNullable = false, Namespace = "")]
        public string DigestResponse
        {
            get => _digestResponse;
            set
            {
                DigestResponseSpecified = true;
                _digestResponse = value;
            }
        }

        [XmlIgnore]
        public bool DigestResponseSpecified { get; set; }
    }
}
