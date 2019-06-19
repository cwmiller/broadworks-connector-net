using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Passwords to be generated for an access device.
    /// The combination of serviceProviderId, groupId, and deviceName will be used
    /// to find the device if it exists. If the device doesn't exist yet, then
    /// the serviceProviderId and groupId will be used to choose the password
    /// rules with which to generate the device password.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:773""}]")]
    public class PasswordForAccessDevice
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:773")]
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
        public bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:773")]
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
        public bool GroupIdSpecified { get; set; }

        private string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:773")]
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
        public bool DeviceNameSpecified { get; set; }

        private bool _generateDeviceAuthenticationPassword;

        [XmlElement(ElementName = "generateDeviceAuthenticationPassword", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:773")]
        public bool GenerateDeviceAuthenticationPassword
        {
            get => _generateDeviceAuthenticationPassword;
            set
            {
                GenerateDeviceAuthenticationPasswordSpecified = true;
                _generateDeviceAuthenticationPassword = value;
            }
        }

        [XmlIgnore]
        public bool GenerateDeviceAuthenticationPasswordSpecified { get; set; }

    }
}
