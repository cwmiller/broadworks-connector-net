using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// AuthenticationVerifyRequest14sp8 is used to authenticate a user either by userId/password, userId/sip
    /// username/sip password,
    /// dn/passcode or a token previously authorized with the ExternalAuthenticationAuthorizeTokenRequest.
    /// The phone number may be any DN associated with a user.
    /// 
    /// The response is a AuthenticationVerifyResponse14sp8 or an ErrorResponse
    /// 
    /// Replaced by AuthenticationVerifyRequest22.
        /// <see cref="AuthenticationVerifyRequest14sp8"/>
        /// <see cref="ExternalAuthenticationAuthorizeTokenRequest"/>
        /// <see cref="AuthenticationVerifyResponse14sp8"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="AuthenticationVerifyRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class AuthenticationVerifyRequest14sp8 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        public string PhoneNumber {
            get => _phoneNumber;
            set {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberSpecified { get; set; }
        
        private string _passcode;

        [XmlElement(ElementName = "passcode", IsNullable = false, Namespace = "")]
        public string Passcode {
            get => _passcode;
            set {
                PasscodeSpecified = true;
                _passcode = value;
            }
        }

        [XmlIgnore]
        public bool PasscodeSpecified { get; set; }
        
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
