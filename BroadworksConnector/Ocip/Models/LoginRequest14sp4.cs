using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// LoginRequest14sp4 is 2nd stage of the 2 stage OCI login process.
    /// The signedPassword is not required for external authentication login from a trusted host (ACL).
    /// The response is either LoginResponse14sp4 or ErrorResponse
    /// 
    /// Replaced by: LoginRequest22 in AS data mode.
        /// <see cref="LoginRequest14sp4"/>
        /// <see cref="LoginResponse14sp4"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="LoginRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class LoginRequest14sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private string _signedPassword;

        [XmlElement(ElementName = "signedPassword", IsNullable = false, Namespace = "")]
        public string SignedPassword {
            get => _signedPassword;
            set {
                SignedPasswordSpecified = true;
                _signedPassword = value;
            }
        }

        [XmlIgnore]
        public bool SignedPasswordSpecified { get; set; }
        
        private string _plainTextPassword;

        [XmlElement(ElementName = "plainTextPassword", IsNullable = false, Namespace = "")]
        public string PlainTextPassword {
            get => _plainTextPassword;
            set {
                PlainTextPasswordSpecified = true;
                _plainTextPassword = value;
            }
        }

        [XmlIgnore]
        public bool PlainTextPasswordSpecified { get; set; }
        
    }
}
