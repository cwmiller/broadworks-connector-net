using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify collaborate room settings for a project room.
    /// The request fails when modifying collaborate room settings for instant rooms or My Room.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""939fd5846dfae8bdf58308d6cb9ebb12:884""}]")]
    public class UserCollaborateProjectRoomModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:884")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        private string _roomId;

        [XmlElement(ElementName = "roomId", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:884")]
        [MinLength(4)]
        [MaxLength(15)]
        public string RoomId
        {
            get => _roomId;
            set
            {
                RoomIdSpecified = true;
                _roomId = value;
            }
        }

        [XmlIgnore]
        protected bool RoomIdSpecified { get; set; }

        private string _roomName;

        [XmlElement(ElementName = "roomName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:884")]
        [MinLength(1)]
        [MaxLength(40)]
        public string RoomName
        {
            get => _roomName;
            set
            {
                RoomNameSpecified = true;
                _roomName = value;
            }
        }

        [XmlIgnore]
        protected bool RoomNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CollaborateRoomAttendeeNotification _attendeeNotification;

        [XmlElement(ElementName = "attendeeNotification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:884")]
        public BroadWorksConnector.Ocip.Models.CollaborateRoomAttendeeNotification AttendeeNotification
        {
            get => _attendeeNotification;
            set
            {
                AttendeeNotificationSpecified = true;
                _attendeeNotification = value;
            }
        }

        [XmlIgnore]
        protected bool AttendeeNotificationSpecified { get; set; }

        private bool _endCollaborateRoomSessionOnOwnerExit;

        [XmlElement(ElementName = "endCollaborateRoomSessionOnOwnerExit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:884")]
        public bool EndCollaborateRoomSessionOnOwnerExit
        {
            get => _endCollaborateRoomSessionOnOwnerExit;
            set
            {
                EndCollaborateRoomSessionOnOwnerExitSpecified = true;
                _endCollaborateRoomSessionOnOwnerExit = value;
            }
        }

        [XmlIgnore]
        protected bool EndCollaborateRoomSessionOnOwnerExitSpecified { get; set; }

        private bool _ownerRequired;

        [XmlElement(ElementName = "ownerRequired", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:884")]
        public bool OwnerRequired
        {
            get => _ownerRequired;
            set
            {
                OwnerRequiredSpecified = true;
                _ownerRequired = value;
            }
        }

        [XmlIgnore]
        protected bool OwnerRequiredSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CollaborateRoomSchedule _roomSchedule;

        [XmlElement(ElementName = "roomSchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:884")]
        public BroadWorksConnector.Ocip.Models.CollaborateRoomSchedule RoomSchedule
        {
            get => _roomSchedule;
            set
            {
                RoomScheduleSpecified = true;
                _roomSchedule = value;
            }
        }

        [XmlIgnore]
        protected bool RoomScheduleSpecified { get; set; }

    }
}
