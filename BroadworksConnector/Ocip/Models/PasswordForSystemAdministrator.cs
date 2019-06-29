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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:821""}]")]
    public class PasswordForSystemAdministrator
    {

        private string _administratorId;

        [XmlElement(ElementName = "administratorId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:821")]
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

        private bool _generatePassword;

        [XmlElement(ElementName = "generatePassword", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:821")]
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
