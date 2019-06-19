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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:3877""}]")]
    public class AuthenticationResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3877")]
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
        public bool UserIdSpecified { get; set; }

        private string _nonce;

        [XmlElement(ElementName = "nonce", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3877")]
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
        public bool NonceSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DigitalSignatureAlgorithm _passwordAlgorithm;

        [XmlElement(ElementName = "passwordAlgorithm", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3877")]
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
        public bool PasswordAlgorithmSpecified { get; set; }

    }
}
