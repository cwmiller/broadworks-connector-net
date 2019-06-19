using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Access device end point that can have multiple contacts.
    /// The endpoint is identified by its linePort (public Identity) and possibly a private Identity.
    /// Port numbers are only used by devices with static line ordering.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:418""}]")]
    public class AccessDeviceMultipleIdentityEndpointWithType
    {

        private BroadWorksConnector.Ocip.Models.AccessDevice _accessDevice;

        [XmlElement(ElementName = "accessDevice", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:418")]
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
        public bool AccessDeviceSpecified { get; set; }

        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:418")]
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
        public bool DeviceTypeSpecified { get; set; }

        private string _linePort;

        [XmlElement(ElementName = "linePort", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:418")]
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
        public bool LinePortSpecified { get; set; }

        private string _privateIdentity;

        [XmlElement(ElementName = "privateIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:418")]
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
        public bool PrivateIdentitySpecified { get; set; }

        private string _contact;

        [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:418")]
        [MinLength(1)]
        [MaxLength(1020)]
        public string Contact
        {
            get => _contact;
            set
            {
                ContactSpecified = true;
                _contact = value;
            }
        }

        [XmlIgnore]
        public bool ContactSpecified { get; set; }

        private int _portNumber;

        [XmlElement(ElementName = "portNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:418")]
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
        public bool PortNumberSpecified { get; set; }

        private string _macAddress;

        [XmlElement(ElementName = "macAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:418")]
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

    }
}
