using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallParkGetInstancePagedSortedResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _recallAlternateUserId;

    [XmlElement(ElementName = "recallAlternateUserId", IsNullable = false, Namespace = "")]
    public string RecallAlternateUserId {
        get => _recallAlternateUserId;
        set {
            RecallAlternateUserIdSpecified = true;
            _recallAlternateUserId = value;
        }
    }

    [XmlIgnore]
    public bool RecallAlternateUserIdSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallParkRecallTo _recallTo;

    [XmlElement(ElementName = "recallTo", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallParkRecallTo RecallTo {
        get => _recallTo;
        set {
            RecallToSpecified = true;
            _recallTo = value;
        }
    }

    [XmlIgnore]
    public bool RecallToSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.C.OCITable _userTable;

    [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable UserTable {
        get => _userTable;
        set {
            UserTableSpecified = true;
            _userTable = value;
        }
    }

    [XmlIgnore]
    public bool UserTableSpecified { get; set; }
}
}
