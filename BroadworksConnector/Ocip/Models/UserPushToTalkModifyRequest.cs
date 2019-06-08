using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPushToTalkModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private bool _allowAutoAnswer;

    [XmlElement(ElementName = "allowAutoAnswer", IsNullable = false, Namespace = "")]
    public bool AllowAutoAnswer {
        get => _allowAutoAnswer;
        set {
            AllowAutoAnswerSpecified = true;
            _allowAutoAnswer = value;
        }
    }

    [XmlIgnore]
    public bool AllowAutoAnswerSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.PushToTalkOutgoingConnectionSelection _outgoingConnectionSelection;

    [XmlElement(ElementName = "outgoingConnectionSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.PushToTalkOutgoingConnectionSelection OutgoingConnectionSelection {
        get => _outgoingConnectionSelection;
        set {
            OutgoingConnectionSelectionSpecified = true;
            _outgoingConnectionSelection = value;
        }
    }

    [XmlIgnore]
    public bool OutgoingConnectionSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.PushToTalkAccessListSelection _accessListSelection;

    [XmlElement(ElementName = "accessListSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.PushToTalkAccessListSelection AccessListSelection {
        get => _accessListSelection;
        set {
            AccessListSelectionSpecified = true;
            _accessListSelection = value;
        }
    }

    [XmlIgnore]
    public bool AccessListSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _selectedUserIdList;

    [XmlElement(ElementName = "selectedUserIdList", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementUserIdList SelectedUserIdList {
        get => _selectedUserIdList;
        set {
            SelectedUserIdListSpecified = true;
            _selectedUserIdList = value;
        }
    }

    [XmlIgnore]
    public bool SelectedUserIdListSpecified { get; set; }
}
}
