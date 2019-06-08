using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSecurityClassificationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _securityClassification;

    [XmlElement(ElementName = "securityClassification", IsNullable = true, Namespace = "")]
    public string SecurityClassification {
        get => _securityClassification;
        set {
            SecurityClassificationSpecified = true;
            _securityClassification = value;
        }
    }

    [XmlIgnore]
    public bool SecurityClassificationSpecified { get; set; }
}
}
