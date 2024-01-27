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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ef3c4f453d01f7ce750331de83ebc765:401""}]")]
    public class PasswordGenerateResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _systemAdministratorPassword;

        [XmlElement(ElementName = "systemAdministratorPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:401")]
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

        protected string _serviceProviderAdministratorPassword;

        [XmlElement(ElementName = "serviceProviderAdministratorPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:401")]
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

        protected string _groupAdministratorPassword;

        [XmlElement(ElementName = "groupAdministratorPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:401")]
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

        protected string _userPassword;

        [XmlElement(ElementName = "userPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:401")]
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

        protected string _userPasscode;

        [XmlElement(ElementName = "userPasscode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:401")]
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

        protected string _userSIPAuthenticationPassword;

        [XmlElement(ElementName = "userSIPAuthenticationPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:401")]
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

        protected string _accessDeviceAuthenticationPassword;

        [XmlElement(ElementName = "accessDeviceAuthenticationPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:401")]
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

        protected string _trunkGroupAuthenticationPassword;

        [XmlElement(ElementName = "trunkGroupAuthenticationPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:401")]
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
