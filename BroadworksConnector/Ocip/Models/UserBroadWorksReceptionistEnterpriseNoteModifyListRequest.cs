using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksReceptionistEnterpriseNoteModifyListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _receptionistUserId;

    [XmlElement(ElementName = "receptionistUserId", IsNullable = false, Namespace = "")]
    public string ReceptionistUserId {
        get => _receptionistUserId;
        set {
            ReceptionistUserIdSpecified = true;
            _receptionistUserId = value;
        }
    }

    [XmlIgnore]
    public bool ReceptionistUserIdSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.ReceptionistContactUserAndNote> _receptionistUserAndNote;

    [XmlElement(ElementName = "receptionistUserAndNote", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.ReceptionistContactUserAndNote> ReceptionistUserAndNote {
        get => _receptionistUserAndNote;
        set {
            ReceptionistUserAndNoteSpecified = true;
            _receptionistUserAndNote = value;
        }
    }

    [XmlIgnore]
    public bool ReceptionistUserAndNoteSpecified { get; set; }
}
}
