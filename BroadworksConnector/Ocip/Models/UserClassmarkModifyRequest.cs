using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserClassmarkModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _classmark;

    [XmlElement(ElementName = "classmark", IsNullable = true, Namespace = "")]
    public string Classmark {
        get => _classmark;
        set {
            ClassmarkSpecified = true;
            _classmark = value;
        }
    }

    [XmlIgnore]
    public bool ClassmarkSpecified { get; set; }
}
}
