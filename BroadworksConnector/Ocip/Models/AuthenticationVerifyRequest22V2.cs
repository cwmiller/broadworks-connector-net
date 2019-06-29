using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// AuthenticationVerifyRequest22V2 is used to authenticate a user either by userId/password, userId/sip username/sip password,
    /// dn/passcode, lineport/password or a token previously authorized with the ExternalAuthenticationAuthorizeTokenRequest.
    /// The phone number may be any DN associated with a user.
    /// The lineport may be any lineport associated with a user.
    /// The password used for the lineport is the user's password associated with userId.
    /// 
    /// The response is a AuthenticationVerifyResponse22V2 or an ErrorResponse
    /// <see cref="AuthenticationVerifyRequest22V2"/>
    /// <see cref="ExternalAuthenticationAuthorizeTokenRequest"/>
    /// <see cref="AuthenticationVerifyResponse22V2"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:60"",""children"":[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:61""},{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:65""},{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:69""},{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:73""},{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:76""}]}]")]
    public class AuthenticationVerifyRequest22V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:76")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        private string _password;

        [XmlElement(ElementName = "password", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:69")]
        [MinLength(1)]
        [MaxLength(60)]
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
        protected bool PasswordSpecified { get; set; }

        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:65")]
        [MinLength(1)]
        [MaxLength(23)]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool PhoneNumberSpecified { get; set; }

        private string _passcode;

        [XmlElement(ElementName = "passcode", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:65")]
        [MinLength(1)]
        [MaxLength(30)]
        public string Passcode
        {
            get => _passcode;
            set
            {
                PasscodeSpecified = true;
                _passcode = value;
            }
        }

        [XmlIgnore]
        protected bool PasscodeSpecified { get; set; }

        private string _linePort;

        [XmlElement(ElementName = "linePort", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:69")]
        [MinLength(1)]
        [MaxLength(161)]
        public string LinePort
        {
            get => _linePort;
            set
            {
                LinePortSpecified = true;
                _linePort = value;
            }
        }

        [XmlIgnore]
        protected bool LinePortSpecified { get; set; }

        private string _loginToken;

        [XmlElement(ElementName = "loginToken", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:73")]
        [MinLength(1)]
        public string LoginToken
        {
            get => _loginToken;
            set
            {
                LoginTokenSpecified = true;
                _loginToken = value;
            }
        }

        [XmlIgnore]
        protected bool LoginTokenSpecified { get; set; }

        private string _sipAuthenticationUserName;

        [XmlElement(ElementName = "sipAuthenticationUserName", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:76")]
        [MinLength(1)]
        [MaxLength(80)]
        public string SipAuthenticationUserName
        {
            get => _sipAuthenticationUserName;
            set
            {
                SipAuthenticationUserNameSpecified = true;
                _sipAuthenticationUserName = value;
            }
        }

        [XmlIgnore]
        protected bool SipAuthenticationUserNameSpecified { get; set; }

        private string _sipAuthenticationPassword;

        [XmlElement(ElementName = "sipAuthenticationPassword", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:76")]
        [MinLength(1)]
        [MaxLength(60)]
        public string SipAuthenticationPassword
        {
            get => _sipAuthenticationPassword;
            set
            {
                SipAuthenticationPasswordSpecified = true;
                _sipAuthenticationPassword = value;
            }
        }

        [XmlIgnore]
        protected bool SipAuthenticationPasswordSpecified { get; set; }

    }
}
