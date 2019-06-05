using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserModifyGroupIdRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _newGroupId;

    [XmlElement(ElementName = "newGroupId", IsNullable = false, Namespace = "")]
    public string NewGroupId {
        get => _newGroupId;
        set {
            NewGroupIdSpecified = true;
            _newGroupId = value;
        }
    }

    [XmlIgnore]
    public bool NewGroupIdSpecified { get; set; }
    private bool _evaluateOnly;

    [XmlElement(ElementName = "evaluateOnly", IsNullable = false, Namespace = "")]
    public bool EvaluateOnly {
        get => _evaluateOnly;
        set {
            EvaluateOnlySpecified = true;
            _evaluateOnly = value;
        }
    }

    [XmlIgnore]
    public bool EvaluateOnlySpecified { get; set; }
}
}
