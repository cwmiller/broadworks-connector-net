using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's authentication service information.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9db4d5fa1bbf70f2626f52a5d6e3420e:72"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""9db4d5fa1bbf70f2626f52a5d6e3420e:75""}]}]")]
    public class UserAuthenticationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"9db4d5fa1bbf70f2626f52a5d6e3420e:72")]
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

        private string _userName;

        [XmlElement(ElementName = "userName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9db4d5fa1bbf70f2626f52a5d6e3420e:72")]
        [MinLength(1)]
        [MaxLength(80)]
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
        protected bool UserNameSpecified { get; set; }

        private string _newPassword;

        [XmlElement(ElementName = "newPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9db4d5fa1bbf70f2626f52a5d6e3420e:75")]
        [MinLength(1)]
        [MaxLength(60)]
        public string NewPassword
        {
            get => _newPassword;
            set
            {
                NewPasswordSpecified = true;
                _newPassword = value;
            }
        }

        [XmlIgnore]
        protected bool NewPasswordSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.UserAuthenticationModifyRequestPassword _password;

        [XmlElement(ElementName = "password", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9db4d5fa1bbf70f2626f52a5d6e3420e:75")]
        public BroadWorksConnector.Ocip.Models.UserAuthenticationModifyRequestPassword Password
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

    }
}
