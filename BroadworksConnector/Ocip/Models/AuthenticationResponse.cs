using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// AuthenticationRequest/Response is 1st stage of the 2 stage OCI login process.
    /// <see cref="AuthenticationRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:340""}]")]
    public class AuthenticationResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:340")]
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

        protected string _nonce;

        [XmlElement(ElementName = "nonce", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:340")]
        public string Nonce
        {
            get => _nonce;
            set
            {
                NonceSpecified = true;
                _nonce = value;
            }
        }

        [XmlIgnore]
        protected bool NonceSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DigitalSignatureAlgorithm _passwordAlgorithm;

        [XmlElement(ElementName = "passwordAlgorithm", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:340")]
        public BroadWorksConnector.Ocip.Models.DigitalSignatureAlgorithm PasswordAlgorithm
        {
            get => _passwordAlgorithm;
            set
            {
                PasswordAlgorithmSpecified = true;
                _passwordAlgorithm = value;
            }
        }

        [XmlIgnore]
        protected bool PasswordAlgorithmSpecified { get; set; }

    }
}
