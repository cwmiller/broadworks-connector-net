using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserNumberPortabilityAnnouncementModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private bool _enable;

    [XmlElement(ElementName = "enable", IsNullable = false, Namespace = "")]
    public bool Enable {
        get => _enable;
        set {
            EnableSpecified = true;
            _enable = value;
        }
    }

    [XmlIgnore]
    public bool EnableSpecified { get; set; }
}
}
