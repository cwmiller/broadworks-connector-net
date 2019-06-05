using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCollaborateRoomGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.CollaborateRoomType _roomType;

    [XmlElement(ElementName = "roomType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CollaborateRoomType RoomType {
        get => _roomType;
        set {
            RoomTypeSpecified = true;
            _roomType = value;
        }
    }

    [XmlIgnore]
    public bool RoomTypeSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.CollaborateRoomAttendeeNotification _attendeeNotification;

    [XmlElement(ElementName = "attendeeNotification", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CollaborateRoomAttendeeNotification AttendeeNotification {
        get => _attendeeNotification;
        set {
            AttendeeNotificationSpecified = true;
            _attendeeNotification = value;
        }
    }

    [XmlIgnore]
    public bool AttendeeNotificationSpecified { get; set; }
    private bool _endCollaborateRoomSessionOnOwnerExit;

    [XmlElement(ElementName = "endCollaborateRoomSessionOnOwnerExit", IsNullable = false, Namespace = "")]
    public bool EndCollaborateRoomSessionOnOwnerExit {
        get => _endCollaborateRoomSessionOnOwnerExit;
        set {
            EndCollaborateRoomSessionOnOwnerExitSpecified = true;
            _endCollaborateRoomSessionOnOwnerExit = value;
        }
    }

    [XmlIgnore]
    public bool EndCollaborateRoomSessionOnOwnerExitSpecified { get; set; }
    private bool _ownerRequired;

    [XmlElement(ElementName = "ownerRequired", IsNullable = false, Namespace = "")]
    public bool OwnerRequired {
        get => _ownerRequired;
        set {
            OwnerRequiredSpecified = true;
            _ownerRequired = value;
        }
    }

    [XmlIgnore]
    public bool OwnerRequiredSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.CollaborateRoomSchedule _roomSchedule;

    [XmlElement(ElementName = "roomSchedule", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CollaborateRoomSchedule RoomSchedule {
        get => _roomSchedule;
        set {
            RoomScheduleSpecified = true;
            _roomSchedule = value;
        }
    }

    [XmlIgnore]
    public bool RoomScheduleSpecified { get; set; }
}
}
