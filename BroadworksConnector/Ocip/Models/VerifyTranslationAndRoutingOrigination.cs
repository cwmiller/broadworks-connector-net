using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class VerifyTranslationAndRoutingOrigination 
{
    private string _linePort;

    [XmlElement(ElementName = "linePort", IsNullable = false, Namespace = "")]
    public string LinePort {
        get => _linePort;
        set {
            LinePortSpecified = true;
            _linePort = value;
        }
    }

    [XmlIgnore]
    public bool LinePortSpecified { get; set; }
    private string _phone;

    [XmlElement(ElementName = "phone", IsNullable = false, Namespace = "")]
    public string Phone {
        get => _phone;
        set {
            PhoneSpecified = true;
            _phone = value;
        }
    }

    [XmlIgnore]
    public bool PhoneSpecified { get; set; }
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
    private string _url;

    [XmlElement(ElementName = "url", IsNullable = false, Namespace = "")]
    public string Url {
        get => _url;
        set {
            UrlSpecified = true;
            _url = value;
        }
    }

    [XmlIgnore]
    public bool UrlSpecified { get; set; }
}
}
