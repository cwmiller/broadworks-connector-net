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
    /// The response is either LoginResponse14sp4 or ErrorResponse
    /// <see cref="LoginRequest14sp4"/>
    /// <see cref="LoginResponse14sp4"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:16826""}]")]
    public class LoginRequest14sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.LoginResponse14sp4>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:16826")]
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

        protected string _signedPassword;

        [XmlElement(ElementName = "signedPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16826")]
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

        protected string _plainTextPassword;

        [XmlElement(ElementName = "plainTextPassword", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:16826")]
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
