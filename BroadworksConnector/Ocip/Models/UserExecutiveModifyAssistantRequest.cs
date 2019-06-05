using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserExecutiveModifyAssistantRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private bool _allowOptInOut;

    [XmlElement(ElementName = "allowOptInOut", IsNullable = false, Namespace = "")]
    public bool AllowOptInOut {
        get => _allowOptInOut;
        set {
            AllowOptInOutSpecified = true;
            _allowOptInOut = value;
        }
    }

    [XmlIgnore]
    public bool AllowOptInOutSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ReplacementUserIdList _assistantUserIdList;

    [XmlElement(ElementName = "assistantUserIdList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList AssistantUserIdList {
        get => _assistantUserIdList;
        set {
            AssistantUserIdListSpecified = true;
            _assistantUserIdList = value;
        }
    }

    [XmlIgnore]
    public bool AssistantUserIdListSpecified { get; set; }
}
}
