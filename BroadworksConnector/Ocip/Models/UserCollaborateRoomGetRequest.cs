using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCollaborateRoomGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _roomId;

    [XmlElement(ElementName = "roomId", IsNullable = false, Namespace = "")]
    public string RoomId {
        get => _roomId;
        set {
            RoomIdSpecified = true;
            _roomId = value;
        }
    }

    [XmlIgnore]
    public bool RoomIdSpecified { get; set; }
}
}
