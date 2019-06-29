using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the PasswordGenerateRequest.
    /// The response contains the requested passwords.
    /// <see cref="PasswordGenerateRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:459""}]")]
    public class PasswordGenerateResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _systemAdministratorPassword;

        [XmlElement(ElementName = "systemAdministratorPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:459")]
        [MinLength(1)]
        [MaxLength(60)]
        public string SystemAdministratorPassword
        {
            get => _systemAdministratorPassword;
            set
            {
                SystemAdministratorPasswordSpecified = true;
                _systemAdministratorPassword = value;
            }
        }

        [XmlIgnore]
        protected bool SystemAdministratorPasswordSpecified { get; set; }

        private string _serviceProviderAdministratorPassword;

        [XmlElement(ElementName = "serviceProviderAdministratorPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:459")]
        [MinLength(1)]
        [MaxLength(60)]
        public string ServiceProviderAdministratorPassword
        {
            get => _serviceProviderAdministratorPassword;
            set
            {
                ServiceProviderAdministratorPasswordSpecified = true;
                _serviceProviderAdministratorPassword = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdministratorPasswordSpecified { get; set; }

        private string _groupAdministratorPassword;

        [XmlElement(ElementName = "groupAdministratorPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:459")]
        [MinLength(1)]
        [MaxLength(60)]
        public string GroupAdministratorPassword
        {
            get => _groupAdministratorPassword;
            set
            {
                GroupAdministratorPasswordSpecified = true;
                _groupAdministratorPassword = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdministratorPasswordSpecified { get; set; }

        private string _userPassword;

        [XmlElement(ElementName = "userPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:459")]
        [MinLength(1)]
        [MaxLength(60)]
        public string UserPassword
        {
            get => _userPassword;
            set
            {
                UserPasswordSpecified = true;
                _userPassword = value;
            }
        }

        [XmlIgnore]
        protected bool UserPasswordSpecified { get; set; }

        private string _userPasscode;

        [XmlElement(ElementName = "userPasscode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:459")]
        [MinLength(1)]
        [MaxLength(30)]
        public string UserPasscode
        {
            get => _userPasscode;
            set
            {
                UserPasscodeSpecified = true;
                _userPasscode = value;
            }
        }

        [XmlIgnore]
        protected bool UserPasscodeSpecified { get; set; }

        private string _userSIPAuthenticationPassword;

        [XmlElement(ElementName = "userSIPAuthenticationPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:459")]
        [MinLength(1)]
        [MaxLength(60)]
        public string UserSIPAuthenticationPassword
        {
            get => _userSIPAuthenticationPassword;
            set
            {
                UserSIPAuthenticationPasswordSpecified = true;
                _userSIPAuthenticationPassword = value;
            }
        }

        [XmlIgnore]
        protected bool UserSIPAuthenticationPasswordSpecified { get; set; }

        private string _accessDeviceAuthenticationPassword;

        [XmlElement(ElementName = "accessDeviceAuthenticationPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:459")]
        [MinLength(1)]
        [MaxLength(60)]
        public string AccessDeviceAuthenticationPassword
        {
            get => _accessDeviceAuthenticationPassword;
            set
            {
                AccessDeviceAuthenticationPasswordSpecified = true;
                _accessDeviceAuthenticationPassword = value;
            }
        }

        [XmlIgnore]
        protected bool AccessDeviceAuthenticationPasswordSpecified { get; set; }

        private string _trunkGroupAuthenticationPassword;

        [XmlElement(ElementName = "trunkGroupAuthenticationPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:459")]
        [MinLength(1)]
        [MaxLength(60)]
        public string TrunkGroupAuthenticationPassword
        {
            get => _trunkGroupAuthenticationPassword;
            set
            {
                TrunkGroupAuthenticationPasswordSpecified = true;
                _trunkGroupAuthenticationPassword = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupAuthenticationPasswordSpecified { get; set; }

    }
}
