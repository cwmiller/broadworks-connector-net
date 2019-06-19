using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the address and credentials of the File Repository hosting the requested access device file.
    /// Also get the file name and path on the File Repository.
    /// The response is either a DeviceManagementFileAuthLocationGetResponse17 or an ErrorResponse.
    /// 
    /// Replaced by: DeviceManagementFileAuthLocationGetRequest18
    /// <see cref="DeviceManagementFileAuthLocationGetResponse17"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="DeviceManagementFileAuthLocationGetRequest18"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:18225""}]")]
    public class DeviceManagementFileAuthLocationGetRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.DeviceAccessProtocol16 _deviceAccessProtocol;

        [XmlElement(ElementName = "deviceAccessProtocol", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18225")]
        public BroadWorksConnector.Ocip.Models.DeviceAccessProtocol16 DeviceAccessProtocol
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18225")]
        [MinLength(1)]
        [MaxLength(40)]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18225")]
        [MinLength(1)]
        [MaxLength(256)]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18225")]
        [MinLength(1)]
        [MaxLength(161)]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18225")]
        [MinLength(1)]
        [MaxLength(60)]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18225")]
        [MinLength(1)]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18225")]
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
        public bool MacAddressSpecified { get; set; }

        private string _realmName;

        [XmlElement(ElementName = "realmName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18225")]
        [MinLength(1)]
        [MaxLength(265)]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18225")]
        [MinLength(32)]
        [MaxLength(256)]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18225")]
        [MinLength(32)]
        [MaxLength(32)]
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
