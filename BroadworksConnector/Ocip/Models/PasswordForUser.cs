using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Passwords, passcode and SIP authentication passwords to be generated for a user. If the userId is not
    /// included or included but is not an existing user in the group, a password will be generated based on only
    /// the rules applicable for a new user.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:795""}]")]
    public class PasswordForUser
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:795")]
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

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:795")]
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
        protected bool GroupIdSpecified { get; set; }

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:795")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        private bool _generatePassword;

        [XmlElement(ElementName = "generatePassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:795")]
        public bool GeneratePassword
        {
            get => _generatePassword;
            set
            {
                GeneratePasswordSpecified = true;
                _generatePassword = value;
            }
        }

        [XmlIgnore]
        protected bool GeneratePasswordSpecified { get; set; }

        private bool _generatePasscode;

        [XmlElement(ElementName = "generatePasscode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:795")]
        public bool GeneratePasscode
        {
            get => _generatePasscode;
            set
            {
                GeneratePasscodeSpecified = true;
                _generatePasscode = value;
            }
        }

        [XmlIgnore]
        protected bool GeneratePasscodeSpecified { get; set; }

        private bool _generateSipPassword;

        [XmlElement(ElementName = "generateSipPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:795")]
        public bool GenerateSipPassword
        {
            get => _generateSipPassword;
            set
            {
                GenerateSipPasswordSpecified = true;
                _generateSipPassword = value;
            }
        }

        [XmlIgnore]
        protected bool GenerateSipPasswordSpecified { get; set; }

    }
}
