using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Password to be generated for a group administrator. If the administratorId is not included, or included but
    /// is not an exiting administrator for the group, a password will be generated based on only the rules applicable
    /// for a new user.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:731""}]")]
    public class PasswordForGroupAdministrator
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:731")]
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

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:731")]
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

        protected string _administratorId;

        [XmlElement(ElementName = "administratorId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:731")]
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
        [Group(@"6b27fcc79475236456fc113a42b75543:731")]
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
