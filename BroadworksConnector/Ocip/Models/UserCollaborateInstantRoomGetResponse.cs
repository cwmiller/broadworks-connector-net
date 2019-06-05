using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCollaborateInstantRoomGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
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
    private string _instantRoomStartTime;

    [XmlElement(ElementName = "instantRoomStartTime", IsNullable = false, Namespace = "")]
    public string InstantRoomStartTime {
        get => _instantRoomStartTime;
        set {
            InstantRoomStartTimeSpecified = true;
            _instantRoomStartTime = value;
        }
    }

    [XmlIgnore]
    public bool InstantRoomStartTimeSpecified { get; set; }
    private string _instantRoomEndTime;

    [XmlElement(ElementName = "instantRoomEndTime", IsNullable = false, Namespace = "")]
    public string InstantRoomEndTime {
        get => _instantRoomEndTime;
        set {
            InstantRoomEndTimeSpecified = true;
            _instantRoomEndTime = value;
        }
    }

    [XmlIgnore]
    public bool InstantRoomEndTimeSpecified { get; set; }
}
}
