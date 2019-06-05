using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCollaborateMyRoomModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
}
}
