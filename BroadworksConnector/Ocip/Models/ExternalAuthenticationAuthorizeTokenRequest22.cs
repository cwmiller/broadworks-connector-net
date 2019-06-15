using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This command is part of the Portal API.
    /// Sent when a Web or CLI user logs in using external authentication.
    /// The hashed password value in the request is supported only when the request is sent from the CommPilot web portal.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ExternalAuthenticationAuthorizeTokenRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private bool _isPasswordHashed;

        [XmlElement(ElementName = "isPasswordHashed", IsNullable = false, Namespace = "")]
        public bool IsPasswordHashed {
            get => _isPasswordHashed;
            set {
                IsPasswordHashedSpecified = true;
                _isPasswordHashed = value;
            }
        }

        [XmlIgnore]
        public bool IsPasswordHashedSpecified { get; set; }
        
        private string _loginToken;

        [XmlElement(ElementName = "loginToken", IsNullable = false, Namespace = "")]
        public string LoginToken {
            get => _loginToken;
            set {
                LoginTokenSpecified = true;
                _loginToken = value;
            }
        }

        [XmlIgnore]
        public bool LoginTokenSpecified { get; set; }
        
    }
}
