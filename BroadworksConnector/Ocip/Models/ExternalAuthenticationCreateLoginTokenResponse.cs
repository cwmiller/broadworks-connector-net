using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ExternalAuthenticationCreateLoginTokenResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
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
