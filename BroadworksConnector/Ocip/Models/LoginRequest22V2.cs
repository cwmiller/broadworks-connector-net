using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to login to OCI.
    /// password is not required for external authentication login from a trusted host (ACL).
    /// The response is either LoginResponse22V2 or ErrorResponse
    /// 
    /// Replaced by LoginRequest22V3 in AS data mode.
        /// <see cref="LoginResponse22V2"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="LoginRequest22V3"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class LoginRequest22V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
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
