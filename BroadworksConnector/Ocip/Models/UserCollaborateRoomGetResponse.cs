using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCollaborateRoomGetRequest.
    /// The roomType and roomName parameters are returned for all rooms.
    /// The following parameters are returned for My room and Project Room:
    /// attendeeNotification, endCollaborateRoomSessionOnOwnerExit and
    /// ownerRequired. In addition, the roomSchedule is returned for
    /// Project Room and the instantRoomStartTime and instantRoomEndTime
    /// are returned for Instant Room.
    /// <see cref="UserCollaborateRoomGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""939fd5846dfae8bdf58308d6cb9ebb12:936""}]")]
    public class UserCollaborateRoomGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.CollaborateRoomType _roomType;

        [XmlElement(ElementName = "roomType", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:936")]
        public BroadWorksConnector.Ocip.Models.CollaborateRoomType RoomType
        {
            get => _roomType;
            set
            {
                RoomTypeSpecified = true;
                _roomType = value;
            }
        }

        [XmlIgnore]
        public bool RoomTypeSpecified { get; set; }

        private string _roomName;

        [XmlElement(ElementName = "roomName", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:936")]
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
        public bool RoomNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CollaborateRoomAttendeeNotification _attendeeNotification;

        [XmlElement(ElementName = "attendeeNotification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:936")]
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
        public bool AttendeeNotificationSpecified { get; set; }

        private bool _endCollaborateRoomSessionOnOwnerExit;

        [XmlElement(ElementName = "endCollaborateRoomSessionOnOwnerExit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:936")]
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
        public bool EndCollaborateRoomSessionOnOwnerExitSpecified { get; set; }

        private bool _ownerRequired;

        [XmlElement(ElementName = "ownerRequired", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:936")]
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
        public bool OwnerRequiredSpecified { get; set; }

        private string _instantRoomStartTime;

        [XmlElement(ElementName = "instantRoomStartTime", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:936")]
        public string InstantRoomStartTime
        {
            get => _instantRoomStartTime;
            set
            {
                InstantRoomStartTimeSpecified = true;
                _instantRoomStartTime = value;
            }
        }

        [XmlIgnore]
        public bool InstantRoomStartTimeSpecified { get; set; }

        private string _instantRoomEndTime;

        [XmlElement(ElementName = "instantRoomEndTime", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:936")]
        public string InstantRoomEndTime
        {
            get => _instantRoomEndTime;
            set
            {
                InstantRoomEndTimeSpecified = true;
                _instantRoomEndTime = value;
            }
        }

        [XmlIgnore]
        public bool InstantRoomEndTimeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CollaborateRoomSchedule _roomSchedule;

        [XmlElement(ElementName = "roomSchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:936")]
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
        public bool RoomScheduleSpecified { get; set; }

    }
}
