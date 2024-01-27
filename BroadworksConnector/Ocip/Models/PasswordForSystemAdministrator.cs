using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Password to be generated for a System or Provisioning administrator. If the administratorId is
    /// not included, or included but is not an exiting administrator for the
    /// service provider, a password will be generated
    /// based on only the rules applicable for a new user.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ef3c4f453d01f7ce750331de83ebc765:701""}]")]
    public class PasswordForSystemAdministrator
    {

        protected string _administratorId;

        [XmlElement(ElementName = "administratorId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:701")]
        [MinLength(1)]
        [MaxLength(161)]
        public string AdministratorId
        {
            get => _administratorId;
            set
            {
                AdministratorIdSpecified = true;
                _administratorId = value;
            }
        }

        [XmlIgnore]
        protected bool AdministratorIdSpecified { get; set; }

        protected bool _generatePassword;

        [XmlElement(ElementName = "generatePassword", IsNullable = false, Namespace = "")]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:701")]
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

    }
}
