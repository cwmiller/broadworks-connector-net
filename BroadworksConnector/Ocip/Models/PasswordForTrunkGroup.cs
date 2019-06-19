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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:837""}]")]
    public class PasswordForTrunkGroup
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:837")]
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
        [Group(@"6b27fcc79475236456fc113a42b75543:837")]
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

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6b27fcc79475236456fc113a42b75543:837")]
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
        public bool NameSpecified { get; set; }

        private bool _generateTrunkGroupAuthenticationPassword;

        [XmlElement(ElementName = "generateTrunkGroupAuthenticationPassword", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:837")]
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
        public bool GenerateTrunkGroupAuthenticationPasswordSpecified { get; set; }

    }
}
