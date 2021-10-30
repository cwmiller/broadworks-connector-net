using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add collaborate instant room.
    /// The response is either a UserCollaborateInstantRoomAddResponse or an ErrorResponse.
    /// <see cref="UserCollaborateInstantRoomAddResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""939fd5846dfae8bdf58308d6cb9ebb12:632"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""939fd5846dfae8bdf58308d6cb9ebb12:634""}]}]")]
    public class UserCollaborateInstantRoomAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserCollaborateInstantRoomAddResponse>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:632")]
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

        private string _roomName;

        [XmlElement(ElementName = "roomName", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:634")]
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

        private bool _useRoomIdAsRoomName;

        [XmlElement(ElementName = "useRoomIdAsRoomName", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:634")]
        public bool UseRoomIdAsRoomName
        {
            get => _useRoomIdAsRoomName;
            set
            {
                UseRoomIdAsRoomNameSpecified = true;
                _useRoomIdAsRoomName = value;
            }
        }

        [XmlIgnore]
        protected bool UseRoomIdAsRoomNameSpecified { get; set; }

    }
}
