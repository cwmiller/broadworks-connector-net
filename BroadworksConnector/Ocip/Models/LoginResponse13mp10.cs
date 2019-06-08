using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class LoginResponse13mp10 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.LoginType _loginType;

    [XmlElement(ElementName = "loginType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.LoginType LoginType {
        get => _loginType;
        set {
            LoginTypeSpecified = true;
            _loginType = value;
        }
    }

    [XmlIgnore]
    public bool LoginTypeSpecified { get; set; }
    private string _locale;

    [XmlElement(ElementName = "locale", IsNullable = false, Namespace = "")]
    public string Locale {
        get => _locale;
        set {
            LocaleSpecified = true;
            _locale = value;
        }
    }

    [XmlIgnore]
    public bool LocaleSpecified { get; set; }
    private string _encoding;

    [XmlElement(ElementName = "encoding", IsNullable = false, Namespace = "")]
    public string Encoding {
        get => _encoding;
        set {
            EncodingSpecified = true;
            _encoding = value;
        }
    }

    [XmlIgnore]
    public bool EncodingSpecified { get; set; }
}
}
