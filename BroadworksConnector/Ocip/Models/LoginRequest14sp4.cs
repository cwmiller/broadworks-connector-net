using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// LoginRequest14sp4 is 2nd stage of the 2 stage OCI login process.
    /// The signedPassword is not required for external authentication login from a trusted host (ACL).
    /// 
    /// The response is either a LoginResponse14sp4 or an ErrorResponse.
    /// <see cref="LoginRequest14sp4"/>
    /// <see cref="LoginResponse14sp4"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:16396""}]")]
    public class LoginRequest14sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest<LoginResponse14sp4>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16396")]
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

        private string _signedPassword;

        [XmlElement(ElementName = "signedPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16396")]
        [MinLength(1)]
        public string SignedPassword
        {
            get => _signedPassword;
            set
            {
                SignedPasswordSpecified = true;
                _signedPassword = value;
            }
        }

        [XmlIgnore]
        protected bool SignedPasswordSpecified { get; set; }

        private string _plainTextPassword;

        [XmlElement(ElementName = "plainTextPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16396")]
        [MinLength(1)]
        [MaxLength(60)]
        public string PlainTextPassword
        {
            get => _plainTextPassword;
            set
            {
                PlainTextPasswordSpecified = true;
                _plainTextPassword = value;
            }
        }

        [XmlIgnore]
        protected bool PlainTextPasswordSpecified { get; set; }

    }
}
