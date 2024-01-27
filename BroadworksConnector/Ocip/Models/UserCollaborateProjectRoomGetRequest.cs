using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request collaborate room settings for a project room.
    /// The request fails when requesting collaborate room settings for instant rooms or My Room.
    /// The response is either UserCollaborateProjectRoomGetResponse or
    /// ErrorResponse.
    /// <see cref="UserCollaborateProjectRoomGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""bc805893b9cc7e3e01eec64e9ad62768:849""}]")]
    public class UserCollaborateProjectRoomGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserCollaborateProjectRoomGetResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"bc805893b9cc7e3e01eec64e9ad62768:849")]
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

        protected string _roomId;

        [XmlElement(ElementName = "roomId", IsNullable = false, Namespace = "")]
        [Group(@"bc805893b9cc7e3e01eec64e9ad62768:849")]
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

    }
}
