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
    /// The response is either DeviceManagementFileAuthLocationGetResponse22V3 or ErrorResponse.
    /// The following elements are only used in AS data mode and will fail in XS data mode:
    /// deviceToken
    /// The following elements are only used in XS data mode and will be ignored in AS data mode:
    /// fileNameLookup
    /// fileNameOnDisk
    /// <see cref="DeviceManagementFileAuthLocationGetResponse22V3"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:153""}]")]
    public class DeviceManagementFileAuthLocationGetRequest22V3 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.DeviceAccessProtocol22 _deviceAccessProtocol;

        [XmlElement(ElementName = "deviceAccessProtocol", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:153")]
        public BroadWorksConnector.Ocip.Models.DeviceAccessProtocol22 DeviceAccessProtocol
        {
            get => _deviceAccessProtocol;
            set
            {
                DeviceAccessProtocolSpecified = true;
                _deviceAccessProtocol = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceAccessProtocolSpecified { get; set; }

        private string _deviceAccessMethod;

        [XmlElement(ElementName = "deviceAccessMethod", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:153")]
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
        protected bool DeviceAccessMethodSpecified { get; set; }

        private string _deviceAccessURI;

        [XmlElement(ElementName = "deviceAccessURI", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:153")]
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
        protected bool DeviceAccessURISpecified { get; set; }

        private string _accessDeviceUserName;

        [XmlElement(ElementName = "accessDeviceUserName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:153")]
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
        protected bool AccessDeviceUserNameSpecified { get; set; }

        private string _accessDeviceUserPassword;

        [XmlElement(ElementName = "accessDeviceUserPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:153")]
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
        protected bool AccessDeviceUserPasswordSpecified { get; set; }

        private string _deviceToken;

        [XmlElement(ElementName = "deviceToken", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:153")]
        [MinLength(1)]
        public string DeviceToken
        {
            get => _deviceToken;
            set
            {
                DeviceTokenSpecified = true;
                _deviceToken = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceTokenSpecified { get; set; }

        private string _signedPassword;

        [XmlElement(ElementName = "signedPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:153")]
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
        protected bool SignedPasswordSpecified { get; set; }

        private string _macAddress;

        [XmlElement(ElementName = "macAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:153")]
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

        private string _realmName;

        [XmlElement(ElementName = "realmName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:153")]
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
        protected bool RealmNameSpecified { get; set; }

        private string _digestHa1Complement;

        [XmlElement(ElementName = "digestHa1Complement", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:153")]
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
        protected bool DigestHa1ComplementSpecified { get; set; }

        private string _digestResponse;

        [XmlElement(ElementName = "digestResponse", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:153")]
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
        protected bool DigestResponseSpecified { get; set; }

        private bool _fileNameLookup;

        [XmlElement(ElementName = "fileNameLookup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:153")]
        public bool FileNameLookup
        {
            get => _fileNameLookup;
            set
            {
                FileNameLookupSpecified = true;
                _fileNameLookup = value;
            }
        }

        [XmlIgnore]
        protected bool FileNameLookupSpecified { get; set; }

        private string _fileNameOnDisk;

        [XmlElement(ElementName = "fileNameOnDisk", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:153")]
        [MinLength(1)]
        [MaxLength(265)]
        public string FileNameOnDisk
        {
            get => _fileNameOnDisk;
            set
            {
                FileNameOnDiskSpecified = true;
                _fileNameOnDisk = value;
            }
        }

        [XmlIgnore]
        protected bool FileNameOnDiskSpecified { get; set; }

    }
}
