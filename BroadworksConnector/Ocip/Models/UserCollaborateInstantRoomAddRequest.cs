using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCollaborateInstantRoomAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _roomName;

    [XmlElement(ElementName = "roomName", IsNullable = false, Namespace = "")]
    public string RoomName {
        get => _roomName;
        set {
            RoomNameSpecified = true;
            _roomName = value;
        }
    }

    [XmlIgnore]
    public bool RoomNameSpecified { get; set; }
    private bool _useRoomIdAsRoomName;

    [XmlElement(ElementName = "useRoomIdAsRoomName", IsNullable = false, Namespace = "")]
    public bool UseRoomIdAsRoomName {
        get => _useRoomIdAsRoomName;
        set {
            UseRoomIdAsRoomNameSpecified = true;
            _useRoomIdAsRoomName = value;
        }
    }

    [XmlIgnore]
    public bool UseRoomIdAsRoomNameSpecified { get; set; }
}
}
