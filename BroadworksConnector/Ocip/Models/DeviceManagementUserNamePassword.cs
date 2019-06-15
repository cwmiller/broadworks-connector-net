using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Access device credentials.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class DeviceManagementUserNamePassword 
    {

        
        private string _userName;

        [XmlElement(ElementName = "userName", IsNullable = false, Namespace = "")]
        public string UserName {
            get => _userName;
            set {
                UserNameSpecified = true;
                _userName = value;
            }
        }

        [XmlIgnore]
        public bool UserNameSpecified { get; set; }
        
        private string _password;

        [XmlElement(ElementName = "password", IsNullable = false, Namespace = "")]
        public string Password {
            get => _password;
            set {
                PasswordSpecified = true;
                _password = value;
            }
        }

        [XmlIgnore]
        public bool PasswordSpecified { get; set; }
        
    }
}
