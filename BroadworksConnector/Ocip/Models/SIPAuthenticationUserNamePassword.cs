using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// User's authentication service information.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SIPAuthenticationUserNamePassword 
    {

        
        private string _sipAuthenticationUserName;

        [XmlElement(ElementName = "sipAuthenticationUserName", IsNullable = false, Namespace = "")]
        public string SipAuthenticationUserName {
            get => _sipAuthenticationUserName;
            set {
                SipAuthenticationUserNameSpecified = true;
                _sipAuthenticationUserName = value;
            }
        }

        [XmlIgnore]
        public bool SipAuthenticationUserNameSpecified { get; set; }
        
        private string _sipAuthenticationPassword;

        [XmlElement(ElementName = "sipAuthenticationPassword", IsNullable = false, Namespace = "")]
        public string SipAuthenticationPassword {
            get => _sipAuthenticationPassword;
            set {
                SipAuthenticationPasswordSpecified = true;
                _sipAuthenticationPassword = value;
            }
        }

        [XmlIgnore]
        public bool SipAuthenticationPasswordSpecified { get; set; }
        
    }
}
