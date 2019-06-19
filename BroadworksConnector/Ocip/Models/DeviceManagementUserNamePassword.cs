using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Access device credentials.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:43647""}]")]
    public class DeviceManagementUserNamePassword
    {

        private string _userName;

        [XmlElement(ElementName = "userName", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:43647")]
        [MinLength(1)]
        [MaxLength(30)]
        public string UserName
        {
            get => _userName;
            set
            {
                UserNameSpecified = true;
                _userName = value;
            }
        }

        [XmlIgnore]
        public bool UserNameSpecified { get; set; }

        private string _password;

        [XmlElement(ElementName = "password", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:43647")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Password
        {
            get => _password;
            set
            {
                PasswordSpecified = true;
                _password = value;
            }
        }

        [XmlIgnore]
        public bool PasswordSpecified { get; set; }

    }
}
