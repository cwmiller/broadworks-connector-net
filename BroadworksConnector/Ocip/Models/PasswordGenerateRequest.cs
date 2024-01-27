using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Generate passwords based on the corresponding password/passcode rules.
    /// The response is either PasswordGenerateResponse or ErrorResponse.
    /// <see cref="PasswordGenerateResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ef3c4f453d01f7ce750331de83ebc765:380""}]")]
    public class PasswordGenerateRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.PasswordGenerateResponse>
    {

        protected BroadWorksConnector.Ocip.Models.PasswordForSystemAdministrator _systemAdministratorPassword;

        [XmlElement(ElementName = "systemAdministratorPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:380")]
        public BroadWorksConnector.Ocip.Models.PasswordForSystemAdministrator SystemAdministratorPassword
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

        protected BroadWorksConnector.Ocip.Models.PasswordForServiceProviderAdministrator _serviceProviderAdministratorPassword;

        [XmlElement(ElementName = "serviceProviderAdministratorPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:380")]
        public BroadWorksConnector.Ocip.Models.PasswordForServiceProviderAdministrator ServiceProviderAdministratorPassword
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

        protected BroadWorksConnector.Ocip.Models.PasswordForGroupAdministrator _groupAdministratorPassword;

        [XmlElement(ElementName = "groupAdministratorPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:380")]
        public BroadWorksConnector.Ocip.Models.PasswordForGroupAdministrator GroupAdministratorPassword
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

        protected BroadWorksConnector.Ocip.Models.PasswordForUser _userPassword;

        [XmlElement(ElementName = "userPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:380")]
        public BroadWorksConnector.Ocip.Models.PasswordForUser UserPassword
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

        protected BroadWorksConnector.Ocip.Models.PasswordForAccessDevice _accessDeviceAuthenticationPassword;

        [XmlElement(ElementName = "accessDeviceAuthenticationPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:380")]
        public BroadWorksConnector.Ocip.Models.PasswordForAccessDevice AccessDeviceAuthenticationPassword
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

        protected BroadWorksConnector.Ocip.Models.PasswordForTrunkGroup _trunkGroupAuthenticationPassword;

        [XmlElement(ElementName = "trunkGroupAuthenticationPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:380")]
        public BroadWorksConnector.Ocip.Models.PasswordForTrunkGroup TrunkGroupAuthenticationPassword
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
