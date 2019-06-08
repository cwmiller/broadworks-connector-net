using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class AuthenticationResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
    private string _nonce;

    [XmlElement(ElementName = "nonce", IsNullable = false, Namespace = "")]
    public string Nonce {
        get => _nonce;
        set {
            NonceSpecified = true;
            _nonce = value;
        }
    }

    [XmlIgnore]
    public bool NonceSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.DigitalSignatureAlgorithm _passwordAlgorithm;

    [XmlElement(ElementName = "passwordAlgorithm", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DigitalSignatureAlgorithm PasswordAlgorithm {
        get => _passwordAlgorithm;
        set {
            PasswordAlgorithmSpecified = true;
            _passwordAlgorithm = value;
        }
    }

    [XmlIgnore]
    public bool PasswordAlgorithmSpecified { get; set; }
}
}
