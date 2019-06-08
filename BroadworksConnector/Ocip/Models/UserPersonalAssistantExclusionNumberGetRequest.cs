using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPersonalAssistantExclusionNumberGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _exclusionNumber;

    [XmlElement(ElementName = "exclusionNumber", IsNullable = false, Namespace = "")]
    public string ExclusionNumber {
        get => _exclusionNumber;
        set {
            ExclusionNumberSpecified = true;
            _exclusionNumber = value;
        }
    }

    [XmlIgnore]
    public bool ExclusionNumberSpecified { get; set; }
}
}
