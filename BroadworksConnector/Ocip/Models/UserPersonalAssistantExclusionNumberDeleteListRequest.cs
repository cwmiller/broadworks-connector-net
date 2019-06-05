using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPersonalAssistantExclusionNumberDeleteListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<string> _exclusionNumber;

    [XmlElement(ElementName = "exclusionNumber", IsNullable = false, Namespace = "")]
    public List<string> ExclusionNumber {
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
