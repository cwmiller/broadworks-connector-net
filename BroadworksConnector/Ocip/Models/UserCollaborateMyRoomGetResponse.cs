using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCollaborateMyRoomGetRequest.
        /// <see cref="UserCollaborateMyRoomGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCollaborateMyRoomGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
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
        
        private BroadWorksConnector.Ocip.Models.CollaborateRoomAttendeeNotification _attendeeNotification;

        [XmlElement(ElementName = "attendeeNotification", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CollaborateRoomAttendeeNotification AttendeeNotification {
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
