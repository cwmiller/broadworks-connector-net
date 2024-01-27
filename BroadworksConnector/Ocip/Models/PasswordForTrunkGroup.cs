using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Passwords to be generated for a trunk group.
    /// The combination of serviceProviderId, groupId, and name will be used to
    /// find the trunk group if it exists. If the trunk group doesn't exist yet,
    /// then the serviceProviderId and groupId will be used to choose the password
    /// rules with which to generate the trunk group password.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ef3c4f453d01f7ce750331de83ebc765:717""}]")]
    public class PasswordForTrunkGroup
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:717")]
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
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:717")]
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

        protected string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:717")]
        [MinLength(1)]
        [MaxLength(30)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        protected bool _generateTrunkGroupAuthenticationPassword;

        [XmlElement(ElementName = "generateTrunkGroupAuthenticationPassword", IsNullable = false, Namespace = "")]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:717")]
        public bool GenerateTrunkGroupAuthenticationPassword
        {
            get => _generateTrunkGroupAuthenticationPassword;
            set
            {
                GenerateTrunkGroupAuthenticationPasswordSpecified = true;
                _generateTrunkGroupAuthenticationPassword = value;
            }
        }

        [XmlIgnore]
        protected bool GenerateTrunkGroupAuthenticationPasswordSpecified { get; set; }

    }
}
