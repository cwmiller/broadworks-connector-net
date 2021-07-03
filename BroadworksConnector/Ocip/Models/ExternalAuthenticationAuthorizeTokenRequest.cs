using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This command is part of the Portal API.
    /// Sent when a Web or CLI user logs in using external authentication.
    /// The password must be hashed. The password hashing algorithm is:
    /// 1) The message digest of the user's plain password is calculated using the SHA algorithm.
    /// 2) For every four bits in the 160-bit digest, starting from the first bit, it is
    /// converted into a character in ASCII Hex format (0 through 9, a through f).
    /// The result is a 40-character string, for example, f7a9e24777ec23212c54d7a350bc5bea5477fdbb.
    /// 3) The above string then is used to populate the password field in the request.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a8b2edcd7d6936a8b76653949ae59623:62""}]")]
    public class ExternalAuthenticationAuthorizeTokenRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:62")]
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
        [Optional]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:62")]
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

        private string _loginToken;

        [XmlElement(ElementName = "loginToken", IsNullable = false, Namespace = "")]
        [Group(@"a8b2edcd7d6936a8b76653949ae59623:62")]
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

    }
}
